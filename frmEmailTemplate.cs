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
    public partial class frmEmailTemplate : Form
    {
        public frmEmailTemplate()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
           // this.SaveData();
        }

        private void frmEmailTemplate_Load(object sender, EventArgs e)
        {
            //this.CRMEmailTemplatesTableAdapter.Fill(this.IRDataSet.CRMEmailTemplates);
            //this.ResetControls();
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            this.CRMEmailTemplatesBindingSource.AddNew();
            base.SuspendLayout();
            base.ResumeLayout();
        }

        private void SaveData()
        {
            //checked
            //{
            //    if (Operators.CompareString(this.tmpFileName, "", false) != 0)
            //    {
            //        int num = Common.IntScalar("select max(DocumentID) from CRMDocuments", false);
            //        while (MyProject.Computer.FileSystem.FileExists(string.Concat(new string[]
            //        {
            //            Common.DocumentPath,
            //            "D",
            //            Conversions.ToString(num),
            //            "_",
            //            this.RealFilename
            //        })))
            //        {
            //            num++;
            //        }
            //        try
            //        {
            //            MyProject.Computer.FileSystem.CopyFile(this.tmpFileName, string.Concat(new string[]
            //            {
            //                Common.DocumentPath,
            //                "D",
            //                Conversions.ToString(num),
            //                "_",
            //                this.RealFilename
            //            }));
            //        }
            //        catch (Exception expr_BB)
            //        {
            //            ProjectData.SetProjectError(expr_BB);
            //            ProjectData.ClearProjectError();
            //        }
            //        this.txtFileName.Text = string.Concat(new string[]
            //        {
            //            Common.DocumentPath,
            //            "D",
            //            Conversions.ToString(num),
            //            "_",
            //            this.RealFilename
            //        });
            //    }
            //    base.Validate();
            //    this.CRMEmailTemplatesBindingSource.EndEdit();
            //    this.CRMEmailTemplatesTableAdapter.Update(this.IRDataSet);
            //}
        }

        private void btnMarker_Click(object sender, EventArgs e)
        {
            //if (Operators.CompareString(this.cbMarker.Text, "", false) != 0)
            //{
            //    string left = Strings.LCase(this.cbMarker.Text);
            //    if (Operators.CompareString(left, "customer first name", false) == 0)
            //    {
            //        int arg_62_0 = this.txtBody.SelectionStart;
            //        this.txtBody.SelectionLength = 1;
            //        this.txtBody.SelectedText = "<FirstName>";
            //        return;
            //    }
            //    if (Operators.CompareString(left, "my email address", false) == 0)
            //    {
            //        int arg_8B_0 = this.txtBody.SelectionStart;
            //        this.txtBody.SelectionLength = 1;
            //        this.txtBody.SelectedText = "<MyEmail>";
            //        return;
            //    }
            //    if (Operators.CompareString(left, "my phone number", false) != 0)
            //    {
            //        return;
            //    }
            //    int arg_B4_0 = this.txtBody.SelectionStart;
            //    this.txtBody.SelectionLength = 1;
            //    this.txtBody.SelectedText = "<MyPhone>";
            //}
        }


        private void ResetControls()
        {
            this.btnEdit.Text = "Allow Edits";
            this.cbMarker.Enabled = false;
            this.btnMarker.Enabled = false;
            this.txtBody.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (Operators.CompareString(this.btnEdit.Text, "Allow Edits", false) == 0)
            //{
            //    this.btnEdit.Text = "Prevent Edits";
            //    this.cbMarker.Enabled = true;
            //    this.btnMarker.Enabled = true;
            //    this.txtBody.ReadOnly = false;
            //    return;
            //}
            //this.ResetControls();
        }

        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.ResetControls();
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.ResetControls();
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.ResetControls();
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.ResetControls();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            //MyProject.Forms.frmMain.OpenFileDialog1.Filter = "All Files|*.*";
            //MyProject.Forms.frmMain.OpenFileDialog1.Multiselect = false;
            //if (MyProject.Forms.frmMain.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.tmpFileName = MyProject.Forms.frmMain.OpenFileDialog1.FileName;
            //    this.RealFilename = MyProject.Computer.FileSystem.GetName(this.tmpFileName);
            //    this.txtFileName.Text = this.RealFilename;
            //    return;
            //}
            //this.Cursor = Cursors.Default;
        }

        private void IdTextBox1_Leave(object sender, EventArgs e)
        {
        //    if (Common.IntScalar("select count(*) from CRMEmailTempletes where TemplateName = '" + this.IdTextBox1.Text + "'", false) > 0)
        //    {
        //        Interaction.MsgBox("Name already in use.", MsgBoxStyle.OkOnly, null);
        //        this.IdTextBox1.Text = "";
        //        return;
        //    }
        //    if (Common.IntScalar("select count(*) from CRMUserForms where FormName = '" + this.IdTextBox1.Text + "'", false) > 0)
        //    {
        //        Interaction.MsgBox("Name already in use.", MsgBoxStyle.OkOnly, null);
        //        this.IdTextBox1.Text = "";
        //    }
        //    if (Strings.InStr(this.IdTextBox1.Text, "TEMPLATE", CompareMethod.Binary) == 0)
        //    {
        //        Interaction.MsgBox("The word template must appear in all template names.", MsgBoxStyle.OkOnly, null);
        //        this.IdTextBox1.Text = "";
        //    }
        }
    }
}
