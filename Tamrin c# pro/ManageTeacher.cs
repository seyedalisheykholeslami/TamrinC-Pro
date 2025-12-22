using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_c__pro
{
    public class ManageTeacher
    {
        static List<Teacher> teachers;
        public ManageTeacher()
        {
            if (teachers == null)
                teachers= new List<Teacher>();
        }

        public void Add(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void RemoveAt(int index)
        {
            teachers.RemoveAt(index);
        }
        public IReadOnlyList<Teacher> GetStudents()
        {
            return teachers;
        }
        public Teacher SearchTeacher(string key)
        {
            return teachers.FirstOrDefault(p => p.NationalCode == key);
            //if (teacher != null)
            //return new Teacher()
            //{
            //    FirstName = teacher.FirstName,
            //    LastName = teacher.LastName,
            //    NationalCode = teacher.NationalCode,
            //    PhoneNumber = teacher.PhoneNumber,
            //    Address = teacher.Address,
            //    Field = teacher.Field,
            //};
            //return null;
        }
        public void Update(Teacher teacher)
        {
            var isFind = teachers.IndexOf(teacher);
            teachers[isFind]= teacher;
        
        }

    }
}
