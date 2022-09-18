using System.ComponentModel;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CRM
{
    partial class frmMain
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintCurrentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JustForJeffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecialStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetVersionNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmailContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaintenanceFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LookupFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportsProspectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDownsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateLocalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNoOnAreas = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesTotalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TodaysActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenRMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PickupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductivityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.TelemarketerNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TelemarketerActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.HorseRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVerticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyMikeOfCustomerIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FranciesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MikesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ToDoPopup = new System.Windows.Forms.Timer(this.components);
            this.IdPanel1 = new System.Windows.Forms.Panel();
            this.btnMap = new System.Windows.Forms.Button();
            this.gbLegend = new System.Windows.Forms.GroupBox();
            this.IdLabel8 = new System.Windows.Forms.Label();
            this.IdLabel7 = new System.Windows.Forms.Label();
            this.IdLabel5 = new System.Windows.Forms.Label();
            this.IdLabel4 = new System.Windows.Forms.Label();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdLabel6 = new System.Windows.Forms.Label();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.cbCalendar = new System.Windows.Forms.ComboBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.ckAllTasks = new System.Windows.Forms.CheckBox();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.ckHideInactive = new System.Windows.Forms.CheckBox();
            this.cbLookupData = new System.Windows.Forms.ComboBox();
            this.ckLookupAll = new System.Windows.Forms.CheckBox();
            this.ckSecondary = new System.Windows.Forms.CheckBox();
            this.ckShowAllContacts = new System.Windows.Forms.CheckBox();
            this.btnAdvFind = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbLookup = new System.Windows.Forms.ComboBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.lblLookup = new System.Windows.Forms.Label();
            this.ckPartial = new System.Windows.Forms.CheckBox();
            this.EnhancedManageUserComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManageUserComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.IdPanel1.SuspendLayout();
            this.gbLegend.SuspendLayout();
            this.IdGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnhancedManageUserComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserComboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(197, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Tan;
            this.MenuStrip1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.ReportsToolStripMenuItem,
            this.WindowToolStripMenuItem,
            this.BackToolStripMenuItem,
            this.ForewardToolStripMenuItem,
            this.LastLookupToolStripMenuItem,
            this.RefreshCompanyToolStripMenuItem,
            this.DeleteContactToolStripMenuItem,
            this.CustomerIssuesToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.MdiWindowListItem = this.WindowToolStripMenuItem;
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyPreferencesToolStripMenuItem,
            this.PrintCurrentFormToolStripMenuItem,
            this.ChangePasswordToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.ExitToolStripMenuItem,
            this.JustForJeffToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // MyPreferencesToolStripMenuItem
            // 
            this.MyPreferencesToolStripMenuItem.Name = "MyPreferencesToolStripMenuItem";
            this.MyPreferencesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.MyPreferencesToolStripMenuItem.Text = "My Preferences";
            this.MyPreferencesToolStripMenuItem.Click += new System.EventHandler(this.MyPreferencesToolStripMenuItem_Click);
            // 
            // PrintCurrentFormToolStripMenuItem
            // 
            this.PrintCurrentFormToolStripMenuItem.Name = "PrintCurrentFormToolStripMenuItem";
            this.PrintCurrentFormToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.PrintCurrentFormToolStripMenuItem.Text = "Print Current Form";
            this.PrintCurrentFormToolStripMenuItem.Visible = false;
            this.PrintCurrentFormToolStripMenuItem.Click += new System.EventHandler(this.PrintCurrentFormToolStripMenuItem_Click);
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ChangePasswordToolStripMenuItem.Text = "Change Password";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // JustForJeffToolStripMenuItem
            // 
            this.JustForJeffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpecialStuffToolStripMenuItem,
            this.SetVersionNumberToolStripMenuItem});
            this.JustForJeffToolStripMenuItem.Name = "JustForJeffToolStripMenuItem";
            this.JustForJeffToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.JustForJeffToolStripMenuItem.Text = "Just for Jeff";
            // 
            // SpecialStuffToolStripMenuItem
            // 
            this.SpecialStuffToolStripMenuItem.Name = "SpecialStuffToolStripMenuItem";
            this.SpecialStuffToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.SpecialStuffToolStripMenuItem.Text = "Special Stuff";
            this.SpecialStuffToolStripMenuItem.Click += new System.EventHandler(this.SpecialStuffToolStripMenuItem_Click);
            // 
            // SetVersionNumberToolStripMenuItem
            // 
            this.SetVersionNumberToolStripMenuItem.Name = "SetVersionNumberToolStripMenuItem";
            this.SetVersionNumberToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.SetVersionNumberToolStripMenuItem.Text = "Set Version Number";
            this.SetVersionNumberToolStripMenuItem.Click += new System.EventHandler(this.SetVersionNumberToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmailContentToolStripMenuItem,
            this.UsersToolStripMenuItem,
            this.MaintenanceFormsToolStripMenuItem,
            this.UpdateLocalDataToolStripMenuItem,
            this.mnuNoOnAreas});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // EmailContentToolStripMenuItem
            // 
            this.EmailContentToolStripMenuItem.Name = "EmailContentToolStripMenuItem";
            this.EmailContentToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.EmailContentToolStripMenuItem.Text = "Email Templates";
            this.EmailContentToolStripMenuItem.Click += new System.EventHandler(this.EmailContentToolStripMenuItem_Click);
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersToolStripMenuItem1,
            this.UserGroupsToolStripMenuItem,
            this.UserLogToolStripMenuItem});
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.UsersToolStripMenuItem.Text = "Users";
            // 
            // UsersToolStripMenuItem1
            // 
            this.UsersToolStripMenuItem1.Name = "UsersToolStripMenuItem1";
            this.UsersToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.UsersToolStripMenuItem1.Text = "Users";
            this.UsersToolStripMenuItem1.Click += new System.EventHandler(this.UsersToolStripMenuItem1_Click);
            // 
            // UserGroupsToolStripMenuItem
            // 
            this.UserGroupsToolStripMenuItem.Name = "UserGroupsToolStripMenuItem";
            this.UserGroupsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.UserGroupsToolStripMenuItem.Text = "User Groups";
            this.UserGroupsToolStripMenuItem.Click += new System.EventHandler(this.UserGroupsToolStripMenuItem_Click);
            // 
            // UserLogToolStripMenuItem
            // 
            this.UserLogToolStripMenuItem.Name = "UserLogToolStripMenuItem";
            this.UserLogToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.UserLogToolStripMenuItem.Text = "User Log";
            this.UserLogToolStripMenuItem.Click += new System.EventHandler(this.UserLogToolStripMenuItem_Click);
            // 
            // MaintenanceFormsToolStripMenuItem
            // 
            this.MaintenanceFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoteTypeToolStripMenuItem,
            this.TaskTypeToolStripMenuItem,
            this.LookupFieldsToolStripMenuItem,
            this.ImportsProspectsToolStripMenuItem,
            this.DropDownsToolStripMenuItem,
            this.ApplicationControlToolStripMenuItem,
            this.DataLoadToolStripMenuItem});
            this.MaintenanceFormsToolStripMenuItem.Name = "MaintenanceFormsToolStripMenuItem";
            this.MaintenanceFormsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.MaintenanceFormsToolStripMenuItem.Text = "Maintenance Forms";
            // 
            // NoteTypeToolStripMenuItem
            // 
            this.NoteTypeToolStripMenuItem.Name = "NoteTypeToolStripMenuItem";
            this.NoteTypeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.NoteTypeToolStripMenuItem.Text = "Note Type";
            this.NoteTypeToolStripMenuItem.Visible = false;
            this.NoteTypeToolStripMenuItem.Click += new System.EventHandler(this.NoteTypeToolStripMenuItem_Click);
            // 
            // TaskTypeToolStripMenuItem
            // 
            this.TaskTypeToolStripMenuItem.Name = "TaskTypeToolStripMenuItem";
            this.TaskTypeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.TaskTypeToolStripMenuItem.Text = "Task Type";
            this.TaskTypeToolStripMenuItem.Visible = false;
            this.TaskTypeToolStripMenuItem.Click += new System.EventHandler(this.TaskTypeToolStripMenuItem_Click);
            // 
            // LookupFieldsToolStripMenuItem
            // 
            this.LookupFieldsToolStripMenuItem.Name = "LookupFieldsToolStripMenuItem";
            this.LookupFieldsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.LookupFieldsToolStripMenuItem.Text = "Lookup Fields";
            this.LookupFieldsToolStripMenuItem.Visible = false;
            this.LookupFieldsToolStripMenuItem.Click += new System.EventHandler(this.LookupFieldsToolStripMenuItem_Click);
            // 
            // ImportsProspectsToolStripMenuItem
            // 
            this.ImportsProspectsToolStripMenuItem.Name = "ImportsProspectsToolStripMenuItem";
            this.ImportsProspectsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ImportsProspectsToolStripMenuItem.Text = "Import Prospects";
            this.ImportsProspectsToolStripMenuItem.Click += new System.EventHandler(this.ImportsProspectsToolStripMenuItem_Click);
            // 
            // DropDownsToolStripMenuItem
            // 
            this.DropDownsToolStripMenuItem.Name = "DropDownsToolStripMenuItem";
            this.DropDownsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.DropDownsToolStripMenuItem.Text = "Drop Downs";
            this.DropDownsToolStripMenuItem.Click += new System.EventHandler(this.DropDownsToolStripMenuItem_Click);
            // 
            // ApplicationControlToolStripMenuItem
            // 
            this.ApplicationControlToolStripMenuItem.Name = "ApplicationControlToolStripMenuItem";
            this.ApplicationControlToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ApplicationControlToolStripMenuItem.Text = "Application Control";
            this.ApplicationControlToolStripMenuItem.Click += new System.EventHandler(this.ApplicationControlToolStripMenuItem_Click);
            // 
            // DataLoadToolStripMenuItem
            // 
            this.DataLoadToolStripMenuItem.Name = "DataLoadToolStripMenuItem";
            this.DataLoadToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.DataLoadToolStripMenuItem.Text = "Data Load";
            this.DataLoadToolStripMenuItem.Visible = false;
            this.DataLoadToolStripMenuItem.Click += new System.EventHandler(this.DataLoadToolStripMenuItem_Click);
            // 
            // UpdateLocalDataToolStripMenuItem
            // 
            this.UpdateLocalDataToolStripMenuItem.Name = "UpdateLocalDataToolStripMenuItem";
            this.UpdateLocalDataToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.UpdateLocalDataToolStripMenuItem.Text = "Update Local Data";
            this.UpdateLocalDataToolStripMenuItem.Click += new System.EventHandler(this.UpdateLocalDataToolStripMenuItem_Click);
            // 
            // mnuNoOnAreas
            // 
            this.mnuNoOnAreas.CheckOnClick = true;
            this.mnuNoOnAreas.Name = "mnuNoOnAreas";
            this.mnuNoOnAreas.Size = new System.Drawing.Size(189, 22);
            this.mnuNoOnAreas.Text = "No % on Areas";
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalesTotalsToolStripMenuItem,
            this.CallReportToolStripMenuItem,
            this.TodaysActivitiesToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.OpenRMAToolStripMenuItem,
            this.OpenQuotesToolStripMenuItem,
            this.PickupsToolStripMenuItem,
            this.ProductivityReportToolStripMenuItem,
            this.ToolStripMenuItem5,
            this.TelemarketerNewCustomerToolStripMenuItem,
            this.TelemarketerActivityToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.MapsToolStripMenuItem,
            this.ToolStripMenuItem4,
            this.HorseRaceToolStripMenuItem});
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ReportsToolStripMenuItem.Text = "Reports";
            this.ReportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItem_Click);
            // 
            // SalesTotalsToolStripMenuItem
            // 
            this.SalesTotalsToolStripMenuItem.Name = "SalesTotalsToolStripMenuItem";
            this.SalesTotalsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.SalesTotalsToolStripMenuItem.Text = "Sales Totals";
            this.SalesTotalsToolStripMenuItem.Click += new System.EventHandler(this.SalesTotalsToolStripMenuItem_Click);
            // 
            // CallReportToolStripMenuItem
            // 
            this.CallReportToolStripMenuItem.Name = "CallReportToolStripMenuItem";
            this.CallReportToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.CallReportToolStripMenuItem.Text = "Call Report";
            this.CallReportToolStripMenuItem.Click += new System.EventHandler(this.CallReportToolStripMenuItem_Click);
            // 
            // TodaysActivitiesToolStripMenuItem
            // 
            this.TodaysActivitiesToolStripMenuItem.Name = "TodaysActivitiesToolStripMenuItem";
            this.TodaysActivitiesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.TodaysActivitiesToolStripMenuItem.Text = "Todays Activities";
            this.TodaysActivitiesToolStripMenuItem.Click += new System.EventHandler(this.TodaysActivitiesToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(234, 6);
            // 
            // OpenRMAToolStripMenuItem
            // 
            this.OpenRMAToolStripMenuItem.Name = "OpenRMAToolStripMenuItem";
            this.OpenRMAToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.OpenRMAToolStripMenuItem.Text = "Open RMA";
            this.OpenRMAToolStripMenuItem.Click += new System.EventHandler(this.OpenRMAToolStripMenuItem_Click);
            // 
            // OpenQuotesToolStripMenuItem
            // 
            this.OpenQuotesToolStripMenuItem.Name = "OpenQuotesToolStripMenuItem";
            this.OpenQuotesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.OpenQuotesToolStripMenuItem.Text = "Open Quotes";
            this.OpenQuotesToolStripMenuItem.Click += new System.EventHandler(this.OpenQuotesToolStripMenuItem_Click);
            // 
            // PickupsToolStripMenuItem
            // 
            this.PickupsToolStripMenuItem.Name = "PickupsToolStripMenuItem";
            this.PickupsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.PickupsToolStripMenuItem.Text = "Pickups";
            this.PickupsToolStripMenuItem.Click += new System.EventHandler(this.PickupsToolStripMenuItem_Click);
            // 
            // ProductivityReportToolStripMenuItem
            // 
            this.ProductivityReportToolStripMenuItem.Name = "ProductivityReportToolStripMenuItem";
            this.ProductivityReportToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.ProductivityReportToolStripMenuItem.Text = "Productivity Report";
            this.ProductivityReportToolStripMenuItem.Click += new System.EventHandler(this.ProductivityReportToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(234, 6);
            // 
            // TelemarketerNewCustomerToolStripMenuItem
            // 
            this.TelemarketerNewCustomerToolStripMenuItem.Name = "TelemarketerNewCustomerToolStripMenuItem";
            this.TelemarketerNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.TelemarketerNewCustomerToolStripMenuItem.Text = "Telemarketer New Customer";
            this.TelemarketerNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.TelemarketerNewCustomerToolStripMenuItem_Click);
            // 
            // TelemarketerActivityToolStripMenuItem
            // 
            this.TelemarketerActivityToolStripMenuItem.Name = "TelemarketerActivityToolStripMenuItem";
            this.TelemarketerActivityToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.TelemarketerActivityToolStripMenuItem.Text = "Telemarketer Activity";
            this.TelemarketerActivityToolStripMenuItem.Click += new System.EventHandler(this.TelemarketerActivityToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(234, 6);
            // 
            // MapsToolStripMenuItem
            // 
            this.MapsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalesRouteToolStripMenuItem,
            this.CurrentCompanyToolStripMenuItem});
            this.MapsToolStripMenuItem.Name = "MapsToolStripMenuItem";
            this.MapsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.MapsToolStripMenuItem.Text = "Maps";
            // 
            // SalesRouteToolStripMenuItem
            // 
            this.SalesRouteToolStripMenuItem.Name = "SalesRouteToolStripMenuItem";
            this.SalesRouteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.SalesRouteToolStripMenuItem.Text = "Sales Route";
            this.SalesRouteToolStripMenuItem.Click += new System.EventHandler(this.SalesRouteToolStripMenuItem_Click);
            // 
            // CurrentCompanyToolStripMenuItem
            // 
            this.CurrentCompanyToolStripMenuItem.Name = "CurrentCompanyToolStripMenuItem";
            this.CurrentCompanyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.CurrentCompanyToolStripMenuItem.Text = "Current Company";
            this.CurrentCompanyToolStripMenuItem.Click += new System.EventHandler(this.CurrentCompanyToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(234, 6);
            // 
            // HorseRaceToolStripMenuItem
            // 
            this.HorseRaceToolStripMenuItem.Name = "HorseRaceToolStripMenuItem";
            this.HorseRaceToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.HorseRaceToolStripMenuItem.Text = "Horse Race";
            this.HorseRaceToolStripMenuItem.Click += new System.EventHandler(this.HorseRaceToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeToolStripMenuItem,
            this.TileVerticleToolStripMenuItem,
            this.TileHorizontalToolStripMenuItem});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.WindowToolStripMenuItem.Text = "Window";
            // 
            // CascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.CascadeToolStripMenuItem.Text = "Cascade";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // TileVerticleToolStripMenuItem
            // 
            this.TileVerticleToolStripMenuItem.Name = "TileVerticleToolStripMenuItem";
            this.TileVerticleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.TileVerticleToolStripMenuItem.Text = "Tile Verticle";
            this.TileVerticleToolStripMenuItem.Click += new System.EventHandler(this.TileVerticleToolStripMenuItem_Click);
            // 
            // TileHorizontalToolStripMenuItem
            // 
            this.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem";
            this.TileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.TileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.BackToolStripMenuItem.Text = "Back";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // ForewardToolStripMenuItem
            // 
            this.ForewardToolStripMenuItem.Name = "ForewardToolStripMenuItem";
            this.ForewardToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ForewardToolStripMenuItem.Text = "Forward";
            this.ForewardToolStripMenuItem.Click += new System.EventHandler(this.ForewardToolStripMenuItem_Click);
            // 
            // LastLookupToolStripMenuItem
            // 
            this.LastLookupToolStripMenuItem.Name = "LastLookupToolStripMenuItem";
            this.LastLookupToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.LastLookupToolStripMenuItem.Text = "Last Lookup";
            this.LastLookupToolStripMenuItem.Click += new System.EventHandler(this.LastLookupToolStripMenuItem_Click);
            // 
            // RefreshCompanyToolStripMenuItem
            // 
            this.RefreshCompanyToolStripMenuItem.Name = "RefreshCompanyToolStripMenuItem";
            this.RefreshCompanyToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.RefreshCompanyToolStripMenuItem.Text = "Refresh Company";
            this.RefreshCompanyToolStripMenuItem.Click += new System.EventHandler(this.RefreshCompanyToolStripMenuItem_Click);
            // 
            // DeleteContactToolStripMenuItem
            // 
            this.DeleteContactToolStripMenuItem.Name = "DeleteContactToolStripMenuItem";
            this.DeleteContactToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.DeleteContactToolStripMenuItem.Text = "Delete Contact";
            this.DeleteContactToolStripMenuItem.Click += new System.EventHandler(this.DeleteContactToolStripMenuItem_Click);
            // 
            // CustomerIssuesToolStripMenuItem
            // 
            this.CustomerIssuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem,
            this.NotifyMikeOfCustomerIssueToolStripMenuItem,
            this.FranciesListToolStripMenuItem,
            this.MikesListToolStripMenuItem});
            this.CustomerIssuesToolStripMenuItem.Name = "CustomerIssuesToolStripMenuItem";
            this.CustomerIssuesToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.CustomerIssuesToolStripMenuItem.Text = "Customer Issues";
            // 
            // NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem
            // 
            this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Name = "NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem";
            this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Text = "Send this prospect to Francie";
            this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Click += new System.EventHandler(this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem_Click);
            // 
            // NotifyMikeOfCustomerIssueToolStripMenuItem
            // 
            this.NotifyMikeOfCustomerIssueToolStripMenuItem.Name = "NotifyMikeOfCustomerIssueToolStripMenuItem";
            this.NotifyMikeOfCustomerIssueToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.NotifyMikeOfCustomerIssueToolStripMenuItem.Text = "Notify Mike of Customer Issue";
            this.NotifyMikeOfCustomerIssueToolStripMenuItem.Click += new System.EventHandler(this.NotifyMikeOfCustomerIssueToolStripMenuItem_Click);
            // 
            // FranciesListToolStripMenuItem
            // 
            this.FranciesListToolStripMenuItem.Name = "FranciesListToolStripMenuItem";
            this.FranciesListToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.FranciesListToolStripMenuItem.Text = "Francie\'s List";
            this.FranciesListToolStripMenuItem.Click += new System.EventHandler(this.FranciesListToolStripMenuItem_Click);
            // 
            // MikesListToolStripMenuItem
            // 
            this.MikesListToolStripMenuItem.Name = "MikesListToolStripMenuItem";
            this.MikesListToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.MikesListToolStripMenuItem.Text = "Mike\'s List";
            this.MikesListToolStripMenuItem.Click += new System.EventHandler(this.MikesListToolStripMenuItem_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.Tan;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRecordCount});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 727);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1112, 22);
            this.StatusStrip1.TabIndex = 1;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(0, 17);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 300000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 1000;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Timer3
            // 
            this.Timer3.Interval = 30000;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // ToDoPopup
            // 
            this.ToDoPopup.Interval = 60000;
            this.ToDoPopup.Tick += new System.EventHandler(this.ToDo_Tick);
            // 
            // IdPanel1
            // 
            this.IdPanel1.Controls.Add(this.btnMap);
            this.IdPanel1.Controls.Add(this.gbLegend);
            this.IdPanel1.Controls.Add(this.lblCalendar);
            this.IdPanel1.Controls.Add(this.cbCalendar);
            this.IdPanel1.Controls.Add(this.lblTasks);
            this.IdPanel1.Controls.Add(this.cbTasks);
            this.IdPanel1.Controls.Add(this.ckAllTasks);
            this.IdPanel1.Controls.Add(this.btnCalendar);
            this.IdPanel1.Controls.Add(this.btnTasks);
            this.IdPanel1.Controls.Add(this.btnGroups);
            this.IdPanel1.Controls.Add(this.btnSearch);
            this.IdPanel1.Controls.Add(this.btnContacts);
            this.IdPanel1.Controls.Add(this.IdGroupBox1);
            this.IdPanel1.Controls.Add(this.pictureBoxLogo);
            this.IdPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.IdPanel1.Location = new System.Drawing.Point(0, 24);
            this.IdPanel1.Name = "IdPanel1";
            this.IdPanel1.Size = new System.Drawing.Size(200, 703);
            this.IdPanel1.TabIndex = 0;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Brown;
            this.btnMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMap.Enabled = false;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.Color.White;
            this.btnMap.Location = new System.Drawing.Point(0, 600);
            this.btnMap.Name = "btnMap";
            this.btnMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMap.Size = new System.Drawing.Size(200, 36);
            this.btnMap.TabIndex = 51;
            this.btnMap.Text = "&Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.IdButton1_Click);
            // 
            // gbLegend
            // 
            this.gbLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLegend.Controls.Add(this.IdLabel8);
            this.gbLegend.Controls.Add(this.IdLabel7);
            this.gbLegend.Controls.Add(this.IdLabel5);
            this.gbLegend.Controls.Add(this.IdLabel4);
            this.gbLegend.Controls.Add(this.IdLabel3);
            this.gbLegend.Controls.Add(this.IdLabel2);
            this.gbLegend.Controls.Add(this.IdLabel6);
            this.gbLegend.Font = new System.Drawing.Font("Arial", 10F);
            this.gbLegend.Location = new System.Drawing.Point(16, 714);
            this.gbLegend.Name = "gbLegend";
            this.gbLegend.Size = new System.Drawing.Size(152, 151);
            this.gbLegend.TabIndex = 50;
            this.gbLegend.TabStop = false;
            this.gbLegend.Tag = "";
            this.gbLegend.Text = "Legend";
            this.gbLegend.Visible = false;
            // 
            // IdLabel8
            // 
            this.IdLabel8.AutoSize = true;
            this.IdLabel8.BackColor = System.Drawing.Color.White;
            this.IdLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IdLabel8.Location = new System.Drawing.Point(21, 133);
            this.IdLabel8.Name = "IdLabel8";
            this.IdLabel8.Size = new System.Drawing.Size(108, 13);
            this.IdLabel8.TabIndex = 6;
            this.IdLabel8.Text = "WHITE Un-approved";
            // 
            // IdLabel7
            // 
            this.IdLabel7.AutoSize = true;
            this.IdLabel7.BackColor = System.Drawing.Color.Orange;
            this.IdLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IdLabel7.Location = new System.Drawing.Point(21, 114);
            this.IdLabel7.Name = "IdLabel7";
            this.IdLabel7.Size = new System.Drawing.Size(101, 13);
            this.IdLabel7.TabIndex = 5;
            this.IdLabel7.Text = "ORANGE Test Only";
            // 
            // IdLabel5
            // 
            this.IdLabel5.AutoSize = true;
            this.IdLabel5.BackColor = System.Drawing.Color.Yellow;
            this.IdLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IdLabel5.Location = new System.Drawing.Point(21, 95);
            this.IdLabel5.Name = "IdLabel5";
            this.IdLabel5.Size = new System.Drawing.Size(104, 13);
            this.IdLabel5.TabIndex = 4;
            this.IdLabel5.Text = "YELLOW Outsource";
            // 
            // IdLabel4
            // 
            this.IdLabel4.AutoSize = true;
            this.IdLabel4.BackColor = System.Drawing.Color.Green;
            this.IdLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IdLabel4.ForeColor = System.Drawing.Color.White;
            this.IdLabel4.Location = new System.Drawing.Point(21, 76);
            this.IdLabel4.Name = "IdLabel4";
            this.IdLabel4.Size = new System.Drawing.Size(94, 13);
            this.IdLabel4.TabIndex = 3;
            this.IdLabel4.Text = "GREEN Approved";
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.BackColor = System.Drawing.Color.Magenta;
            this.IdLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IdLabel3.ForeColor = System.Drawing.Color.White;
            this.IdLabel3.Location = new System.Drawing.Point(21, 57);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(106, 13);
            this.IdLabel3.TabIndex = 2;
            this.IdLabel3.Text = "MAGENTA Warranty";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.BackColor = System.Drawing.Color.Cyan;
            this.IdLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IdLabel2.ForeColor = System.Drawing.Color.Black;
            this.IdLabel2.Location = new System.Drawing.Point(21, 38);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(78, 13);
            this.IdLabel2.TabIndex = 1;
            this.IdLabel2.Text = "CYAN Shipped";
            // 
            // IdLabel6
            // 
            this.IdLabel6.AutoSize = true;
            this.IdLabel6.BackColor = System.Drawing.Color.Red;
            this.IdLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IdLabel6.ForeColor = System.Drawing.Color.White;
            this.IdLabel6.Location = new System.Drawing.Point(21, 19);
            this.IdLabel6.Name = "IdLabel6";
            this.IdLabel6.Size = new System.Drawing.Size(55, 13);
            this.IdLabel6.TabIndex = 0;
            this.IdLabel6.Text = "RED Hold";
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCalendar.Location = new System.Drawing.Point(15, 664);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(133, 16);
            this.lblCalendar.TabIndex = 9;
            this.lblCalendar.Text = "Show Calendar For:";
            // 
            // cbCalendar
            // 
            this.cbCalendar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCalendar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCalendar.DisplayMember = "UserID";
            this.cbCalendar.Font = new System.Drawing.Font("Arial", 10F);
            this.cbCalendar.FormattingEnabled = true;
            this.cbCalendar.Location = new System.Drawing.Point(16, 676);
            this.cbCalendar.Name = "cbCalendar";
            this.cbCalendar.Size = new System.Drawing.Size(154, 24);
            this.cbCalendar.TabIndex = 10;
            this.cbCalendar.ValueMember = "UserID";
            this.cbCalendar.SelectedIndexChanged += new System.EventHandler(this.cbCalendar_SelectedIndexChanged);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTasks.Location = new System.Drawing.Point(15, 664);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(111, 16);
            this.lblTasks.TabIndex = 7;
            this.lblTasks.Text = "Show Tasks For:";
            // 
            // cbTasks
            // 
            this.cbTasks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTasks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTasks.DisplayMember = "UserID";
            this.cbTasks.Font = new System.Drawing.Font("Arial", 10F);
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(16, 676);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(154, 24);
            this.cbTasks.TabIndex = 8;
            this.cbTasks.ValueMember = "UserID";
            this.cbTasks.SelectedIndexChanged += new System.EventHandler(this.cbTasks_SelectedIndexChanged);
            // 
            // ckAllTasks
            // 
            this.ckAllTasks.AutoSize = true;
            this.ckAllTasks.Font = new System.Drawing.Font("Arial", 10F);
            this.ckAllTasks.Location = new System.Drawing.Point(18, 641);
            this.ckAllTasks.Name = "ckAllTasks";
            this.ckAllTasks.Size = new System.Drawing.Size(118, 20);
            this.ckAllTasks.TabIndex = 6;
            this.ckAllTasks.Text = "Show All Tasks";
            this.ckAllTasks.UseVisualStyleBackColor = true;
            this.ckAllTasks.CheckedChanged += new System.EventHandler(this.ckAllTasks_CheckedChanged);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Brown;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalendar.Enabled = false;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Location = new System.Drawing.Point(0, 564);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalendar.Size = new System.Drawing.Size(200, 36);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Text = "&Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnEblast_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.Brown;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Arial", 10F);
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Location = new System.Drawing.Point(0, 528);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(200, 36);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = "Call List";
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.BackColor = System.Drawing.Color.Brown;
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGroups.ForeColor = System.Drawing.Color.White;
            this.btnGroups.Location = new System.Drawing.Point(0, 492);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(200, 36);
            this.btnGroups.TabIndex = 3;
            this.btnGroups.Text = "Areas";
            this.btnGroups.UseVisualStyleBackColor = false;
            this.btnGroups.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Brown;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(0, 456);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Grid";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnCompanies_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.Brown;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Arial", 10F);
            this.btnContacts.ForeColor = System.Drawing.Color.White;
            this.btnContacts.Location = new System.Drawing.Point(0, 420);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(200, 36);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Controls.Add(this.ckHideInactive);
            this.IdGroupBox1.Controls.Add(this.cbLookupData);
            this.IdGroupBox1.Controls.Add(this.ckLookupAll);
            this.IdGroupBox1.Controls.Add(this.ckSecondary);
            this.IdGroupBox1.Controls.Add(this.ckShowAllContacts);
            this.IdGroupBox1.Controls.Add(this.btnAdvFind);
            this.IdGroupBox1.Controls.Add(this.btnFind);
            this.IdGroupBox1.Controls.Add(this.cbLookup);
            this.IdGroupBox1.Controls.Add(this.IdLabel1);
            this.IdGroupBox1.Controls.Add(this.lblLookup);
            this.IdGroupBox1.Controls.Add(this.ckPartial);
            this.IdGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(0, 58);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(200, 361);
            this.IdGroupBox1.TabIndex = 0;
            this.IdGroupBox1.TabStop = false;
            // 
            // ckHideInactive
            // 
            this.ckHideInactive.AutoSize = true;
            this.ckHideInactive.Checked = true;
            this.ckHideInactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckHideInactive.Font = new System.Drawing.Font("Arial", 10F);
            this.ckHideInactive.Location = new System.Drawing.Point(5, 284);
            this.ckHideInactive.Name = "ckHideInactive";
            this.ckHideInactive.Size = new System.Drawing.Size(166, 20);
            this.ckHideInactive.TabIndex = 5;
            this.ckHideInactive.Text = "Hide Inactive Contacts";
            this.ckHideInactive.UseVisualStyleBackColor = true;
            // 
            // cbLookupData
            // 
            this.cbLookupData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbLookupData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLookupData.Font = new System.Drawing.Font("Arial", 10F);
            this.cbLookupData.FormattingEnabled = true;
            this.cbLookupData.Location = new System.Drawing.Point(10, 96);
            this.cbLookupData.Name = "cbLookupData";
            this.cbLookupData.Size = new System.Drawing.Size(177, 24);
            this.cbLookupData.TabIndex = 1;
            this.cbLookupData.TextChanged += new System.EventHandler(this.cbLookupData_TextChanged);
            // 
            // ckLookupAll
            // 
            this.ckLookupAll.AutoSize = true;
            this.ckLookupAll.Font = new System.Drawing.Font("Arial", 10F);
            this.ckLookupAll.Location = new System.Drawing.Point(5, 336);
            this.ckLookupAll.Name = "ckLookupAll";
            this.ckLookupAll.Size = new System.Drawing.Size(91, 20);
            this.ckLookupAll.TabIndex = 7;
            this.ckLookupAll.Text = "Lookup All";
            this.ckLookupAll.UseVisualStyleBackColor = true;
            // 
            // ckSecondary
            // 
            this.ckSecondary.Checked = true;
            this.ckSecondary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSecondary.Font = new System.Drawing.Font("Arial", 10F);
            this.ckSecondary.Location = new System.Drawing.Point(6, 246);
            this.ckSecondary.Name = "ckSecondary";
            this.ckSecondary.Size = new System.Drawing.Size(154, 41);
            this.ckSecondary.TabIndex = 4;
            this.ckSecondary.Text = "Exclude Secondary Contacts On Grid";
            this.ckSecondary.UseVisualStyleBackColor = true;
            // 
            // ckShowAllContacts
            // 
            this.ckShowAllContacts.AutoSize = true;
            this.ckShowAllContacts.Font = new System.Drawing.Font("Arial", 10F);
            this.ckShowAllContacts.Location = new System.Drawing.Point(5, 310);
            this.ckShowAllContacts.Name = "ckShowAllContacts";
            this.ckShowAllContacts.Size = new System.Drawing.Size(190, 20);
            this.ckShowAllContacts.TabIndex = 6;
            this.ckShowAllContacts.Text = "Show everyone’s contacts";
            this.ckShowAllContacts.UseVisualStyleBackColor = true;
            this.ckShowAllContacts.Visible = false;
            // 
            // btnAdvFind
            // 
            this.btnAdvFind.BackColor = System.Drawing.Color.Brown;
            this.btnAdvFind.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdvFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvFind.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvFind.ForeColor = System.Drawing.Color.White;
            this.btnAdvFind.Location = new System.Drawing.Point(42, 198);
            this.btnAdvFind.Name = "btnAdvFind";
            this.btnAdvFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdvFind.Size = new System.Drawing.Size(98, 42);
            this.btnAdvFind.TabIndex = 3;
            this.btnAdvFind.Text = "&Advanced Find";
            this.btnAdvFind.UseVisualStyleBackColor = false;
            this.btnAdvFind.Click += new System.EventHandler(this.btnAdvFind_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Brown;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(42, 150);
            this.btnFind.Name = "btnFind";
            this.btnFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFind.Size = new System.Drawing.Size(98, 42);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbLookup
            // 
            this.cbLookup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbLookup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLookup.Font = new System.Drawing.Font("Arial", 10F);
            this.cbLookup.FormattingEnabled = true;
            this.cbLookup.Location = new System.Drawing.Point(12, 50);
            this.cbLookup.Name = "cbLookup";
            this.cbLookup.Size = new System.Drawing.Size(175, 24);
            this.cbLookup.TabIndex = 0;
            this.cbLookup.SelectedIndexChanged += new System.EventHandler(this.cbLookup_SelectedIndexChanged);
            this.cbLookup.TextChanged += new System.EventHandler(this.cbLookup_TextChanged);
            this.cbLookup.Leave += new System.EventHandler(this.cbLookup_Leave);
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(13, 75);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(67, 16);
            this.IdLabel1.TabIndex = 8;
            this.IdLabel1.Text = "Contains:";
            // 
            // lblLookup
            // 
            this.lblLookup.AutoSize = true;
            this.lblLookup.Font = new System.Drawing.Font("Arial", 10F);
            this.lblLookup.Location = new System.Drawing.Point(12, 19);
            this.lblLookup.Name = "lblLookup";
            this.lblLookup.Size = new System.Drawing.Size(95, 16);
            this.lblLookup.TabIndex = 5;
            this.lblLookup.Text = "Contact Field:";
            // 
            // ckPartial
            // 
            this.ckPartial.AutoSize = true;
            this.ckPartial.Checked = true;
            this.ckPartial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckPartial.Font = new System.Drawing.Font("Arial", 10F);
            this.ckPartial.Location = new System.Drawing.Point(16, 120);
            this.ckPartial.Name = "ckPartial";
            this.ckPartial.Size = new System.Drawing.Size(153, 20);
            this.ckPartial.TabIndex = 10;
            this.ckPartial.Text = "Allow Partial Lookup";
            this.ckPartial.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1112, 749);
            this.Controls.Add(this.IdPanel1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM Azure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.IdPanel1.ResumeLayout(false);
            this.IdPanel1.PerformLayout();
            this.gbLegend.ResumeLayout(false);
            this.gbLegend.PerformLayout();
            this.IdGroupBox1.ResumeLayout(false);
            this.IdGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnhancedManageUserComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserComboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyPreferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintCurrentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JustForJeffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpecialStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetVersionNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmailContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem UserGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaintenanceFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoteTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LookupFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportsProspectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DropDownsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ApplicationControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateLocalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNoOnAreas;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalesTotalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CallReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TodaysActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem OpenRMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenQuotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PickupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductivityReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem TelemarketerNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TelemarketerActivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalesRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentCompanyToolStripMenuItem;        
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem HorseRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileVerticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ForewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LastLookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotifyMikeOfCustomerIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FranciesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MikesListToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRecordCount;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Timer Timer3;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.Timer ToDoPopup;
        private System.Windows.Forms.Panel IdPanel1;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.GroupBox gbLegend; 
        private System.Windows.Forms.Label IdLabel8;
        private System.Windows.Forms.Label IdLabel7;
        private System.Windows.Forms.Label IdLabel5;
        private System.Windows.Forms.Label IdLabel4;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label IdLabel6;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.ComboBox cbCalendar;
        private System.Windows.Forms.BindingSource EnhancedManageUserComboBindingSource;
        //
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.BindingSource ManageUserComboBindingSource;
        private System.Windows.Forms.CheckBox ckAllTasks;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.CheckBox ckHideInactive;
        private System.Windows.Forms.ComboBox cbLookupData;
        private System.Windows.Forms.CheckBox ckLookupAll;
        private System.Windows.Forms.CheckBox ckSecondary;
        private System.Windows.Forms.CheckBox ckShowAllContacts;
        private System.Windows.Forms.Button btnAdvFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbLookup;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label lblLookup;
        private System.Windows.Forms.CheckBox ckPartial;

    }
}

