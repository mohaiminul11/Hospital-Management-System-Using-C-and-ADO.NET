namespace Hospital_Management2.User_Controls
{
    partial class ManageAccounts
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
            this.metroButtonRefresh = new MetroFramework.Controls.MetroButton();
            this.metroButtonUpdate = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonViewAll = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxAccType = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFullName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabe = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTextBoxUsername);
            this.panel1.Controls.Add(this.metroButtonRefresh);
            this.panel1.Controls.Add(this.metroButtonUpdate);
            this.panel1.Controls.Add(this.metroButtonDelete);
            this.panel1.Controls.Add(this.metroButtonAdd);
            this.panel1.Controls.Add(this.metroButtonViewAll);
            this.panel1.Controls.Add(this.metroTextBoxAddress);
            this.panel1.Controls.Add(this.metroTextBoxPhone);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.comboBoxAccType);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroTextBoxFullName);
            this.panel1.Controls.Add(this.metroTextBoxPassword);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabe);
            this.panel1.Controls.Add(this.metroLabelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 320);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroButtonRefresh
            // 
            this.metroButtonRefresh.Location = new System.Drawing.Point(113, 279);
            this.metroButtonRefresh.Name = "metroButtonRefresh";
            this.metroButtonRefresh.Size = new System.Drawing.Size(97, 32);
            this.metroButtonRefresh.TabIndex = 17;
            this.metroButtonRefresh.Text = "Refresh";
            this.metroButtonRefresh.UseSelectable = true;
            this.metroButtonRefresh.Click += new System.EventHandler(this.metroButtonRefresh_Click);
            // 
            // metroButtonUpdate
            // 
            this.metroButtonUpdate.Location = new System.Drawing.Point(5, 279);
            this.metroButtonUpdate.Name = "metroButtonUpdate";
            this.metroButtonUpdate.Size = new System.Drawing.Size(97, 32);
            this.metroButtonUpdate.TabIndex = 16;
            this.metroButtonUpdate.Text = "Update";
            this.metroButtonUpdate.UseSelectable = true;
            this.metroButtonUpdate.Click += new System.EventHandler(this.metroButtonUpdate_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(220, 230);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(97, 32);
            this.metroButtonDelete.TabIndex = 15;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.UseSelectable = true;
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(113, 230);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(97, 32);
            this.metroButtonAdd.TabIndex = 14;
            this.metroButtonAdd.Text = "Add";
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButtonViewAll
            // 
            this.metroButtonViewAll.Location = new System.Drawing.Point(5, 230);
            this.metroButtonViewAll.Name = "metroButtonViewAll";
            this.metroButtonViewAll.Size = new System.Drawing.Size(97, 32);
            this.metroButtonViewAll.TabIndex = 13;
            this.metroButtonViewAll.Text = "View All";
            this.metroButtonViewAll.UseSelectable = true;
            this.metroButtonViewAll.Click += new System.EventHandler(this.metroButtonViewAll_Click);
            // 
            // metroTextBoxAddress
            // 
            // 
            // 
            // 
            this.metroTextBoxAddress.CustomButton.Image = null;
            this.metroTextBoxAddress.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.metroTextBoxAddress.CustomButton.Name = "";
            this.metroTextBoxAddress.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAddress.CustomButton.TabIndex = 1;
            this.metroTextBoxAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAddress.CustomButton.UseSelectable = true;
            this.metroTextBoxAddress.CustomButton.Visible = false;
            this.metroTextBoxAddress.Lines = new string[0];
            this.metroTextBoxAddress.Location = new System.Drawing.Point(117, 193);
            this.metroTextBoxAddress.MaxLength = 32767;
            this.metroTextBoxAddress.Name = "metroTextBoxAddress";
            this.metroTextBoxAddress.PasswordChar = '\0';
            this.metroTextBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAddress.SelectedText = "";
            this.metroTextBoxAddress.SelectionLength = 0;
            this.metroTextBoxAddress.SelectionStart = 0;
            this.metroTextBoxAddress.Size = new System.Drawing.Size(200, 21);
            this.metroTextBoxAddress.TabIndex = 12;
            this.metroTextBoxAddress.UseSelectable = true;
            this.metroTextBoxAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPhone
            // 
            // 
            // 
            // 
            this.metroTextBoxPhone.CustomButton.Image = null;
            this.metroTextBoxPhone.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.metroTextBoxPhone.CustomButton.Name = "";
            this.metroTextBoxPhone.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPhone.CustomButton.TabIndex = 1;
            this.metroTextBoxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPhone.CustomButton.UseSelectable = true;
            this.metroTextBoxPhone.CustomButton.Visible = false;
            this.metroTextBoxPhone.Lines = new string[0];
            this.metroTextBoxPhone.Location = new System.Drawing.Point(117, 155);
            this.metroTextBoxPhone.MaxLength = 32767;
            this.metroTextBoxPhone.Name = "metroTextBoxPhone";
            this.metroTextBoxPhone.PasswordChar = '\0';
            this.metroTextBoxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPhone.SelectedText = "";
            this.metroTextBoxPhone.SelectionLength = 0;
            this.metroTextBoxPhone.SelectionStart = 0;
            this.metroTextBoxPhone.Size = new System.Drawing.Size(200, 21);
            this.metroTextBoxPhone.TabIndex = 11;
            this.metroTextBoxPhone.UseSelectable = true;
            this.metroTextBoxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Address:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(5, 155);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Phone:";
            // 
            // comboBoxAccType
            // 
            this.comboBoxAccType.FormattingEnabled = true;
            this.comboBoxAccType.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.comboBoxAccType.Location = new System.Drawing.Point(117, 5);
            this.comboBoxAccType.Name = "comboBoxAccType";
            this.comboBoxAccType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAccType.TabIndex = 8;
            this.comboBoxAccType.SelectedIndexChanged += new System.EventHandler(this.MakeChages);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Acc. Type:";
            // 
            // metroTextBoxFullName
            // 
            // 
            // 
            // 
            this.metroTextBoxFullName.CustomButton.Image = null;
            this.metroTextBoxFullName.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.metroTextBoxFullName.CustomButton.Name = "";
            this.metroTextBoxFullName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFullName.CustomButton.TabIndex = 1;
            this.metroTextBoxFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFullName.CustomButton.UseSelectable = true;
            this.metroTextBoxFullName.CustomButton.Visible = false;
            this.metroTextBoxFullName.Lines = new string[0];
            this.metroTextBoxFullName.Location = new System.Drawing.Point(117, 117);
            this.metroTextBoxFullName.MaxLength = 32767;
            this.metroTextBoxFullName.Name = "metroTextBoxFullName";
            this.metroTextBoxFullName.PasswordChar = '\0';
            this.metroTextBoxFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFullName.SelectedText = "";
            this.metroTextBoxFullName.SelectionLength = 0;
            this.metroTextBoxFullName.SelectionStart = 0;
            this.metroTextBoxFullName.Size = new System.Drawing.Size(200, 21);
            this.metroTextBoxFullName.TabIndex = 5;
            this.metroTextBoxFullName.UseSelectable = true;
            this.metroTextBoxFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(117, 81);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '\0';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(200, 21);
            this.metroTextBoxPassword.TabIndex = 4;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Full Name:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabe
            // 
            this.metroLabe.AutoSize = true;
            this.metroLabe.Location = new System.Drawing.Point(5, 79);
            this.metroLabe.Name = "metroLabe";
            this.metroLabe.Size = new System.Drawing.Size(66, 19);
            this.metroLabe.TabIndex = 1;
            this.metroLabe.Text = "Password:";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(3, 43);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(71, 19);
            this.metroLabelName.TabIndex = 0;
            this.metroLabelName.Text = "Username:";
            // 
            // metroTextBoxUsername
            // 
            this.metroTextBoxUsername.Location = new System.Drawing.Point(117, 43);
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.metroTextBoxUsername.TabIndex = 18;
            this.metroTextBoxUsername.TextChanged += new System.EventHandler(this.metroTextBoxUsername_TextChanged);
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageAccounts";
            this.Size = new System.Drawing.Size(370, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddress;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPhone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox comboBoxAccType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFullName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabe;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroButton metroButtonUpdate;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroButton metroButtonViewAll;
        private MetroFramework.Controls.MetroButton metroButtonRefresh;
        private System.Windows.Forms.TextBox metroTextBoxUsername;
    }
}
