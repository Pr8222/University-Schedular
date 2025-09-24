using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Schedular.DataLayer;
using Schedular.DataLayer.Context;
using Schedular.ViewModels;

namespace Schedular.Business
{
    public class TeacherService
    {
        private readonly UnitOfWork _uow;
        public TeacherService()
        {
            _uow = new UnitOfWork();
        }

        public List<TeachersViewModel> GetAllTeachers()
        {
            var list = _uow.TeacherRepository.GetTeachers()
                .Select(l => new TeachersViewModel
                {
                    TeacherID = l.TeacherID,
                    TeacherName = l.FullName
                }).ToList();
            return list;
        }

        public List<TeachersViewModel> GetTeachersByFilter(string filter)
        {
            var list = _uow.TeacherRepository.GetTeacherByFilter(filter)
                .Select(l => new TeachersViewModel
                {
                    TeacherID = l.TeacherID,
                    TeacherName = l.FullName
                }).ToList();
            return list;
        }

        public TeachersViewModel GetTeacherById(int teacherId)
        {
            var teacher = _uow.TeacherRepository.GetTeacherById(teacherId);
            var result = new TeachersViewModel
                {
                    TeacherID = teacher.TeacherID,
                    TeacherName = teacher.FullName
                };
            return result;
        }

        public bool AddTeacher(string teacherName)
        {
            try
            {
                var newTeacher = new Teacher
                {
                    FullName = teacherName
                };
                _uow.TeacherRepository.AddTeacher(newTeacher);
                _uow.Save();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditTeacher(TeachersViewModel teacher)
        {
            try
            {
                var editTeacher = new Teacher
                {
                    TeacherID = teacher.TeacherID,
                    FullName = teacher.TeacherName
                };
                _uow.TeacherRepository.UpdateTeacher(editTeacher);
                _uow.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTeacher(int teacherId)
        {
            try
            {
                _uow.TeacherRepository.RemoveTeacher(teacherId);
                _uow.Save();
                return true;
            }
            catch
            {
                return false;
            }
        } 
    }
}
