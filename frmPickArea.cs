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
    public partial class frmPickArea : Form
    {
        public string GroupID;
        public frmPickArea()
        {
            InitializeComponent();
        }

        private void frmPickArea_Load(object sender, EventArgs e)
        {
            int num = 0;
            SqlConnection connection = new SqlConnection();
            //connection = Common.ConnectToSQL(false);
            //new SqlCommand("", connection);
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);

            //string text = "select distinct G.Name, G.GroupID from CRMGroup G left join CRMCompany CO on G.groupID = CO.GroupID ";
            //string text2 = "where Hassubgroup = 'True' and ParentGroupID is null ";

            //if (!Common.CanUseForm("ALLCONTACTS", true) | MyProject.Forms.frmMain.ckShowAllContacts.CheckState == CheckState.Unchecked)
            //{
            //    SqlConnection sqlConnection2 = new SqlConnection();
            //    sqlConnection2 = Common.ConnectToSQL(false);
            //    SqlCommand sqlCommand = new SqlCommand("Select UserLinkID from CRMUserLinks where UserID = '" + Common.IRUser + "' and LinkType = 1", sqlConnection2);
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //    if (sqlDataReader.HasRows)
            //    {
            //        string text3 = "(";

            //        while (sqlDataReader.Read())
            //        {
            //            text3 = string.Concat(new string[]
            //            {
            //                text3,
            //                "CO.ManageUserID = '",
            //                sqlDataReader.GetString(0),
            //                "' or  G.ManageUserID = '",
            //                sqlDataReader.GetString(0),
            //                "' or "
            //            });
            //        }

            //        text3 = string.Concat(new string[]
            //        {
            //            text3,
            //            " CO.ManageUserID = '",
            //            Common.IRUser,
            //            "' or  G.ManageUserID = '",
            //            Common.IRUser,
            //            "')"
            //        });

            //        text2 = clsSQLSearches.setWhere(text2, text3);
            //    }
            //    else
            //    {
            //        text2 = clsSQLSearches.setWhere(text2, string.Concat(new string[]
            //        {
            //            "(CO.ManageUserID = '",
            //            Common.IRUser,
            //            "' or  G.ManageUserID = '",
            //            Common.IRUser,
            //            "')"
            //        }));
            //    }

            //    sqlCommand.Connection.Close();
            //    sqlConnection2.Close();
            //}

            //text += text2;
            //text += " order by G.Name";
            //SqlCommand sqlCommand2 = new SqlCommand(text, sqlConnection);
            //SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();

            //checked
            //{
            //    while (sqlDataReader2.Read())
            //    {
            //        Conversions.ToString(sqlDataReader2.GetInt32(1));
            //        this.trAreas.Nodes.Add(Strings.UCase(sqlDataReader2.GetString(0)));
            //        this.trAreas.Nodes[num].Tag = sqlDataReader2.GetInt32(1);
            //        this.LoadChildren(sqlDataReader2.GetInt32(1), num);
            //        num++;
            //    }
            //    sqlCommand2.Connection.Close();
            //    sqlConnection.Close();
            //}
        }

        private void LoadChildren(int ParentGroupID, int currIndex)
        {
            int num = 0;
            SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            //SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
            //sqlCommand.CommandText = "select Name, groupid from CRMGroup where ParentGroupID = " + Conversions.ToString(ParentGroupID) + " order by name";
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //checked
            //{
            //    while (sqlDataReader.Read())
            //    {
            //        this.trAreas.Nodes[currIndex].Nodes.Add(Strings.UCase(sqlDataReader.GetString(0)));
            //        this.trAreas.Nodes[currIndex].Nodes[num].Tag = sqlDataReader.GetInt32(1);
            //        this.LoadGrandChildren(sqlDataReader.GetInt32(1), currIndex, num);
            //        num++;
            //    }
            //    sqlCommand.Connection.Close();
            //    sqlConnection.Close();
            //}
        }

        private void LoadGrandChildren(int ParentGroupID, int currIndex, int AIndex)
        {
            //int num = 0;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            //SqlCommand sqlCommand = new SqlCommand("", sqlConnection);
            //sqlCommand.CommandText = "select Name, groupid from CRMGroup where ParentGroupID = " + Conversions.ToString(ParentGroupID) + " order by name";
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //checked
            //{
            //    while (sqlDataReader.Read())
            //    {
            //        this.trAreas.Nodes[currIndex].Nodes[AIndex].Nodes.Add(Strings.UCase(sqlDataReader.GetString(0)));
            //        this.trAreas.Nodes[currIndex].Nodes[AIndex].Nodes[num].Tag = sqlDataReader.GetInt32(1);
            //        num++;
            //    }
            //    sqlCommand.Connection.Close();
            //    sqlConnection.Close();
            //}
        }

        private void trAreas_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    this.GroupID = Conversions.ToString(this.trAreas.SelectedNode.Tag);
            //}
            //catch (Exception expr_1D)
            //{
            //    ProjectData.SetProjectError(expr_1D);
            //    ProjectData.ClearProjectError();
            //}
            //if (Operators.CompareString(this.GroupID, "", false) != 0)
            //{
            //    base.DialogResult = DialogResult.OK;
            //}
        }
    }
}
