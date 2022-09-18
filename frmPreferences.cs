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
    public partial class frmPreferences : Form
    {
        public frmPreferences()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            //if (MyProject.Computer.FileSystem.FileExists(Common.CommonFolder + "\\Preferences.ini"))
            //{
            //    FileSystem.FileOpen(1, Common.CommonFolder + "\\Preferences.ini", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
            //    int num = 0;
            //    try
            //    {
            //        num = Conversions.ToInteger(FileSystem.LineInput(1));
            //    }
            //    catch (Exception expr_4C)
            //    {
            //        ProjectData.SetProjectError(expr_4C);
            //        num = 0;
            //        ProjectData.ClearProjectError();
            //    }
            //    if (num == 1)
            //    {
            //        this.ckContacts.CheckState = CheckState.Checked;
            //    }
            //    else
            //    {
            //        this.ckContacts.CheckState = CheckState.Unchecked;
            //    }
            //    try
            //    {
            //        num = Conversions.ToInteger(FileSystem.LineInput(1));
            //    }
            //    catch (Exception expr_89)
            //    {
            //        ProjectData.SetProjectError(expr_89);
            //        num = 0;
            //        ProjectData.ClearProjectError();
            //    }
            //    if (num == 1)
            //    {
            //        this.ckHistory.CheckState = CheckState.Checked;
            //    }
            //    else
            //    {
            //        this.ckHistory.CheckState = CheckState.Unchecked;
            //    }
            //    try
            //    {
            //        num = Conversions.ToInteger(FileSystem.LineInput(1));
            //    }
            //    catch (Exception expr_C6)
            //    {
            //        ProjectData.SetProjectError(expr_C6);
            //        num = 0;
            //        ProjectData.ClearProjectError();
            //    }
            //    if (num == 1)
            //    {
            //        this.ckHideInactive.CheckState = CheckState.Checked;
            //    }
            //    else
            //    {
            //        this.ckHideInactive.CheckState = CheckState.Unchecked;
            //    }
            //    try
            //    {
            //        num = Conversions.ToInteger(FileSystem.LineInput(1));
            //    }
            //    catch (Exception expr_103)
            //    {
            //        ProjectData.SetProjectError(expr_103);
            //        num = 0;
            //        ProjectData.ClearProjectError();
            //    }
            //    if (num == 1)
            //    {
            //        this.ckLaptop.CheckState = CheckState.Checked;
            //    }
            //    else
            //    {
            //        this.ckLaptop.CheckState = CheckState.Unchecked;
            //    }
            //    try
            //    {
            //        num = Conversions.ToInteger(FileSystem.LineInput(1));
            //    }
            //    catch (Exception expr_141)
            //    {
            //        ProjectData.SetProjectError(expr_141);
            //        num = 0;
            //        ProjectData.ClearProjectError();
            //    }
            //    if (num == 1)
            //    {
            //        this.ckMirror.CheckState = CheckState.Checked;
            //    }
            //    else
            //    {
            //        this.ckMirror.CheckState = CheckState.Unchecked;
            //    }
            //    try
            //    {
            //        num = Conversions.ToInteger(FileSystem.LineInput(1));
            //    }
            //    catch (Exception expr_17F)
            //    {
            //        ProjectData.SetProjectError(expr_17F);
            //        num = 0;
            //        ProjectData.ClearProjectError();
            //    }
            //    if (num == 1)
            //    {
            //        this.ckLocal.CheckState = CheckState.Checked;
            //    }
            //    else
            //    {
            //        this.ckLocal.CheckState = CheckState.Unchecked;
            //    }
            //    FileSystem.FileClose(new int[]
            //    {
            //        1
            //    });
            //}
            //else
            //{
            //    this.ckContacts.CheckState = CheckState.Checked;
            //    this.ckHistory.CheckState = CheckState.Unchecked;
            //}
            //if (Common.CanUseForm("ALLCONTACTS", true))
            //{
            //    this.ckContacts.Visible = true;
            //    return;
            //}
            this.ckContacts.Visible = false;
            this.ckContacts.CheckState = CheckState.Unchecked;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FileSystem.FileOpen(1, Common.CommonFolder + "\\Preferences.ini", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
            //    if (this.ckContacts.Visible)
            //    {
            //        if (this.ckContacts.CheckState == CheckState.Checked)
            //        {
            //            FileSystem.PrintLine(1, new object[]
            //            {
            //                "1"
            //            });
            //        }
            //        else
            //        {
            //            FileSystem.PrintLine(1, new object[]
            //            {
            //                "0"
            //            });
            //        }
            //    }
            //    else
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "0"
            //        });
            //    }
            //    if (this.ckHistory.CheckState == CheckState.Checked)
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "1"
            //        });
            //    }
            //    else
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "0"
            //        });
            //    }
            //    if (this.ckHideInactive.CheckState == CheckState.Checked)
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "1"
            //        });
            //    }
            //    else
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "0"
            //        });
            //    }
            //    if (this.ckLaptop.CheckState == CheckState.Checked)
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "1"
            //        });
            //    }
            //    else
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "0"
            //        });
            //    }
            //    if (this.ckMirror.CheckState == CheckState.Checked)
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "1"
            //        });
            //    }
            //    else
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "0"
            //        });
            //    }
            //    if (this.ckLocal.CheckState == CheckState.Checked)
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "1"
            //        });
            //    }
            //    else
            //    {
            //        FileSystem.PrintLine(1, new object[]
            //        {
            //            "0"
            //        });
            //    }
            //    FileSystem.FileClose(new int[]
            //    {
            //        1
            //    });
            //}
            //catch (Exception expr_19D)
            //{
            //    ProjectData.SetProjectError(expr_19D);
            //    ProjectData.ClearProjectError();
            //}
            //base.Close();
        }
    }
}
