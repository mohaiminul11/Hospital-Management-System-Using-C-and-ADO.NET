using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management2.User_Controls;

namespace Hospital_Management2
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        public int id;
        public Admin()
        {
            InitializeComponent();
            panelEveryThingHolder.Controls.Clear();
            ManageAccounts a = new ManageAccounts();
            panelEveryThingHolder.Controls.Add(a);
        }

        public void changeInfo(string s)
        {
            this.labelAdminName.Text = s;
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            ManageAccounts a = new ManageAccounts();
            panelEveryThingHolder.Controls.Add(a);
        }

        private void metroButtonChangeCharges_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            ChangeCharges a = new ChangeCharges();
            panelEveryThingHolder.Controls.Add(a);
        }

        private void metroButtonAddAppoinment_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            ManageAppoinments a = new ManageAppoinments();
            panelEveryThingHolder.Controls.Add(a);
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            AddPatient a = new AddPatient();
            panelEveryThingHolder.Controls.Add(a);
        }

        private void metroButtonLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin u = new UserLogin();
            u.Show();
        }
    }
}
