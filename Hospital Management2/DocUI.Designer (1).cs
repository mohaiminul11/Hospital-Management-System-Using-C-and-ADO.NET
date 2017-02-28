namespace Hospital_Management2
{
    partial class DocUI
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panelEveryThingHolder = new System.Windows.Forms.Panel();
            this.labelDocName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.metroButton2);
            this.splitContainer1.Panel1.Controls.Add(this.metroButton1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelEveryThingHolder);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(560, 320);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 3;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.SteelBlue;
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton2.Location = new System.Drawing.Point(0, 50);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(186, 48);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "See User Info";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(186, 50);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Appoinment List";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
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
            // labelDocName
            // 
            this.labelDocName.AutoSize = true;
            this.labelDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDocName.Location = new System.Drawing.Point(141, 22);
            this.labelDocName.Name = "labelDocName";
            this.labelDocName.Size = new System.Drawing.Size(103, 25);
            this.labelDocName.TabIndex = 5;
            this.labelDocName.Text = "docName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // DocUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelDocName);
            this.Controls.Add(this.label1);
            this.Name = "DocUI";
            this.Load += new System.EventHandler(this.DocUI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panelEveryThingHolder;
        private System.Windows.Forms.Label labelDocName;
        private System.Windows.Forms.Label label1;
    }
}