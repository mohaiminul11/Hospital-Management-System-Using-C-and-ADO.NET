namespace Hospital_Management2
{
    partial class Admin
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metro = new MetroFramework.Controls.MetroButton();
            this.metroButtonAddAppoinment = new MetroFramework.Controls.MetroButton();
            this.metroButtonChangeCharges = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.panelEveryThingHolder = new System.Windows.Forms.Panel();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel1.Controls.Add(this.metroButtonLogout);
            this.splitContainer1.Panel1.Controls.Add(this.metro);
            this.splitContainer1.Panel1.Controls.Add(this.metroButtonAddAppoinment);
            this.splitContainer1.Panel1.Controls.Add(this.metroButtonChangeCharges);
            this.splitContainer1.Panel1.Controls.Add(this.metroButton3);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelEveryThingHolder);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(560, 320);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 6;
            // 
            // metro
            // 
            this.metro.BackColor = System.Drawing.Color.SteelBlue;
            this.metro.Dock = System.Windows.Forms.DockStyle.Top;
            this.metro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metro.Location = new System.Drawing.Point(0, 150);
            this.metro.Name = "metro";
            this.metro.Size = new System.Drawing.Size(186, 50);
            this.metro.TabIndex = 7;
            this.metro.Text = "Manage Patient Info";
            this.metro.UseCustomBackColor = true;
            this.metro.UseCustomForeColor = true;
            this.metro.UseSelectable = true;
            this.metro.Click += new System.EventHandler(this.metroButtonLogout_Click);
            // 
            // metroButtonAddAppoinment
            // 
            this.metroButtonAddAppoinment.BackColor = System.Drawing.Color.SteelBlue;
            this.metroButtonAddAppoinment.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonAddAppoinment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButtonAddAppoinment.Location = new System.Drawing.Point(0, 100);
            this.metroButtonAddAppoinment.Name = "metroButtonAddAppoinment";
            this.metroButtonAddAppoinment.Size = new System.Drawing.Size(186, 50);
            this.metroButtonAddAppoinment.TabIndex = 6;
            this.metroButtonAddAppoinment.Text = "Manage Appoinments";
            this.metroButtonAddAppoinment.UseCustomBackColor = true;
            this.metroButtonAddAppoinment.UseCustomForeColor = true;
            this.metroButtonAddAppoinment.UseSelectable = true;
            this.metroButtonAddAppoinment.Click += new System.EventHandler(this.metroButtonAddAppoinment_Click);
            // 
            // metroButtonChangeCharges
            // 
            this.metroButtonChangeCharges.BackColor = System.Drawing.Color.SteelBlue;
            this.metroButtonChangeCharges.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonChangeCharges.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButtonChangeCharges.Location = new System.Drawing.Point(0, 50);
            this.metroButtonChangeCharges.Name = "metroButtonChangeCharges";
            this.metroButtonChangeCharges.Size = new System.Drawing.Size(186, 50);
            this.metroButtonChangeCharges.TabIndex = 5;
            this.metroButtonChangeCharges.Text = "Change charges";
            this.metroButtonChangeCharges.UseCustomBackColor = true;
            this.metroButtonChangeCharges.UseCustomForeColor = true;
            this.metroButtonChangeCharges.UseSelectable = true;
            this.metroButtonChangeCharges.Click += new System.EventHandler(this.metroButtonChangeCharges_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.SteelBlue;
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton3.Location = new System.Drawing.Point(0, 0);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(186, 50);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Manage Employee Info";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // panelEveryThingHolder
            // 
            this.panelEveryThingHolder.BackColor = System.Drawing.Color.Teal;
            this.panelEveryThingHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEveryThingHolder.ForeColor = System.Drawing.Color.White;
            this.panelEveryThingHolder.Location = new System.Drawing.Point(0, 0);
            this.panelEveryThingHolder.Name = "panelEveryThingHolder";
            this.panelEveryThingHolder.Size = new System.Drawing.Size(370, 320);
            this.panelEveryThingHolder.TabIndex = 0;
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAdminName.Location = new System.Drawing.Point(141, 21);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(128, 25);
            this.labelAdminName.TabIndex = 8;
            this.labelAdminName.Text = "AdminName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.metroButtonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButtonLogout.Location = new System.Drawing.Point(0, 200);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(186, 50);
            this.metroButtonLogout.TabIndex = 8;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.UseCustomBackColor = true;
            this.metroButtonLogout.UseCustomForeColor = true;
            this.metroButtonLogout.UseSelectable = true;
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click_1);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelAdminName);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelEveryThingHolder;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButtonChangeCharges;
        private MetroFramework.Controls.MetroButton metroButtonAddAppoinment;
        private MetroFramework.Controls.MetroButton metro;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
    }
}