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
    public partial class RentalsN : Form

    {
        public void RentalsN_VisibleChanged(object sender, EventArgs e)
        {
            rentalBindingSource.ResetBindings(true);
            this.Refresh();
            this.rentalTableAdapter.Fill(this.melDatabase112DataSetLab11.rental);
        }
        public Form Formtoshowonclosing { get; set; }

        public void AddVisibleChangedEventHandler()
        {
            this.VisibleChanged += new EventHandler(RentalsN_VisibleChanged);
        }
        public RentalsN()
        {
            InitializeComponent();
        }
    


        SqlConnection conn = null;
        SqlDataReader custreader = null;
        SqlDataReader scootreader = null;


        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rentalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.rentalBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.melDatabase112DataSetLab11);
            }
             catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("You cannot delete this item until all related records are deleted");
            }
        }

        private void RentalsN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melDatabase112DataSetLab11.rental' table. You can move, or remove it, as needed.
            this.rentalTableAdapter.Fill(this.melDatabase112DataSetLab11.rental);

        }

        private void custIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (custIDTextBox.Text != "")
            {
                conn = new SqlConnection(@"Data Source=melscloudserver.database.windows.net;Initial Catalog=MelDatabase112;User ID=tarling;Password=Royals16;MultipleActiveResultSets=true");
                conn.Open();
                SqlCommand custcmd = new SqlCommand("SELECT FIrstName, LastName FROM customer WHERE CustID = @myCustID", conn);
                SqlParameter custparam = new SqlParameter();
                custparam.ParameterName = "@myCustID";
                custparam.Value = custIDTextBox.Text;
                custcmd.Parameters.Add(custparam);
                custreader = custcmd.ExecuteReader();

                DataSet custds = new DataSet();
                DataTable custdt = new DataTable("CustTable");
                custds.Tables.Add(custdt);
                custds.Load(custreader, LoadOption.PreserveChanges, custds.Tables[0]);
                custreader.Close();

                CustNametb.Text = custdt.Rows[0][0].ToString().Trim() + " " +
                    custdt.Rows[0][1].ToString().Trim();
            }
           
        }

        private void scooterIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (scooterIDTextBox.Text != "")
            {
                conn = new SqlConnection(@"Data Source=melscloudserver.database.windows.net;Initial Catalog=MelDatabase112;User ID=tarling;Password=Royals16;MultipleActiveResultSets=true");
                conn.Open();
                SqlCommand scootcmd = new SqlCommand("SELECT Scooter FROM Scooters WHERE ID = @ScootID", conn);
                SqlParameter scootparam = new SqlParameter();
                scootparam.ParameterName = "@ScootID";
                scootparam.Value = scooterIDTextBox.Text;
                scootcmd.Parameters.Add(scootparam);
                scootreader = scootcmd.ExecuteReader();

                DataSet scootds = new DataSet();
                DataTable scootdt = new DataTable("ScootTable");
                scootds.Tables.Add(scootdt);
                scootds.Load(scootreader, LoadOption.PreserveChanges, scootds.Tables[0]);
                scootreader.Close();
                if (scootds.Tables[0].Rows.Count < 1)
                {
                    Imagetb.Text = "";
                }
                else
                {
                    Imagetb.Text = scootdt.Rows[0][0].ToString();
                    scootpb.Image = Image.FromFile("C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\Images\\" +
                        scootdt.Rows[0][0].ToString());
                }
                //CustNametb.Text = custdt.Rows[0][0].ToString().Trim() + " " +
                //    custdt.Rows[0][1].ToString().Trim();
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var addRentalForm = new AddRentals();
            addRentalForm.Formtoshowonclosing = this;
            addRentalForm.Show();
            this.Hide();
        }
    }
}
