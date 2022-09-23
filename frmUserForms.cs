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
    public partial class frmUserForms : Form
    {
        public string tmpGroup;
        public frmUserForms()
        {
            InitializeComponent();
        }

        private void frmUserForms_Load(object sender, EventArgs e)
        {
           // this.UserFormsTableAdapter.FillByNotIn(this.IRDataSet.CRMUserForms, this.tmpGroup);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
        }
    }
}
