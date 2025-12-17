using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_c__pro
{
    public class ManageStudent
    {
       static List<Student> student;
        
       
        public ManageStudent()
        {
            if (student == null)
                student = new List<Student>();          
        }
        
        public void Add(Student _student)
        {
            student.Add(_student);
        }
        public void RemoveAt(int index)
        {
            student.RemoveAt(index);
        }
        public IReadOnlyList<Student> GetStudents()
        {
            return student;
        }
        public bool SearchStudent(string key)
        {
            if (student.FirstOrDefault(p => p.StudentCode == key) == null)
                return true;

           return false;    
        }
        

    }
}
