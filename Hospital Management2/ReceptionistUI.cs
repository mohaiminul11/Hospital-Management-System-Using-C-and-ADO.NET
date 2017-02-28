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
    public partial class ReceptionistUI : MetroFramework.Forms.MetroForm
    {
        public int id;
        public ReceptionistUI()
        {
            InitializeComponent();
            panelEveryThingHolder.Controls.Clear();
            ManageAppoinments b = new ManageAppoinments();
            panelEveryThingHolder.Controls.Add(b);

        }

        public void changeInfo(string s)
        {
            this.labelReceptionistName.Text = s;
        }

        private void ReceptionistUI_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonAddPatient_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            AddPatient a = new AddPatient();
            panelEveryThingHolder.Controls.Add(a);
        }

        private void metroButtonTransection_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            Transection t = new Transection();
            panelEveryThingHolder.Controls.Add(t);
        }

        private void metroButtonBedAssignment_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            AssignBed b = new AssignBed();
            panelEveryThingHolder.Controls.Add(b);
        }

        private void metroButtonAppoinmentList_Click(object sender, EventArgs e)
        {
            panelEveryThingHolder.Controls.Clear();
            ManageAppoinments b = new ManageAppoinments();
            panelEveryThingHolder.Controls.Add(b);
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin u = new UserLogin();
            u.Show();
        }

    }
}
