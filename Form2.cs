using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelsMobilityProject
{
    public partial class CustomerRentals : Form
    {
        public Form Formtoshowonclosing { get; set; }
        public CustomerRentals()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melDatabase112AzureDataSet.rental' table. You can move, or remove it, as needed.
           // this.rentalTableAdapter1.Fill(this.melDatabase112AzureDataSet.rental);
            // TODO: This line of code loads data into the 'melDatabase112AzureDataSet.customer' table. You can move, or remove it, as needed.
          //  this.customerTableAdapter1.Fill(this.melDatabase112AzureDataSet.customer);
            // TODO: This line of code loads data into the 'melDatabaseDataSetMain.rental' table. You can move, or remove it, as needed.
            this.rentalTableAdapter.Fill(this.melDatabaseDataSetMain.rental);
            // TODO: This line of code loads data into the 'melDatabaseDataSetMain.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.melDatabaseDataSetMain.customer);
            this.WindowState = FormWindowState.Maximized;


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.melDatabaseDataSetMain);

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void custIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
