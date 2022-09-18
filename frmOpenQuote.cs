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
    public partial class frmOpenQuote : Form
    {
        private string RecordManager;
        public frmOpenQuote()
        {
            InitializeComponent();
        }

        private void frmOpenQuote_Load(object sender, EventArgs e)
        {
        //    this.dtStartDate.EditValue = DateTime.Today.Date;
        //    this.dtEndDate.EditValue = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateTime.Today.Date);
        //    this.LoadGrid();
        }
        public void LoadGrid()
        {
            //string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select Q.QuoteID as 'Quote #', Q.ManageUserID as 'Record Manager', Q.CustomerName as 'Customer', Q.IRCode, L.Qty, L.Manufacturer as 'Manuf', L.ItemNumbner as 'Model #',  L.Description, L.QuotePrice as 'Repair $', Q.RMA, Q.CreateDate as 'Date'  from CRMQuote Q left join CRMQuoteLines L on Q.QuoteID = L.QuoteID where CreateDate between '", this.dtStartDate.EditValue), "' and '"), this.dtEndDate.EditValue), "' and "), " RMA = 'False'"));
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
            //text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(distinct Q.QuoteID) from CRMQuote Q left join CRMQuoteLines L on Q.QuoteID = L.QuoteID where CreateDate between '", this.dtStartDate.EditValue), "' and '"), this.dtEndDate.EditValue), "' and "), " RMA = 'False'"));
            //if (!Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    this.RecordManager = Common.IRUser;
            //    text = text + " and ManageUserID  = '" + this.RecordManager + "'";
            //}
            //this.lblCount.Text = "Quote Count: " + Conversions.ToString(Common.IntScalar(text, false));
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
            //rptQuote rptQuote = new rptQuote();
            //rptQuote.RequestParameters = false;
            //rptQuote.FilterString = (("[QuoteID] = " + Conversions.ToString(value)) ?? "");
            //rptQuote.CreateDocument();
            //expr_30.ReportPrintControl.PrintingSystem = rptQuote.PrintingSystem;
            //expr_30.ReportPrintControl.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
            //expr_30.ReportPrintControl.UpdatePageView();
            //expr_30.Show();
        }
    }
}
