using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace CRM
{
    partial class frmScheduleActivity
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
            this.CRMContactListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CRMTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CRMTaskColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IRDataSet = new System.Data.DataSet();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.IdGroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRecordManager = new System.Windows.Forms.TextBox();
            this.IdLabel6 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.cbAlarm = new System.Windows.Forms.ComboBox();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.IdLabel9 = new System.Windows.Forms.Label();
            this.IdTextBox1 = new System.Windows.Forms.TextBox();
            this.IdLabel8 = new System.Windows.Forms.Label();
            this.cbRegarding = new System.Windows.Forms.ComboBox();
            this.IdGroupBox3 = new System.Windows.Forms.GroupBox();
            this.cbContact = new System.Windows.Forms.ComboBox();
            this.IdGroupBox2 = new System.Windows.Forms.GroupBox();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblWeels = new System.Windows.Forms.Label();
            this.cbWeeks = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.IdTabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.btnAttach = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.IdLabel11 = new System.Windows.Forms.Label();
            this.IdRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.txtTaskCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CRMContactListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMTaskColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            this.IdGroupBox4.SuspendLayout();
            this.IdGroupBox3.SuspendLayout();
            this.IdGroupBox2.SuspendLayout();
            this.IdTabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "NewDataSet";
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Controls.Add(this.btnDelete);
            this.IdGroupBox1.Controls.Add(this.cmdSave);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(738, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 204);
            this.IdGroupBox1.TabIndex = 9;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.cmdSave.Text = "&OK";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(6, 70);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // IdGroupBox4
            // 
            this.IdGroupBox4.Controls.Add(this.txtRecordManager);
            this.IdGroupBox4.Controls.Add(this.IdLabel6);
            this.IdGroupBox4.Controls.Add(this.cbColor);
            this.IdGroupBox4.Controls.Add(this.lblColor);
            this.IdGroupBox4.Controls.Add(this.btnSchedule);
            this.IdGroupBox4.Controls.Add(this.cbAlarm);
            this.IdGroupBox4.Controls.Add(this.lblAlarm);
            this.IdGroupBox4.Controls.Add(this.cbPriority);
            this.IdGroupBox4.Controls.Add(this.IdLabel9);
            this.IdGroupBox4.Controls.Add(this.IdTextBox1);
            this.IdGroupBox4.Controls.Add(this.IdLabel8);
            this.IdGroupBox4.Controls.Add(this.cbRegarding);
            this.IdGroupBox4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox4.Location = new System.Drawing.Point(6, 200);
            this.IdGroupBox4.Name = "IdGroupBox4";
            this.IdGroupBox4.Size = new System.Drawing.Size(699, 226);
            this.IdGroupBox4.TabIndex = 2;
            this.IdGroupBox4.TabStop = false;
            this.IdGroupBox4.Text = "Regarding";
            // 
            // txtRecordManager
            // 
            this.txtRecordManager.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRecordManager.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "ManageUserID", true));
            this.txtRecordManager.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRecordManager.ForeColor = System.Drawing.Color.Black;
            this.txtRecordManager.Location = new System.Drawing.Point(246, 186);
            this.txtRecordManager.Name = "txtRecordManager";
            this.txtRecordManager.ReadOnly = true;
            this.txtRecordManager.Size = new System.Drawing.Size(232, 23);
            this.txtRecordManager.TabIndex = 14;
            // 
            // IdLabel6
            // 
            this.IdLabel6.AutoSize = true;
            this.IdLabel6.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel6.Location = new System.Drawing.Point(125, 190);
            this.IdLabel6.Name = "IdLabel6";
            this.IdLabel6.Size = new System.Drawing.Size(113, 16);
            this.IdLabel6.TabIndex = 13;
            this.IdLabel6.Text = "Record Manager";
            // 
            // cbColor
            // 
            this.cbColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbColor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CRMTasksBindingSource, "TaskColor", true));
            this.cbColor.DataSource = this.CRMTaskColorBindingSource;
            this.cbColor.DisplayMember = "Name";
            this.cbColor.Font = new System.Drawing.Font("Arial", 10F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(136, 144);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(180, 24);
            this.cbColor.TabIndex = 11;
            this.cbColor.ValueMember = "TaskColor";
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial", 10F);
            this.lblColor.Location = new System.Drawing.Point(133, 125);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 16);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.Brown;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(494, 186);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(186, 24);
            this.btnSchedule.TabIndex = 9;
            this.btnSchedule.Text = "Schedule For...";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // cbAlarm
            // 
            this.cbAlarm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbAlarm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAlarm.Font = new System.Drawing.Font("Arial", 10F);
            this.cbAlarm.FormattingEnabled = true;
            this.cbAlarm.Items.AddRange(new object[] {
            "NONE",
            "5 Minutes",
            "10 Minutes",
            "15 Minutes",
            "30 Minutes",
            "60 Minutes"});
            this.cbAlarm.Location = new System.Drawing.Point(322, 144);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(156, 24);
            this.cbAlarm.TabIndex = 8;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Arial", 10F);
            this.lblAlarm.Location = new System.Drawing.Point(319, 124);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(79, 16);
            this.lblAlarm.TabIndex = 7;
            this.lblAlarm.Text = "Ring Alarm:";
            // 
            // cbPriority
            // 
            this.cbPriority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbPriority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPriority.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "TaskPriority", true));
            this.cbPriority.Font = new System.Drawing.Font("Arial", 10F);
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "HIGH",
            "MEDIUM",
            "LOW"});
            this.cbPriority.Location = new System.Drawing.Point(23, 144);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(106, 24);
            this.cbPriority.TabIndex = 6;
            // 
            // IdLabel9
            // 
            this.IdLabel9.AutoSize = true;
            this.IdLabel9.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel9.Location = new System.Drawing.Point(26, 124);
            this.IdLabel9.Name = "IdLabel9";
            this.IdLabel9.Size = new System.Drawing.Size(51, 16);
            this.IdLabel9.TabIndex = 5;
            this.IdLabel9.Text = "Priority";
            // 
            // IdTextBox1
            // 
            this.IdTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "Location", true));
            this.IdTextBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTextBox1.ForeColor = System.Drawing.Color.Black;
            this.IdTextBox1.Location = new System.Drawing.Point(23, 98);
            this.IdTextBox1.Name = "IdTextBox1";
            this.IdTextBox1.Size = new System.Drawing.Size(657, 23);
            this.IdTextBox1.TabIndex = 4;
            // 
            // IdLabel8
            // 
            this.IdLabel8.AutoSize = true;
            this.IdLabel8.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel8.Location = new System.Drawing.Point(20, 70);
            this.IdLabel8.Name = "IdLabel8";
            this.IdLabel8.Size = new System.Drawing.Size(61, 16);
            this.IdLabel8.TabIndex = 3;
            this.IdLabel8.Text = "Location";
            // 
            // cbRegarding
            // 
            this.cbRegarding.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbRegarding.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRegarding.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "Regarding", true));
            this.cbRegarding.Font = new System.Drawing.Font("Arial", 10F);
            this.cbRegarding.FormattingEnabled = true;
            this.cbRegarding.Location = new System.Drawing.Point(23, 34);
            this.cbRegarding.Name = "cbRegarding";
            this.cbRegarding.Size = new System.Drawing.Size(657, 24);
            this.cbRegarding.TabIndex = 0;
            // 
            // IdGroupBox3
            // 
            this.IdGroupBox3.Controls.Add(this.cbContact);
            this.IdGroupBox3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox3.Location = new System.Drawing.Point(6, 110);
            this.IdGroupBox3.Name = "IdGroupBox3";
            this.IdGroupBox3.Size = new System.Drawing.Size(699, 84);
            this.IdGroupBox3.TabIndex = 1;
            this.IdGroupBox3.TabStop = false;
            this.IdGroupBox3.Text = "Schedule With";
            // 
            // cbContact
            // 
            this.cbContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContact.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CRMTasksBindingSource, "ContactID", true));
            this.cbContact.Font = new System.Drawing.Font("Arial", 10F);
            this.cbContact.FormattingEnabled = true;
            this.cbContact.Location = new System.Drawing.Point(23, 33);
            this.cbContact.Name = "cbContact";
            this.cbContact.Size = new System.Drawing.Size(509, 24);
            this.cbContact.TabIndex = 0;
            this.cbContact.Enter += new System.EventHandler(this.cbContact_Enter);
            // 
            // IdGroupBox2
            // 
            this.IdGroupBox2.Controls.Add(this.IdLabel3);
            this.IdGroupBox2.Controls.Add(this.dtStartTime);
            this.IdGroupBox2.Controls.Add(this.lblWeels);
            this.IdGroupBox2.Controls.Add(this.cbWeeks);
            this.IdGroupBox2.Controls.Add(this.lblStart);
            this.IdGroupBox2.Controls.Add(this.cbType);
            this.IdGroupBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox2.Location = new System.Drawing.Point(7, 6);
            this.IdGroupBox2.Name = "IdGroupBox2";
            this.IdGroupBox2.Size = new System.Drawing.Size(699, 98);
            this.IdGroupBox2.TabIndex = 0;
            this.IdGroupBox2.TabStop = false;
            this.IdGroupBox2.Text = "Activity Type";
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel3.Location = new System.Drawing.Point(20, 24);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(42, 16);
            this.IdLabel3.TabIndex = 25;
            this.IdLabel3.Text = "Type:";
            // 
            // dtStartTime
            // 
            this.dtStartTime.Font = new System.Drawing.Font("Arial", 10F);
            this.dtStartTime.Location = new System.Drawing.Point(331, 46);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(154, 23);
            this.dtStartTime.TabIndex = 23;
            // 
            // lblWeels
            // 
            this.lblWeels.AutoSize = true;
            this.lblWeels.Font = new System.Drawing.Font("Arial", 10F);
            this.lblWeels.Location = new System.Drawing.Point(201, 25);
            this.lblWeels.Name = "lblWeels";
            this.lblWeels.Size = new System.Drawing.Size(128, 16);
            this.lblWeels.TabIndex = 11;
            this.lblWeels.Text = "Weeks from Today:";
            this.lblWeels.Visible = false;
            // 
            // cbWeeks
            // 
            this.cbWeeks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbWeeks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWeeks.Font = new System.Drawing.Font("Arial", 10F);
            this.cbWeeks.FormattingEnabled = true;
            this.cbWeeks.Items.AddRange(new object[] {
            "1 WEEK",
            "2 WEEKS",
            "3 WEEKS",
            "4 WEEKS",
            "6 WEEKS"});
            this.cbWeeks.Location = new System.Drawing.Point(204, 45);
            this.cbWeeks.Name = "cbWeeks";
            this.cbWeeks.Size = new System.Drawing.Size(121, 24);
            this.cbWeeks.TabIndex = 10;
            this.cbWeeks.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStart.Location = new System.Drawing.Point(214, 24);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(109, 16);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Date\\Time:";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CRMTasksBindingSource, "TaskType", true));
            this.cbType.Font = new System.Drawing.Font("Arial", 10F);
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(23, 44);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(165, 24);
            this.cbType.TabIndex = 0;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // IdTabControl1
            // 
            this.IdTabControl1.Controls.Add(this.TabPage1);
            this.IdTabControl1.Controls.Add(this.TabPage2);
            this.IdTabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTabControl1.Location = new System.Drawing.Point(12, 24);
            this.IdTabControl1.Name = "IdTabControl1";
            this.IdTabControl1.SelectedIndex = 0;
            this.IdTabControl1.Size = new System.Drawing.Size(720, 461);
            this.IdTabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Tan;
            this.TabPage1.Controls.Add(this.IdGroupBox4);
            this.TabPage1.Controls.Add(this.IdGroupBox3);
            this.TabPage1.Controls.Add(this.IdGroupBox2);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(712, 432);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.Tan;
            this.TabPage2.Controls.Add(this.btnAttach);
            this.TabPage2.Controls.Add(this.txtFileName);
            this.TabPage2.Controls.Add(this.IdLabel11);
            this.TabPage2.Controls.Add(this.IdRichTextBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(712, 432);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Details";
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Brown;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(656, 333);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(32, 29);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "...";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFileName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFileName.ForeColor = System.Drawing.Color.Black;
            this.txtFileName.Location = new System.Drawing.Point(100, 336);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(539, 23);
            this.txtFileName.TabIndex = 2;
            // 
            // IdLabel11
            // 
            this.IdLabel11.AutoSize = true;
            this.IdLabel11.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel11.Location = new System.Drawing.Point(18, 342);
            this.IdLabel11.Name = "IdLabel11";
            this.IdLabel11.Size = new System.Drawing.Size(78, 16);
            this.IdLabel11.TabIndex = 1;
            this.IdLabel11.Text = "Attachment";
            // 
            // IdRichTextBox1
            // 
            this.IdRichTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "Details", true));
            this.IdRichTextBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdRichTextBox1.Location = new System.Drawing.Point(23, 33);
            this.IdRichTextBox1.Name = "IdRichTextBox1";
            this.IdRichTextBox1.Size = new System.Drawing.Size(664, 285);
            this.IdRichTextBox1.TabIndex = 0;
            this.IdRichTextBox1.Text = "";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompanyID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "CompanyID", true));
            this.txtCompanyID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCompanyID.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyID.Location = new System.Drawing.Point(354, 220);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(100, 23);
            this.txtCompanyID.TabIndex = 11;
            // 
            // txtContactID
            // 
            this.txtContactID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContactID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "ContactID", true));
            this.txtContactID.Font = new System.Drawing.Font("Arial", 10F);
            this.txtContactID.ForeColor = System.Drawing.Color.Black;
            this.txtContactID.Location = new System.Drawing.Point(354, 184);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(100, 23);
            this.txtContactID.TabIndex = 10;
            // 
            // txtTaskCode
            // 
            this.txtTaskCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTaskCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMTasksBindingSource, "TaskCode", true));
            this.txtTaskCode.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTaskCode.ForeColor = System.Drawing.Color.Black;
            this.txtTaskCode.Location = new System.Drawing.Point(376, 271);
            this.txtTaskCode.Name = "txtTaskCode";
            this.txtTaskCode.Size = new System.Drawing.Size(100, 23);
            this.txtTaskCode.TabIndex = 12;
            // 
            // frmScheduleActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(872, 497);
            this.ControlBox = false;
            this.Controls.Add(this.IdGroupBox1);
            this.Controls.Add(this.IdTabControl1);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.txtTaskCode);
            this.Name = "frmScheduleActivity";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "ScheduleTask";
            this.Text = "Schedule Task";
            this.Load += new System.EventHandler(this.frmScheduleActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CRMContactListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMTaskColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            this.IdGroupBox1.ResumeLayout(false);
            this.IdGroupBox4.ResumeLayout(false);
            this.IdGroupBox4.PerformLayout();
            this.IdGroupBox3.ResumeLayout(false);
            this.IdGroupBox2.ResumeLayout(false);
            this.IdGroupBox2.PerformLayout();
            this.IdTabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource CRMContactListBindingSource;
        private System.Windows.Forms.BindingSource CustComboBindingSource;
        private System.Windows.Forms.BindingSource CRMTasksBindingSource;
        private System.Windows.Forms.BindingSource CRMTaskColorBindingSource;
        private System.Data.DataSet IRDataSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.GroupBox IdGroupBox4;
        private System.Windows.Forms.GroupBox IdGroupBox3;
        private System.Windows.Forms.GroupBox IdGroupBox2;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbAlarm;
        private System.Windows.Forms.ComboBox cbRegarding;
        private System.Windows.Forms.ComboBox cbWeeks;
        private System.Windows.Forms.ComboBox cbContact;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.TextBox txtRecordManager;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.TextBox txtTaskCode;
        private System.Windows.Forms.TextBox IdTextBox1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label IdLabel6;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label IdLabel9;
        private System.Windows.Forms.Label IdLabel8;
        private System.Windows.Forms.Label lblWeels;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label IdLabel11;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.RichTextBox IdRichTextBox1;


        private System.Windows.Forms.TabControl IdTabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
    }
}