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
    public partial class frmPickups : Form
    {
        public frmPickups()
        {
            InitializeComponent();
        }

        private void frmPickups_Load(object sender, EventArgs e)
        {
            //this.dtStartDate.EditValue = DateTime.Today.Date;
            //this.dtEndDate.EditValue = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateTime.Today.Date);
            //this.LoadGrid();
        }

        public void LoadGrid()
        {
            //string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select P.PickupID as 'Pickup #', P.ManageUserID as 'Record Manager', P.CustomerName as 'Customer', P.IRCode, L.Qty, L.Manufacturer as 'Manuf', L.ItemNumbner as 'Model #',  L.Description, L.Price, L.Warranty, P.CreateDate as 'Date'   from CRMPickup P left join CRMPickupLines L on P.PickupID = L.PickupID  where CreateDate between '", this.dtStartDate.EditValue), "' and '"), this.dtEndDate.EditValue), "'"));
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
            //text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(distinct P.PickupID) from CRMPickup P left join CRMPickupLines L on P.PickupID = L.PickupID  where CreateDate between '", this.dtStartDate.EditValue), "' and '"), this.dtEndDate.EditValue), "'"));
            //if (!Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    this.RecordManager = Common.IRUser;
            //    text = text + " and ManageUserID  = '" + this.RecordManager + "'";
            //}
            //this.lblCount.Text = "Pickup Count: " + Conversions.ToString(Common.IntScalar(text, false));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void gridDetail_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = this.gridDetail.CurrentCell.RowIndex;
            //int value = Conversions.ToInteger(this.gridDetail[0, rowIndex].Value);
            //frmDevExViewReport expr_30 = new frmDevExViewReport(true, 1);
            //expr_30.Icon = MyProject.Forms.frmMain.Icon;
            //rptPickupRequest rptPickupRequest = new rptPickupRequest();
            //rptPickupRequest.RequestParameters = false;
            //rptPickupRequest.FilterString = (("[PickupID] = " + Conversions.ToString(value)) ?? "");
            //rptPickupRequest.CreateDocument();
            //expr_30.ReportPrintControl.PrintingSystem = rptPickupRequest.PrintingSystem;
            //expr_30.ReportPrintControl.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
            //expr_30.ReportPrintControl.UpdatePageView();
            //expr_30.Show();
        }
    }
}
