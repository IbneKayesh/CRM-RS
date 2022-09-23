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
    public partial class frmProductivity : Form
    {
        private string FilterParamater;

        private string FilterStringCall;

        private string FilterStringRMA;

        private string FilterStringPickup;

        private string FilterStringAPPT;

        private string RecordManager;
        public frmProductivity()
        {
            InitializeComponent();
        }
        private void frmProductivity_Load(object sender, EventArgs e)
        {
            //this.dtStart.EditValue = DateTime.Today.Date;
            //this.dtEnd.EditValue = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateTime.Today.Date);
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
                //rptProductivity rptProductivity = new rptProductivity();
                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptProductivity.RequestParameters = false;
                //    rptProductivity.FilterString = "[UserID] = '" + Common.IRUser + "'";
                //    rptProductivity.txtPARAMETERS.Text = this.FilterParamater;
                //    rptProductivity.CreateDocument();
                //    frmDevExViewReport.ReportPrintControl.PrintingSystem = rptProductivity.PrintingSystem;
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
                this.Cursor = Cursors.WaitCursor;
                this.ReportFilter();
                //rptProductivity rptProductivity = new rptProductivity();
                //if (Common.CanUseForm(Conversions.ToString(base.Tag), false))
                //{
                //    rptProductivity.RequestParameters = false;
                //    rptProductivity.FilterString = "[UserID] = '" + Common.IRUser + "'";
                //    rptProductivity.txtPARAMETERS.Text = this.FilterParamater;
                //    rptProductivity.CreateDocument();
                //    rptProductivity.PrintingSystem.PageSettings.PrinterName = Common.GetDefaultPrinterName();
                //    Common.LogEntryCRM(base.Name, "Print", 0, 0, "");
                //    rptProductivity.Print();
                //    this.Cursor = Cursors.Default;
                //}
            }
        }

        private void LoadData()
        {
          //  Common.NonQuery("delete from ReportProductivity where UserID = '" + Common.IRUser + "'", false);
            SqlConnection sqlConnection = new SqlConnection();
           // sqlConnection = Common.ConnectToSQL(false);
            SqlConnection sqlConnection2 = new SqlConnection();
            //sqlConnection2 = Common.ConnectToSQL(false);
            SqlCommand sqlCommand = new SqlCommand("SQL goes here", sqlConnection2);
            SqlCommand sqlCommand2 = new SqlCommand("Select distinct (isnull(ManageUserID,'')) from CRMCompany", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                sqlCommand.CommandText = string.Concat(new string[]
                {
                    "insert into ReportProductivity (ManageUserID,  UserID) values ('",
                    sqlDataReader.GetString(0),
                    "', '",
                  //  Common.IRUser,
                    "')"
                });
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Cancel();
            }
            sqlCommand2.Cancel();
            sqlDataReader.Close();
            sqlCommand2.CommandText = "select ManageUserID, isnull(OutsideSales,'False') from ReportProductivity RP join CRMUsers CU on RP.ManageUserID = CU.UserId join SalesPeople SP on CU.IRSalesPersonNo = SP.SalesPersonNo";
            sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (sqlDataReader.GetBoolean(1))
                {
                    sqlCommand.CommandText = string.Concat(new string[]
                    {
                        "update ReportProductivity set Location = 'O' where ManageUserID = '",
                        sqlDataReader.GetString(0),
                        "' and UserID = '",
                       // Common.IRUser,
                        "'"
                    });
                }
                else
                {
                    sqlCommand.CommandText = string.Concat(new string[]
                    {
                        "update ReportProductivity set Location = 'I' where ManageUserID = '",
                        sqlDataReader.GetString(0),
                        "' and UserID = '",
                        //Common.IRUser,
                        "'"
                    });
                }
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Cancel();
            }
            sqlCommand2.Cancel();
            sqlDataReader.Close();
            //Common.NonQuery("update ReportProductivity set Location = 'I' where UserID = '" + Common.IRUser + "' and Location is null", false);
            string text = "SELECT isnull(CreateUserID,''), Count(*) FROM CRMHistory  where (TypeID = 0 or TypeID = 1 or TypeID = 2 or TypeID = 200 or TypeID = 201  or TypeID = 202 or TypeID = 203 or TypeID = 204 or TypeID = 205 or TypeID = 206 or TypeID = 207 or TypeID = 215 or TypeID = 216) and ";
           // text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" CreateDate between '", this.dtStart.EditValue), "' AND '"), this.dtEnd.EditValue), "'")));
            text += " group by CreateUserID ";
            sqlCommand2.CommandText = text;
            sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                sqlCommand.CommandText = string.Concat(new string[]
                {
                    "update ReportProductivity set Calls = ",
                   // Conversions.ToString(sqlDataReader.GetInt32(1)),
                    " where ManageUserID = '",
                    sqlDataReader.GetString(0),
                    "'"
                });
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Cancel();
            }
            sqlCommand2.Cancel();
            sqlDataReader.Close();
            text = "SELECT isnull(CreateUserID,''), Count(*) FROM CRMRMA  where ";
          //  text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" CreateDate between '", this.dtStart.EditValue), "' AND '"), this.dtEnd.EditValue), "'")));
            text += " group by CreateUserID ";
            sqlCommand2.CommandText = text;
            sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                sqlCommand.CommandText = string.Concat(new string[]
                {
                    "update ReportProductivity set RMA = ",
                   // Conversions.ToString(sqlDataReader.GetInt32(1)),
                    " where ManageUserID = '",
                    sqlDataReader.GetString(0),
                    "'"
                });
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Cancel();
            }
            sqlCommand2.Cancel();
            sqlDataReader.Close();
            text = "SELECT isnull(createUserID,''), Count(*) FROM CRMTasks where TaskCode = 2 and ";
           // text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" CreateDate between '", this.dtStart.EditValue), "' AND '"), this.dtEnd.EditValue), "'")));
            text += " group by CreateUserID ";
            sqlCommand2.CommandText = text;
            sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                sqlCommand.CommandText = string.Concat(new string[]
                {
                    "update ReportProductivity set PU = ",
                   // Conversions.ToString(sqlDataReader.GetInt32(1)),
                    " where ManageUserID = '",
                    sqlDataReader.GetString(0),
                    "'"
                });
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Cancel();
            }
            sqlCommand2.Cancel();
            sqlDataReader.Close();
            text = "SELECT isnull(createUserID,''), Count(*) FROM CRMTasks  where  (Tasktype = 6 or TaskType = 1) and ";
           // text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" CreateDate between '", this.dtStart.EditValue), "' AND '"), this.dtEnd.EditValue), "'")));
            text += " group by CreateUserID ";
            sqlCommand2.CommandText = text;
            sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                sqlCommand.CommandText = string.Concat(new string[]
                {
                    "update ReportProductivity set Appt = ",
                  //  Conversions.ToString(sqlDataReader.GetInt32(1)),
                    " where ManageUserID = '",
                    sqlDataReader.GetString(0),
                    "'"
                });
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Cancel();
            }
            sqlCommand2.Cancel();
            sqlDataReader.Close();
            sqlCommand2.Connection.Close();
            sqlCommand.Connection.Close();
            sqlConnection.Close();
            sqlConnection2.Close();
           // Common.NonQuery("update ReportProductivity set DT = isnull(RMA,0) + isnull(PU,0) + isnull(APPT,0) where UserID = '" + Common.IRUser + "'", false);
          //  Common.NonQuery("delete from ReportProductivity where UserID = '" + Common.IRUser + "' and DT = 0", false);
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void ReportFilter()
        {
            this.FilterParamater = "";
            this.DateFilter("", this.dtStart, this.dtEnd);
            this.LoadData();
        }

        private void DateFilter(string DateName, DateTimePicker StartDate, DateTimePicker EndDate)
        {
            //if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //{
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(DateName + " ON OR BEFORE ", EndDate.EditValue)));
            //        this.FilterStringCall = Conversions.ToString(Operators.AddObject(this.FilterStringCall, Operators.ConcatenateObject(Operators.ConcatenateObject("(StartTime <= '", this.dtEnd.EditValue), "' )")));
            //        this.FilterStringRMA = Conversions.ToString(Operators.AddObject(this.FilterStringRMA, Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate <= '", this.dtEnd.EditValue), "' )")));
            //        this.FilterStringPickup = Conversions.ToString(Operators.AddObject(this.FilterStringPickup, Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate <= '", this.dtEnd.EditValue), "' )")));
            //        this.FilterStringAPPT = Conversions.ToString(Operators.AddObject(this.FilterStringAPPT, Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate <= '", this.dtEnd.EditValue), "' )")));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(DateName + " ON OR AFTER ", EndDate.EditValue)));
            //        this.FilterStringCall = Conversions.ToString(Operators.AddObject(this.FilterStringCall, Operators.ConcatenateObject(Operators.ConcatenateObject("(StartTime >= '", this.dtStart.EditValue), "' )")));
            //        this.FilterStringRMA = Conversions.ToString(Operators.AddObject(this.FilterStringRMA, Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate >= '", this.dtEnd.EditValue), "' )")));
            //        this.FilterStringPickup = Conversions.ToString(Operators.AddObject(this.FilterStringPickup, Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate >= '", this.dtEnd.EditValue), "' )")));
            //        this.FilterStringAPPT = Conversions.ToString(Operators.AddObject(this.FilterStringAPPT, Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate >= '", this.dtStart.EditValue), "' )")));
            //    }
            //    if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(StartDate.EditValue, null, false), Operators.CompareObjectNotEqual(EndDate.EditValue, null, false))))
            //    {
            //        this.FilterParamater = Conversions.ToString(Operators.AddObject(this.FilterParamater, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(DateName + " BETWEEN ", StartDate.EditValue), " AND "), EndDate.EditValue)));
            //        this.FilterStringCall = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("(StartTime >= '", this.dtStart.EditValue), "'  and StartTime <= '"), this.dtEnd.EditValue), "') "));
            //        this.FilterStringRMA = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate >= '", this.dtStart.EditValue), "'  and QuoteDate <= '"), this.dtEnd.EditValue), "' )"));
            //        this.FilterStringPickup = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate >= '", this.dtStart.EditValue), "'  and QuoteDate <= '"), this.dtEnd.EditValue), "' )"));
            //        this.FilterStringAPPT = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("(CreateDate >= '", this.dtStart.EditValue), "'  and CreateDate <= '"), this.dtEnd.EditValue), "' )"));
            //    }
            //}
        }
    }
}
