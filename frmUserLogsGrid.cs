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
    public partial class frmUserLogsGrid : Form
    {
        public frmUserLogsGrid()
        {
            InitializeComponent();
        }


        private void frmUserLogsGrid_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //this.dtLogDate.EditValue = DateTime.Today;
            //idComboBox cbUser = this.cbUser;
            //Common.FillCombo(ref cbUser, "select 'ALL' as UserID union all select upper(userID) as 'UserID' from CRMUsers", "UserID", "NONE");
            //this.cbUser = cbUser;
            //this.CRMUserLogTableAdapter.FillByEntryTime(this.IRDataSet.CRMUserLog, Conversions.ToString(this.dtLogDate.EditValue));
            //this.IdDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.Cursor = Cursors.Default;
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateGrid();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.UpdateGrid();
        }

        private void UpdateGrid()
        {
            this.Cursor = Cursors.WaitCursor;
            //if (Strings.Trim(this.cbUser.Text).Length > 0 & Operators.CompareString(Strings.Trim(this.cbUser.Text), "ALL", false) != 0)
            //{
            //    this.CRMUserLogTableAdapter.FillByUserID(this.IRDataSet.CRMUserLog, this.cbUser.Text, Conversions.ToString(this.dtLogDate.EditValue));
            //}
            //else
            //{
            //    this.CRMUserLogTableAdapter.FillByEntryTime(this.IRDataSet.CRMUserLog, Conversions.ToString(this.dtLogDate.EditValue));
            //}
            this.Cursor = Cursors.Default;
        }

        private void dtLogDate_EditValueChanged(object sender, EventArgs e)
        {
            //if (this.dtLogDate.Focused)
            //{
            //    this.UpdateGrid();
            //}
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //this.Timer1.Enabled = false;
            //this.UpdateGrid();
            //this.Timer1.Enabled = true;
        }
    }
}
