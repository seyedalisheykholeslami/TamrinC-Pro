using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tamrin_c__pro
{
    public partial class FrmStudent : Form
    {
        Student information;
        ManageStudent manageStudent;
        AlertHelp alertHelp;
        public string _nationalCode;
        public event Action InsertUser;
        public FrmStudent()
        {
            InitializeComponent();
            manageStudent = new ManageStudent();
           alertHelp = new AlertHelp();
        }
        private void FrmManage_Load(object sender, EventArgs e)
        {
            if (_nationalCode != null)
            {
                btnNewStudent.Visible = false;
                btnEntry.Text = "Save";
                information = manageStudent.SearchStudent(_nationalCode);
                txtFirstName.Text = information.FirstName;
                txtLastName.Text = information.LastName;
                txtNationalCode.Text = information.NationalCode;
                txtStudentCode.Text = information.StudentCode;
                cbmGrade.SelectedItem = information.Grade;
                txtNationalCode.Enabled = false;
            }
        }
        OperationResult FillProp(bool edit)
        {
            information.FirstName = txtFirstName.Text;
            information.LastName = txtLastName.Text;
            information.NationalCode = txtNationalCode.Text;
            information.Grade = (string)cbmGrade.SelectedItem;
            information.StudentCode = txtStudentCode.Text;
            return information.Validation(edit); 
        }
        public bool Add()
        {
            bool status = false;
            information = new Student();
            OperationResult check = FillProp(false);
            if (check.IsSuccess)
            {
                manageStudent.Add(information);
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
                manageStudent.Update(information);
                information = null;
                _nationalCode = null;
                alertHelp.Icon = MessageBoxIcon.Information;
                DialogResult = DialogResult.OK;
            }
            else
                alertHelp.Icon = MessageBoxIcon.Error;
            
                alertHelp.Message = check.Message;
                alertHelp.Text = check.Text;
                alertHelp.Alert();
            


        }
        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (information == null)
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
                cbmGrade.SelectedItem = txtFirstName.Text =
                txtLastName.Text = txtNationalCode.Text =
                txtStudentCode.Text = null;
            }
        }

       
    }
}
