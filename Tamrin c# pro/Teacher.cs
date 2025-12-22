using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin_c__pro
{
    public class Teacher : Person
    {
        ManageTeacher manageTeacher;
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Field { get; set; }
        public Teacher()
        {
            manageTeacher = new ManageTeacher();    
        }
        public override OperationResult Validation(bool edit)
        {

            if (FirstName.Length < 3)
            {
                return new OperationResult()
                {
                    Message = "اسم نمیتواند کمتر از 3 حرف باشد",
                    Text = "ErorName",
                    IsSuccess = false,
                };
            }
            else if (NationalCode.Length < 10)
            {
                return new OperationResult()
                {
                    Message = "کد ملی نمیتواند کمتر از 10 حرف باشد",
                    Text = "ErorNationalCode",
                    IsSuccess = false
                };

            }
            else if (Field == null)
            {
                return new OperationResult()
                {
                    Message = "لطفا یک رشته را انتخاب کنید",
                    Text = "ErorField",
                    IsSuccess = false
                };
            }
            else if (PhoneNumber.Length < 11)
            {
                return new OperationResult()
                {
                    Message = "شماره تلفن نمیتواند کمتر از 11 حرف باشد",
                    Text = "ErorPhoneNumber",
                    IsSuccess = false
                };
            }
            else if (!edit && manageTeacher.SearchTeacher(NationalCode) != null)
            {
                return new OperationResult()
                {
                    Message = "معلم با این مشخصات از قبل وجود دارد",
                    Text = "ErorNationalCode",
                    IsSuccess = false
                };
            }
            else
                return new OperationResult()
                {
                    Message = "اطلاعات با موفقیت ثبت شد",
                    Text = "Success",
                    IsSuccess = true,
                };
        }


    }
}
