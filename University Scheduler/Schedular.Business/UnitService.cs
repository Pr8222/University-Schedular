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

        public bool AddUnit(string title, int unit)
        {   try
            {
                var newUnit = new Course
                {
                    Title = title,
                    Units = unit
                };

                _uow.CourseRepository.AddCourse(newUnit);

                _uow.Save();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool EditUnit(CoursesViewModel unit)
        {
            try
            {
                var updateUnit = new Course
                {
                    CourseID = unit.Id,
                    Title = unit.CourseName,
                    Units = unit.Units
                };
                _uow.CourseRepository.UpdateCourse(updateUnit);
                _uow.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUnit(int unitId)
        {
            try
            {
                _uow.CourseRepository.DeleteCourse(unitId);
                _uow.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<CoursesViewModel> GetUnitsByFilter(string searchTxt)
        {
            var units = _uow.CourseRepository.GetCourseByFilter(searchTxt);
            var result = units.Select(u => new CoursesViewModel
            {
                Id = u.CourseID,
                CourseName = u.Title,
                Units = u.Units
            }).ToList();
            return result;
        }
    }
}
