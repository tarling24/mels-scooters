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
    public partial class ScootersN : Form
    {
        public Form Formtoshowonclosing { get; set; }

        public ScootersN()
        {
            InitializeComponent();
        }

        private void scootersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scootersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.melDatabase112DataSetLab11);

        }

        private void ScootersN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'melDatabase112DataSetLab11.Scooters' table. You can move, or remove it, as needed.
            this.scootersTableAdapter.Fill(this.melDatabase112DataSetLab11.Scooters);

        }

        private void ScootersPB_Click(object sender, EventArgs e)
        {

        }

        private void scooterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (scooterTextBox.Text == "n/a")
                {
                    ScootersPB.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\noimage\\noscooter.jpg");
                }
                else if (scooterTextBox.Text == "")
                {
                    ScootersPB.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\noimage\\noscooter.jpg");
                }
                else
                {
                    ScootersPB.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\Images\\Images\\" + scooterTextBox.Text);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                ScootersPB.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\c# 3\\Challenge Lab 6\\noimage\\noscooter.jpg");
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();

        }
    }
}
