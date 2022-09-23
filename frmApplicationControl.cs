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
    public partial class frmApplicationControl : Form
    {
        public frmApplicationControl()
        {
            InitializeComponent();
        }


        private void cmdCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //Common.NonQuery(string.Concat(new string[]
            //{
            //    "update CompanyControl set CRMDataLoad = '",
            //    Conversions.ToString(this.ckCRMLockout.Checked),
            //    "', UserLogDate = ",
            //    Conversions.ToString(this.numLogs.Value),
            //    ", HistoryArchiveDate = ",
            //    Conversions.ToString(this.numArchive.Value),
            //    ",  PickupTemplate = ",
            //    Conversions.ToString(this.numPickup.Value),
            //    ", QuoteTemplate = ",
            //    Conversions.ToString(this.numQuote.Value),
            //    ", RMATemplate = ",
            //    Conversions.ToString(this.numRMA.Value),
            //    ", RMAWarrantyTemplate = ",
            //    Conversions.ToString(this.numRMAWarranty.Value),
            //    ",  UseNewServer = '",
            //    Conversions.ToString(this.ckIR2Lockout.Checked),
            //    "', SMTPServer = '",
            //    this.txtSMTP.Text,
            //    "', RMACCEmail = '",
            //    this.txtCCEmail.Text,
            //    "', RMAPortalTemplate = ",
            //    Conversions.ToString(this.intPortalRMA.Value)
            //}) ?? "", false);
            //Common.LogEntryCRM(base.Name, "SAVE", 0, 0, "APPLICATION CONTROL");
            base.Close();
        }

        private void ckLockout_CheckedChanged(object sender, EventArgs e)
        {
           // MyProject.Forms.frmMain.Timer2.Enabled = false;
        }

        private void frmApplicationControl_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            SqlCommand expr_18 = new SqlCommand("select CRMDataLoad, UserLogDate, HistoryArchiveDate, PickupTemplate, QuoteTemplate, RMATemplate, RMAWarrantyTemplate, UseNewServer, SMTPServer, RMACCEmail, RMAPortalTemplate from CompanyControl", sqlConnection);
            SqlDataReader sqlDataReader = expr_18.ExecuteReader();
            sqlDataReader.Read();
            this.ckCRMLockout.Checked = sqlDataReader.GetBoolean(0);
            this.numLogs.Value = new decimal(sqlDataReader.GetInt32(1));
            this.numArchive.Value = new decimal(sqlDataReader.GetInt32(2));
            this.numPickup.Value = new decimal(sqlDataReader.GetInt32(3));
            this.numQuote.Value = new decimal(sqlDataReader.GetInt32(4));
            this.numRMA.Value = new decimal(sqlDataReader.GetInt32(5));
            this.numRMAWarranty.Value = new decimal(sqlDataReader.GetInt32(6));
            this.ckIR2Lockout.Checked = sqlDataReader.GetBoolean(7);
            this.txtSMTP.Text = sqlDataReader.GetString(8);
            this.txtCCEmail.Text = sqlDataReader.GetString(9);
            this.intPortalRMA.Value = new decimal(sqlDataReader.GetInt32(10));
            expr_18.Connection.Close();
            sqlConnection.Close();
        }
    }
}
