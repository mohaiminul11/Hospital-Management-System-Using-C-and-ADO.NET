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
    public partial class Transection : UserControl

    {
        BLL.Fee a = new BLL.Fee();
        ComboBox[] c;
        int number;
        //string[] arr;
        List<string> nlist = new List<string>();


        BLL.ManageAppoinments ma;
       BLL.Transection ts;
        public Transection()
        {
            InitializeComponent();
            ma = new BLL.ManageAppoinments();
            ts = new BLL.Transection();
            PatientPhoneTextBox();
            
        }

        void PatientPhoneTextBox()
        {

            List<string> PatientPhones = ma.getPatientPhones();
            //metroTextBoxPatientId
            AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
            metroTextBoxPatientPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            metroTextBoxPatientPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colValues.AddRange(PatientPhones.ToArray());
            metroTextBoxPatientPhone.AutoCompleteCustomSource = colValues;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAddPatient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < number; i++) { 
                
                nlist.Add((panel1.Controls["any"+i]).Text);
            }

           
            bool b = ts.AddTransection(nlist, number, metroTextBoxPatientPhone.Text);
            if (b == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Transection Complete");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Failed!");
            }


            

        }

        private void Transection_Load(object sender, EventArgs e)
        {

        }

        private void metroCheckBoxBedCharge_CheckedChanged(object sender, EventArgs e)
        {
            //if (metroCheckBoxBedCharge.Checked == true)
            //{
            //    metroLabelDays.Show();
            //    metroTextBoxDays.Show();

            //}
            //else {
            //    metroLabelDays.Hide();
            //    metroTextBoxDays.Hide();
            //}
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            
            Int32.TryParse(metroTextBoxNoOfInput.Text,out number);
            ComboBox[] c = new ComboBox[number];
            for (int i = 0; i < number;i++ )
            {
                var txt = new ComboBox();
                c[i] = txt;
                txt.Name = "Any"+i;
                //txt.Text = "Any";
                List<string> Services = a.listOfAllServices();
                BindingSource bi = new BindingSource();
                bi.DataSource = Services;
                c[i].DataSource = bi;
                c[i].Refresh();


                txt.Location = new Point(2, 100 + (i * 28));
                txt.Visible = true;
                //c[i].Click+=new EventHandler(btnClick);
                panel1.Controls.Add(c[i]);
            }
        }

        private void metroButtonViewTransection_Click(object sender, EventArgs e)
        {
            List<DAL.Transection> vt = ts.viewAllTransection();

            if (vt == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nothing Found!");
            }
            else {

               // var a = ts.viewAllAdmin();
                BindingSource bi = new BindingSource();
                bi.DataSource = vt;

                ViewAll v = new ViewAll();
                v.changeValues(bi, "Transections", "Transections");
                v.Show();
            }
        }


    }
}
