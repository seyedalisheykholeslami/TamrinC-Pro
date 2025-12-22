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
        Teacher information;
        ManageTeacher manageTeacher;
        AlertHelp alertHelp;
        public string _nationalCode = null;
        public event Action InsertUser;
        public FrmTeacher()
        {
            InitializeComponent();
            manageTeacher = new ManageTeacher();
            alertHelp = new AlertHelp();
            alertHelp.Button = MessageBoxButtons.OK;
            alertHelp.Icon = MessageBoxIcon.Error;
        }


        private void FrmManage_Load(object sender, EventArgs e)
        {
            if (_nationalCode != null)
            {

                btnNewTeacher.Visible = false;
                btnEntry.Text = "Save";
                information =  manageTeacher.SearchTeacher(_nationalCode);
                txtFirstName.Text = information.FirstName;  
                txtLastName.Text = information.LastName;
                txtNationalCode.Text = information.NationalCode;
                txtPhoneNumber.Text = information.PhoneNumber;
                txtAddress.Text = information.Address;
                cbmField.SelectedItem = information.Field;
                txtNationalCode.Enabled = false;
            }
        }
        OperationResult FillProp(bool edit)
        {
            
            information.FirstName = txtFirstName.Text;
            information.LastName = txtLastName.Text;
            information.NationalCode = txtNationalCode.Text;
            information.Field= (string)cbmField.SelectedItem;
            information.PhoneNumber = txtPhoneNumber.Text;
            information.Address =txtAddress.Text;
            return information.Validation(edit);
        }
        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (_nationalCode == null)
            {
                if (Add())
                    DialogResult = DialogResult.OK;
            }
            else
                Edit();
        }
        public bool Add()
        {
            bool status = false;
            information = new Teacher();
            OperationResult check = FillProp(false);
            if (check.IsSuccess)
            {
                manageTeacher.Add(information);
                information = null;
                alertHelp.Icon = MessageBoxIcon.Information;
                status = true;
            }
            else
                alertHelp.Icon = MessageBoxIcon.Error;
            alertHelp.Message = check.Message;
            alertHelp.Text = check.Text;
            alertHelp.Alert();


            return status;
        }
        private void Edit()
        {
            OperationResult check = FillProp(true);
            if (check.IsSuccess)
            {
                manageTeacher.Update(information);
                information = null;
                _nationalCode = null;
                DialogResult = DialogResult.OK;
                alertHelp.Icon = MessageBoxIcon.Information;
            }
            else
                alertHelp.Icon = MessageBoxIcon.Error;
            alertHelp.Message = check.Message;
            alertHelp.Text = check.Text;
            alertHelp.Alert();
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
