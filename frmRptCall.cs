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
    public partial class frmRptCall : Form
    {
        private string FilterParamater;

        private string FilterString;

        private string RecordManager;
        public frmRptCall()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
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


                //rptCallReport rptCallReport = new rptCallReport();


                //DateTime startDate = DateTime.MinValue;
                //DateTime endDate = DateTime.MinValue;

                //try
                //{
                //    startDate = (DateTime)dtStart.EditValue;
                //    endDate = (DateTime)dtEnd.EditValue;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Start Date is not a valid date!  Value = " + dtStart.EditValue.ToString());

                //    return;
                //}


                //try
                //{
                //    endDate = (DateTime)dtEnd.EditValue;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("End Date is not a valid date!  Value = " + dtEnd.EditValue.ToString());

                //    return;
                //}


                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptCallReport.RequestParameters = false;
                //    rptCallReport.ReportRecordManager = this.cbRecordManager.Text;
                //    rptCallReport.FilterString = this.FilterString;



                //    rptCallReport.txtPARAMETERS.Text = this.FilterParamater;                    // Sample Data Here:   BETWEEN 3/1/2022 AND 3/2/2022

                //    rptCallReport.StartDate = startDate;
                //    rptCallReport.EndDate = endDate;


                //    rptCallReport.CreateDocument();
                //    frmDevExViewReport.ReportPrintControl.PrintingSystem = rptCallReport.PrintingSystem;
                //    frmDevExViewReport.ReportPrintControl.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
                //    frmDevExViewReport.ReportPrintControl.UpdatePageView();
                //    Common.LogEntryCRM(base.Name, "Preview", 0, 0, "");
                //    frmDevExViewReport.Show();
                //    this.Cursor = Cursors.Default;
                //}
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                //this.Cursor = Cursors.WaitCursor;
                //this.ReportFilter();


                //rptCallReport rptCallReport = new rptCallReport();


                //DateTime startDate = DateTime.MinValue;
                //DateTime endDate = DateTime.MinValue;

                //try
                //{
                //    startDate = (DateTime)dtStart.EditValue;
                //    endDate = (DateTime)dtEnd.EditValue;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Start Date is not a valid date!  Value = " + dtStart.EditValue.ToString());

                //    return;
                //}


                //try
                //{
                //    endDate = (DateTime)dtEnd.EditValue;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("End Date is not a valid date!  Value = " + dtEnd.EditValue.ToString());

                //    return;
                //}



                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptCallReport.RequestParameters = false;
                //    rptCallReport.ReportRecordManager = this.cbRecordManager.Text;
                //    rptCallReport.FilterString = this.FilterString;


                //    rptCallReport.txtPARAMETERS.Text = this.FilterParamater;


                //    rptCallReport.StartDate = startDate;
                //    rptCallReport.EndDate = endDate;



                //    rptCallReport.CreateDocument();
                //    rptCallReport.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
                //    Common.LogEntryCRM(base.Name, "Print", 0, 0, "");
                //    rptCallReport.Print();
                //    this.Cursor = Cursors.Default;
                //}
            }
        }

        private bool ValidateForm()
        {
            bool result = true;
            //if (this.cbRecordManager.Text.Length == 0)
            //{
            //    Interaction.MsgBox("You must specify a Record Manager for this report.", MsgBoxStyle.Exclamation, "Invalid Criteria");
            //    result = false;
            //}
            //if (checked((int)DateAndTime.DateDiff(DateInterval.Month, Conversions.ToDate(this.dtStart.EditValue), Conversions.ToDate(this.dtEnd.EditValue), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)) > 12)
            //{
            //    Interaction.MsgBox("Please limit number of months to 12.", MsgBoxStyle.Exclamation, "Invalid Criteria");
            //    result = false;
            //}
            return result;
        }

        private string ReportFilter()
        {
            this.FilterString = "";
            this.FilterParamater = "";
            string result = "";
            this.DateFilter("", this.dtStart, this.dtEnd);
            string text = this.cbReportType.Text;
            //if (Operators.CompareString(text, "ALL", false) != 0)
            //{
            //    if (Operators.CompareString(text, "APPOINTMENT", false) == 0)
            //    {
            //        if (this.FilterString.Length > 0)
            //        {
            //            this.FilterString += " and ";
            //        }
            //        this.FilterString += "([TypeID] = 110 or [TypeID] = 111 or [TypeID] = 112 or [TypeID] = 209 or [TypeID] = 210 or [TypeID] = 211 or [TypeID] = 212 or [TypeID] = 213 or [TypeID] = 214)";
            //    }
            //    else
            //    {
            //        this.cbReportType.Text = "CALL";
            //        if (this.FilterString.Length > 0)
            //        {
            //            this.FilterString += " and ";
            //        }
            //        this.FilterString += "([TypeID] = 0 or [TypeID] = 1 or [TypeID] = 2 or [TypeID] = 200 or [TypeID] = 201 or [TypeID] = 202 or [TypeID] = 203 or [TypeID] = 204 or [TypeID] = 205 or [TypeID] = 206 or [TypeID] = 207 or [TypeID] = 208 or [TypeID] = 215 or [TypeID] = 216)";
            //    }
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
            //        this.FilterString = Conversions.ToString(Operators.AddObject(this.FilterString, Operators.ConcatenateObject(Operators.ConcatenateObject("[CreateDate] <= #", this.dtEnd.EditValue), "# ")));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(DateName + " ON OR AFTER ", EndDate.EditValue)));
            //        this.FilterString = Conversions.ToString(Operators.AddObject(this.FilterString, Operators.ConcatenateObject(Operators.ConcatenateObject("[CreateDate] >= #", this.dtStart.EditValue), "# ")));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DateName + " BETWEEN ", StartDate.EditValue), " AND "), EndDate.EditValue)));
            //        this.FilterString = Conversions.ToString(Operators.AddObject(this.FilterString, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("[CreateDate] >= #", this.dtStart.EditValue), "#  and [CreateDate] <= #"), this.dtEnd.EditValue), "# ")));
            //    }
            //}
        }

        private void frmRptCall_Load(object sender, EventArgs e)
        {
            //this.ManageUserComboTableAdapter.Fill(this.IRDataSetViews.ManageUserCombo);


            //this.dtStart.EditValue = DateTime.Today.Date;
            //this.dtEnd.EditValue = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateTime.Today.Date);


            this.cbReportType.Text = "CALL";
        }
    }
}
