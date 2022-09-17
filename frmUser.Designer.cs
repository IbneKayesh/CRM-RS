using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CRM
{
    partial class frmUser
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmUser));
            this.IRDataSet = new System.Data.DataSet();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.IdTextBox1 = new System.Windows.Forms.TextBox();
            this.IdTextBox2 = new System.Windows.Forms.TextBox();
            this.IdTextBox3 = new System.Windows.Forms.TextBox();
            this.IdLabel4 = new System.Windows.Forms.Label();
            this.IdComboBox1 = new System.Windows.Forms.ComboBox();
            this.IdLabel5 = new System.Windows.Forms.Label();
            this.IdTextBox4 = new System.Windows.Forms.TextBox();
            this.IdLabel6 = new System.Windows.Forms.Label();
            this.cbIRSales = new System.Windows.Forms.ComboBox();
            this.cbManagerLinks = new System.Windows.Forms.ComboBox();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.btnDeleteLink = new System.Windows.Forms.Button();
            this.IdGroupBox2 = new System.Windows.Forms.GroupBox();
            this.IdGroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteDLink = new System.Windows.Forms.Button();
            this.cbDriverLinks = new System.Windows.Forms.ComboBox();
            this.btnAddDLink = new System.Windows.Forms.Button();
            this.ckCanLogin = new System.Windows.Forms.CheckBox();
            this.ckRecordManager = new System.Windows.Forms.CheckBox();
            this.ckActive = new System.Windows.Forms.CheckBox();
            this.IdLabel7 = new System.Windows.Forms.Label();
            this.IdTextBox5 = new System.Windows.Forms.TextBox();
            this.btnSeePassword = new System.Windows.Forms.Button();
            this.cmdChangeUserName = new System.Windows.Forms.Button();
            this.ckTell = new System.Windows.Forms.CheckBox();
            this.SalesPersonComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            this.IdGroupBox2.SuspendLayout();
            this.IdGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IRDataSet
            // 
            //this.UsersBindingSource.DataMember = "CRMUsers";
            this.UsersBindingSource.DataSource = this.IRDataSet;
            this.IRDataSet.DataSetName = "IRDataSet";
            this.IRDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // IRDataSet
            // 
            this.SalesPersonComboBindingSource.DataMember = "SalesPersonCombo";
            //this.SalesPersonComboBindingSource.DataSource = this.IRDataSetViews;
            //this.IRDataSetViews.DataSetName = "IRDataSetViews";
            //this.IRDataSetViews.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            //this.SalesPersonComboTableAdapter.ClearBeforeFill = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(486, 58);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "LoginPassword", true));
            // 
            // txtLogin
            // 
            this.txtLogin.AcceptsReturn = true;
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLogin.Location = new System.Drawing.Point(486, 23);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogin.Size = new System.Drawing.Size(175, 22);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.DoubleClick += new System.EventHandler(this.txtLogin_DoubleClick);
            this.txtLogin.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "UserId", true));
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(6, 118);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Brown;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.White;
            this.cmdSave.Location = new System.Drawing.Point(6, 22);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSave.Size = new System.Drawing.Size(98, 42);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Tan;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(381, 95);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(98, 16);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Security Group:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Tan;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(411, 61);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(68, 16);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Password:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Tan;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(437, 26);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(42, 16);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Login:";
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnIndividual);
            this.IdGroupBox1.Controls.Add(this.btnDelete);
            this.IdGroupBox1.Controls.Add(this.cmdSave);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(678, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 219);
            this.IdGroupBox1.TabIndex = 8;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnIndividual
            // 
            this.btnIndividual.BackColor = System.Drawing.Color.Brown;
            this.btnIndividual.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividual.ForeColor = System.Drawing.Color.White;
            this.btnIndividual.Location = new System.Drawing.Point(6, 70);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIndividual.Size = new System.Drawing.Size(98, 42);
            this.btnIndividual.TabIndex = 99;
            this.btnIndividual.Text = "&Add Individual Permission";
            this.btnIndividual.UseVisualStyleBackColor = false;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGroup.Font = new System.Drawing.Font("Arial", 10F);
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(486, 92);
            this.cbGroup.MaxLength = 20;
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(175, 24);
            this.cbGroup.TabIndex = 10;
            this.cbGroup.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "UserGroup", true));
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(19, 25);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(79, 16);
            this.IdLabel1.TabIndex = 11;
            this.IdLabel1.Text = "First Name:";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(55, 60);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(43, 16);
            this.IdLabel2.TabIndex = 12;
            this.IdLabel2.Text = "Initial:";
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel3.Location = new System.Drawing.Point(20, 95);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(78, 16);
            this.IdLabel3.TabIndex = 13;
            this.IdLabel3.Text = "Last Name:";
            // 
            // IdTextBox1
            // 
            this.IdTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTextBox1.ForeColor = System.Drawing.Color.Black;
            this.IdTextBox1.Location = new System.Drawing.Point(105, 22);
            this.IdTextBox1.MaxLength = 128;
            this.IdTextBox1.Name = "IdTextBox1";
            this.IdTextBox1.Size = new System.Drawing.Size(230, 23);
            this.IdTextBox1.TabIndex = 14;
            this.IdTextBox1.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "FirstName", true));
            // 
            // IdTextBox2
            // 
            this.IdTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTextBox2.ForeColor = System.Drawing.Color.Black;
            this.IdTextBox2.Location = new System.Drawing.Point(105, 57);
            this.IdTextBox2.MaxLength = 1;
            this.IdTextBox2.Name = "IdTextBox2";
            this.IdTextBox2.Size = new System.Drawing.Size(27, 23);
            this.IdTextBox2.TabIndex = 15;
            this.IdTextBox2.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "MiddleName", true));
            // 
            // IdTextBox3
            // 
            this.IdTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTextBox3.ForeColor = System.Drawing.Color.Black;
            this.IdTextBox3.Location = new System.Drawing.Point(105, 92);
            this.IdTextBox3.MaxLength = 128;
            this.IdTextBox3.Name = "IdTextBox3";
            this.IdTextBox3.Size = new System.Drawing.Size(230, 23);
            this.IdTextBox3.TabIndex = 16;
            this.IdTextBox3.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "LastName", true));
            // 
            // IdLabel4
            // 
            this.IdLabel4.AutoSize = true;
            this.IdLabel4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel4.Location = new System.Drawing.Point(34, 131);
            this.IdLabel4.Name = "IdLabel4";
            this.IdLabel4.Size = new System.Drawing.Size(63, 16);
            this.IdLabel4.TabIndex = 17;
            this.IdLabel4.Text = "Job Title:";
            // 
            // IdComboBox1
            // 
            this.IdComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.IdComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IdComboBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdComboBox1.FormattingEnabled = true;
            this.IdComboBox1.Items.AddRange(new object[] {
            "ACCOUNT MANAGER",
            "ADMIN ACCOUNT",
            "ADMINISTRATIVE ASSISTANT",
            "CUSTOMER SERVICE REPRESENTATIVE",
            "GENERAL MANAGER",
            "INSIDE SALES REPRESENTATIVE",
            "INSIDE SALES SUPPORT",
            "MARKETING COORDINATOR",
            "PRESIDENT",
            "REGIONAL SALES MANAGER",
            "SALES",
            "SALES MANAGER",
            "SALES REPRESENTATIVE",
            "SALES SUPPORT",
            "TECHNICIAN",
            "TERRITORY REPRESENTATIVE"});
            this.IdComboBox1.Location = new System.Drawing.Point(105, 127);
            this.IdComboBox1.MaxLength = 128;
            this.IdComboBox1.Name = "IdComboBox1";
            this.IdComboBox1.Size = new System.Drawing.Size(230, 24);
            this.IdComboBox1.TabIndex = 19;
            this.IdComboBox1.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "JobTitle", true));
            // 
            // IdLabel5
            // 
            this.IdLabel5.AutoSize = true;
            this.IdLabel5.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel5.Location = new System.Drawing.Point(53, 166);
            this.IdLabel5.Name = "IdLabel5";
            this.IdLabel5.Size = new System.Drawing.Size(45, 16);
            this.IdLabel5.TabIndex = 20;
            this.IdLabel5.Text = "Email:";
            // 
            // IdTextBox4
            // 
            this.IdTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTextBox4.ForeColor = System.Drawing.Color.Black;
            this.IdTextBox4.Location = new System.Drawing.Point(105, 163);
            this.IdTextBox4.MaxLength = 100;
            this.IdTextBox4.Name = "IdTextBox4";
            this.IdTextBox4.Size = new System.Drawing.Size(289, 23);
            this.IdTextBox4.TabIndex = 21;
            this.IdTextBox4.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "Email", true));
            // 
            // IdLabel6
            // 
            this.IdLabel6.AutoSize = true;
            this.IdLabel6.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel6.Location = new System.Drawing.Point(367, 130);
            this.IdLabel6.Name = "IdLabel6";
            this.IdLabel6.Size = new System.Drawing.Size(112, 16);
            this.IdLabel6.TabIndex = 24;
            this.IdLabel6.Text = "IR Sales Person:";
            // 
            // cbIRSales
            // 
            this.cbIRSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbIRSales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIRSales.DisplayMember = "Name";
            this.cbIRSales.Font = new System.Drawing.Font("Arial", 10F);
            this.cbIRSales.FormattingEnabled = true;
            this.cbIRSales.Location = new System.Drawing.Point(486, 127);
            this.cbIRSales.MaxLength = 20;
            this.cbIRSales.Name = "cbIRSales";
            this.cbIRSales.Size = new System.Drawing.Size(175, 24);
            this.cbIRSales.TabIndex = 25;
            this.cbIRSales.ValueMember = "SalesPersonNo";
            this.cbIRSales.DataBindings.Add(new Binding("SelectedValue", this.UsersBindingSource, "IRSalesPersonNo", true));
            this.cbIRSales.DataSource = this.SalesPersonComboBindingSource;
            // 
            // cbManagerLinks
            // 
            this.cbManagerLinks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbManagerLinks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbManagerLinks.Font = new System.Drawing.Font("Arial", 10F);
            this.cbManagerLinks.FormattingEnabled = true;
            this.cbManagerLinks.Location = new System.Drawing.Point(17, 22);
            this.cbManagerLinks.Name = "cbManagerLinks";
            this.cbManagerLinks.Size = new System.Drawing.Size(178, 24);
            this.cbManagerLinks.TabIndex = 27;
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.Color.Brown;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLink.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.Location = new System.Drawing.Point(17, 59);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(126, 26);
            this.btnAddLink.TabIndex = 28;
            this.btnAddLink.Text = "Add Link";
            this.btnAddLink.UseVisualStyleBackColor = false;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // btnDeleteLink
            // 
            this.btnDeleteLink.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLink.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDeleteLink.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLink.Location = new System.Drawing.Point(153, 59);
            this.btnDeleteLink.Name = "btnDeleteLink";
            this.btnDeleteLink.Size = new System.Drawing.Size(126, 26);
            this.btnDeleteLink.TabIndex = 29;
            this.btnDeleteLink.Text = "Delete Link";
            this.btnDeleteLink.UseVisualStyleBackColor = false;
            this.btnDeleteLink.Click += new System.EventHandler(this.btnDeleteLink_Click);
            // 
            // IdGroupBox2
            // 
            this.IdGroupBox2.Controls.Add(this.btnDeleteLink);
            this.IdGroupBox2.Controls.Add(this.cbManagerLinks);
            this.IdGroupBox2.Controls.Add(this.btnAddLink);
            this.IdGroupBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox2.Location = new System.Drawing.Point(22, 248);
            this.IdGroupBox2.Name = "IdGroupBox2";
            this.IdGroupBox2.Size = new System.Drawing.Size(295, 100);
            this.IdGroupBox2.TabIndex = 31;
            this.IdGroupBox2.TabStop = false;
            this.IdGroupBox2.Text = "Linked Record Managers:";
            // 
            // IdGroupBox3
            // 
            this.IdGroupBox3.Controls.Add(this.btnDeleteDLink);
            this.IdGroupBox3.Controls.Add(this.cbDriverLinks);
            this.IdGroupBox3.Controls.Add(this.btnAddDLink);
            this.IdGroupBox3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox3.Location = new System.Drawing.Point(330, 248);
            this.IdGroupBox3.Name = "IdGroupBox3";
            this.IdGroupBox3.Size = new System.Drawing.Size(295, 100);
            this.IdGroupBox3.TabIndex = 32;
            this.IdGroupBox3.TabStop = false;
            this.IdGroupBox3.Text = "Linked Drivers:";
            // 
            // btnDeleteDLink
            // 
            this.btnDeleteDLink.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteDLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDLink.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDeleteDLink.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDLink.Location = new System.Drawing.Point(153, 59);
            this.btnDeleteDLink.Name = "btnDeleteDLink";
            this.btnDeleteDLink.Size = new System.Drawing.Size(126, 26);
            this.btnDeleteDLink.TabIndex = 29;
            this.btnDeleteDLink.Text = "Delete Link";
            this.btnDeleteDLink.UseVisualStyleBackColor = false;
            this.btnDeleteDLink.Click += new System.EventHandler(this.btnDeleteDLink_Click);
            // 
            // cbDriverLinks
            // 
            this.cbDriverLinks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbDriverLinks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDriverLinks.Font = new System.Drawing.Font("Arial", 10F);
            this.cbDriverLinks.FormattingEnabled = true;
            this.cbDriverLinks.Location = new System.Drawing.Point(17, 22);
            this.cbDriverLinks.Name = "cbDriverLinks";
            this.cbDriverLinks.Size = new System.Drawing.Size(178, 24);
            this.cbDriverLinks.TabIndex = 27;
            // 
            // btnAddDLink
            // 
            this.btnAddDLink.BackColor = System.Drawing.Color.Brown;
            this.btnAddDLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDLink.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAddDLink.ForeColor = System.Drawing.Color.White;
            this.btnAddDLink.Location = new System.Drawing.Point(17, 59);
            this.btnAddDLink.Name = "btnAddDLink";
            this.btnAddDLink.Size = new System.Drawing.Size(126, 26);
            this.btnAddDLink.TabIndex = 28;
            this.btnAddDLink.Text = "Add Link";
            this.btnAddDLink.UseVisualStyleBackColor = false;
            this.btnAddDLink.Click += new System.EventHandler(this.btnAddDLink_Click);
            // 
            // ckCanLogin
            // 
            this.ckCanLogin.AutoSize = true;
            this.ckCanLogin.Font = new System.Drawing.Font("Arial", 10F);
            this.ckCanLogin.Location = new System.Drawing.Point(362, 200);
            this.ckCanLogin.Name = "ckCanLogin";
            this.ckCanLogin.Size = new System.Drawing.Size(91, 20);
            this.ckCanLogin.TabIndex = 35;
            this.ckCanLogin.Text = "Can Login";
            this.ckCanLogin.UseVisualStyleBackColor = true;
            this.ckCanLogin.DataBindings.Add(new Binding("CheckState", this.UsersBindingSource, "CanLogin", true));
            // 
            // ckRecordManager
            // 
            this.ckRecordManager.AutoSize = true;
            this.ckRecordManager.Font = new System.Drawing.Font("Arial", 10F);
            this.ckRecordManager.Location = new System.Drawing.Point(183, 200);
            this.ckRecordManager.Name = "ckRecordManager";
            this.ckRecordManager.Size = new System.Drawing.Size(161, 20);
            this.ckRecordManager.TabIndex = 34;
            this.ckRecordManager.Text = "Non Record Manager";
            this.ckRecordManager.UseVisualStyleBackColor = true;
            this.ckRecordManager.CheckedChanged += new System.EventHandler(this.ckRecordManager_CheckedChanged);
            this.ckRecordManager.DataBindings.Add(new Binding("CheckState", this.UsersBindingSource, "NonRecordManager", true));
            // 
            // ckActive
            // 
            this.ckActive.AutoSize = true;
            this.ckActive.Font = new System.Drawing.Font("Arial", 10F);
            this.ckActive.Location = new System.Drawing.Point(100, 200);
            this.ckActive.Name = "ckActive";
            this.ckActive.Size = new System.Drawing.Size(64, 20);
            this.ckActive.TabIndex = 33;
            this.ckActive.Text = "Active";
            this.ckActive.UseVisualStyleBackColor = true;
            this.ckActive.DataBindings.Add(new Binding("CheckState", this.UsersBindingSource, "Active", true));
            // 
            // IdLabel7
            // 
            this.IdLabel7.AutoSize = true;
            this.IdLabel7.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel7.Location = new System.Drawing.Point(427, 166);
            this.IdLabel7.Name = "IdLabel7";
            this.IdLabel7.Size = new System.Drawing.Size(52, 16);
            this.IdLabel7.TabIndex = 36;
            this.IdLabel7.Text = "Phone:";
            // 
            // IdTextBox5
            // 
            this.IdTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox5.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTextBox5.ForeColor = System.Drawing.Color.Black;
            this.IdTextBox5.Location = new System.Drawing.Point(486, 163);
            this.IdTextBox5.Name = "IdTextBox5";
            this.IdTextBox5.Size = new System.Drawing.Size(175, 23);
            this.IdTextBox5.TabIndex = 37;
            this.IdTextBox5.DataBindings.Add(new Binding("Text", this.UsersBindingSource, "Phone", true));
            // 
            // btnSeePassword
            // 
            this.btnSeePassword.BackColor = System.Drawing.Color.Brown;
            this.btnSeePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeePassword.ForeColor = System.Drawing.Color.White;
            this.btnSeePassword.Location = new System.Drawing.Point(684, 299);
            this.btnSeePassword.Name = "btnSeePassword";
            this.btnSeePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSeePassword.Size = new System.Drawing.Size(98, 42);
            this.btnSeePassword.TabIndex = 99;
            this.btnSeePassword.Text = "See Password";
            this.btnSeePassword.UseVisualStyleBackColor = false;
            this.btnSeePassword.Click += new System.EventHandler(this.btnSeePassword_Click);
            // 
            // cmdChangeUserName
            // 
            this.cmdChangeUserName.BackColor = System.Drawing.Color.Brown;
            this.cmdChangeUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdChangeUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChangeUserName.ForeColor = System.Drawing.Color.White;
            this.cmdChangeUserName.Location = new System.Drawing.Point(684, 248);
            this.cmdChangeUserName.Name = "cmdChangeUserName";
            this.cmdChangeUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdChangeUserName.Size = new System.Drawing.Size(98, 42);
            this.cmdChangeUserName.TabIndex = 100;
            this.cmdChangeUserName.Text = "Change User Login";
            this.cmdChangeUserName.UseVisualStyleBackColor = false;
            this.cmdChangeUserName.Visible = false;
            this.cmdChangeUserName.Click += new System.EventHandler(this.cmdChangeUserName_Click);
            // 
            // ckTell
            // 
            this.ckTell.AutoSize = true;
            this.ckTell.Font = new System.Drawing.Font("Arial", 10F);
            this.ckTell.Location = new System.Drawing.Point(183, 222);
            this.ckTell.Name = "ckTell";
            this.ckTell.Size = new System.Drawing.Size(108, 20);
            this.ckTell.TabIndex = 101;
            this.ckTell.Text = "Telemarketer";
            this.ckTell.UseVisualStyleBackColor = true;
            this.ckTell.CheckedChanged += new System.EventHandler(this.ckTell_CheckedChanged);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(804, 360);
            this.Controls.Add(this.ckTell);
            this.Controls.Add(this.cmdChangeUserName);
            this.Controls.Add(this.btnSeePassword);
            this.Controls.Add(this.IdTextBox5);
            this.Controls.Add(this.IdLabel7);
            this.Controls.Add(this.ckCanLogin);
            this.Controls.Add(this.ckRecordManager);
            this.Controls.Add(this.ckActive);
            this.Controls.Add(this.IdGroupBox3);
            this.Controls.Add(this.IdGroupBox2);
            this.Controls.Add(this.cbIRSales);
            this.Controls.Add(this.IdLabel6);
            this.Controls.Add(this.IdGroupBox1);
            this.Controls.Add(this.IdTextBox4);
            this.Controls.Add(this.IdLabel5);
            this.Controls.Add(this.IdComboBox1);
            this.Controls.Add(this.IdLabel4);
            this.Controls.Add(this.IdTextBox3);
            this.Controls.Add(this.IdTextBox2);
            this.Controls.Add(this.IdTextBox1);
            this.Controls.Add(this.IdLabel3);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(4, 23);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            this.IdGroupBox1.ResumeLayout(false);
            this.IdGroupBox2.ResumeLayout(false);
            this.IdGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet IRDataSet;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdChangeUserName;
        private System.Windows.Forms.Button btnSeePassword;
        private System.Windows.Forms.Button btnAddDLink;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteLink;
        private System.Windows.Forms.Button btnDeleteDLink;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.Label IdLabel4;
        private System.Windows.Forms.Label IdLabel5;
        private System.Windows.Forms.Label IdLabel6;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label IdLabel7;
        private System.Windows.Forms.TextBox IdTextBox1;
        private System.Windows.Forms.TextBox IdTextBox2;
        private System.Windows.Forms.TextBox IdTextBox3;
        private System.Windows.Forms.TextBox IdTextBox4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox IdTextBox5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ComboBox IdComboBox1;
        private System.Windows.Forms.ComboBox cbDriverLinks;
        private System.Windows.Forms.ComboBox cbIRSales;
        private System.Windows.Forms.ComboBox cbManagerLinks;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.GroupBox IdGroupBox2;
        private System.Windows.Forms.GroupBox IdGroupBox3;
        private System.Windows.Forms.CheckBox ckCanLogin;
        private System.Windows.Forms.CheckBox ckRecordManager;
        private System.Windows.Forms.CheckBox ckActive;
        private System.Windows.Forms.CheckBox ckTell;
        private BindingSource SalesPersonComboBindingSource;
        private BindingSource UsersBindingSource;
    }
}