namespace Hospital_Management2.User_Controls
{
    partial class ManageAppoinments
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
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBoxPatientId = new System.Windows.Forms.TextBox();
            this.metroTextBoxDocName = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonChageCharge = new MetroFramework.Controls.MetroButton();
            this.metroButtonViewCurrentCharges = new MetroFramework.Controls.MetroButton();
            this.metroLabe = new MetroFramework.Controls.MetroLabel();
            this.metroLabeDocId = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButtonDelete);
            this.panel1.Controls.Add(this.metroDateTime1);
            this.panel1.Controls.Add(this.metroTextBoxPatientId);
            this.panel1.Controls.Add(this.metroTextBoxDocName);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroButtonChageCharge);
            this.panel1.Controls.Add(this.metroButtonViewCurrentCharges);
            this.panel1.Controls.Add(this.metroLabe);
            this.panel1.Controls.Add(this.metroLabeDocId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 320);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(4, 248);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(149, 32);
            this.metroButtonDelete.TabIndex = 21;
            this.metroButtonDelete.Text = "Delete Appoinment";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "dd-MM-yyyy";
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime1.Location = new System.Drawing.Point(141, 117);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 20;
            this.metroDateTime1.Value = new System.DateTime(2016, 1, 7, 2, 8, 36, 0);
            // 
            // metroTextBoxPatientId
            // 
            this.metroTextBoxPatientId.Location = new System.Drawing.Point(141, 72);
            this.metroTextBoxPatientId.Name = "metroTextBoxPatientId";
            this.metroTextBoxPatientId.Size = new System.Drawing.Size(200, 20);
            this.metroTextBoxPatientId.TabIndex = 19;
            this.metroTextBoxPatientId.TextChanged += new System.EventHandler(this.metroTextBoxPatientId_TextChanged);
            // 
            // metroTextBoxDocName
            // 
            this.metroTextBoxDocName.Location = new System.Drawing.Point(141, 20);
            this.metroTextBoxDocName.Name = "metroTextBoxDocName";
            this.metroTextBoxDocName.Size = new System.Drawing.Size(200, 20);
            this.metroTextBoxDocName.TabIndex = 18;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Date";
            // 
            // metroButtonChageCharge
            // 
            this.metroButtonChageCharge.Location = new System.Drawing.Point(193, 179);
            this.metroButtonChageCharge.Name = "metroButtonChageCharge";
            this.metroButtonChageCharge.Size = new System.Drawing.Size(149, 32);
            this.metroButtonChageCharge.TabIndex = 9;
            this.metroButtonChageCharge.Text = "Add Appoinment";
            this.metroButtonChageCharge.UseSelectable = true;
            this.metroButtonChageCharge.Click += new System.EventHandler(this.metroButtonChageCharge_Click);
            // 
            // metroButtonViewCurrentCharges
            // 
            this.metroButtonViewCurrentCharges.Location = new System.Drawing.Point(4, 179);
            this.metroButtonViewCurrentCharges.Name = "metroButtonViewCurrentCharges";
            this.metroButtonViewCurrentCharges.Size = new System.Drawing.Size(149, 32);
            this.metroButtonViewCurrentCharges.TabIndex = 8;
            this.metroButtonViewCurrentCharges.Text = "View Appoinments";
            this.metroButtonViewCurrentCharges.UseSelectable = true;
            this.metroButtonViewCurrentCharges.Click += new System.EventHandler(this.metroButtonViewCurrentCharges_Click);
            // 
            // metroLabe
            // 
            this.metroLabe.AutoSize = true;
            this.metroLabe.Location = new System.Drawing.Point(4, 72);
            this.metroLabe.Name = "metroLabe";
            this.metroLabe.Size = new System.Drawing.Size(89, 19);
            this.metroLabe.TabIndex = 1;
            this.metroLabe.Text = "Patient Phone";
            // 
            // metroLabeDocId
            // 
            this.metroLabeDocId.AllowDrop = true;
            this.metroLabeDocId.AutoSize = true;
            this.metroLabeDocId.Location = new System.Drawing.Point(4, 20);
            this.metroLabeDocId.Name = "metroLabeDocId";
            this.metroLabeDocId.Size = new System.Drawing.Size(101, 19);
            this.metroLabeDocId.TabIndex = 0;
            this.metroLabeDocId.Text = "Doc UserName:";
            // 
            // ManageAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageAppoinments";
            this.Size = new System.Drawing.Size(370, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButtonChageCharge;
        private MetroFramework.Controls.MetroButton metroButtonViewCurrentCharges;
        private MetroFramework.Controls.MetroLabel metroLabe;
        private MetroFramework.Controls.MetroLabel metroLabeDocId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox metroTextBoxDocName;
        private System.Windows.Forms.TextBox metroTextBoxPatientId;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
    }
}
