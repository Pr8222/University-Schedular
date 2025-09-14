using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.DataLayer.Repositories
{
    public interface ICourseScheduleRepository
    {
        List<CourseSchedule> GetCourseSchedules();
        CourseSchedule GetCourseScheduleById(int courseId);
        IEnumerable<CourseSchedule> GetCoursesByFilter(string parameter);
        bool AddCourse(CourseSchedule course);
        bool UpdateCourse(CourseSchedule course);
        bool RemoveCourse(CourseSchedule course);
        bool RemoveCourse(int courseId);
    }
}
