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
    public partial class frmLookup : Form
    {
        private string GridSQLStr;

        public string frm;

        private SqlDataAdapter daSQLDataAdapter;

        private DataView gdvDataView;

        private string SearchString;

        private int ColumnLookUp;

        public frmLookup()
        {
            InitializeComponent();
            //base.MdiParent = MyProject.Forms.frmMain;
            //MyProject.Forms.frmMain.Show();
        }
        public frmLookup(string fm, string LookupSTR)
        {
            base.Load += new EventHandler(this.frmLookup_Load);
            base.KeyDown += new KeyEventHandler(this.frmLookup_KeyDown);
            this.InitializeComponent();
            this.GridSQLStr = LookupSTR;
            this.frm = fm;
        }
        private void frmLookup_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            this.daSQLDataAdapter = new SqlDataAdapter();
            //this.daSQLDataAdapter = Common.GetGridData(this.GridSQLStr, false);
            //this.daSQLDataAdapter.Fill(dataTable);
            //this.gdvDataView = new DataView(dataTable);
            //this.gridLookup.DataSource = dataTable;
            //this.gridLookup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //checked
            //{
            //    int num = this.gridLookup.ColumnCount - 1;
            //    for (int i = 0; i <= num; i++)
            //    {
            //        this.gridLookup.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            //    }
            //    this.gridLookup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //    string left = this.frm;
            //    if (Operators.CompareString(left, "SalesPeople", false) != 0)
            //    {
            //        if (Operators.CompareString(left, "Customer", false) != 0)
            //        {
            //            if (Operators.CompareString(left, "Vendors", false) != 0)
            //            {
            //                if (Operators.CompareString(left, "Manufacturers", false) != 0)
            //                {
            //                    if (Operators.CompareString(left, "User", false) == 0)
            //                    {
            //                        this.btnFind.Visible = false;
            //                        this.btnNew.Visible = true;
            //                        this.btnNew.Text = "Add User";
            //                    }
            //                }
            //                else
            //                {
            //                    this.btnFind.Visible = false;
            //                    this.btnNew.Visible = true;
            //                    this.btnNew.Text = "Add Manf";
            //                }
            //            }
            //            else
            //            {
            //                this.btnFind.Visible = false;
            //                this.btnNew.Visible = true;
            //                this.btnNew.Text = "Add Vendor";
            //                base.MinimizeBox = true;
            //            }
            //        }
            //        else
            //        {
            //            this.btnFind.Visible = true;
            //            this.btnNew.Visible = true;
            //            this.btnNew.Text = "Add Customer";
            //        }
            //    }
            //    else
            //    {
            //        this.btnFind.Visible = false;
            //        this.btnNew.Visible = true;
            //        this.btnNew.Text = "Add Salesperson";
            //        this.gridLookup.Columns[2].Visible = false;
            //    }
            //    this.Text = this.frm + " Lookup";
            //}
        }

        private void frmLookup_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.Return)
            {
                this.loadnewForms();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string left = this.frm;
            //if (Operators.CompareString(left, "Customer", false) != 0 && Operators.CompareString(left, "SalesPeople", false) != 0 && Operators.CompareString(left, "Vendors", false) != 0 && Operators.CompareString(left, "Manufacturers", false) != 0 && Operators.CompareString(left, "User", false) == 0)
            //{
            //    frmUser frmUser = new frmUser();
            //    if (Common.CanUseForm(Conversions.ToString(frmUser.Tag), false))
            //    {
            //        frmUser.Icon = MyProject.Forms.frmMain.Icon;
            //        frmUser.UserID = "";
            //        Common.LogEntryCRM(base.Name, "CREATE", 0, 0, "");
            //        frmUser.ShowDialog();
            //    }
            //}
        }
        private void cmdRefresh()
        {
            DataTable dataTable = new DataTable();
            this.daSQLDataAdapter = new SqlDataAdapter();
            //this.daSQLDataAdapter = Common.GetGridData(this.GridSQLStr, false);
            this.daSQLDataAdapter.Fill(dataTable);
            this.gdvDataView = new DataView(dataTable);
            this.gridLookup.DataSource = dataTable;
            checked
            {
                int num = this.gridLookup.ColumnCount - 1;
                for (int i = 0; i <= num; i++)
                {
                    this.gridLookup.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            checked
            {
                if (this.txtValue.Text.Length > 0)
                {
                    string left = this.frm;
                    //if (Operators.CompareString(left, "Vendors", false) == 0 || Operators.CompareString(left, "Manufacturers", false) == 0)
                    //{
                    //    this.ColumnLookUp = 1;
                    //}
                    //else
                    //{
                    //    this.ColumnLookUp = 0;
                    //}
                    //int num = this.gridLookup.RowCount - 1;
                    //for (int i = 0; i <= num; i++)
                    //{
                    //    if (Operators.ConditionalCompareObjectGreaterEqual(this.gridLookup[this.ColumnLookUp, i].Value, this.txtValue.Text, false))
                    //    {
                    //        DataGridViewCell currentCell = this.gridLookup[this.ColumnLookUp, i];
                    //        this.gridLookup.CurrentCell = currentCell;
                    //        return;
                    //    }
                    //}
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.txtValue.Text = "";
            string connector = "like";
            this.Cursor = Cursors.WaitCursor;
            //frmInput frmInput = new frmInput();
            //if (Operators.CompareString(Common.SentCustNo, "", false) != 0)
            //{
            //    Common.PickedCustNo = "NONE";
            //    string left = this.frm;
            //    if (Operators.CompareString(left, "Customer", false) != 0 && Operators.CompareString(left, "Vendors", false) != 0)
            //    {
            //        Operators.CompareString(left, "Manufacturers", false);
            //    }
            //    frmInput.Close();
            //    base.Close();
            //    return;
            //}
            //if (Operators.CompareString(Common.PickedCustNo, "NONE", false) != 0)
            //{
            //    string left2 = this.frm;
            //    if (Operators.CompareString(left2, "Customer", false) != 0)
            //    {
            //        if (Operators.CompareString(left2, "Vendors", false) != 0)
            //        {
            //            if (Operators.CompareString(left2, "Manufacturers Search", false) == 0)
            //            {
            //                frmInput.Text = "Manf Search";
            //            }
            //        }
            //        else
            //        {
            //            frmInput.Text = "Vendor Search";
            //        }
            //    }
            //    else
            //    {
            //        frmInput.Text = "Customer Search";
            //    }
            //    frmInput.frm = this.frm;
            //    frmInput.ShowDialog();
            //    if (frmInput.DialogResult != DialogResult.OK)
            //    {
            //        this.Cursor = Cursors.Default;
            //        frmInput.Close();
            //        return;
            //    }
            //}
            //else
            //{
            //    Common.PickedCustNo = "";
            //}
            //frmInput.SearchFor.Text = "%" + frmInput.SearchFor.Text + "%";
            //frmInput.SearchBy.Text = clsSQLSearches.SetSearchBy1(frmInput.SearchBy.Text, this.frm);
            //int num;
            //if (Strings.Len(frmInput.CustNameAddr.Text) <= 0)
            //{
            //    string left3 = this.frm;
            //    if (Operators.CompareString(left3, "Customer", false) != 0)
            //    {
            //        if (Operators.CompareString(left3, "Vendors", false) != 0)
            //        {
            //            if (Operators.CompareString(left3, "Manufacturers", false) == 0)
            //            {
            //                this.SearchString = clsSQLSearches.SetMasterCust(ref frmInput, connector);
            //            }
            //        }
            //        else
            //        {
            //            this.SearchString = clsSQLSearches.SetMasterCust(ref frmInput, connector);
            //        }
            //    }
            //    else
            //    {
            //        this.SearchString = clsSQLSearches.SetMasterCust(ref frmInput, connector);
            //    }
            //    num = Common.RecordCount(this.SearchString);
            //    if (num > 10000)
            //    {
            //        Interaction.MsgBox("Your search returned " + Conversions.ToString(num) + ". Please refine you search.", MsgBoxStyle.Critical, "Search Canceled");
            //        this.Cursor = Cursors.Default;
            //        frmInput.Close();
            //        return;
            //    }
            //    if (num <= 1)
            //    {
            //        if (num == 0)
            //        {
            //            frmInput.Close();
            //            Interaction.MsgBox("Sorry no records were found", MsgBoxStyle.OkOnly, null);
            //            this.Cursor = Cursors.Default;
            //            return;
            //        }
            //        Common.SentCustNo = Common.StrScalar(this.SearchString, false);
            //        string left4 = this.frm;
            //        if (Operators.CompareString(left4, "Customer", false) != 0 && Operators.CompareString(left4, "Vendors", false) != 0)
            //        {
            //            Operators.CompareString(left4, "Manufacturers", false);
            //        }
            //        frmInput.Close();
            //        base.Close();
            //        return;
            //    }
            //}
            //if (Strings.Len(frmInput.CustNameAddr.Text) > 0)
            //{
            //    string left5 = this.frm;
            //    if (Operators.CompareString(left5, "Customer", false) != 0)
            //    {
            //        if (Operators.CompareString(left5, "Vendors", false) != 0)
            //        {
            //            if (Operators.CompareString(left5, "Manufacturers", false) == 0)
            //            {
            //                this.SearchString = clsSQLSearches.SetGridSearchStringCustName(ref frmInput, connector);
            //            }
            //        }
            //        else
            //        {
            //            this.SearchString = clsSQLSearches.SetGridSearchStringCustName(ref frmInput, connector);
            //        }
            //    }
            //    else
            //    {
            //        this.SearchString = clsSQLSearches.SetGridSearchStringCustName(ref frmInput, connector);
            //    }
            //}
            //else
            //{
            //    string left6 = this.frm;
            //    if (Operators.CompareString(left6, "Customer", false) != 0)
            //    {
            //        if (Operators.CompareString(left6, "Vendors", false) != 0)
            //        {
            //            if (Operators.CompareString(left6, "Manufacturers", false) == 0)
            //            {
            //                this.SearchString = clsSQLSearches.SetGridSearchStringCustName(ref frmInput, connector);
            //            }
            //        }
            //        else
            //        {
            //            this.SearchString = clsSQLSearches.SetGridSearchStringCustName(ref frmInput, connector);
            //        }
            //    }
            //    else
            //    {
            //        this.SearchString = clsSQLSearches.SetGridSearchStringCust(ref frmInput, connector);
            //    }
            //}
            //num = Common.RecordCount(this.SearchString);
            //if (num == 1)
            //{
            //    string left7 = this.frm;
            //    if (Operators.CompareString(left7, "Customer", false) != 0 && Operators.CompareString(left7, "Vendors", false) != 0)
            //    {
            //        Operators.CompareString(left7, "Manufacturers", false);
            //    }
            //    frmInput.Close();
            //    base.Close();
            //    return;
            //}
            //if (num == 0)
            //{
            //    frmInput.Close();
            //    Interaction.MsgBox("Sorry no records were found", MsgBoxStyle.OkOnly, null);
            //    this.Cursor = Cursors.Default;
            //    return;
            //}
            //DataTable dataTable = new DataTable();
            //this.daSQLDataAdapter = new SqlDataAdapter();
            //this.daSQLDataAdapter = Common.GetGridData(this.SearchString, false);
            //this.daSQLDataAdapter.Fill(dataTable);
            //this.gdvDataView = new DataView(dataTable);
            //this.gridLookup.DataSource = dataTable;
            //frmInput.Close();
            //this.Cursor = Cursors.Default;
            //checked
            //{
            //    int num2 = this.gridLookup.ColumnCount - 1;
            //    for (int i = 0; i <= num2; i++)
            //    {
            //        this.gridLookup.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            //    }
            //}
        }

        private void gridLookup_DoubleClick(object sender, EventArgs e)
        {
            this.loadnewForms();
        }

        private void loadnewForms()
        {
            int index = this.gridLookup.CurrentRow.Index;
            string left = this.frm;
            //if (Operators.CompareString(left, "Customer", false) != 0 && Operators.CompareString(left, "SalesPeople", false) != 0 && Operators.CompareString(left, "Vendors", false) != 0 && Operators.CompareString(left, "Manufacturers", false) != 0 && Operators.CompareString(left, "User", false) == 0)
            //{
            //    frmUser frmUser = new frmUser();
            //    if (Common.CanUseForm(Conversions.ToString(frmUser.Tag), false))
            //    {
            //        frmUser.Icon = MyProject.Forms.frmMain.Icon;
            //        frmUser.UserID = Conversions.ToString(this.gridLookup[0, index].Value);
            //        frmUser.ShowDialog();
            //    }
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
