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
    public partial class AddRentals : Form
    {
        public AddRentals()
        {
            InitializeComponent();
        }
        public Form Formtoshowonclosing { get; set; }



        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();
        }

        private void Addrentalbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            if ((Custtb.Text != "") || (Scoottb.Text != ""))
            {
                conn = new SqlConnection(@"Data Source=melscloudserver.database.windows.net;Initial Catalog=MelDatabase112;User ID=tarling;Password=Royals16;MultipleActiveResultSets=true");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into rental values('" +
                    Custtb.Text + "', '" + Scoottb.Text + "', '" + Startdp.Value + "', '" + Enddp.Value + "', '" +
                    Conditiontb.Text + "', '" + Commentstb.Text + "')", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Rental Added Successfully");
                conn.Close();
                Custtb.Text = "";
                Scoottb.Text = "";
                Conditiontb.Text = "";
                Commentstb.Text = "";
               
            }
            else
            {
                MessageBox.Show("Data Could Not Be Added! ):");
            }
        }

        private void Custtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Scoottb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Scoottb.Text == "n/a")
                {
                    Scooterpb.Image = Image.FromFile(filename: "C: \\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\noimage\\noscooter.jpg");
                }
                else if (Scoottb.Text == "")
                {
                    Scooterpb.Image = Image.FromFile(filename: "C: \\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\noimage\\noscooter.jpg");
                }
                else
                {
                    Scooterpb.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\Images\\" + Scoottb.Text);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Scooterpb.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\noimage\\noscooter.jpg");
            }
        }

        private void AddRentals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melDatabase112DataSetLab11.Scooters' table. You can move, or remove it, as needed.
            this.scootersTableAdapter.Fill(this.melDatabase112DataSetLab11.Scooters);
            // TODO: This line of code loads data into the 'melDatabase112DataSetLab11.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.melDatabase112DataSetLab11.customer);

        }

        private void Custcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Custcb.SelectedValue != null)
            {
                Custtb.Text = Custcb.SelectedValue.ToString();
            }
        }

        private void Scootcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Scootcb.SelectedValue != null)
            {
                var selectedScooter = (DataRowView)Scootcb.SelectedItem;

                Scoottb.Text = Scootcb.SelectedValue.ToString();
                Scooterpb.Image = Image.FromFile("C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\Images\\" +
                    selectedScooter["Scooter"].ToString());
            }
        }
    }
}
