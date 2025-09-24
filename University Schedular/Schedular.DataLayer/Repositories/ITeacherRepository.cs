using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.DataLayer.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetTeachers();
        Teacher GetTeacherById(int teacherId);
        IEnumerable<Teacher> GetTeacherByFilter(string parameter);
        bool AddTeacher(Teacher teacher);
        bool UpdateTeacher(Teacher teacher);
        bool RemoveTeacher(Teacher teacher);
        bool RemoveTeacher(int teacherId);
    }
}
