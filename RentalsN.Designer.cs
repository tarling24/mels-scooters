
namespace MelsMobilityProject
{
    partial class RentalsN
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label custIDLabel;
            System.Windows.Forms.Label scooterIDLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label rentalExitConditionLabel;
            System.Windows.Forms.Label commentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalsN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.rentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melDatabase112DataSetLab11 = new MelsMobilityProject.MelDatabase112DataSetLab11();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.scooterIDTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalExitConditionTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.Imagetb = new System.Windows.Forms.TextBox();
            this.scootpb = new System.Windows.Forms.PictureBox();
            this.CustNametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rentalTableAdapter = new MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.rentalTableAdapter();
            this.tableAdapterManager = new MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.TableAdapterManager();
            this.rentalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rentalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            custIDLabel = new System.Windows.Forms.Label();
            scooterIDLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            rentalExitConditionLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingNavigator)).BeginInit();
            this.rentalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("MS UI Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(1094, 165);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(209, 29);
            label8.TabIndex = 16;
            label8.Text = "Customer Name\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("MS UI Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(1161, 645);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(83, 29);
            label9.TabIndex = 19;
            label9.Text = "Image";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(74, 211);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(51, 33);
            iDLabel.TabIndex = 22;
            iDLabel.Text = "ID:";
            // 
            // custIDLabel
            // 
            custIDLabel.AutoSize = true;
            custIDLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            custIDLabel.Location = new System.Drawing.Point(74, 275);
            custIDLabel.Name = "custIDLabel";
            custIDLabel.Size = new System.Drawing.Size(124, 33);
            custIDLabel.TabIndex = 24;
            custIDLabel.Text = "Cust ID:";
            // 
            // scooterIDLabel
            // 
            scooterIDLabel.AutoSize = true;
            scooterIDLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scooterIDLabel.Location = new System.Drawing.Point(74, 344);
            scooterIDLabel.Name = "scooterIDLabel";
            scooterIDLabel.Size = new System.Drawing.Size(166, 33);
            scooterIDLabel.TabIndex = 26;
            scooterIDLabel.Text = "Scooter ID:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startDateLabel.Location = new System.Drawing.Point(74, 417);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(162, 33);
            startDateLabel.TabIndex = 28;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endDateLabel.Location = new System.Drawing.Point(74, 493);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(145, 33);
            endDateLabel.TabIndex = 30;
            endDateLabel.Text = "End Date:";
            // 
            // rentalExitConditionLabel
            // 
            rentalExitConditionLabel.AutoSize = true;
            rentalExitConditionLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rentalExitConditionLabel.Location = new System.Drawing.Point(74, 561);
            rentalExitConditionLabel.Name = "rentalExitConditionLabel";
            rentalExitConditionLabel.Size = new System.Drawing.Size(304, 33);
            rentalExitConditionLabel.TabIndex = 32;
            rentalExitConditionLabel.Text = "Rental Exit Condition:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commentsLabel.Location = new System.Drawing.Point(74, 629);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(165, 33);
            commentsLabel.TabIndex = 34;
            commentsLabel.Text = "Comments:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(custIDLabel);
            this.groupBox1.Controls.Add(this.custIDTextBox);
            this.groupBox1.Controls.Add(scooterIDLabel);
            this.groupBox1.Controls.Add(this.scooterIDTextBox);
            this.groupBox1.Controls.Add(startDateLabel);
            this.groupBox1.Controls.Add(this.startDateDateTimePicker);
            this.groupBox1.Controls.Add(endDateLabel);
            this.groupBox1.Controls.Add(this.endDateDateTimePicker);
            this.groupBox1.Controls.Add(rentalExitConditionLabel);
            this.groupBox1.Controls.Add(this.rentalExitConditionTextBox);
            this.groupBox1.Controls.Add(commentsLabel);
            this.groupBox1.Controls.Add(this.commentsTextBox);
            this.groupBox1.Controls.Add(this.Exitbutton);
            this.groupBox1.Controls.Add(this.backbutton);
            this.groupBox1.Controls.Add(this.Imagetb);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.scootpb);
            this.groupBox1.Controls.Add(this.CustNametb);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1457, 890);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(415, 205);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(477, 39);
            this.iDTextBox.TabIndex = 23;
            // 
            // rentalBindingSource
            // 
            this.rentalBindingSource.DataMember = "rental";
            this.rentalBindingSource.DataSource = this.melDatabase112DataSetLab11;
            // 
            // melDatabase112DataSetLab11
            // 
            this.melDatabase112DataSetLab11.DataSetName = "MelDatabase112DataSetLab11";
            this.melDatabase112DataSetLab11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "CustID", true));
            this.custIDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDTextBox.Location = new System.Drawing.Point(415, 269);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.Size = new System.Drawing.Size(477, 39);
            this.custIDTextBox.TabIndex = 25;
            this.custIDTextBox.TextChanged += new System.EventHandler(this.custIDTextBox_TextChanged);
            // 
            // scooterIDTextBox
            // 
            this.scooterIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "ScooterID", true));
            this.scooterIDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scooterIDTextBox.Location = new System.Drawing.Point(415, 338);
            this.scooterIDTextBox.Name = "scooterIDTextBox";
            this.scooterIDTextBox.Size = new System.Drawing.Size(477, 39);
            this.scooterIDTextBox.TabIndex = 27;
            this.scooterIDTextBox.TextChanged += new System.EventHandler(this.scooterIDTextBox_TextChanged);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentalBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(415, 410);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(477, 39);
            this.startDateDateTimePicker.TabIndex = 29;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentalBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(415, 486);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(477, 39);
            this.endDateDateTimePicker.TabIndex = 31;
            // 
            // rentalExitConditionTextBox
            // 
            this.rentalExitConditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "RentalExitCondition", true));
            this.rentalExitConditionTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalExitConditionTextBox.Location = new System.Drawing.Point(415, 555);
            this.rentalExitConditionTextBox.Name = "rentalExitConditionTextBox";
            this.rentalExitConditionTextBox.Size = new System.Drawing.Size(477, 39);
            this.rentalExitConditionTextBox.TabIndex = 33;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalBindingSource, "Comments", true));
            this.commentsTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(298, 623);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(594, 150);
            this.commentsTextBox.TabIndex = 35;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(1299, 812);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(122, 53);
            this.Exitbutton.TabIndex = 22;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(23, 812);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(122, 53);
            this.backbutton.TabIndex = 21;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Imagetb
            // 
            this.Imagetb.Location = new System.Drawing.Point(1083, 687);
            this.Imagetb.Name = "Imagetb";
            this.Imagetb.Size = new System.Drawing.Size(247, 31);
            this.Imagetb.TabIndex = 20;
            // 
            // scootpb
            // 
            this.scootpb.Location = new System.Drawing.Point(997, 282);
            this.scootpb.Name = "scootpb";
            this.scootpb.Size = new System.Drawing.Size(401, 343);
            this.scootpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scootpb.TabIndex = 18;
            this.scootpb.TabStop = false;
            // 
            // CustNametb
            // 
            this.CustNametb.Location = new System.Drawing.Point(997, 211);
            this.CustNametb.Name = "CustNametb";
            this.CustNametb.Size = new System.Drawing.Size(401, 31);
            this.CustNametb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rentals";
            // 
            // rentalTableAdapter
            // 
            this.rentalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.rentalTableAdapter = this.rentalTableAdapter;
            this.tableAdapterManager.ScootersTableAdapter = null;
            this.tableAdapterManager.SecurityTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rentalBindingNavigator
            // 
            this.rentalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rentalBindingNavigator.BindingSource = this.rentalBindingSource;
            this.rentalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rentalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rentalBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.rentalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rentalBindingNavigatorSaveItem});
            this.rentalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rentalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rentalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rentalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rentalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rentalBindingNavigator.Name = "rentalBindingNavigator";
            this.rentalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rentalBindingNavigator.Size = new System.Drawing.Size(1482, 50);
            this.rentalBindingNavigator.TabIndex = 1;
            this.rentalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // rentalBindingNavigatorSaveItem
            // 
            this.rentalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rentalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rentalBindingNavigatorSaveItem.Image")));
            this.rentalBindingNavigatorSaveItem.Name = "rentalBindingNavigatorSaveItem";
            this.rentalBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.rentalBindingNavigatorSaveItem.Text = "Save Data";
            this.rentalBindingNavigatorSaveItem.Click += new System.EventHandler(this.rentalBindingNavigatorSaveItem_Click);
            // 
            // RentalsN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 920);
            this.Controls.Add(this.rentalBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "RentalsN";
            this.Text = "RentalsN";
            this.Load += new System.EventHandler(this.RentalsN_Load);
            this.VisibleChanged += new System.EventHandler(this.RentalsN_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingNavigator)).EndInit();
            this.rentalBindingNavigator.ResumeLayout(false);
            this.rentalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox Imagetb;
        private System.Windows.Forms.PictureBox scootpb;
        private System.Windows.Forms.TextBox CustNametb;
        private MelDatabase112DataSetLab11 melDatabase112DataSetLab11;
        private System.Windows.Forms.BindingSource rentalBindingSource;
        private MelDatabase112DataSetLab11TableAdapters.rentalTableAdapter rentalTableAdapter;
        private MelDatabase112DataSetLab11TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rentalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rentalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.TextBox scooterIDTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox rentalExitConditionTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
    }
}