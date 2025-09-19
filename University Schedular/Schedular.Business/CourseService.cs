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
        // adding new teacher if not exists
        internal Teacher AddTeacher(string teacherName)
        {
            var teacher = _uow.TeacherRepository.GetTeachers().FirstOrDefault(t => t.FullName.Equals(teacherName, StringComparison.OrdinalIgnoreCase));
            if (teacher == null)
            {
                teacher = new Teacher
                {
                    FullName = teacherName
                };
                _uow.TeacherRepository.AddTeacher(teacher);
                _uow.Save();
            }
            return teacher;
        }
        // adding new course if not exists
        internal Course AddCourse(string courseTitle, int units)
        {
            var course = _uow.CourseRepository.GetCourses().FirstOrDefault(c => c.Title.Equals(courseTitle, StringComparison.OrdinalIgnoreCase));
            if (course == null)
            {
                course = new Course
                {
                    Title = courseTitle,
                    Units = units
                };
                _uow.CourseRepository.AddCourse(course);
                _uow.Save();
            }
            return course;
        }
        // add new schedule manually
        public void AddSchedule(AddCourseViewModel addCourse)
        {
            if(addCourse != null)
            {
                var teacher = AddTeacher(addCourse.TeacherName);
                var course = AddCourse(addCourse.CourseTitle, addCourse.Units);
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
        public void RemoveCourse(int courseId)
        {
            _uow.CourseScheduleRepository.RemoveCourse(courseId);
            _uow.Save();
        }
        // edit course schedule
        public void EditCourse(EditCourseViewModel model)
        {
            var schedule = _uow.CourseScheduleRepository.GetCourseScheduleById(model.Id);
            if (schedule != null)
            {
                var teacher = AddTeacher(model.TeacherName);
                var course = AddCourse(model.CourseTitle, model.Units);
                schedule.Teacher = teacher;
                schedule.Course = course;
                schedule.Term = model.Term;
                schedule.ClassGroup = model.ClassGroup;
                schedule.DayOfWeek = model.DayOfWeek;
                schedule.StartTime = model.StartTime;
                schedule.EndTime = model.EndTime;
                schedule.Capacity = model.Capacity;
                _uow.CourseScheduleRepository.UpdateCourse(schedule);
                _uow.Save();
            }
        }
        // search course schedule
        public List<CourseScheduleViewModel> SearchCourseSchedule(string searchTxt)
        {
           var schdules = _uow.CourseScheduleRepository.GetCoursesByFilter(searchTxt);
           var result = schdules.Select(cs =>  new CourseScheduleViewModel
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
    }
}
