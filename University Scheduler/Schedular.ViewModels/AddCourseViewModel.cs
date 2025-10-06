using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.ViewModels
{
    public class AddCourseViewModel
    {
        public string CourseTitle { get; set; }
        public string TeacherName { get; set; }
        public string Term { get; set; }
        public int ClassGroup { get; set; }
        public int Units { get; set; }
        public int Capacity { get; set; }
        public string DayOfWeek { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
    }
}
