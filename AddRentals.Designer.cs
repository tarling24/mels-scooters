
namespace MelsMobilityProject
{
    partial class AddRentals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Commentstb = new System.Windows.Forms.TextBox();
            this.Conditiontb = new System.Windows.Forms.TextBox();
            this.Enddp = new System.Windows.Forms.DateTimePicker();
            this.Startdp = new System.Windows.Forms.DateTimePicker();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Custcb = new System.Windows.Forms.ComboBox();
            this.Scootcb = new System.Windows.Forms.ComboBox();
            this.Custtb = new System.Windows.Forms.TextBox();
            this.Scoottb = new System.Windows.Forms.TextBox();
            this.Scooterpb = new System.Windows.Forms.PictureBox();
            this.Addrentalbutton = new System.Windows.Forms.Button();
            this.melDatabase112DataSetLab11 = new MelsMobilityProject.MelDatabase112DataSetLab11();
            this.melDatabase112DataSetLab11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.customerTableAdapter();
            this.scootersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scootersTableAdapter = new MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.ScootersTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scooterpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.Backbutton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1251, 777);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.Addrentalbutton);
            this.groupBox2.Controls.Add(this.Custtb);
            this.groupBox2.Controls.Add(this.Custcb);
            this.groupBox2.Controls.Add(this.Startdp);
            this.groupBox2.Controls.Add(this.Enddp);
            this.groupBox2.Controls.Add(this.Conditiontb);
            this.groupBox2.Controls.Add(this.Commentstb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 694);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Rental Details";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.Scooterpb);
            this.groupBox3.Controls.Add(this.Scoottb);
            this.groupBox3.Controls.Add(this.Scootcb);
            this.groupBox3.Location = new System.Drawing.Point(644, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 694);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scooter Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cust ID\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Condition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comments";
            // 
            // Commentstb
            // 
            this.Commentstb.Location = new System.Drawing.Point(193, 394);
            this.Commentstb.Multiline = true;
            this.Commentstb.Name = "Commentstb";
            this.Commentstb.Size = new System.Drawing.Size(364, 198);
            this.Commentstb.TabIndex = 5;
            // 
            // Conditiontb
            // 
            this.Conditiontb.Location = new System.Drawing.Point(193, 313);
            this.Conditiontb.Name = "Conditiontb";
            this.Conditiontb.Size = new System.Drawing.Size(364, 31);
            this.Conditiontb.TabIndex = 6;
            // 
            // Enddp
            // 
            this.Enddp.Location = new System.Drawing.Point(193, 239);
            this.Enddp.Name = "Enddp";
            this.Enddp.Size = new System.Drawing.Size(364, 31);
            this.Enddp.TabIndex = 7;
            // 
            // Startdp
            // 
            this.Startdp.Location = new System.Drawing.Point(193, 170);
            this.Startdp.Name = "Startdp";
            this.Startdp.Size = new System.Drawing.Size(364, 31);
            this.Startdp.TabIndex = 8;
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Firebrick;
            this.Backbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(6, 718);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(122, 54);
            this.Backbutton.TabIndex = 16;
            this.Backbutton.Text = "Back\r\n";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Custcb
            // 
            this.Custcb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "CustID", true));
            this.Custcb.DataSource = this.customerBindingSource;
            this.Custcb.DisplayMember = "FullName";
            this.Custcb.FormattingEnabled = true;
            this.Custcb.Location = new System.Drawing.Point(288, 92);
            this.Custcb.Name = "Custcb";
            this.Custcb.Size = new System.Drawing.Size(269, 33);
            this.Custcb.TabIndex = 9;
            this.Custcb.ValueMember = "CustID";
            this.Custcb.SelectedIndexChanged += new System.EventHandler(this.Custcb_SelectedIndexChanged);
            // 
            // Scootcb
            // 
            this.Scootcb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.scootersBindingSource, "ID", true));
            this.Scootcb.DataSource = this.scootersBindingSource;
            this.Scootcb.DisplayMember = "Name";
            this.Scootcb.FormattingEnabled = true;
            this.Scootcb.Location = new System.Drawing.Point(282, 92);
            this.Scootcb.Name = "Scootcb";
            this.Scootcb.Size = new System.Drawing.Size(266, 33);
            this.Scootcb.TabIndex = 0;
            this.Scootcb.ValueMember = "ID";
            this.Scootcb.SelectedIndexChanged += new System.EventHandler(this.Scootcb_SelectedIndexChanged);
            // 
            // Custtb
            // 
            this.Custtb.Location = new System.Drawing.Point(193, 92);
            this.Custtb.Name = "Custtb";
            this.Custtb.ReadOnly = true;
            this.Custtb.Size = new System.Drawing.Size(76, 31);
            this.Custtb.TabIndex = 10;
            this.Custtb.TextChanged += new System.EventHandler(this.Custtb_TextChanged);
            // 
            // Scoottb
            // 
            this.Scoottb.Location = new System.Drawing.Point(118, 94);
            this.Scoottb.Name = "Scoottb";
            this.Scoottb.ReadOnly = true;
            this.Scoottb.Size = new System.Drawing.Size(108, 31);
            this.Scoottb.TabIndex = 11;
            this.Scoottb.TextChanged += new System.EventHandler(this.Scoottb_TextChanged);
            // 
            // Scooterpb
            // 
            this.Scooterpb.Location = new System.Drawing.Point(44, 170);
            this.Scooterpb.Name = "Scooterpb";
            this.Scooterpb.Size = new System.Drawing.Size(551, 332);
            this.Scooterpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scooterpb.TabIndex = 12;
            this.Scooterpb.TabStop = false;
            // 
            // Addrentalbutton
            // 
            this.Addrentalbutton.BackColor = System.Drawing.Color.Beige;
            this.Addrentalbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addrentalbutton.Location = new System.Drawing.Point(372, 614);
            this.Addrentalbutton.Name = "Addrentalbutton";
            this.Addrentalbutton.Size = new System.Drawing.Size(185, 62);
            this.Addrentalbutton.TabIndex = 17;
            this.Addrentalbutton.Text = "Add Rental";
            this.Addrentalbutton.UseVisualStyleBackColor = false;
            this.Addrentalbutton.Click += new System.EventHandler(this.Addrentalbutton_Click);
            // 
            // melDatabase112DataSetLab11
            // 
            this.melDatabase112DataSetLab11.DataSetName = "MelDatabase112DataSetLab11";
            this.melDatabase112DataSetLab11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // melDatabase112DataSetLab11BindingSource
            // 
            this.melDatabase112DataSetLab11BindingSource.DataSource = this.melDatabase112DataSetLab11;
            this.melDatabase112DataSetLab11BindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.melDatabase112DataSetLab11BindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // scootersBindingSource
            // 
            this.scootersBindingSource.DataMember = "Scooters";
            this.scootersBindingSource.DataSource = this.melDatabase112DataSetLab11BindingSource;
            // 
            // scootersTableAdapter
            // 
            this.scootersTableAdapter.ClearBeforeFill = true;
            // 
            // AddRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 802);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRentals";
            this.Text = "AddRentals";
            this.Load += new System.EventHandler(this.AddRentals_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scooterpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker Startdp;
        private System.Windows.Forms.DateTimePicker Enddp;
        private System.Windows.Forms.TextBox Conditiontb;
        private System.Windows.Forms.TextBox Commentstb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.ComboBox Scootcb;
        private System.Windows.Forms.ComboBox Custcb;
        private System.Windows.Forms.PictureBox Scooterpb;
        private System.Windows.Forms.TextBox Scoottb;
        private System.Windows.Forms.Button Addrentalbutton;
        private System.Windows.Forms.TextBox Custtb;
        private System.Windows.Forms.BindingSource melDatabase112DataSetLab11BindingSource;
        private MelDatabase112DataSetLab11 melDatabase112DataSetLab11;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MelDatabase112DataSetLab11TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource scootersBindingSource;
        private MelDatabase112DataSetLab11TableAdapters.ScootersTableAdapter scootersTableAdapter;
    }
}