using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace MelsMobilityProject
{
    public partial class Main : Form
    {
        public Form Formtoshowonclosing { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitmain_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
            Formtoshowonclosing.Show();


        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melDatabaseDataSetMain.Scooters' table. You can move, or remove it, as needed.
            this.scootersTableAdapter.Fill(this.melDatabaseDataSetMain.Scooters);
            this.WindowState = FormWindowState.Maximized;
        }



        private void scootersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scootersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.melDatabaseDataSetMain);

        }

        private void pictureBoxScooter_Click(object sender, EventArgs e)
        {
            
        }

        private void scooterpictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void scooterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (scooterTextBox.Text == "n/a")
                {
                    pictureBoxScooter.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\noimage\\noscooter.jpg");
                }
                else if (scooterTextBox.Text == "")
                {
                    pictureBoxScooter.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\noimage\\noscooter.jpg");
                }
                else
                {
                    pictureBoxScooter.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\Images\\Images\\" + scooterTextBox.Text);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                pictureBoxScooter.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\noimage\\noscooter.jpg");
            }
        }

        private void customerrentalbutton_Click(object sender, EventArgs e)
        {
            var CloudRecordsForm = new CloudRecords();
            CloudRecordsForm.Formtoshowonclosing = this;
            CloudRecordsForm.Show();
            this.Hide();
        }

        private void ScooterRentalButton_Click(object sender, EventArgs e)
        {
            var RentedScootersForm = new RentedScooters();
            RentedScootersForm.Formtoshowonclosing = this;
            RentedScootersForm.Show();
            this.Hide();
        }
    }
}
