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
        ManageStudent dataManager;
        public Student Information { get; set; }
        public event Action InsertUser;
        public FrmStudent()
        {
            InitializeComponent();
            dataManager = new ManageStudent();
           
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
            Information.Grade = (string)cbxGrade.SelectedItem;
            Information.StudentCode = txtStudentCode.Text;
            return Information.Validation(); 
        }
        public bool Add()
        {
            Information = new Student();
            bool check = FillProp();
            if (check)
            {
                dataManager.Add(Information);
                return true;
            }
            else         
                AlertHelp.Alert();
            return  false;
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
                cbxGrade.SelectedItem = txtFirstName.Text =
                txtLastName.Text = txtNationalCode.Text =
                txtStudentCode.Text = null;
            }
        }

       
    }
}
