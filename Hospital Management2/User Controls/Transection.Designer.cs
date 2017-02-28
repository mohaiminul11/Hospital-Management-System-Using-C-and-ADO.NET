namespace Hospital_Management2.User_Controls
{
    partial class Transection
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
            this.metroTextBoxPatientPhone = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNoOfInput = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonCompleteTransection = new MetroFramework.Controls.MetroButton();
            this.metroButtonViewTransection = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButtonViewTransection);
            this.panel1.Controls.Add(this.metroTextBoxPatientPhone);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroButtonAdd);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroTextBoxNoOfInput);
            this.panel1.Controls.Add(this.metroButtonCompleteTransection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 320);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroTextBoxPatientPhone
            // 
            this.metroTextBoxPatientPhone.Location = new System.Drawing.Point(98, 5);
            this.metroTextBoxPatientPhone.Name = "metroTextBoxPatientPhone";
            this.metroTextBoxPatientPhone.Size = new System.Drawing.Size(157, 20);
            this.metroTextBoxPatientPhone.TabIndex = 13;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Patient Phone";
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(274, 42);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.metroButtonAdd.TabIndex = 10;
            this.metroButtonAdd.Text = "Add";
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "No Of Fees";
            // 
            // metroTextBoxNoOfInput
            // 
            // 
            // 
            // 
            this.metroTextBoxNoOfInput.CustomButton.Image = null;
            this.metroTextBoxNoOfInput.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.metroTextBoxNoOfInput.CustomButton.Name = "";
            this.metroTextBoxNoOfInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxNoOfInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNoOfInput.CustomButton.TabIndex = 1;
            this.metroTextBoxNoOfInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNoOfInput.CustomButton.UseSelectable = true;
            this.metroTextBoxNoOfInput.CustomButton.Visible = false;
            this.metroTextBoxNoOfInput.Lines = new string[0];
            this.metroTextBoxNoOfInput.Location = new System.Drawing.Point(98, 42);
            this.metroTextBoxNoOfInput.MaxLength = 32767;
            this.metroTextBoxNoOfInput.Name = "metroTextBoxNoOfInput";
            this.metroTextBoxNoOfInput.PasswordChar = '\0';
            this.metroTextBoxNoOfInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNoOfInput.SelectedText = "";
            this.metroTextBoxNoOfInput.SelectionLength = 0;
            this.metroTextBoxNoOfInput.SelectionStart = 0;
            this.metroTextBoxNoOfInput.Size = new System.Drawing.Size(157, 23);
            this.metroTextBoxNoOfInput.TabIndex = 7;
            this.metroTextBoxNoOfInput.UseSelectable = true;
            this.metroTextBoxNoOfInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNoOfInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonCompleteTransection
            // 
            this.metroButtonCompleteTransection.Location = new System.Drawing.Point(215, 273);
            this.metroButtonCompleteTransection.Name = "metroButtonCompleteTransection";
            this.metroButtonCompleteTransection.Size = new System.Drawing.Size(134, 32);
            this.metroButtonCompleteTransection.TabIndex = 6;
            this.metroButtonCompleteTransection.Text = "Complete Transection";
            this.metroButtonCompleteTransection.UseSelectable = true;
            this.metroButtonCompleteTransection.Click += new System.EventHandler(this.metroButtonAddPatient_Click);
            // 
            // metroButtonViewTransection
            // 
            this.metroButtonViewTransection.Location = new System.Drawing.Point(215, 226);
            this.metroButtonViewTransection.Name = "metroButtonViewTransection";
            this.metroButtonViewTransection.Size = new System.Drawing.Size(134, 32);
            this.metroButtonViewTransection.TabIndex = 14;
            this.metroButtonViewTransection.Text = "View All Transection";
            this.metroButtonViewTransection.UseSelectable = true;
            this.metroButtonViewTransection.Click += new System.EventHandler(this.metroButtonViewTransection_Click);
            // 
            // Transection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Transection";
            this.Size = new System.Drawing.Size(370, 320);
            this.Load += new System.EventHandler(this.Transection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButtonCompleteTransection;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNoOfInput;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox metroTextBoxPatientPhone;
        private MetroFramework.Controls.MetroButton metroButtonViewTransection;
    }
}
