using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelsMobilityProject
{
    public partial class RentedScooters : Form
    {
        public Form Formtoshowonclosing { get; set; }
        public RentedScooters()
        {
            InitializeComponent();


        }

        SqlConnection conn = null;
        SqlDataReader customerRentalReader = null;
        SqlDataReader scooterReader = null;
        private void RentedScooters_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=melscloudserver.database.windows.net;Initial Catalog=MelDatabase112;Persist Security Info=True;User ID=tarling;Password=Royals16;MultipleActiveResultsSets=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Name, ID FROM Scooters", conn);
            customerRentalReader = cmd.ExecuteReader();

            DataSet dsScooterID = new DataSet();
            DataTable dtScooterID = new DataTable("Table1");
            dsScooterID.Tables.Add(dtScooterID);

            dsScooterID.Load(customerRentalReader, LoadOption.PreserveChanges, dsScooterID.Tables[0]);
         

            ScooterCombobox.ValueMember = "ID";
            ScooterCombobox.DisplayMember = "Name";
            ScooterCombobox.DataSource = dsScooterID.Tables[0];
            ScooterCombobox.SelectedIndex = 1;
            ScooterCombobox.SelectedValue = 1;

            customerRentalReader.Close();

        }

        private void ScooterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();
            if(ScooterCombobox.SelectedValue == null)
            {

            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT Rentals.ScooterID, " +
                    "Rentals.StartDate, Rentals.EndDate, " +
                    "Rentals.RentalExitCondition, Customers.FirstName, Customer.LastName " +
                    "From Rentals INNER JOIN Customers ON Rentals.CustID = Customers.CustID " +
                    "WHERE Rentals.ScooterID = @ScootID", conn);

                SqlCommand cmd2 = new SqlCommand("Select ID, Scooter, Condition From Scooters WHERE ID = @ScootID2", conn);

                cmd2.Parameters.AddWithValue("@ScootID2", ScooterCombobox.SelectedValue);

                cmd.Parameters.AddWithValue("@ScootID", ScooterCombobox.SelectedValue);

                customerRentalReader = cmd.ExecuteReader();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("Table1");
                ds.Tables.Add(dt);
                ds.Load(customerRentalReader, LoadOption.PreserveChanges, ds.Tables[0]);
                customerRentalReader.Close();

                scooterReader = cmd2.ExecuteReader();
                DataSet ds2 = new DataSet();
                DataTable dt2 = new DataTable("Table2");
                ds2.Tables.Add(dt2);
                ds2.Load(scooterReader, LoadOption.PreserveChanges, ds2.Tables[0]);
                scooterReader.Close();

                rentalDataGridView.DataSource = ds.Tables[0];

                this.rentalDataGridView.Columns["ID"].Visible = false;

                if(ds2.Tables[0].Rows.Count < 1)
                {
                    ConditionTextbox.Text = "";
                    Imagetextbox.Text = "";
                }
                else
                {
                    ConditionTextbox.Text = dt2.Rows[0][2].ToString();
                    Imagetextbox.Text = dt2.Rows[0][1].ToString();

                    Scooterpic.Image = Image.FromFile("C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\Images\\Images"
                        + dt2.Rows[0][1].ToString());
                }



            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();
        }
    }
}
