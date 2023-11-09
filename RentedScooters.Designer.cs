
namespace MelsMobilityProject
{
    partial class RentedScooters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Imagetextbox = new System.Windows.Forms.TextBox();
            this.Scooterpic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConditionTextbox = new System.Windows.Forms.TextBox();
            this.ScooterCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rentalDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scooterpic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.Exitbutton);
            this.groupBox1.Controls.Add(this.Imagetextbox);
            this.groupBox1.Controls.Add(this.Scooterpic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1720, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Crimson;
            this.Exitbutton.Location = new System.Drawing.Point(21, 521);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(111, 50);
            this.Exitbutton.TabIndex = 7;
            this.Exitbutton.Text = "EXIT";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Imagetextbox
            // 
            this.Imagetextbox.Location = new System.Drawing.Point(1333, 479);
            this.Imagetextbox.Name = "Imagetextbox";
            this.Imagetextbox.Size = new System.Drawing.Size(258, 31);
            this.Imagetextbox.TabIndex = 6;
            // 
            // Scooterpic
            // 
            this.Scooterpic.Location = new System.Drawing.Point(1266, 114);
            this.Scooterpic.Name = "Scooterpic";
            this.Scooterpic.Size = new System.Drawing.Size(374, 359);
            this.Scooterpic.TabIndex = 5;
            this.Scooterpic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scooter Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scooter Rental History";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.Controls.Add(this.ConditionTextbox);
            this.groupBox2.Controls.Add(this.ScooterCombobox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(139, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 414);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // ConditionTextbox
            // 
            this.ConditionTextbox.Location = new System.Drawing.Point(102, 289);
            this.ConditionTextbox.Name = "ConditionTextbox";
            this.ConditionTextbox.Size = new System.Drawing.Size(203, 31);
            this.ConditionTextbox.TabIndex = 5;
            // 
            // ScooterCombobox
            // 
            this.ScooterCombobox.FormattingEnabled = true;
            this.ScooterCombobox.Location = new System.Drawing.Point(102, 167);
            this.ScooterCombobox.Name = "ScooterCombobox";
            this.ScooterCombobox.Size = new System.Drawing.Size(203, 33);
            this.ScooterCombobox.TabIndex = 4;
            this.ScooterCombobox.SelectedIndexChanged += new System.EventHandler(this.ScooterCombobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Scooter Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Scooter";
            // 
            // rentalDataGridView
            // 
            this.rentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalDataGridView.Location = new System.Drawing.Point(0, 598);
            this.rentalDataGridView.Name = "rentalDataGridView";
            this.rentalDataGridView.RowHeadersWidth = 82;
            this.rentalDataGridView.RowTemplate.Height = 33;
            this.rentalDataGridView.Size = new System.Drawing.Size(1708, 477);
            this.rentalDataGridView.TabIndex = 1;
            // 
            // RentedScooters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 1087);
            this.Controls.Add(this.rentalDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "RentedScooters";
            this.Text = "Customer Rented Scooters";
            this.Load += new System.EventHandler(this.RentedScooters_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scooterpic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.TextBox Imagetextbox;
        private System.Windows.Forms.PictureBox Scooterpic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ConditionTextbox;
        private System.Windows.Forms.ComboBox ScooterCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView rentalDataGridView;
    }
}