using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM
{
    public partial class frmMain : Form
    {
        private int HoldCount;

        public int frmShowing;

        private DataTable dtLookup;

        private string tmpRecManager;

        private void frmMain_Load(object sender, EventArgs e)
        {

            // V2 - 12/6/2021.
            this.Text = "CRM Azure - Contact";
            this.WindowState = FormWindowState.Normal;

            this.Width = 2000;
            this.Height = 1000;

            //this.Icon = new Icon("crm_icon_resized.ico");

            //Common.LastContacts = new int[5];
            //Common.LastTask = new int[5];
            //Common.LastContactPosition = 0;
            //this.lblTasks.Visible = false;
            //this.cbTasks.Visible = false;
            //this.lblCalendar.Visible = false;
            //this.cbCalendar.Visible = false;
            //this.Text = "CRM Azure v" + Common.SetVersionDate(MyProject.Application.Info.Version.ToString(), true);
            //Common.MyIP = clsSQLConn.SetConnectionString();
            ////Common.NewVersion = false;
            //if (!MyProject.Computer.FileSystem.DirectoryExists(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\CRMEmailTracker\\History"))
            //{
            //    MyProject.Computer.FileSystem.CreateDirectory(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\CRMEmailTracker\\History");
            //}
            //clsEmailTracker.ClearEmailHistory();
            //if (Common.NoData)
            //{
            //    if (Interaction.MsgBox("Your database is empty.\rIf you are loading your local database for the first time this is expected press OK.\rIf not then press Cancel to flip back to the main server.", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "Empty or missing local database") == MsgBoxResult.Cancel)
            //    {
            //        try
            //        {
            //            FileSystem.FileOpen(1, Common.CommonFolder + "\\Preferences.ini", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            //            FileSystem.PrintLine(1, new object[]
            //            {
            //                "1"
            //            });
            //            FileSystem.PrintLine(1, new object[]
            //            {
            //                "0"
            //            });
            //            FileSystem.PrintLine(1, new object[]
            //            {
            //                "1"
            //            });
            //            FileSystem.FileClose(new int[]
            //            {
            //                1
            //            });
            //        }
            //        catch (Exception expr_168)
            //        {
            //            ProjectData.SetProjectError(expr_168);
            //            ProjectData.ClearProjectError();
            //        }
            //        Common.MyIP = clsSQLConn.SetConnectionString();
            //        Interaction.MsgBox("Your preferences have been reset back to the default settings.", MsgBoxStyle.OkOnly, null);
            //    }
            //    else
            //    {
            //        new frmLoadData().ShowDialog();
            //        base.Close();
            //    }
            //}
            //if (!clsSQLConn.isConnected(false))
            //{
            //    Interaction.MsgBox("SQL Connect Error", MsgBoxStyle.OkOnly, null);
            //    ProjectData.EndApp();
            //}
            //int num = 0;
            //frmLogin frmLogin = new frmLogin();
            //checked
            //{
            //    while (!((Operators.CompareString(Common.IRUser, "", false) != 0 & Operators.CompareString(Common.IRGroup, "", false) != 0) | num > 3))
            //    {
            //        if (num > 0)
            //        {
            //            Interaction.MsgBox("Incorrect username or password.", MsgBoxStyle.OkOnly, null);
            //            Common.LogEntryCRM(base.Name, "Failed Login", 0, 0, frmLogin.txtUserID.Text + " " + frmLogin.txtPassword.Text);
            //        }
            //        num++;
            //        frmLogin.ShowDialog();
            //        if (frmLogin.DialogResult != DialogResult.OK)
            //        {
            //            ProjectData.EndApp();
            //        }
            //        else
            //        {
            //            Common.IRGroup = Common.StrScalar(string.Concat(new string[]
            //            {
            //                "select UserGroup from CRMUsers where UserID = '",
            //                frmLogin.txtUserID.Text,
            //                "' and LoginPassword = '",
            //                frmLogin.txtPassword.Text,
            //                "' and Active = 'True' and CanLogin = 'True'"
            //            }), false);
            //            Common.IRUser = frmLogin.txtUserID.Text;
            //        }
            //    }
            //    if (Operators.CompareString(Common.IRGroup, "", false) == 0 | Operators.CompareString(Common.IRGroup, "BAD", false) == 0)
            //    {
            //        Interaction.MsgBox("Incorrect username or password.", MsgBoxStyle.OkOnly, null);
            //        Common.LogEntryCRM(base.Name, "Failed Login", 0, 0, frmLogin.txtUserID.Text + " " + frmLogin.txtPassword.Text);
            //        ProjectData.EndApp();
            //    }
            //    this.Cursor = Cursors.WaitCursor;
            //    Common.IRSalesPersonNo = Common.IntScalar("select isnull(IRSalesPersonNo,0) from CRMUsers where UserID = '" + Common.IRUser + "'", false);
            //    int num2 = FileSystem.FreeFile();
            //    FileSystem.FileOpen(num2, MyProject.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\\CRMLocal.ini", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            //    FileSystem.PrintLine(num2, new object[]
            //    {
            //        frmLogin.txtUserID.Text
            //    });
            //    FileSystem.FileClose(new int[]
            //    {
            //        num2
            //    });
            //    if (clsSQLConn.isConnected(false))
            //    {
            //        this.Text = "CRM Azure (" + Common.IRUser + ") v " + Common.SetVersionDate(MyProject.Application.Info.Version.ToString(), false);
            //        if (Common.LocalOnly)
            //        {
            //            this.Text += " LOCAL USE ONLY NO CHANGES WILL SAVE TO SERVER";
            //        }
            //        Common.LogEntryCRM(base.Name, "Login", 0, 0, "");
            //    }
            //    frmLogin.Close();
            //    this.CreateTable();
            //    this.GetStarted();
            //    this.SetupLookup();
            //    this.EmailTemplatePermissions();
            //    if (Common.CanUseForm("DELETE CONTACT", true))
            //    {
            //        this.DeleteContactToolStripMenuItem.Visible = true;
            //    }
            //    else
            //    {
            //        this.DeleteContactToolStripMenuItem.Visible = false;
            //    }
            //    if (Common.CanUseForm("MAPPING", true))
            //    {
            //        this.MapsToolStripMenuItem.Visible = true;
            //    }
            //    else
            //    {
            //        this.MapsToolStripMenuItem.Visible = false;
            //    }
            //    if (!Common.CanUseForm("ACTIVITYREPORT", true))
            //    {
            //        this.CallReportToolStripMenuItem.Visible = false;
            //    }
            //    if (!Common.CanUseForm("TODAYS_ACTIVITIES", true))
            //    {
            //        this.TodaysActivitiesToolStripMenuItem.Visible = false;
            //    }
            //    if (Common.CanUseForm("PRODUCTIVITY_REPORT", true))
            //    {
            //        this.ProductivityReportToolStripMenuItem.Visible = true;
            //    }
            //    else
            //    {
            //        this.ProductivityReportToolStripMenuItem.Visible = false;
            //    }
            //    if (Common.CanUseForm("ALLCONTACTS", true))
            //    {
            //        this.ckShowAllContacts.Visible = true;
            //        if (Common.LookupAllFiles)
            //        {
            //            this.ckShowAllContacts.CheckState = CheckState.Checked;
            //        }
            //        else
            //        {
            //            this.ckShowAllContacts.CheckState = CheckState.Unchecked;
            //        }
            //    }
            //    else
            //    {
            //        this.ckShowAllContacts.CheckState = CheckState.Unchecked;
            //        this.ckShowAllContacts.Visible = false;
            //    }
            //    if (Common.HideInactive)
            //    {
            //        this.ckHideInactive.CheckState = CheckState.Checked;
            //    }
            //    else
            //    {
            //        this.ckHideInactive.CheckState = CheckState.Unchecked;
            //    }
            //    this.Timer1.Enabled = true;
            //    this.ToDoPopup.Enabled = true;
            //    Common.NonQuery("update CRMTasks set OnHold = 'False' where (OnHold = 'True' or OnHold is null) and ManageUserID = '" + Common.IRUser + "'", false);
            //    this.ManageUserComboTableAdapter.Fill(this.IRDataSetViews.ManageUserCombo);
            //    try
            //    {
            //        this.EnhancedManageUserComboTableAdapter.Fill(this.IRDataSetViews.EnhancedManageUserCombo);
            //    }
            //    catch (Exception expr_5AC)
            //    {
            //        ProjectData.SetProjectError(expr_5AC);
            //        ProjectData.ClearProjectError();
            //    }
            //    this.cbTasks.Text = "";
            //    this.cbCalendar.Text = "";
            //    if (Common.CanUseForm("PRINT_CURRENT_FORM", true))
            //    {
            //        this.PrintCurrentFormToolStripMenuItem.Visible = true;
            //    }
            //    this.Cursor = Cursors.Default;
            //    if (!Common.CanUseForm("MIKES_LIST", true))
            //    {
            //        this.MikesListToolStripMenuItem.Visible = false;
            //    }
            //    if (!Common.CanUseForm("FRANCIES_LIST", true))
            //    {
            //        this.FranciesListToolStripMenuItem.Visible = false;
            //    }
            //    if (Operators.CompareString(Strings.UCase(Common.IRUser), "JEFF", false) == 0)
            //    {
            //        this.JustForJeffToolStripMenuItem.Visible = true;
            //    }
            //    else
            //    {
            //        this.JustForJeffToolStripMenuItem.Visible = false;
            //    }
            //    if (!Common.CanUseForm("", true))
            //    {
            //        this.TelemarketerActivityToolStripMenuItem.Visible = false;
            //    }
            //    if (!Common.CanUseForm("", true))
            //    {
            //        this.TelemarketerNewCustomerToolStripMenuItem.Visible = false;
            //    }
            //    if (!this.TelemarketerNewCustomerToolStripMenuItem.Visible & !this.TelemarketerActivityToolStripMenuItem.Visible)
            //    {
            //        this.ToolStripMenuItem5.Visible = false;
            //    }

            //    int num3 = 0;

            //    try
            //    {
            //        if (MyProject.Computer.FileSystem.FileExists(Common.CommonFolder + "\\LastCompany.ini"))
            //        {
            //            FileSystem.FileOpen(1, Common.CommonFolder + "\\LastCompany.ini", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);

            //            num3 = Conversions.ToInteger(FileSystem.LineInput(1));

            //            FileSystem.FileClose(new int[]
            //            {
            //                1
            //            });
            //        }
            //    }
            //    catch (Exception expr_717)
            //    {
            //        ProjectData.SetProjectError(expr_717);
            //        ProjectData.ClearProjectError();
            //    }

            //    if (num3 != 0)
            //    {
            //        this.frmShowing = 1;
            //        this.SetupLookup();

            //        if (Common.LaptopMonitor)
            //        {
            //            Form[] mdiChildren = base.MdiChildren;

            //            for (int i = 0; i < mdiChildren.Length; i++)
            //            {
            //                Form form = mdiChildren[i];

            //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                {
            //                    new frmContactLaptop();

            //                    frmContactLaptop expr_77F = (frmContactLaptop)form;
            //                    expr_77F.ContactID = num3;
            //                    clsContacts.RefreshData(false);

            //                    expr_77F.WindowState = FormWindowState.Maximized;

            //                    expr_77F.BringToFrontHelper();
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Form[] mdiChildren2 = base.MdiChildren;

            //            for (int j = 0; j < mdiChildren2.Length; j++)
            //            {
            //                Form form2 = mdiChildren2[j];

            //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                {
            //                    new frmContact();

            //                    frmContact expr_7E0 = (frmContact)form2;
            //                    expr_7E0.ContactID = num3;
            //                    clsContacts.RefreshData(false);

            //                    expr_7E0.WindowState = FormWindowState.Maximized;

            //                    expr_7E0.BringToFrontHelper();
            //                }
            //            }
            //        }
            //    }

            //    if (Common.LocalOnly)
            //    {
            //        this.UpdateLocalDataToolStripMenuItem.Visible = true;
            //    }
            //    else
            //    {
            //        this.UpdateLocalDataToolStripMenuItem.Visible = false;
            //    }

            //    this.cbLookup.Focus();

            //    int num4 = Common.IntScalar(string.Concat(new string[]
            //    {
            //        "select Count(*) from CRMTasks T join CRMContactList L on T.ContactID = L.ContactID where  T.ManageUserID = '",
            //        Common.IRUser,
            //        "' and (TaskType = 6 or TaskType = 1)  and Deleted = 'False' and TaskColor <> '255,185,185,185' and StartTime < '",
            //        DateAndTime.DateAdd(DateInterval.Day, -2.0, DateTime.Today).ToShortDateString(),
            //        "'"
            //    }), false);

            //    if (num4 > 0)
            //    {
            //        Interaction.MsgBox("You have " + Conversions.ToString(num4) + " open calendar items over two days old.", MsgBoxStyle.OkOnly, null);
            //    }
            //}

            // V2 - 12/6/2021.
            this.Text = "CRM Azure - Contact";
        }


        private void EmailTemplatePermissions()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            //SqlCommand sqlCommand = new SqlCommand("select TemplateName from CRMEmailTemplates where TemplateName not in (select FormName from CRMUserForms)", sqlConnection);
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    Common.NonQuery("insert into CRMUserForms (FormName) values ('" + sqlDataReader.GetString(0) + "')", false);
            //}
            //sqlCommand.Connection.Close();
            //sqlConnection.Close();
        }

        private void CreateTable()
        {
            //try
            //{
            //    this.dtLookup = new DataTable("LookupData");
            //    DataColumn dataColumn = new DataColumn();
            //    dataColumn.DataType = Type.GetType("System.String");
            //    dataColumn.ColumnName = "DisplayName";
            //    dataColumn.AutoIncrement = false;
            //    dataColumn.Caption = "DisplayName";
            //    dataColumn.ReadOnly = false;
            //    dataColumn.Unique = false;
            //    this.dtLookup.Columns.Add(dataColumn);
            //    dataColumn = new DataColumn();
            //    dataColumn.DataType = Type.GetType("System.String");
            //    dataColumn.ColumnName = "FieldName";
            //    dataColumn.ReadOnly = true;
            //    dataColumn.Unique = true;
            //    this.dtLookup.Columns.Add(dataColumn);
            //}
            //catch (Exception expr_A4)
            //{
            //    ProjectData.SetProjectError(expr_A4);
            //    Exception ex = expr_A4;
            //    string arg_B1_0 = ex.Message;
            //    ProjectData.ClearProjectError();
            //}
        }

        private void GetStarted()
        {
            //this.frmShowing = 1;

            //if (Common.LaptopMonitor)
            //{
            //    frmContactLaptop frmContactLaptop = new frmContactLaptop();

            //    if (Common.CanUseForm(Conversions.ToString(frmContactLaptop.Tag), false))
            //    {
            //        frmContactLaptop.Icon = base.Icon;
            //        frmContactLaptop.MdiParent = this;

            //        // frmContactLaptop.ControlBox = false;
            //        frmContactLaptop.ControlBox = true;

            //        frmContactLaptop.Show();

            //        return;
            //    }
            //}
            //else
            //{
            //    // V2 - 12/6/2021:

            //    LaunchContactForm();

            //    //frmContact frmContact = new frmContact();
            //    //if (Common.CanUseForm(Conversions.ToString(frmContact.Tag), false))
            //    //{
            //    //    frmContact.Icon = base.Icon;
            //    //    frmContact.MdiParent = this;
            //    //    frmContact.Show();
            //    //    frmContact.WindowState = FormWindowState.Minimized;
            //    //    frmContact.BringToFrontHelper();
            //    //}
            //}
        }


        // V2 12/6/2021:
        //frmContact frmContact;
        public void LaunchContactForm()
        {
            //frmContact = null;
            //frmContact = new frmContact();

            //if (Common.CanUseForm(Conversions.ToString(frmContact.Tag), false))
            //{
            //    frmContact.Icon = base.Icon;
            //    frmContact.MdiParent = this;

            //    frmContact.ControlBox = true;

            //    frmContact.Show();


            //    //frmContact.WindowState = FormWindowState.Minimized;

            //    frmContact.WindowState = FormWindowState.Maximized;

            //    frmContact.BringToFrontHelper();
            //}
        }


        // V2 12/9/2021:

        public void LaunchForm(Form formToLaunch)
        {
           // frmContact = null;
            //frmContact = new frmContact();

            //if (Common.CanUseForm(Conversions.ToString(frmContact.Tag), false))
            //{
            //    frmContact.Icon = base.Icon;
            //    frmContact.MdiParent = this;
            //    frmContact.Show();
            //    frmContact.WindowState = FormWindowState.Minimized;
            //    frmContact.BringToFrontHelper();
            //}
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            //if (this.ActiveMdiChild != null)
            //{

                // Grant - 6/19/2022:
               // clsContacts.RefreshData(false);


                // Grant Changes - 12/1/2021:
                //if(this.ActiveMdiChild.FormBorderStyle == FormBorderStyle.None)

            //    this.ActiveMdiChild.BringToFrontHelper();
            //}


            // throw new NotImplementedException();

            /*
            Form[] mdiChildren = base.MdiChildren;
            for (int i = 0; i < mdiChildren.Length; i++)
            {
                Form form = mdiChildren[i];
                if (form.Visible )
                    form.BringToFrontHelper();
              //  if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
              //  {
                    //new frmContactLaptop();
                    //frmContactLaptop expr_77F = (frmContactLaptop)form;
                    //expr_77F.ContactID = num3;
                    //clsContacts.RefreshData(false);
                    //expr_77F.BringToFrontHelper();
              //  }
            }
            */
        }

        public frmMain()
        {
            //base.Load += new EventHandler(this.frmMain_Load);
            //base.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);

            //// Grant 12/1/2021:
            /////////////////////base.MdiChildActivate += FrmMain_MdiChildActivate;
            /////
            //base.ResizeEnd += FrmMain_ResizeEnd;
            //this.HoldCount = 0;
            //this.tmpRecManager = "";

            InitializeComponent();


            //try
            //{
            //    string applicationPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

            //    // Load SQL Server Types for SQL Server Spatial:
            //    LoadNativeAssemblies(applicationPath);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"LoadNativeAssembliesv13() Error:  {ex.Message}", "Load Native Assemblies Error!");
            //}


        }

        private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            //if (this.ActiveMdiChild != null)
            //{
            //    if (this.ActiveMdiChild.FormBorderStyle == FormBorderStyle.None && this.ActiveMdiChild.WindowState != FormWindowState.Maximized)
            //        this.ActiveMdiChild.BringToFrontHelper();
            //}
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintCurrentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Common.PrintForm(this.ActiveMdiChild);
        }

        private void UsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmLookup frmLookup = new frmLookup("User", "Select 'User Login' = UserID, 'Group' = UserGroup from CRMUsers order by UserID");
            //if (Common.CanUseForm("User", false))
            //{
            //    frmLookup.Icon = base.Icon;
            //    frmLookup.ShowDialog();
            //}
        }

        private void UserGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUserGroups frmUserGroups = new frmUserGroups();
            //if (Common.CanUseForm(Conversions.ToString(frmUserGroups.Tag), false))
            //{
            //    frmUserGroups.Icon = base.Icon;
            //    frmUserGroups.ShowDialog();
            //}
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FileSystem.FileOpen(1, Common.CommonFolder + "\\LastCompany.ini", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            //FileSystem.PrintLine(1, new object[]
            //{
            //    Common.LastContactID
            //});
            //FileSystem.FileClose(new int[]
            //{
            //    1
            //});
            //Common.LogEntryCRM(base.Name, "Logoff", 0, 0, "");
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            //this.frmShowing = 1;

            //this.SetupLookup();

            //checked
            //{
            //    if (Common.LaptopMonitor)
            //    {
            //        Form[] mdiChildren = base.MdiChildren;

            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];

            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //            {
            //                form.BringToFrontHelper();
            //                clsContacts.RefreshData(false);
            //                return;
            //            }
            //        }

            //        return;
            //    }




            //    // V2 - 12/9/2021:

            //    ShowFormNow("frmContact", "");




            //    //Form[] mdiChildren2 = base.MdiChildren;
            //    //for (int j = 0; j < mdiChildren2.Length; j++)
            //    //{
            //    //    Form form2 = mdiChildren2[j];
            //    //    if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //    //    {
            //    //        form2.BringToFrontHelper();
            //    //        clsContacts.RefreshData(false);
            //    //        return;
            //    //    }
            //    //}


            //}
        }

        // V2 - 12/9/2021.

        private void ShowFormNow(string formName, string formText)
        {
            // V2 - 12/6/2021:

            FormCollection fc = Application.OpenForms;

            bool foundFormFlag = false;

            Form FormThatWasFound = null;

            foreach (Form frm in fc)
            {
                if (frm.Text == formText)
                {
                    // We've found it!

                    foundFormFlag = true;

                    FormThatWasFound = frm;

                    break;
                }

                if (frm.Name == formName)
                {
                    // We've found it!

                    foundFormFlag = true;

                    FormThatWasFound = frm;

                    break;
                }
            }

            if (foundFormFlag == false)
            {
                // The form is not present!
                // So start it up again!!!

                // V2 - 12/6/2021:

                switch (formName)
                {
                    case "frmContact":
                        {
                            LaunchContactForm();

                            break;
                        }
                }


            }
            else
            {
                // Set it active!

                //if (FormThatWasFound != null)
                //{
                //    FormThatWasFound.Activate();

                //    FormThatWasFound.BringToFrontHelper();

                //    // Grant - 6/19/2022:
                //    clsContacts.RefreshData(false);
                //}

            }

            return;
        }
        private void btnCompanies_Click(object sender, EventArgs e)
        {
            //this.frmShowing = 2;
            //this.SetupLookup();
            //Form[] mdiChildren = base.MdiChildren;
            //checked
            //{
            //    for (int i = 0; i < mdiChildren.Length; i++)
            //    {
            //        Form form = mdiChildren[i];
            //        if (Operators.CompareString(form.Name, MyProject.Forms.frmSearchGrid.Name, false) == 0)
            //        {
            //            form.BringToFront();
            //            return;
            //        }
            //    }
            //    this.AdvancedFind(false);
            //}
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.frmShowing = 3;
            //this.SetupLookup();

            //Form[] mdiChildren = base.MdiChildren;

            //checked
            //{
            //    for (int i = 0; i < mdiChildren.Length; i++)
            //    {
            //        Form form = mdiChildren[i];

            //        if (Operators.CompareString(form.Name, MyProject.Forms.frmAreas.Name, false) == 0)
            //        {
            //            frmAreas expr_4A = (frmAreas)form;
            //            expr_4A.NoPCT = this.mnuNoOnAreas.Checked;
            //            expr_4A.BringToFront();
            //            this.Cursor = Cursors.Default;

            //            return;
            //        }
            //    }
            //    frmAreas frmAreas = new frmAreas();

            //    if (Common.CanUseForm(Conversions.ToString(frmAreas.Tag), false))
            //    {
            //        frmAreas.Icon = base.Icon;
            //        frmAreas.MdiParent = this;
            //        frmAreas.NoPCT = this.mnuNoOnAreas.Checked;
            //        frmAreas.Show();


            //        // V2 - 12/6/2021:
            //        base.LayoutMdi(MdiLayout.Cascade);



            //        this.Cursor = Cursors.Default;
            //    }
            //}
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            this.frmShowing = 4;
            //this.SetupLookup();
            //Form[] mdiChildren = base.MdiChildren;
            //checked
            //{
            //    for (int i = 0; i < mdiChildren.Length; i++)
            //    {
            //        Form form = mdiChildren[i];
            //        if (Operators.CompareString(form.Name, MyProject.Forms.frmTasks.Name, false) == 0)
            //        {
            //            frmTasks frmTasks = (frmTasks)form;
            //            if (Common.CanUseForm("SEE_ALL_TASKS", true))
            //            {
            //                frmTasks.RecordManager = this.cbTasks.Text;
            //            }
            //            frmTasks.LoadGrid();
            //            frmTasks.BringToFront();
            //            return;
            //        }
            //    }
            //    frmTasks frmTasks2 = new frmTasks();
            //    if (Common.CanUseForm(Conversions.ToString(frmTasks2.Tag), false))
            //    {
            //        frmTasks2.Icon = base.Icon;
            //        if (Common.CanUseForm("SEE_ALL_TASKS", true))
            //        {
            //            frmTasks2.RecordManager = this.cbTasks.Text;
            //        }
            //        frmTasks2.MdiParent = this;
            //        frmTasks2.Show();
            //    }
            //}
        }
        public void SetupLookup()
        {
            this.gbLegend.Visible = false;
            this.ckAllTasks.Visible = false;
            this.cbTasks.Visible = false;
            this.lblTasks.Visible = false;
            this.lblCalendar.Visible = false;
            this.cbCalendar.Visible = false;
            this.ForewardToolStripMenuItem.Visible = false;
            this.BackToolStripMenuItem.Visible = false;
            this.CustomerIssuesToolStripMenuItem.Visible = false;

            this.pictureBoxLogo.Visible = true;

            //switch (this.frmShowing)
            //{
            //    case 1:
            //        {
            //            this.CustomerIssuesToolStripMenuItem.Visible = true;
            //            this.dtLookup.Clear();
            //            SqlConnection sqlConnection = new SqlConnection();
            //            sqlConnection = Common.ConnectToSQL(false);
            //            string cmdText = "select distinct DisplayName, FieldName from CRMLookupFields";
            //            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //            while (sqlDataReader.Read())
            //            {
            //                DataRow dataRow = this.dtLookup.NewRow();
            //                dataRow["DisplayName"] = sqlDataReader.GetString(0);
            //                dataRow["FieldName"] = sqlDataReader.GetString(1);
            //                this.dtLookup.Rows.Add(dataRow);
            //            }
            //            sqlCommand.Connection.Close();
            //            sqlConnection.Close();
            //            this.cbLookup.DataSource = this.dtLookup;
            //            this.cbLookup.DisplayMember = "DisplayName";
            //            this.cbLookup.ValueMember = "FieldName";
            //            this.cbLookup.Text = "";
            //            this.ForewardToolStripMenuItem.Visible = true;
            //            this.BackToolStripMenuItem.Visible = true;
            //            return;
            //        }
            //    case 2:
            //        {
            //            this.dtLookup.Clear();
            //            SqlConnection sqlConnection2 = new SqlConnection();
            //            sqlConnection2 = Common.ConnectToSQL(false);
            //            string cmdText2 = "select distinct DisplayName, FieldName from CRMLookupFields";
            //            SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection2);
            //            SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            //            while (sqlDataReader2.Read())
            //            {
            //                DataRow dataRow2 = this.dtLookup.NewRow();
            //                dataRow2["DisplayName"] = sqlDataReader2.GetString(0);
            //                dataRow2["FieldName"] = sqlDataReader2.GetString(1);
            //                this.dtLookup.Rows.Add(dataRow2);
            //            }
            //            sqlCommand2.Connection.Close();
            //            sqlConnection2.Close();
            //            this.cbLookup.DataSource = this.dtLookup;
            //            this.cbLookup.DisplayMember = "DisplayName";
            //            this.cbLookup.ValueMember = "FieldName";
            //            this.cbLookup.Text = "";
            //            return;
            //        }
            //    case 3:
            //    case 6:
            //        break;
            //    case 4:
            //        this.ckAllTasks.Visible = true;
            //        if (!Common.CanUseForm("SEE_ALL_TASKS", true))
            //        {
            //            this.lblTasks.Visible = false;
            //            this.cbTasks.Visible = false;
            //            return;
            //        }
            //        this.lblTasks.Visible = true;
            //        this.cbTasks.Visible = true;
            //        if (Operators.CompareString(this.cbTasks.Text, "", false) == 0)
            //        {
            //            if (Operators.CompareString(this.tmpRecManager, "", false) != 0)
            //            {
            //                this.cbTasks.Text = this.tmpRecManager;
            //                return;
            //            }
            //            this.cbTasks.Text = Common.IRUser;
            //            return;
            //        }
            //        break;
            //    case 5:
            //        if (Common.CanUseForm("SEE_ALL_TASKS", true))
            //        {
            //            this.lblCalendar.Visible = true;
            //            this.cbCalendar.Visible = true;
            //            if (Operators.CompareString(this.cbCalendar.Text, "", false) == 0)
            //            {
            //                if (Operators.CompareString(this.tmpRecManager, "", false) != 0)
            //                {
            //                    this.cbCalendar.Text = this.tmpRecManager;
            //                    return;
            //                }
            //                this.cbCalendar.Text = Common.IRUser;
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            this.lblCalendar.Visible = false;
            //            this.cbCalendar.Visible = false;
            //        }
            //        break;
            //    default:
            //        return;
            //}
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (this.ckLookupAll.CheckState == CheckState.Checked)
            {
                this.ckLookupAll.CheckState = CheckState.Unchecked;
                this.cbLookup.Text = "";
                this.cbLookupData.Text = "";
            }
            string text = "";
            string text2 = "select ContactID from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID ";
            string text3;
            string text4;
            if (this.ckPartial.CheckState == CheckState.Checked)
            {
                text3 = "%" + this.cbLookupData.Text + "%";
                text4 = "like";
            }
            else
            {
                text3 = this.cbLookupData.Text;
                text4 = "=";
            }
            //checked
            //{
            //    if (Operators.ConditionalCompareObjectEqual(this.cbLookup.SelectedValue, "FullName", false))
            //    {
            //        int num = Strings.InStr(Strings.Trim(this.cbLookupData.Text), " ", CompareMethod.Binary);
            //        if (num <= 0)
            //        {
            //            Common.LastSearchSQL = "";
            //            Common.LastSearchWhere = "";
            //            this.Cursor = Cursors.Default;
            //            Interaction.MsgBox("Sorry no records matched your search criteria.", MsgBoxStyle.OkOnly, "No Records");
            //            return;
            //        }
            //        string text5 = Strings.Trim(Strings.Mid(this.cbLookupData.Text, 1, num));
            //        string text6 = Strings.Trim(Strings.Mid(this.cbLookupData.Text, num, text3.Length - num));
            //        if (this.ckPartial.CheckState == CheckState.Checked)
            //        {
            //            text5 = "%" + text5 + "%";
            //            text6 = "%" + text6 + "%";
            //            text4 = "like";
            //        }
            //        else
            //        {
            //            text4 = "=";
            //        }
            //        text = clsSQLSearches.setWhere(text, string.Concat(new string[]
            //        {
            //            "FirstName ",
            //            text4,
            //            " '",
            //            text5,
            //            "'"
            //        }));
            //        text = clsSQLSearches.setWhere(text, string.Concat(new string[]
            //        {
            //            "LastName ",
            //            text4,
            //            " '",
            //            text6,
            //            "'"
            //        }));
            //    }
            //    else if (Operators.ConditionalCompareObjectEqual(this.cbLookup.SelectedValue, "AREA", false))
            //    {
            //        SqlConnection connection = new SqlConnection();
            //        connection = Common.ConnectToSQL(false);
            //        SqlDataReader sqlDataReader = new SqlCommand(string.Concat(new string[]
            //        {
            //            "select GroupID from CRMGroup where Name ",
            //            text4,
            //            " '",
            //            text3,
            //            "' "
            //        }), connection).ExecuteReader();
            //        if (sqlDataReader.HasRows)
            //        {
            //            string text7 = "(";
            //            while (sqlDataReader.Read())
            //            {
            //                text7 = text7 + "CO.GroupID = " + Conversions.ToString(sqlDataReader.GetInt32(0)) + " or ";
            //            }
            //            text7 = Strings.Mid(text7, 1, text7.Length - 3);
            //            text7 += ")";
            //            text = clsSQLSearches.setWhere(text, text7);
            //        }
            //    }
            //    else if (Operators.CompareString(Strings.Trim(this.cbLookupData.Text), "", false) != 0)
            //    {
            //        text = clsSQLSearches.setWhere(text, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.cbLookup.SelectedValue, " "), text4), " '"), text3), "'")));
            //    }
            //    if (!Common.CanUseForm("ALLCONTACTS", true) | this.ckShowAllContacts.CheckState == CheckState.Unchecked)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection = Common.ConnectToSQL(false);
            //        SqlCommand sqlCommand = new SqlCommand("Select UserLinkID from CRMUserLinks where UserID = '" + Common.IRUser + "' and LinkType = 1", sqlConnection);
            //        SqlDataReader sqlDataReader2 = sqlCommand.ExecuteReader();
            //        if (sqlDataReader2.HasRows)
            //        {
            //            string text8 = "(";
            //            while (sqlDataReader2.Read())
            //            {
            //                text8 = text8 + "ManageUserID = '" + sqlDataReader2.GetString(0) + "' or ";
            //            }
            //            text8 = text8 + " ManageUserID = '" + Common.IRUser + "')";
            //            text = clsSQLSearches.setWhere(text, text8);
            //        }
            //        else
            //        {
            //            text = clsSQLSearches.setWhere(text, "ManageUserID = '" + Common.IRUser + "'");
            //        }
            //        sqlCommand.Connection.Close();
            //        sqlConnection.Close();
            //    }
            //    if (this.ckSecondary.CheckState == CheckState.Checked)
            //    {
            //        text = clsSQLSearches.setWhere(text, "PrimaryContact = 'True'");
            //    }
            //    if (this.ckHideInactive.CheckState == CheckState.Checked)
            //    {
            //        text = clsSQLSearches.setWhere(text, "ConStatus <> 'INACTIVE'");
            //    }

            //    Common.LastSearchSQL = text2;
            //    Common.LastSearchWhere = text;
            //    text2 += text;
            //    text2 += " order by CN.CompanyID";
            //    Common.LogEntryCRM(base.Name, "SEARCH", 0, 0, "CONTACT " + this.cbLookup.Text + " " + this.cbLookupData.Text);
            //    int num2 = Common.RecordCount(text2);

            //    if (num2 != 0)
            //    {
            //        if (num2 != 1)
            //        {
            //            this.frmShowing = 2;
            //            this.SetupLookup();
            //            Form[] mdiChildren = base.MdiChildren;
            //            for (int i = 0; i < mdiChildren.Length; i++)
            //            {
            //                Form form = mdiChildren[i];
            //                if (Operators.CompareString(form.Name, MyProject.Forms.frmSearchGrid.Name, false) == 0)
            //                {
            //                    frmSearchGrid expr_645 = (frmSearchGrid)form;
            //                    expr_645.where = text;
            //                    expr_645.LoadGrid();
            //                    expr_645.BringToFront();
            //                    this.Cursor = Cursors.Default;
            //                    return;
            //                }
            //            }
            //            frmSearchGrid frmSearchGrid = new frmSearchGrid();
            //            if (!Common.CanUseForm(Conversions.ToString(frmSearchGrid.Tag), false))
            //            {
            //                return;
            //            }
            //            frmSearchGrid.Icon = base.Icon;
            //            frmSearchGrid.where = text;
            //            frmSearchGrid.MdiParent = this;
            //            frmSearchGrid.Show();
            //            frmSearchGrid.WindowState = FormWindowState.Minimized;
            //            frmSearchGrid.WindowState = FormWindowState.Maximized;
            //            this.Cursor = Cursors.Default;
            //        }
            //        else
            //        {
            //            this.frmShowing = 1;
            //            this.SetupLookup();
            //            Common.LastSearchSQL = "";
            //            Common.LastSearchWhere = "";
            //            if (Common.LaptopMonitor)
            //            {
            //                Form[] mdiChildren2 = base.MdiChildren;

            //                for (int j = 0; j < mdiChildren2.Length; j++)
            //                {
            //                    Form form2 = mdiChildren2[j];

            //                    if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                    {
            //                        frmContactLaptop expr_54A = (frmContactLaptop)form2;

            //                        expr_54A.ContactID = Common.IntScalar(text2, false);
            //                        expr_54A.CompanyCount = 1;
            //                        clsContacts.RefreshData(false);
            //                        expr_54A.BringToFrontHelper();
            //                        this.Cursor = Cursors.Default;

            //                        return;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Form[] mdiChildren3 = base.MdiChildren;
            //                for (int k = 0; k < mdiChildren3.Length; k++)
            //                {
            //                    Form form3 = mdiChildren3[k];

            //                    if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                    {
            //                        frmContact expr_5C1 = (frmContact)form3;

            //                        expr_5C1.ContactID = Common.IntScalar(text2, false);
            //                        expr_5C1.CompanyCount = 1;
            //                        clsContacts.RefreshData(false);
            //                        expr_5C1.BringToFrontHelper();
            //                        this.Cursor = Cursors.Default;

            //                        return;
            //                    }
            //                }
            //            }
            //        }
            //        this.Cursor = Cursors.Default;
            //        return;
            //    }
            //    Common.LastSearchSQL = "";
            //    Common.LastSearchWhere = "";
            //    this.Cursor = Cursors.Default;
            //    Interaction.MsgBox("Sorry no records matched your search criteria.", MsgBoxStyle.OkOnly, "No Records");
            //}
        }

        private void AdvancedFind(bool Redo)
        {
            //string text;
            //string text2;
            //if (Redo)
            //{
            //    text = Common.LastSearchSQL;
            //    text2 = Common.LastSearchWhere;
            //}
            //else
            //{
            //    frmAdvancedFind frmAdvancedFind = new frmAdvancedFind();
            //    if (!Common.CanUseForm(Conversions.ToString(frmAdvancedFind.Tag), false))
            //    {
            //        return;
            //    }
            //    frmAdvancedFind.Icon = base.Icon;
            //    frmAdvancedFind.frmShowing = this.frmShowing;
            //    frmAdvancedFind.ShowDialog();
            //    if (frmAdvancedFind.DialogResult == DialogResult.Cancel)
            //    {
            //        return;
            //    }
            //    this.Cursor = Cursors.WaitCursor;
            //    text = frmAdvancedFind.SQLStr;
            //    text2 = frmAdvancedFind.Where;
            //}
            //if (!Common.CanUseForm("ALLCONTACTS", true) | this.ckShowAllContacts.CheckState == CheckState.Unchecked)
            //{
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection = Common.ConnectToSQL(false);
            //    SqlCommand sqlCommand = new SqlCommand("Select UserLinkID from CRMUserLinks where UserID = '" + Common.IRUser + "' and LinkType = 1", sqlConnection);
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.HasRows)
            //    {
            //        string text3 = "(";
            //        while (sqlDataReader.Read())
            //        {
            //            text3 = text3 + "ManageUserID = '" + sqlDataReader.GetString(0) + "' or ";
            //        }
            //        text3 = text3 + " ManageUserID = '" + Common.IRUser + "')";
            //        text2 = clsSQLSearches.setWhere(text2, text3);
            //    }
            //    else
            //    {
            //        text2 = clsSQLSearches.setWhere(text2, "ManageUserID = '" + Common.IRUser + "'");
            //    }
            //    sqlCommand.Connection.Close();
            //    sqlConnection.Close();
            //}
            //if (this.ckSecondary.CheckState == CheckState.Checked)
            //{
            //    text2 = clsSQLSearches.setWhere(text2, "PrimaryContact = 'True'");
            //}
            //if (this.ckHideInactive.CheckState == CheckState.Checked)
            //{
            //    text2 = clsSQLSearches.setWhere(text2, "ConStatus <> 'INACTIVE'");
            //}
            //text += text2;
            //text += " order by CN.CompanyID";
            //Common.LogEntryCRM(base.Name, "SEARCH", 0, 0, "CONTACT " + this.cbLookup.Text + " " + this.cbLookupData.Text);
            //int num = Common.RecordCount(text);
            //if (num == 0)
            //{
            //    this.Cursor = Cursors.Default;
            //    Interaction.MsgBox("Sorry no records matched your search criteria.", MsgBoxStyle.OkOnly, "No Records");
            //    return;
            //}
            //checked
            //{
            //    if (num != 1)
            //    {
            //        Form[] mdiChildren = base.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmSearchGrid.Name, false) == 0)
            //            {
            //                frmSearchGrid expr_312 = (frmSearchGrid)form;
            //                expr_312.where = text2;
            //                expr_312.LoadGrid();
            //                expr_312.BringToFront();
            //                this.Cursor = Cursors.Default;
            //                return;
            //            }
            //        }
            //        frmSearchGrid frmSearchGrid = new frmSearchGrid();
            //        if (!Common.CanUseForm(Conversions.ToString(frmSearchGrid.Tag), false))
            //        {
            //            return;
            //        }
            //        frmSearchGrid.Icon = base.Icon;
            //        frmSearchGrid.where = text2;
            //        frmSearchGrid.MdiParent = this;
            //        frmSearchGrid.Show();
            //        frmSearchGrid.WindowState = FormWindowState.Minimized;
            //        frmSearchGrid.WindowState = FormWindowState.Maximized;
            //        this.Cursor = Cursors.Default;
            //    }
            //    else if (Common.LaptopMonitor)
            //    {
            //        Form[] mdiChildren2 = base.MdiChildren;
            //        for (int j = 0; j < mdiChildren2.Length; j++)
            //        {
            //            Form form2 = mdiChildren2[j];

            //            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //            {
            //                ((frmContactLaptop)form2).ContactID = Common.IntScalar(text, false);

            //                clsContacts.RefreshData(false);
            //                this.Cursor = Cursors.Default;

            //                return;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Form[] mdiChildren3 = base.MdiChildren;
            //        for (int k = 0; k < mdiChildren3.Length; k++)
            //        {
            //            Form form3 = mdiChildren3[k];

            //            if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //            {
            //                ((frmContact)form3).ContactID = Common.IntScalar(text, false);

            //                clsContacts.RefreshData(false);
            //                this.Cursor = Cursors.Default;

            //                return;
            //            }
            //        }
            //    }
            //    this.Cursor = Cursors.Default;
            //}
        }

        private void btnAdvFind_Click(object sender, EventArgs e)
        {
            if (this.ckLookupAll.CheckState == CheckState.Checked)
            {
                this.ckLookupAll.CheckState = CheckState.Unchecked;
            }
            this.AdvancedFind(false);
        }

        private void btnEblast_Click(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (Common.CanUseForm("Calendar", false))
            //    {
            //        this.frmShowing = 5;
            //        Form[] mdiChildren = base.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmCalendar.Name, false) == 0)
            //            {
            //                frmCalendar frmCalendar = new frmCalendar();
            //                frmCalendar = (frmCalendar)form;
            //                string value = "";

            //                if (Common.LaptopMonitor)
            //                {
            //                    new frmContactLaptop();

            //                    Form[] mdiChildren2 = base.MdiChildren;

            //                    for (int j = 0; j < mdiChildren2.Length; j++)
            //                    {
            //                        Form form2 = mdiChildren2[j];

            //                        if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                        {
            //                            value = ((frmContactLaptop)form2).txtContactID.Text;

            //                            break;
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    new frmContact();

            //                    Form[] mdiChildren3 = base.MdiChildren;

            //                    for (int k = 0; k < mdiChildren3.Length; k++)
            //                    {
            //                        Form form3 = mdiChildren3[k];

            //                        if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                        {
            //                            value = ((frmContact)form3).txtContactID.Text;
            //                            break;
            //                        }
            //                    }
            //                }

            //                frmCalendar.ContactID = Conversions.ToInteger(value);

            //                frmCalendar.GetCalendarItems();

            //                frmCalendar.BringToFront();

            //                this.SetupLookup();

            //                return;
            //            }
            //        }

            //        frmCalendar frmCalendar2 = new frmCalendar();
            //        string value2 = "";
            //        string left = "";
            //        string text = "";

            //        if (Common.LaptopMonitor)
            //        {
            //            new frmContactLaptop();

            //            Form[] mdiChildren4 = base.MdiChildren;

            //            for (int l = 0; l < mdiChildren4.Length; l++)
            //            {
            //                Form form4 = mdiChildren4[l];

            //                if (Operators.CompareString(form4.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                {
            //                    frmContactLaptop expr_1AB = (frmContactLaptop)form4;

            //                    value2 = expr_1AB.txtContactID.Text;
            //                    left = expr_1AB.txtCompanyID.Text;
            //                    text = expr_1AB.cbRecordManager.Text;

            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            new frmContact();

            //            Form[] mdiChildren5 = base.MdiChildren;

            //            for (int m = 0; m < mdiChildren5.Length; m++)
            //            {
            //                Form form5 = mdiChildren5[m];

            //                if (Operators.CompareString(form5.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                {
            //                    frmContact expr_225 = (frmContact)form5;

            //                    value2 = expr_225.txtContactID.Text;
            //                    left = expr_225.txtCompanyID.Text;
            //                    text = expr_225.cbRecordManager.Text;

            //                    break;
            //                }
            //            }
            //        }

            //        int contactID = 0;

            //        if (Operators.CompareString(left, "", false) == 0)
            //        {
            //            this.tmpRecManager = Common.IRUser;
            //        }
            //        else
            //        {
            //            contactID = Conversions.ToInteger(value2);

            //            int num = Common.IntScalar("select count(*) from CRMUserLinks where UserID = '" + text + "' and LinkType = 2", false);

            //            if (num != 0)
            //            {
            //                if (num != 1)
            //                {
            //                    this.tmpRecManager = Common.idComboInput("Select driver", "select UserLinkID from CRMUserLinks where UserID = '" + text + "' and LinkType = 2", "UserLinkID", "UserLInkID", "", "Select Driver", "", "");
            //                }
            //                else
            //                {
            //                    this.tmpRecManager = Common.StrScalar("select UserLinkID from CRMUserLinks where UserID = '" + text + "' and LinkType = 2", false);
            //                }
            //            }
            //            else
            //            {
            //                if (!Common.CanUseForm("SEE_ALL_TASKS", true))
            //                {
            //                    Interaction.MsgBox("This record manager does not currently have an assigned driver.", MsgBoxStyle.Critical, "No Assigned Driver");
            //                    return;
            //                }

            //                frmCalendar2.RecordManager = Common.IRUser;
            //            }
            //        }

            //        frmCalendar2.AreaManager = text;
            //        frmCalendar2.RecordManager = this.tmpRecManager;
            //        frmCalendar2.ContactID = contactID;
            //        frmCalendar2.Icon = base.Icon;
            //        frmCalendar2.MdiParent = this;

            //        frmCalendar2.Show();

            //        this.SetupLookup();
            //    }
            //}
        }

        private void EmailContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEmailTemplate frmEmailTemplate = new frmEmailTemplate();
            //if (Common.CanUseForm(Conversions.ToString(frmEmailTemplate.Tag), false))
            //{
            //    frmEmailTemplate.Icon = base.Icon;
            //    frmEmailTemplate.ShowDialog();
            //}
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //this.Timer1.Enabled = false;
            //this.Text = "CRM Azure (" + Common.IRUser + ") v " + Common.SetVersionDate(MyProject.Application.Info.Version.ToString(), false);
            //this.Timer1.Enabled = true;
        }

        private void UserLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUserLogsGrid frmUserLogsGrid = new frmUserLogsGrid();
            //if (Common.CanUseForm(Conversions.ToString(frmUserLogsGrid.Tag), false))
            //{
            //    frmUserLogsGrid.Icon = base.Icon;
            //    frmUserLogsGrid.MdiParent = this;
            //    frmUserLogsGrid.Show();
            //}
        }
        private void cbLookup_TextChanged(object sender, EventArgs e)
        {
            //if (Operators.CompareString(this.cbLookup.Text, "", false) == 0)
            //{
            //    this.cbLookupData.Text = "";
            //}
        }

        private void NoteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmHistoryType frmHistoryType = new frmHistoryType();
            //if (Common.CanUseForm(Conversions.ToString(frmHistoryType.Tag), false))
            //{
            //    frmHistoryType.Icon = base.Icon;
            //    frmHistoryType.ShowDialog();
            //}
        }

        private void TaskTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTaskType frmTaskType = new frmTaskType();
            //if (Common.CanUseForm(Conversions.ToString(frmTaskType.Tag), false))
            //{
            //    frmTaskType.Icon = base.Icon;
            //    frmTaskType.ShowDialog();
            //}
        }

        private void LookupFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmLookupFields frmLookupFields = new frmLookupFields();
            //if (Common.CanUseForm(Conversions.ToString(frmLookupFields.Tag), false))
            //{
            //    frmLookupFields.Icon = base.Icon;
            //    frmLookupFields.ShowDialog();
            //}
        }

        private void ImportsProspectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmImport frmImport = new frmImport();
            //if (Common.CanUseForm(Conversions.ToString(frmImport.Tag), false))
            //{
            //    frmImport.Icon = base.Icon;
            //    frmImport.ShowDialog();
            //}
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Timer2.Enabled = false;

            ////////////////////////////////////if (Common.BitScalar("select CRMDataLoad from CompanyControl", false))
            ////////////////////////////////////{
            ////////////////////////////////////    this.Timer3.Enabled = true;

            ////////////////////////////////////    Interaction.MsgBox("System maintenance underway you must exit the application.", MsgBoxStyle.OkOnly, "System Maintenance");

            ////////////////////////////////////    base.Close();
            ////////////////////////////////////}

            ////////////////////////////////////this.Timer2.Enabled = true;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            //////////////////////////////////////ProjectData.EndApp();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPasswordChange frmPasswordChange = new frmPasswordChange();
            //if (Common.CanUseForm(Conversions.ToString(frmPasswordChange.Tag), false))
            //{
            //    frmPasswordChange.Icon = base.Icon;
            //    frmPasswordChange.ShowDialog();
            //}
        }

        private void DropDownsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDropDowns frmDropDowns = new frmDropDowns();
            //if (Common.CanUseForm(Conversions.ToString(frmDropDowns.Tag), false))
            //{
            //    frmDropDowns.Icon = base.Icon;
            //    frmDropDowns.ShowDialog();
            //}
        }

        private void cbLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.cbLookup.Focused)
            //{
            //    this.FillLookupData(Conversions.ToString(this.cbLookup.SelectedValue));
            //}
        }

        internal static uint ComputeStringHash(string s)
        {
            uint num = 0;
            if (s != null)
            {
                num = 2166136261U;
                for (int index = 0; index < s.Length; ++index)
                    num = (uint)((s[index] ^ (int)num) * 16777619);
            }
            return num;
        }


        private void FillLookupData(string LookupValue)
        {
            //string left = Common.StrScalar("select FieldType from CRMLookupFields where FieldName = '" + LookupValue + "'", false);
            //if (Operators.CompareString(left, "TEXT", false) != 0)
            //{
            //    if (Operators.CompareString(left, "COMB", false) == 0)
            //    {
            //        uint num = ComputeStringHash(LookupValue);
            //        if (num <= 2827817063u)
            //        {
            //            if (num <= 1805450078u)
            //            {
            //                if (num <= 415739499u)
            //                {
            //                    if (num != 173083532u)
            //                    {
            //                        if (num == 415739499u)
            //                        {
            //                            if (Operators.CompareString(LookupValue, "SICCode", false) == 0)
            //                            {
            //                                idComboBox cbLookupData = this.cbLookupData;
            //                                Common.FillCombo(ref cbLookupData, "select distinct SICCode from CRMCompany order by SICCode", "SICCode", "NONE");
            //                                this.cbLookupData = cbLookupData;
            //                            }
            //                        }
            //                    }
            //                    else if (Operators.CompareString(LookupValue, "ManageUserID", false) == 0)
            //                    {
            //                        idComboBox cbLookupData = this.cbLookupData;
            //                        Common.FillCombo(ref cbLookupData, "select UserID from ManageUserCombo order by UserID", "UserID", "NONE");
            //                        this.cbLookupData = cbLookupData;
            //                    }
            //                }
            //                else if (num != 502047894u)
            //                {
            //                    if (num == 1805450078u)
            //                    {
            //                        if (Operators.CompareString(LookupValue, "Competition2", false) == 0)
            //                        {
            //                            idComboBox cbLookupData = this.cbLookupData;
            //                            Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Competition 2' order by Name", "Name", "NONE");
            //                            this.cbLookupData = cbLookupData;
            //                        }
            //                    }
            //                }
            //                else if (Operators.CompareString(LookupValue, "State", false) == 0)
            //                {
            //                    idComboBox cbLookupData = this.cbLookupData;
            //                    Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'States' order by Name", "Name", "NONE");
            //                    this.cbLookupData = cbLookupData;
            //                }
            //            }
            //            else if (num <= 2422945378u)
            //            {
            //                if (num != 2115578328u)
            //                {
            //                    if (num == 2422945378u)
            //                    {
            //                        if (Operators.CompareString(LookupValue, "City", false) == 0)
            //                        {
            //                            idComboBox cbLookupData = this.cbLookupData;
            //                            Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Cities' order by Name", "Name", "NONE");
            //                            this.cbLookupData = cbLookupData;
            //                        }
            //                    }
            //                }
            //                else if (Operators.CompareString(LookupValue, "Competition", false) == 0)
            //                {
            //                    idComboBox cbLookupData = this.cbLookupData;
            //                    Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Competition' order by Name", "Name", "NONE");
            //                    this.cbLookupData = cbLookupData;
            //                }
            //            }
            //            else if (num != 2423721063u)
            //            {
            //                if (num == 2827817063u)
            //                {
            //                    if (Operators.CompareString(LookupValue, "CreateUserID", false) == 0)
            //                    {
            //                        idComboBox cbLookupData = this.cbLookupData;
            //                        Common.FillCombo(ref cbLookupData, "select UserID from ManageUserCombo order by UserID", "UserID", "NONE");
            //                        this.cbLookupData = cbLookupData;
            //                    }
            //                }
            //            }
            //            else if (Operators.CompareString(LookupValue, "Department", false) == 0)
            //            {
            //                idComboBox cbLookupData = this.cbLookupData;
            //                Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Departments' order by Name", "Name", "NONE");
            //                this.cbLookupData = cbLookupData;
            //            }
            //        }
            //        else if (num <= 3462902463u)
            //        {
            //            if (num <= 2947802513u)
            //            {
            //                if (num != 2884173501u)
            //                {
            //                    if (num == 2947802513u)
            //                    {
            //                        if (Operators.CompareString(LookupValue, "Category", false) == 0)
            //                        {
            //                            idComboBox cbLookupData = this.cbLookupData;
            //                            Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Company ID/Status' order by Name", "Name", "NONE");
            //                            this.cbLookupData = cbLookupData;
            //                        }
            //                    }
            //                }
            //                else if (Operators.CompareString(LookupValue, "ConStatus", false) == 0)
            //                {
            //                    idComboBox cbLookupData = this.cbLookupData;
            //                    Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Contact ID/Status' order by Name", "Name", "NONE");
            //                    this.cbLookupData = cbLookupData;
            //                }
            //            }
            //            else if (num != 3376168378u)
            //            {
            //                if (num == 3462902463u)
            //                {
            //                    if (Operators.CompareString(LookupValue, "Equipment2", false) == 0)
            //                    {
            //                        idComboBox cbLookupData = this.cbLookupData;
            //                        Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Equipment 2' order by Name", "Name", "NONE");
            //                        this.cbLookupData = cbLookupData;
            //                    }
            //                }
            //            }
            //            else if (Operators.CompareString(LookupValue, "JobTitle", false) == 0)
            //            {
            //                idComboBox cbLookupData = this.cbLookupData;
            //                Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'jobtitles' order by Name", "Name", "NONE");
            //                this.cbLookupData = cbLookupData;
            //            }
            //        }
            //        else if (num <= 4017444449u)
            //        {
            //            if (num != 3512062061u)
            //            {
            //                if (num == 4017444449u)
            //                {
            //                    if (Operators.CompareString(LookupValue, "Classification", false) == 0)
            //                    {
            //                        idComboBox cbLookupData = this.cbLookupData;
            //                        Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Classification' order by Name", "Name", "NONE");
            //                        this.cbLookupData = cbLookupData;
            //                    }
            //                }
            //            }
            //            else if (Operators.CompareString(LookupValue, "Type", false) == 0)
            //            {
            //                idComboBox cbLookupData = this.cbLookupData;
            //                Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Type' order by Name", "Name", "NONE");
            //                this.cbLookupData = cbLookupData;
            //            }
            //        }
            //        else if (num != 4104324905u)
            //        {
            //            if (num == 4222088599u)
            //            {
            //                if (Operators.CompareString(LookupValue, "Equipment", false) == 0)
            //                {
            //                    idComboBox cbLookupData = this.cbLookupData;
            //                    Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Equipment' order by Name", "Name", "NONE");
            //                    this.cbLookupData = cbLookupData;
            //                }
            //            }
            //        }
            //        else if (Operators.CompareString(LookupValue, "ReferredBy", false) == 0)
            //        {
            //            idComboBox cbLookupData = this.cbLookupData;
            //            Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Refered By' order by Name", "Name", "NONE");
            //            this.cbLookupData = cbLookupData;
            //        }
            //        this.cbLookupData.Text = "";
            //    }
            //}
            //else
            //{
            //    this.cbLookupData.DataSource = null;
            //}
            //if (Operators.CompareString(LookupValue, "AssignmentDate", false) == 0)
            //{
            //    this.ckPartial.CheckState = CheckState.Unchecked;
            //    this.ckPartial.Enabled = false;
            //    return;
            //}
            //this.ckPartial.Enabled = true;
        }

        private void cbLookupData_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnFind;
        }

        private void ApplicationControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmApplicationControl frmApplicationControl = new frmApplicationControl();
            //if (Common.CanUseForm(Conversions.ToString(frmApplicationControl.Tag), false))
            //{
            //    frmApplicationControl.Icon = base.Icon;
            //    frmApplicationControl.ShowDialog();
            //}
        }

        private void ToDo_Tick(object sender, EventArgs e)
        {
            //clsEmailTracker.TrackEmail();
            //this.ToDoPopup.Enabled = false;
            //if (this.HoldCount >= 10)
            //{
            //    Common.NonQuery("update CRMTasks set OnHold = 'False' where ManageUserID = '" + Common.IRUser + "'", false);
            //    this.HoldCount = 0;
            //}
            //if (Common.IntScalar(string.Concat(new string[]
            //{
            //    "select count(*) from CRMTasks where ReminderTime <= '",
            //    Conversions.ToString(DateTime.Now),
            //    "' and ManageUserID = '",
            //    Common.IRUser,
            //    "' and OnHold = 'False' and TaskType = 2 and Deleted = 'False'"
            //}), false) > 0)
            //{
            //    new frmToDoPopup
            //    {
            //        Icon = base.Icon
            //    }.ShowDialog();
            //}
            //checked
            //{
            //    this.HoldCount++;
            //    this.ToDoPopup.Enabled = true;
            //}
        }

        private void MyPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPreferences frmPreferences = new frmPreferences();
            //if (Common.CanUseForm(Conversions.ToString(frmPreferences.Tag), false))
            //{
            //    frmPreferences.Icon = base.Icon;
            //    frmPreferences.ShowDialog();
            //}
        }

        private void ckAllTasks_CheckedChanged(object sender, EventArgs e)
        {
            //Form[] mdiChildren = base.MdiChildren;
            //checked
            //{
            //    for (int i = 0; i < mdiChildren.Length; i++)
            //    {
            //        Form form = mdiChildren[i];
            //        if (Operators.CompareString(form.Name, MyProject.Forms.frmTasks.Name, false) == 0)
            //        {
            //            frmTasks expr_32 = (frmTasks)form;
            //            expr_32.LoadGrid();
            //            expr_32.BringToFront();
            //            return;
            //        }
            //    }
            //}
        }

        private void SalesTotalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRptSalesTotals frmRptSalesTotals = new frmRptSalesTotals();
            //if (Common.CanUseForm(Conversions.ToString(frmRptSalesTotals.Tag), false))
            //{
            //    frmRptSalesTotals.Icon = base.Icon;
            //    frmRptSalesTotals.ShowDialog();
            //}
        }

        private void cbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (this.frmShowing == 4)
            //    {
            //        Form[] mdiChildren = base.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmTasks.Name, false) == 0)
            //            {
            //                frmTasks frmTasks = (frmTasks)form;
            //                if (Common.CanUseForm("SEE_ALL_TASKS", true))
            //                {
            //                    frmTasks.RecordManager = this.cbTasks.Text;
            //                }
            //                frmTasks.LoadGrid();
            //                frmTasks.BringToFront();
            //                return;
            //            }
            //        }
            //    }
            //}
        }

        private void cbCalendar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (this.cbCalendar.Focused && this.frmShowing == 5)
            //    {
            //        Form[] mdiChildren = base.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmCalendar.Name, false) == 0)
            //            {
            //                frmCalendar frmCalendar = (frmCalendar)form;
            //                if (Common.CanUseForm("SEE_ALL_TASKS", true))
            //                {
            //                    frmCalendar.RecordManager = this.cbCalendar.Text;
            //                }
            //                frmCalendar.AreaManager = "";
            //                frmCalendar.GetCalendarItems();
            //                frmCalendar.BringToFront();
            //                return;
            //            }
            //        }
            //    }
            //}
        }

        private void LastLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AdvancedFind(true);
        }
        private void DataLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmDataLoad().ShowDialog();
        }

        private void ForewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (Common.LastContactPosition + 1 <= 4 && Common.LastContacts[Common.LastContactPosition + 1] != 0)
            //    {
            //        if (Common.LaptopMonitor)
            //        {
            //            Form[] mdiChildren = base.MdiChildren;

            //            for (int i = 0; i < mdiChildren.Length; i++)
            //            {
            //                Form form = mdiChildren[i];

            //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                {
            //                    frmContactLaptop expr_58 = (frmContactLaptop)form;

            //                    expr_58.ContactID = Common.LastContacts[Common.LastContactPosition + 1];
            //                    expr_58.CompanyCount = 1;
            //                    expr_58.TaskID = Common.LastTask[Common.LastContactPosition + 1];
            //                    expr_58.MovingBack = 2;

            //                    clsContacts.RefreshData(false);
            //                    expr_58.BringToFrontHelper();

            //                    return;
            //                }
            //            }

            //            return;
            //        }

            //        Form[] mdiChildren2 = base.MdiChildren;

            //        for (int j = 0; j < mdiChildren2.Length; j++)
            //        {
            //            Form form2 = mdiChildren2[j];

            //            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //            {
            //                frmContact expr_DA = (frmContact)form2;

            //                expr_DA.ContactID = Common.LastContacts[Common.LastContactPosition + 1];
            //                expr_DA.CompanyCount = 1;
            //                expr_DA.TaskID = Common.LastTask[Common.LastContactPosition + 1];
            //                expr_DA.MovingBack = 2;

            //                clsContacts.RefreshData(false);
            //                expr_DA.BringToFrontHelper();

            //                return;
            //            }
            //        }
            //    }
            //}
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (Common.LastContactPosition != 0 && Common.LastContacts[Common.LastContactPosition] != 0)
            //    {
            //        if (Common.LaptopMonitor)
            //        {
            //            Form[] mdiChildren = base.MdiChildren;
            //            for (int i = 0; i < mdiChildren.Length; i++)
            //            {
            //                Form form = mdiChildren[i];

            //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                {
            //                    frmContactLaptop expr_53 = (frmContactLaptop)form;

            //                    expr_53.ContactID = Common.LastContacts[Common.LastContactPosition - 1];
            //                    expr_53.CompanyCount = 1;
            //                    expr_53.TaskID = Common.LastTask[Common.LastContactPosition - 1];
            //                    expr_53.MovingBack = 1;

            //                    clsContacts.RefreshData(false);
            //                    expr_53.BringToFrontHelper();

            //                    return;
            //                }
            //            }
            //            return;
            //        }
            //        Form[] mdiChildren2 = base.MdiChildren;
            //        for (int j = 0; j < mdiChildren2.Length; j++)
            //        {
            //            Form form2 = mdiChildren2[j];

            //            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //            {
            //                frmContact expr_D5 = (frmContact)form2;

            //                expr_D5.ContactID = Common.LastContacts[Common.LastContactPosition - 1];
            //                expr_D5.CompanyCount = 1;
            //                expr_D5.TaskID = Common.LastTask[Common.LastContactPosition - 1];
            //                expr_D5.MovingBack = 1;

            //                clsContacts.RefreshData(false);
            //                expr_D5.BringToFrontHelper();

            //                return;
            //            }
            //        }
            //    }
            //}
        }

        private void CallReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRptCall frmRptCall = new frmRptCall();
            //if (Common.CanUseForm(Conversions.ToString(frmRptCall.Tag), false))
            //{
            //    frmRptCall.Icon = base.Icon;
            //    frmRptCall.ShowDialog();
            //}
        }

        private void RefreshCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (this.frmShowing == 1)
            //    {
            //        object instance = null;

            //        if (Common.LaptopMonitor)
            //        {
            //            Form[] mdiChildren = base.MdiChildren;

            //            for (int i = 0; i < mdiChildren.Length; i++)
            //            {
            //                Form form = mdiChildren[i];

            //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                {
            //                    instance = new frmContactLaptop();
            //                    instance = form;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Form[] mdiChildren2 = base.MdiChildren;

            //            for (int j = 0; j < mdiChildren2.Length; j++)
            //            {
            //                Form form2 = mdiChildren2[j];

            //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                {
            //                    instance = new frmContact();
            //                    instance = form2;
            //                }
            //            }
            //        }
            //        try
            //        {
            //            NewLateBinding.LateCall(instance, null, "Updatepage", new object[0], null, null, null, true);
            //            clsContacts.RefreshData(true);
            //        }
            //        catch (Exception expr_BE)
            //        {
            //            ProjectData.SetProjectError(expr_BE);
            //            ProjectData.ClearProjectError();
            //        }
            //    }
            //}
        }

        private void OpenRMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.frmShowing = 1;
            //this.SetupLookup();
            //Form[] mdiChildren = base.MdiChildren;
            //checked
            //{
            //    for (int i = 0; i < mdiChildren.Length; i++)
            //    {
            //        Form form = mdiChildren[i];
            //        //form.Text = string.Empty;

            //        if (Operators.CompareString(form.Name, MyProject.Forms.frmOpenRMA.Name, false) == 0)
            //        {
            //            frmOpenRMA expr_3F = (frmOpenRMA)form;
            //            expr_3F.LoadGrid();
            //            expr_3F.BringToFront();
            //            return;
            //        }
            //    }
            //    frmOpenRMA frmOpenRMA = new frmOpenRMA();
            //    if (Common.CanUseForm(Conversions.ToString(frmOpenRMA.Tag), false))
            //    {
            //        // frmOpenRMA.Text = string.Empty;

            //        frmOpenRMA.MdiParent = this;
            //        frmOpenRMA.Icon = base.Icon;
            //        frmOpenRMA.Show();
            //        //frmOpenRMA.BringToFrontHelper();
            //    }
            //}
        }

        private void OpenQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmShowing = 1;
            this.SetupLookup();
            Form[] mdiChildren = base.MdiChildren;
            checked
            {
                //for (int i = 0; i < mdiChildren.Length; i++)
                //{
                //    Form form = mdiChildren[i];
                //    if (Operators.CompareString(form.Name, MyProject.Forms.frmOpenQuote.Name, false) == 0)
                //    {
                //        frmOpenQuote expr_3F = (frmOpenQuote)form;
                //        expr_3F.LoadGrid();
                //        expr_3F.BringToFront();
                //        return;
                //    }
                //}
                //frmOpenQuote frmOpenQuote = new frmOpenQuote();
                //if (Common.CanUseForm(Conversions.ToString(frmOpenQuote.Tag), false))
                //{
                //    frmOpenQuote.MdiParent = this;
                //    frmOpenQuote.Icon = base.Icon;
                //    frmOpenQuote.Show();
                //}
            }
        }

        private void PickupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmShowing = 1;
            this.SetupLookup();
            Form[] mdiChildren = base.MdiChildren;
            checked
            {
                //for (int i = 0; i < mdiChildren.Length; i++)
                //{
                //    Form form = mdiChildren[i];
                //    if (Operators.CompareString(form.Name, MyProject.Forms.frmPickups.Name, false) == 0)
                //    {
                //        frmPickups expr_3F = (frmPickups)form;
                //        expr_3F.LoadGrid();
                //        expr_3F.BringToFront();
                //        return;
                //    }
                //}
                //frmPickups frmPickups = new frmPickups();
                //if (Common.CanUseForm(Conversions.ToString(frmPickups.Tag), false))
                //{
                //    frmPickups.MdiParent = this;
                //    frmPickups.Icon = base.Icon;
                //    frmPickups.Show();
                //}
            }
        }

        private void DeleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //object instance = null;
            //checked
            //{
            //    if (Common.LaptopMonitor)
            //    {
            //        Form[] mdiChildren = base.MdiChildren;

            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];

            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //            {
            //                instance = new frmContactLaptop();
            //                instance = form;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Form[] mdiChildren2 = base.MdiChildren;

            //        for (int j = 0; j < mdiChildren2.Length; j++)
            //        {
            //            Form form2 = mdiChildren2[j];

            //            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //            {
            //                instance = new frmContact();
            //                instance = form2;
            //            }
            //        }
            //    }

            //    NewLateBinding.LateCall(instance, null, "Updatepage", new object[0], null, null, null, true);

            //    if (Common.CanUseForm("DELETE CONTACT", true) && Interaction.MsgBox("This will delete the currently displayed contact.\rTHIS CANNOT BE UNDONE!\rAre you sure?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, "Delete Contact") == MsgBoxResult.Yes)
            //    {
            //        int num = Common.IntScalar(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(*) from CRMContact where CompanyID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
            //        if (num == 1)
            //        {
            //            if (Interaction.MsgBox("This is the only contact for this company do you want to delete the company as well?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Delete Company") != MsgBoxResult.Yes)
            //            {
            //                Interaction.MsgBox("Sorry you cannot have a company with no contacts. Delete contact not allowed.", MsgBoxStyle.OkOnly, null);
            //                return;
            //            }
            //            Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from CRMContact where ContactID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
            //            Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from CRMCompany where CompanyID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
            //        }
            //        else
            //        {
            //            Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from CRMContact where ContactID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
            //        }
            //    }
            //    clsContacts.RefreshData(false);
            //}
        }

        private void TodaysActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTodaysActivities frmTodaysActivities = new frmTodaysActivities();
            //if (Common.CanUseForm(Conversions.ToString(frmTodaysActivities.Tag), false))
            //{
            //    frmTodaysActivities.Icon = base.Icon;
            //    frmTodaysActivities.ShowDialog();
            //}
        }

        private void SalesRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMapSalesRoute frmMapSalesRoute = new frmMapSalesRoute();
            //if (Common.CanUseForm(Conversions.ToString(frmMapSalesRoute.Tag), false))
            //{
            //    frmMapSalesRoute.Icon = base.Icon;
            //    frmMapSalesRoute.ShowDialog();
            //}
        }

        private void CurrentCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (Common.CanUseForm("MAPPING", false))
            //    {
            //        this.frmShowing = 6;
            //        Form[] mdiChildren = base.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmMainMap.Name, false) == 0)
            //            {
            //                frmMainMap frmMainMap = new frmMainMap();
            //                frmMainMap = (frmMainMap)form;
            //                if (Common.LaptopMonitor)
            //                {
            //                    new frmContactLaptop();

            //                    Form[] mdiChildren2 = base.MdiChildren;

            //                    for (int j = 0; j < mdiChildren2.Length; j++)
            //                    {
            //                        Form form2 = mdiChildren2[j];

            //                        if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                        {
            //                            string arg_AB_0 = ((frmContactLaptop)form2).txtCompanyID.Text;
            //                            break;
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    new frmContact();

            //                    Form[] mdiChildren3 = base.MdiChildren;

            //                    for (int k = 0; k < mdiChildren3.Length; k++)
            //                    {
            //                        Form form3 = mdiChildren3[k];

            //                        if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                        {
            //                            string arg_107_0 = ((frmContact)form3).txtCompanyID.Text;

            //                            break;
            //                        }
            //                    }
            //                }
            //                frmMainMap.Close();
            //            }
            //        }

            //        object instance = null;

            //        if (Common.LaptopMonitor)
            //        {
            //            Form[] mdiChildren4 = base.MdiChildren;

            //            for (int l = 0; l < mdiChildren4.Length; l++)
            //            {
            //                Form form4 = mdiChildren4[l];

            //                if (Operators.CompareString(form4.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                {
            //                    instance = new frmContactLaptop();
            //                    instance = form4;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Form[] mdiChildren5 = base.MdiChildren;

            //            for (int m = 0; m < mdiChildren5.Length; m++)
            //            {
            //                Form form5 = mdiChildren5[m];

            //                if (Operators.CompareString(form5.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                {
            //                    instance = new frmContact();
            //                    instance = form5;
            //                }
            //            }
            //        }

            //        this.Cursor = Cursors.WaitCursor;
            //        this.frmShowing = 6;
            //        this.SetupLookup();

            //        frmMainMap frmMainMap2 = new frmMainMap();

            //        if (Common.CanUseForm(Conversions.ToString(frmMainMap2.Tag), false))
            //        {
            //            frmMainMap2.MdiParent = this;
            //            frmMainMap2.CompanyID = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //            frmMainMap2.MapType = "Company Location";
            //            frmMainMap2.Icon = base.Icon;

            //            frmMainMap2.Show();

            //            this.Cursor = Cursors.Default;
            //        }
            //    }
            //}
        }

        private void cbLookup_Leave(object sender, EventArgs e)
        {
            //if (Conversions.ToBoolean(Operators.OrObject(Operators.AndObject(Operators.CompareObjectEqual(this.cbLookup.SelectedValue, "", false), Operators.CompareString(this.cbLookup.Text, "", false) != 0), Operators.CompareString(Strings.LCase(this.cbLookup.Text), "record manager", false) == 0)))
            //{
            //    string lookupValue = Common.StrScalar("select FieldName from CRMLookupFields where DisplayName = '" + this.cbLookup.Text + "'", false);
            //    try
            //    {
            //        this.FillLookupData(lookupValue);
            //    }
            //    catch (Exception expr_92)
            //    {
            //        ProjectData.SetProjectError(expr_92);
            //        ProjectData.ClearProjectError();
            //    }
            //}
        }

        private void UpdateLocalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new frmLoadData().ShowDialog();
        }

        private string SetStatus(bool PartNeeded, DateTime PartNeededDate, bool RT, DateTime RTDate, bool PartsDue, DateTime PartsDueDate, bool RUR, DateTime RURDate, bool PartsRcvd, DateTime PartsRcvdDate, bool Evaluation, DateTime EvaluationDate, DateTime ApprovalDate, bool Approved, bool ReQuote, DateTime ReQuoteDate)
        {
            string result = "REC";
            DateTime[] array = new DateTime[]
            {
                PartNeededDate,
                PartsRcvdDate,
                PartsDueDate,
                RURDate,
                RTDate,
                EvaluationDate,
                ApprovalDate,
                ReQuoteDate
            };
            Array.Sort<DateTime>(array);
            int num = 0;
            checked
            {
                do
                {
                    //if (DateTime.Compare(array[num], Conversions.ToDate("1/1/1900")) != 0)
                    //{
                    //    if (DateTime.Compare(array[num], ApprovalDate) == 0 & Approved)
                    //    {
                    //        result = "APP";
                    //    }
                    //    else if (DateTime.Compare(array[num], EvaluationDate) == 0 & Evaluation)
                    //    {
                    //        result = "EVAL";
                    //    }
                    //    else if (DateTime.Compare(array[num], PartNeededDate) == 0 & PartNeeded)
                    //    {
                    //        result = "P/N";
                    //    }
                    //    else if (DateTime.Compare(array[num], PartsDueDate) == 0 & PartsDue)
                    //    {
                    //        result = "P/D";
                    //    }
                    //    else if (DateTime.Compare(array[num], PartsRcvdDate) == 0 & PartsRcvd)
                    //    {
                    //        result = "P/R";
                    //    }
                    //    else if (DateTime.Compare(array[num], RTDate) == 0 & RT)
                    //    {
                    //        result = "R&T";
                    //    }
                    //    else if (DateTime.Compare(array[num], RURDate) == 0 & RUR)
                    //    {
                    //        result = "RUR";
                    //    }
                    //    else if (DateTime.Compare(array[num], ReQuoteDate) == 0 & ReQuote)
                    //    {
                    //        result = "RQ";
                    //    }
                    //}
                    num++;
                }
                while (num <= 7);
                return result;
            }
        }

        private void IdButton1_Click(object sender, EventArgs e)
        {
            //checked
            //{
            //    if (Common.CanUseForm("MAPPING", false))
            //    {
            //        this.frmShowing = 6;
            //        Form[] mdiChildren = base.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmMainMap.Name, false) == 0)
            //            {
            //                frmMainMap frmMainMap = new frmMainMap();
            //                frmMainMap = (frmMainMap)form;
            //                if (Common.LaptopMonitor)
            //                {
            //                    new frmContactLaptop();

            //                    Form[] mdiChildren2 = base.MdiChildren;

            //                    for (int j = 0; j < mdiChildren2.Length; j++)
            //                    {
            //                        Form form2 = mdiChildren2[j];

            //                        if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                        {
            //                            string arg_A6_0 = ((frmContactLaptop)form2).txtCompanyID.Text;

            //                            break;
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    new frmContact();

            //                    Form[] mdiChildren3 = base.MdiChildren;

            //                    for (int k = 0; k < mdiChildren3.Length; k++)
            //                    {
            //                        Form form3 = mdiChildren3[k];

            //                        if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                        {
            //                            string arg_102_0 = ((frmContact)form3).txtCompanyID.Text;

            //                            break;
            //                        }
            //                    }
            //                }
            //                frmMainMap.BringToFrontHelper();
            //                this.SetupLookup();
            //                return;
            //            }
            //        }

            //        object instance = null;

            //        if (Common.LaptopMonitor)
            //        {
            //            Form[] mdiChildren4 = base.MdiChildren;

            //            for (int l = 0; l < mdiChildren4.Length; l++)
            //            {
            //                Form form4 = mdiChildren4[l];

            //                if (Operators.CompareString(form4.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //                {
            //                    instance = new frmContactLaptop();
            //                    instance = form4;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Form[] mdiChildren5 = base.MdiChildren;

            //            for (int m = 0; m < mdiChildren5.Length; m++)
            //            {
            //                Form form5 = mdiChildren5[m];

            //                if (Operators.CompareString(form5.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //                {
            //                    instance = new frmContact();
            //                    instance = form5;
            //                }
            //            }
            //        }

            //        this.Cursor = Cursors.WaitCursor;
            //        this.frmShowing = 6;
            //        this.SetupLookup();
            //        frmMainMap frmMainMap2 = new frmMainMap();

            //        if (Common.CanUseForm(Conversions.ToString(frmMainMap2.Tag), false))
            //        {
            //            frmMainMap2.MdiParent = this;
            //            frmMainMap2.CompanyID = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //            frmMainMap2.MapType = "Company Location";
            //            frmMainMap2.Icon = base.Icon;
            //            frmMainMap2.Show();
            //            this.Cursor = Cursors.Default;
            //        }
            //    }
            //}
        }

        private void NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //object instance = null;
            //checked
            //{
            //    if (Common.LaptopMonitor)
            //    {
            //        Form[] mdiChildren = base.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];

            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //            {
            //                instance = new frmContactLaptop();
            //                instance = form;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Form[] mdiChildren2 = base.MdiChildren;

            //        for (int j = 0; j < mdiChildren2.Length; j++)
            //        {
            //            Form form2 = mdiChildren2[j];

            //            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //            {
            //                instance = new frmContact();
            //                instance = form2;
            //            }
            //        }
            //    }

            //    int value = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //    int value2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //    string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "cbRecordManager", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //    frmTODONotes frmTODONotes = new frmTODONotes();
            //    frmTODONotes.Icon = base.Icon;
            //    frmTODONotes.Text = "Notes for Francie";
            //    frmTODONotes.ShowDialog();
            //    string text2 = frmTODONotes.txtNotes.Text;

            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "insert into CRMCustIssues (CompanyID, ContactID, ManageUserID, MF, Notes, CreateDate, IssueStatus, CreateUserID) values  (",
            //        Conversions.ToString(value),
            //        ", ",
            //        Conversions.ToString(value2),
            //        ", '",
            //        text,
            //        "', 'F', '",
            //        text2,
            //        "', '",
            //        Conversions.ToString(DateTime.Now),
            //        "', 'False', '",
            //        Common.IRUser,
            //        "')"
            //    }), false);

            //    frmTODONotes.Close();
            //}
        }

        private void NotifyMikeOfCustomerIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //object instance = null;

            //checked
            //{
            //    if (Common.LaptopMonitor)
            //    {
            //        Form[] mdiChildren = base.MdiChildren;

            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];

            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //            {
            //                instance = new frmContactLaptop();
            //                instance = form;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Form[] mdiChildren2 = base.MdiChildren;

            //        for (int j = 0; j < mdiChildren2.Length; j++)
            //        {
            //            Form form2 = mdiChildren2[j];

            //            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //            {
            //                instance = new frmContact();
            //                instance = form2;
            //            }
            //        }
            //    }

            //    int value = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //    int value2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //    string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "cbRecordManager", new object[0], null, null, null), null, "text", new object[0], null, null, null));
            //    frmTODONotes frmTODONotes = new frmTODONotes();
            //    frmTODONotes.Icon = base.Icon;
            //    frmTODONotes.Text = "Notes for Mike";
            //    frmTODONotes.ShowDialog();
            //    string text2 = frmTODONotes.txtNotes.Text;

            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "insert into CRMCustIssues (CompanyID, ContactID, ManageUserID, MF, Notes, CreateDate, IssueStatus, CreateUserID) values  (",
            //        Conversions.ToString(value),
            //        ",  ",
            //        Conversions.ToString(value2),
            //        ", '",
            //        text,
            //        "', 'M', '",
            //        text2,
            //        "', '",
            //        Conversions.ToString(DateTime.Now),
            //        "', 'False', '",
            //        Common.IRUser,
            //        "')"
            //    }), false);

            //    frmTODONotes.Close();
            //}
        }

        private void FranciesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmCustIssues
            //{
            //    Icon = base.Icon,
            //    MdiParent = this,
            //    Text = "Prospects going no where",
            //    MF = "F"
            //}.Show();
        }

        private void MikesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmCustIssues
            //{
            //    Icon = base.Icon,
            //    MdiParent = this,
            //    Text = "Customers with issues",
            //    MF = "M"
            //}.Show();
        }

        private void ProductivityReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmProductivity
            //{
            //    Icon = base.Icon
            //}.ShowDialog();
        }

        private void HorseRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmHorseRace
            //{
            //    Icon = base.Icon
            //}.ShowDialog();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object instance = null;

            checked
            {
                //if (Common.LaptopMonitor)
                //{
                //    Form[] mdiChildren = base.MdiChildren;

                //    for (int i = 0; i < mdiChildren.Length; i++)
                //    {
                //        Form form = mdiChildren[i];

                //        if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
                //        {
                //            instance = new frmContactLaptop();
                //            instance = form;
                //        }
                //    }
                //}
                //else
                //{
                //    Form[] mdiChildren2 = base.MdiChildren;

                //    for (int j = 0; j < mdiChildren2.Length; j++)
                //    {
                //        Form form2 = mdiChildren2[j];

                //        if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
                //        {
                //            instance = new frmContact();
                //            instance = form2;
                //        }
                //    }
                //}


                // V2 - 12/6/2021:
                //////NewLateBinding.LateCall(NewLateBinding.LateGet(instance, null, "txtSport", new object[0], null, null, null), null, "Focus", new object[0], null, null, null, true);
            }
        }

        private void TelemarketerNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmTMNewCust
            //{
            //    Icon = base.Icon
            //}.ShowDialog();
        }

        private void TelemarketerActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmTMActivity
            //{
            //    Icon = base.Icon
            //}.ShowDialog();
        }

        private void SpecialStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    frmPassword expr_05 = new frmPassword();
        //    expr_05.Icon = base.Icon;
        //    expr_05.Text = "Enter Password";
        //    expr_05.ShowDialog();

        //    if (Operators.CompareString(expr_05.txtPassword.Text, "Kmc-159", false) == 0)
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        SqlConnection sqlConnection = new SqlConnection();
        //        sqlConnection = Common.ConnectToSQL(false);
        //        SqlCommand sqlCommand = new SqlCommand("Select TaskID from CRMTasks where CreateUserID = 'REBECCA.FALLON' and CreateDate > = '1/1/2015' and (TaskType = 6 or TaskType = 1 )", sqlConnection);
        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        while (sqlDataReader.Read())
        //        {
        //            long value = Common.Int64Scalar(("select HistoryID From CRMTasks T join CRMHistory H on T.CompanyID = H.CompanyID and T.ContactID = H.ContactID and T.ManageUserID = H.CreateUserID where (t.TaskType = 6 or T.TaskType = 1 ) and (Typeid = 110 or TypeID = 111 or TypeID = 112 or TypeID = 209 or TypeID = 210 or TypeID = 211 or TypeID = 212 or TypeID = 213 or TypeID = 214) and cast( t.StartTime as date) = cast(H.CreateDate as date) and T.TaskID = " + Conversions.ToString(sqlDataReader.GetInt32(0))) ?? "", false);
        //            Common.NonQuery(("update CRMHistory set TaskID = " + Conversions.ToString(sqlDataReader.GetInt32(0)) + " where HistoryID = " + Conversions.ToString(value)) ?? "", false);
        //        }
        //        sqlCommand.Connection.Close();
        //        sqlConnection.Close();
        //        this.Cursor = Cursors.Default;
        //    }
        }

        private void SetVersionNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPassword expr_05 = new frmPassword();
            //expr_05.Icon = base.Icon;
            //expr_05.Text = "Enter Password";
            //expr_05.ShowDialog();
            //if (Operators.CompareString(expr_05.txtPassword.Text, "kmC-159", false) == 0)
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    Common.NonQuery("update CompanyControl set CRMVersion = '" + MyProject.Application.Info.Version.ToString() + "'", false);
            //    this.Cursor = Cursors.Default;
            //}
        }

        private static extern IntPtr LoadLibrary(string libname);


        private static void LoadNativeAssembly(string nativeBinaryPath, string assemblyName)
        {
            var path = Path.Combine(nativeBinaryPath, assemblyName);

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"{path} not found");
            }

            var ptr = LoadLibrary(path);
            if (ptr == IntPtr.Zero)
            {
                throw new Exception(string.Format(
                    "Error loading {0} (ErrorCode: {1})",
                    assemblyName,
                    Marshal.GetLastWin32Error()));
            }
        }

        public static void LoadNativeAssemblies(string rootApplicationPath)
        {
            var nativeBinaryPath = Environment.Is64BitProcess
            ? Path.Combine(rootApplicationPath, @"SqlServerTypes\x64\")
            : Path.Combine(rootApplicationPath, @"SqlServerTypes\x86\");

            LoadNativeAssembly(nativeBinaryPath, "msvcr120.dll");
            LoadNativeAssembly(nativeBinaryPath, "SqlServerSpatial140.dll");
        }



















    }
}
