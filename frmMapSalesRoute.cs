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
    public partial class frmMapSalesRoute : Form
    {
        public frmMapSalesRoute()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //frmMainMap frmMainMap = new frmMainMap();
            //if (Common.CanUseForm(Conversions.ToString(frmMainMap.Tag), false))
            //{
            //    frmMainMap.MdiParent = MyProject.Forms.frmMain;
            //    frmMainMap.ManageUserID = this.cbRecordManager.Text;
            //    frmMainMap.StartDate = Conversions.ToDate(this.dtStart.EditValue);
            //    frmMainMap.EndDate = Conversions.ToDate(this.dtEnd.EditValue);
            //    frmMainMap.MapType = "Sales Route";
            //    frmMainMap.Icon = base.Icon;
            //    frmMainMap.Show();
            //    this.Cursor = Cursors.Default;
            //    base.Close();
            //}
        }

        private void frmMapSalesRoute_Load(object sender, EventArgs e)
        {
            //this.ManageUserComboTableAdapter.Fill(this.IRDataSetViews.ManageUserCombo);
            //this.dtStart.EditValue = DateTime.Today.Date;
            //this.dtEnd.EditValue = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateTime.Today.Date);
        }
    }
}
