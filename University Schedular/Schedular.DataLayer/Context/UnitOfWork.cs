using Schedular.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        UniversitySchedular_DBEntities db = new UniversitySchedular_DBEntities();

        private ICourseScheduleRepository _courseScheduleRepository;
        private ITeacherRepository _teacherRepository;
        private ICourseRepository _courseRepository;

        public ICourseScheduleRepository CourseScheduleRepository
        {
            get
            {
                if (_courseScheduleRepository == null)
                {
                    _courseScheduleRepository = new Services.CourseScheduleRepository(db);
                }
                return _courseScheduleRepository;
            }
        }

        public ITeacherRepository TeacherRepository
        {
            get
            {
                if (_teacherRepository == null)
                {
                    _teacherRepository = new Services.TeacherRepository(db);
                }
                return _teacherRepository;
            }
        }

        public ICourseRepository CourseRepository
        {
            get
            {
                if (_courseRepository == null)
                {
                    _courseRepository = new Services.CourseRepositoy(db);
                }
                return _courseRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
