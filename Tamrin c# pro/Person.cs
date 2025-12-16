using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin_c__pro
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public virtual string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public virtual bool Validation()
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

            else
                return true;

            AlertHelp.Button = MessageBoxButtons.OK;
            AlertHelp.Icon = MessageBoxIcon.Error;
            return false;
        }
    }
}
