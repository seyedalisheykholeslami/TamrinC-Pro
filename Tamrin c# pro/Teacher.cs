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
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Field { get; set; }
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
            else if (Field == null)
            {
                AlertHelp.Message = "لطفا یک رشته را انتخاب کنید";
                AlertHelp.Text = "ErorField";
            }
            else if (PhoneNumber.Length < 11)
            {
                AlertHelp.Message = "شماره تلفن نمیتواند کمتر از 11 حرف باشد";
                AlertHelp.Text = "ErorPhoneNumber";
            }
            else
                return true;

            AlertHelp.Button = MessageBoxButtons.OK;
            AlertHelp.Icon = MessageBoxIcon.Error;
            return false;
        }


    }
}
