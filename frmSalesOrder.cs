using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CRM
{
    public partial class frmSalesOrder : Form
    {
        public int SentSONo;

        public int SentSNumber;

        public string SessionID;

        private string oText;

        private bool dataChanged;

        private SqlDataAdapter daSQLDataAdapter;

        private DataView gdvDataView;

        private bool FormLoaded;

        //public Collection printCollection;

        private bool ShipViaDrop;

        private bool SalesOneDrop;

        private bool SalesTwoDrop;
        public frmSalesOrder()
        {
            base.Load += new EventHandler(this.frmSalesOrder_Load);
            base.KeyDown += new KeyEventHandler(this.frmSalesOrder_KeyDown);
            this.SentSONo = 0;
            this.SentSNumber = 0;
            this.SessionID = "";
            this.dataChanged = false;
            this.FormLoaded = false;
            this.ShipViaDrop = false;
            this.SalesOneDrop = false;
            this.SalesTwoDrop = false;

            InitializeComponent();
        }

        private void frmSalesOrder_Load(object sender, EventArgs e)
        {
            //if (Common.CanUseForm("SALESORDERRPT", true))
            //{
            //    this.btnSoScreen.Visible = true;
            //}
            //this.LoadExisting("");
            //this.LockForm();
            //this.Text = Strings.Replace(this.Text, "?", Conversions.ToString(this.SentSONo), 1, -1, CompareMethod.Binary);
        }

        private void frmSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;

            if (keyCode == Keys.Return)
            {
               // this.GetSNumberDetail();
            }
        }

        private void LockForm()
        {
            //Common.CycleCheck(false, this);
            //Common.CycleText(false, this);
            //Common.CycleCombo(false, this);
        }

        private void LoadExisting(string Location)
        {
            //this.SalesOrdersTableAdapter.FillBySalesOrderNo(this.IRDataSet.SalesOrders, this.SentSONo);

            //string sQLStr;

            //if (Common.CanUseForm("Warranty_PCT", true))
            //{
            //    sQLStr = "select SN.snumberNo as 'S #', M.Description as 'Manufacturer', I.ItemNumber as 'Item', isnull(SN.Price,0) + isnull(sn.RushFee,0) as 'Price',  isnull(sn.Location,'') as 'Location', 'W' as 'Warranty %', SN.ManufacturerNo from sNumbers SN  left join Items I ON SN.ItemRecordID  = I.RecordID   left join Manufacturer M on SN.ManufacturerNo = M.ManufacturerNo  where SN.SalesOrderNo = " + Conversions.ToString(this.SentSONo) + " order by sn.snumberNo";
            //}
            //else
            //{
            //    sQLStr = "select SN.snumberNo as 'S #', M.Description as 'Manufacturer', I.ItemNumber as 'Item', isnull(SN.Price,0) + isnull(sn.RushFee,0) as 'Price',  isnull(sn.Location,'') as 'Location' from sNumbers SN  left join Items I ON SN.ItemRecordID  = I.RecordID   left join Manufacturer M on SN.ManufacturerNo = M.ManufacturerNo  where SN.SalesOrderNo = " + Conversions.ToString(this.SentSONo) + " order by sn.snumberNo";
            //}

            //DataTable dataTable = new DataTable();

            //this.daSQLDataAdapter = new SqlDataAdapter();
            //this.daSQLDataAdapter = Common.GetGridData(sQLStr, false);
            //this.daSQLDataAdapter.Fill(dataTable);
            //this.gdvDataView = new DataView(dataTable);
            //this.gridDetail.DataSource = dataTable;

            //if (Common.CanUseForm("Warranty_PCT", true))
            //{
            //    this.gridDetail.Columns[6].Visible = false;
            //}

            //this.gridDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //this.dataChanged = false;

            //checked
            //{
            //    if (Operators.CompareString(Location, "BUTTON", false) == 0)
            //    {
            //        this.IdTabControl1.SelectedIndex = 0;
            //    }
            //    else
            //    {
            //        this.IdTabControl1.SelectedIndex = 1;
            //        if (this.gridDetail.RowCount > 0)
            //        {
            //            int num = this.gridDetail.RowCount - 1;
            //            for (int i = 0; i <= num; i++)
            //            {
            //                if (Operators.ConditionalCompareObjectEqual(this.gridDetail[0, i].Value, this.SentSNumber, false))
            //                {
            //                    DataGridViewCell currentCell = this.gridDetail[0, i];
            //                    this.gridDetail.CurrentCell = currentCell;
            //                    break;
            //                }
            //            }
            //        }
            //    }

            //    this.lblCreditHold.Visible = Common.BitScalar(("select CreditHold from Customers where CustomerNo = " + Common.NQ(this.cbCustomer.Text)) ?? "", false);
            //    this.Timer1.Enabled = true;
            //    this.cbCustomer.Enabled = false;
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void gridDetail_SelectionChanged(object sender, EventArgs e)
        {
            //if (this.FormLoaded)
            //{
            //    this.SetDetails();
            //}
        }


        private void SetDetails()
        {
            //checked
            //{
            //    try
            //    {
            //        decimal num = 0m;
            //        int index = this.gridDetail.CurrentRow.Index;
            //        int num2 = Conversions.ToInteger(this.gridDetail[0, index].Value);
            //        string cmdText = "select SN.snumberNo, isnull(M.Description,''), isnull(I.ItemNumber,''), isnull(SN.RefNumber,''), isnull(sn.SerialNumber,''), isnull(t.Initials,''),  isnull(SN.ApprovalDate,''), isnull(sn.ApprovedBy,''), isnull(SN.CustomerPONO,''), isnull(sn.ApprovedPrice,'0'),  sn.outsourced, isnull(SN.DateInvoiced,'1/1/1900'), isnull(SN.InvoiceNo,0), isnull(sc.CodeDescription,''), isnull(sm.Description,''),  sn.Rush, sn.Warranty, isnull(sn.oldsnumberno, 0), I.RecordID, isnull(SN.Notes,''), isnull(SN.RushFee, 0), isnull(qbi.QBInvoiceNo,0),  isnull(sn.PartNeeded,'False'), isnull(sn.PartNeededDate,'1/1/1900'), isnull(sn.RT,'False'), isnull(sn.RTDate,'1/1/1900'), isnull(sn.PartsDue,'False'),  isnull(sn.PartsDueDate,'1/1/1900'), isnull(sn.RUR,'False'), isnull(sn.RURDate,'1/1/1900'), isnull(sn.PartsRcvd,'False'), isnull(sn.PartsRcvdDate,'1/1/1900'),  isnull(sn.Evaluation,'False'), isnull(sn.EvaluationDate,'1/1/1900')  from sNumbers SN left join Items I ON SN.ItemRecordID = I.RecordID left join Manufacturer M on I.ManufacturerNo = M.ManufacturerNo  left join Technicians T on sn.TechnicianNo = T.TechnicianNo LEFT Join  ShipmentCodes SC on sn.ShipmentCodeID = sc.ShipmentCodeID  left join ShipMethod sm on sn.ShipMethodID = sm.ShipMethodid  left join QBInvoice qbi on sn.InvoiceNo = qbi.InvoiceNo  where(SN.snumberNo = " + Conversions.ToString(num2) + ")";
            //        int num3 = Common.IntScalar(("select isnull(InvoiceNo,0) from sNumbers where sNumberNo = " + Conversions.ToString(num2)) ?? "", false);
            //        string text = "";
            //        string right = "";

            //        if (num3 != 0)
            //        {
            //            text = clsSO.GetTrackingNumber(num3);
            //            right = Conversions.ToString(clsSO.GetShipDate(num3));
            //        }


            //        SqlConnection sqlConnection = new SqlConnection();
            //        sqlConnection = Common.ConnectToSQL(false);
            //        SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //        sqlDataReader.Read();

            //        this.numSNo.Value = new decimal(num2);
            //        this.txtManuf.Text = sqlDataReader.GetString(1);
            //        this.txtItem.Text = Conversions.ToString(sqlDataReader.GetValue(2));
            //        this.txtRefNo.Text = Conversions.ToString(sqlDataReader.GetValue(3));
            //        this.txtSerNo.Text = Conversions.ToString(sqlDataReader.GetValue(4));
            //        this.txtTech.Text = Conversions.ToString(sqlDataReader.GetValue(5));
            //        this.numPrice.Value = Conversions.ToDecimal(sqlDataReader.GetValue(9));
            //        this.lblRush.Visible = sqlDataReader.GetBoolean(15);
            //        this.lblWarranty.Visible = sqlDataReader.GetBoolean(16);

            //        decimal num4 = Common.DecScalar(("select isnull(sum(isnull(Pl.UnitCost,0) * isnull(PD.ReceivedQty,0)),0) from Polines PL join POLineDetail PD on Pl.POLineID = PD.POLineID where PD.SNumberNo = " + Conversions.ToString(num2)) ?? "", false);
            //        num4 = decimal.Add(num4, Common.DecScalar(("select isnull(Price,0) from Outsource where snumberNo = " + Conversions.ToString(num2)) ?? "", false));


            //        if (this.lblWarranty.Visible)
            //        {
            //            this.cbWarranty.Items.Clear();
            //            this.cbWarranty.Visible = true;
            //            this.lblWarranty.Text = "WARRANTY";
            //            bool flag = true;
            //            int num5 = Conversions.ToInteger(sqlDataReader.GetValue(17));
            //            this.cbWarranty.Items.Add(num5);

            //            while (flag)
            //            {
            //                flag = Common.BitScalar(("select Warranty from snumbers where SnumberNo = " + Conversions.ToString(num5)) ?? "", false);
            //                if (flag)
            //                {
            //                    int num6 = Common.IntScalar(("Select OldSNumberNo from snumbers where snumberno = " + Conversions.ToString(num5)) ?? "", false);

            //                    if (num6 == num5)
            //                    {
            //                        Interaction.MsgBox("Invalid original S Number on warranty job.  Warranty cost and listing is invalid for this job", MsgBoxStyle.Exclamation, null);
            //                        break;
            //                    }

            //                    num5 = num6;
            //                    this.cbWarranty.Items.Add(num5);
            //                }
            //            }


            //            this.cbWarranty.Text = Conversions.ToString(sqlDataReader.GetValue(17));

            //            int num7 = this.cbWarranty.Items.Count - 1;

            //            for (int i = 0; i <= num7; i++)
            //            {
            //                num4 = decimal.Add(num4, Common.DecScalar(("select isnull(sum(isnull(Pl.UnitCost,0) * isnull(PD.ReceivedQty,0)),0) from Polines PL join POLineDetail PD on Pl.POLineID = PD.POLineID where PD.SNumberNo = " + this.cbWarranty.Items[i].ToString()) ?? "", false));
            //            }

            //            int num8 = this.cbWarranty.Items.Count - 1;

            //            for (int i = 0; i <= num8; i++)
            //            {
            //                num4 = decimal.Add(num4, Common.DecScalar(("select isnull(Price,0) from Outsource where snumberNo = " + this.cbWarranty.Items[i].ToString()) ?? "", false));
            //            }
            //        }
            //        else
            //        {
            //            this.cbWarranty.Visible = false;
            //        }

            //        this.lblPartsCost.Text = "Parts Cost $" + Strings.Format(num4, "N");
            //        int @int = sqlDataReader.GetInt32(21);
            //        this.lblPriceSource.Visible = true;
            //        this.lblPriceSource.Text = Common.StrScalar(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select detail from CalculateCustomerPrice(" + Common.NQ(this.cbCustomer.Text) + ", ", sqlDataReader.GetValue(18)), ")")), false);
            //        num = sqlDataReader.GetDecimal(20);

            //        if (decimal.Compare(num, decimal.Zero) > 0)
            //        {
            //            idLabel lblPriceSource;
            //            (lblPriceSource = this.lblPriceSource).Text = lblPriceSource.Text + "  Plus Rush Fee of $" + Conversions.ToString(num);
            //        }

            //        string text2;

            //        if (Operators.CompareString(sqlDataReader.GetValue(6).ToString(), "", false) != 0 & DateTime.Compare(Conversions.ToDate(sqlDataReader.GetValue(6).ToString()), Conversions.ToDate("1/1/1900")) != 0)
            //        {
            //            text2 = Conversions.ToString(Operators.ConcatenateObject("On ", sqlDataReader.GetValue(6)));

            //            if (Operators.CompareString(sqlDataReader.GetValue(7).ToString(), "", false) != 0)
            //            {
            //                text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject("; By ", sqlDataReader.GetValue(7))));
            //            }
            //            if (Operators.CompareString(sqlDataReader.GetValue(8).ToString(), "", false) != 0)
            //            {
            //                text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject("; P/O # ", sqlDataReader.GetValue(8))));
            //            }
            //            if (Operators.CompareString(sqlDataReader.GetValue(9).ToString(), "0", false) != 0)
            //            {
            //                text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject("; Price ", sqlDataReader.GetValue(9))));
            //            }
            //        }
            //        else
            //        {
            //            text2 = "";
            //        }
            //        string value;

            //        if (sqlDataReader.GetBoolean(10))
            //        {
            //            value = clsSO.getOutsourceStatus(num2);
            //        }
            //        else
            //        {
            //            value = "";
            //        }

            //        string text3;

            //        if (Operators.CompareString(sqlDataReader.GetDateTime(11).ToShortDateString(), "1/1/1900", false) != 0)
            //        {
            //            text3 = Conversions.ToString(Operators.ConcatenateObject("On ", sqlDataReader.GetValue(11)));

            //            if (Operators.CompareString(sqlDataReader.GetValue(12).ToString(), "", false) != 0)
            //            {
            //                text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject("; P/S ", sqlDataReader.GetValue(12))));
            //            }

            //            if (@int != 0)
            //            {
            //                text3 = text3 + "; Invoice# " + Conversions.ToString(@int);
            //            }

            //            if (Operators.CompareString(sqlDataReader.GetValue(13).ToString(), "", false) != 0)
            //            {
            //                text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject("; ", sqlDataReader.GetValue(13))));
            //            }

            //            if (Operators.CompareString(sqlDataReader.GetValue(14).ToString(), "", false) != 0)
            //            {
            //                text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject("; Via ", sqlDataReader.GetValue(14))));
            //            }

            //            if (Operators.CompareString(text, "", false) != 0)
            //            {
            //                text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("; " + text + " (", sqlDataReader.GetValue(14)), " "), right), ")")));
            //            }
            //        }
            //        else
            //        {
            //            text3 = "";
            //        }

            //        string value2;

            //        if (Operators.CompareString(sqlDataReader.GetValue(18).ToString(), "", false) != 0)
            //        {
            //            value2 = sqlDataReader.GetString(19);
            //        }
            //        else
            //        {
            //            value2 = "";
            //        }

            //        string partsStatus = clsSO.getPartsStatus(num2);
            //        bool boolean = sqlDataReader.GetBoolean(22);
            //        DateTime dateTime = sqlDataReader.GetDateTime(23);
            //        bool boolean2 = sqlDataReader.GetBoolean(24);
            //        DateTime dateTime2 = sqlDataReader.GetDateTime(25);
            //        bool boolean3 = sqlDataReader.GetBoolean(26);
            //        DateTime dateTime3 = sqlDataReader.GetDateTime(27);
            //        bool boolean4 = sqlDataReader.GetBoolean(28);
            //        DateTime dateTime4 = sqlDataReader.GetDateTime(29);
            //        bool boolean5 = sqlDataReader.GetBoolean(30);
            //        DateTime dateTime5 = sqlDataReader.GetDateTime(31);
            //        bool boolean6 = sqlDataReader.GetBoolean(32);
            //        DateTime dateTime6 = sqlDataReader.GetDateTime(33);

            //        string value3 = this.SetStatus(boolean, dateTime, boolean2, dateTime2, boolean3, dateTime3, boolean4, dateTime4, boolean5, dateTime5, boolean6, dateTime6);

            //        sqlCommand.Connection.Close();
            //        sqlConnection.Close();

            //        idDataGridView expr_809 = this.gridDetailStatus;

            //        expr_809.RowCount = 6;
            //        expr_809.ColumnCount = 2;
            //        expr_809.Columns[1].Width = 635;
            //        expr_809.ColumnHeadersVisible = false;
            //        expr_809.RowHeadersVisible = false;
            //        expr_809[0, 0].Value = "Approval";
            //        expr_809[0, 1].Value = "Outsource";
            //        expr_809[0, 2].Value = "Shipment";
            //        expr_809[0, 3].Value = "Notes";
            //        expr_809[0, 4].Value = "Parts";
            //        expr_809[0, 5].Value = "Status";
            //        expr_809[1, 0].Value = text2;
            //        expr_809[1, 1].Value = value;
            //        expr_809[1, 2].Value = text3;
            //        expr_809[1, 3].Value = value2;
            //        expr_809[1, 4].Value = partsStatus;
            //        expr_809[1, 5].Value = value3;
            //        int num9 = 0;

            //        do
            //        {
            //            this.gridDetailStatus[0, num9].Style.ForeColor = Color.Blue;
            //            this.gridDetailStatus[0, num9].Style.BackColor = Color.LightGray;

            //            num9++;
            //        }
            //        while (num9 <= 5);

            //        this.gridDetailStatus.ReadOnly = true;
            //    }
            //    catch (Exception expr_954)
            //    {
            //        ProjectData.SetProjectError(expr_954);
            //        ProjectData.ClearProjectError();
            //    }
            //}
        }


        private string SetStatus(bool PartNeeded, DateTime PartNeededDate, bool RT, DateTime RTDate, bool PartsDue, DateTime PartsDueDate, bool RUR, DateTime RURDate, bool PartsRcvd, DateTime PartsRcvdDate, bool Evaluation, DateTime EvaluationDate)
        {
            string text = "";

            DateTime[] array = new DateTime[]
            {
                PartNeededDate,
                PartsRcvdDate,
                PartsDueDate,
                RURDate,
                RTDate,
                EvaluationDate
            };

            Array.Sort<DateTime>(array);

            int num = 0;

            checked
            {
                //do
                //{
                //    string str = "";

                //    if (DateTime.Compare(array[num], Conversions.ToDate("1/1/1900")) != 0)
                //    {
                //        if (DateTime.Compare(array[num], EvaluationDate) == 0 & Evaluation)
                //        {
                //            str = "EVAL ";
                //        }
                //        else if (DateTime.Compare(array[num], PartNeededDate) == 0 & PartNeeded)
                //        {
                //            str = "PN ";
                //        }
                //        else if (DateTime.Compare(array[num], PartsDueDate) == 0 & PartsDue)
                //        {
                //            str = "PD ";
                //        }
                //        else if (DateTime.Compare(array[num], PartsRcvdDate) == 0 & PartsRcvd)
                //        {
                //            str = "PR ";
                //        }
                //        else if (DateTime.Compare(array[num], RTDate) == 0 & RT)
                //        {
                //            str = "RT ";
                //        }
                //        else if (DateTime.Compare(array[num], RURDate) == 0 & RUR)
                //        {
                //            str = "RUR ";
                //        }
                //        if (text.Length > 0)
                //        {
                //            text += ": ";
                //        }

                //        text = text + str + array[num].ToShortDateString();
                //    }
                //    num++;
                //}
                //while (num <= 5);

                //if (Operators.CompareString(text, "", false) == 0)
                //{
                //    text = "N/A";
                //}

                return text;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //this.Timer1.Enabled = false;

            //checked
            //{
            //    int num = this.gridDetail.RowCount - 1;

            //    for (int i = 0; i <= num; i++)
            //    {
            //        Color backColor = Color.White;

            //        int num2 = (int)clsSO.SNumberStatus(Conversions.ToInteger(this.gridDetail[0, i].Value));

            //        switch (num2)
            //        {
            //            case 3:
            //                {
            //                    backColor = Color.Green;
            //                    break;
            //                }

            //            case 4:
            //                {
            //                    //backColor = Color.Yellow;

            //                    backColor = Color.Magenta;

            //                    break;
            //                }

            //            case 5:
            //                {
            //                    backColor = Color.Cyan;
            //                    break;
            //                }

            //            case 6:
            //            case 8:
            //                {
            //                    break;
            //                }

            //            case 7:
            //                {
            //                    backColor = Color.Red;
            //                    break;
            //                }

            //            case 9:
            //                {
            //                    backColor = Color.Orange;
            //                    break;
            //                }

            //            default:
            //                {
            //                    if (num2 == 26)
            //                    {
            //                        //backColor = Color.Magenta;

            //                        backColor = Color.Yellow;
            //                    }

            //                    break;
            //                }
            //        }

            //        int j = 0;

            //        do
            //        {
            //            this.gridDetail[j, i].Style.BackColor = backColor;

            //            j++;
            //        }
            //        while (j <= 4);
            //    }

            //    if (Common.CanUseForm("Warranty_PCT", true))
            //    {
            //        int num3 = this.gridDetail.RowCount - 1;

            //        for (int j = 0; j <= num3; j++)
            //        {
            //            int manufacturerNo = Conversions.ToInteger(this.gridDetail[6, j].Value);
            //            string itemNumber = Conversions.ToString(this.gridDetail[2, j].Value);
            //            this.gridDetail[5, j].Value = clsSO.GetWarrantyPCT(manufacturerNo, itemNumber);
            //            decimal num4 = new decimal(Strings.InStr(Conversions.ToString(this.gridDetail[5, j].Value), "%", CompareMethod.Binary) - 1);
            //            num4 = Conversions.ToDecimal(Strings.Mid(Conversions.ToString(this.gridDetail[5, j].Value), 1, Convert.ToInt32(num4)));
            //            this.gridDetail[5, j].Style.BackColor = this.SetPCTColors(num4);
            //        }
            //    }

            //    this.FormLoaded = true;
            //    this.SetDetails();
            //}
        }

        private Color SetPCTColors(decimal PCT)
        {
            Color result = Color.Orange;

            if (decimal.Compare(PCT, new decimal(10L)) <= 0)
            {
                result = Color.LightBlue;
            }
            else if (decimal.Compare(PCT, new decimal(25L)) <= 0)
            {
                result = Color.Orange;
            }
            else if (decimal.Compare(PCT, new decimal(25L)) > 0)
            {
                result = Color.Red;
            }
            return result;

        }

        private void gridDetail_DoubleClick(object sender, EventArgs e)
        {
            //this.GetSNumberDetail();
        }


        private void GetSNumberDetail()
        {
            //if (this.gridDetail.RowCount > 0)
            //{
            //    this.Cursor = Cursors.WaitCursor;
            //    int index = this.gridDetail.CurrentRow.Index;
            //    int mySnumber = Conversions.ToInteger(this.gridDetail[0, index].Value);

            //    frmSNumber frmSNumber = new frmSNumber();

            //    if (Common.CanUseForm(Conversions.ToString(frmSNumber.Tag), false))
            //    {
            //        frmSNumber.ManufacturerTableAdapter.Fill(frmSNumber.IRDataSet.Manufacturer);
            //        frmSNumber.VendorsTableAdapter.Fill(frmSNumber.IRDataSet.Vendors);
            //        frmSNumber.ShipmentCodesTableAdapter.Fill(frmSNumber.IRDataSet.ShipmentCodes);
            //        frmSNumber.ShipMethodTableAdapter.Fill(frmSNumber.IRDataSet.ShipMethod);
            //        frmSNumber.Icon = MyProject.Forms.frmMain.Icon;
            //        frmSNumber.mySnumber = mySnumber;
            //        frmSNumber.SessionID = this.SessionID;
            //        frmSNumber.CustNo = this.cbCustomer.Text;
            //        frmSNumber.ShowDialog();

            //        this.Cursor = Cursors.Default;

            //        this.LoadExisting("");

            //        frmSNumber.Close();

            //        DataGridViewCell currentCell = this.gridDetail[0, index];

            //        this.gridDetail.CurrentCell = currentCell;
            //    }
            //}
        }

        private void LoadCustDetails()
        {
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection = Common.ConnectToSQL(false);
            //SqlCommand sqlCommand = new SqlCommand(("select C.CreditHold, isnull(C.AddressOne,''), isnull(C.AddressTwo,''), isnull(C.AddressThree,''), isnull(C.City,''), isnull(C.State,''),  isnull(C.Zip,''), isnull(C.Phone,''), isnull(C.Fax,''), isnull(C.SONotes,''), isnull(C.Company,''), isnull(S.AddressOne,''), isnull(S.AddressTwo,''),  isnull(S.AddressThree,''), isnull(S.City,''), isnull(S.State,''), isnull(S.Zip,''), isnull(C.DefaultContactID,0), isnull(C.Contact2id,0),   isnull(C.ShipMethod,0), isnull(C.SalesPerson,0), isnull(C.SalesPerson2,0), isnull(C.SONotes,''), isnull(eMail,'')  from Customers C left join CustomerShipTo S on C.DefaultShipToID = S.ShipToID  where C.CustomerNo = " + Common.NQ(this.cbCustomer.Text)) ?? "", sqlConnection);
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //if (sqlDataReader.HasRows)
            //{
            //    sqlDataReader.Read();

            //    this.lblCreditHold.Visible = sqlDataReader.GetBoolean(0);
            //    this.txtBillAddr1.Text = sqlDataReader.GetString(1);
            //    this.txtBillAddr2.Text = sqlDataReader.GetString(2);
            //    this.txtBillAddr3.Text = sqlDataReader.GetString(3);
            //    this.txtBillCity.Text = sqlDataReader.GetString(4);
            //    this.txtBillSt.Text = sqlDataReader.GetString(5);
            //    this.txtBillZip.Text = sqlDataReader.GetString(6);
            //    this.txtPhone.Text = sqlDataReader.GetString(7);
            //    this.txtFax.Text = sqlDataReader.GetString(8);
            //    this.txtNotes.Text = sqlDataReader.GetString(9);
            //    this.txtShipTo.Text = sqlDataReader.GetString(10);
            //    this.txtShipToAddr1.Text = sqlDataReader.GetString(11);
            //    this.txtShipToAddr2.Text = sqlDataReader.GetString(12);
            //    this.txtShipToAddr3.Text = sqlDataReader.GetString(13);
            //    this.txtShipToCity.Text = sqlDataReader.GetString(14);
            //    this.txtShipToSt.Text = sqlDataReader.GetString(15);
            //    this.txtShipToZip.Text = sqlDataReader.GetString(16);

            //    int @int = sqlDataReader.GetInt32(17);
            //    int int2 = sqlDataReader.GetInt32(18);
            //    int int3 = sqlDataReader.GetInt32(19);
            //    int int4 = sqlDataReader.GetInt32(20);
            //    int int5 = sqlDataReader.GetInt32(21);

            //    string text = Strings.Trim(sqlDataReader.GetString(22));
            //    string text2 = Strings.Trim(sqlDataReader.GetString(23));

            //    sqlCommand.Connection.Close();
            //    sqlConnection.Close();
            //    sqlConnection = Common.ConnectToSQL(false);
            //    SqlCommand expr_210 = new SqlCommand(("Select isnull(Name,''), isnull(eMail,'') from CustomerContacts where ContactID = " + Conversions.ToString(@int)) ?? "", sqlConnection);
            //    SqlDataReader sqlDataReader2 = expr_210.ExecuteReader();

            //    if (sqlDataReader2.HasRows)
            //    {
            //        sqlDataReader2.Read();
            //        this.txtContact.Text = sqlDataReader2.GetString(0);
            //        this.txtEmail.Text = sqlDataReader2.GetString(1);
            //    }

            //    sqlDataReader2.Close();
            //    expr_210.Cancel();

            //    if (Operators.CompareString(Strings.Trim(this.txtContact.Text), "", false) != 0 & Operators.CompareString(this.txtEmail.Text, "", false) == 0)
            //    {
            //        this.txtEmail.Text = text2;
            //    }

            //    expr_210.CommandText = (("Select isnull(Name,''), isnull(eMail,'') from CustomerContacts where ContactID = " + Conversions.ToString(int2)) ?? "");
            //    sqlDataReader2 = expr_210.ExecuteReader();

            //    if (sqlDataReader2.HasRows)
            //    {
            //        sqlDataReader2.Read();
            //        this.txtContact2.Text = sqlDataReader2.GetString(0);
            //        this.txtEmail2.Text = sqlDataReader2.GetString(1);
            //    }

            //    sqlDataReader2.Close();
            //    expr_210.Cancel();

            //    expr_210.CommandText = (("Select isnull(Description,'') from ShipMethod where ShipMethodID = " + Conversions.ToString(int3)) ?? "");
            //    sqlDataReader2 = expr_210.ExecuteReader();

            //    if (sqlDataReader2.HasRows)
            //    {
            //        sqlDataReader2.Read();
            //        this.cbShipVia.Text = sqlDataReader2.GetString(0);
            //    }

            //    sqlDataReader2.Close();
            //    expr_210.Cancel();

            //    expr_210.CommandText = "Select isnull(Name,'') from SalesPeople where SalesPersonNo = " + Conversions.ToString(int4) + " and Status = 'True'";
            //    sqlDataReader2 = expr_210.ExecuteReader();

            //    if (sqlDataReader2.HasRows)
            //    {
            //        sqlDataReader2.Read();
            //        this.cbSalesPerson.Text = sqlDataReader2.GetString(0);
            //    }
            //    else
            //    {
            //        Interaction.MsgBox("WARNING WARNING WARNING\rThis customer does not have a valid primary salesperson", MsgBoxStyle.Critical, "No primary salesperson");
            //    }

            //    sqlDataReader2.Close();
            //    expr_210.Cancel();

            //    expr_210.CommandText = "Select isnull(Name,'') from SalesPeople where SalesPersonNo = " + Conversions.ToString(int5) + " and Status = 'True'";
            //    sqlDataReader2 = expr_210.ExecuteReader();

            //    if (sqlDataReader2.HasRows)
            //    {
            //        sqlDataReader2.Read();
            //        this.cbSalesPerson2.Text = sqlDataReader2.GetString(0);
            //    }

            //    if (text.Length > 0)
            //    {
            //        Interaction.MsgBox(text, MsgBoxStyle.Information, "Customer Sales Order Notes");
            //    }

            //    expr_210.Connection.Close();
            //    sqlConnection.Close();

            //    return;
            //}
            //sqlConnection.Close();
        }

        private void gridDetail_Sorted(object sender, EventArgs e)
        {
            this.Timer1.Enabled = true;
        }

        private void IdTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.IdTabControl1.SelectedIndex == 0)
            //{
            //    base.CancelButton = this.btnCLose;
            //    this.LoadExisting("BUTTON");
            //    return;
            //}

            //base.CancelButton = this.btnClose2;

            //if (this.SentSONo == 0)
            //{
            //    this.SentSONo = Convert.ToInt32(this.numSONumber.Value);
            //    this.Text = "Sales Order (" + Conversions.ToString(this.SentSONo) + ")";
            //    this.LoadExisting("");
            //}
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Timer2.Enabled = false;
            string text = this.cbCustomer.Text;

            if (this.IdTabControl1.SelectedIndex == 1)
            {
                this.IdTabControl1.SelectedIndex = 0;
            }

            //this.CustomersTableAdapter.Fill(this.IRDataSet.Customers);
            this.cbCustomer.Text = text;
            this.dataChanged = true;

            this.LoadCustDetails();
        }

        private void IdButton1_Click(object sender, EventArgs e)
        {
            this.GetSNumberDetail();
        }

        private void IdButton2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnSoScreen_Click(object sender, EventArgs e)
        {
            //int num = clsSO.PrintSalesOrder(Conversions.ToInteger(this.numSONumber.Text), true, "NONE", 0);

            //if (num != -1)
            //{
            //    return;
            //}

            //Interaction.MsgBox("There was an error creating the report.", MsgBoxStyle.OkOnly, null);
        }

        private void cmdGetTrack_Click(object sender, EventArgs e)
        {
            //int index = this.gridDetail.CurrentRow.Index;
            //int value = Conversions.ToInteger(this.gridDetail[0, index].Value);
            //int num = Common.IntScalar(("select isnull(InvoiceNo,0) from sNumbers where sNumberNo = " + Conversions.ToString(value)) ?? "", false);

            //if (num != 0)
            //{
            //    Clipboard.Clear();
            //    Clipboard.SetText(clsSO.GetTrackingNumber(num));
            //}
        }
    }
}
