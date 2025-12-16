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
        DataManager dataManager;
        
        public FrmDisplay()
        {
            InitializeComponent();
            dataManager = new DataManager();
             
        }
        private void FillDGV()
        {
            dgvStudent.DataSource = dataManager.GetStudents().ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmManage frmManage = new FrmManage();
            
            frmManage.InsertUser += FillDGV;
            if (frmManage.ShowDialog() == DialogResult.OK)
                FillDGV();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index >= 0)
            {
                dataManager.RemoveAt(dgvStudent.CurrentRow.Index);
                FillDGV();
            }
            else
            {
                AlertHelp.Message = "لطفا یک سطر را انتخاب کنید";
                AlertHelp.Text = "SelectRow";
                AlertHelp.Button = MessageBoxButtons.OK;
                AlertHelp.Icon = MessageBoxIcon.Warning;
                AlertHelp.Alert();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (dgvStudent.CurrentRow.Index >= 0)
            {
                FrmManage frmManage = new FrmManage();
                frmManage.Information = dgvStudent.CurrentRow.DataBoundItem as Student;
                frmManage.ShowDialog();
            }
            else 
            {
                AlertHelp.Message = "لطفا یک سطر را انتخاب کنید";
                AlertHelp.Text = "SelectRow";
                AlertHelp.Button = MessageBoxButtons.OK;
                AlertHelp.Icon = MessageBoxIcon.Warning;
                AlertHelp.Alert();
            }
        }
    }
}
