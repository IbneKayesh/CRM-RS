using System.ComponentModel;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Drawing;

namespace CRM
{
    partial class frmRMA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IRDataSet = new System.Data.DataSet();
            this.cbReturnShipping = new System.Windows.Forms.ComboBox();
            this.IdLabel32 = new System.Windows.Forms.Label();
            this.lblIRCode = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.IdLabel13 = new System.Windows.Forms.Label();
            this.IdLabel12 = new System.Windows.Forms.Label();
            this.IdLabel11 = new System.Windows.Forms.Label();
            this.IdLabel10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtIRCode = new System.Windows.Forms.TextBox();
            this.txtRecordManager = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.IdLabel9 = new System.Windows.Forms.Label();
            this.IdLabel8 = new System.Windows.Forms.Label();
            this.IdLabel7 = new System.Windows.Forms.Label();
            this.IdLabel6 = new System.Windows.Forms.Label();
            this.IdLabel5 = new System.Windows.Forms.Label();
            this.IdLabel4 = new System.Windows.Forms.Label();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.gridDetails = new System.Windows.Forms.DataGridView();
            this.dtPickupDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.txtCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtRMA = new System.Windows.Forms.TextBox();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.RecordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumbnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProblemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbBranchCode = new System.Windows.Forms.ComboBox();
            this.IdLabel14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "IRDataSet";
            // 
            // cbReturnShipping
            // 
            this.cbReturnShipping.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbReturnShipping.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReturnShipping.Font = new System.Drawing.Font("Arial", 10F);
            this.cbReturnShipping.FormattingEnabled = true;
            this.cbReturnShipping.Location = new System.Drawing.Point(588, 229);
            this.cbReturnShipping.Name = "cbReturnShipping";
            this.cbReturnShipping.Size = new System.Drawing.Size(273, 24);
            this.cbReturnShipping.TabIndex = 13;
            this.cbReturnShipping.Tag = "HideOnDemand";
            // 
            // IdLabel32
            // 
            this.IdLabel32.AutoSize = true;
            this.IdLabel32.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel32.Location = new System.Drawing.Point(482, 233);
            this.IdLabel32.Name = "IdLabel32";
            this.IdLabel32.Size = new System.Drawing.Size(99, 15);
            this.IdLabel32.TabIndex = 77;
            this.IdLabel32.Tag = "HideOnDemand";
            this.IdLabel32.Text = "Return Shipping:";
            // 
            // lblIRCode
            // 
            this.lblIRCode.AutoSize = true;
            this.lblIRCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblIRCode.Location = new System.Drawing.Point(534, 82);
            this.lblIRCode.Name = "lblIRCode";
            this.lblIRCode.Size = new System.Drawing.Size(238, 16);
            this.lblIRCode.TabIndex = 75;
            this.lblIRCode.Text = "ADDRESS WAS PULLED FROM IR2";
            this.lblIRCode.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNotes.Location = new System.Drawing.Point(12, 281);
            this.txtNotes.MaxLength = 1000;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(915, 80);
            this.txtNotes.TabIndex = 14;
            this.txtNotes.Text = "";
            // 
            // IdLabel13
            // 
            this.IdLabel13.AutoSize = true;
            this.IdLabel13.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel13.Location = new System.Drawing.Point(12, 263);
            this.IdLabel13.Name = "IdLabel13";
            this.IdLabel13.Size = new System.Drawing.Size(133, 16);
            this.IdLabel13.TabIndex = 69;
            this.IdLabel13.Text = "Special Instructions:";
            // 
            // IdLabel12
            // 
            this.IdLabel12.AutoSize = true;
            this.IdLabel12.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel12.Location = new System.Drawing.Point(533, 202);
            this.IdLabel12.Name = "IdLabel12";
            this.IdLabel12.Size = new System.Drawing.Size(47, 16);
            this.IdLabel12.TabIndex = 67;
            this.IdLabel12.Text = "Cell #:";
            // 
            // IdLabel11
            // 
            this.IdLabel11.AutoSize = true;
            this.IdLabel11.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel11.Location = new System.Drawing.Point(54, 232);
            this.IdLabel11.Name = "IdLabel11";
            this.IdLabel11.Size = new System.Drawing.Size(45, 16);
            this.IdLabel11.TabIndex = 66;
            this.IdLabel11.Text = "Email:";
            // 
            // IdLabel10
            // 
            this.IdLabel10.AutoSize = true;
            this.IdLabel10.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel10.Location = new System.Drawing.Point(35, 202);
            this.IdLabel10.Name = "IdLabel10";
            this.IdLabel10.Size = new System.Drawing.Size(64, 16);
            this.IdLabel10.TabIndex = 65;
            this.IdLabel10.Text = "Phone #:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail.Location = new System.Drawing.Point(106, 229);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPhone.Location = new System.Drawing.Point(106, 199);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(315, 23);
            this.txtPhone.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContact.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContact.Location = new System.Drawing.Point(106, 169);
            this.txtContact.MaxLength = 50;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(315, 23);
            this.txtContact.TabIndex = 5;
            // 
            // txtCell
            // 
            this.txtCell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCell.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCell.Location = new System.Drawing.Point(588, 199);
            this.txtCell.MaxLength = 20;
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(185, 23);
            this.txtCell.TabIndex = 12;
            // 
            // txtZip
            // 
            this.txtZip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtZip.Font = new System.Drawing.Font("Arial", 10F);
            this.txtZip.Location = new System.Drawing.Point(588, 139);
            this.txtZip.MaxLength = 10;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(121, 23);
            this.txtZip.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Font = new System.Drawing.Font("Arial", 10F);
            this.txtState.Location = new System.Drawing.Point(498, 139);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(40, 23);
            this.txtState.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCity.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCity.Location = new System.Drawing.Point(106, 139);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(315, 23);
            this.txtCity.TabIndex = 4;
            // 
            // txtAddress2
            // 
            this.txtAddress2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAddress2.Location = new System.Drawing.Point(106, 109);
            this.txtAddress2.MaxLength = 50;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(315, 23);
            this.txtAddress2.TabIndex = 3;
            // 
            // txtIRCode
            // 
            this.txtIRCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIRCode.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIRCode.Location = new System.Drawing.Point(588, 49);
            this.txtIRCode.MaxLength = 20;
            this.txtIRCode.Name = "txtIRCode";
            this.txtIRCode.Size = new System.Drawing.Size(185, 23);
            this.txtIRCode.TabIndex = 9;
            // 
            // txtRecordManager
            // 
            this.txtRecordManager.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRecordManager.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRecordManager.Location = new System.Drawing.Point(588, 20);
            this.txtRecordManager.MaxLength = 20;
            this.txtRecordManager.Name = "txtRecordManager";
            this.txtRecordManager.Size = new System.Drawing.Size(185, 23);
            this.txtRecordManager.TabIndex = 8;
            // 
            // txtAddress1
            // 
            this.txtAddress1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress1.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAddress1.Location = new System.Drawing.Point(106, 79);
            this.txtAddress1.MaxLength = 50;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(315, 23);
            this.txtAddress1.TabIndex = 2;
            // 
            // IdLabel9
            // 
            this.IdLabel9.AutoSize = true;
            this.IdLabel9.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel9.Location = new System.Drawing.Point(39, 172);
            this.IdLabel9.Name = "IdLabel9";
            this.IdLabel9.Size = new System.Drawing.Size(60, 16);
            this.IdLabel9.TabIndex = 53;
            this.IdLabel9.Text = "Contact:";
            // 
            // IdLabel8
            // 
            this.IdLabel8.AutoSize = true;
            this.IdLabel8.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel8.Location = new System.Drawing.Point(551, 142);
            this.IdLabel8.Name = "IdLabel8";
            this.IdLabel8.Size = new System.Drawing.Size(30, 16);
            this.IdLabel8.TabIndex = 52;
            this.IdLabel8.Text = "Zip:";
            // 
            // IdLabel7
            // 
            this.IdLabel7.AutoSize = true;
            this.IdLabel7.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel7.Location = new System.Drawing.Point(447, 142);
            this.IdLabel7.Name = "IdLabel7";
            this.IdLabel7.Size = new System.Drawing.Size(44, 16);
            this.IdLabel7.TabIndex = 51;
            this.IdLabel7.Text = "State:";
            // 
            // IdLabel6
            // 
            this.IdLabel6.AutoSize = true;
            this.IdLabel6.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel6.Location = new System.Drawing.Point(64, 142);
            this.IdLabel6.Name = "IdLabel6";
            this.IdLabel6.Size = new System.Drawing.Size(35, 16);
            this.IdLabel6.TabIndex = 50;
            this.IdLabel6.Text = "City:";
            // 
            // IdLabel5
            // 
            this.IdLabel5.AutoSize = true;
            this.IdLabel5.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel5.Location = new System.Drawing.Point(39, 82);
            this.IdLabel5.Name = "IdLabel5";
            this.IdLabel5.Size = new System.Drawing.Size(58, 16);
            this.IdLabel5.TabIndex = 49;
            this.IdLabel5.Text = "Ship To:";
            // 
            // IdLabel4
            // 
            this.IdLabel4.AutoSize = true;
            this.IdLabel4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel4.Location = new System.Drawing.Point(470, 52);
            this.IdLabel4.Name = "IdLabel4";
            this.IdLabel4.Size = new System.Drawing.Size(110, 16);
            this.IdLabel4.TabIndex = 48;
            this.IdLabel4.Text = "Customer Code:";
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel3.Location = new System.Drawing.Point(27, 52);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(72, 16);
            this.IdLabel3.TabIndex = 47;
            this.IdLabel3.Text = "Customer:";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(490, 23);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(90, 16);
            this.IdLabel2.TabIndex = 46;
            this.IdLabel2.Text = "Salesperson:";
            // 
            // gridDetails
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue;
            this.gridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetails.Location = new System.Drawing.Point(10, 367);
            this.gridDetails.MultiSelect = false;
            this.gridDetails.Name = "gridDetails";
            this.gridDetails.Size = new System.Drawing.Size(915, 255);
            this.gridDetails.TabIndex = 15;
            // 
            // dtPickupDate
            // 
            this.dtPickupDate.Location = new System.Drawing.Point(106, 20);
            this.dtPickupDate.Name = "dtPickupDate";
            this.dtPickupDate.Size = new System.Drawing.Size(124, 20);
            this.dtPickupDate.TabIndex = 0;
            this.dtPickupDate.Tag = "HideOnDemand";
            // 
            // txtCustomer
            // 
            this.txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomer.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCustomer.Location = new System.Drawing.Point(106, 49);
            this.txtCustomer.MaxLength = 50;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(315, 23);
            this.txtCustomer.TabIndex = 1;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(58, 23);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(41, 16);
            this.IdLabel1.TabIndex = 42;
            this.IdLabel1.Text = "Date:";
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.cmdDelete);
            this.IdGroupBox1.Controls.Add(this.cmdGenerate);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(821, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 167);
            this.IdGroupBox1.TabIndex = 16;
            this.IdGroupBox1.TabStop = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Brown;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ForeColor = System.Drawing.Color.White;
            this.cmdDelete.Location = new System.Drawing.Point(7, 110);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(98, 42);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "&Delete";
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.BackColor = System.Drawing.Color.Brown;
            this.cmdGenerate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerate.ForeColor = System.Drawing.Color.White;
            this.cmdGenerate.Location = new System.Drawing.Point(7, 15);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(98, 42);
            this.cmdGenerate.TabIndex = 0;
            this.cmdGenerate.Text = "&Generate";
            this.cmdGenerate.UseVisualStyleBackColor = false;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(7, 63);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreateUser.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCreateUser.Location = new System.Drawing.Point(524, 517);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(89, 23);
            this.txtCreateUser.TabIndex = 74;
            this.txtCreateUser.TabStop = false;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Location = new System.Drawing.Point(524, 474);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(124, 20);
            this.txtCreateDate.TabIndex = 73;
            this.txtCreateDate.TabStop = false;
            this.txtCreateDate.Tag = "HideOnDemand";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompanyID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCompanyID.Location = new System.Drawing.Point(524, 445);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(89, 23);
            this.txtCompanyID.TabIndex = 72;
            this.txtCompanyID.TabStop = false;
            // 
            // txtRMA
            // 
            this.txtRMA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRMA.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRMA.Location = new System.Drawing.Point(524, 407);
            this.txtRMA.Name = "txtRMA";
            this.txtRMA.Size = new System.Drawing.Size(89, 23);
            this.txtRMA.TabIndex = 71;
            this.txtRMA.TabStop = false;
            // 
            // txtContactID
            // 
            this.txtContactID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContactID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContactID.Location = new System.Drawing.Point(524, 546);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(89, 23);
            this.txtContactID.TabIndex = 78;
            this.txtContactID.TabStop = false;
            // 
            // RecordIDDataGridViewTextBoxColumn
            // 
            this.RecordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.RecordIDDataGridViewTextBoxColumn.HeaderText = "RecordID";
            this.RecordIDDataGridViewTextBoxColumn.Name = "RecordIDDataGridViewTextBoxColumn";
            this.RecordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.RecordIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // RMAIDDataGridViewTextBoxColumn
            // 
            this.RMAIDDataGridViewTextBoxColumn.DataPropertyName = "RMAID";
            this.RMAIDDataGridViewTextBoxColumn.HeaderText = "RMAID";
            this.RMAIDDataGridViewTextBoxColumn.Name = "RMAIDDataGridViewTextBoxColumn";
            this.RMAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // QtyDataGridViewTextBoxColumn
            // 
            this.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.QtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn";
            this.QtyDataGridViewTextBoxColumn.Width = 48;
            // 
            // ManufacturerDataGridViewTextBoxColumn
            // 
            this.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn";
            this.ManufacturerDataGridViewTextBoxColumn.Width = 95;
            // 
            // ItemNumbnerDataGridViewTextBoxColumn
            // 
            this.ItemNumbnerDataGridViewTextBoxColumn.DataPropertyName = "ItemNumbner";
            this.ItemNumbnerDataGridViewTextBoxColumn.HeaderText = "ItemNumbner";
            this.ItemNumbnerDataGridViewTextBoxColumn.Name = "ItemNumbnerDataGridViewTextBoxColumn";
            this.ItemNumbnerDataGridViewTextBoxColumn.Width = 95;
            // 
            // DescriptionDataGridViewTextBoxColumn
            // 
            this.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn";
            this.DescriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // ProblemDataGridViewTextBoxColumn
            // 
            this.ProblemDataGridViewTextBoxColumn.DataPropertyName = "Problem";
            this.ProblemDataGridViewTextBoxColumn.HeaderText = "Problem";
            this.ProblemDataGridViewTextBoxColumn.Name = "ProblemDataGridViewTextBoxColumn";
            this.ProblemDataGridViewTextBoxColumn.Width = 70;
            // 
            // RushDataGridViewCheckBoxColumn
            // 
            this.RushDataGridViewCheckBoxColumn.DataPropertyName = "Rush";
            this.RushDataGridViewCheckBoxColumn.HeaderText = "Rush";
            this.RushDataGridViewCheckBoxColumn.Name = "RushDataGridViewCheckBoxColumn";
            this.RushDataGridViewCheckBoxColumn.Width = 38;
            // 
            // RepairPriceDataGridViewTextBoxColumn
            // 
            this.RepairPriceDataGridViewTextBoxColumn.DataPropertyName = "RepairPrice";
            this.RepairPriceDataGridViewTextBoxColumn.HeaderText = "RepairPrice";
            this.RepairPriceDataGridViewTextBoxColumn.Name = "RepairPriceDataGridViewTextBoxColumn";
            this.RepairPriceDataGridViewTextBoxColumn.Width = 87;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // cbBranchCode
            // 
            this.cbBranchCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbBranchCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBranchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cbBranchCode.FormattingEnabled = true;
            this.cbBranchCode.Location = new System.Drawing.Point(588, 170);
            this.cbBranchCode.Name = "cbBranchCode";
            this.cbBranchCode.Size = new System.Drawing.Size(121, 21);
            this.cbBranchCode.TabIndex = 79;
            // 
            // IdLabel14
            // 
            this.IdLabel14.AutoSize = true;
            this.IdLabel14.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel14.Location = new System.Drawing.Point(486, 172);
            this.IdLabel14.Name = "IdLabel14";
            this.IdLabel14.Size = new System.Drawing.Size(94, 16);
            this.IdLabel14.TabIndex = 80;
            this.IdLabel14.Text = "Branch Code:";
            // 
            // frmRMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdLabel14);
            this.Controls.Add(this.cbBranchCode);
            this.Controls.Add(this.cbReturnShipping);
            this.Controls.Add(this.IdLabel32);
            this.Controls.Add(this.lblIRCode);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.IdLabel13);
            this.Controls.Add(this.IdLabel12);
            this.Controls.Add(this.IdLabel11);
            this.Controls.Add(this.IdLabel10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtIRCode);
            this.Controls.Add(this.txtRecordManager);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.IdLabel9);
            this.Controls.Add(this.IdLabel8);
            this.Controls.Add(this.IdLabel7);
            this.Controls.Add(this.IdLabel6);
            this.Controls.Add(this.IdLabel5);
            this.Controls.Add(this.IdLabel4);
            this.Controls.Add(this.IdLabel3);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.gridDetails);
            this.Controls.Add(this.dtPickupDate);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.IdGroupBox1);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.txtRMA);
            this.Controls.Add(this.txtContactID);
            this.Name = "frmRMA";
            this.Tag = "RMA";
            this.Text = "frmRMA";
            this.Load += new System.EventHandler(this.frmRMA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).EndInit();
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle;
        //private System.Windows.Forms.BindingSource CRMRMABindingSource;
        private System.Data.DataSet IRDataSet;
        private System.Windows.Forms.ComboBox cbReturnShipping;
        private System.Windows.Forms.Label IdLabel32;
        private System.Windows.Forms.Label lblIRCode;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label IdLabel13;
        private System.Windows.Forms.Label IdLabel12;
        private System.Windows.Forms.Label IdLabel11;
        private System.Windows.Forms.Label IdLabel10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;        
        private System.Windows.Forms.TextBox txtIRCode;
        private System.Windows.Forms.TextBox txtRecordManager;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label IdLabel9;
        private System.Windows.Forms.Label IdLabel8;
        private System.Windows.Forms.Label IdLabel7;
        private System.Windows.Forms.Label IdLabel6;
        private System.Windows.Forms.Label IdLabel5;
        private System.Windows.Forms.Label IdLabel4;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.Label IdLabel2; 
        private System.Windows.Forms.DataGridView gridDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMAIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumbnerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EachDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnumberNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesOrderNoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.BindingSource CRMRMALinesBindingSource;
        private System.Windows.Forms.DateTimePicker dtPickupDate;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.DateTimePicker txtCreateDate;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtRMA;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumbnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProblemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ComboBox cbBranchCode;
        private System.Windows.Forms.Label IdLabel14;

    }
}