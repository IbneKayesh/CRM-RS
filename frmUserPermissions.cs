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
    public partial class frmUserPermissions : Form
    {
        public string LocalUserID;

        private SqlDataAdapter daSQLDataAdapter;

        private DataView gdvDataView;
        public frmUserPermissions()
        {
            InitializeComponent();
        }

        private void frmUserPermissions_Load(object sender, EventArgs e)
        {
            //this.UserFormsTableAdapter.FillByUserNotIn(this.IRDataSet.CRMUserForms, this.LocalUserID);
            this.FillGrid();
        }
        private void FillGrid()
        {
            //string sQLStr = "select FormName from CRMUserPermissions where UserID = '" + this.LocalUserID + "' order by FormName";
            DataTable dataTable = new DataTable();
            //this.daSQLDataAdapter = new SqlDataAdapter();
            //this.daSQLDataAdapter = Common.GetGridData(sQLStr, false);
            //this.daSQLDataAdapter.Fill(dataTable);
            this.gdvDataView = new DataView(dataTable);
            this.GridData.DataSource = dataTable;
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
    //        Common.NonQuery(string.Concat(new string[]
    //{
    //            "insert into CRMUserPermissions (UserID, FormName) values (",
    //            Common.NQ(Strings.UCase(this.LocalUserID)),
    //            ", ",
    //            Common.NQ(Strings.UCase(this.cbPermissions.Text)),
    //            ")"
    //}), false);
            this.FillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string text = "";
            //checked
            //{
            //    int num = this.GridData.RowCount - 1;
            //    for (int i = 0; i <= num; i++)
            //    {
            //        if (this.GridData.Rows[i].Selected)
            //        {
            //            text = Conversions.ToString(this.GridData[0, i].Value);
            //        }
            //    }
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "delete from CRMUserPermissions where UserID = '",
            //        this.LocalUserID,
            //        "' and FormName = '",
            //        text,
            //        "'"
            //    }), false);
            //    this.FillGrid();
            //}
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }
    }
}
