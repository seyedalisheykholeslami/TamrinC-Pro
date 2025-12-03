namespace Tamrin_c__pro
{
    partial class FrmManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(165, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(8, 197);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(142, 35);
            this.btnEntry.TabIndex = 6;
            this.btnEntry.Text = "Entry";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(14, 162);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(99, 29);
            this.chkFemale.TabIndex = 5;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.Click += new System.EventHandler(this.chkFemale_Click);
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(14, 127);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(77, 29);
            this.chkMale.TabIndex = 4;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.Click += new System.EventHandler(this.chkMale_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(169, 144);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 25);
            this.lblGender.TabIndex = 33;
            this.lblGender.Text = "Gnder";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(168, 92);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(131, 25);
            this.lblNationalCode.TabIndex = 32;
            this.lblNationalCode.Text = "NationalCode";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(168, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 25);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(168, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "FirstName";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(13, 89);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(148, 30);
            this.txtNationalCode.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(13, 49);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 30);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(13, 9);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 30);
            this.txtFirstName.TabIndex = 0;
            // 
            // FrmManage
            // 
            this.AcceptButton = this.btnEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(313, 241);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtNationalCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}