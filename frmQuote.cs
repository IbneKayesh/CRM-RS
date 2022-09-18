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
    public partial class frmQuote : Form
    {
        public int QuoteID;

        public int ContactID;

        public int CompanyID;

        public string IRCode;

        private bool NewRecord;
        public frmQuote()
        {
            InitializeComponent();

            this.NewRecord = false;
        }

        private void frmQuote_Load(object sender, EventArgs e)
        {

            //idComboBox cbReturnShipping = this.cbReturnShipping;
            //Common.FillCombo(ref cbReturnShipping, "select Description from ShipMethod", "Description", "NONE");
            //this.cbReturnShipping = cbReturnShipping;
            //if (this.QuoteID == 0)
            //{
            //    this.QuoteID = clsSO.GetNextRMANo();
            //    this.NewRecord = true;
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "insert into CRMQuote (QuoteID, CreateDate, CreateUserID, QuoteDate, companyID, ContactID, RMA) values  (",
            //        Conversions.ToString(this.QuoteID),
            //        ", '",
            //        Conversions.ToString(DateTime.Now),
            //        "','",
            //        Common.IRUser,
            //        "', '",
            //        Conversions.ToString(DateTime.Now),
            //        "', ",
            //        Conversions.ToString(this.CompanyID),
            //        ",  ",
            //        Conversions.ToString(this.ContactID),
            //        ", 'False') "
            //    }), false);
            //}
            //this.Text = this.Text + " (Q" + Conversions.ToString(this.QuoteID) + ")";
            //this.CRMQuoteTableAdapter.FillByQuoteID(this.IRDataSet.CRMQuote, this.QuoteID);
            //this.CRMQuoteLinesTableAdapter.FillByQuoteID(this.IRDataSet.CRMQuoteLines, new int?(this.QuoteID));
            //if (this.NewRecord)
            //{
            //    if (Operators.CompareString(this.IRCode, "", false) != 0)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection = Common.ConnectToSQL(false);
            //        SqlCommand expr_18A = new SqlCommand("select isnull(Company,''), isnull(S.AddressOne,''), isnull(S.AddressTwo,''), isnull(S.City,''),  isnull(S.State,''), isnull(S.Zip,'') from Customers C left Join CustomerShipTo S on C.DefaultShipToID = S.ShipToID where C.CustomerNo = '" + this.IRCode + "'", sqlConnection);
            //        SqlDataReader sqlDataReader = expr_18A.ExecuteReader();
            //        sqlDataReader.Read();
            //        this.txtCustomer.Text = sqlDataReader.GetString(0);
            //        this.txtAddress1.Text = sqlDataReader.GetString(1);
            //        this.txtAddress2.Text = sqlDataReader.GetString(2);
            //        this.txtCity.Text = sqlDataReader.GetString(3);
            //        this.txtState.Text = sqlDataReader.GetString(4);
            //        this.txtZip.Text = sqlDataReader.GetString(5);
            //        sqlDataReader.Close();
            //        expr_18A.Cancel();
            //        expr_18A.CommandText = (("select ManageUserID, CN.CompanyID, isnull(FirstName,'') + ' ' + isnull(LastName,''), isnull(MainPhone,''), isnull(CellPhone,''),  isnull(Email,'') from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID where ContactID = " + Conversions.ToString(this.ContactID)) ?? "");
            //        sqlDataReader = expr_18A.ExecuteReader();
            //        sqlDataReader.Read();
            //        this.txtRecordManager.Text = sqlDataReader.GetString(0);
            //        this.txtCompanyID.Text = Conversions.ToString(sqlDataReader.GetInt32(1));
            //        this.txtContact.Text = sqlDataReader.GetString(2);
            //        this.txtPhone.Text = sqlDataReader.GetString(3);
            //        this.txtCell.Text = sqlDataReader.GetString(4);
            //        this.txtEmail.Text = sqlDataReader.GetString(5);
            //        expr_18A.Connection.Close();
            //        sqlConnection.Close();
            //        this.txtIRCode.Text = this.IRCode;
            //        this.lblIRCode.Visible = true;
            //        if (Operators.CompareString(this.IRCode, "", false) != 0)
            //        {
            //            this.cbReturnShipping.Text = Common.StrScalar("select Description from ShipMethod where ShipMethodID = (select ShipMethod from Customers where CustomerNo = '" + this.IRCode + "')", false);
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        SqlConnection sqlConnection2 = new SqlConnection();
            //        sqlConnection2 = Common.ConnectToSQL(false);
            //        SqlCommand expr_34E = new SqlCommand(("select ManageUserID, CN.CompanyID, isnull(FirstName,'') + ' ' + isnull(LastName,''), isnull(MainPhone,''), isnull(CellPhone,''),  isnull(Email,''), isnull(CO.Name,''), isnull(Address1,''), isnull(Address2,''), isnull(City,''), isnull(State,''), isnull(ZipCode,'') from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID where ContactID = " + Conversions.ToString(this.ContactID)) ?? "", sqlConnection2);
            //        SqlDataReader sqlDataReader2 = expr_34E.ExecuteReader();
            //        sqlDataReader2.Read();
            //        this.txtRecordManager.Text = sqlDataReader2.GetString(0);
            //        this.txtCompanyID.Text = Conversions.ToString(sqlDataReader2.GetInt32(1));
            //        this.txtContact.Text = sqlDataReader2.GetString(2);
            //        this.txtPhone.Text = sqlDataReader2.GetString(3);
            //        this.txtCell.Text = sqlDataReader2.GetString(4);
            //        this.txtEmail.Text = sqlDataReader2.GetString(5);
            //        this.txtCustomer.Text = sqlDataReader2.GetString(6);
            //        this.txtAddress1.Text = sqlDataReader2.GetString(7);
            //        this.txtAddress2.Text = sqlDataReader2.GetString(8);
            //        this.txtCity.Text = sqlDataReader2.GetString(9);
            //        this.txtState.Text = sqlDataReader2.GetString(10);
            //        this.txtZip.Text = sqlDataReader2.GetString(11);
            //        expr_34E.Connection.Close();
            //        sqlConnection2.Close();
            //    }
            //}
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //if (this.NewRecord)
            //{
            //    Common.NonQuery(("delete from CRMQuote where QuoteID = " + Conversions.ToString(this.QuoteID)) ?? "", false);
            //    Common.NonQuery(("delete from CRMQuoteLines where QuoteID = " + Conversions.ToString(this.QuoteID)) ?? "", false);
            //}
            //base.Close();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            this.gridDetails.AllowUserToAddRows = false;
            //if (!this.ValidateForm())
            //{
            //    this.gridDetails.AllowUserToAddRows = true;
            //    return;
            //}
            //checked
            //{
            //    int num = this.gridDetails.RowCount - 1;
            //    for (int i = 0; i <= num; i++)
            //    {
            //        this.gridDetails[1, i].Value = this.QuoteID;
            //        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[7, i].Value)))
            //        {
            //            this.gridDetails[7, i].Value = false;
            //        }
            //        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[9, i].Value)))
            //        {
            //            this.gridDetails[9, i].Value = false;
            //        }
            //    }
            //    try
            //    {
            //        base.Validate();
            //        this.CRMQuoteBindingSource.EndEdit();
            //        this.CRMQuoteTableAdapter.Update(this.IRDataSet.CRMQuote);
            //        this.CRMQuoteLinesBindingSource.EndEdit();
            //        this.CRMQuoteLinesTableAdapter.Update(this.IRDataSet.CRMQuoteLines);
            //    }
            //    catch (Exception expr_11C)
            //    {
            //        ProjectData.SetProjectError(expr_11C);
            //        Exception ex = expr_11C;
            //        Interaction.MsgBox(ex.Message + "Quote was not created.", MsgBoxStyle.OkOnly, null);
            //        ProjectData.ClearProjectError();
            //        return;
            //    }
            //    int value = Common.IntScalar("select QuoteTemplate from CompanyControl", false);
            //    rptQuote expr_158 = new rptQuote();
            //    expr_158.RequestParameters = false;
            //    expr_158.FilterString = (("[QuoteID] = " + Conversions.ToString(this.QuoteID)) ?? "");
            //    expr_158.ExportToPdf(Common.ReportPath + "\\Quote # Q" + Conversions.ToString(this.QuoteID) + ".pdf");
            //    string messageAttachment = Common.ReportPath + "\\Quote # Q" + Conversions.ToString(this.QuoteID) + ".pdf";
            //    expr_158.CreateDocument();
            //    SqlConnection connection = new SqlConnection();
            //    connection = Common.ConnectToSQL(false);
            //    SqlDataReader sqlDataReader = new SqlCommand(("Select isnull(Subject,''), isnull(Body,'') from CRMEmailTemplates where TemplateID = " + Conversions.ToString(value)) ?? "", connection).ExecuteReader();
            //    sqlDataReader.Read();
            //    Email.SendEmail(Email.FormatBody(sqlDataReader.GetString(1), this.ContactID, 0), sqlDataReader.GetString(0), this.txtEmail.Text, "NONE", "NONE", messageAttachment);
            //    base.Close();
            //}
        }


        private bool ValidateForm()
        {
            return true;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            //if (!Common.BitScalar(("select RMA from CRMQuote where QuoteID = " + Conversions.ToString(this.QuoteID)) ?? "", false))
            //{
            //    if (Interaction.MsgBox("Are you sure you want to delete this Quote.", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Delete Quote") == MsgBoxResult.Yes)
            //    {
            //        Common.LogEntryCRM(base.Name, "DELETE QUOTE", this.CompanyID, this.ContactID, "QUOTE ID " + Conversions.ToString(this.QuoteID));
            //        Common.NonQuery(("delete from CRMQuoteLines where QuoteID = " + Conversions.ToString(this.QuoteID)) ?? "", false);
            //        Common.NonQuery(("delete from CRMQuote where QuoteID = " + Conversions.ToString(this.QuoteID)) ?? "", false);
            //        Interaction.MsgBox("Quote Deleted", MsgBoxStyle.OkOnly, null);
            //        base.Close();
            //        return;
            //    }
            //}
            //else
            //{
            //    Interaction.MsgBox("You cannot delete a Quote that has already been converted to an RMA.", MsgBoxStyle.OkOnly, null);
            //}
        }


    }
}
