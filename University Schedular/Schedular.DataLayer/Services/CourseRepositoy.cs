using Schedular.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Schedular.DataLayer.Services
{
    public class CourseRepositoy : ICourseRepository
    {
        UniversitySchedular_DBEntities db;
        public CourseRepositoy(UniversitySchedular_DBEntities context)
        {
            db = context;
        }
        public List<Course> GetCourses()
        {
            return db.Course.ToList();
        }
        public Course GetCourseById(int courseId)
        {
            return db.Course.Find(courseId);
        }
        
        public bool AddCourse(Course course)
        {
            try
            {
               db.Course.Add(course);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCourse(Course course)
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

        public bool DeleteCourse(int courseId)
        {
            try
            {
                var course = GetCourseById(courseId);
                DeleteCourse(course);
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public bool UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
