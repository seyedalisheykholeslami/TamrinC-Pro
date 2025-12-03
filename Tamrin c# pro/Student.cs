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
    public class Student
    {
        DataManager dataManager= new DataManager();
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public Genders GenderType { get; set; }
        public string Gender 
        {
            get
            {
                switch (GenderType)
                {
                    case Genders.Male:
                        return  "اقا";
                    case Genders.Female:
                        return "خانم";
                    default:
                        return "نامشخص";

                }
            }
        }
       

        public bool Validation()
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
