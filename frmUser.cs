using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CRM
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //if (this.ckActive.CheckState != CheckState.Unchecked || Common.IntScalar("select count(*) from CRMCompany where ManageUserID = '" + this.txtLogin.Text + "'", false) <= 0 || Interaction.MsgBox("This user is still assigned to manage at least one company.  Are you sure you want to make them inactive?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Still Assigned to Company") != MsgBoxResult.No)
            //{
            //    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dtLastTime.EditValue)))
            //    {
            //        Common.LogEntryCRM(base.Name, "ADD ENTRY", 0, 0, this.txtLogin.Text);
            //    }
            //    else
            //    {
            //        Common.LogEntryCRM(base.Name, "UPDATE USER", 0, 0, this.txtLogin.Text);
            //    }
            //    this.dtLastTime.EditValue = Common.GetSQLCurrentTimeDate();
            //    base.Validate();
            //    this.UsersBindingSource.EndEdit();
            //    this.UsersTableAdapter.Update(this.IRDataSet.CRMUsers);
            //    base.Close();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("Are you sure you want to delete this User?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, "Delete ") == MsgBoxResult.Yes)
            //{
            //    Common.NonQuery("Delete from CRMUsers where UserID = '" + this.txtLogin.Text + "'", false);
            //    Common.LogEntryCRM(base.Name, "DELETE USER", 0, 0, this.txtLogin.Text);
            //    base.Close();
            //}
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            //frmUserPermissions frmUserPermissions = new frmUserPermissions();
            //if (Common.CanUseForm(Conversions.ToString(frmUserPermissions.Tag), false))
            //{
            //    frmUserPermissions.Icon = MyProject.Forms.frmMain.Icon;
            //    frmUserPermissions.LocalUserID = this.txtLogin.Text;
            //    frmUserPermissions.ShowDialog();
            //    Common.LogEntryCRM(base.Name, "MODIFY PERMISSIONS", 0, 0, this.txtLogin.Text);
            //}
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            //string text = "";
            //while (Operators.CompareString(text, "", false) == 0)
            //{
            //    text = Common.idComboInput("Enter New Linked Record Manager", "Select UserID from ManageUserCombo", "Userid", "UserID", "", "", "", "");
            //    if (Common.IntScalar(string.Concat(new string[]
            //    {
            //        "select count(*) from CRMUserLinks where UserID = '",
            //        this.UserID,
            //        "' and UserLinkID  = '",
            //        text,
            //        "'and LinkType = 1 "
            //    }), false) > 0)
            //    {
            //        if (Interaction.MsgBox("This link already exists.", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical, "Already Exists") == MsgBoxResult.Cancel)
            //        {
            //            return;
            //        }
            //        text = "";
            //    }
            //}
            //Common.NonQuery(string.Concat(new string[]
            //{
            //    "insert into CRMUserLinks (UserID, UserLinkID, LinkType) values ('",
            //    this.UserID,
            //    "', '",
            //    text,
            //    "', 1)"
            //}), false);
            //Common.LogEntryCRM(base.Name, "LINK RECORDMANAGER", 0, 0, this.txtLogin.Text);
            //this.FillLinks();
        }

        private void btnDeleteLink_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("This will delete currently displayed Record Manager Link. Do you want to continue?", MsgBoxStyle.YesNo, "Delete Link") == MsgBoxResult.Yes)
            //{
            //    if (Common.NonQuery(string.Concat(new string[]
            //    {
            //        "delete from CRMUserLinks where UserID = '",
            //        this.UserID,
            //        "' and UserLinkID = '",
            //        this.cbManagerLinks.Text,
            //        "' and LinkType = 1"
            //    }), false) != 1)
            //    {
            //        Interaction.MsgBox("There was an error deleting the link.", MsgBoxStyle.OkOnly, null);
            //        return;
            //    }
            //    Common.LogEntryCRM(base.Name, "DELETE RECORDMANAGER", 0, 0, this.txtLogin.Text);
            //    this.FillLinks();
            //}
        }

        private void btnAddDLink_Click(object sender, EventArgs e)
        {
           // string text = "";
            //while (Operators.CompareString(text, "", false) == 0)
            //{
            //    text = Common.idComboInput("Enter New Linked Driver", "Select UserID from CRMUsers where (UserGroup = 'OUTSIDE SALES' or UserGroup = 'DRIVER') and Active = 'True'", "Userid", "UserID", "", "", "", "");
            //    if (Operators.CompareString(text, "", false) != 0)
            //    {
            //        if (Common.IntScalar(string.Concat(new string[]
            //        {
            //            "select count(*) from CRMUserLinks where UserID = '",
            //            this.UserID,
            //            "' and UserLinkID  = '",
            //            text,
            //            "'and LinkType = 2"
            //        }), false) <= 0)
            //        {
            //            continue;
            //        }
            //        if (Interaction.MsgBox("This link already exists.", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical, "Already Exists") != MsgBoxResult.Cancel)
            //        {
            //            text = "";
            //            continue;
            //        }
            //    }
            //    return;
            //}
            //Common.NonQuery(string.Concat(new string[]
            //{
            //    "insert into CRMUserLinks (UserID, UserLinkID, LinkType) values ('",
            //    this.UserID,
            //    "', '",
            //    text,
            //    "', 2)"
            //}), false);
            //Common.LogEntryCRM(base.Name, "LINK DRIVER", 0, 0, this.txtLogin.Text);
            //this.FillLinks();

        }

        private void btnDeleteDLink_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("This will delete currently displayed Driver Link. Do you want to continue?", MsgBoxStyle.YesNo, "Delete Link") == MsgBoxResult.Yes)
            //{
            //    if (Common.NonQuery(string.Concat(new string[]
            //    {
            //        "delete from CRMUserLinks where UserID = '",
            //        this.UserID,
            //        "' and UserLinkID = '",
            //        this.cbDriverLinks.Text,
            //        "' and LinkType = 2"
            //    }), false) != 1)
            //    {
            //        Interaction.MsgBox("There was an error deleting the link.", MsgBoxStyle.OkOnly, null);
            //        return;
            //    }
            //    Common.LogEntryCRM(base.Name, "DELETE DRIVER", 0, 0, this.txtLogin.Text);
            //    this.FillLinks();
            //}
        }

        private void btnSeePassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Refresh();
           //Common.LogEntryCRM(base.Name, "SEE PASSWORD", 0, 0, this.txtLogin.Text);
        }

        private void cmdChangeUserName_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("Warning this must be done after hours and the user must be logged out.", MsgBoxStyle.OkCancel, "AFTER HOURS ONLY") == MsgBoxResult.Ok)
            //{
                this.Cursor = Cursors.WaitCursor;
                //string text = Common.idInput("New user login", "Change Login", "", 20, "S", 2, 10, "", "");
                string text2 = this.txtLogin.Text;
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMCompany set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMCompany set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMContact set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMGroup set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMHistory set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMHistory set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMHistoryArchive set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMHistoryArchive set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMPickup set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMPickup set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMQuote set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMQuote set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMRMA set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMRMA set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMTasks set CreateUserID = '",
            //        text,
            //        "' where CreateUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMTasks set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMUserLinks set UserID = '",
            //        text,
            //        "' where UserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMUserLinks set UserLinkID = '",
            //        text,
            //        "' where UserLinkID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMUserLog set UserID = '",
            //        text,
            //        "' where UserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMUserLog set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMUserPermissions set UserID = '",
            //        text,
            //        "' where UserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMUsers set UserID = '",
            //        text,
            //        "' where UserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMAreaComboLIst set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMCalendarGroup set ManageUserID = '",
            //        text,
            //        "' where ManageUserID = '",
            //        text2,
            //        "'"
            //    }), false);
                this.Cursor = Cursors.Default;
            //    Interaction.MsgBox("This only changes the login and record manager entries. You must make any necessary name changes in CRM and IR2.\rYOU MUST RESTART YOUR OWN CRM BEFORE THIS CHNAGE WILL FULLY TAKE PLACE.", MsgBoxStyle.OkOnly, null);
            //    base.Close();
            //}
        }

        private void txtLogin_DoubleClick(object sender, EventArgs e)
        {
            //if (Operators.CompareString(Common.IRGroup, "EXECUTIVE", false) == 0 & Operators.CompareString(Strings.LCase(this.txtLogin.Text), Strings.LCase(Common.IRUser), false) != 0)
            //{
            //    this.cmdChangeUserName.Visible = true;
            //}
        }

        private void ckTell_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckRecordManager_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void FillLinks()
        {
            this.cbManagerLinks.Text = "";
            //idComboBox idComboBox = this.cbManagerLinks;
           // Common.FillCombo(ref idComboBox, "select UserLinkID from CRMUserLinks where UserID = '" + this.UserID + "' and LinkType = 1", "UserLinkID", "NONE");
            //this.cbManagerLinks = idComboBox;
            this.cbDriverLinks.Text = "";
            //idComboBox = this.cbDriverLinks;
            //Common.FillCombo(ref idComboBox, "select UserLinkID from CRMUserLinks where UserID = '" + this.UserID + "' and LinkType = 2", "UserLinkID", "NONE");
            //this.cbDriverLinks = idComboBox;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //if (Common.CanUseForm("SEE_PASSWORD", true))
            //{
            //    this.btnSeePassword.Visible = true;
            //}
            //else
            //{
            //    this.btnSeePassword.Visible = false;
            //}
            //this.SalesPersonComboTableAdapter.Fill(this.IRDataSetViews.SalesPersonCombo);
            this.cbGroup.Items.Clear();
            SqlConnection connection = new SqlConnection();
           //connection = Common.ConnectToSQL(false);
            SqlDataReader sqlDataReader = new SqlCommand("select distinct UserGroup from CRMUserGroups", connection).ExecuteReader();
            while (sqlDataReader.Read())
            {
                //this.cbGroup.Items.Add(Strings.UCase(sqlDataReader.GetString(0)));
            }
            //if (Operators.CompareString(this.UserID, "", false) == 0)
            //{
            //    this.UsersBindingSource.AddNew();
               // base.SuspendLayout();
                //this.dtCreateDate.EditValue = DateTime.Now;
                //base.ResumeLayout();
                //this.cbManagerLinks.Enabled = false;
                //this.btnAddLink.Enabled = false;
                //this.btnDeleteLink.Enabled = false;
                //this.btnAddDLink.Enabled = false;
                //this.btnDeleteDLink.Enabled = false;
                //this.ckActive.CheckState = CheckState.Checked;
                //this.ckCanLogin.CheckState = CheckState.Checked;
                //this.ckRecordManager.CheckState = CheckState.Unchecked;
                //this.ckTell.CheckState = CheckState.Unchecked;
               // return;
            //}
            //this.UsersTableAdapter.FillByUserID(this.IRDataSet.CRMUsers, this.UserID);
            this.txtLogin.ReadOnly = true;
            this.FillLinks();
            if (this.ckTell.CheckState == CheckState.Indeterminate)
            {
                this.ckTell.CheckState = CheckState.Unchecked;
            }
        }


        //private void IntializeControlsData()
        //{
        //    this.IdComboBox1.Items.AddRange(new object[]
        //   {
        //        "ACCOUNT MANAGER",
        //        "ADMIN ACCOUNT",
        //        "ADMINISTRATIVE ASSISTANT",
        //        "CUSTOMER SERVICE REPRESENTATIVE",
        //        "GENERAL MANAGER",
        //        "INSIDE SALES REPRESENTATIVE",
        //        "INSIDE SALES SUPPORT",
        //        "MARKETING COORDINATOR",
        //        "PRESIDENT",
        //        "REGIONAL SALES MANAGER",
        //        "SALES",
        //        "SALES MANAGER",
        //        "SALES REPRESENTATIVE",
        //        "SALES SUPPORT",
        //        "TECHNICIAN",
        //        "TERRITORY REPRESENTATIVE"
        //   });
        //}



    }
}
