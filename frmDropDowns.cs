using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM
{
    public partial class frmDropDowns : Form
    {
        public frmDropDowns()
        {
            base.Load += new EventHandler(this.frmDropDowns_Load);
            //this.ComboCode = 0;
            this.InitializeComponent();
        }
      

        

        private void frmDropDowns_Load(object sender, EventArgs e)
        {
            //idComboBox cbDropDowns = this.cbDropDowns;
            //Common.FillCombo(ref cbDropDowns, "select distinct upper(ComboName) as 'ComboName' from CRMComboData order by 'ComboName'", "ComboName", "NONE");
            //this.cbDropDowns = cbDropDowns;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string sOriginalValue = "";
            //string sOriginalValue2 = "";
            //string text = this.cbDropDowns.Text;
            //if (Operators.CompareString(text, "", false) != 0)
            //{
            //    switch (this.ComboCode)
            //    {
            //        case 1:
            //            sOriginalValue = Common.idInput("New entry name", "Entry Name", "", 42, "S", 2, 10, "", "");
            //            break;
            //        case 2:
            //            sOriginalValue = Common.idInput("New entry name", "Entry Name", "", 42, "S", 2, 10, "", "");
            //            sOriginalValue2 = Common.idInput("New entry description", "Entry Description", "", 128, "S", 2, 10, "", "");
            //            break;
            //        case 3:
            //            sOriginalValue2 = Common.idInput("New entry name", "Entry Name", "", 128, "S", 2, 10, "", "");
            //            break;
            //        default:
            //            return;
            //    }
            //    if (Common.NonQuery(string.Concat(new string[]
            //    {
            //        "insert into CRMComboData (Name, Description, ComboName) values (",
            //        Common.NQ(sOriginalValue),
            //        ", ",
            //        Common.NQ(sOriginalValue2),
            //        ", ",
            //        Common.NQ(text),
            //        ")"
            //    }), false) == 1)
            //    {
            //        Common.Popup("Entry inserted", "", 2000);
            //        this.LoadDropDowns();
            //        return;
            //    }
            //    Interaction.MsgBox("There was an error inserting the new entry", MsgBoxStyle.OkOnly, null);
            //}
        }

        private void LoadDropDowns()
        {
        //    string text = Strings.UCase(this.cbDropDowns.Text);
        //    uint num = ComputeStringHash(text);
        //    idComboBox cbItems;
        //    if (num <= 2171759244u)
        //    {
        //        if (num <= 707538136u)
        //        {
        //            if (num <= 319284447u)
        //            {
        //                if (num <= 123687180u)
        //                {
        //                    if (num != 42374885u)
        //                    {
        //                        if (num != 123687180u)
        //                        {
        //                            return;
        //                        }
        //                        if (Operators.CompareString(text, "PRODUCT", false) != 0)
        //                        {
        //                            return;
        //                        }
        //                        cbItems = this.cbItems;
        //                        Common.FillCombo(ref cbItems, "Select upper(Description) as 'Name', RecordID from CRMComboData where ComboName = '" + this.cbDropDowns.Text + "' order by 'Name'", "Name", "RecordID");
        //                        this.cbItems = cbItems;
        //                        this.ComboCode = 3;
        //                        return;
        //                    }
        //                    else if (Operators.CompareString(text, "LAST NAME SUFFIXES", false) != 0)
        //                    {
        //                        return;
        //                    }
        //                }
        //                else if (num != 202344641u)
        //                {
        //                    if (num != 319284447u)
        //                    {
        //                        return;
        //                    }
        //                    if (Operators.CompareString(text, "CLASS", false) != 0)
        //                    {
        //                        return;
        //                    }
        //                }
        //                else if (Operators.CompareString(text, "REFERED BY", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (num <= 352731493u)
        //            {
        //                if (num != 338683789u)
        //                {
        //                    if (num != 352731493u)
        //                    {
        //                        return;
        //                    }
        //                    if (Operators.CompareString(text, "EQUIPMENT 2", false) != 0)
        //                    {
        //                        return;
        //                    }
        //                }
        //                else if (Operators.CompareString(text, "TYPE", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (num != 642206725u)
        //            {
        //                if (num != 675456877u)
        //                {
        //                    if (num != 707538136u)
        //                    {
        //                        return;
        //                    }
        //                    if (Operators.CompareString(text, "COMPETITION", false) != 0)
        //                    {
        //                        return;
        //                    }
        //                }
        //                else if (Operators.CompareString(text, "COUNTRIES", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (Operators.CompareString(text, "PICKUP", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (num <= 1814168832u)
        //        {
        //            if (num <= 1478357791u)
        //            {
        //                if (num != 721484232u)
        //                {
        //                    if (num != 1478357791u)
        //                    {
        //                        return;
        //                    }
        //                    if (Operators.CompareString(text, "STATES", false) != 0)
        //                    {
        //                        return;
        //                    }
        //                    goto IL_4E0;
        //                }
        //                else if (Operators.CompareString(text, "PRODUCT UNIT OF ISSUE", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (num != 1711530060u)
        //            {
        //                if (num != 1814168832u)
        //                {
        //                    return;
        //                }
        //                if (Operators.CompareString(text, "FIRST NAME PREFIXES", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (Operators.CompareString(text, "TEAM", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (num <= 1898297631u)
        //        {
        //            if (num != 1857679755u)
        //            {
        //                if (num != 1898297631u)
        //                {
        //                    return;
        //                }
        //                if (Operators.CompareString(text, "MEETING REGARDING", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (Operators.CompareString(text, "JOBTITLES", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (num != 1971096494u)
        //        {
        //            if (num != 2073035523u)
        //            {
        //                if (num != 2171759244u)
        //                {
        //                    return;
        //                }
        //                if (Operators.CompareString(text, "COMPANY ID/STATUS", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (Operators.CompareString(text, "TO-DO REGARDING", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (Operators.CompareString(text, "COMPETITION 2", false) != 0)
        //        {
        //            return;
        //        }
        //    }
        //    else if (num <= 3199234921u)
        //    {
        //        if (num <= 2445214871u)
        //        {
        //            if (num <= 2390538515u)
        //            {
        //                if (num != 2255264823u)
        //                {
        //                    if (num != 2390538515u)
        //                    {
        //                        return;
        //                    }
        //                    if (Operators.CompareString(text, "LAST RESULTS", false) != 0)
        //                    {
        //                        return;
        //                    }
        //                }
        //                else if (Operators.CompareString(text, "HOBBY", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (num != 2428344022u)
        //            {
        //                if (num != 2445214871u)
        //                {
        //                    return;
        //                }
        //                if (Operators.CompareString(text, "EQUIPMENT", false) != 0)
        //                {
        //                    return;
        //                }
        //                goto IL_4E0;
        //            }
        //            else
        //            {
        //                if (Operators.CompareString(text, "ADDRESS TYPES", false) != 0)
        //                {
        //                    return;
        //                }
        //                goto IL_4E0;
        //            }
        //        }
        //        else if (num <= 2621160833u)
        //        {
        //            if (num != 2503537906u)
        //            {
        //                if (num != 2621160833u)
        //                {
        //                    return;
        //                }
        //                if (Operators.CompareString(text, "CLASSIFICATION", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                if (Operators.CompareString(text, "PHONE TYPES", false) != 0)
        //                {
        //                    return;
        //                }
        //                goto IL_4E0;
        //            }
        //        }
        //        else if (num != 3035571179u)
        //        {
        //            if (num != 3145461884u)
        //            {
        //                if (num != 3199234921u)
        //                {
        //                    return;
        //                }
        //                if (Operators.CompareString(text, "TERRITORY", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (Operators.CompareString(text, "DEPARTMENTS", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (Operators.CompareString(text, "CONTACT ID/STATUS", false) != 0)
        //        {
        //            return;
        //        }
        //    }
        //    else if (num <= 3529609855u)
        //    {
        //        if (num <= 3261357017u)
        //        {
        //            if (num != 3229563407u)
        //            {
        //                if (num != 3261357017u)
        //                {
        //                    return;
        //                }
        //                if (Operators.CompareString(text, "ACCESS LEVEL", false) != 0)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (Operators.CompareString(text, "VACATION REGARDING", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (num != 3346287667u)
        //        {
        //            if (num != 3529609855u)
        //            {
        //                return;
        //            }
        //            if (Operators.CompareString(text, "INDUSTRY", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (Operators.CompareString(text, "PERSONAL ACTIVITY REGARDING", false) != 0)
        //        {
        //            return;
        //        }
        //    }
        //    else if (num <= 3606992460u)
        //    {
        //        if (num != 3534182733u)
        //        {
        //            if (num != 3606992460u)
        //            {
        //                return;
        //            }
        //            if (Operators.CompareString(text, "CALL REGARDING", false) != 0)
        //            {
        //                return;
        //            }
        //        }
        //        else if (Operators.CompareString(text, "SPORT", false) != 0)
        //        {
        //            return;
        //        }
        //    }
        //    else if (num != 3791777883u)
        //    {
        //        if (num != 4016649746u)
        //        {
        //            if (num != 4216680762u)
        //            {
        //                return;
        //            }
        //            if (Operators.CompareString(text, "EMAIL TYPES", false) != 0)
        //            {
        //                return;
        //            }
        //            goto IL_4E0;
        //        }
        //        else if (Operators.CompareString(text, "CITIES", false) != 0)
        //        {
        //            return;
        //        }
        //    }
        //    else if (Operators.CompareString(text, "OPPORTUNITY CLOSE REASONS", false) != 0)
        //    {
        //        return;
        //    }
        //    cbItems = this.cbItems;
        //    Common.FillCombo(ref cbItems, "Select Name, RecordID from CRMComboData where ComboName = '" + this.cbDropDowns.Text + "' order by Name", "Name", "RecordID");
        //    this.cbItems = cbItems;
        //    this.ComboCode = 1;
        //    return;
        //IL_4E0:
        //    cbItems = this.cbItems;
        //    Common.FillCombo(ref cbItems, "Select Name + ': ' + isnull(Description,'') as 'Name', RecordID from CRMComboData where ComboName = '" + this.cbDropDowns.Text + "' order by 'Name'", "Name", "RecordID");
        //    this.cbItems = cbItems;
        //    this.ComboCode = 2;
        }

        internal static uint ComputeStringHash(string s)
        {
            uint num = 0;
            if (s != null)
            {
                num = 2166136261U;
                for (int index = 0; index < s.Length; ++index)
                    num = (uint)(((int)s[index] ^ (int)num) * 16777619);
            }
            return num;
        }

        private void cbDropDowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadDropDowns();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("Are you sure you want to delet this entry?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "DELETE") == MsgBoxResult.Yes)
            //{
            //    if (Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from CRMComboData where RecordID = ", this.cbItems.SelectedValue), "")), false) != 1)
            //    {
            //        Interaction.MsgBox("There was an error deleting this entry.", MsgBoxStyle.OkOnly, null);
            //        return;
            //    }
            //    Common.Popup("Entry Deleted", "", 2000);
            //    this.LoadDropDowns();
            //}
        }
    }
}
