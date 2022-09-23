using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class frmCustIssues : Form
    {
        public frmCustIssues()
        {
            base.Load += new EventHandler(this.frmCustIssues_Load);
            InitializeComponent();
        }

        

        private void frmCustIssues_Load(object sender, EventArgs e)
        {
            //string mF = this.MF;
            //if (Operators.CompareString(mF, "M", false) == 0)
            //{
            //    this.Mike();
            //    return;
            //}
            //if (Operators.CompareString(mF, "F", false) != 0)
            //{
            //    return;
            //}
            //this.Francie();
        }


        private void Mike()
        {
            //this.SQLStr = "select CI.CompanyID, CI.ContactID, CI.ManageUserID as 'RecordManager', Name as 'Company', CI.IRCode, CI.CreateDate as 'Created', CI.CreateUserID as 'Entered By', CI.Notes as 'Issue'  from CRMCustIssues CI join CRMCompany CO on CI.CompanyID = CO.CompanyID where ClosedDate is null and MF = 'M'";
            //this.LoadData();
        }

        private void Francie()
        {
            //this.SQLStr = "select CI.CompanyID, CI.ContactID, CI.ManageUserID as 'RecordManager', Name as 'Company', CI.CreateDate as 'Created', CI.CreateUserID as 'Entered By', CI.Notes  from CRMCustIssues CI join CRMCompany CO on CI.CompanyID = CO.CompanyID where ClosedDate is null and MF = 'F'";
            //this.LoadData();
        }

        private void LoadData()
        {
            DataTable dataTable = new DataTable();
            //this.daSQLDataAdapter = new SqlDataAdapter();
            //this.daSQLDataAdapter = Common.GetGridData(this.SQLStr, false);
            //this.daSQLDataAdapter.Fill(dataTable);
            //this.gdvDataView = new DataView(dataTable);
            this.gridData.DataSource = dataTable;
            this.gridData.Columns[0].Visible = false;
            this.gridData.Columns[1].Visible = false;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridData_DoubleClick(object sender, EventArgs e)
        {
            int index = this.gridData.CurrentRow.Index;
            this.gridData.CurrentRow.Selected = true;
            //this.GOTOContact(Conversions.ToInteger(this.gridData[1, index].Value));
        }

        private void GOTOContact(int ContactID)
        {
            //MyProject.Forms.frmMain.frmShowing = 1;
            //checked
            //{
            //    if (Common.LaptopMonitor)
            //    {
            //        Form[] mdiChildren = MyProject.Forms.frmMain.MdiChildren;
            //        for (int i = 0; i < mdiChildren.Length; i++)
            //        {
            //            Form form = mdiChildren[i];
            //            if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
            //            {
            //                frmContactLaptop expr_52 = (frmContactLaptop)form;
            //                expr_52.ContactID = ContactID;
            //                clsContacts.RefreshData(false);
            //                expr_52.BringToFrontHelper();
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Form[] mdiChildren2 = MyProject.Forms.frmMain.MdiChildren;
            //        for (int j = 0; j < mdiChildren2.Length; j++)
            //        {
            //            Form form2 = mdiChildren2[j];
            //            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
            //            {
            //                frmContact expr_B2 = (frmContact)form2;
            //                expr_B2.ContactID = ContactID;
            //                clsContacts.RefreshData(false);
            //                expr_B2.BringToFrontHelper();
            //                break;
            //            }
            //        }
            //    }
            //    MyProject.Forms.frmMain.SetupLookup();
            //    base.Close();
            //}
        }

        private void cmdComplete_Click(object sender, EventArgs e)
        {
            int index = this.gridData.CurrentRow.Index;
            this.gridData.CurrentRow.Selected = true;
            //Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update CRMCustIssues set ClosedDate = '" + Conversions.ToString(DateTime.Now) + "' where CompanyID = ", this.gridData[0, index].Value), " and ContactID = "), this.gridData[1, index].Value), " ")), false);
            this.LoadData();
        }
    }
}
