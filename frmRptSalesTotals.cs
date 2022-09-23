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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM
{
    public partial class frmRptSalesTotals : Form
    {
        private object FilterParamater;

        private int SalesPerson;
        public frmRptSalesTotals()
        {
            InitializeComponent();
        }

      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private bool ValidateForm()
        {
            bool result = true;
            //if (checked((int)DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(this.dtStart.EditValue), Conversions.ToDate(this.dtEnd.EditValue), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) > 12)
            //{
            //    Interaction.MsgBox("Please limit number of months to 12.", MsgBoxStyle.Exclamation, "Invalid Criteria");
            //    result = false;
            //}
            return result;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.Cursor = Cursors.WaitCursor;
                this.ReportFilter();
                //rptSalesTotals rptSalesTotals = new rptSalesTotals();
                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptSalesTotals.RequestParameters = false;
                //    rptSalesTotals.ShowDetail = this.ckDetail.Checked;
                //    rptSalesTotals.txtPARAMETERS.Text = Conversions.ToString(this.FilterParamater);
                //    rptSalesTotals.CreateDocument();
                //    rptSalesTotals.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
                //    Common.LogEntryCRM(base.Name, "Print", 0, 0, "");
                //    rptSalesTotals.Print();
                //    this.Cursor = Cursors.Default;
                //    base.Close();
                //}
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.Cursor = Cursors.WaitCursor;
                this.ReportFilter();
                //frmDevExViewReport frmDevExViewReport = new frmDevExViewReport(false, 1);
                //frmDevExViewReport.Icon = MyProject.Forms.frmMain.Icon;
                //frmDevExViewReport.MdiParent = MyProject.Forms.frmMain;
                //rptSalesTotals rptSalesTotals = new rptSalesTotals();
                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptSalesTotals.RequestParameters = false;
                //    rptSalesTotals.ShowDetail = this.ckDetail.Checked;
                //    rptSalesTotals.txtPARAMETERS.Text = Conversions.ToString(this.FilterParamater);
                //    rptSalesTotals.CreateDocument();
                //    frmDevExViewReport.ReportPrintControl.PrintingSystem = rptSalesTotals.PrintingSystem;
                //    frmDevExViewReport.ReportPrintControl.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
                //    frmDevExViewReport.ReportPrintControl.UpdatePageView();
                //    Common.LogEntryCRM(base.Name, "Preview", 0, 0, "");
                //    frmDevExViewReport.Show();
                //    this.Cursor = Cursors.Default;
                //    base.Close();
                //}
            }
        }


        private void frmRptSalesTotals_Load(object sender, EventArgs e)
        {
            //this.SalesPersonComboTableAdapter.FillByWithAll(this.IRDataSetViews.SalesPersonCombo);
            //this.dtStart.EditValue = Common.GetMonthStartDate(new DateTime(599266080000000000L));
            //this.dtEnd.EditValue = Common.GetMonthEndDate(new DateTime(599266080000000000L));
            //if (!Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    if (Common.CanUseForm("SEE_LINKED_SALESDATA", true))
            //    {
            //        this.cbSalesperson.DataSource = null;
            //        idComboBox cbSalesperson = this.cbSalesperson;
            //        Common.FillCombo(ref cbSalesperson, "select C.Name, C.SalesPersonNo from SalesPersonCombo C left join CRMUsers U on C.SalesPersonNo = U.IRSalesPersonNo left join CRMUserLinks L on U.UserId = L.UserLinkID where LinkType = 1 and L.UserID = '" + Common.IRUser + "'", "Name", "SalesPersonNo");
            //        this.cbSalesperson = cbSalesperson;
            //        return;
            //    }
            //    this.cbSalesperson.SelectedValue = Common.IntScalar("select IRSalesPersonNo from CRMUsers where UserID = '" + Common.IRUser + "'", false);
            //    this.cbSalesperson.Enabled = false;
            //}
        }

        private string ReportFilter()
        {
            this.FilterParamater = "";
            string result = "";
            //this.DateFilter("", this.dtStart, this.dtEnd);
            //if (Operators.ConditionalCompareObjectGreater(this.cbSalesperson.SelectedValue, 0, false))
            //{
            //    this.SalesPerson = Conversions.ToInteger(this.cbSalesperson.SelectedValue);
            //    this.FilterParamater = Operators.AddObject(this.FilterParamater, '\r');
            //    this.FilterParamater = Operators.AddObject(this.FilterParamater, "SALESPERSON: " + this.cbSalesperson.Text);
            //}
            //else
            //{
            //    this.SalesPerson = 0;
            //}
            //Common.NonQuery("delete from SalesTotalsReport where UserID = '" + Common.IRUser + "'", false);
            //Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("exec dbo.ReportSalesTotals @salespersonNo = " + Conversions.ToString(this.SalesPerson) + ", @beginDate = N'", this.dtStart.EditValue), "', @pEndDate = N'"), this.dtEnd.EditValue), "', @UserId = N'"), Common.IRUser), "'")), false);
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            //SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
            //SqlConnection sqlConnection2 = new SqlConnection();
            //int num = 0;
            //int num2 = 0;
            //int num3 = 0;
            //int value = 0;
            //int value2 = 0;
            //sqlConnection2 = Common.ConnectToSQL(false);
            //SqlCommand sqlCommand2 = new SqlCommand("select distinct SalesPersonNo, ReportMonth, NewCustomers from SalesTotalsReport where UserID = '" + Common.IRUser + "' order by  SalesPersonNo", sqlConnection2);
            //SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            //checked
            //{
            //    if (sqlDataReader.HasRows)
            //    {
            //        while (sqlDataReader.Read())
            //        {
            //            if (num != sqlDataReader.GetInt32(0) & num != 0)
            //            {
            //                sqlCommand.CommandText = (("update SalesTotalsReport set NewCustMonth = " + Conversions.ToString(num2) + " where SalesPersonNo = " + Conversions.ToString(num)) ?? "");
            //                sqlCommand.ExecuteNonQuery();
            //                sqlCommand.Cancel();
            //                num3 += num2;
            //                num2 = 0;
            //                num = sqlDataReader.GetInt32(0);
            //                num2 += sqlDataReader.GetInt32(2);
            //            }
            //            else if (num == 0)
            //            {
            //                num = sqlDataReader.GetInt32(0);
            //                num2 += sqlDataReader.GetInt32(2);
            //            }
            //            else
            //            {
            //                num2 += sqlDataReader.GetInt32(2);
            //            }
            //        }
            //    }
            //    sqlCommand.CommandText = (string.Concat(new string[]
            //    {
            //        "update SalesTotalsReport set NewCustMonth = ",
            //        Conversions.ToString(num2),
            //        ", ReceivedMonth = ",
            //        Conversions.ToString(value),
            //        ",  ShippedMonth = ",
            //        Conversions.ToString(value2),
            //        " where SalesPersonNo = ",
            //        Conversions.ToString(num)
            //    }) ?? "");
            //    sqlCommand.ExecuteNonQuery();
            //    sqlCommand.Cancel();
            //    num3 += num2;
            //    Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update R set ReceivedMonth = W.ReceivedCount from (select Q.SalesPersonNo, Q.ReceivedPrice, Q.ReceivedCount from  (SELECT so.SalesPersonNo as SalesPersonNo, sum((CASE WHEN isnull(sc.RUR,0) = 1 THEN isnull(sn.approvedprice,  sn.price + isNull(sn.rushFee, 0)) ELSE sn.price+isNull(sn.rushFee, 0) END)) as ReceivedPrice  , Count(distinct So.CustomerNo) as ReceivedCount FROM dbo.salesorders as so join dbo.snumbers as sn on  so.SalesOrderNo = sn.salesOrderno left outer join dbo.shipmentcodes as sc on sn.shipmentcodeid = sc.shipmentcodeid  WHERE so.DateEntered between '", this.dtStart.EditValue), "' and '"), this.dtEnd.EditValue), "' GROUP BY  so.SalesPersonNo) "), " as Q where Q.ReceivedPrice > 0) as W join SalesTotalsReport R on W.SalesPersonNo = R.SalesPersonNo and R.UserID = '"), Common.IRUser), "'")), false);
            //    Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update R set ShippedMonth = W.ShippedCount from (SELECT so.SalesPersonNo  , sum(sn.price + isNull(sn.rushFee,0)) as Price,Count(distinct So.CustomerNo) as ShippedCount FROM dbo.salesorders as so  join dbo.snumbers as sn on so.SalesOrderNo= sn.salesOrderno WHERE sn.dateShipped between '", this.dtStart.EditValue), "' and '"), this.dtEnd.EditValue), "' "), " and Price > 0 GROUP BY so.SalesPersonNo) as W join SalesTotalsReport R on "), " W.SalesPersonNo = R.SalesPersonNo and R.UserID = '"), Common.IRUser), "'")), false);
            //    Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update SalesTotalsReport set ReceivedYear = W.ReceivedCount from (select Q.ReceivedPrice, Q.ReceivedCount from  (SELECT sum((CASE WHEN isnull(sc.RUR,0) = 1 THEN isnull(sn.approvedprice,  sn.price + isNull(sn.rushFee, 0)) ELSE sn.price+isNull(sn.rushFee, 0) END)) as ReceivedPrice  , Count(distinct So.CustomerNo) as ReceivedCount FROM dbo.salesorders as so join dbo.snumbers as sn on  so.SalesOrderNo = sn.salesOrderno left outer join dbo.shipmentcodes as sc on sn.shipmentcodeid = sc.shipmentcodeid  WHERE so.DateEntered between '", this.dtStart.EditValue), "' and '"), this.dtEnd.EditValue), "') "), " as Q where Q.ReceivedPrice > 0) as W  where UserID = '"), Common.IRUser), "'")), false);
            //    Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update SalesTotalsReport set ShippedYear = W.ShippedCount from (SELECT  sum(sn.price + isNull(sn.rushFee,0)) as Price,Count(distinct So.CustomerNo) as ShippedCount FROM dbo.salesorders as so  join dbo.snumbers as sn on so.SalesOrderNo= sn.salesOrderno WHERE sn.dateShipped between '", this.dtStart.EditValue), "' and '"), this.dtEnd.EditValue), "' "), " and Price > 0) as W where UserID = '"), Common.IRUser), "'")), false);
            //    sqlCommand.CommandText = (("update SalesTotalsReport set NewCustYear = " + Conversions.ToString(num3)) ?? "");
            //    sqlCommand.ExecuteNonQuery();
            //    sqlCommand2.Connection.Close();
            //    sqlConnection2.Close();
            //    sqlCommand.Connection.Close();
            //    sqlConnection.Close();
                return result;
            //}
        }

        private void DateFilter(string DateName, DateTimePicker StartDate, DateTimePicker EndDate)
        {
            //if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //{
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(DateName + " ON OR BEFORE ", EndDate.EditValue));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(DateName + " ON OR AFTER ", EndDate.EditValue));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DateName + " BETWEEN ", StartDate.EditValue), " AND "), EndDate.EditValue));
            //    }
            //}
        }
    }
}
