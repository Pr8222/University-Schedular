using Schedular.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Schedular.DataLayer.Services
{
    public class TeacherRepository : ITeacherRepository
    {
        UniversitySchedular_DBEntities db;
        public TeacherRepository(UniversitySchedular_DBEntities context)
        {
            db = context;
        }
        public Teacher GetTeacherByName(string teacherName)
        {
            return db.Teacher.Find(teacherName);
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return db.Teacher.Find(teacherId);
        }

        public List<Teacher> GetTeachers()
        {
            return db.Teacher.ToList();
        }
        public bool AddTeacher(Teacher teacher)
        {
            try
            {
                db.Teacher.Add(teacher);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTeacher(Teacher teacher)
        {
            try
            {
                db.Entry(teacher).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveTeacher(Teacher teacher)
        {
            try
            {
                db.Entry(teacher).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveTeacher(int teacherId)
        {
            try
            {
                var teacher = GetTeacherById(teacherId);
                RemoveTeacher(teacher);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
