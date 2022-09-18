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
    public partial class frmOpenRMA : Form
    {
        private string RecordManager;
        public frmOpenRMA()
        {
            InitializeComponent();
        }

        private void frmOpenRMA_Load(object sender, EventArgs e)
        {
            //this.dtStartDate.EditValue = DateTime.Today.Date;
            //this.dtEndDate.EditValue = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateTime.Today.Date);
            this.LoadGrid();
        }
        public void LoadGrid()
        {
            //Common.NonQuery("update CRMRMA set FromPortal = 'False' where FromPortal is null", false);
            //string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select R.RMAID as 'RMA #', R.ManageUserID as 'Record Manager', R.CustomerName as 'Customer', R.IRCode, L.Qty, L.Manufacturer as 'Manuf', L.ItemNumbner as 'Model #',  L.Description, L.RepairPrice as 'Repair $', L.Warranty, R.CreateDate as 'Date', R.FromPortal as 'From Portal'  from CRMRMA R left join CRMRMALines L on R.RMAID = L.RMAID  where CreateDate between '", this.dtStartDate.EditValue), "' and '"), this.dtEndDate.EditValue), "' and SalesOrderNo is null "));
            //if (this.ckPortal.Checked)
            //{
            //    text += " and FromPortal = 'True' ";
            //}
            //if (this.ckCRM.Checked)
            //{
            //    text += " and FromPortal = 'False' ";
            //}
            //if (!Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    this.RecordManager = Common.IRUser;
            //    text = text + " and ManageUserID  = '" + this.RecordManager + "'";
            //}
            //text += " order by CreateDate desc";
            //DataTable dataTable = new DataTable();
            //new SqlDataAdapter();
            //Common.GetGridData(text, false).Fill(dataTable);
            //new DataView(dataTable);
            //this.gridDetail.DataSource = dataTable;
            //this.gridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(distinct R.RMAID) from CRMRMA R left join CRMRMALines L on R.RMAID = L.RMAID where CreateDate between '", this.dtStartDate.EditValue), "' and '"), this.dtEndDate.EditValue), "' and SalesOrderNo is null "));
            //if (!Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    this.RecordManager = Common.IRUser;
            //    text = text + " and ManageUserID  = '" + this.RecordManager + "'";
            //}
            //this.lblCount.Text = "RMA Count: " + Conversions.ToString(Common.IntScalar(text, false));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void gridDetail_DoubleClick(object sender, EventArgs e)
        {
            //int rowIndex = this.gridDetail.CurrentCell.RowIndex;
            //int value = Conversions.ToInteger(this.gridDetail[0, rowIndex].Value);
            //frmDevExViewReport expr_30 = new frmDevExViewReport(true, 1);
            //expr_30.Icon = MyProject.Forms.frmMain.Icon;
            //rptPackingList rptPackingList = new rptPackingList();
            //rptPackingList.RequestParameters = false;
            //rptPackingList.FilterString = (("[RMAID] = " + Conversions.ToString(value)) ?? "");
            //rptPackingList.CreateDocument();
            //expr_30.ReportPrintControl.PrintingSystem = rptPackingList.PrintingSystem;
            //expr_30.ReportPrintControl.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
            //expr_30.ReportPrintControl.UpdatePageView();
            //expr_30.Show();
        }

      
        private void ckPortal_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
