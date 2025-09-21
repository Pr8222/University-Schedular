using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schedular.DataLayer;
using Schedular.DataLayer.Context;
using Schedular.ViewModels;

namespace Schedular.Business
{
    public class UnitService
    {
        private readonly UnitOfWork _uow;

        public UnitService()
        {
            _uow = new UnitOfWork();
        }

        public List<CoursesViewModel> GetAllUnits()
        {
            var units = _uow.CourseRepository.GetCourses()
                .Select(c => new CoursesViewModel
                {
                    Id = c.CourseID,
                    CourseName = c.Title,
                    Units = c.Units
                }).ToList();
            return units;
        }
    }
}
