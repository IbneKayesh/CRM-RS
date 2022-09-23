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
    public partial class frmTodaysActivities : Form
    {
        public frmTodaysActivities()
        {
            InitializeComponent();
        }

        private void frmTodaysActivities_Load(object sender, EventArgs e)
        {
            //this.ManageUserComboTableAdapter.Fill(this.IRDataSetViews.ManageUserCombo);
            //if (!Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    this.cbRecordManager.Text = Common.IRUser;
            //    this.cbRecordManager.Enabled = false;
            //}
            //this.dtStart.EditValue = DateTime.Today.Date;
            //this.dtEnd.EditValue = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateTime.Today.Date);
            this.Loadgrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void Loadgrid()
        {
            //string arg_74_0 = Conversions.ToString(Operators.AddObject("SELECT HistoryID, ManageUserID as 'Record Manager', CreateDate as 'Date', Name as 'Company', City, State, ContactName as 'Contact', Category as 'Status', Typename as 'Color', Regarding, Details, TypeID  FROM ReportActivityCall ", Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" where ManageUserID = '" + this.cbRecordManager.Text + "' and CreateDate >= '", this.dtStart.EditValue), "' and CreateDate <= '"), this.dtEnd.EditValue), "'"))) + " order by CreateDate ";
            //DataTable dataTable = new DataTable();
            //new SqlDataAdapter();
            //Common.GetGridData(arg_74_0, false).Fill(dataTable);
            //new DataView(dataTable);
            //this.gridDetail.DataSource = dataTable;
            //this.txtCount.Text = Conversions.ToString(checked(this.gridDetail.RowCount - 1));
            //this.gridDetail.Columns[11].Visible = false;
            //this.gridDetail.Columns[0].Visible = false;
            //this.gridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cbRecordManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Loadgrid();
        }

        private void gridDetail_DoubleClick(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //frmNewNote frmNewNote = new frmNewNote();
            //if (Common.CanUseForm(Conversions.ToString(frmNewNote.Tag), false))
            //{
            //    int index = this.gridDetail.CurrentRow.Index;
            //    frmNewNote.Icon = MyProject.Forms.frmMain.Icon;
            //    frmNewNote.HistoryID = Conversions.ToLong(this.gridDetail[0, index].Value);
            //    frmNewNote.ShowDialog();
            //    this.Cursor = Cursors.Default;
            //}
        }
    }
}
