using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_c__pro
{
    public class DataManager
    {
       static List<Student>  students;
       
        public DataManager()
        {
            if (students == null)
            students = new List<Student>();          
        }
        
        public void Add(Student student)
        { 
            students.Add(student);
        }
        public void RemoveAt(int index)
        { 
            students.RemoveAt(index);
        }
        public IReadOnlyList<Student> GetStudents()
        {
            return students;
        }
        
    }
}
