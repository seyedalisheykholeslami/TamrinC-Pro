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
    public partial class FrmManage : Form
    {
        DataManager dataManager;
        bool IsEdit = false;
        public Student Student { get; set; }
        public FrmManage()
        {
            InitializeComponent();
            dataManager = new DataManager();
            
        }

        public void FillStudent()
        {
            if (Student != null) 
                IsEdit = true;

            Student.FirstName = txtFirstName.Text;
            Student.LastName = txtLastName.Text;
            Student.NationalCode = txtNationalCode.Text;

            if (chkMale.Checked)
                Student.GenderType = Genders.Male;

            else if (chkFemale.Checked)

                Student.GenderType = Genders.Female;

            else
                Student.GenderType = Genders.UnKnow;
            
            bool check = Student.Validation();
            if (!check)
                AlertHelp.Alert();
        } 
        private void btnEntry_Click(object sender, EventArgs e)
        {
                  FillStudent();
                if (IsEdit==false )
            {
                dataManager.Add(Student);          
                this.Close();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chkMale_Click(object sender, EventArgs e)
        {
            chkFemale.Checked = false;
        }
        private void chkFemale_Click(object sender, EventArgs e)
        {
            chkMale.Checked = false;
        }
    }
}
