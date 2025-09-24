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
    }
}
