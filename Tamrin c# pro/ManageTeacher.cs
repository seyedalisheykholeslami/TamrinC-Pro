using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_c__pro
{
    public class ManageTeacher
    {
        static List<Teacher> teacher;
        public ManageTeacher()
        {
            if (teacher == null)
                teacher = new List<Teacher>();
        }

        public void Add(Teacher _teacher)
        {
            teacher.Add(_teacher);
        }
        public void RemoveAt(int index)
        {
            teacher.RemoveAt(index);
        }
        public IReadOnlyList<Teacher> GetStudents()
        {
            return teacher;
        }
        public bool SearchTeacher(string number,string code)
        {
            if (teacher.FirstOrDefault(p => p.PhoneNumber == number) == null)
                if (teacher.FirstOrDefault(p => p.NationalCode == code) == null)
                    return true;

            return false;
        }


    }
}
