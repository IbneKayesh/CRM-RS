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
    public partial class frmPickup : Form
    {
        public int PickupID;

        public int ContactID;

        public int CompanyID;

        public string IRCode;

        private bool NewRecord;
        public frmPickup()
        {
            this.NewRecord = false;
            InitializeComponent();
        }

        private void frmPickup_Load(object sender, EventArgs e)
        {
            //if (this.PickupID == 0)
            //{
            //    this.PickupID = clsSO.GetNextRMANo();
            //    this.NewRecord = true;
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "insert into CRMPickup (PickupID, CreateDate, CreateUserID, QuoteDate, PickupDate, CompanyID, ContactID) values  (",
            //        Conversions.ToString(this.PickupID),
            //        ", '",
            //        Conversions.ToString(DateTime.Now),
            //        "','",
            //        Common.IRUser,
            //        "', '",
            //        Conversions.ToString(DateTime.Now),
            //        "', '",
            //        Conversions.ToString(DateTime.Now),
            //        "', ",
            //        Conversions.ToString(this.CompanyID),
            //        ", ",
            //        Conversions.ToString(this.ContactID),
            //        ") "
            //    }), false);
            //}
            //this.Text = this.Text + " (P" + Conversions.ToString(this.PickupID) + ")";
            //this.CRMPickupTableAdapter.FillByPickupID(this.IRDataSet.CRMPickup, this.PickupID);
            //this.CRMPickupLinesTableAdapter.FillByPickupID(this.IRDataSet.CRMPickupLines, new int?(this.PickupID));
            //if (this.NewRecord)
            //{
            //    if (Operators.CompareString(this.IRCode, "", false) != 0)
            //    {
            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection = Common.ConnectToSQL(false);
            //        SqlCommand expr_17D = new SqlCommand("select isnull(Company,''), isnull(S.AddressOne,''), isnull(S.AddressTwo,''), isnull(S.City,''),  isnull(S.State,''), isnull(S.Zip,'') from Customers C left Join CustomerShipTo S on C.DefaultShipToID = S.ShipToID where C.CustomerNo = '" + this.IRCode + "'", sqlConnection);
            //        SqlDataReader sqlDataReader = expr_17D.ExecuteReader();
            //        sqlDataReader.Read();
            //        this.txtCustomer.Text = sqlDataReader.GetString(0);
            //        this.txtAddress1.Text = sqlDataReader.GetString(1);
            //        this.txtAddress2.Text = sqlDataReader.GetString(2);
            //        this.txtCity.Text = sqlDataReader.GetString(3);
            //        this.txtState.Text = sqlDataReader.GetString(4);
            //        this.txtZip.Text = sqlDataReader.GetString(5);
            //        sqlDataReader.Close();
            //        expr_17D.Cancel();
            //        expr_17D.CommandText = (("select ManageUserID, CN.CompanyID, isnull(FirstName,'') + ' ' + isnull(LastName,''), isnull(MainPhone,''), isnull(CellPhone,''),  isnull(Email,'') from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID where ContactID = " + Conversions.ToString(this.ContactID)) ?? "");
            //        sqlDataReader = expr_17D.ExecuteReader();
            //        sqlDataReader.Read();
            //        this.txtRecordManager.Text = sqlDataReader.GetString(0);
            //        this.txtCompanyID.Text = Conversions.ToString(sqlDataReader.GetInt32(1));
            //        this.txtContact.Text = sqlDataReader.GetString(2);
            //        this.txtPhone.Text = sqlDataReader.GetString(3);
            //        this.txtCell.Text = sqlDataReader.GetString(4);
            //        this.txtEmail.Text = sqlDataReader.GetString(5);
            //        expr_17D.Connection.Close();
            //        sqlConnection.Close();
            //        this.txtIRCode.Text = this.IRCode;
            //        this.lblIRCode.Visible = true;
            //        return;
            //    }
            //    SqlConnection sqlConnection2 = new SqlConnection();
            //    sqlConnection2 = Common.ConnectToSQL(false);
            //    SqlCommand expr_305 = new SqlCommand(("select ManageUserID, CN.CompanyID, isnull(FirstName,'') + ' ' + isnull(LastName,''), isnull(MainPhone,''), isnull(CellPhone,''),  isnull(Email,''), isnull(CO.Name,''), isnull(Address1,''), isnull(Address2,''), isnull(City,''), isnull(State,''), isnull(ZipCode,'') from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID where ContactID = " + Conversions.ToString(this.ContactID)) ?? "", sqlConnection2);
            //    SqlDataReader sqlDataReader2 = expr_305.ExecuteReader();
            //    sqlDataReader2.Read();
            //    this.txtRecordManager.Text = sqlDataReader2.GetString(0);
            //    this.txtCompanyID.Text = Conversions.ToString(sqlDataReader2.GetInt32(1));
            //    this.txtContact.Text = sqlDataReader2.GetString(2);
            //    this.txtPhone.Text = sqlDataReader2.GetString(3);
            //    this.txtCell.Text = sqlDataReader2.GetString(4);
            //    this.txtEmail.Text = sqlDataReader2.GetString(5);
            //    this.txtCustomer.Text = sqlDataReader2.GetString(6);
            //    this.txtAddress1.Text = sqlDataReader2.GetString(7);
            //    this.txtAddress2.Text = sqlDataReader2.GetString(8);
            //    this.txtCity.Text = sqlDataReader2.GetString(9);
            //    this.txtState.Text = sqlDataReader2.GetString(10);
            //    this.txtZip.Text = sqlDataReader2.GetString(11);
            //    expr_305.Connection.Close();
            //    sqlConnection2.Close();
            //}
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //if (this.NewRecord)
            //{
            //    Common.NonQuery(("delete from CRMPickup where PickupID = " + Conversions.ToString(this.PickupID)) ?? "", false);
            //    Common.NonQuery(("delete from CRMPickupLines where PickupID = " + Conversions.ToString(this.PickupID)) ?? "", false);
            //}
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.gridDetails.AllowUserToAddRows = false;
            if (!this.ValidateForm())
            {
                this.gridDetails.AllowUserToAddRows = true;
                return;
            }
            checked
            {
                //int num = this.gridDetails.RowCount - 1;
                //for (int i = 0; i <= num; i++)
                //{
                //    this.gridDetails[1, i].Value = this.PickupID;
                //    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[7, i].Value)))
                //    {
                //        this.gridDetails[7, i].Value = false;
                //    }
                //    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[9, i].Value)))
                //    {
                //        this.gridDetails[9, i].Value = false;
                //    }
                //    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.gridDetails[10, i].Value)))
                //    {
                //        this.gridDetails[10, i].Value = false;
                //    }
                //}
                //try
                //{
                //    base.Validate();
                //    this.CRMPickupBindingSource.EndEdit();
                //    this.CRMPickupTableAdapter.Update(this.IRDataSet.CRMPickup);
                //    this.CRMPickupLinesBindingSource.EndEdit();
                //    this.CRMPickupLinesTableAdapter.Update(this.IRDataSet.CRMPickupLines);
                //}
                //catch (Exception expr_154)
                //{
                //    ProjectData.SetProjectError(expr_154);
                //    Exception ex = expr_154;
                //    Interaction.MsgBox(ex.Message + "Pickup was not created.", MsgBoxStyle.OkOnly, null);
                //    ProjectData.ClearProjectError();
                //    return;
                //}
                //int value = Common.IntScalar("select PickupTemplate from CompanyControl", false);
                //rptPickupRequest expr_190 = new rptPickupRequest();
                //expr_190.RequestParameters = false;
                //expr_190.FilterString = (("[PickupID] = " + Conversions.ToString(this.PickupID)) ?? "");
                //expr_190.ExportToPdf(Common.ReportPath + "\\Pickup Request # P" + Conversions.ToString(this.PickupID) + ".pdf");
                //string messageAttachment = Common.ReportPath + "\\Pickup Request # P" + Conversions.ToString(this.PickupID) + ".pdf";
                //expr_190.CreateDocument();
                //SqlConnection connection = new SqlConnection();
                //connection = Common.ConnectToSQL(false);
                //SqlDataReader sqlDataReader = new SqlCommand(("Select isnull(Subject,''), isnull(Body,'') from CRMEmailTemplates where TemplateID = " + Conversions.ToString(value)) ?? "", connection).ExecuteReader();
                //sqlDataReader.Read();
                //if (this.ckPartial2.CheckState == CheckState.Checked)
                //{
                //    Email.SendEmail(Email.FormatBody(sqlDataReader.GetString(1), this.ContactID, 0), sqlDataReader.GetString(0), this.txtEmail.Text, "NONE", "NONE", messageAttachment);
                //}
                //else
                //{
                //    string fileName = Common.ReportPath + "\\Pickup Request # P" + Conversions.ToString(this.PickupID) + ".pdf";
                //    int num2 = Common.IntScalar("select max(DocumentID) from CRMDocuments", false);
                //    while (MyProject.Computer.FileSystem.FileExists(string.Concat(new string[]
                //    {
                //        Common.DocumentPath,
                //        "D",
                //        Conversions.ToString(num2),
                //        "_Pickup Request # P",
                //        Conversions.ToString(this.PickupID),
                //        ".pdf"
                //    })))
                //    {
                //        num2++;
                //    }
                //    if (Common.NonQuery(string.Concat(new string[]
                //    {
                //        "insert into CRMDocuments (FileName, DisplayName, FilePath, CompanyID, ContactID, DocumentDate) values  ('D",
                //        Conversions.ToString(num2),
                //        "_Pickup Request # P",
                //        Conversions.ToString(this.PickupID),
                //        ".pdf', 'Pickup Request # P",
                //        Conversions.ToString(this.PickupID),
                //        ".pdf',  '",
                //        Common.DocumentPath,
                //        "D",
                //        Conversions.ToString(num2),
                //        "_Pickup Request # P",
                //        Conversions.ToString(this.PickupID),
                //        ".pdf', ",
                //        Conversions.ToString(this.CompanyID),
                //        ", ",
                //        Conversions.ToString(this.ContactID),
                //        ", '",
                //        Conversions.ToString(DateTime.Now),
                //        "')"
                //    }), false) == 1)
                //    {
                //        try
                //        {
                //            MyProject.Computer.FileSystem.CopyFile(Common.ReportPath + "\\Pickup Request # P" + Conversions.ToString(this.PickupID) + ".pdf", string.Concat(new string[]
                //            {
                //                Common.DocumentPath,
                //                "D",
                //                Conversions.ToString(num2),
                //                "_Pickup Request # P",
                //                Conversions.ToString(this.PickupID),
                //                ".pdf"
                //            }));
                //        }
                //        catch (Exception expr_468)
                //        {
                //            ProjectData.SetProjectError(expr_468);
                //            ProjectData.ClearProjectError();
                //        }
                //    }
                //    new Process();
                //    try
                //    {
                //        Process.Start(fileName, Conversions.ToString(3));
                //    }
                //    catch (Exception expr_48D)
                //    {
                //        ProjectData.SetProjectError(expr_48D);
                //        Exception ex2 = expr_48D;
                //        Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, "Document Error");
                //        ProjectData.ClearProjectError();
                //    }
                //}
                this.Close();
            }
        }
        private bool ValidateForm()
        {
            return true;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("Are you sure you want to delete this pickup list.", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Delete Pickup List") == MsgBoxResult.Yes)
            //{
            //    Common.LogEntryCRM(base.Name, "DELETE PICKUP", this.CompanyID, this.ContactID, "Pickup ID " + Conversions.ToString(this.PickupID));
            //    Common.NonQuery(("delete from CRMPickupLines where PickupID = " + Conversions.ToString(this.PickupID)) ?? "", false);
            //    Common.NonQuery(("delete from CRMPickup where PickupID = " + Conversions.ToString(this.PickupID)) ?? "", false);
            //    Interaction.MsgBox("Pickup Deleted", MsgBoxStyle.OkOnly, null);
            //    base.Close();
            //}
        }
    }
}
