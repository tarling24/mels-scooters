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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void labeluserid_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {
         
            string connectssms = "Data Source=melscloudserver.database.windows.net;Initial Catalog=MelDatabase112;Persist Security Info=True;User ID=tarling;Password=Royals16";
            string query = "SELECT * from Security WHERE UserID= '" + textuserid.Text + "'AND Password = '" + textentry.Text + "'";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectssms))
                {
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    myConnection.Open();
                    SqlDataReader readerReturnValue = cmd.ExecuteReader();
                        if (readerReturnValue.HasRows == true)
                    {
                        MessageBox.Show("Login Credentials Valid");

                        var DashForm = new Dashboard();
                        DashForm.Formtoshowonclosing = this;
                        DashForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User ID and or Password is incorrect. Please try again.");

                    }
                    myConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonview_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            if (buttonshow.Text == "show")
            {
                textentry.PasswordChar = '\0';
                textentry.UseSystemPasswordChar = false;
                buttonshow.Text = "hide";
            }
            else
            {
                textentry.PasswordChar = '*';
                textentry.UseSystemPasswordChar = true;
                buttonshow.Text = "show";
            }

        }

        private void buttonhide_Click(object sender, EventArgs e)
        {
            if (textentry.PasswordChar == '\0')
            {
                buttonshow.BringToFront();
                textentry.PasswordChar = '*';
                textentry.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
