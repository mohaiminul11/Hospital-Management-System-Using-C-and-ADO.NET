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
    public partial class ManageAccounts : UserControl
    {
        UserInfoHandler u = new UserInfoHandler();
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (comboBoxAccType.Text != "" && metroTextBoxUsername.Text != "" && metroTextBoxPassword.Text != "" && metroTextBoxFullName.Text != "" && metroTextBoxPhone.Text != "" && metroTextBoxAddress.Text!="")
            {
                if (comboBoxAccType.Text == "Admin")
                {
                    bool m = u.AddAdmin(metroTextBoxUsername.Text, metroTextBoxPassword.Text, metroTextBoxFullName.Text, metroTextBoxPhone.Text, metroTextBoxAddress.Text);
                    if (m == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Admin Account Added Successfully.");
                    }
                }
                else if (comboBoxAccType.Text == "Doctor")
                {
                    bool m = u.AddDoc(metroTextBoxUsername.Text, metroTextBoxPassword.Text, metroTextBoxFullName.Text, metroTextBoxPhone.Text, metroTextBoxAddress.Text);
                    if (m == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Doctor Account Added Successfully.");
                    }
                }
                else if (comboBoxAccType.Text == "Receptionist")
                {
                    bool m = u.AddReceptionist(metroTextBoxUsername.Text, metroTextBoxPassword.Text, metroTextBoxFullName.Text, metroTextBoxPhone.Text, metroTextBoxAddress.Text);
                    if (m == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Receptionist Account Added Successfully.");
                    }
                }
            }
            
            else {
                MetroFramework.MetroMessageBox.Show(this,"Please Put All Inputs.");
            }
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            //MetroFramework.MetroMessageBox.Show(this, "Hi There!");
            BLL.UserInfoHandler u = new BLL.UserInfoHandler();
            if (comboBoxAccType.Text == "Admin")
            {
                bool m = u.DeleteAdminInfo(metroTextBoxUsername.Text);
                if (m == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Admin Account Deleted Successfully!");
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "No Such Account Found!");
                }
            }


            else if (comboBoxAccType.Text == "Doctor")
            {
                bool m = u.DeleteDocInfo(metroTextBoxUsername.Text);
                if (m == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Doctor Account Deleted Successfully!");
                }else {
                    MetroFramework.MetroMessageBox.Show(this, "No Such Account Found!");
                }
            }


            else if (comboBoxAccType.Text == "Receptionist")
            {
                bool m = u.DeleteReceptionistInfo(metroTextBoxUsername.Text);
                if (m == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Receptionist Account Deleted Successfully!");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No Such Account Found!");
                }
            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Please select Account Type");
            }
        }

        private void metroButtonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxAccType.Text = "";
            metroTextBoxUsername.Text = "";
            metroTextBoxPassword.Text = "";
            metroTextBoxFullName.Text = "";
            metroTextBoxPhone.Text = "";
            metroTextBoxAddress.Text = "";
        }


        //Admin
        //Doctor
        //Receptionist
        private void metroButtonViewAll_Click(object sender, EventArgs e)
        {
            BLL.UserInfoHandler u= new BLL.UserInfoHandler();

            if(comboBoxAccType.Text=="Admin"){
                            
            var a = u.viewAllAdmin();
            BindingSource bi = new BindingSource();
            bi.DataSource = a;

            ViewAll v = new ViewAll();
            v.changeValues(bi, "Admins", "EmployeeAccounts");
            v.Show();
            
            }else if(comboBoxAccType.Text=="Doctor"){
                
            List<DAL.Doctor> a = u.viewAllDoctors();
            BindingSource bi = new BindingSource();
            bi.DataSource = a;

            ViewAll v = new ViewAll();
            v.changeValues(bi, "Doctors", "EmployeeAccounts");
            v.Show();

            }
            else if (comboBoxAccType.Text == "Receptionist")
            {

                List<DAL.Receptionist> a = u.viewAllReceptionists();
                BindingSource bi = new BindingSource();
                bi.DataSource = a;

                ViewAll v = new ViewAll();
                v.changeValues(bi, "Receptionists", "EmployeeAccounts");
                v.Show();

            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Please Select Account Type.");
            }
            
        }

        private void metroButtonUpdate_Click(object sender, EventArgs e)
        {
            UserInfoHandler u = new UserInfoHandler();
            if (comboBoxAccType.Text == "Admin")
            {
                bool m = u.UpdateAdminInfo(metroTextBoxUsername.Text, metroTextBoxPassword.Text, metroTextBoxFullName.Text, metroTextBoxPhone.Text, metroTextBoxAddress.Text);
                if (m == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Account Updated!");
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "Something went Wrong! please Check input.");
                }
            }
            else if (comboBoxAccType.Text == "Doctor")
            {
                bool m = u.UpdateDocInfo(metroTextBoxUsername.Text, metroTextBoxPassword.Text, metroTextBoxFullName.Text, metroTextBoxPhone.Text, metroTextBoxAddress.Text);
                if (m == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Account Updated!");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Something went Wrong! please Check input.");
                }
            }
            else if (comboBoxAccType.Text == "Receptionist")
            {
                bool m = u.UpdateReceptionistInfo(metroTextBoxUsername.Text, metroTextBoxPassword.Text, metroTextBoxFullName.Text, metroTextBoxPhone.Text, metroTextBoxAddress.Text);
                if (m == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Account Updated!");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Something went Wrong! please Check input.");
                }
            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Please Select Account Type.");
            }
        }

        private void MakeChages(object sender, EventArgs e)
        {
            if (comboBoxAccType.Text == "Admin")
            {
                List<string> usernames = u.getAdminUsername();
                //metroTextBoxPatientId
                AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
                metroTextBoxUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                metroTextBoxUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                colValues.AddRange(usernames.ToArray());
                metroTextBoxUsername.AutoCompleteCustomSource = colValues;
            }
            else if (comboBoxAccType.Text == "Doctor")
            {
                List<string> usernames = u.getDoctorUsername();
                //metroTextBoxPatientId
                AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
                metroTextBoxUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                metroTextBoxUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                colValues.AddRange(usernames.ToArray());
                metroTextBoxUsername.AutoCompleteCustomSource = colValues;
            }
            else if (comboBoxAccType.Text == "Receptionist")
            {
                List<string> usernames = u.getReceptionistUsername();
                //metroTextBoxPatientId
                AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
                metroTextBoxUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                metroTextBoxUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                colValues.AddRange(usernames.ToArray());
                metroTextBoxUsername.AutoCompleteCustomSource = colValues;
            
            }
        }

        private void metroTextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
