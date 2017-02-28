using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using BLL;

namespace Hospital_Management2.User_Controls
{

    public partial class ChangeCharges : UserControl
    {
        BLL.Fee a=new BLL.Fee();
        public ChangeCharges()
        {
            InitializeComponent();
            AdjustComboBoxItems();
        }

         void AdjustComboBoxItems(){
             List<string> Services = a.listOfAllServices();
             BindingSource bi = new BindingSource();
             bi.DataSource = Services;
             metroComboBox1.DataSource = bi;
             metroComboBox1.Refresh();
        }

        BLL.Fee u = new BLL.Fee();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<DAL.FeeTable> a = u.AllCharges();

            BindingSource bi = new BindingSource();
            bi.DataSource = a;

            ViewAll v = new ViewAll();
            v.changeValues(bi,"Different Charges:","Charges");
            v.Show();
        }

        private void metroButtonChageCharge_Click(object sender, EventArgs e)
        {
            bool b = u.changeCharge(metroComboBox1.Text, metroTextBoxAmount.Text);
            if (b == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a valid Amount.");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Amount Changed!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAddNewType_Click(object sender, EventArgs e)
        {
            if (metroTextBoxNewType.Text != "" && metroTextBoxAmount.Text != "")
            {
                bool value = u.Addtype(metroTextBoxNewType.Text, metroTextBoxAmount.Text);
                if (value == true)
                {
                    AdjustComboBoxItems();
                    MetroMessageBox.Show(this, "Successfully Addded!");
                }
                else
                {
                    MetroMessageBox.Show(this, "Failed!");
                }
            }
            else {
                   MetroMessageBox.Show(this,"Please fill \"New Type\" and \"Amount\" field");
            }
            
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text != "")
            {
                bool b = u.DeleteType(metroComboBox1.Text);

                if (b == true)
                {
                    AdjustComboBoxItems();
                    MetroMessageBox.Show(this, "Deleted Successfully!");
                }
                else
                {
                    MetroMessageBox.Show(this, "Failed to Delete the item");
                }
            }
            else {
                MetroMessageBox.Show(this, "No Type Selected!");
            }
            
            }
            

        
    }
}
