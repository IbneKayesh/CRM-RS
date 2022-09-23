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
    public partial class frmTMNewCust : Form
    {
        private string FilterParamater;

        private string FilterString;

        private string TM;
        public frmTMNewCust()
        {
            InitializeComponent();
        }


        private void frmTMNewCust_Load(object sender, EventArgs e)
        {
        //    idComboBox cbTM = this.cbTM;
        //    Common.FillCombo(ref cbTM, "Select UserID from TMCombo union select 'ALL' as UserID", "UserID", "NONE");
        //    this.cbTM = cbTM;
        //    this.dtStart.EditValue = DateAndTime.DateAdd(DateInterval.Month, -1.0, Common.GetMonthStartDate(new DateTime(599266080000000000L)));
        //    this.dtEnd.EditValue = DateAndTime.DateAdd(DateInterval.Month, -1.0, Common.GetMonthEndDate(new DateTime(599266080000000000L)));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                this.Cursor = Cursors.WaitCursor;
                this.ReportFilter();
                //rptTMNewCustomer rptTMNewCustomer = new rptTMNewCustomer();
                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptTMNewCustomer.RequestParameters = false;
                //    rptTMNewCustomer.StartDate = Conversions.ToDate(this.dtStart.EditValue);
                //    rptTMNewCustomer.EndDate = Conversions.ToDate(this.dtEnd.EditValue);
                //    rptTMNewCustomer.NewDate = DateAndTime.DateAdd(DateInterval.Month, 6.0, Conversions.ToDate(this.dtEnd.EditValue));
                //    rptTMNewCustomer.FilterString = this.FilterString;
                //    rptTMNewCustomer.txtPARAMETERS.Text = this.FilterParamater;
                //    rptTMNewCustomer.CreateDocument();
                //    rptTMNewCustomer.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
                //    Common.LogEntryCRM(base.Name, "Print", 0, 0, "");
                //    rptTMNewCustomer.Print();
                //    this.Cursor = Cursors.Default;
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
                //rptTMNewCustomer rptTMNewCustomer = new rptTMNewCustomer();
                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptTMNewCustomer.RequestParameters = false;
                //    rptTMNewCustomer.StartDate = Conversions.ToDate(this.dtStart.EditValue);
                //    rptTMNewCustomer.EndDate = Conversions.ToDate(this.dtEnd.EditValue);
                //    rptTMNewCustomer.NewDate = DateAndTime.DateAdd(DateInterval.Month, 6.0, Conversions.ToDate(this.dtEnd.EditValue));
                //    rptTMNewCustomer.FilterString = this.FilterString;
                //    rptTMNewCustomer.txtPARAMETERS.Text = this.FilterParamater;
                //    rptTMNewCustomer.CreateDocument();
                //    frmDevExViewReport.ReportPrintControl.PrintingSystem = rptTMNewCustomer.PrintingSystem;
                //    frmDevExViewReport.ReportPrintControl.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
                //    frmDevExViewReport.ReportPrintControl.UpdatePageView();
                //    Common.LogEntryCRM(base.Name, "Preview", 0, 0, "");
                //    frmDevExViewReport.Show();
                //    this.Cursor = Cursors.Default;
                //}
            }
        }

        private string ReportFilter()
        {
            this.FilterString = "";
            this.FilterParamater = "";
            string expr_16 = "";
            this.DateFilter("", this.dtStart, this.dtEnd);
            //if (this.cbTM.Text.Length > 0 & Operators.CompareString(this.cbTM.Text, "ALL", false) != 0)
            //{
            //    this.TM = this.cbTM.Text;
            //    this.FilterParamater += "\r";
            //    this.FilterParamater = this.FilterParamater + "Telemarketer: " + this.cbTM.Text;
            //    if (this.FilterString.Length > 0)
            //    {
            //        this.FilterString += " and ";
            //    }
            //    this.FilterString = this.FilterString + "[CreateUserID] = '" + this.cbTM.Text + "'";
            //    return expr_16;
            //}
            this.TM = "";
            return expr_16;
        }

        private bool ValidateForm()
        {
            bool result = true;
            //if (Operators.CompareString(this.dtStart.Text, "", false) == 0 | Operators.CompareString(this.dtEnd.Text, "", false) == 0)
            //{
            //    Interaction.MsgBox("You must specify a beginning and an end date for this report.", MsgBoxStyle.Exclamation, "Invalid Criteria");
            //    result = false;
            //}
            //if (checked((int)DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(this.dtStart.EditValue), Conversions.ToDate(this.dtEnd.EditValue), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) > 12)
            //{
            //    Interaction.MsgBox("Please limit number of months to 12.", MsgBoxStyle.Exclamation, "Invalid Criteria");
            //    result = false;
            //}
            return result;
        }

        private void DateFilter(string DateName, DateTimePicker StartDate, DateTimePicker EndDate)
        {
            //if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //{
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(DateName + " ON OR BEFORE ", EndDate.EditValue)));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(DateName + " ON OR AFTER ", EndDate.EditValue)));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DateName + " BETWEEN ", StartDate.EditValue), " AND "), EndDate.EditValue)));
            //    }
            //}
        }
    }
}
