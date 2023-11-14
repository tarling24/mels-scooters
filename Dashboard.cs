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
    public partial class Dashboard : Form
    {
        public Form Formtoshowonclosing { get; set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Customersbutton_Click(object sender, EventArgs e)
        {
            var CustomerForm = new CustomersNcs();
            CustomerForm.Formtoshowonclosing = this;
            CustomerForm.Show();
            this.Hide();
        }
    }
}
