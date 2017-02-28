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

namespace Hospital_Management2.User_Controls
{
    public partial class AddPatient : UserControl
    {
        UserInfoHandler u = new UserInfoHandler();
        BLL.ManageAppoinments m = new BLL.ManageAppoinments();
        public AddPatient()
        {
            InitializeComponent();
            initializePhoneNoComboBox();
        }


        void initializePhoneNoComboBox() {
            List<string> PatientPhones = m.getPatientPhones();
            //metroTextBoxPatientId
            AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
            metroTextBoxPhoneNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            metroTextBoxPhoneNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colValues.AddRange(PatientPhones.ToArray());
            metroTextBoxPhoneNo.AutoCompleteCustomSource = colValues;
        }
        private void metroButtonAddPatient_Click(object sender, EventArgs e)
        {
            if (metroTextBoxPhoneNo.Text != ""&&metroTextBoxName.Text!=""&&metroTextBoxContactAddress.Text!="")
            {
                BLL.UserInfoHandler ui = new BLL.UserInfoHandler();
                bool bx=ui.AddPatient(metroTextBoxName.Text, metroTextBoxPhoneNo.Text, metroTextBoxContactAddress.Text);
                if (bx == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Patient Added!");
                    initializePhoneNoComboBox();
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this,"Failed!");
                }
       
            }
            else {
                MetroFramework.MetroMessageBox.Show(this,"Please Enter All Values");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonViewAll_Click(object sender, EventArgs e)
        {
            var a = u.viewAllPatients();
            BindingSource bi = new BindingSource();
            bi.DataSource = a;

            ViewAll v = new ViewAll();
            v.changeValues(bi, "Patients", "Patients");
            v.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBoxPhoneNo.Text != "")
            {
                bool bx = u.DeletePatient(metroTextBoxPhoneNo.Text);
                if (bx == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Failed!");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Deleted.");
                }
            }
            else {
                MetroFramework.MetroMessageBox.Show(this,"Please Enter Phone No.");
            }
            
        }

        private void metroButtonModify_Click(object sender, EventArgs e)
        {
            if (metroTextBoxPhoneNo.Text != "")
            {
                bool bx = u.PatientModify(metroTextBoxPhoneNo.Text, metroTextBoxName.Text, metroTextBoxContactAddress.Text);
                if (bx == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Successfully Modified.");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Modification Failed!");
                }
            }
            else {
                MetroFramework.MetroMessageBox.Show(this,"Please Enter Phone No.");
            }
        }
    }
}
