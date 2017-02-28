using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Hospital_Management2
{
    public partial class ViewAll : MetroFramework.Forms.MetroForm
    {
        public ViewAll()
        {
            InitializeComponent();
        }

        public void changeValues(BindingSource c,string s, string type)
        {
            label.Text = s;
            if(type=="EmployeeAccounts"){
                dataGridView.AutoGenerateColumns = false;
                dataGridView.ColumnCount = 5;

                dataGridView.Columns[0].Name = "Id";
                dataGridView.Columns[0].DataPropertyName = "Id";
                dataGridView.Columns[1].Name = "User Name";
                dataGridView.Columns[1].DataPropertyName = "UserName";
                dataGridView.Columns[2].Name = "FullName";
                dataGridView.Columns[2].DataPropertyName = "FullName";
                dataGridView.Columns[3].Name = "Phone";
                dataGridView.Columns[3].DataPropertyName = "Phone";
                dataGridView.Columns[4].Name = "Address";
                dataGridView.Columns[4].DataPropertyName = "Address";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView.DataSource = c;
                dataGridView.Refresh();
            }
            else if (type == "Charges")
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.ColumnCount = 2;

                dataGridView.Columns[0].Name = "Fee Name";
                dataGridView.Columns[0].DataPropertyName = "FeeName";
                dataGridView.Columns[1].Name = "Charge";
                dataGridView.Columns[1].DataPropertyName = "Charge";
                dataGridView.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView.DataSource = c;
                dataGridView.Refresh();
            }
            else if (type == "Appoinments")
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.ColumnCount = 5;

                dataGridView.Columns[0].Name = "Appoinment ID";
                dataGridView.Columns[0].DataPropertyName = "appoinmentID";
                dataGridView.Columns[1].Name = "Doctor Name";
                dataGridView.Columns[1].DataPropertyName = "DoctorUname";
                dataGridView.Columns[2].Name = "Patient Phone";
                dataGridView.Columns[2].DataPropertyName = "PatientPhone";
                dataGridView.Columns[3].Name = "Date";
                dataGridView.Columns[3].DataPropertyName = "Date";
                dataGridView.Columns[4].Name = "Done";
                dataGridView.Columns[4].DataPropertyName = "Done";

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView.DataSource = c;
                dataGridView.Refresh();
            }
            else if (type == "Transections")
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.ColumnCount = 4;

                dataGridView.Columns[0].Name = "Transection Id";
                dataGridView.Columns[0].DataPropertyName = "TransectionId";
                dataGridView.Columns[1].Name = "Patient Phone";
                dataGridView.Columns[1].DataPropertyName = "PatientPhone";
                dataGridView.Columns[2].Name = "Total";
                dataGridView.Columns[2].DataPropertyName = "Total";
                dataGridView.Columns[3].Name = "Date";
                dataGridView.Columns[3].DataPropertyName = "Date";;

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView.DataSource = c;
                dataGridView.Refresh();
            }
            else if (type == "ALLBeds")
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.ColumnCount = 3;

                dataGridView.Columns[0].Name = "BedId";
                dataGridView.Columns[0].DataPropertyName = "BedId";
                dataGridView.Columns[1].Name = "Assigned";
                dataGridView.Columns[1].DataPropertyName = "Assigned";
                dataGridView.Columns[2].Name = "PatientPhone";
                dataGridView.Columns[2].DataPropertyName = "PatientPhone";

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView.DataSource = c;
                dataGridView.Refresh();
            }
            else if (type == "Patients")
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.ColumnCount = 4;

                dataGridView.Columns[0].Name = "PatientId";
                dataGridView.Columns[0].DataPropertyName = "PatientId";
                dataGridView.Columns[1].Name = "Name";
                dataGridView.Columns[1].DataPropertyName = "Name";
                dataGridView.Columns[2].Name = "PhoneNo";
                dataGridView.Columns[2].DataPropertyName = "PhoneNo";
                dataGridView.Columns[3].Name = "ContactAddress";
                dataGridView.Columns[3].DataPropertyName = "ContactAddress";

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView.DataSource = c;
                dataGridView.Refresh();
            }
            
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {

        }
    }
}
