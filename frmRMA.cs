using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CRM
{
    public partial class frmRMA : Form
    {
        public frmRMA()
        {
            InitializeComponent();
        }

        private void frmRMA_Load(object sender, EventArgs e)
        {
            //if (Operators.CompareString(this.IRCode, "", false) != 0 && Common.IntScalar("select count(*) from Customers where CustomerNo = '" + this.IRCode + "'", false) == 0)
            //{
            //    Interaction.MsgBox("There is no matching customer in IR2 for this IRCode. You cannot create an RMA until the IR2 record is created for this account.", MsgBoxStyle.Critical, "NO Record in IR2.");
            //    this.Timer1.Enabled = true;
            //    base.Visible = false;
            //    base.Close();
            //    return;
            //}
            //idComboBox idComboBox = this.cbReturnShipping;
            //Common.FillCombo(ref idComboBox, "select Description from ShipMethod", "Description", "NONE");
            //this.cbReturnShipping = idComboBox;
            //idComboBox = this.cbBranchCode;
            //Common.FillCombo(ref idComboBox, "Select BranchCode from BranchCodes", "BranchCode", "BranchCode");
            //this.cbBranchCode = idComboBox;
            //if (this.RMAID == 0)
            //{
            //    this.RMAID = clsSO.GetNextRMANo();
            //    this.NewRecord = true;
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "insert into CRMRMA (RMAID, CreateDate, CreateUserID, QuoteDate, CompanyID, ContactID) values  (",
            //        Conversions.ToString(this.RMAID),
            //        ", '",
            //        Conversions.ToString(DateTime.Now),
            //        "','",
            //        Common.IRUser,
            //        "', '",
            //        Conversions.ToString(DateTime.Now),
            //        "',  ",
            //        Conversions.ToString(this.CompanyID),
            //        ", ",
            //        Conversions.ToString(this.ContactID),
            //        ") "
            //    }), false);
            //}
            //this.Text = this.Text + " (R" + Conversions.ToString(this.RMAID) + ")";
            //this.CRMRMATableAdapter.FillByRMAID(this.IRDataSet.CRMRMA, this.RMAID);
            //this.CRMRMALinesTableAdapter.FillByRMAID(this.IRDataSet.CRMRMALines, new int?(this.RMAID));
            //if (this.NewRecord)
            //{
            //    if (Operators.CompareString(this.IRCode, "", false) != 0)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection = Common.ConnectToSQL(false);
            //        SqlCommand expr_20A = new SqlCommand("select isnull(Company,''), isnull(S.AddressOne,''), isnull(S.AddressTwo,''), isnull(S.City,''),  isnull(S.State,''), isnull(S.Zip,'') from Customers C left Join CustomerShipTo S on C.DefaultShipToID = S.ShipToID where C.CustomerNo = '" + this.IRCode + "'", sqlConnection);
            //        SqlDataReader sqlDataReader = expr_20A.ExecuteReader();
            //        sqlDataReader.Read();
            //        this.txtCustomer.Text = sqlDataReader.GetString(0);
            //        this.txtAddress1.Text = sqlDataReader.GetString(1);
            //        this.txtAddress2.Text = sqlDataReader.GetString(2);
            //        this.txtCity.Text = sqlDataReader.GetString(3);
            //        this.txtState.Text = sqlDataReader.GetString(4);
            //        this.txtZip.Text = sqlDataReader.GetString(5);
            //        sqlDataReader.Close();
            //        expr_20A.Cancel();
            //        expr_20A.CommandText = (("select ManageUserID, CN.CompanyID, isnull(FirstName,'') + ' ' + isnull(LastName,''), isnull(MainPhone,''), isnull(CellPhone,''),  isnull(Email,'') from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID where ContactID = " + Conversions.ToString(this.ContactID)) ?? "");
            //        sqlDataReader = expr_20A.ExecuteReader();
            //        sqlDataReader.Read();
            //        this.txtRecordManager.Text = sqlDataReader.GetString(0);
            //        this.txtCompanyID.Text = Conversions.ToString(sqlDataReader.GetInt32(1));
            //        this.txtContact.Text = sqlDataReader.GetString(2);
            //        this.txtPhone.Text = sqlDataReader.GetString(3);
            //        this.txtCell.Text = sqlDataReader.GetString(4);
            //        this.txtEmail.Text = sqlDataReader.GetString(5);
            //        expr_20A.Connection.Close();
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
            //        SqlCommand expr_3CE = new SqlCommand(("select ManageUserID, CN.CompanyID, isnull(FirstName,'') + ' ' + isnull(LastName,''), isnull(MainPhone,''), isnull(CellPhone,''),  isnull(Email,''), isnull(CO.Name,''), isnull(Address1,''), isnull(Address2,''), isnull(City,''), isnull(State,''), isnull(ZipCode,'') from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID where ContactID = " + Conversions.ToString(this.ContactID)) ?? "", sqlConnection2);
            //        SqlDataReader sqlDataReader2 = expr_3CE.ExecuteReader();
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
            //        expr_3CE.Connection.Close();
            //        sqlConnection2.Close();
            //    }
            //}
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //if (this.NewRecord)
            //{
            //    Common.NonQuery(("delete from CRMRMA where RMAID = " + Conversions.ToString(this.RMAID)) ?? "", false);
            //    Common.NonQuery(("delete from CRMRMALines where RMAID = " + Conversions.ToString(this.RMAID)) ?? "", false);
            //}
            base.Close();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            //this.gridDetails.AllowUserToAddRows = false;

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
            //        this.gridDetails[1, i].Value = this.RMAID;

            //        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[7, i].Value)))
            //        {
            //            this.gridDetails[7, i].Value = false;
            //        }

            //        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[9, i].Value)))
            //        {
            //            this.gridDetails[9, i].Value = false;
            //        }

            //        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[11, i].Value)))
            //        {
            //            this.gridDetails[11, i].Value = false;
            //        }
            //    }

            //    try
            //    {
            //        base.Validate();
            //        this.CRMRMABindingSource.EndEdit();
            //        this.CRMRMATableAdapter.Update(this.IRDataSet.CRMRMA);
            //        this.CRMRMALinesBindingSource.EndEdit();
            //        this.CRMRMALinesTableAdapter.Update(this.IRDataSet.CRMRMALines);
            //    }
            //    catch (Exception expr_154)
            //    {
            //        ProjectData.SetProjectError(expr_154);
            //        Exception ex = expr_154;
            //        Interaction.MsgBox(ex.Message + "RMA was not created.", MsgBoxStyle.OkOnly, null);
            //        ProjectData.ClearProjectError();

            //        return;
            //    }

            //    int value;

            //    if (Common.IntScalar("select count(*) from CRMRMALines where RMAID = " + Conversions.ToString(this.RMAID) + " and Warranty = 'True'", false) > 0)
            //    {
            //        value = Common.IntScalar("select RMAWarrantyTemplate from CompanyControl", false);
            //    }
            //    else
            //    {
            //        value = Common.IntScalar("select RMATemplate from CompanyControl", false);
            //    }


            //    rptPackingList expr_1C1 = new rptPackingList();

            //    expr_1C1.RequestParameters = false;
            //    expr_1C1.FilterString = (("[RMAID] = " + Conversions.ToString(this.RMAID)) ?? "");



            //    expr_1C1.ExportToPdf(Common.ReportPath + "\\Packing Slip # R" + Conversions.ToString(this.RMAID) + ".pdf");

            //    string messageAttachment = Common.ReportPath + "\\Packing Slip # R" + Conversions.ToString(this.RMAID) + ".pdf";

            //    expr_1C1.CreateDocument();

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
            bool result = true;
            //if (Operators.CompareString(this.cbBranchCode.Text, "", false) == 0)
            //{
            //    Interaction.MsgBox("You must select the Branch Code for the RMA.", MsgBoxStyle.OkOnly, null);
            //    result = false;
            //}
            return result;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            //if (Conversions.ToDouble(Common.StrScalar("select count(*) from CRMRMALines where RMAID = " + Conversions.ToString(this.RMAID) + " and SalesOrderNo is not null", false)) == 0.0)
            //{
            //    if (Interaction.MsgBox("Are you sure you want to delete this RMA.", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Delete RMA") == MsgBoxResult.Yes)
            //    {
            //        Common.LogEntryCRM(base.Name, "DELETE RMA", this.CompanyID, this.ContactID, "RMA ID " + Conversions.ToString(this.RMAID));
            //        Common.NonQuery(("delete from CRMRMALines where RMAID = " + Conversions.ToString(this.RMAID)) ?? "", false);
            //        Common.NonQuery(("delete from CRMRMA where RMAID = " + Conversions.ToString(this.RMAID)) ?? "", false);
            //        Interaction.MsgBox("RMA Deleted", MsgBoxStyle.OkOnly, null);
            //        base.Close();
            //        return;
            //    }
            //}
            //else
            //{
            //    Interaction.MsgBox("You cannot delete a RMA that has already been received.", MsgBoxStyle.OkOnly, null);
            //}
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
