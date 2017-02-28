namespace Hospital_Management2.User_Controls
{
    partial class DocAppoinments
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
            this.metroTextBoxAppoinmentId = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonChageCharge = new MetroFramework.Controls.MetroButton();
            this.metroButtonViewCurrentCharges = new MetroFramework.Controls.MetroButton();
            this.metroLabeDocId = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTextBoxAppoinmentId);
            this.panel1.Controls.Add(this.metroButtonChageCharge);
            this.panel1.Controls.Add(this.metroButtonViewCurrentCharges);
            this.panel1.Controls.Add(this.metroLabeDocId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 320);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroTextBoxAppoinmentId
            // 
            // 
            // 
            // 
            this.metroTextBoxAppoinmentId.CustomButton.Image = null;
            this.metroTextBoxAppoinmentId.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.metroTextBoxAppoinmentId.CustomButton.Name = "";
            this.metroTextBoxAppoinmentId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAppoinmentId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAppoinmentId.CustomButton.TabIndex = 1;
            this.metroTextBoxAppoinmentId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAppoinmentId.CustomButton.UseSelectable = true;
            this.metroTextBoxAppoinmentId.CustomButton.Visible = false;
            this.metroTextBoxAppoinmentId.Lines = new string[0];
            this.metroTextBoxAppoinmentId.Location = new System.Drawing.Point(142, 16);
            this.metroTextBoxAppoinmentId.MaxLength = 32767;
            this.metroTextBoxAppoinmentId.Name = "metroTextBoxAppoinmentId";
            this.metroTextBoxAppoinmentId.PasswordChar = '\0';
            this.metroTextBoxAppoinmentId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAppoinmentId.SelectedText = "";
            this.metroTextBoxAppoinmentId.SelectionLength = 0;
            this.metroTextBoxAppoinmentId.SelectionStart = 0;
            this.metroTextBoxAppoinmentId.Size = new System.Drawing.Size(200, 23);
            this.metroTextBoxAppoinmentId.TabIndex = 10;
            this.metroTextBoxAppoinmentId.UseSelectable = true;
            this.metroTextBoxAppoinmentId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAppoinmentId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonChageCharge
            // 
            this.metroButtonChageCharge.Location = new System.Drawing.Point(193, 179);
            this.metroButtonChageCharge.Name = "metroButtonChageCharge";
            this.metroButtonChageCharge.Size = new System.Drawing.Size(149, 32);
            this.metroButtonChageCharge.TabIndex = 9;
            this.metroButtonChageCharge.Text = "Mark as Done";
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
            // metroLabeDocId
            // 
            this.metroLabeDocId.AllowDrop = true;
            this.metroLabeDocId.AutoSize = true;
            this.metroLabeDocId.Location = new System.Drawing.Point(4, 20);
            this.metroLabeDocId.Name = "metroLabeDocId";
            this.metroLabeDocId.Size = new System.Drawing.Size(100, 19);
            this.metroLabeDocId.TabIndex = 0;
            this.metroLabeDocId.Text = "Appoinment Id:";
            // 
            // DocAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DocAppoinments";
            this.Size = new System.Drawing.Size(370, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAppoinmentId;
        private MetroFramework.Controls.MetroButton metroButtonChageCharge;
        private MetroFramework.Controls.MetroButton metroButtonViewCurrentCharges;
        private MetroFramework.Controls.MetroLabel metroLabeDocId;
    }
}
