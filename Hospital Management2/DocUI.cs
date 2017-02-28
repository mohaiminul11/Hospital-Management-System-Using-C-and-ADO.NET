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
    public partial class DocUI : MetroFramework.Forms.MetroForm
    {
        public string id;
        public DocUI()
        {
            InitializeComponent();
            //panelEveryThingHolder.Controls.Clear();
            //DocAppoinments a = new DocAppoinments();
            //a.id = id;
            //panelEveryThingHolder.Controls.Add(a);
        }

        public void changeInfo(string s)
        {
            this.labelDocName.Text = s;
        }

        private void DocUI_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonAddAppoinment_Click(object sender, EventArgs e)
        {
            //MetroFramework.MetroMessageBox.Show(this,id.ToString());
            panelEveryThingHolder.Controls.Clear();
            DocAppoinments a = new DocAppoinments();
            a.id = id;
            panelEveryThingHolder.Controls.Add(a);
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin u = new UserLogin();
            u.Show();


        }
    }
}
