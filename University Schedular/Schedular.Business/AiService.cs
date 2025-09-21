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
            string schedulesJson = JsonConvert.SerializeObject(currentSchedules, Formatting.Indented);

            var prompt = $@"
تو یک برنامه‌ریز دانشگاهی هستی.
وظیفه‌ات این است که برای دروس، برنامه درسی جدید پیشنهاد بدهی.

ورودی:
- نام درس: {courseTitle}
- نام استاد: {teacherName}
- شماره گروه: {classGroup}
- تعداد کلاس‌ها: {count}
- نوع پخش: {(distributionType == "spread" ? "در طول هفته پخش شود" : "فشرده در یک روز باشد")}
- برنامه‌های فعلی (برای جلوگیری از تداخل):
{schedulesJson}

قوانین:
1. کلاس‌های گروه مشترک نباید با هم تداخل زمانی داشته باشند.
2. نوع پخش باید رعایت شود:
   - spread → کلاس‌ها در طول هفته توزیع شوند.
   - compact → اگر تعداد کلاس‌ها بیشتر از 1 باشد، همه کلاس‌ها در یک روز برگزار شوند.
3. خروجی باید فقط یک آرایه JSON باشد (هیچ متن اضافی یا توضیحی نباشد).
4. هر آیتم خروجی باید شامل این خصوصیات باشد:
   - DayOfWeek
   - StartTime
   - EndTime
   - CourseTitle
   - TeacherName
   - ClassGroup
5. طول زمان کلاس‌ها بر اساس تعداد واحد مشخص شود:
   - 3 واحد → 2 ساعت و 30 دقیقه
   - 2 واحد → 1 ساعت و 40 دقیقه
   - 1 واحد → 1 ساعت و 40 دقیقه
6. زمان شروع اولین کلاس‌ها ساعت 08:00 صبح باشد.
7. زمان پایان آخرین کلاس‌ها حداکثر ساعت 20:00 شب باشد.
8. شروع کلاس‌ها به صورت منطقی پشت‌سرهم یا در روزهای مختلف (بسته به نوع پخش) تنظیم شود.
9. روزها رو به صورت فارسی بده
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
