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

        public void ScootersN_VisibleChanged(object sender, EventArgs e)
        {
            scootersBindingSource.ResetBindings(true);
            this.Refresh();
            this.scootersTableAdapter.Fill(this.melDatabase112DataSetLab11.Scooters);
        }
        public Form Formtoshowonclosing { get; set; }
        public void AddVisibleChangedEventHandler()
        {
            this.VisibleChanged += new EventHandler(ScootersN_VisibleChanged);
        }

        public ScootersN()
        {
            InitializeComponent();
        }
        private void ScootersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scootersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.melDatabase112DataSetLab11);

        }

        private void scootersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.scootersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.melDatabase112DataSetLab11);
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("You cannot delete this item until all related records are deleted");
            }

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
                    ScootersPB.Image = Image.FromFile(filename: "C: \\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\noimage\\noscooter.jpg");
                }
                else if (scooterTextBox.Text == "")
                {
                    ScootersPB.Image = Image.FromFile(filename: "C: \\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\noimage\\noscooter.jpg");
                }
                else
                {
                    ScootersPB.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\Images\\" + scooterTextBox.Text);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                ScootersPB.Image = Image.FromFile(filename: "C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\noimage\\noscooter.jpg");
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != Formtoshowonclosing)
                Formtoshowonclosing.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newAddScoot = new AddScooters();
            newAddScoot.Formtoshowonclosing = this;
            newAddScoot.Show();
            this.Hide();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var newAddScoot = new AddScooters();
            newAddScoot.Formtoshowonclosing = this;
            newAddScoot.Show();
            this.Hide();
        }
    }
}
