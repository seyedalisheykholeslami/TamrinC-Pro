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
        public override OperationResult Validation(bool edit)
        {
            if (FirstName.Length < 3)
            {
                return new OperationResult()
                {
                    Message = "اسم نمیتواند کمتر از 3 حرف باشد",
                    Text = "ErorName",
                    IsSuccess = false
                };
            }
            else if (NationalCode.Length < 10)
            {
                return new OperationResult()
                {
                    Message = "کد ملی نمیتواند کمتر از 10 حرف باشد",
                    Text = "ErorNationalCode",
                    IsSuccess=false
                };
            }
            else if (StudentCode.Length < 4)
            {
                return new OperationResult()
                {
                    Message = "کد دانش اموزی نمیتواند کمتر از 4 حرف باشد",
                    Text = "ErorStudentCode",
                    IsSuccess = false
                };
            }
            else if (!edit && dataManager.SearchStudent(NationalCode)!=null)
            {
                return new OperationResult()
                {
                    Message = "کد دانش اموزی از قبل وجود دارد",
                    Text = "ErorNationalCode",
                    IsSuccess = false
                };
            }
            else if (Grade == null)
            {
                return new OperationResult()
                {
                    Message = "لطفا یک مقطع تحصیلی را انتخاب کنید",
                    Text = "ErorGrade",
                    IsSuccess = false
                };
            }
            else
                return new OperationResult()
                {
                    Message = "اطلاعات با موفقیت ثبت شد",
                    Text = "Success",
                    IsSuccess = true
                };
        }


    }
}
