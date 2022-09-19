using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CRM
{
    partial class frmSalesOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SalesOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IRDataSet = new System.Data.DataSet();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtLastChangedDate = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCreditHold = new System.Windows.Forms.TextBox();
            this.lblCreditHold = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.TextBox();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IdTabControl1 = new System.Windows.Forms.TabControl();
            this.tabHeader = new System.Windows.Forms.TabPage();
            this.IdLabel26 = new System.Windows.Forms.Label();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.ckPickup = new System.Windows.Forms.CheckBox();
            this.txtFax2 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.IdLabel7 = new System.Windows.Forms.Label();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdLabel23 = new System.Windows.Forms.Label();
            this.lblContact2 = new System.Windows.Forms.Label();
            this.cbSalesPerson2 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtContact2 = new System.Windows.Forms.TextBox();
            this.ckPrintQuote = new System.Windows.Forms.CheckBox();
            this.txtQStamp = new System.Windows.Forms.RichTextBox();
            this.lblQuoteStamp = new System.Windows.Forms.Label();
            this.IdLabel15 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.dtSODate = new System.Windows.Forms.DateTimePicker();
            this.ckPrintPS = new System.Windows.Forms.CheckBox();
            this.ckPrintSO = new System.Windows.Forms.CheckBox();
            this.IdLabel14 = new System.Windows.Forms.Label();
            this.IdLabel13 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.IdLabel12 = new System.Windows.Forms.Label();
            this.cbSalesPerson = new System.Windows.Forms.TextBox();
            this.cbShipVia = new System.Windows.Forms.TextBox();
            this.IdLabel11 = new System.Windows.Forms.Label();
            this.IdLabel10 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.IdLabel9 = new System.Windows.Forms.Label();
            this.lblContact1 = new System.Windows.Forms.Label();
            this.txtShipToZip = new System.Windows.Forms.TextBox();
            this.txtShipToSt = new System.Windows.Forms.TextBox();
            this.txtShipToCity = new System.Windows.Forms.TextBox();
            this.txtBillZip = new System.Windows.Forms.TextBox();
            this.txtBillSt = new System.Windows.Forms.TextBox();
            this.txtBillCity = new System.Windows.Forms.TextBox();
            this.lblShipTo = new System.Windows.Forms.Label();
            this.IdLabel6 = new System.Windows.Forms.Label();
            this.IdLabel5 = new System.Windows.Forms.Label();
            this.IdLabel4 = new System.Windows.Forms.Label();
            this.txtShipToAddr3 = new System.Windows.Forms.TextBox();
            this.txtShipToAddr2 = new System.Windows.Forms.TextBox();
            this.txtShipToAddr1 = new System.Windows.Forms.TextBox();
            this.txtShipTo = new System.Windows.Forms.TextBox();
            this.txtBillAddr3 = new System.Windows.Forms.TextBox();
            this.txtBillAddr2 = new System.Windows.Forms.TextBox();
            this.txtBillAddr1 = new System.Windows.Forms.TextBox();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCLose = new System.Windows.Forms.Button();
            this.numSalesPersonNo = new System.Windows.Forms.NumericUpDown();
            this.numSalesPersonNo2 = new System.Windows.Forms.NumericUpDown();
            this.numShipMethodid = new System.Windows.Forms.NumericUpDown();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.cmdGetTrack = new System.Windows.Forms.Button();
            this.IdGroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSoScreen = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.IdButton1 = new System.Windows.Forms.Button();
            this.IdGroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.cbWarranty = new System.Windows.Forms.ComboBox();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblRush = new System.Windows.Forms.Label();
            this.gridDetailStatus = new System.Windows.Forms.DataGridView();
            this.lblPriceSource = new System.Windows.Forms.Label();
            this.IdLabel22 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.IdLabel21 = new System.Windows.Forms.Label();
            this.IdLabel20 = new System.Windows.Forms.Label();
            this.IdLabel19 = new System.Windows.Forms.Label();
            this.IdLabel18 = new System.Windows.Forms.Label();
            this.IdLabel17 = new System.Windows.Forms.Label();
            this.txtTech = new System.Windows.Forms.TextBox();
            this.txtSerNo = new System.Windows.Forms.TextBox();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtManuf = new System.Windows.Forms.TextBox();
            this.numSNo = new System.Windows.Forms.NumericUpDown();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.SalesPersonComboBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SalesPersonComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numSONumber = new System.Windows.Forms.NumericUpDown();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.IdTextBox1 = new System.Windows.Forms.TextBox();
            this.IdLabel8 = new System.Windows.Forms.Label();
            this.IdTextBox2 = new System.Windows.Forms.TextBox();
            this.IdTextBox3 = new System.Windows.Forms.TextBox();
            this.IdTextBox4 = new System.Windows.Forms.TextBox();
            this.IdTextBox5 = new System.Windows.Forms.TextBox();
            this.IdLabel16 = new System.Windows.Forms.Label();
            this.IdLabel24 = new System.Windows.Forms.Label();
            this.IdLabel25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            this.IdTabControl1.SuspendLayout();
            this.tabHeader.SuspendLayout();
            this.IdGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalesPersonNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalesPersonNo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShipMethodid)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.IdGroupBox2.SuspendLayout();
            this.IdGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSONumber)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesOrdersBindingSource
            // 
            this.SalesOrdersBindingSource.DataSource = this.IRDataSet;
            this.SalesOrdersBindingSource.Position = 0;
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "IRDataSet";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dtLastChangedDate
            // 
            this.dtLastChangedDate.Location = new System.Drawing.Point(548, 101);
            this.dtLastChangedDate.Name = "dtLastChangedDate";
            this.dtLastChangedDate.Size = new System.Drawing.Size(100, 20);
            this.dtLastChangedDate.TabIndex = 73;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(285, 14);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(68, 16);
            this.lblCustomer.TabIndex = 38;
            this.lblCustomer.Text = "Customer";
            // 
            // txtCreditHold
            // 
            this.txtCreditHold.BackColor = System.Drawing.SystemColors.Window;
            this.txtCreditHold.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreditHold.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCreditHold.Location = new System.Drawing.Point(783, 11);
            this.txtCreditHold.Name = "txtCreditHold";
            this.txtCreditHold.Size = new System.Drawing.Size(115, 23);
            this.txtCreditHold.TabIndex = 36;
            this.txtCreditHold.Visible = false;
            // 
            // lblCreditHold
            // 
            this.lblCreditHold.AutoSize = true;
            this.lblCreditHold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreditHold.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCreditHold.ForeColor = System.Drawing.Color.Red;
            this.lblCreditHold.Location = new System.Drawing.Point(697, 13);
            this.lblCreditHold.Name = "lblCreditHold";
            this.lblCreditHold.Size = new System.Drawing.Size(79, 18);
            this.lblCreditHold.TabIndex = 35;
            this.lblCreditHold.Text = "Credit Hold";
            // 
            // cbCustomer
            // 
            this.cbCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.cbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "CustomerNo", true));
            this.cbCustomer.Font = new System.Drawing.Font("Arial", 10F);
            this.cbCustomer.Location = new System.Drawing.Point(359, 10);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(157, 23);
            this.cbCustomer.TabIndex = 0;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataSource = this.IRDataSet;
            this.CustomersBindingSource.Position = 0;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(17, 14);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(95, 16);
            this.IdLabel1.TabIndex = 31;
            this.IdLabel1.Text = "Sales Order #";
            // 
            // IdTabControl1
            // 
            this.IdTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTabControl1.Controls.Add(this.tabHeader);
            this.IdTabControl1.Controls.Add(this.tabDetail);
            this.IdTabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTabControl1.Location = new System.Drawing.Point(12, 71);
            this.IdTabControl1.Name = "IdTabControl1";
            this.IdTabControl1.SelectedIndex = 0;
            this.IdTabControl1.Size = new System.Drawing.Size(1043, 959);
            this.IdTabControl1.TabIndex = 1;
            this.IdTabControl1.SelectedIndexChanged += new System.EventHandler(this.IdTabControl1_SelectedIndexChanged);
            // 
            // tabHeader
            // 
            this.tabHeader.AutoScroll = true;
            this.tabHeader.BackColor = System.Drawing.Color.Tan;
            this.tabHeader.Controls.Add(this.IdLabel26);
            this.tabHeader.Controls.Add(this.txtBranchCode);
            this.tabHeader.Controls.Add(this.ckPickup);
            this.tabHeader.Controls.Add(this.txtFax2);
            this.tabHeader.Controls.Add(this.txtPhone2);
            this.tabHeader.Controls.Add(this.IdLabel7);
            this.tabHeader.Controls.Add(this.IdLabel3);
            this.tabHeader.Controls.Add(this.IdLabel2);
            this.tabHeader.Controls.Add(this.IdLabel23);
            this.tabHeader.Controls.Add(this.lblContact2);
            this.tabHeader.Controls.Add(this.cbSalesPerson2);
            this.tabHeader.Controls.Add(this.txtEmail2);
            this.tabHeader.Controls.Add(this.txtContact2);
            this.tabHeader.Controls.Add(this.ckPrintQuote);
            this.tabHeader.Controls.Add(this.txtQStamp);
            this.tabHeader.Controls.Add(this.lblQuoteStamp);
            this.tabHeader.Controls.Add(this.IdLabel15);
            this.tabHeader.Controls.Add(this.txtNotes);
            this.tabHeader.Controls.Add(this.dtSODate);
            this.tabHeader.Controls.Add(this.ckPrintPS);
            this.tabHeader.Controls.Add(this.ckPrintSO);
            this.tabHeader.Controls.Add(this.IdLabel14);
            this.tabHeader.Controls.Add(this.IdLabel13);
            this.tabHeader.Controls.Add(this.txtReference);
            this.tabHeader.Controls.Add(this.IdLabel12);
            this.tabHeader.Controls.Add(this.cbSalesPerson);
            this.tabHeader.Controls.Add(this.cbShipVia);
            this.tabHeader.Controls.Add(this.IdLabel11);
            this.tabHeader.Controls.Add(this.IdLabel10);
            this.tabHeader.Controls.Add(this.txtFax);
            this.tabHeader.Controls.Add(this.txtPO);
            this.tabHeader.Controls.Add(this.txtPhone);
            this.tabHeader.Controls.Add(this.txtEmail);
            this.tabHeader.Controls.Add(this.txtContact);
            this.tabHeader.Controls.Add(this.IdLabel9);
            this.tabHeader.Controls.Add(this.lblContact1);
            this.tabHeader.Controls.Add(this.txtShipToZip);
            this.tabHeader.Controls.Add(this.txtShipToSt);
            this.tabHeader.Controls.Add(this.txtShipToCity);
            this.tabHeader.Controls.Add(this.txtBillZip);
            this.tabHeader.Controls.Add(this.txtBillSt);
            this.tabHeader.Controls.Add(this.txtBillCity);
            this.tabHeader.Controls.Add(this.lblShipTo);
            this.tabHeader.Controls.Add(this.IdLabel6);
            this.tabHeader.Controls.Add(this.IdLabel5);
            this.tabHeader.Controls.Add(this.IdLabel4);
            this.tabHeader.Controls.Add(this.txtShipToAddr3);
            this.tabHeader.Controls.Add(this.txtShipToAddr2);
            this.tabHeader.Controls.Add(this.txtShipToAddr1);
            this.tabHeader.Controls.Add(this.txtShipTo);
            this.tabHeader.Controls.Add(this.txtBillAddr3);
            this.tabHeader.Controls.Add(this.txtBillAddr2);
            this.tabHeader.Controls.Add(this.txtBillAddr1);
            this.tabHeader.Controls.Add(this.IdGroupBox1);
            this.tabHeader.Controls.Add(this.numSalesPersonNo);
            this.tabHeader.Controls.Add(this.numSalesPersonNo2);
            this.tabHeader.Controls.Add(this.numShipMethodid);
            this.tabHeader.Location = new System.Drawing.Point(4, 25);
            this.tabHeader.Name = "tabHeader";
            this.tabHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeader.Size = new System.Drawing.Size(1035, 930);
            this.tabHeader.TabIndex = 0;
            this.tabHeader.Text = "Header";
            // 
            // IdLabel26
            // 
            this.IdLabel26.AutoSize = true;
            this.IdLabel26.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel26.Location = new System.Drawing.Point(703, 326);
            this.IdLabel26.Name = "IdLabel26";
            this.IdLabel26.Size = new System.Drawing.Size(90, 16);
            this.IdLabel26.TabIndex = 85;
            this.IdLabel26.Text = "Branch Code";
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBranchCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "BranchCode", true));
            this.txtBranchCode.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBranchCode.Location = new System.Drawing.Point(706, 347);
            this.txtBranchCode.MaxLength = 20;
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.ReadOnly = true;
            this.txtBranchCode.Size = new System.Drawing.Size(123, 23);
            this.txtBranchCode.TabIndex = 84;
            // 
            // ckPickup
            // 
            this.ckPickup.AutoSize = true;
            this.ckPickup.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.SalesOrdersBindingSource, "PickedUp", true));
            this.ckPickup.Font = new System.Drawing.Font("Arial", 10F);
            this.ckPickup.Location = new System.Drawing.Point(803, 262);
            this.ckPickup.Name = "ckPickup";
            this.ckPickup.Size = new System.Drawing.Size(89, 20);
            this.ckPickup.TabIndex = 83;
            this.ckPickup.TabStop = false;
            this.ckPickup.Text = "Picked Up";
            this.ckPickup.UseVisualStyleBackColor = true;
            // 
            // txtFax2
            // 
            this.txtFax2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFax2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Fax2", true));
            this.txtFax2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFax2.Location = new System.Drawing.Point(650, 244);
            this.txtFax2.MaxLength = 20;
            this.txtFax2.Name = "txtFax2";
            this.txtFax2.Size = new System.Drawing.Size(128, 23);
            this.txtFax2.TabIndex = 17;
            // 
            // txtPhone2
            // 
            this.txtPhone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Phone2", true));
            this.txtPhone2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPhone2.Location = new System.Drawing.Point(516, 244);
            this.txtPhone2.MaxLength = 20;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(128, 23);
            this.txtPhone2.TabIndex = 16;
            // 
            // IdLabel7
            // 
            this.IdLabel7.AutoSize = true;
            this.IdLabel7.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel7.Location = new System.Drawing.Point(650, 224);
            this.IdLabel7.Name = "IdLabel7";
            this.IdLabel7.Size = new System.Drawing.Size(30, 16);
            this.IdLabel7.TabIndex = 81;
            this.IdLabel7.Text = "Fax";
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel3.Location = new System.Drawing.Point(516, 224);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(48, 16);
            this.IdLabel3.TabIndex = 80;
            this.IdLabel3.Text = "Phone";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(215, 279);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(86, 16);
            this.IdLabel2.TabIndex = 79;
            this.IdLabel2.Text = "Salesperson";
            // 
            // IdLabel23
            // 
            this.IdLabel23.AutoSize = true;
            this.IdLabel23.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel23.Location = new System.Drawing.Point(203, 224);
            this.IdLabel23.Name = "IdLabel23";
            this.IdLabel23.Size = new System.Drawing.Size(41, 16);
            this.IdLabel23.TabIndex = 78;
            this.IdLabel23.Text = "Email";
            // 
            // lblContact2
            // 
            this.lblContact2.AutoSize = true;
            this.lblContact2.Font = new System.Drawing.Font("Arial", 10F);
            this.lblContact2.Location = new System.Drawing.Point(6, 224);
            this.lblContact2.Name = "lblContact2";
            this.lblContact2.Size = new System.Drawing.Size(56, 16);
            this.lblContact2.TabIndex = 77;
            this.lblContact2.Text = "Contact";
            // 
            // cbSalesPerson2
            // 
            this.cbSalesPerson2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbSalesPerson2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "SalesPerson2", true));
            this.cbSalesPerson2.Font = new System.Drawing.Font("Arial", 10F);
            this.cbSalesPerson2.Location = new System.Drawing.Point(218, 299);
            this.cbSalesPerson2.Name = "cbSalesPerson2";
            this.cbSalesPerson2.Size = new System.Drawing.Size(191, 23);
            this.cbSalesPerson2.TabIndex = 19;
            // 
            // txtEmail2
            // 
            this.txtEmail2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "eMail2", true));
            this.txtEmail2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail2.Location = new System.Drawing.Point(203, 244);
            this.txtEmail2.MaxLength = 50;
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(307, 23);
            this.txtEmail2.TabIndex = 15;
            // 
            // txtContact2
            // 
            this.txtContact2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContact2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Contact2", true));
            this.txtContact2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContact2.Location = new System.Drawing.Point(6, 244);
            this.txtContact2.MaxLength = 30;
            this.txtContact2.Name = "txtContact2";
            this.txtContact2.Size = new System.Drawing.Size(191, 23);
            this.txtContact2.TabIndex = 14;
            // 
            // ckPrintQuote
            // 
            this.ckPrintQuote.AutoSize = true;
            this.ckPrintQuote.Font = new System.Drawing.Font("Arial", 10F);
            this.ckPrintQuote.Location = new System.Drawing.Point(720, 521);
            this.ckPrintQuote.Name = "ckPrintQuote";
            this.ckPrintQuote.Size = new System.Drawing.Size(98, 20);
            this.ckPrintQuote.TabIndex = 70;
            this.ckPrintQuote.Text = "Print Quote";
            this.ckPrintQuote.UseVisualStyleBackColor = true;
            // 
            // txtQStamp
            // 
            this.txtQStamp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "QuoteStamp", true));
            this.txtQStamp.Font = new System.Drawing.Font("Arial", 10F);
            this.txtQStamp.Location = new System.Drawing.Point(6, 521);
            this.txtQStamp.MaxLength = 1000;
            this.txtQStamp.Name = "txtQStamp";
            this.txtQStamp.ReadOnly = true;
            this.txtQStamp.Size = new System.Drawing.Size(675, 96);
            this.txtQStamp.TabIndex = 24;
            this.txtQStamp.Text = "";
            // 
            // lblQuoteStamp
            // 
            this.lblQuoteStamp.AutoSize = true;
            this.lblQuoteStamp.Font = new System.Drawing.Font("Arial", 10F);
            this.lblQuoteStamp.Location = new System.Drawing.Point(6, 500);
            this.lblQuoteStamp.Name = "lblQuoteStamp";
            this.lblQuoteStamp.Size = new System.Drawing.Size(90, 16);
            this.lblQuoteStamp.TabIndex = 68;
            this.lblQuoteStamp.Text = "Quote Stamp";
            // 
            // IdLabel15
            // 
            this.IdLabel15.AutoSize = true;
            this.IdLabel15.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel15.Location = new System.Drawing.Point(6, 374);
            this.IdLabel15.Name = "IdLabel15";
            this.IdLabel15.Size = new System.Drawing.Size(43, 16);
            this.IdLabel15.TabIndex = 67;
            this.IdLabel15.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Notes", true));
            this.txtNotes.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNotes.Location = new System.Drawing.Point(6, 397);
            this.txtNotes.MaxLength = 1000;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(675, 96);
            this.txtNotes.TabIndex = 23;
            this.txtNotes.Text = "";
            // 
            // dtSODate
            // 
            this.dtSODate.Location = new System.Drawing.Point(6, 33);
            this.dtSODate.Name = "dtSODate";
            this.dtSODate.Size = new System.Drawing.Size(100, 23);
            this.dtSODate.TabIndex = 0;
            // 
            // ckPrintPS
            // 
            this.ckPrintPS.AutoSize = true;
            this.ckPrintPS.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.SalesOrdersBindingSource, "PrintNotesOnPackingSlip", true));
            this.ckPrintPS.Font = new System.Drawing.Font("Arial", 10F);
            this.ckPrintPS.Location = new System.Drawing.Point(720, 424);
            this.ckPrintPS.Name = "ckPrintPS";
            this.ckPrintPS.Size = new System.Drawing.Size(101, 20);
            this.ckPrintPS.TabIndex = 64;
            this.ckPrintPS.Text = "Print on P/S";
            this.ckPrintPS.UseVisualStyleBackColor = true;
            // 
            // ckPrintSO
            // 
            this.ckPrintSO.AutoSize = true;
            this.ckPrintSO.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.SalesOrdersBindingSource, "PrintNotesOnSalesOrder", true));
            this.ckPrintSO.Font = new System.Drawing.Font("Arial", 10F);
            this.ckPrintSO.Location = new System.Drawing.Point(720, 397);
            this.ckPrintSO.Name = "ckPrintSO";
            this.ckPrintSO.Size = new System.Drawing.Size(103, 20);
            this.ckPrintSO.TabIndex = 63;
            this.ckPrintSO.Text = "Print on S/O";
            this.ckPrintSO.UseVisualStyleBackColor = true;
            // 
            // IdLabel14
            // 
            this.IdLabel14.AutoSize = true;
            this.IdLabel14.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel14.Location = new System.Drawing.Point(555, 326);
            this.IdLabel14.Name = "IdLabel14";
            this.IdLabel14.Size = new System.Drawing.Size(85, 16);
            this.IdLabel14.TabIndex = 62;
            this.IdLabel14.Text = "Reference #";
            // 
            // IdLabel13
            // 
            this.IdLabel13.AutoSize = true;
            this.IdLabel13.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel13.Location = new System.Drawing.Point(407, 326);
            this.IdLabel13.Name = "IdLabel13";
            this.IdLabel13.Size = new System.Drawing.Size(43, 16);
            this.IdLabel13.TabIndex = 61;
            this.IdLabel13.Text = "P/O #";
            // 
            // txtReference
            // 
            this.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReference.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "RefNumber", true));
            this.txtReference.Font = new System.Drawing.Font("Arial", 10F);
            this.txtReference.Location = new System.Drawing.Point(558, 347);
            this.txtReference.MaxLength = 20;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(123, 23);
            this.txtReference.TabIndex = 22;
            // 
            // IdLabel12
            // 
            this.IdLabel12.AutoSize = true;
            this.IdLabel12.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel12.Location = new System.Drawing.Point(6, 279);
            this.IdLabel12.Name = "IdLabel12";
            this.IdLabel12.Size = new System.Drawing.Size(86, 16);
            this.IdLabel12.TabIndex = 59;
            this.IdLabel12.Text = "Salesperson";
            // 
            // cbSalesPerson
            // 
            this.cbSalesPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbSalesPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "SalesPerson", true));
            this.cbSalesPerson.Font = new System.Drawing.Font("Arial", 10F);
            this.cbSalesPerson.Location = new System.Drawing.Point(6, 299);
            this.cbSalesPerson.Name = "cbSalesPerson";
            this.cbSalesPerson.Size = new System.Drawing.Size(191, 23);
            this.cbSalesPerson.TabIndex = 18;
            // 
            // cbShipVia
            // 
            this.cbShipVia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbShipVia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipMethod", true));
            this.cbShipVia.Font = new System.Drawing.Font("Arial", 10F);
            this.cbShipVia.Location = new System.Drawing.Point(6, 346);
            this.cbShipVia.Name = "cbShipVia";
            this.cbShipVia.Size = new System.Drawing.Size(206, 23);
            this.cbShipVia.TabIndex = 20;
            // 
            // IdLabel11
            // 
            this.IdLabel11.AutoSize = true;
            this.IdLabel11.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel11.Location = new System.Drawing.Point(6, 326);
            this.IdLabel11.Name = "IdLabel11";
            this.IdLabel11.Size = new System.Drawing.Size(59, 16);
            this.IdLabel11.TabIndex = 56;
            this.IdLabel11.Text = "Ship Via";
            // 
            // IdLabel10
            // 
            this.IdLabel10.AutoSize = true;
            this.IdLabel10.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel10.Location = new System.Drawing.Point(647, 172);
            this.IdLabel10.Name = "IdLabel10";
            this.IdLabel10.Size = new System.Drawing.Size(30, 16);
            this.IdLabel10.TabIndex = 55;
            this.IdLabel10.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Fax", true));
            this.txtFax.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFax.Location = new System.Drawing.Point(650, 193);
            this.txtFax.MaxLength = 20;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(128, 23);
            this.txtFax.TabIndex = 13;
            // 
            // txtPO
            // 
            this.txtPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "PONumber", true));
            this.txtPO.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPO.Location = new System.Drawing.Point(410, 347);
            this.txtPO.MaxLength = 200;
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(123, 23);
            this.txtPO.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Phone", true));
            this.txtPhone.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPhone.Location = new System.Drawing.Point(516, 193);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(128, 23);
            this.txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "eMail", true));
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail.Location = new System.Drawing.Point(203, 193);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Contact", true));
            this.txtContact.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContact.Location = new System.Drawing.Point(6, 193);
            this.txtContact.MaxLength = 30;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(191, 23);
            this.txtContact.TabIndex = 10;
            // 
            // IdLabel9
            // 
            this.IdLabel9.AutoSize = true;
            this.IdLabel9.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel9.Location = new System.Drawing.Point(203, 174);
            this.IdLabel9.Name = "IdLabel9";
            this.IdLabel9.Size = new System.Drawing.Size(41, 16);
            this.IdLabel9.TabIndex = 49;
            this.IdLabel9.Text = "Email";
            // 
            // lblContact1
            // 
            this.lblContact1.AutoSize = true;
            this.lblContact1.Font = new System.Drawing.Font("Arial", 10F);
            this.lblContact1.Location = new System.Drawing.Point(6, 174);
            this.lblContact1.Name = "lblContact1";
            this.lblContact1.Size = new System.Drawing.Size(56, 16);
            this.lblContact1.TabIndex = 48;
            this.lblContact1.Text = "Contact";
            // 
            // txtShipToZip
            // 
            this.txtShipToZip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipToZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToZip", true));
            this.txtShipToZip.Font = new System.Drawing.Font("Arial", 10F);
            this.txtShipToZip.Location = new System.Drawing.Point(633, 145);
            this.txtShipToZip.MaxLength = 10;
            this.txtShipToZip.Name = "txtShipToZip";
            this.txtShipToZip.Size = new System.Drawing.Size(81, 23);
            this.txtShipToZip.TabIndex = 47;
            // 
            // txtShipToSt
            // 
            this.txtShipToSt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipToSt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToState", true));
            this.txtShipToSt.Font = new System.Drawing.Font("Arial", 10F);
            this.txtShipToSt.Location = new System.Drawing.Point(598, 145);
            this.txtShipToSt.MaxLength = 2;
            this.txtShipToSt.Name = "txtShipToSt";
            this.txtShipToSt.Size = new System.Drawing.Size(35, 23);
            this.txtShipToSt.TabIndex = 46;
            // 
            // txtShipToCity
            // 
            this.txtShipToCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipToCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToCity", true));
            this.txtShipToCity.Font = new System.Drawing.Font("Arial", 10F);
            this.txtShipToCity.Location = new System.Drawing.Point(407, 145);
            this.txtShipToCity.MaxLength = 30;
            this.txtShipToCity.Name = "txtShipToCity";
            this.txtShipToCity.Size = new System.Drawing.Size(191, 23);
            this.txtShipToCity.TabIndex = 9;
            // 
            // txtBillZip
            // 
            this.txtBillZip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBillZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "BillToZip", true));
            this.txtBillZip.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBillZip.Location = new System.Drawing.Point(232, 145);
            this.txtBillZip.MaxLength = 10;
            this.txtBillZip.Name = "txtBillZip";
            this.txtBillZip.Size = new System.Drawing.Size(81, 23);
            this.txtBillZip.TabIndex = 5;
            // 
            // txtBillSt
            // 
            this.txtBillSt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBillSt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "BillToState", true));
            this.txtBillSt.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBillSt.Location = new System.Drawing.Point(197, 145);
            this.txtBillSt.MaxLength = 2;
            this.txtBillSt.Name = "txtBillSt";
            this.txtBillSt.Size = new System.Drawing.Size(35, 23);
            this.txtBillSt.TabIndex = 43;
            // 
            // txtBillCity
            // 
            this.txtBillCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBillCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "BillToCity", true));
            this.txtBillCity.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBillCity.Location = new System.Drawing.Point(6, 145);
            this.txtBillCity.MaxLength = 30;
            this.txtBillCity.Name = "txtBillCity";
            this.txtBillCity.Size = new System.Drawing.Size(191, 23);
            this.txtBillCity.TabIndex = 42;
            // 
            // lblShipTo
            // 
            this.lblShipTo.AutoSize = true;
            this.lblShipTo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblShipTo.Location = new System.Drawing.Point(407, 26);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(54, 16);
            this.lblShipTo.TabIndex = 41;
            this.lblShipTo.Text = "Ship To";
            // 
            // IdLabel6
            // 
            this.IdLabel6.AutoSize = true;
            this.IdLabel6.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel6.Location = new System.Drawing.Point(516, 172);
            this.IdLabel6.Name = "IdLabel6";
            this.IdLabel6.Size = new System.Drawing.Size(48, 16);
            this.IdLabel6.TabIndex = 40;
            this.IdLabel6.Text = "Phone";
            // 
            // IdLabel5
            // 
            this.IdLabel5.AutoSize = true;
            this.IdLabel5.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel5.Location = new System.Drawing.Point(6, 56);
            this.IdLabel5.Name = "IdLabel5";
            this.IdLabel5.Size = new System.Drawing.Size(44, 16);
            this.IdLabel5.TabIndex = 39;
            this.IdLabel5.Text = "Bill To";
            // 
            // IdLabel4
            // 
            this.IdLabel4.AutoSize = true;
            this.IdLabel4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel4.Location = new System.Drawing.Point(6, 12);
            this.IdLabel4.Name = "IdLabel4";
            this.IdLabel4.Size = new System.Drawing.Size(37, 16);
            this.IdLabel4.TabIndex = 38;
            this.IdLabel4.Text = "Date";
            // 
            // txtShipToAddr3
            // 
            this.txtShipToAddr3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipToAddr3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToAddress3", true));
            this.txtShipToAddr3.Font = new System.Drawing.Font("Arial", 10F);
            this.txtShipToAddr3.Location = new System.Drawing.Point(407, 122);
            this.txtShipToAddr3.MaxLength = 42;
            this.txtShipToAddr3.Name = "txtShipToAddr3";
            this.txtShipToAddr3.Size = new System.Drawing.Size(307, 23);
            this.txtShipToAddr3.TabIndex = 8;
            // 
            // txtShipToAddr2
            // 
            this.txtShipToAddr2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipToAddr2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToAddress2", true));
            this.txtShipToAddr2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtShipToAddr2.Location = new System.Drawing.Point(407, 99);
            this.txtShipToAddr2.MaxLength = 42;
            this.txtShipToAddr2.Name = "txtShipToAddr2";
            this.txtShipToAddr2.Size = new System.Drawing.Size(307, 23);
            this.txtShipToAddr2.TabIndex = 7;
            // 
            // txtShipToAddr1
            // 
            this.txtShipToAddr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipToAddr1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToAddress1", true));
            this.txtShipToAddr1.Font = new System.Drawing.Font("Arial", 10F);
            this.txtShipToAddr1.Location = new System.Drawing.Point(407, 76);
            this.txtShipToAddr1.MaxLength = 42;
            this.txtShipToAddr1.Name = "txtShipToAddr1";
            this.txtShipToAddr1.Size = new System.Drawing.Size(307, 23);
            this.txtShipToAddr1.TabIndex = 6;
            // 
            // txtShipTo
            // 
            this.txtShipTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtShipTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToCompany", true));
            this.txtShipTo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtShipTo.Location = new System.Drawing.Point(407, 45);
            this.txtShipTo.MaxLength = 50;
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(307, 23);
            this.txtShipTo.TabIndex = 1;
            // 
            // txtBillAddr3
            // 
            this.txtBillAddr3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBillAddr3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "BillToAddress3", true));
            this.txtBillAddr3.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBillAddr3.Location = new System.Drawing.Point(6, 122);
            this.txtBillAddr3.MaxLength = 42;
            this.txtBillAddr3.Name = "txtBillAddr3";
            this.txtBillAddr3.Size = new System.Drawing.Size(307, 23);
            this.txtBillAddr3.TabIndex = 4;
            // 
            // txtBillAddr2
            // 
            this.txtBillAddr2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBillAddr2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "BillToAddress2", true));
            this.txtBillAddr2.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBillAddr2.Location = new System.Drawing.Point(6, 99);
            this.txtBillAddr2.MaxLength = 42;
            this.txtBillAddr2.Name = "txtBillAddr2";
            this.txtBillAddr2.Size = new System.Drawing.Size(307, 23);
            this.txtBillAddr2.TabIndex = 3;
            // 
            // txtBillAddr1
            // 
            this.txtBillAddr1.BackColor = System.Drawing.SystemColors.Window;
            this.txtBillAddr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBillAddr1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "BillToAddress1", true));
            this.txtBillAddr1.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBillAddr1.Location = new System.Drawing.Point(6, 76);
            this.txtBillAddr1.MaxLength = 42;
            this.txtBillAddr1.Name = "txtBillAddr1";
            this.txtBillAddr1.Size = new System.Drawing.Size(307, 23);
            this.txtBillAddr1.TabIndex = 2;
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnCLose);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(923, 30);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(109, 69);
            this.IdGroupBox1.TabIndex = 25;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Brown;
            this.btnCLose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Location = new System.Drawing.Point(5, 15);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCLose.Size = new System.Drawing.Size(98, 42);
            this.btnCLose.TabIndex = 3;
            this.btnCLose.Text = "&Close";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numSalesPersonNo
            // 
            this.numSalesPersonNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "SalesPersonNo", true));
            this.numSalesPersonNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numSalesPersonNo.Location = new System.Drawing.Point(206, 424);
            this.numSalesPersonNo.Name = "numSalesPersonNo";
            this.numSalesPersonNo.Size = new System.Drawing.Size(100, 23);
            this.numSalesPersonNo.TabIndex = 76;
            this.numSalesPersonNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numSalesPersonNo2
            // 
            this.numSalesPersonNo2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "SalesPersonNo2", true));
            this.numSalesPersonNo2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numSalesPersonNo2.Location = new System.Drawing.Point(312, 424);
            this.numSalesPersonNo2.Name = "numSalesPersonNo2";
            this.numSalesPersonNo2.Size = new System.Drawing.Size(100, 23);
            this.numSalesPersonNo2.TabIndex = 75;
            this.numSalesPersonNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numShipMethodid
            // 
            this.numShipMethodid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipMethodid", true));
            this.numShipMethodid.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numShipMethodid.Location = new System.Drawing.Point(83, 424);
            this.numShipMethodid.Name = "numShipMethodid";
            this.numShipMethodid.Size = new System.Drawing.Size(100, 23);
            this.numShipMethodid.TabIndex = 74;
            this.numShipMethodid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.Color.Tan;
            this.tabDetail.Controls.Add(this.cmdGetTrack);
            this.tabDetail.Controls.Add(this.IdGroupBox2);
            this.tabDetail.Controls.Add(this.IdButton1);
            this.tabDetail.Controls.Add(this.IdGroupBox3);
            this.tabDetail.Controls.Add(this.gridDetail);
            this.tabDetail.Location = new System.Drawing.Point(4, 25);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(1035, 930);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "Detail";
            // 
            // cmdGetTrack
            // 
            this.cmdGetTrack.BackColor = System.Drawing.Color.Brown;
            this.cmdGetTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGetTrack.Font = new System.Drawing.Font("Arial", 10F);
            this.cmdGetTrack.ForeColor = System.Drawing.Color.White;
            this.cmdGetTrack.Location = new System.Drawing.Point(161, 8);
            this.cmdGetTrack.Name = "cmdGetTrack";
            this.cmdGetTrack.Size = new System.Drawing.Size(175, 37);
            this.cmdGetTrack.TabIndex = 27;
            this.cmdGetTrack.Text = "Copy Tracking Number";
            this.cmdGetTrack.UseVisualStyleBackColor = false;
            this.cmdGetTrack.Click += new System.EventHandler(this.cmdGetTrack_Click);
            // 
            // IdGroupBox2
            // 
            this.IdGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox2.Controls.Add(this.btnSoScreen);
            this.IdGroupBox2.Controls.Add(this.btnClose2);
            this.IdGroupBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox2.Location = new System.Drawing.Point(795, 8);
            this.IdGroupBox2.Name = "IdGroupBox2";
            this.IdGroupBox2.Size = new System.Drawing.Size(109, 120);
            this.IdGroupBox2.TabIndex = 26;
            this.IdGroupBox2.TabStop = false;
            // 
            // btnSoScreen
            // 
            this.btnSoScreen.BackColor = System.Drawing.Color.Brown;
            this.btnSoScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoScreen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoScreen.ForeColor = System.Drawing.Color.White;
            this.btnSoScreen.Location = new System.Drawing.Point(5, 17);
            this.btnSoScreen.Name = "btnSoScreen";
            this.btnSoScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSoScreen.Size = new System.Drawing.Size(98, 42);
            this.btnSoScreen.TabIndex = 4;
            this.btnSoScreen.Text = "&S/O To Screen";
            this.btnSoScreen.UseVisualStyleBackColor = false;
            this.btnSoScreen.Visible = false;
            this.btnSoScreen.Click += new System.EventHandler(this.btnSoScreen_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.Brown;
            this.btnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.Color.White;
            this.btnClose2.Location = new System.Drawing.Point(5, 65);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose2.Size = new System.Drawing.Size(98, 42);
            this.btnClose2.TabIndex = 3;
            this.btnClose2.Text = "&Close";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.IdButton2_Click);
            // 
            // IdButton1
            // 
            this.IdButton1.BackColor = System.Drawing.Color.Brown;
            this.IdButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdButton1.ForeColor = System.Drawing.Color.White;
            this.IdButton1.Location = new System.Drawing.Point(59, 8);
            this.IdButton1.Name = "IdButton1";
            this.IdButton1.Size = new System.Drawing.Size(61, 37);
            this.IdButton1.TabIndex = 3;
            this.IdButton1.Text = "Details";
            this.IdButton1.UseVisualStyleBackColor = false;
            this.IdButton1.Click += new System.EventHandler(this.IdButton1_Click);
            // 
            // IdGroupBox3
            // 
            this.IdGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdGroupBox3.Controls.Add(this.lblPartsCost);
            this.IdGroupBox3.Controls.Add(this.cbWarranty);
            this.IdGroupBox3.Controls.Add(this.lblWarranty);
            this.IdGroupBox3.Controls.Add(this.lblRush);
            this.IdGroupBox3.Controls.Add(this.gridDetailStatus);
            this.IdGroupBox3.Controls.Add(this.lblPriceSource);
            this.IdGroupBox3.Controls.Add(this.IdLabel22);
            this.IdGroupBox3.Controls.Add(this.numPrice);
            this.IdGroupBox3.Controls.Add(this.IdLabel21);
            this.IdGroupBox3.Controls.Add(this.IdLabel20);
            this.IdGroupBox3.Controls.Add(this.IdLabel19);
            this.IdGroupBox3.Controls.Add(this.IdLabel18);
            this.IdGroupBox3.Controls.Add(this.IdLabel17);
            this.IdGroupBox3.Controls.Add(this.txtTech);
            this.IdGroupBox3.Controls.Add(this.txtSerNo);
            this.IdGroupBox3.Controls.Add(this.txtRefNo);
            this.IdGroupBox3.Controls.Add(this.txtItem);
            this.IdGroupBox3.Controls.Add(this.txtManuf);
            this.IdGroupBox3.Controls.Add(this.numSNo);
            this.IdGroupBox3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox3.Location = new System.Drawing.Point(6, 308);
            this.IdGroupBox3.Name = "IdGroupBox3";
            this.IdGroupBox3.Size = new System.Drawing.Size(783, 331);
            this.IdGroupBox3.TabIndex = 2;
            this.IdGroupBox3.TabStop = false;
            // 
            // lblPartsCost
            // 
            this.lblPartsCost.AutoSize = true;
            this.lblPartsCost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPartsCost.Location = new System.Drawing.Point(583, 99);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(79, 16);
            this.lblPartsCost.TabIndex = 18;
            this.lblPartsCost.Text = "Parts Cost";
            // 
            // cbWarranty
            // 
            this.cbWarranty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbWarranty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWarranty.Font = new System.Drawing.Font("Arial", 10F);
            this.cbWarranty.FormattingEnabled = true;
            this.cbWarranty.Location = new System.Drawing.Point(675, 67);
            this.cbWarranty.Name = "cbWarranty";
            this.cbWarranty.Size = new System.Drawing.Size(92, 24);
            this.cbWarranty.TabIndex = 17;
            this.cbWarranty.Visible = false;
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblWarranty.Location = new System.Drawing.Point(583, 73);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(85, 16);
            this.lblWarranty.TabIndex = 16;
            this.lblWarranty.Text = "WARRANTY";
            this.lblWarranty.Visible = false;
            // 
            // lblRush
            // 
            this.lblRush.AutoSize = true;
            this.lblRush.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRush.Location = new System.Drawing.Point(697, 41);
            this.lblRush.Name = "lblRush";
            this.lblRush.Size = new System.Drawing.Size(46, 16);
            this.lblRush.TabIndex = 15;
            this.lblRush.Text = "RUSH";
            this.lblRush.Visible = false;
            // 
            // gridDetailStatus
            // 
            this.gridDetailStatus.AllowUserToAddRows = false;
            this.gridDetailStatus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.PowderBlue;
            this.gridDetailStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.gridDetailStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetailStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDetailStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetailStatus.ColumnHeadersVisible = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetailStatus.DefaultCellStyle = dataGridViewCellStyle21;
            this.gridDetailStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridDetailStatus.Location = new System.Drawing.Point(10, 118);
            this.gridDetailStatus.MultiSelect = false;
            this.gridDetailStatus.Name = "gridDetailStatus";
            this.gridDetailStatus.ReadOnly = true;
            this.gridDetailStatus.RowHeadersVisible = false;
            this.gridDetailStatus.Size = new System.Drawing.Size(757, 207);
            this.gridDetailStatus.TabIndex = 7;
            // 
            // lblPriceSource
            // 
            this.lblPriceSource.AutoSize = true;
            this.lblPriceSource.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPriceSource.Location = new System.Drawing.Point(171, 81);
            this.lblPriceSource.Name = "lblPriceSource";
            this.lblPriceSource.Size = new System.Drawing.Size(88, 16);
            this.lblPriceSource.TabIndex = 13;
            this.lblPriceSource.Text = "Price Source";
            this.lblPriceSource.Visible = false;
            // 
            // IdLabel22
            // 
            this.IdLabel22.AutoSize = true;
            this.IdLabel22.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel22.Location = new System.Drawing.Point(7, 78);
            this.IdLabel22.Name = "IdLabel22";
            this.IdLabel22.Size = new System.Drawing.Size(39, 16);
            this.IdLabel22.TabIndex = 12;
            this.IdLabel22.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numPrice.Location = new System.Drawing.Point(53, 78);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 23);
            this.numPrice.TabIndex = 6;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel21
            // 
            this.IdLabel21.AutoSize = true;
            this.IdLabel21.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel21.Location = new System.Drawing.Point(633, 15);
            this.IdLabel21.Name = "IdLabel21";
            this.IdLabel21.Size = new System.Drawing.Size(74, 16);
            this.IdLabel21.TabIndex = 10;
            this.IdLabel21.Text = "Technician";
            // 
            // IdLabel20
            // 
            this.IdLabel20.AutoSize = true;
            this.IdLabel20.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel20.Location = new System.Drawing.Point(501, 15);
            this.IdLabel20.Name = "IdLabel20";
            this.IdLabel20.Size = new System.Drawing.Size(55, 16);
            this.IdLabel20.TabIndex = 9;
            this.IdLabel20.Text = "Serial #";
            // 
            // IdLabel19
            // 
            this.IdLabel19.AutoSize = true;
            this.IdLabel19.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel19.Location = new System.Drawing.Point(395, 15);
            this.IdLabel19.Name = "IdLabel19";
            this.IdLabel19.Size = new System.Drawing.Size(85, 16);
            this.IdLabel19.TabIndex = 8;
            this.IdLabel19.Text = "Reference #";
            // 
            // IdLabel18
            // 
            this.IdLabel18.AutoSize = true;
            this.IdLabel18.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel18.Location = new System.Drawing.Point(244, 15);
            this.IdLabel18.Name = "IdLabel18";
            this.IdLabel18.Size = new System.Drawing.Size(33, 16);
            this.IdLabel18.TabIndex = 7;
            this.IdLabel18.Text = "Item";
            // 
            // IdLabel17
            // 
            this.IdLabel17.AutoSize = true;
            this.IdLabel17.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel17.Location = new System.Drawing.Point(96, 15);
            this.IdLabel17.Name = "IdLabel17";
            this.IdLabel17.Size = new System.Drawing.Size(91, 16);
            this.IdLabel17.TabIndex = 6;
            this.IdLabel17.Text = "Manufacturer";
            // 
            // txtTech
            // 
            this.txtTech.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTech.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTech.Location = new System.Drawing.Point(636, 38);
            this.txtTech.Name = "txtTech";
            this.txtTech.Size = new System.Drawing.Size(55, 23);
            this.txtTech.TabIndex = 5;
            // 
            // txtSerNo
            // 
            this.txtSerNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSerNo.Location = new System.Drawing.Point(504, 38);
            this.txtSerNo.Name = "txtSerNo";
            this.txtSerNo.Size = new System.Drawing.Size(126, 23);
            this.txtSerNo.TabIndex = 4;
            // 
            // txtRefNo
            // 
            this.txtRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRefNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRefNo.Location = new System.Drawing.Point(398, 38);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(100, 23);
            this.txtRefNo.TabIndex = 3;
            // 
            // txtItem
            // 
            this.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItem.Font = new System.Drawing.Font("Arial", 10F);
            this.txtItem.Location = new System.Drawing.Point(247, 38);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(145, 23);
            this.txtItem.TabIndex = 2;
            // 
            // txtManuf
            // 
            this.txtManuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtManuf.Font = new System.Drawing.Font("Arial", 10F);
            this.txtManuf.Location = new System.Drawing.Point(96, 38);
            this.txtManuf.Name = "txtManuf";
            this.txtManuf.Size = new System.Drawing.Size(145, 23);
            this.txtManuf.TabIndex = 1;
            // 
            // numSNo
            // 
            this.numSNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numSNo.Location = new System.Drawing.Point(7, 38);
            this.numSNo.Name = "numSNo";
            this.numSNo.Size = new System.Drawing.Size(83, 23);
            this.numSNo.TabIndex = 0;
            this.numSNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.PowderBlue;
            this.gridDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.gridDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetail.Location = new System.Drawing.Point(6, 59);
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.ReadOnly = true;
            this.gridDetail.Size = new System.Drawing.Size(783, 236);
            this.gridDetail.TabIndex = 1;
            this.gridDetail.SelectionChanged += new System.EventHandler(this.gridDetail_SelectionChanged);
            this.gridDetail.Sorted += new System.EventHandler(this.gridDetail_Sorted);
            this.gridDetail.DoubleClick += new System.EventHandler(this.gridDetail_DoubleClick);
            // 
            // SalesPersonComboBindingSource1
            // 
            this.SalesPersonComboBindingSource1.DataMember = "SalesPersonCombo";
            // 
            // SalesPersonComboBindingSource
            // 
            this.SalesPersonComboBindingSource.DataMember = "SalesPersonCombo";
            // 
            // numSONumber
            // 
            this.numSONumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "SalesOrderNo", true));
            this.numSONumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numSONumber.ForeColor = System.Drawing.Color.Red;
            this.numSONumber.Location = new System.Drawing.Point(119, 11);
            this.numSONumber.Name = "numSONumber";
            this.numSONumber.Size = new System.Drawing.Size(100, 23);
            this.numSONumber.TabIndex = 32;
            this.numSONumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // IdTextBox1
            // 
            this.IdTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.IdTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "ShipToCompany", true));
            this.IdTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox1.Location = new System.Drawing.Point(359, 40);
            this.IdTextBox1.MaxLength = 50;
            this.IdTextBox1.Name = "IdTextBox1";
            this.IdTextBox1.ReadOnly = true;
            this.IdTextBox1.Size = new System.Drawing.Size(272, 20);
            this.IdTextBox1.TabIndex = 74;
            // 
            // IdLabel8
            // 
            this.IdLabel8.AutoSize = true;
            this.IdLabel8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel8.Location = new System.Drawing.Point(768, 71);
            this.IdLabel8.Name = "IdLabel8";
            this.IdLabel8.Size = new System.Drawing.Size(25, 14);
            this.IdLabel8.TabIndex = 82;
            this.IdLabel8.Text = "Fax";
            // 
            // IdTextBox2
            // 
            this.IdTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Fax", true));
            this.IdTextBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox2.Location = new System.Drawing.Point(799, 68);
            this.IdTextBox2.MaxLength = 20;
            this.IdTextBox2.Name = "IdTextBox2";
            this.IdTextBox2.ReadOnly = true;
            this.IdTextBox2.Size = new System.Drawing.Size(83, 20);
            this.IdTextBox2.TabIndex = 78;
            // 
            // IdTextBox3
            // 
            this.IdTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Phone", true));
            this.IdTextBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox3.Location = new System.Drawing.Point(679, 68);
            this.IdTextBox3.MaxLength = 20;
            this.IdTextBox3.Name = "IdTextBox3";
            this.IdTextBox3.ReadOnly = true;
            this.IdTextBox3.Size = new System.Drawing.Size(83, 20);
            this.IdTextBox3.TabIndex = 77;
            // 
            // IdTextBox4
            // 
            this.IdTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "eMail", true));
            this.IdTextBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox4.Location = new System.Drawing.Point(359, 68);
            this.IdTextBox4.MaxLength = 50;
            this.IdTextBox4.Name = "IdTextBox4";
            this.IdTextBox4.ReadOnly = true;
            this.IdTextBox4.Size = new System.Drawing.Size(272, 20);
            this.IdTextBox4.TabIndex = 76;
            // 
            // IdTextBox5
            // 
            this.IdTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SalesOrdersBindingSource, "Contact", true));
            this.IdTextBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox5.Location = new System.Drawing.Point(177, 68);
            this.IdTextBox5.MaxLength = 30;
            this.IdTextBox5.Name = "IdTextBox5";
            this.IdTextBox5.ReadOnly = true;
            this.IdTextBox5.Size = new System.Drawing.Size(138, 20);
            this.IdTextBox5.TabIndex = 75;
            // 
            // IdLabel16
            // 
            this.IdLabel16.AutoSize = true;
            this.IdLabel16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel16.Location = new System.Drawing.Point(321, 71);
            this.IdLabel16.Name = "IdLabel16";
            this.IdLabel16.Size = new System.Drawing.Size(31, 14);
            this.IdLabel16.TabIndex = 81;
            this.IdLabel16.Text = "Email";
            // 
            // IdLabel24
            // 
            this.IdLabel24.AutoSize = true;
            this.IdLabel24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel24.Location = new System.Drawing.Point(127, 71);
            this.IdLabel24.Name = "IdLabel24";
            this.IdLabel24.Size = new System.Drawing.Size(44, 14);
            this.IdLabel24.TabIndex = 80;
            this.IdLabel24.Text = "Contact";
            // 
            // IdLabel25
            // 
            this.IdLabel25.AutoSize = true;
            this.IdLabel25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel25.Location = new System.Drawing.Point(637, 71);
            this.IdLabel25.Name = "IdLabel25";
            this.IdLabel25.Size = new System.Drawing.Size(37, 14);
            this.IdLabel25.TabIndex = 79;
            this.IdLabel25.Text = "Phone";
            // 
            // frmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.btnCLose;
            this.ClientSize = new System.Drawing.Size(925, 735);
            this.Controls.Add(this.IdLabel8);
            this.Controls.Add(this.IdTextBox2);
            this.Controls.Add(this.IdTextBox3);
            this.Controls.Add(this.IdTextBox4);
            this.Controls.Add(this.IdTextBox5);
            this.Controls.Add(this.IdLabel16);
            this.Controls.Add(this.IdLabel24);
            this.Controls.Add(this.IdLabel25);
            this.Controls.Add(this.IdTextBox1);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCreditHold);
            this.Controls.Add(this.lblCreditHold);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.IdTabControl1);
            this.Controls.Add(this.dtLastChangedDate);
            this.Controls.Add(this.numSONumber);
            this.KeyPreview = true;
            this.Name = "frmSalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SalesOrder";
            this.Text = "frmSalesOrder";
            this.Load += new System.EventHandler(this.frmSalesOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            this.IdTabControl1.ResumeLayout(false);
            this.tabHeader.ResumeLayout(false);
            this.tabHeader.PerformLayout();
            this.IdGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSalesPersonNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalesPersonNo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShipMethodid)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.IdGroupBox2.ResumeLayout(false);
            this.IdGroupBox3.ResumeLayout(false);
            this.IdGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSONumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle;
        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2;
        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3;
        private System.Windows.Forms.BindingSource SalesOrdersBindingSource;
        private System.Data.DataSet IRDataSet;

        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.DateTimePicker dtLastChangedDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCreditHold;  
        private System.Windows.Forms.Label lblCreditHold;
        private System.Windows.Forms.TextBox cbCustomer;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.TabControl IdTabControl1;
        private System.Windows.Forms.TabPage tabHeader;
        private System.Windows.Forms.CheckBox ckPickup;        
        private System.Windows.Forms.TextBox txtFax2;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label IdLabel7;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label IdLabel23;
        private System.Windows.Forms.Label lblContact2;
        private System.Windows.Forms.TextBox cbSalesPerson2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtContact2;
        private System.Windows.Forms.CheckBox ckPrintQuote;
        private System.Windows.Forms.RichTextBox txtQStamp;
        private System.Windows.Forms.Label lblQuoteStamp;
        private System.Windows.Forms.Label IdLabel15;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtSODate;
        private System.Windows.Forms.CheckBox ckPrintPS;
        private System.Windows.Forms.CheckBox ckPrintSO;
        private System.Windows.Forms.Label IdLabel14;
        private System.Windows.Forms.Label IdLabel13;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label IdLabel12;
        private System.Windows.Forms.TextBox cbSalesPerson;
        private System.Windows.Forms.TextBox cbShipVia;
        private System.Windows.Forms.Label IdLabel11;
        private System.Windows.Forms.Label IdLabel10;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label IdLabel9;
        private System.Windows.Forms.Label lblContact1;
        private System.Windows.Forms.TextBox txtShipToZip;
        private System.Windows.Forms.TextBox txtShipToSt;
        private System.Windows.Forms.TextBox txtShipToCity;
        private System.Windows.Forms.TextBox txtBillZip;
        private System.Windows.Forms.TextBox txtBillSt;
        private System.Windows.Forms.TextBox txtBillCity;
        private System.Windows.Forms.Label lblShipTo;
        private System.Windows.Forms.Label IdLabel6;
        private System.Windows.Forms.Label IdLabel5;
        private System.Windows.Forms.Label IdLabel4;
        private System.Windows.Forms.TextBox txtShipToAddr3;
        private System.Windows.Forms.TextBox txtShipToAddr2;
        private System.Windows.Forms.TextBox txtShipToAddr1;
        private System.Windows.Forms.TextBox txtShipTo;
        private System.Windows.Forms.TextBox txtBillAddr3;
        private System.Windows.Forms.TextBox txtBillAddr2;
        private System.Windows.Forms.TextBox txtBillAddr1;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.NumericUpDown numSalesPersonNo;
        private System.Windows.Forms.NumericUpDown numSalesPersonNo2;
        private System.Windows.Forms.NumericUpDown numShipMethodid;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.Button cmdGetTrack;
        private System.Windows.Forms.GroupBox IdGroupBox2;
        private System.Windows.Forms.Button btnSoScreen;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button IdButton1;
        private System.Windows.Forms.GroupBox IdGroupBox3;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.ComboBox cbWarranty;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblRush;
        private System.Windows.Forms.DataGridView gridDetailStatus;
        private System.Windows.Forms.Label lblPriceSource;
        private System.Windows.Forms.Label IdLabel22;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label IdLabel21;
        private System.Windows.Forms.Label IdLabel20;
        private System.Windows.Forms.Label IdLabel19;
        private System.Windows.Forms.Label IdLabel18;
        private System.Windows.Forms.Label IdLabel17;
        private System.Windows.Forms.TextBox txtTech;
        private System.Windows.Forms.TextBox txtSerNo;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtManuf;
        private System.Windows.Forms.NumericUpDown numSNo;
        private System.Windows.Forms.DataGridView gridDetail;
        private System.Windows.Forms.BindingSource SalesPersonComboBindingSource1;
        private System.Windows.Forms.BindingSource SalesPersonComboBindingSource;
        private System.Windows.Forms.NumericUpDown numSONumber;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.TextBox IdTextBox1;
        private System.Windows.Forms.Label IdLabel8;
        private System.Windows.Forms.TextBox IdTextBox2;
        private System.Windows.Forms.TextBox IdTextBox3;
        private System.Windows.Forms.TextBox IdTextBox4;
        private System.Windows.Forms.TextBox IdTextBox5;
        private System.Windows.Forms.Label IdLabel16;
        private System.Windows.Forms.Label IdLabel24;
        private System.Windows.Forms.Label IdLabel25;
        private System.Windows.Forms.Label IdLabel26;
        private System.Windows.Forms.TextBox txtBranchCode;




    }
}