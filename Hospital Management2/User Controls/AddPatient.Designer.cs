namespace Hospital_Management2.User_Controls
{
    partial class AddPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButtonAddPatient = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxContactAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabe = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroButtonViewAll = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButtonModify = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTextBoxPhoneNo);
            this.panel1.Controls.Add(this.metroButtonModify);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButtonViewAll);
            this.panel1.Controls.Add(this.metroButtonAddPatient);
            this.panel1.Controls.Add(this.metroTextBoxContactAddress);
            this.panel1.Controls.Add(this.metroTextBoxName);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabe);
            this.panel1.Controls.Add(this.metroLabelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 320);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroButtonAddPatient
            // 
            this.metroButtonAddPatient.Location = new System.Drawing.Point(230, 189);
            this.metroButtonAddPatient.Name = "metroButtonAddPatient";
            this.metroButtonAddPatient.Size = new System.Drawing.Size(112, 32);
            this.metroButtonAddPatient.TabIndex = 6;
            this.metroButtonAddPatient.Text = "Add Patient";
            this.metroButtonAddPatient.UseSelectable = true;
            this.metroButtonAddPatient.Click += new System.EventHandler(this.metroButtonAddPatient_Click);
            // 
            // metroTextBoxContactAddress
            // 
            // 
            // 
            // 
            this.metroTextBoxContactAddress.CustomButton.Image = null;
            this.metroTextBoxContactAddress.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxContactAddress.CustomButton.Name = "";
            this.metroTextBoxContactAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxContactAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxContactAddress.CustomButton.TabIndex = 1;
            this.metroTextBoxContactAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxContactAddress.CustomButton.UseSelectable = true;
            this.metroTextBoxContactAddress.CustomButton.Visible = false;
            this.metroTextBoxContactAddress.Lines = new string[0];
            this.metroTextBoxContactAddress.Location = new System.Drawing.Point(142, 125);
            this.metroTextBoxContactAddress.MaxLength = 32767;
            this.metroTextBoxContactAddress.Name = "metroTextBoxContactAddress";
            this.metroTextBoxContactAddress.PasswordChar = '\0';
            this.metroTextBoxContactAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxContactAddress.SelectedText = "";
            this.metroTextBoxContactAddress.SelectionLength = 0;
            this.metroTextBoxContactAddress.SelectionStart = 0;
            this.metroTextBoxContactAddress.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxContactAddress.TabIndex = 5;
            this.metroTextBoxContactAddress.UseSelectable = true;
            this.metroTextBoxContactAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxContactAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxName
            // 
            // 
            // 
            // 
            this.metroTextBoxName.CustomButton.Image = null;
            this.metroTextBoxName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxName.CustomButton.Name = "";
            this.metroTextBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxName.CustomButton.TabIndex = 1;
            this.metroTextBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxName.CustomButton.UseSelectable = true;
            this.metroTextBoxName.CustomButton.Visible = false;
            this.metroTextBoxName.Lines = new string[0];
            this.metroTextBoxName.Location = new System.Drawing.Point(142, 73);
            this.metroTextBoxName.MaxLength = 32767;
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.PasswordChar = '\0';
            this.metroTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxName.SelectedText = "";
            this.metroTextBoxName.SelectionLength = 0;
            this.metroTextBoxName.SelectionStart = 0;
            this.metroTextBoxName.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxName.TabIndex = 3;
            this.metroTextBoxName.UseSelectable = true;
            this.metroTextBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Contact Address:";
            // 
            // metroLabe
            // 
            this.metroLabe.AutoSize = true;
            this.metroLabe.Location = new System.Drawing.Point(15, 28);
            this.metroLabe.Name = "metroLabe";
            this.metroLabe.Size = new System.Drawing.Size(71, 19);
            this.metroLabe.TabIndex = 1;
            this.metroLabe.Text = "Phone No:";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(15, 77);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(48, 19);
            this.metroLabelName.TabIndex = 0;
            this.metroLabelName.Text = "Name:";
            // 
            // metroButtonViewAll
            // 
            this.metroButtonViewAll.Location = new System.Drawing.Point(4, 189);
            this.metroButtonViewAll.Name = "metroButtonViewAll";
            this.metroButtonViewAll.Size = new System.Drawing.Size(112, 32);
            this.metroButtonViewAll.TabIndex = 7;
            this.metroButtonViewAll.Text = "View ALL";
            this.metroButtonViewAll.UseSelectable = true;
            this.metroButtonViewAll.Click += new System.EventHandler(this.metroButtonViewAll_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(4, 251);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 32);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Delete";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButtonModify
            // 
            this.metroButtonModify.Location = new System.Drawing.Point(230, 251);
            this.metroButtonModify.Name = "metroButtonModify";
            this.metroButtonModify.Size = new System.Drawing.Size(112, 32);
            this.metroButtonModify.TabIndex = 9;
            this.metroButtonModify.Text = "Modify";
            this.metroButtonModify.UseSelectable = true;
            this.metroButtonModify.Click += new System.EventHandler(this.metroButtonModify_Click);
            // 
            // metroTextBoxPhoneNo
            // 
            this.metroTextBoxPhoneNo.Location = new System.Drawing.Point(142, 27);
            this.metroTextBoxPhoneNo.Name = "metroTextBoxPhoneNo";
            this.metroTextBoxPhoneNo.Size = new System.Drawing.Size(200, 20);
            this.metroTextBoxPhoneNo.TabIndex = 10;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddPatient";
            this.Size = new System.Drawing.Size(370, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButtonAddPatient;
        private MetroFramework.Controls.MetroTextBox metroTextBoxContactAddress;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabe;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroButton metroButtonModify;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButtonViewAll;
        private System.Windows.Forms.TextBox metroTextBoxPhoneNo;
    }
}
