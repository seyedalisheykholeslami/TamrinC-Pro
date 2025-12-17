using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin_c__pro
{
    public partial class FrmTeacher : Form
    {
        ManageTeacher manageTeacher;
        public Teacher Information { get; set; }
        public event Action InsertUser;
        public FrmTeacher()
        {
            InitializeComponent();
            manageTeacher = new ManageTeacher();
        }


        private void FrmManage_Load(object sender, EventArgs e)
        {
            if (Information != null)
            {
                btnEntry.Text = "Save";
                btnNewStudent.Visible = false;
            }
        }
        bool FillProp()
        {
            Information.FirstName = txtFirstName.Text;
            Information.LastName = txtLastName.Text;
            Information.NationalCode = txtNationalCode.Text;
            Information.Field= (string)cbmField.SelectedItem;
            Information.PhoneNumber = txtPhoneNumber.Text;
            Information.Address =txtAddress.Text;   
            return Information.Validation();
        }
        public bool Add()
        {
            Information = new Teacher();
            bool check = FillProp();
            if (check)
            {
                manageTeacher.Add(Information);
                Information = null;
                return true;
                
            }
            else
                AlertHelp.Alert();
            return false;
        }
        private void Edit()
        {
            bool check = FillProp();
            if (!check)
                AlertHelp.Alert();
            else
                DialogResult = DialogResult.OK;


        }
        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (Information == null)
            {
                if (Add())
                    DialogResult = DialogResult.OK;
                
            }
            else
                Edit();

            
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            if (Add())
            {
                InsertUser();
                cbmField.SelectedItem = txtFirstName.Text =
                txtLastName.Text = txtNationalCode.Text =
                txtPhoneNumber.Text = txtAddress.Text = null;
            }
        }
    }
}
