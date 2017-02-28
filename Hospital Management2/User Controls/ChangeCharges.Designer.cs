namespace Hospital_Management2.User_Controls
{
    partial class ChangeCharges
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
            this.metroButtonAddNewType = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNewType = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonChageCharge = new MetroFramework.Controls.MetroButton();
            this.metroButtonViewCurrentCharges = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabe = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButtonDelete);
            this.panel1.Controls.Add(this.metroButtonAddNewType);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroTextBoxNewType);
            this.panel1.Controls.Add(this.metroButtonChageCharge);
            this.panel1.Controls.Add(this.metroButtonViewCurrentCharges);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.metroTextBoxAmount);
            this.panel1.Controls.Add(this.metroLabe);
            this.panel1.Controls.Add(this.metroLabelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 320);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroButtonAddNewType
            // 
            this.metroButtonAddNewType.Location = new System.Drawing.Point(4, 216);
            this.metroButtonAddNewType.Name = "metroButtonAddNewType";
            this.metroButtonAddNewType.Size = new System.Drawing.Size(149, 32);
            this.metroButtonAddNewType.TabIndex = 12;
            this.metroButtonAddNewType.Text = "Add New Type";
            this.metroButtonAddNewType.UseSelectable = true;
            this.metroButtonAddNewType.Click += new System.EventHandler(this.metroButtonAddNewType_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AllowDrop = true;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "New Type:";
            // 
            // metroTextBoxNewType
            // 
            // 
            // 
            // 
            this.metroTextBoxNewType.CustomButton.Image = null;
            this.metroTextBoxNewType.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxNewType.CustomButton.Name = "";
            this.metroTextBoxNewType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxNewType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNewType.CustomButton.TabIndex = 1;
            this.metroTextBoxNewType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNewType.CustomButton.UseSelectable = true;
            this.metroTextBoxNewType.CustomButton.Visible = false;
            this.metroTextBoxNewType.Lines = new string[0];
            this.metroTextBoxNewType.Location = new System.Drawing.Point(142, 61);
            this.metroTextBoxNewType.MaxLength = 32767;
            this.metroTextBoxNewType.Name = "metroTextBoxNewType";
            this.metroTextBoxNewType.PasswordChar = '\0';
            this.metroTextBoxNewType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNewType.SelectedText = "";
            this.metroTextBoxNewType.SelectionLength = 0;
            this.metroTextBoxNewType.SelectionStart = 0;
            this.metroTextBoxNewType.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxNewType.TabIndex = 10;
            this.metroTextBoxNewType.UseSelectable = true;
            this.metroTextBoxNewType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNewType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonChageCharge
            // 
            this.metroButtonChageCharge.Location = new System.Drawing.Point(193, 162);
            this.metroButtonChageCharge.Name = "metroButtonChageCharge";
            this.metroButtonChageCharge.Size = new System.Drawing.Size(149, 32);
            this.metroButtonChageCharge.TabIndex = 9;
            this.metroButtonChageCharge.Text = "Change Charge";
            this.metroButtonChageCharge.UseSelectable = true;
            this.metroButtonChageCharge.Click += new System.EventHandler(this.metroButtonChageCharge_Click);
            // 
            // metroButtonViewCurrentCharges
            // 
            this.metroButtonViewCurrentCharges.Location = new System.Drawing.Point(4, 162);
            this.metroButtonViewCurrentCharges.Name = "metroButtonViewCurrentCharges";
            this.metroButtonViewCurrentCharges.Size = new System.Drawing.Size(149, 32);
            this.metroButtonViewCurrentCharges.TabIndex = 8;
            this.metroButtonViewCurrentCharges.Text = "View Current Charges:";
            this.metroButtonViewCurrentCharges.UseSelectable = true;
            this.metroButtonViewCurrentCharges.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(142, 10);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(200, 29);
            this.metroComboBox1.TabIndex = 7;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroTextBoxAmount
            // 
            // 
            // 
            // 
            this.metroTextBoxAmount.CustomButton.Image = null;
            this.metroTextBoxAmount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxAmount.CustomButton.Name = "";
            this.metroTextBoxAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAmount.CustomButton.TabIndex = 1;
            this.metroTextBoxAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAmount.CustomButton.UseSelectable = true;
            this.metroTextBoxAmount.CustomButton.Visible = false;
            this.metroTextBoxAmount.Lines = new string[0];
            this.metroTextBoxAmount.Location = new System.Drawing.Point(142, 105);
            this.metroTextBoxAmount.MaxLength = 32767;
            this.metroTextBoxAmount.Name = "metroTextBoxAmount";
            this.metroTextBoxAmount.PasswordChar = '\0';
            this.metroTextBoxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAmount.SelectedText = "";
            this.metroTextBoxAmount.SelectionLength = 0;
            this.metroTextBoxAmount.SelectionStart = 0;
            this.metroTextBoxAmount.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxAmount.TabIndex = 4;
            this.metroTextBoxAmount.UseSelectable = true;
            this.metroTextBoxAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabe
            // 
            this.metroLabe.AutoSize = true;
            this.metroLabe.Location = new System.Drawing.Point(4, 109);
            this.metroLabe.Name = "metroLabe";
            this.metroLabe.Size = new System.Drawing.Size(59, 19);
            this.metroLabe.TabIndex = 1;
            this.metroLabe.Text = "Amount:";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AllowDrop = true;
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(4, 20);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(39, 19);
            this.metroLabelName.TabIndex = 0;
            this.metroLabelName.Text = "Type:";
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(193, 216);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(149, 32);
            this.metroButtonDelete.TabIndex = 13;
            this.metroButtonDelete.Text = "Delete Type";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // ChangeCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ChangeCharges";
            this.Size = new System.Drawing.Size(370, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButtonChageCharge;
        private MetroFramework.Controls.MetroButton metroButtonViewCurrentCharges;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAmount;
        private MetroFramework.Controls.MetroLabel metroLabe;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroButton metroButtonAddNewType;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNewType;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
    }
}
