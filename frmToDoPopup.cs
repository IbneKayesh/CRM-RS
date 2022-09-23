using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CRM
{
    public partial class frmToDoPopup : Form
    {
        public frmToDoPopup()
        {
            InitializeComponent();
        }

        private void frmToDoPopup_Load(object sender, EventArgs e)
        {
            this.LoadRecords();
        //    this.cbAlarm.Text = "15 Minutes";
        //    if (this.gridDetail.RowCount == 0)
        //    {
        //        base.Close();
        //    }
        }

        private void LoadRecords()
        {
            //string arg_45_0 = string.Concat(new string[]
            //{
            //    "select TaskID, StartTime as 'Start Time', C.FirstName + ' ' + C.LastName as 'Name', Regarding, T.CreateUserID as 'Created By' from CRMTasks T join CRMContact C on T.ContactID = C.ContactID where ManageUserID = '",
            //    Common.IRUser,
            //    "' and  ReminderTime <= '",
            //    Conversions.ToString(DateTime.Now),
            //    "' and TaskType = 2 and OnHold = 'False' and Deleted = 'False'"
            //});
            //DataTable dataTable = new DataTable();
            //new SqlDataAdapter();
            //Common.GetGridData(arg_45_0, false).Fill(dataTable);
            //new DataView(dataTable);
            //this.gridDetail.DataSource = dataTable;
            //this.gridDetail.Columns[0].Visible = false;
            //this.gridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //this.Timer1.Enabled = true;
        }

        private void MarkAsCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int index = this.gridDetail.CurrentRow.Index;
            //clsSO.CompleteTaskSimple(Conversions.ToInteger(this.gridDetail[0, index].Value));
            //this.LoadRecords();
            //if (this.gridDetail.RowCount < 1)
            //{
            //    base.Close();
            //}
        }

        private void PostponeUntilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int index = this.gridDetail.CurrentRow.Index;
            //int num = Conversions.ToInteger(this.gridDetail[0, index].Value);
            //frmScheduleActivity frmScheduleActivity = new frmScheduleActivity("TASK");
            //if (Common.CanUseForm(Conversions.ToString(frmScheduleActivity.Tag), false))
            //{
            //    frmScheduleActivity.Icon = MyProject.Forms.frmMain.Icon;
            //    frmScheduleActivity.TaskID = num;
            //    frmScheduleActivity.ShowDialog();
            //    frmScheduleActivity.Close();
            //    this.Timer1.Enabled = true;
            //}
        }

        private void OpenContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.gridDetail.CurrentRow.Index == -1)
            //    {
            //        return;
            //    }
            //}
            //catch (Exception expr_1A)
            //{
            //    ProjectData.SetProjectError(expr_1A);
            //    ProjectData.ClearProjectError();
            //    return;
            //}
            //int index = this.gridDetail.CurrentRow.Index;
            //int num = Conversions.ToInteger(this.gridDetail[0, index].Value);
            //int contactID = Common.IntScalar(("Select ContactID, CompanyID from CRMTasks where TaskID = " + Conversions.ToString(num)) ?? "", false);
            //checked
            //{
            //    if (Common.LaptopMonitor)
            //    {
            //        Form[] mdiChildren = MyProject.Forms.frmMain.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //            {
            //                frmContactLaptop expr_C0 = (frmContactLaptop)form;
            //                expr_C0.ContactID = contactID;
            //                expr_C0.CompanyCount = 1;
            //                expr_C0.TaskID = num;
            //                clsContacts.RefreshData(false);
            //                expr_C0.BringToFrontHelper();
            //                Common.NonQuery(("update CRMTasks set OnHold = 'True' where TaskID = " + Conversions.ToString(num)) ?? "", false);
            //                base.Close();
            //                return;
            //            }
            //        }
            //        return;
            //    }
            //    Form[] mdiChildren2 = MyProject.Forms.frmMain.MdiChildren;
            //    for (int j = 0; j < mdiChildren2.Length; j++)
            //    {
            //        Form form2 = mdiChildren2[j];
            //        if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //        {
            //            frmContact expr_15B = (frmContact)form2;
            //            expr_15B.ContactID = contactID;
            //            expr_15B.CompanyCount = 1;
            //            expr_15B.TaskID = num;
            //            clsContacts.RefreshData(false);
            //            expr_15B.BringToFrontHelper();
            //            Common.NonQuery(("update CRMTasks set OnHold = 'True' where TaskID = " + Conversions.ToString(num)) ?? "", false);
            //            base.Close();
            //            return;
            //        }
            //    }
            //}
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //string text = Strings.LCase(this.cbAlarm.Text);
            //text = Strings.Replace(text, "minutes", "", 1, -1, CompareMethod.Binary);
            //DateTime value = DateAndTime.DateAdd(DateInterval.Minute, (double)Conversions.ToInteger(text), DateTime.Now);
            //Common.NonQuery(string.Concat(new string[]
            //{
            //    "update CRMTasks set ReminderTime = '",
            //    Conversions.ToString(value),
            //    "'  where ReminderTime is not null and ManageUserID = '",
            //    Common.IRUser,
            //    "' and  ReminderTime <= '",
            //    Conversions.ToString(DateTime.Now),
            //    "' and TaskType = 2 and Deleted = 'False'"
            //}), false);
            base.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.LoadRecords();
        }

        private void gridDetail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            //    DataGridView.HitTestInfo hitTestInfo = this.gridDetail.HitTest(e.X, e.Y);
            //    this.gridDetail.ClearSelection();
            //    this.gridDetail.Rows[hitTestInfo.RowIndex].Selected = true;
            //    DataGridViewCell currentCell = this.gridDetail[1, hitTestInfo.RowIndex];
            //    this.gridDetail.CurrentCell = currentCell;
            }
        }
    }
}
