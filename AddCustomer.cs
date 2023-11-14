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
    public partial class AddCustomer : Form
    {
        public Form Formtoshowonclosing { get; set; }

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();
        }

        private void AddCustomerbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            if(fnametb.Text != "")
            {
                conn = new SqlConnection(@"Data Source=melscloudserver.database.windows.net;Initial Catalog=MelDatabase112;User ID=tarling;Password=Royals16;MultipleActiveResultSets=true");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into customer values('" +
                    fnametb.Text + "', '" + Lnametb.Text + "', '" + Addresstb.Text + "', '" + Citytb.Text + "', '" +
                    Statetb.Text + "', '" + Ziptb.Text + "', '" + Phonetb.Text + "', '" + Emailtb.Text + "')", conn);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully");
                conn.Close();
                fnametb.Text = "";
                Lnametb.Text = "";
                Addresstb.Text = "";
                Citytb.Text = "";
                Statetb.Text = "";
                Ziptb.Text = "";
                Phonetb.Text = "";
                Emailtb.Text = "";
            }
            else
            {
                MessageBox.Show("Data Could Not Be Added! ):");
            }
        }
        
    }
}
