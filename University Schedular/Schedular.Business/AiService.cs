using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Schedular.ViewModels;
using System;
using System.Collections.Generic;
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
            // کل جدول فعلی
            string schedulesJson = JsonConvert.SerializeObject(currentSchedules, Formatting.Indented);

            // پرامپت هوشمند
            var prompt = $@"
تو یک برنامه‌ریز دانشگاهی هستی.
وظیفه‌ات اینه که برنامه درسی جدید پیشنهاد بدی.

ورودی:
- نام درس: {courseTitle}
- نام استاد: {teacherName}
- شماره گروه: {classGroup}
- تعداد کلاس‌ها: {count}
- نوع پخش: {(distributionType == "spread" ? "در طول هفته پخش شود" : "فشرده در یک روز باشد")}
- برنامه‌های فعلی (برای جلوگیری از تداخل):
{schedulesJson}

قوانین:
1. کلاس‌های گروه مشترک نباید با هم تداخل داشته باشند.
2. رعایت نوع پخش (spread یا compact).
3. فرمت خروجی فقط JSON آرایه باشد، هیچ متن اضافی ننویس.
4. هر آیتم باید شامل این خصوصیات باشد:
   DayOfWeek, StartTime, EndTime, CourseTitle, TeacherName, ClassGroup.
5.بر اساس تعداد واحد زمان شروع و پایان رو طوری بذار که برای:
،دروس 3 واحد بازه زمانی 2 ساعت و 30 دقیقه
دروس 2 واحدی 1 ساعت و 40 دقیقه و
دروس 1 واحدی هم 1 ساعت و 40 دقیقه باشه
";

            var body = new
            {
                model = "gemini-1.5-flash",
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
            if (content.StartsWith("```"))
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
