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
    public partial class CloudRecords : Form
    {
        public Form Formtoshowonclosing { get; set; }
        public CloudRecords()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.melDatabase112AzureDataSet);

        }

        private void CloudRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melDatabase112AzureDataSet.rental' table. You can move, or remove it, as needed.
            this.rentalTableAdapter.Fill(this.melDatabase112AzureDataSet.rental);
            // TODO: This line of code loads data into the 'melDatabase112AzureDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.melDatabase112AzureDataSet.customer);
            this.WindowState = FormWindowState.Maximized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RecordsExit_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();
        }
    }
}
