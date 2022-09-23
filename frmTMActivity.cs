using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class frmTMActivity : Form
    {
        public frmTMActivity()
        {
            InitializeComponent();
        }


        private void frmTodaysActivities_Load(object sender, EventArgs e)
        {
            //idComboBox cbTM = this.cbTM;
            //Common.FillCombo(ref cbTM, "Select UserID from TMCombo", "UserID", "NONE");
            //this.cbTM = cbTM;
            //if (!Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    this.cbTM.Text = Common.IRUser;
            //    this.cbTM.Enabled = false;
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
            //string arg_7E_0 = Conversions.ToString(Operators.AddObject("SELECT HistoryID, RecordManager as 'Record Manager', CreateDate as 'Date', Name as 'Company', City, State, ContactName as 'Contact', Category as 'Status', Typename as 'Color', Regarding, Details, TypeID  FROM ReportTMActivityCall ", Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" where ManageUserID = '" + this.cbTM.Text + "' and CreateDate >= '", this.dtStart.EditValue), "' and CreateDate <= '"), this.dtEnd.EditValue), "'"))) + " and (Typeid = 110 or TypeID = 111 or TypeID = 112 or TypeID = 209 or TypeID = 210 or TypeID = 211 or TypeID = 212 or TypeID = 213 or TypeID = 214)" + " order by CreateDate ";
            //DataTable dataTable = new DataTable();
            //new SqlDataAdapter();
            //Common.GetGridData(arg_7E_0, false).Fill(dataTable);
            //new DataView(dataTable);
            //this.gridDetail.DataSource = dataTable;
            //this.txtCount.Text = Conversions.ToString(checked(this.gridDetail.RowCount - 1));
            this.gridDetail.Columns[11].Visible = false;
            this.gridDetail.Columns[0].Visible = false;
            this.gridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cbRecordManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Loadgrid();
        }

        private void gridDetail_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
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

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            this.Loadgrid();
        }
    }
}
