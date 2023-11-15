
namespace MelsMobilityProject
{
    partial class ScootersN
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label scooterLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label conditionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScootersN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.ScootersPB = new System.Windows.Forms.PictureBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.scootersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melDatabase112DataSetLab11 = new MelsMobilityProject.MelDatabase112DataSetLab11();
            this.scooterTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scootersTableAdapter = new MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.ScootersTableAdapter();
            this.tableAdapterManager = new MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.TableAdapterManager();
            this.scootersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.scootersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            scooterLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScootersPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingNavigator)).BeginInit();
            this.scootersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(163, 210);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(51, 33);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // scooterLabel
            // 
            scooterLabel.AutoSize = true;
            scooterLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scooterLabel.Location = new System.Drawing.Point(163, 279);
            scooterLabel.Name = "scooterLabel";
            scooterLabel.Size = new System.Drawing.Size(127, 33);
            scooterLabel.TabIndex = 3;
            scooterLabel.Text = "Scooter:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(163, 346);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(98, 33);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(163, 410);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(93, 33);
            colorLabel.TabIndex = 7;
            colorLabel.Text = "Color:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(163, 471);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(142, 33);
            categoryLabel.TabIndex = 9;
            categoryLabel.Text = "Category:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conditionLabel.Location = new System.Drawing.Point(163, 534);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(148, 33);
            conditionLabel.TabIndex = 11;
            conditionLabel.Text = "Condition:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.exitbutton);
            this.groupBox1.Controls.Add(this.ScootersPB);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(scooterLabel);
            this.groupBox1.Controls.Add(this.scooterTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(colorLabel);
            this.groupBox1.Controls.Add(this.colorTextBox);
            this.groupBox1.Controls.Add(categoryLabel);
            this.groupBox1.Controls.Add(this.categoryTextBox);
            this.groupBox1.Controls.Add(conditionLabel);
            this.groupBox1.Controls.Add(this.conditionTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Firebrick;
            this.exitbutton.Location = new System.Drawing.Point(22, 664);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(115, 51);
            this.exitbutton.TabIndex = 20;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // ScootersPB
            // 
            this.ScootersPB.Location = new System.Drawing.Point(710, 210);
            this.ScootersPB.Name = "ScootersPB";
            this.ScootersPB.Size = new System.Drawing.Size(362, 360);
            this.ScootersPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScootersPB.TabIndex = 13;
            this.ScootersPB.TabStop = false;
            this.ScootersPB.Click += new System.EventHandler(this.ScootersPB_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(343, 207);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(252, 39);
            this.iDTextBox.TabIndex = 2;
            // 
            // scootersBindingSource
            // 
            this.scootersBindingSource.DataMember = "Scooters";
            this.scootersBindingSource.DataSource = this.melDatabase112DataSetLab11;
            // 
            // melDatabase112DataSetLab11
            // 
            this.melDatabase112DataSetLab11.DataSetName = "MelDatabase112DataSetLab11";
            this.melDatabase112DataSetLab11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scooterTextBox
            // 
            this.scooterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Scooter", true));
            this.scooterTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scooterTextBox.Location = new System.Drawing.Point(343, 278);
            this.scooterTextBox.Name = "scooterTextBox";
            this.scooterTextBox.Size = new System.Drawing.Size(252, 39);
            this.scooterTextBox.TabIndex = 4;
            this.scooterTextBox.TextChanged += new System.EventHandler(this.scooterTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(343, 343);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(252, 39);
            this.nameTextBox.TabIndex = 6;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Color", true));
            this.colorTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(343, 407);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(252, 39);
            this.colorTextBox.TabIndex = 8;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Category", true));
            this.categoryTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(343, 468);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(252, 39);
            this.categoryTextBox.TabIndex = 10;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Condition", true));
            this.conditionTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionTextBox.Location = new System.Drawing.Point(343, 531);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(252, 39);
            this.conditionTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scooters\r\n\r\n";
            // 
            // scootersTableAdapter
            // 
            this.scootersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.rentalTableAdapter = null;
            this.tableAdapterManager.ScootersTableAdapter = this.scootersTableAdapter;
            this.tableAdapterManager.SecurityTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MelsMobilityProject.MelDatabase112DataSetLab11TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // scootersBindingNavigator
            // 
            this.scootersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scootersBindingNavigator.BindingSource = this.scootersBindingSource;
            this.scootersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scootersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scootersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.scootersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.scootersBindingNavigatorSaveItem});
            this.scootersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.scootersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scootersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scootersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scootersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scootersBindingNavigator.Name = "scootersBindingNavigator";
            this.scootersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scootersBindingNavigator.Size = new System.Drawing.Size(1212, 42);
            this.scootersBindingNavigator.TabIndex = 1;
            this.scootersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
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
            // scootersBindingNavigatorSaveItem
            // 
            this.scootersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scootersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scootersBindingNavigatorSaveItem.Image")));
            this.scootersBindingNavigatorSaveItem.Name = "scootersBindingNavigatorSaveItem";
            this.scootersBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.scootersBindingNavigatorSaveItem.Text = "Save Data";
            this.scootersBindingNavigatorSaveItem.Click += new System.EventHandler(this.scootersBindingNavigatorSaveItem_Click);
            // 
            // ScootersN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 771);
            this.Controls.Add(this.scootersBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScootersN";
            this.Text = "ScootersN";
            this.Load += new System.EventHandler(this.ScootersN_Load);
            this.VisibleChanged += new System.EventHandler(this.ScootersN_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScootersPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabase112DataSetLab11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingNavigator)).EndInit();
            this.scootersBindingNavigator.ResumeLayout(false);
            this.scootersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MelDatabase112DataSetLab11 melDatabase112DataSetLab11;
        private System.Windows.Forms.BindingSource scootersBindingSource;
        private MelDatabase112DataSetLab11TableAdapters.ScootersTableAdapter scootersTableAdapter;
        private MelDatabase112DataSetLab11TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scootersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton scootersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox scooterTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.PictureBox ScootersPB;
        private System.Windows.Forms.Button exitbutton;
    }
}