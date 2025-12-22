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
    public partial class FrmDisplay : Form
    {
        ManageStudent manageStudent;
        ManageTeacher manageTeacher;
        AlertHelp alertHelp;
        public FrmDisplay()
        {
            InitializeComponent();
            manageStudent = new ManageStudent();
            manageTeacher = new ManageTeacher();
            alertHelp = new AlertHelp();
            cmbSelectUser.SelectedIndex = 0;
        }

        private void FillDGV()
        {
            if (cmbSelectUser.SelectedIndex == 0)
                dgvStudent.DataSource = manageTeacher.GetStudents().ToList();

            else if (cmbSelectUser.SelectedIndex == 1)
                dgvStudent.DataSource = manageStudent.GetStudents().ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSelectUser.SelectedIndex == 0)
            {
                FrmTeacher frmTeacher = new FrmTeacher();
                frmTeacher.InsertUser += FillDGV;
                if (frmTeacher.ShowDialog() == DialogResult.OK)
                    FillDGV();
            }
            else if (cmbSelectUser.SelectedIndex == 1)
            {
                FrmStudent frmStudent = new FrmStudent();
                frmStudent.InsertUser += FillDGV;
                if (frmStudent.ShowDialog() == DialogResult.OK)
                    FillDGV();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index >= 0)
            {
                if (cmbSelectUser.SelectedIndex == 0)
                {
                    manageTeacher.RemoveAt(dgvStudent.CurrentRow.Index);
                    FillDGV();
                }
                else if (cmbSelectUser.SelectedIndex == 1)
                {
                    manageStudent.RemoveAt(dgvStudent.CurrentRow.Index);
                    FillDGV();
                }
            }
            else
            {
                alertHelp.Message = "لطفا یک سطر را انتخاب کنید";
                alertHelp.Text = "SelectRow";
                alertHelp.Button = MessageBoxButtons.OK;
                alertHelp.Icon = MessageBoxIcon.Warning;
                alertHelp.Alert();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvStudent.CurrentRow.Index >= 0)
            {
                if (cmbSelectUser.SelectedIndex == 0)
                {
                    FrmTeacher frmTeacher = new FrmTeacher();
                    var teacher = dgvStudent.CurrentRow.DataBoundItem as Teacher;
                    frmTeacher._nationalCode = teacher.NationalCode;
                    frmTeacher.ShowDialog();

                }
                else if (cmbSelectUser.SelectedIndex == 1)
                {
                    FrmStudent frmStudent = new FrmStudent();
                    var student = dgvStudent.CurrentRow.DataBoundItem as Student;
                    frmStudent._nationalCode = student.NationalCode;
                    frmStudent.ShowDialog();
                }
            }
            else
            {
                alertHelp.Message = "لطفا یک سطر را انتخاب کنید";
               alertHelp.Text = "SelectRow";
               alertHelp.Button = MessageBoxButtons.OK;
               alertHelp.Icon = MessageBoxIcon.Warning;
               alertHelp.Alert();
            }
        }


        private void cmbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV();
        }
    }
}
