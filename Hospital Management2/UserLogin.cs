using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Hospital_Management2
{
    public partial class UserLogin : MetroFramework.Forms.MetroForm
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButtonLogin_Click_1(object sender, EventArgs e)
        {
            BLL.Authenticator a = new BLL.Authenticator();
            string idval="";
            string s = a.authenticate(metroComboBoxAccountType.Text, textBoxUsername.Text, textBoxPassword.Text, ref idval);
            if (s == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check the inputs!");
            }
            else if (metroComboBoxAccountType.Text == "Admin")
            {
                Admin admin = new Admin();
                //admin.id = idval;
                admin.changeInfo(s);
                this.Hide();
                admin.Show();

                //MetroFramework.MetroMessageBox.Show(this, s);
            }
            else if (metroComboBoxAccountType.Text == "Doctor")
            {
                DocUI d = new DocUI();
                d.id = idval;
                d.changeInfo(s);
                this.Hide();
                d.Show();

            }
            else if (metroComboBoxAccountType.Text == "Receptoinist")
            {
                ReceptionistUI r = new ReceptionistUI();
                //r.id = idval;
                r.changeInfo(s);
                this.Hide();
                r.Show();
            }
        }
    }
}