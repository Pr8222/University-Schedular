using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Schedular.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Business
{
    public class AiService : IAiService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://generativelanguage.googleapis.com/v1beta/openai/";

        public AiService(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey), "Gemini API key is required.");

            _apiKey = apiKey;

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }

        public async Task<List<CourseScheduleViewModel>> SuggestSchedulesAsync(
            List<CourseScheduleViewModel> currentSchedules,
            string teacherName,
            string courseTitle,
            int classGroup,
            int count,
            string distributionType
        )
        {

            var relevantSchedules = currentSchedules
                .Where(s => s.TeacherName == teacherName || s.ClassGroup == classGroup)
                .Select(s => new
                {
                    s.DayOfWeek,
                    s.StartTime,
                    s.EndTime,
                    s.TeacherName,
                    s.ClassGroup
                })
                .ToList();

            string schedulesJson = JsonConvert.SerializeObject(relevantSchedules);

            var prompt = $@"
تو یک برنامه‌ریز دانشگاهی هستی.
با توجه به اطلاعات زیر، یک برنامه‌ی جدید پیشنهاد بده.

درس: {courseTitle}
استاد: {teacherName}
گروه: {classGroup}
تعداد کلاس‌ها: {count}
نوع پخش: {(distributionType == "spread" ? "پخش در هفته" : "فشرده در یک روز")}
برنامه‌های فعلی مرتبط:
{schedulesJson}

قوانین:
1. کلاس‌های استاد یا گروه نباید تداخل زمانی داشته باشند.
2. نوع پخش رعایت شود (spread = پخش، compact = فشرده در یک روز).
3. فقط خروجی JSON آرایه‌ای بده (بدون توضیح).
4. هر کلاس شامل: DayOfWeek، StartTime، EndTime، CourseTitle، TeacherName، ClassGroup باشد.
5. زمان کلاس‌ها:
   - 3 واحد = 2:30
   - 2 واحد = 1:40
   - 1 واحد = 1:40
6. شروع از 08:00 و پایان حداکثر 20:00.
7. روزها به فارسی باشد.
";

            var body = new
            {
                model = "gemini-2.5-flash",
                messages = new[]
                {
                    new { role = "system", content = "You are an expert in academic schedule planning." },
                    new { role = "user", content = prompt }
                }
            };

            var requestJson = JsonConvert.SerializeObject(body);

            var response = await _httpClient.PostAsync(
                $"{_baseUrl}chat/completions",
                new StringContent(requestJson, Encoding.UTF8, "application/json")
            );

            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Gemini API error: {response.StatusCode}, {responseString}");

            var root = JObject.Parse(responseString);
            var content = root["choices"]?[0]?["message"]?["content"]?.ToString();
            if (!string.IsNullOrWhiteSpace(content) && content.StartsWith("```"))
            {
                int start = content.IndexOf("[");
                int end = content.LastIndexOf("]");
                content = content.Substring(start, end - start + 1);
            }

            if (string.IsNullOrWhiteSpace(content))
                throw new Exception("No content returned from Gemini API.");

            return JsonConvert.DeserializeObject<List<CourseScheduleViewModel>>(content)
                   ?? new List<CourseScheduleViewModel>();
        }
    }
}
