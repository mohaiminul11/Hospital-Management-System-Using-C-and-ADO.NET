using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MetroFramework;

namespace Hospital_Management2.User_Controls
{
    public partial class DocAppoinments : UserControl
    {
        public string id;

        BLL.ManageAppoinments u = new BLL.ManageAppoinments();
        public DocAppoinments()
        {
            InitializeComponent();
        }

        private void metroButtonViewCurrentCharges_Click(object sender, EventArgs e)
        {

            //MetroFramework.MetroMessageBox.Show(this,id.ToString());
            List<DAL.Appoinment> a = u.docAppoinmentList(id);

            bool isEmpty = !a.Any();

            BindingSource bi = new BindingSource();
            bi.DataSource = a;

            if (isEmpty==false)
            {
                ViewAll v = new ViewAll();
                v.changeValues(bi, "Appoinments", "Appoinments");
                v.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Nothing found!");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonChageCharge_Click(object sender, EventArgs e)
        {
            bool b = u.DocMarkAsDone(metroTextBoxAppoinmentId.Text);
            if (b)
            {
                MetroFramework.MetroMessageBox.Show(this, "Done!");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Failed!");
            }
        }
    }
}
