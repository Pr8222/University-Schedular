using Schedular.DataLayer;
using Schedular.DataLayer.Context;
using Schedular.DataLayer.Repositories;
using Schedular.DataLayer.Services;
using Schedular.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Business
{
    public class CourseService
    {
        private readonly UnitOfWork _uow;

        public CourseService()
        {
            _uow = new UnitOfWork();
        }
        public List<CourseScheduleViewModel> GetAllCourseSchedules()
        {
            var courses = _uow.CourseScheduleRepository.GetCourseSchedules();

            var result = courses.Select(cs => new CourseScheduleViewModel
            {
                Id = cs.ID,
                CourseTitle = cs.Course.Title,
                Units = cs.Course.Units,
                TeacherName = cs.Teacher.FullName,
                Term = cs.Term,
                ClassGroup = cs.ClassGroup,
                DayOfWeek = cs.DayOfWeek,
                StartTime = cs.StartTime.ToString(),
                EndTime = cs.EndTime.ToString(),
                Capacity = cs.Capacity.Value,
            }).ToList();

            return result;
        }
        public void AddSchedule(AddCourseViewModel addCourse)
        {
            var teacher = _uow.TeacherRepository.GetTeacherByName(addCourse.TeacherName);
            if (teacher == null)
            {
                teacher = new Teacher
                {
                    FullName = addCourse.TeacherName
                };
                _uow.TeacherRepository.AddTeacher(teacher);
            }

            var course = _uow.CourseRepository.GetCourseByTitle(addCourse.CourseTitle);
            if (course == null)
            {
                course = new Course
                {
                    Title = addCourse.CourseTitle,
                    Units = addCourse.Units
                };
                _uow.CourseRepository.AddCourse(course);
            }

            var schedule = new CourseSchedule
            {
                Teacher = teacher,  
                Course = course,    
                Term = addCourse.Term,
                ClassGroup = addCourse.ClassGroup,
                DayOfWeek = addCourse.DayOfWeek,
                StartTime = addCourse.StartTime,
                EndTime = addCourse.EndTime,
                Capacity = addCourse.Capacity
            };

            _uow.CourseScheduleRepository.AddCourse(schedule);

            _uow.Save();
        }
    }
}
