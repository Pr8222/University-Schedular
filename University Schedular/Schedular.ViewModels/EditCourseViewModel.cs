using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.ViewModels
{
    public class EditCourseViewModel
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public int Units { get; set; }
        public string TeacherName { get; set; }
        public string Term { get; set; }
        public int ClassGroup { get; set; }
        public string DayOfWeek { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public int Capacity { get; set; }
    }
}
