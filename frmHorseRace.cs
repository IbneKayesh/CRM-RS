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
    public partial class frmHorseRace : Form
    {
        public frmHorseRace()
        {
            base.Load += new EventHandler(this.frmHorseRace_Load);
            InitializeComponent();
        }

        private void frmHorseRace_Load(object sender, EventArgs e)
        {
            //Common.LogEntryCRM(base.Name, "VIEW", 0, 0, "");
            //if (!Common.CanUseForm("LEAVE_HORSE_RACE_ON_ALWAYS", true))
            //{
            //    this.Timer1.Enabled = true;
            //}
            //else
            //{
            //    this.Timer2.Enabled = true;
            //    this.IdLabel1.Visible = false;
            //}
            //DateTime monthStartDate = Common.GetMonthStartDate(DateTime.Today);
            //int rowCount = Common.IntScalar("select count(*) from SalesPersonGoals where MonthNo = '" + Conversions.ToString(monthStartDate) + "'", false);
            //idDataGridView expr_77 = this.gridDetail;
            //expr_77.RowCount = rowCount;
            //expr_77.ColumnCount = 12;
            //expr_77.ColumnHeadersVisible = true;
            //expr_77.Columns[0].HeaderText = "Sales#";
            //expr_77.Columns[1].HeaderText = "Record Manager";
            //expr_77.Columns[2].HeaderText = "Shipped";
            //expr_77.Columns[3].HeaderText = "Shipped Goal";
            //expr_77.Columns[4].HeaderText = "Shipped %";
            //expr_77.Columns[5].HeaderText = "Quoted";
            //expr_77.Columns[6].HeaderText = "Quoted Goal";
            //expr_77.Columns[7].HeaderText = "Quoted %";
            //expr_77.Columns[8].HeaderText = "New Cust";
            //expr_77.Columns[9].HeaderText = "New Cust Goal";
            //expr_77.Columns[10].HeaderText = "New Cust %";
            //expr_77.Columns[11].HeaderText = "Total %";
            //this.gridDetail.Columns[0].Visible = false;
            //int num = 0;
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            //bool flag = Common.CanUseForm("SEE_HORSE_RACE_NAMES", true);
            //SqlCommand sqlCommand = new SqlCommand("select SP.SalesPersonNo, SP.Name  from SalesPeople SP join SalesPersonGoals SG on SP.SalesPersonNo = SG.SalesPersonNo where MonthNo = '" + Conversions.ToString(monthStartDate) + "'", sqlConnection);
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //checked
            //{
            //    while (sqlDataReader.Read())
            //    {
            //        this.gridDetail[0, num].Value = sqlDataReader.GetInt32(0);
            //        if (flag)
            //        {
            //            this.gridDetail[1, num].Value = sqlDataReader.GetString(1);
            //        }
            //        else if (sqlDataReader.GetInt32(0) == Common.IRSalesPersonNo)
            //        {
            //            this.gridDetail[1, num].Value = sqlDataReader.GetString(1);
            //        }
            //        else
            //        {
            //            this.gridDetail[1, num].Value = "********";
            //        }
            //        num++;
            //    }
            //    sqlCommand.Connection.Close();
            //    sqlConnection.Close();
            //    this.FillGrid();
            //}
        }

        private void FillGrid()
        {
            //DateTime monthStartDate = Common.GetMonthStartDate(DateTime.Today);
            //DateTime monthEndDate = Common.GetMonthEndDate(DateTime.Today);
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            //SqlCommand sqlCommand = new SqlCommand("SQL Goes here", sqlConnection);
            //string text = string.Concat(new string[]
            //{
            //    "SELECT  so.SalesPersonNo, cast(SUM(sn.price + isNull(sn.rushFee,0)) as varchar(20)) as 'Sales',  cast(isnull((select ShippedGoal from SalespersonGoals where SalesPersonNo = so.SalespersonNo and MonthNo = '",
            //    Conversions.ToString(monthStartDate),
            //    "'),0)as varchar(20)) as 'Goal' FROM dbo.salesOrders AS so JOIN dbo.snumbers AS sn ON so.salesOrderno = sn.salesOrderno join SalesPeople SP on SO.SalesPersonNo = SP.SalesPersonNo WHERE  sn.RTDate BETWEEN '",
            //    Conversions.ToString(monthStartDate),
            //    "' AND '",
            //    Conversions.ToString(monthEndDate),
            //    "' "
            //});
            //text += " GROUP BY so.SalesPersonNo";
            //sqlCommand.CommandText = text;
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //checked
            //{
            //    while (sqlDataReader.Read())
            //    {
            //        int num = this.gridDetail.RowCount - 1;
            //        for (int i = 0; i <= num; i++)
            //        {
            //            if (Operators.ConditionalCompareObjectEqual(this.gridDetail[0, i].Value, sqlDataReader.GetInt32(0), false))
            //            {
            //                this.gridDetail[2, i].Value = sqlDataReader.GetString(1);
            //                this.gridDetail[3, i].Value = sqlDataReader.GetString(2);
            //            }
            //        }
            //    }
            //    sqlDataReader.Close();
            //    sqlCommand.Cancel();
            //    text = string.Concat(new string[]
            //    {
            //        "SELECT so.SalesPersonNo,  cast(sum((CASE WHEN isnull(sc.RUR,0) = 1 THEN isnull(sn.approvedprice,sn.price+isNull(sn.rushFee,0)) ELSE sn.price+isNull(sn.rushFee,0) END)) as varchar(20)) as 'Sales',  cast(isnull((select QuotedGoal from SalespersonGoals where SalesPersonNo = so.SalespersonNo and MonthNo = '",
            //        Conversions.ToString(monthStartDate),
            //        "'),0)as varchar(20)) as 'Goal' FROM dbo.salesOrders AS so JOIN dbo.snumbers AS sn ON so.salesOrderno = sn.salesOrderno left outer join dbo.shipmentcodes as sc on sn.shipmentcodeid = sc.shipmentcodeid join SalesPeople SP on SO.SalesPersonNo = SP.SalesPersonNo WHERE  so.dateentered BETWEEN '",
            //        Conversions.ToString(monthStartDate),
            //        "' AND '",
            //        Conversions.ToString(monthEndDate),
            //        "' "
            //    });
            //    text += " GROUP BY so.SalesPersonNo";
            //    sqlCommand.CommandText = text;
            //    sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        int num2 = this.gridDetail.RowCount - 1;
            //        for (int j = 0; j <= num2; j++)
            //        {
            //            if (Operators.ConditionalCompareObjectEqual(this.gridDetail[0, j].Value, sqlDataReader.GetInt32(0), false))
            //            {
            //                this.gridDetail[5, j].Value = sqlDataReader.GetString(1);
            //                this.gridDetail[6, j].Value = sqlDataReader.GetString(2);
            //            }
            //        }
            //    }
            //    sqlDataReader.Close();
            //    sqlCommand.Cancel();
            //    text = string.Concat(new string[]
            //    {
            //        "SELECT so.SalesPersonNo,  cast(count(distinct so.CustomerNo ) as varchar(20)) as 'New Customers', cast(isnull((select NewCustGoal  from SalespersonGoals where SalesPersonNo = so.SalespersonNo and MonthNo = '",
            //        Conversions.ToString(monthStartDate),
            //        "'),0)as varchar(20)) as 'Goal'  FROM dbo.salesOrders AS so join SalesPeople SP on SO.SalesPersonNo = SP.SalesPersonNo WHERE  so.DateEntered   BETWEEN '",
            //        Conversions.ToString(monthStartDate),
            //        "' AND '",
            //        Conversions.ToString(monthEndDate),
            //        "' and SO.SalesPersonNo is not null and  so.CustomerNo not in (select CustomerNo from SalesOrders where DateEntered < '",
            //        Conversions.ToString(monthStartDate),
            //        "')  "
            //    });
            //    text += " GROUP BY so.SalesPersonNo";
            //    sqlCommand.CommandText = text;
            //    sqlDataReader = sqlCommand.ExecuteReader();
            //    while (sqlDataReader.Read())
            //    {
            //        int num3 = this.gridDetail.RowCount - 1;
            //        for (int k = 0; k <= num3; k++)
            //        {
            //            if (Operators.ConditionalCompareObjectEqual(this.gridDetail[0, k].Value, sqlDataReader.GetInt32(0), false))
            //            {
            //                this.gridDetail[8, k].Value = sqlDataReader.GetString(1);
            //                this.gridDetail[9, k].Value = sqlDataReader.GetString(2);
            //            }
            //        }
            //    }
            //    sqlDataReader.Close();
            //    sqlCommand.Cancel();
            //    sqlCommand.Connection.Close();
            //    sqlConnection.Close();
            //    this.addPCT(monthStartDate, monthEndDate);
            //    this.gridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //    DataGridViewColumn dataGridViewColumn = this.gridDetail.Columns[11];
            //    this.gridDetail.Sort(dataGridViewColumn, ListSortDirection.Descending);
            //    if (!Common.CanUseForm("SHOW_HORSE_RACE_AMOUNTS", true))
            //    {
            //        this.gridDetail.Columns[2].Visible = false;
            //        this.gridDetail.Columns[3].Visible = false;
            //        this.gridDetail.Columns[5].Visible = false;
            //        this.gridDetail.Columns[6].Visible = false;
            //    }
            //}
        }

        private void addPCT(DateTime StartDate, DateTime EndDate)
        {
            //checked
            //{
            //    int num = this.gridDetail.RowCount - 1;
            //    for (int i = 0; i <= num; i++)
            //    {
            //        decimal num2 = 0m;
            //        decimal num3 = 0m;
            //        decimal num4 = 0m;
            //        try
            //        {
            //            num2 = Conversions.ToDecimal(this.gridDetail[2, i].Value);
            //        }
            //        catch (Exception expr_48)
            //        {
            //            ProjectData.SetProjectError(expr_48);
            //            num2 = 0m;
            //            ProjectData.ClearProjectError();
            //        }
            //        try
            //        {
            //            num3 = Conversions.ToDecimal(this.gridDetail[3, i].Value);
            //        }
            //        catch (Exception expr_7B)
            //        {
            //            ProjectData.SetProjectError(expr_7B);
            //            num3 = 0m;
            //            ProjectData.ClearProjectError();
            //        }
            //        try
            //        {
            //            num4 = decimal.Multiply(decimal.Divide(num2, num3), new decimal(100L));
            //        }
            //        catch (Exception expr_AD)
            //        {
            //            ProjectData.SetProjectError(expr_AD);
            //            ProjectData.ClearProjectError();
            //        }
            //        this.gridDetail[2, i].Value = Strings.Format(num2, "N");
            //        this.gridDetail[3, i].Value = Strings.Format(num3, "N");
            //        this.gridDetail[4, i].Value = Math.Round(num4, 2);
            //        decimal d = Conversions.ToDecimal(Strings.Format(num4, "N"));
            //        num2 = 0m;
            //        num3 = 0m;
            //        num4 = 0m;
            //        try
            //        {
            //            num2 = Conversions.ToDecimal(this.gridDetail[5, i].Value);
            //        }
            //        catch (Exception expr_16B)
            //        {
            //            ProjectData.SetProjectError(expr_16B);
            //            num2 = 0m;
            //            ProjectData.ClearProjectError();
            //        }
            //        try
            //        {
            //            num3 = Conversions.ToDecimal(this.gridDetail[6, i].Value);
            //        }
            //        catch (Exception expr_19E)
            //        {
            //            ProjectData.SetProjectError(expr_19E);
            //            num3 = 0m;
            //            ProjectData.ClearProjectError();
            //        }
            //        try
            //        {
            //            num4 = decimal.Multiply(decimal.Divide(num2, num3), new decimal(100L));
            //        }
            //        catch (Exception expr_1D0)
            //        {
            //            ProjectData.SetProjectError(expr_1D0);
            //            ProjectData.ClearProjectError();
            //        }
            //        this.gridDetail[5, i].Value = Strings.Format(num2, "N");
            //        this.gridDetail[6, i].Value = Strings.Format(num3, "N");
            //        this.gridDetail[7, i].Value = Math.Round(num4, 2);
            //        decimal d2 = Conversions.ToDecimal(Strings.Format(num4, "N"));
            //        num2 = 0m;
            //        num3 = 0m;
            //        num4 = 0m;
            //        try
            //        {
            //            num2 = Conversions.ToDecimal(this.gridDetail[8, i].Value);
            //        }
            //        catch (Exception expr_28E)
            //        {
            //            ProjectData.SetProjectError(expr_28E);
            //            num2 = 0m;
            //            ProjectData.ClearProjectError();
            //        }
            //        try
            //        {
            //            num3 = Conversions.ToDecimal(this.gridDetail[9, i].Value);
            //        }
            //        catch (Exception expr_2C2)
            //        {
            //            ProjectData.SetProjectError(expr_2C2);
            //            num3 = 0m;
            //            ProjectData.ClearProjectError();
            //        }
            //        try
            //        {
            //            num4 = decimal.Multiply(decimal.Divide(num2, num3), new decimal(100L));
            //        }
            //        catch (Exception expr_2F4)
            //        {
            //            ProjectData.SetProjectError(expr_2F4);
            //            ProjectData.ClearProjectError();
            //        }
            //        this.gridDetail[8, i].Value = Strings.Format(num2, "N");
            //        this.gridDetail[9, i].Value = Strings.Format(num3, "N");
            //        this.gridDetail[10, i].Value = Math.Round(num4, 2);
            //        decimal d3 = decimal.Divide(decimal.Add(decimal.Add(Conversions.ToDecimal(Strings.Format(num4, "N")), d2), d), new decimal(3L));
            //        this.gridDetail[11, i].Value = Math.Round(d3, 2);
            //    }
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.FillGrid();
        }
    }
}
