
namespace MelsMobilityProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonshow = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonsignin = new System.Windows.Forms.Button();
            this.textentry = new System.Windows.Forms.TextBox();
            this.textuserid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labeluserid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonshow);
            this.groupBox1.Controls.Add(this.buttonexit);
            this.groupBox1.Controls.Add(this.buttonsignin);
            this.groupBox1.Controls.Add(this.textentry);
            this.groupBox1.Controls.Add(this.textuserid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelpassword);
            this.groupBox1.Controls.Add(this.labeluserid);
            this.groupBox1.Location = new System.Drawing.Point(917, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonshow
            // 
            this.buttonshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshow.Location = new System.Drawing.Point(387, 211);
            this.buttonshow.Name = "buttonshow";
            this.buttonshow.Size = new System.Drawing.Size(58, 35);
            this.buttonshow.TabIndex = 5;
            this.buttonshow.Text = "show";
            this.buttonshow.UseVisualStyleBackColor = true;
            this.buttonshow.Click += new System.EventHandler(this.buttonshow_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Tomato;
            this.buttonexit.Location = new System.Drawing.Point(67, 271);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(145, 46);
            this.buttonexit.TabIndex = 4;
            this.buttonexit.Text = "EXIT";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonsignin
            // 
            this.buttonsignin.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonsignin.Location = new System.Drawing.Point(248, 271);
            this.buttonsignin.Name = "buttonsignin";
            this.buttonsignin.Size = new System.Drawing.Size(145, 46);
            this.buttonsignin.TabIndex = 3;
            this.buttonsignin.Text = "Sign in";
            this.buttonsignin.UseVisualStyleBackColor = false;
            this.buttonsignin.Click += new System.EventHandler(this.buttonsignin_Click);
            // 
            // textentry
            // 
            this.textentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textentry.Location = new System.Drawing.Point(87, 211);
            this.textentry.Name = "textentry";
            this.textentry.PasswordChar = '*';
            this.textentry.Size = new System.Drawing.Size(294, 31);
            this.textentry.TabIndex = 2;
            this.textentry.UseSystemPasswordChar = true;
            // 
            // textuserid
            // 
            this.textuserid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textuserid.Location = new System.Drawing.Point(87, 120);
            this.textuserid.Name = "textuserid";
            this.textuserid.Size = new System.Drawing.Size(294, 31);
            this.textuserid.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please enter your login credentials";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(89, 183);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(112, 25);
            this.labelpassword.TabIndex = 1;
            this.labelpassword.Text = "Password:";
            // 
            // labeluserid
            // 
            this.labeluserid.AutoSize = true;
            this.labeluserid.Location = new System.Drawing.Point(89, 92);
            this.labeluserid.Name = "labeluserid";
            this.labeluserid.Size = new System.Drawing.Size(89, 25);
            this.labeluserid.TabIndex = 0;
            this.labeluserid.Text = "User ID:";
            this.labeluserid.Click += new System.EventHandler(this.labeluserid_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mel\'s";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobility Scooters";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1813, 913);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labeluserid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textentry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonsignin;
        public System.Windows.Forms.TextBox textuserid;
        private System.Windows.Forms.Button buttonshow;
    }
}