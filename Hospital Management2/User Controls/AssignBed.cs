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
    public partial class AssignBed : UserControl
    {
        BLL.ManageAppoinments ma = new BLL.ManageAppoinments();
        //BLL.ManageAppoinments m = new BLL.ManageAppoinments();
        BLL.BedRelated b = new BLL.BedRelated();
        public AssignBed()
        {

            InitializeComponent();
            AssignComboBox();
            ChangeFreeBedComboBox();
            assignPhoneNoToTextField();
            //View v = new View();
            //v.changeDataGridView(bi);
            
        }

        void assignPhoneNoToTextField() {
            List<string> PatientPhones = ma.getPatientPhones();
            AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
            metroTextBoxPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            metroTextBoxPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colValues.AddRange(PatientPhones.ToArray());
            metroTextBoxPhone.AutoCompleteCustomSource = colValues;
        }
        void AssignComboBox() {
            List<int> a = b.getInfo();
            BindingSource bi = new BindingSource();
            bi.DataSource = a;
            metroComboBoxSelectBed.DataSource = bi;
            metroComboBoxSelectBed.Refresh();
            
        }

        void ChangeFreeBedComboBox() {
            List<int> a = b.OccupiedBed();
            BindingSource bi = new BindingSource();
            bi.DataSource = a;
            metroComboBoxFreeBed.DataSource = bi;
            metroComboBoxFreeBed.Refresh();
        }

        void ChangePhoneTextBox() {

            List<string> PatientPhones = ma.getPatientPhones();
            //metroTextBoxPatientId
            AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
            metroTextBoxPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            metroTextBoxPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colValues.AddRange(PatientPhones.ToArray());
            metroTextBoxPhone.AutoCompleteCustomSource = colValues;
        
        }

        private void metroButtonAddPatient_Click(object sender, EventArgs e)
        {
            if (metroTextBoxPhone.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Phone No.");
            }
            else {
                bool x = b.assign(metroTextBoxPhone.Text, metroComboBoxSelectBed.Text);
                if (x == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Bed Assigned!");
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this,"Bed Asssignment Failed!");
                }
            }

            ChangeFreeBedComboBox();
        }

        private void metroButtonShowAllBed_Click(object sender, EventArgs e)
        {
            List<DAL.BedTable> bt = b.ShowAllBeds();
            BindingSource bi = new BindingSource();
            bi.DataSource = bt;

            ViewAll v = new ViewAll();
            v.changeValues(bi, "ALL Beds", "ALLBeds");
            v.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAddBed_Click(object sender, EventArgs e)
        {
            bool bx=b.AddBed(metroTextBoxAddBed.Text);
            if (bx == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Successfully Added.");
            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Failed!");
            }
        }

        private void metroButtonFreeBed_Click(object sender, EventArgs e)
        {

            if (metroComboBoxFreeBed.Text != "")
            {
                bool bx = b.freeBed(metroComboBoxFreeBed.Text);
                if (bx == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Bed Freed!");
                    AssignComboBox();
                    ChangeFreeBedComboBox();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Failed!");
                }
            }
            else {
                MetroFramework.MetroMessageBox.Show(this,"Check Input.");
            }
        }
    }
}
