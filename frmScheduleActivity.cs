using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM
{
    public partial class frmScheduleActivity : Form
    {
        public string ScheduleFrom;

        public object TaskID;

        public DateTime StartTime;

        public int ContactID;

        public string RecordManager;

        private bool NewRecord;

        private string tmpFileName;

        private string RealFilename;

        private int tmpWeeks;

        public frmScheduleActivity(string SchFrm)
        {
            this.TaskID = 0;
            this.NewRecord = false;
            this.tmpFileName = "";
            this.RealFilename = "";
            InitializeComponent();
            this.ScheduleFrom = SchFrm;
        }

        private void frmScheduleActivity_Load(object sender, EventArgs e)
        {
            this.NewRecord = false;
            //this.CRMTaskColorTableAdapter.Fill(this.IRDataSet.CRMTaskColor);
            //if (Common.CanUseForm("SCHEDULETASKFOROTHERS", true))
            //{
            //    this.btnSchedule.Visible = true;
            //}
            //else
            //{
            //    this.btnSchedule.Visible = false;
            //}
            //if (Operators.ConditionalCompareObjectEqual(this.TaskID, 0, false))
            //{
            //    this.NewRecord = true;
            //    this.btnDelete.Visible = false;
            //    this.TaskID = Common.AddNewTask();
            //}
            //if (this.NewRecord)
            //{
            //    this.CRMTasksTableAdapter.FillByTaskID(this.IRDataSet.CRMTasks, Conversions.ToInteger(this.TaskID));
            //    if (Operators.CompareString(this.ScheduleFrom, "TASK", false) == 0)
            //    {
            //        idComboBox cbType = this.cbType;
            //        Common.FillCombo(ref cbType, "Select upper(Name) as 'Name', GroupID from CRMHistoryTypeGroup where SuperGroupID = 1 and Name <> 'NOTE' and GroupID <= 2 order by Name", "Name", "GroupID");
            //        this.cbType = cbType;
            //    }
            //    else
            //    {
            //        idComboBox cbType = this.cbType;
            //        Common.FillCombo(ref cbType, "Select upper(Name) as 'Name', GroupID from CRMHistoryTypeGroup where SuperGroupID = 1 and GroupID >= 5 and GroupID <= 7 order by Name", "Name", "GroupID");
            //        this.cbType = cbType;
            //    }
            //}
            //else
            //{
            //    if (Common.CanUseForm("DELETE_TASK", true))
            //    {
            //        this.btnDelete.Visible = true;
            //    }
            //    else
            //    {
            //        this.btnDelete.Visible = false;
            //    }
            //    idComboBox cbType = this.cbType;
            //    Common.FillCombo(ref cbType, "Select upper(Name) as 'Name', GroupID from CRMHistoryTypeGroup where SuperGroupID = 1 and Name <> 'NOTE' order by Name", "Name", "GroupID");
            this.cbType = cbType;
            this.cbType.Enabled = false;
            //    this.CRMTasksTableAdapter.FillByTaskID(this.IRDataSet.CRMTasks, Conversions.ToInteger(this.TaskID));
            //    Common.LogEntryCRM(base.Name, "OPEN TASK", Conversions.ToInteger(this.txtCompanyID.Text), Conversions.ToInteger(this.txtContactID.Text), Conversions.ToString(Operators.ConcatenateObject("TASK ", this.TaskID)));
            //}
            //if (Common.IntScalar(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(*) from CRMTasks where DeleteDate is not null and TaskID = ", this.TaskID), "")), false) > 0)
            //{
            //    this.cbColor.Enabled = false;
            //}
            //if (Operators.CompareString(this.txtCompanyID.Text, "", false) == 0)
            //{
            //    this.txtCompanyID.Text = Conversions.ToString(Common.IntScalar(("select CompanyID from CRMContact where ContactID = " + Conversions.ToString(this.ContactID)) ?? "", false));
            //}
            //if (this.NewRecord)
            //{
            //    this.txtRecordManager.Text = this.RecordManager;
            //    this.dtStartTime.EditValue = this.StartTime;
            //    this.cbPriority.Text = "LOW";
            //    if (this.ContactID != 0)
            //    {
            //        this.txtContactID.Text = Conversions.ToString(this.ContactID);
            //        this.cbContact.Text = Common.StrScalar(("select Name from CRMContactList where ContactID = " + this.txtContactID.Text) ?? "", false);
            //        this.cbContact.Enabled = false;
            //    }
            //    else
            //    {
            //        this.CRMContactListTableAdapter.Fill(this.IRDataSetViews.CRMContactList);
            //    }
            //    Common.LogEntryCRM(base.Name, "CREATE TASK", Conversions.ToInteger(this.txtCompanyID.Text), Conversions.ToInteger(this.txtContactID.Text), Conversions.ToString(Operators.ConcatenateObject("TASK ", this.TaskID)));
            //    return;
            //}
            this.cbType.Enabled = false;
            //if (Operators.CompareString(this.txtContactID.Text, "", false) != 0)
            //{
            //    this.cbContact.Text = Common.StrScalar(("select Name from CRMContactList where ContactID = " + this.txtContactID.Text) ?? "", false);
            //    this.cbContact.Enabled = false;
            //}
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //int num;
            //checked
            //{
            //    if (this.cbWeeks.Visible)
            //    {
            //        this.tmpWeeks = (int)Math.Round(unchecked(Conversions.ToDouble(Strings.Mid(this.cbWeeks.Text, 1, 1)) * 7.0));
            //        this.dtStartTime.EditValue = DateAndTime.DateAdd(DateInterval.Day, (double)this.tmpWeeks, DateTime.Today);
            //    }
            //    num = Common.IntScalar(("Select CompanyID from CRMContact where ContactID = " + Conversions.ToString(this.ContactID)) ?? "", false);
            //    if (Operators.CompareString(this.tmpFileName, "", false) != 0)
            //    {
            //        int num2 = Common.IntScalar("select max(DocumentID) from CRMDocuments", false);
            //        while (MyProject.Computer.FileSystem.FileExists(string.Concat(new string[]
            //        {
            //            Common.DocumentPath,
            //            "D",
            //            Conversions.ToString(num2),
            //            "_",
            //            this.RealFilename
            //        })))
            //        {
            //            num2++;
            //        }
            //        if (Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
            //        {
            //            "insert into CRMDocuments (FileName, DisplayName, ActivityID, FilePath, CompanyID, ContactID, DocumentDate) values  (",
            //            Common.NQ("D" + Conversions.ToString(num2) + "_" + this.RealFilename),
            //            ", ",
            //            Common.NQ(this.RealFilename),
            //            ", "
            //        }), this.TaskID), ", "), " "), Common.NQ(string.Concat(new string[]
            //        {
            //            Common.DocumentPath,
            //            "D",
            //            Conversions.ToString(num2),
            //            "_",
            //            this.RealFilename
            //        }))), ", "), num), ", "), this.ContactID), ", '"), DateTime.Now), "')")), false) == 1)
            //        {
            //            try
            //            {
            //                MyProject.Computer.FileSystem.CopyFile(this.tmpFileName, string.Concat(new string[]
            //                {
            //                    Common.DocumentPath,
            //                    "D",
            //                    Conversions.ToString(num2),
            //                    "_",
            //                    this.RealFilename
            //                }));
            //            }
            //            catch (Exception expr_24D)
            //            {
            //                ProjectData.SetProjectError(expr_24D);
            //                ProjectData.ClearProjectError();
            //            }
            //        }
            //    }
            //}
            DateTime value = DateTime.Now;
            //if (this.lblAlarm.Visible && Operators.CompareString(this.cbAlarm.Text, "NONE", false) != 0)
            //{
            //    string text = Strings.LCase(this.cbAlarm.Text);
            //    text = Strings.Replace(text, "minutes", "", 1, -1, CompareMethod.Binary);
            //    value = DateAndTime.DateAdd(DateInterval.Minute, Conversions.ToDouble(text) * -1.0, Conversions.ToDate(this.dtStartTime.EditValue));
            //}
            base.Validate();
            this.CRMTasksBindingSource.EndEdit();
            //this.CRMTasksTableAdapter.Update(this.IRDataSet);
            //Common.LogEntryCRM(base.Name, "SAVE TASK", num, Conversions.ToInteger(this.txtContactID.Text), Conversions.ToString(Operators.ConcatenateObject("TASK ", this.TaskID)));
            //if (this.lblAlarm.Visible)
            //{
            //    if (Operators.CompareString(this.cbAlarm.Text, "NONE", false) != 0)
            //    {
            //        Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update CRMTasks set ReminderTime = '" + Conversions.ToString(value) + "' where TaskID = ", this.TaskID), "")), false);
            //    }
            //    else
            //    {
            //        Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update CRMTasks set ReminderTime = null where TaskID = ", this.TaskID), "")), false);
            //    }
            //}
            base.DialogResult = DialogResult.OK;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void cbContact_Enter(object sender, EventArgs e)
        {
            //idComboBox cbContact = this.cbContact;
            //Common.FillCombo(ref cbContact, "Select Name, ContactID from CRMContactLIst where ManageUserID = ", "Name", "ContactID");
            //this.cbContact = cbContact;
        }
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //   this.txtRecordManager.Text = Common.idComboInput("Select Record Manager", "Select UserID from ManageUserCombo", "UserID", "UserID", "", "", "", "");
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            //MyProject.Forms.frmMain.OpenFileDialog1.Filter = "All Files|*.*";
            //MyProject.Forms.frmMain.OpenFileDialog1.Multiselect = false;
            //if (MyProject.Forms.frmMain.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.tmpFileName = MyProject.Forms.frmMain.OpenFileDialog1.FileName;
            //    this.RealFilename = MyProject.Computer.FileSystem.GetName(this.tmpFileName);
            //    this.txtFileName.Text = this.RealFilename;
            //    return;
            //}
            this.Cursor = Cursors.Default;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = this.cbType.Text;
            //if (Operators.CompareString(text, "CALL", false) == 0)
            //{
            //    this.dtStartTime.Visible = false;
            //    this.cbColor.Visible = false;
            //    this.lblStart.Visible = false;
            //    this.lblColor.Visible = false;
            //    this.lblWeels.Visible = true;
            //    this.cbWeeks.Visible = true;
            //    this.cbWeeks.Text = "4 WEEKS";
            //    this.lblAlarm.Visible = false;
            //    this.cbAlarm.Visible = false;
            //    this.tmpWeeks = checked((int)Math.Round(unchecked(Conversions.ToDouble(Strings.Mid(this.cbWeeks.Text, 1, 1)) * 7.0)));
            //    this.dtStartTime.EditValue = DateAndTime.DateAdd(DateInterval.Day, (double)this.tmpWeeks, DateTime.Today);
            //    return;
            //}
            //if (Operators.CompareString(text, "TO-DO", false) == 0)
            //{
            //    this.dtStartTime.Visible = true;
            //    this.cbColor.Visible = false;
            //    this.lblStart.Visible = true;
            //    this.lblColor.Visible = false;
            //    this.lblWeels.Visible = false;
            //    this.cbWeeks.Visible = false;
            //    this.lblAlarm.Visible = true;
            //    this.cbAlarm.Visible = true;
            //    this.cbAlarm.Text = "15 MINUTES";
            //    return;
            //}
            //if (Operators.CompareString(text, "APPOINTMENT", false) == 0)
            //{
            //    this.dtStartTime.Visible = true;
            //    this.cbColor.Visible = true;
            //    this.lblStart.Visible = true;
            //    this.lblColor.Visible = true;
            //    this.cbColor.Text = "CONFIRMED-RED";
            //    this.lblWeels.Visible = false;
            //    this.cbWeeks.Visible = false;
            //    this.cbAlarm.Visible = false;
            //    this.lblAlarm.Visible = false;
            //    return;
            //}
            //if (Operators.CompareString(text, "VACATION", false) == 0)
            //{
            //    this.cbRegarding.Text = "VACATION";
            //    return;
            //}
            //if (Operators.CompareString(text, "SICK", false) != 0)
            //{
            //    return;
            //}
            this.cbRegarding.Text = "SICK";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("Are you sure you want to delete this task?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Delete Task") == MsgBoxResult.Yes)
            //{
            //    Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Update CRMTasks set Deleted = 'True' where Taskid = ", this.TaskID), "")), false);
            //    Common.LogEntryCRM(base.Name, "DELETE TASK", Conversions.ToInteger(this.txtCompanyID.Text), Conversions.ToInteger(this.txtContactID.Text), Conversions.ToString(Operators.ConcatenateObject("TASK ", this.TaskID)));
            //}
        }
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.txtTaskCode.Text = Conversions.ToString(Common.IntScalar(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select RecordID from CRMTaskColor where TaskColor = '", this.cbColor.SelectedValue), "'")), false));
        }
    }
}
