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
    public partial class frmPasswordChange : Form
    {
        public frmPasswordChange()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (Common.IntScalar(("select count(*) from CRMUsers where UserID = '" + Common.IRUser + "' and LoginPassword = " + Common.NQ(this.txtOldPass.Text)) ?? "", false) != 1)
            //{
            //    Interaction.MsgBox("Old password is incorrect.", MsgBoxStyle.OkOnly, "Incorrect Password");
            //    return;
            //}
            //if (Operators.CompareString(this.txtNewPass.Text, this.txtConfirmPass.Text, false) == 0)
            //{
            //    Common.NonQuery(string.Concat(new string[]
            //    {
            //        "update CRMUsers set LoginPassword = ",
            //        Common.NQ(this.txtNewPass.Text),
            //        " where UserID = '",
            //        Common.IRUser,
            //        "'"
            //    }), false);
            //    Interaction.MsgBox("Password changed.", MsgBoxStyle.OkOnly, "Success");
            //    base.Close();
            //    return;
            //}
            //Interaction.MsgBox("Passwords do not match.", MsgBoxStyle.OkOnly, "Passwords do not match");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
