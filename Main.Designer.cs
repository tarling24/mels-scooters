
namespace MelsMobilityProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExitmain = new System.Windows.Forms.Button();
            this.melDatabaseDataSetMain = new MelsMobilityProject.MelDatabaseDataSetMain();
            this.scootersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scootersTableAdapter = new MelsMobilityProject.MelDatabaseDataSetMainTableAdapters.ScootersTableAdapter();
            this.tableAdapterManager = new MelsMobilityProject.MelDatabaseDataSetMainTableAdapters.TableAdapterManager();
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.scooterTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxScooter = new System.Windows.Forms.PictureBox();
            this.customerrentalbutton = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            scooterLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.melDatabaseDataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingNavigator)).BeginInit();
            this.scootersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScooter)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(117, 191);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(52, 33);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // scooterLabel
            // 
            scooterLabel.AutoSize = true;
            scooterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scooterLabel.Location = new System.Drawing.Point(117, 228);
            scooterLabel.Name = "scooterLabel";
            scooterLabel.Size = new System.Drawing.Size(123, 33);
            scooterLabel.TabIndex = 5;
            scooterLabel.Text = "Scooter:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(117, 265);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(101, 33);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(117, 302);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(93, 33);
            colorLabel.TabIndex = 9;
            colorLabel.Text = "Color:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(117, 339);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(141, 33);
            categoryLabel.TabIndex = 11;
            categoryLabel.Text = "Category:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conditionLabel.Location = new System.Drawing.Point(117, 376);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(146, 33);
            conditionLabel.TabIndex = 13;
            conditionLabel.Text = "Condition:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scooters!!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonExitmain
            // 
            this.buttonExitmain.BackColor = System.Drawing.Color.Red;
            this.buttonExitmain.Location = new System.Drawing.Point(12, 629);
            this.buttonExitmain.Name = "buttonExitmain";
            this.buttonExitmain.Size = new System.Drawing.Size(158, 51);
            this.buttonExitmain.TabIndex = 1;
            this.buttonExitmain.Text = "EXIT";
            this.buttonExitmain.UseVisualStyleBackColor = false;
            this.buttonExitmain.Click += new System.EventHandler(this.buttonExitmain_Click);
            // 
            // melDatabaseDataSetMain
            // 
            this.melDatabaseDataSetMain.DataSetName = "MelDatabaseDataSetMain";
            this.melDatabaseDataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scootersBindingSource
            // 
            this.scootersBindingSource.DataMember = "Scooters";
            this.scootersBindingSource.DataSource = this.melDatabaseDataSetMain;
            // 
            // scootersTableAdapter
            // 
            this.scootersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.rentalTableAdapter = null;
            this.tableAdapterManager.ScootersTableAdapter = this.scootersTableAdapter;
            this.tableAdapterManager.UpdateOrder = MelsMobilityProject.MelDatabaseDataSetMainTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.scootersBindingNavigator.Size = new System.Drawing.Size(1105, 50);
            this.scootersBindingNavigator.TabIndex = 2;
            this.scootersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // scootersBindingNavigatorSaveItem
            // 
            this.scootersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scootersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scootersBindingNavigatorSaveItem.Image")));
            this.scootersBindingNavigatorSaveItem.Name = "scootersBindingNavigatorSaveItem";
            this.scootersBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
            this.scootersBindingNavigatorSaveItem.Text = "Save Data";
            this.scootersBindingNavigatorSaveItem.Click += new System.EventHandler(this.scootersBindingNavigatorSaveItem_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "ID", true));
            this.IDTextBox.Location = new System.Drawing.Point(261, 191);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(239, 31);
            this.IDTextBox.TabIndex = 4;
            // 
            // scooterTextBox
            // 
            this.scooterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Scooter", true));
            this.scooterTextBox.Location = new System.Drawing.Point(261, 228);
            this.scooterTextBox.Name = "scooterTextBox";
            this.scooterTextBox.Size = new System.Drawing.Size(239, 31);
            this.scooterTextBox.TabIndex = 6;
            this.scooterTextBox.TextChanged += new System.EventHandler(this.scooterTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(261, 265);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(239, 31);
            this.nameTextBox.TabIndex = 8;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(261, 302);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(239, 31);
            this.colorTextBox.TabIndex = 10;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(261, 339);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(239, 31);
            this.categoryTextBox.TabIndex = 12;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scootersBindingSource, "Condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(261, 376);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(239, 31);
            this.conditionTextBox.TabIndex = 14;
            // 
            // pictureBoxScooter
            // 
            this.pictureBoxScooter.Location = new System.Drawing.Point(652, 171);
            this.pictureBoxScooter.Name = "pictureBoxScooter";
            this.pictureBoxScooter.Size = new System.Drawing.Size(209, 238);
            this.pictureBoxScooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScooter.TabIndex = 15;
            this.pictureBoxScooter.TabStop = false;
            this.pictureBoxScooter.Click += new System.EventHandler(this.pictureBoxScooter_Click);
            // 
            // customerrentalbutton
            // 
            this.customerrentalbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.customerrentalbutton.Location = new System.Drawing.Point(289, 430);
            this.customerrentalbutton.Name = "customerrentalbutton";
            this.customerrentalbutton.Size = new System.Drawing.Size(211, 48);
            this.customerrentalbutton.TabIndex = 16;
            this.customerrentalbutton.Text = "Customer Rental";
            this.customerrentalbutton.UseVisualStyleBackColor = false;
            this.customerrentalbutton.Click += new System.EventHandler(this.customerrentalbutton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 701);
            this.Controls.Add(this.customerrentalbutton);
            this.Controls.Add(this.pictureBoxScooter);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(scooterLabel);
            this.Controls.Add(this.scooterTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.scootersBindingNavigator);
            this.Controls.Add(this.buttonExitmain);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.melDatabaseDataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scootersBindingNavigator)).EndInit();
            this.scootersBindingNavigator.ResumeLayout(false);
            this.scootersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScooter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExitmain;
        private MelDatabaseDataSetMain melDatabaseDataSetMain;
        private System.Windows.Forms.BindingSource scootersBindingSource;
        private MelDatabaseDataSetMainTableAdapters.ScootersTableAdapter scootersTableAdapter;
        private MelDatabaseDataSetMainTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox scooterTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.PictureBox pictureBoxScooter;
        private System.Windows.Forms.Button customerrentalbutton;
    }
}