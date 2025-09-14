using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.DataLayer.Repositories
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
        Course GetCourseById(int courseId);
        Course GetCourseByTitle(string courseTitle);
        bool AddCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(Course course);
        bool DeleteCourse(int courseId);
    }
}
