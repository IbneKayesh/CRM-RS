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

namespace CRM
{
    public partial class frmUserGroups : Form
    {
        public frmUserGroups()
        {
            InitializeComponent();
        }


        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.UserGroupsTableAdapter.FillByUserGroup(this.IRDataSet.CRMUserGroups, this.cbGroup.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (Operators.CompareString(this.cbGroup.Text, "", false) == 0)
            //{
            //    Interaction.MsgBox("You must select a group first", MsgBoxStyle.OkOnly, null);
            //    return;
            //}
            //while (true)
            //{
            //    frmUserForms frmUserForms = new frmUserForms();
            //    if (!Common.CanUseForm(Conversions.ToString(frmUserForms.Tag), false))
            //    {
            //        break;
            //    }
            //    frmUserForms.Icon = base.Icon;
            //    frmUserForms.Text = "Add Form to Group";
            //    frmUserForms.tmpGroup = this.cbGroup.Text;
            //    frmUserForms.ShowDialog();
            //    if (frmUserForms.DialogResult == DialogResult.Cancel)
            //    {
            //        break;
            //    }
            //    if (Common.NonQuery(string.Concat(new string[]
            //    {
            //        "insert into CRMUserGroups (UserGroup, FormName) values (",
            //        Common.NQ(Strings.UCase(this.cbGroup.Text)),
            //        ", ",
            //        Common.NQ(Strings.UCase(frmUserForms.cbGroup.Text)),
            //        ")"
            //    }), false) == -1)
            //    {
            //        Interaction.MsgBox("There was an error adding the form.", MsgBoxStyle.OkOnly, null);
            //    }
            //    Common.LogEntryCRM(base.Name, "ADD FORM", 0, 0, this.cbGroup.Text + " " + frmUserForms.cbGroup.Text);
            //    frmUserForms.Close();
            //    this.UserGroupsTableAdapter.FillByUserGroup(this.IRDataSet.CRMUserGroups, this.cbGroup.Text);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string text = this.UserGroupsidDataGridView[1, this.UserGroupsidDataGridView.CurrentRow.Index].Value.ToString();
            //if (Interaction.MsgBox("Are you sure you want to delete this form from the group?", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
            //{
            //    Common.LogEntryCRM(base.Name, "DELETE GROUP FORM", 0, 0, this.cbGroup.Text + " " + text);
            //    if (Common.NonQuery(string.Concat(new string[]
            //    {
            //        "delete from CRMUserGroups where UserGroup = '",
            //        this.cbGroup.Text,
            //        "' and FormName = '",
            //        text,
            //        "'"
            //    }), false) == -1)
            //    {
            //        Interaction.MsgBox("There was an error deleting the form.", MsgBoxStyle.OkOnly, null);
            //    }
            //    this.UserGroupsTableAdapter.FillByUserGroup(this.IRDataSet.CRMUserGroups, this.cbGroup.Text);
            //}
        }

        private void frmUserGroups_Load(object sender, EventArgs e)
        {
            //this.cbGroup.Items.Clear();
            //SqlConnection connection = new SqlConnection();
            //connection = Common.ConnectToSQL(false);
            //SqlDataReader sqlDataReader = new SqlCommand("select distinct UserGroup from CRMUserGroups", connection).ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    this.cbGroup.Items.Add(Strings.UCase(sqlDataReader.GetString(0)));
            //}
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            //string text = Common.idInput("New group name", "Add New Group", "", 20, "S", 2, 10, "", "");
            //if (Operators.CompareString(text, "", false) != 0)
            //{
            //    if (Common.IntScalar("select count(*) from CRMUserGroups where UserGroup = '" + text + "'", false) == 0)
            //    {
            //        this.cbGroup.Items.Add(Strings.UCase(text));
            //        return;
            //    }
            //    Interaction.MsgBox("This group is already in use", MsgBoxStyle.OkOnly, "Group already exists");
            //}
        }
    }
}
