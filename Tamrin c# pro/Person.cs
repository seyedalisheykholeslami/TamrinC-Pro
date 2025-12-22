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
        public virtual OperationResult Validation(bool edit)
        {
            OperationResult result = new OperationResult();

            if (FirstName.Length < 3)
            {
                result.Message = "اسم نمیتواند کمتر از 3 حرف باشد";
                result.Text = "ErorFirstName";
                result.IsSuccess = true;
            }
            else if (NationalCode.Length < 10)
            {
                result.Message = "کد ملی نمیتواند کمتر از 10 حرف باشد";
                result.Text = "ErorNationalCode";
                result.IsSuccess = true;
            }

            else
                result.IsSuccess = true ;

           
            return result;
        }
    }
}
