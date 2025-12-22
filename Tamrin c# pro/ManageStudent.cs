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
       static List<Student> students;
        
       
        public ManageStudent()
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
        public Student SearchStudent(string key)
        {
            var student = students.FirstOrDefault(p => p.NationalCode == key);
                if (student != null)
                    return new Student()
                    {
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        NationalCode = student.NationalCode,
                        StudentCode = student.StudentCode,
                        Grade = student.Grade
                    };
            return null;
        }
        public void Update(Student student)
        {
            var isFound = students.FirstOrDefault(p => p.NationalCode == student.NationalCode);
            isFound = student;

        }

    }
}
