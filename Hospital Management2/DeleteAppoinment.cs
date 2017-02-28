using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Hospital_Management2
{
    
    public partial class DeleteAppoinment : MetroFramework.Forms.MetroForm
    {
        BLL.ManageAppoinments b=new BLL.ManageAppoinments();
        public DeleteAppoinment()
        {
            InitializeComponent();
        }

        private void DeleteAppoinment_Load(object sender, EventArgs e)
        {

        }



        public void changeValues(BindingSource c)
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
        private void metroButtonDeleteAppoinment_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count>0)
            {
                int rowindex = dataGridView.CurrentCell.RowIndex;

                string m=dataGridView.Rows[rowindex].Cells[0].Value.ToString();
               // MetroFramework.MetroMessageBox.Show(this,m);

                b.deleteAppoinment(m);

                MetroFramework.MetroMessageBox.Show(this,"Deleted");
                this.Close();

            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Please Select A row");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
