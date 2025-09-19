using Schedular.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.DataLayer.Services
{
    public class CourseScheduleRepository : ICourseScheduleRepository
    {
        UniversitySchedular_DBEntities db;

        public CourseScheduleRepository(UniversitySchedular_DBEntities context)
        {
            db = context;
        }

        public List<CourseSchedule> GetCourseSchedules()
        {
            return db.CourseSchedule
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .AsNoTracking()
                .ToList();
        }

        public CourseSchedule GetCourseScheduleById(int courseId)
        {
            return db.CourseSchedule.Find(courseId);
        }

        public bool AddCourse(CourseSchedule course)
        {
            try
            {
                db.CourseSchedule.Add(course);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCourse(CourseSchedule course)
        {
            try
            {
                db.Entry(course).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveCourse(CourseSchedule course)
        {
            try
            {
                db.Entry(course).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveCourse(int courseId)
        {
            try
            {
                var course = GetCourseScheduleById(courseId);
                RemoveCourse(course);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<CourseSchedule> GetCoursesByFilter(string parameter)
        {
            return db.CourseSchedule.Include(cs => cs.Course)
                .Include(cs => cs.Teacher)
                .Where(cs => cs.Course.Title.Contains(parameter) ||
            cs.Teacher.FullName.Contains(parameter) ||
            cs.Term.Contains(parameter) ||
            cs.ClassGroup.Contains(parameter) ||
            cs.DayOfWeek.Contains(parameter)).ToList();
        }
    }
}
