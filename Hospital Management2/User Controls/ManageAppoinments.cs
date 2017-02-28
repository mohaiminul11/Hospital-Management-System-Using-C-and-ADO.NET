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
    public partial class ManageAppoinments : UserControl
    {
        BLL.ManageAppoinments m = new BLL.ManageAppoinments();
        
        public ManageAppoinments()
        {
            InitializeComponent();
            initiateDocNameTextBox();
            PatientPhoneTextBox();
        }

        void initiateDocNameTextBox() {
            List<string> docName = m.getDocNames();
            //metroTextBoxDocName
            AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
            metroTextBoxDocName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            metroTextBoxDocName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colValues.AddRange(docName.ToArray());
            metroTextBoxDocName.AutoCompleteCustomSource = colValues;
            
           
        }

        void PatientPhoneTextBox() {

            List<string> PatientPhones = m.getPatientPhones();
            //metroTextBoxPatientId
            AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
            metroTextBoxPatientId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            metroTextBoxPatientId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colValues.AddRange(PatientPhones.ToArray());
            metroTextBoxPatientId.AutoCompleteCustomSource = colValues;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonChageCharge_Click(object sender, EventArgs e)
        {
            if (metroTextBoxDocName.Text != "" && metroTextBoxPatientId.Text != "" && metroDateTime1.Text != "")
            {
                BLL.ManageAppoinments m = new BLL.ManageAppoinments();
                bool bx=m.AddAppoinment(metroTextBoxDocName.Text, metroTextBoxPatientId.Text, metroDateTime1.Text);
                if (bx == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Appoinment Added!");
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "Failed to Add Appoinment.");
                }
                
            }

            else {
                MetroFramework.MetroMessageBox.Show(this, "Please Fill All The Fields.");
            }
        }

        BLL.ManageAppoinments u = new BLL.ManageAppoinments();
        private void metroButtonViewCurrentCharges_Click(object sender, EventArgs e)
        {
            if (metroTextBoxDocName.Text!=""&&metroDateTime1.Text!="")
            {
                List<DAL.Appoinment> a = u.getAppoinments(metroTextBoxDocName.Text,metroDateTime1.Text);

                if (a == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nothing Found!");
                }
                else
                {
                    BindingSource bi = new BindingSource();
                    bi.DataSource = a;

                    ViewAll v = new ViewAll();
                    v.changeValues(bi, "Appoinments", "Appoinments");
                    v.Show();
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Doc Id and Date");
            }
            
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {

            if (metroTextBoxDocName.Text != "" && metroDateTime1.Text!="")
            {
                List<DAL.Appoinment> a = u.getAppoinments(metroTextBoxDocName.Text, metroDateTime1.Text);

                if (a == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nothing Found!");
                }
                else
                {
                    BindingSource bi = new BindingSource();
                    bi.DataSource = a;

                    ViewAll v = new ViewAll();
                    DeleteAppoinment d = new DeleteAppoinment();
                    d.changeValues(bi);
                    d.Show();
                }
            }
            else {
                MetroFramework.MetroMessageBox.Show(this,"Please Enter Doc Username and Date");
            }
        }

        private void metroTextBoxPatientId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
