using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MelsMobilityProject
{
    public partial class CustomersNcs : Form
    {
        public void CustomerNcs_VisibleChanged(object sender, EventArgs e)
        {
           
            customerBindingSource.ResetBindings(true);
            this.Refresh();
            this.customerTableAdapter.Fill(this.melDatabase112DataSetLab11.customer);
        }
        public Form Formtoshowonclosing { get; set; }
        public void AddVisibleChangedEventHandler()
        {
            this.VisibleChanged += new EventHandler(CustomerNcs_VisibleChanged);
        }

        public CustomersNcs()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.melDatabase112DataSetLab11);

        }

        private void CustomersNcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melDatabase112DataSetLab11.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.melDatabase112DataSetLab11.customer);

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.melDatabase112DataSetLab11);
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("You cannot delete this item until all related records are deleted");
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var newAddCusts = new AddCustomer();
            newAddCusts.Formtoshowonclosing = this;
            newAddCusts.Show();
            this.Hide();
        }
    }
}
