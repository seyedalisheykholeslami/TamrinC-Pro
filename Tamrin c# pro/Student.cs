using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tamrin_c__pro
{
    public class Student : Person
    {
        ManageStudent dataManager;
        public Student()
        {
            dataManager = new ManageStudent();    
        }
        public string StudentCode { get; set; }
        public string Grade { get; set; }
        public override string FullName
        {
            get
            {
                return FirstName + "" + LastName + " " + Grade;
            
            
            }
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Grade + " " + StudentCode;
        }
        public override bool Validation()
        {
            if (FirstName.Length < 3)
            {
                AlertHelp.Message = "اسم نمیتواند کمتر از 3 حرف باشد";
                AlertHelp.Text = "ErorName";
            }
            else if (NationalCode.Length < 10)
            {
                AlertHelp.Message = "کد ملی نمیتواند کمتر از 10 حرف باشد";
                AlertHelp.Text = "ErorNationalCode";
            }
            else if (StudentCode.Length < 4)
            {
                AlertHelp.Message = "کد دانش اموزی نمیتواند کمتر از 4 حرف باشد";
                AlertHelp.Text = "ErorStudentCode";
            }
            else if (!dataManager.SearchStudent(StudentCode))
            {
                AlertHelp.Message = "کد دانش اموزی از قبل وجود دارد";
                AlertHelp.Text = "ErorNationalCode";
            }
            else if (Grade == null)
            {
                AlertHelp.Message = "لطفا یک مقطع تحصیلی را انتخاب کنید";
                AlertHelp.Text = "ErorGrade";
            }          
            else
                return true;

            AlertHelp.Button = MessageBoxButtons.OK;
            AlertHelp.Icon = MessageBoxIcon.Error;
            return false;
        }


    }
}
