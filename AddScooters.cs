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
using System.IO;

namespace MelsMobilityProject
{
    public partial class AddScooters : Form
    {
        public AddScooters()
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

        private void Addscootbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            if (Imagetb.Text != "")
            {
                conn = new SqlConnection(@"Data Source=melscloudserver.database.windows.net;Initial Catalog=MelDatabase112;User ID=tarling;Password=Royals16;MultipleActiveResultSets=true");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Scooters values('" +
                    Imagetb.Text + "', '" + Nametb.Text + "', '" + Colortb.Text + "', '" + Categorytb.Text + "', '" +
                    Conditiontb.Text + "')", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Scooter Added Successfully");
                conn.Close();
                Imagetb.Text = "";
                Nametb.Text = "";
                Colortb.Text = "";
                Categorytb.Text = "";
                Conditiontb.Text = "";
                
            }
            else
            {
                MessageBox.Show("Data Could Not Be Added! ):");
            }
        }

        private void Getimagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if(choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFilName = choofdlog.FileName;

                string result = Path.GetFileName(choofdlog.FileName);
                string path = choofdlog.FileName;
                string path2 = @"C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\Images\\" + result;

                File.Move(path, path2);
                MessageBox.Show(sFilName + "Was moved to correct Folder");
                Imagetb.Text = result;

                NewScootpb.Image = Image.FromFile("C:\\Users\\Thomas Arling\\source\\repos\\MelsMobilityProject\\Images\\Images\\" + result);

            }
        }
    }
}
