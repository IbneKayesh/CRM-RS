using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class frmLoadData : Form
    {
        private string CurrentSQLServer;
        //there is no GUI for this Ping Tool
        Ping pingClient;
        public frmLoadData()
        {
            InitializeComponent();
            //there is no GUI for this Ping Tool, Add this Event Handler Manually
            pingClient.PingCompleted += new PingCompletedEventHandler(pingClient_PingCompleted);
        }
        private void pingClient_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                if (e.Reply.Status == IPStatus.Success)
                {
                    /////////////////////////////////////////////////////////////////////////////////this.ChangeStructure();
                   // MyProject.Forms.frmMain.Refresh();
                    this.Cursor = Cursors.WaitCursor;
                    this.pb1.Visible = true;
                    this.pb1.Value = 0;

                    ////////////if (Operators.CompareString(Common.ConStr, "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=IR;User ID=IRUser; Password=dmqh-421f", false) == 0)			// ?????????????????????????????
                    ////////////{
                    ////////////	Common.NonQuery("EXEC sp_dropserver '" + this.CurrentSQLServer + "', 'droplogins'", false);
                    ////////////	if (Common.NonQuery(string.Concat(new string[]
                    ////////////	{
                    ////////////		"USE [Master] EXEC Master.dbo.sp_addlinkedserver @server = N'",
                    ////////////		this.CurrentSQLServer,
                    ////////////		"', @srvproduct=N'SQL Server'; EXEC Master.dbo.sp_addlinkedsrvlogin @rmtsrvname = N'",
                    ////////////		this.CurrentSQLServer,
                    ////////////		"', @locallogin=N'sa' , @rmtuser = N'sa', @rmtpassword = N'30-06spring'"
                    ////////////	}), false) == 1)
                    ////////////	{
                    ////////////		this.LoadData();
                    ////////////		Common.NonQuery("EXEC sp_dropserver '" + this.CurrentSQLServer + "', 'droplogins'", false);
                    ////////////		Interaction.MsgBox("Data load complete you must restart the CRM to continue.", MsgBoxStyle.OkOnly, null);
                    ////////////		MyProject.Forms.frmMain.Close();
                    ////////////	}
                    ////////////	else
                    ////////////	{
                    ////////////		Interaction.MsgBox("Unable to link to the main server.", MsgBoxStyle.OkOnly, null);
                    ////////////		Common.NonQuery("EXEC sp_dropserver '" + this.CurrentSQLServer + "', 'droplogins'", false);
                    ////////////	}
                    ////////////}

                    this.Cursor = Cursors.Default;
                    base.Close();
                    return;
                }
                //Interaction.MsgBox("Unable to see main server. Please check you network connection and VPN as needed.", MsgBoxStyle.OkOnly, null);
                this.Cursor = Cursors.Default;
                base.Close();
            }
        }

        private void frmLoadData_Load(object sender, EventArgs e)
        {
            pingClient = new Ping();
            this.CurrentSQLServer = "";
        }
        private void ChangeStructure()
        {
            //Common.NonQuery("CREATE TABLE [dbo].[CPUserLog](\t[RecordID] [bigint] IDENTITY(1,1) NOT NULL,\t[UserID] [varchar](40) NULL,\t[LoginTime] [datetime] NULL,\t[LoginIP] [varchar](15) NULL, CONSTRAINT [PK_CPUserLog] PRIMARY KEY CLUSTERED (\t[RecordID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]", false);
            //Common.NonQuery("CREATE TABLE [dbo].[ApplicationUsers](\t[RecordID] [bigint] IDENTITY(1,1) NOT NULL,\t[UserID] [varchar](100) NOT NULL,\t[UserPassword] [varchar](60) NOT NULL,\t[LastPasswordDate] [datetime] NULL,\t[LoginTime] [datetime] NULL,\t[UserName] [varchar](50) NULL,\t[Email] [varchar](100) NULL,\t[CustomerNo] [varchar](20) NULL,\t[UserStatus] [bit] NULL,\t[ContactNo] [int] NULL, CONSTRAINT [PK_ApplicationUsers] PRIMARY KEY CLUSTERED (\t[RecordID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]", false);
            //Common.NonQuery("CREATE TABLE [dbo].[EmailAddresses](\t[RecordID] [int] IDENTITY(1,1) NOT NULL,\t[EmailAddress] [varchar](150) NOT NULL,\t[EmailPassword] [varchar](20) NOT NULL,\t[UsedToday] [int] NOT NULL, CONSTRAINT [PK_EmailAddresses_1] PRIMARY KEY CLUSTERED (\t[RecordID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]", false);
            //Common.NonQuery("CREATE TABLE [dbo].[ReportTempTotalGoal](\t[SessionKey] [varchar](100) NOT NULL,\t[Basis] [varchar](50) NULL,\t[Months] [int] NULL,\t[TGoal1] [decimal](19, 4) NULL,\t[TGoal2] [decimal](19, 4) NULL,\t[TGoal3] [decimal](19, 4) NULL,\t[TGoal4] [decimal](19, 4) NULL,\t[TGoal5] [decimal](19, 4) NULL,\t[TGoal6] [decimal](19, 4) NULL,\t[TGoal7] [decimal](19, 4) NULL,\t[TGoal8] [decimal](19, 4) NULL,\t[TGoal9] [decimal](19, 4) NULL,\t[TGoal10] [decimal](19, 4) NULL,\t[TGoal11] [decimal](19, 4) NULL,\t[TGoal12] [decimal](19, 4) NULL,\t[TGoal13] [decimal](19, 4) NULL, CONSTRAINT [PK_ReportTempTotalGoal] PRIMARY KEY CLUSTERED (\t[SessionKey] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]", false);
            //Common.NonQuery("ALTER TABLE CRMCompany ALTER COLUMN Equipment VARCHAR(1000) NULL", false);
            //Common.NonQuery("ALTER TABLE CRMCompany ALTER COLUMN Equipment2 VARCHAR(1000) NULL", false);
            //Common.NonQuery("ALTER TABLE CRMCompany ADD Lifetime DECIMAL(18,2) NULL", false);
            //Common.NonQuery("ALTER TABLE CRMContact ADD Sport VARCHAR(50) NULL", false);
            //Common.NonQuery("ALTER TABLE CRMContact ADD Team VARCHAR(50) NULL", false);
            //Common.NonQuery("ALTER TABLE CRMContact ADD Hobby VARCHAR(50) NULL", false);
            //Common.NonQuery("ALTER TABLE CompanyControl ADD ShippingOverridePass VARCHAR(50) NULL", false);
            //Common.NonQuery("ALTER TABLE Items ADD ItemPriceDate DATETIME NULL", false);
            //Common.NonQuery("ALTER TABLE CRMTasks ADD TaskCode INT NULL", false);
            //Common.NonQuery("ALTER TABLE Items ADD ItemPriceDate DATETIME NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal1 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal2 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal3 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal4 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal5 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal6 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal7 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal8 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal9 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal10 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal11 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal12 INT NULL", false);
            //Common.NonQuery("ALTER TABLE ReportsTempGoals ADD GroupTotal13 INT NULL", false);
            //Common.NonQuery("ALTER TABLE SNumbers ADD JobStatus VARCHAR(10) NULL", false);
            //Common.NonQuery("ALTER TABLE SNumbers ADD PortalNotes VARCHAR(6000) NULL", false);
            //Common.NonQuery("ALTER TABLE SNumbers ADD ReQuote bit NULL", false);
            //Common.NonQuery("ALTER TABLE SNumbers ADD ReQuoteDate DATETIME NULL", false);
            //Common.NonQuery("ALTER TABLE SNumbers ADD ReQuoteNote VARCHAR(200) NULL", false);
            //Common.NonQuery("CREATE VIEW [dbo].[VEditFreightCurrentOnly] AS SELECT distinct SN.InvoiceNo, qbi.QBInvoiceNo, SN.DateInvoiced, qbi.QBRegisterNo, cust.CustomerNo, it.linestotal, sm.ShipMethodid, sm.Description AS shipmethod,  SN.WaitingOnUPS, SN.Hold, SN.Freight, so.SalesOrderNo, cust.ChargeFreight, \t C.CompanyName, C.CompanyAddress1, C.Phone AS CompanyPhone, C.Fax AS CompanyFax FROM            dbo.SalesOrders AS so INNER JOIN     dbo.Customers AS cust ON so.CustomerNo = cust.CustomerNo INNER JOIN     dbo.SNumbers AS SN ON so.SalesOrderNo = SN.SalesOrderNo INNER JOIN  dbo.InvoiceTotal AS it ON SN.InvoiceNo = it.invoiceno LEFT OUTER JOIN   dbo.QBInvoice AS qbi ON SN.InvoiceNo = qbi.InvoiceNo LEFT OUTER JOIN    dbo.ShipMethod AS sm ON SN.ShipMethodID = sm.ShipMethodid CROSS JOIN     dbo.CompanyControl AS C \t where SN.Hold = 'true'", false);
            //Common.NonQuery("  CREATE VIEW [dbo].[EnhancedManageUserCombo] AS  SELECT UserID FROM CRMUsers where Active = 'True' and (NonRecordManager = 'False' or UserGroup = 'DRIVER') ", false);
            //Common.NonQuery("CREATE VIEW [dbo].[CPOrders] AS  SELECT        dbo.SalesOrders.SalesOrderNo, dbo.SalesOrders.CustomerNo, dbo.SNumbers.snumberNo, dbo.Manufacturer.Description, dbo.Items.ItemNumber,   dbo.SNumbers.SerialNumber, isnull(Price,0) + isnull(RushFee,0) as 'Price' , dbo.SNumbers.CustomerPONO, dbo.SNumbers.Shipped , dbo.SNumbers.JobStatus, dbo.SalesOrders.DateEntered   FROM            dbo.SalesOrders  JOIN dbo.SNumbers ON dbo.SalesOrders.SalesOrderNo = dbo.SNumbers.SalesOrderNo JOIN           dbo.Manufacturer ON dbo.SNumbers.ManufacturerNo = dbo.Manufacturer.ManufacturerNo  JOIN           dbo.Items ON dbo.Snumbers.ItemRecordID = dbo.Items.RecordID ", false);
            //Common.NonQuery("ALTER VIEW [dbo].[ReportJobLocation] AS SELECT        dbo.SNumbers.snumberNo, dbo.SalesOrders.SalesOrderNo, dbo.SNumbers.ApprovalDate, dbo.SNumbers.TechnicianNo, dbo.Customers.Company,                   dbo.SNumbers.Shipped, dbo.SNumbers.Rush, dbo.Manufacturer.Description, dbo.SNumbers.ItemNumber, dbo.SNumbers.Location,  \t\t\t\t dbo.SNumbers.Price + isnull(dbo.SNumbers.RushFee,0) as Price, dbo.SNumbers.RT, dbo.SNumbers.RTDate, dbo.SNumbers.DateShipped, dbo.SNumbers.BranchCode  FROM            dbo.SNumbers INNER JOIN                 dbo.SalesOrders ON dbo.SNumbers.SalesOrderNo = dbo.SalesOrders.SalesOrderNo INNER JOIN               dbo.Customers ON dbo.SalesOrders.CustomerNo = dbo.Customers.CustomerNo INNER JOIN                dbo.Manufacturer ON dbo.SNumbers.ManufacturerNo = dbo.Manufacturer.ManufacturerNo \t\t\t  where Location is not null", false);
            //Common.NonQuery("ALTER VIEW [dbo].[ReportJobNoLocation] AS   SELECT        dbo.SNumbers.snumberNo, dbo.SalesOrders.SalesOrderNo, dbo.SNumbers.ApprovalDate, dbo.SNumbers.TechnicianNo, dbo.Customers.Company,    dbo.SNumbers.Shipped, dbo.SNumbers.Rush, dbo.Manufacturer.Description, dbo.SNumbers.ItemNumber, dbo.SNumbers.Location,   dbo.SNumbers.Price + ISNULL(dbo.SNumbers.RushFee, 0) AS Price, dbo.SNumbers.RT, dbo.SNumbers.RTDate, dbo.SalesOrders.DateEntered, dbo.SNumbers.BranchCode    FROM            dbo.SNumbers INNER JOIN  dbo.SalesOrders ON dbo.SNumbers.SalesOrderNo = dbo.SalesOrders.SalesOrderNo INNER JOIN  dbo.Customers ON dbo.SalesOrders.CustomerNo = dbo.Customers.CustomerNo INNER JOIN  dbo.Manufacturer ON dbo.SNumbers.ManufacturerNo = dbo.Manufacturer.ManufacturerNo  WHERE        (dbo.SNumbers.Location IS NULL) AND (dbo.SNumbers.Shipped = 'False')", false);
            //Common.NonQuery("ALTER VIEW [dbo].[ReportActivityCall] AS  SELECT    H.HistoryID, H.CreateUserID as 'ManageUserID', H.CreateDate, CO.Name, CO.City, CO.State, CN.FirstName + ' ' + cn.LastName as 'ContactName', CO.Category, HT.name as Typename, Regarding, Details, TypeID, H.ManageUserID as 'RecordManager', CO.IRCode, CO.Lifetime, CN.MainPhone    FROM dbo.CRMHistory H join CRMCompany CO on H.CompanyID = CO.CompanyID join CRMContact CN on H.ContactID = CN.ContactID join CRMHistoryType HT on H.TypeID = HT.HistoryTypeID", false);
        }

        private void CloseOtherForms()
        {
            //Form[] mdiChildren = MyProject.Forms.frmMain.MdiChildren;
            //checked
            //{
            //    for (int i = 0; i < mdiChildren.Length; i++)
            //    {
            //        Form form = mdiChildren[i];
            //        if (Operators.CompareString(form.Name, base.Name, false) != 0)
            //        {
            //            form.Close();
            //        }
            //    }
            //}
        }

        private void LoadData()
        {
            //Common.NonQuery("delete from CompanyControl", false);
            //Common.NonQuery("insert into CompanyControl select * from [" + this.CurrentSQLServer + "].IR.dbo.CompanyControl", false);
            //checked
            //{
            //    idProgressBar pb;
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMComboData", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMComboData ON insert into CRMComboData  (RecordID, Name, Description, ComboName) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMComboData", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMCompany", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMCompany ON insert into CRMCompany (CompanyID, Address1, Address2, AssignmentDate, Category, City, Classification, Competition, Competition2, County, Country, CreateDate, CreateUserID, DUNSNo, Equipment, Equipment2, GroupID, IRCode, ManageUserID, MSA, Name, Notes, NumberEmployees, Products, ReferredBy, Region, Revenue, SICCode, State, Status, Territory, Type, VendorNo, WEBAddress, ZipCode, Lat, Long, Lifetime) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMCompany", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMContact", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMContact ON insert into CRMContact (ContactID, AltPhone, AltPhoneExt, CellPhone, CompanyID, ConStatus, CreateUserID, Department, Email, FaxNumber, FirstName, JobTitle, LastAttemptDate, LastLetterDate, LasteMailDate, LastMeetDate, LastName, LastReachDate, MainPhone, Middlename, NamePrefix, NameSuffix, Notes, PrimaryContact, PrimaryOrder, Phone, PhoneExt, WorkHours, NoCompanyEmail, DefaultContact, Sport, Team, Hobby) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMContact", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMDocuments", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMDocuments ON insert into CRMDocuments (DocumentID, FileName, DisplayName, ActivityID, HistoryID, FilePath, CompanyID, ContactID, DocumentDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMDocuments", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMEmailTemplates", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMEmailTemplates ON insert into CRMEmailTemplates (TemplateID, TemplateName, Subject, Body, DefaultTemplate, Active, DocumentPath) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMEmailTemplates", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMGroup", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMGroup ON insert into CRMGroup (GroupID, Name, Description, HasSubGroup, ParentGroupID, ManageUserID) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMGroup", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMHistory", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMHistory ON insert into CRMHistory (HistoryID, CompanyID, ContactID, TypeID, StartTime, EndTime, Regarding, Details, ManageUserID, CreateUserID, CreateDate) select HistoryID, CompanyID, ContactID, TypeID, StartTime, EndTime, Regarding, Details, ManageUserID, CreateUserID, CreateDate from [" + this.CurrentSQLServer + "].IR.dbo.CRMHistory", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMHistoryArchive", false);
            //    Common.NonQuery("insert into CRMHistoryArchive (HistoryID, CompanyID, ContactID, TypeID, StartTime, EndTime, Regarding, Details, ManageUserID, CreateUserID, CreateDate) select HistoryID, CompanyID, ContactID, TypeID, StartTime, EndTime, Regarding, Details, ManageUserID, CreateUserID, CreateDate from [" + this.CurrentSQLServer + "].IR.dbo.CRMHistoryArchive", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMHistoryType", false);
            //    Common.NonQuery("insert into CRMHistoryType select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMHistoryType", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMHistoryTypeGroup", false);
            //    Common.NonQuery("insert into CRMHistoryTypeGroup select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMHistoryTypeGroup", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMHistoryTypeSuperGroup", false);
            //    Common.NonQuery("insert into CRMHistoryTypeSuperGroup select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMHistoryTypeSuperGroup", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMLookupFields", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMLookupFields ON insert into CRMLookupFields (RecordID, FormShowing, FieldName, DisplayName, FieldType) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMLookupFields", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMPickup", false);
            //    Common.NonQuery("insert into CRMPickup select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMPickup", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMPickupLines", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMPickupLines ON insert into CRMPickupLines (RecordID, PickupID, Qty, Manufacturer, ItemNumbner, Description, Problem, Rush, Price, Warranty, Each) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMPickupLines", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMQuote", false);
            //    Common.NonQuery("insert into CRMQuote select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMQuote", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMQuoteLines", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMQuoteLines ON insert into CRMQuoteLines (RecordID, QuoteID, Qty, Manufacturer, ItemNumbner, Description, Problem, Rush, QuotePrice, Each) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMQuoteLines", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMRMA", false);
            //    Common.NonQuery("insert into CRMRMA select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMRMA", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMRMALines", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMRMALines ON insert into CRMRMALines (RecordID, RMAID, Qty, Manufacturer, ItemNumbner, Description, Problem, Rush, RepairPrice, SalesOrderNo, SnumberNo, Warranty, Each) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMRMALines", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMTaskColor", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMTaskColor ON insert into CRMTaskColor (RecordID, Name, TaskColor) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMTaskColor", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMTasks", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMTasks ON insert into CRMTasks (TaskID, AttachmentID, CompanyID, ContactID, CreateDate, CreateUserID, Deleted, Details, EndTime, Location, Regarding, StartTime, TaskPriority, TaskType, ManageUserID, TaskColor, ReminderTime, OnHold, DeleteDate) select TaskID, AttachmentID, CompanyID, ContactID, CreateDate, CreateUserID, Deleted, Details, EndTime, Location, Regarding, StartTime, TaskPriority, TaskType, ManageUserID, TaskColor, ReminderTime, OnHold, DeleteDate from [" + this.CurrentSQLServer + "].IR.dbo.CRMTasks", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMTaskType", false);
            //    Common.NonQuery("insert into CRMTaskType select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMTaskType", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMUserForms", false);
            //    Common.NonQuery("insert into CRMUserForms select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMUserForms", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMUserGroups", false);
            //    Common.NonQuery("insert into CRMUserGroups select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMUserGroups", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMUserLinks", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CRMUserLinks ON insert into CRMUserLinks (RecordID, UserID, UserLinkID, LinkType) select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMUserLinks", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMUserPermissions", false);
            //    Common.NonQuery("insert into CRMUserPermissions select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMUserPermissions", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CRMUsers", false);
            //    Common.NonQuery("insert into CRMUsers select * from [" + this.CurrentSQLServer + "].IR.dbo.CRMUsers", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CustomerContacts", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CustomerContacts ON insert into CustomerContacts (ContactID, CustomerNo, eMail, Fax, Name, PayableContact, Phone, SalesContact, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.CustomerContacts", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CustomerItem", false);
            //    Common.NonQuery("insert into CustomerItem select * from [" + this.CurrentSQLServer + "].IR.dbo.CustomerItem", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CustomerManufacturer", false);
            //    Common.NonQuery("insert into CustomerManufacturer select * from [" + this.CurrentSQLServer + "].IR.dbo.CustomerManufacturer", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Customers", false);
            //    Common.NonQuery("insert into Customers select * from [" + this.CurrentSQLServer + "].IR.dbo.Customers", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CustomerShipTo", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CustomerShipTo ON insert into CustomerShipTo (ShipToID, CustomerNo, AddressOne, AddressThree, AddressTwo, City, State, LastChangedDate, Zip) select * from [" + this.CurrentSQLServer + "].IR.dbo.CustomerShipTo", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from CustomReportFields", false);
            //    Common.NonQuery("SET IDENTITY_INSERT CustomReportFields ON insert into CustomReportFields (RecordID, DisplayName, FieldName, FieldSize, FieldType, TabName, Filter, PSOnly) select * from [" + this.CurrentSQLServer + "].IR.dbo.CustomReportFields", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from DocumentManagement", false);
            //    Common.NonQuery("SET IDENTITY_INSERT DocumentManagement ON insert into DocumentManagement (RecordID, SalesOrderNo, DateEntered, DocumentTitle, UserID, InvoiceNo, SnumberNo, DocumentPath) select * from [" + this.CurrentSQLServer + "].IR.dbo.DocumentManagement", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Fedex_Shipment", false);
            //    Common.NonQuery("SET IDENTITY_INSERT Fedex_Shipment ON insert into Fedex_Shipment (fedex_shipment_id, voidindicator, fedex_id, actualweight, billableweight, shipdate, calculatedrate, billablerate, timestamp, publishedrate, servicetype, Id) select * from [" + this.CurrentSQLServer + "].IR.dbo.Fedex_Shipment", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from FedexBillingOption", false);
            //    Common.NonQuery("insert into FedexBillingOption select * from [" + this.CurrentSQLServer + "].IR.dbo.FedexBillingOption", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from FedexServiceType", false);
            //    Common.NonQuery("SET IDENTITY_INSERT FedexServiceType ON insert into FedexServiceType (fedexServiceType_id, serviceType, sequence) select * from [" + this.CurrentSQLServer + "].IR.dbo.FedexServiceType", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Fedexshipment", false);
            //    Common.NonQuery("insert into Fedexshipment select * from [" + this.CurrentSQLServer + "].IR.dbo.Fedexshipment", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from FedexShipMethod", false);
            //    Common.NonQuery("insert into FedexShipMethod select * from [" + this.CurrentSQLServer + "].IR.dbo.FedexShipMethod", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from InvGeneral", false);
            //    Common.NonQuery("SET IDENTITY_INSERT InvGeneral ON insert into InvGeneral (RecordID, Sku, VendorNo, VendorName, ManufPartNo, Manufacturer, ProductGroup, UnitOfMeasure, BinNo, Category, InvFlag, ListPrice, UnitPrice, UnitCost, Tax, QtyOnHand, QtyOnOrder, QtyOnBack, QtyAllocated, MinimumQty, MaximumQty, LastActivityDt, LeadTime, UnitSize, InvDescription, CurrYrUsage, LastYrUsage, NA) select * from [" + this.CurrentSQLServer + "].IR.dbo.InvGeneral", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ItemClasses", false);
            //    Common.NonQuery("insert into ItemClasses select * from [" + this.CurrentSQLServer + "].IR.dbo.ItemClasses", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Items", false);
            //    Common.NonQuery("SET IDENTITY_INSERT Items ON insert into Items (RecordID, Description, ItemClassName, ItemNumber, Weight, ManufacturerNo, OutsourceVendorNo, PrintFlag, Status, LastChangedDate, ListPrice, ItemCost, Notes, OEMPrice, VendorNo, HoldDate, WARRANTY_ADBF, PictureOnFile, ItemPriceDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.Items", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from LastSNumber", false);
            //    Common.NonQuery("insert into LastSNumber select * from [" + this.CurrentSQLServer + "].IR.dbo.LastSNumber", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Manufacturer", false);
            //    Common.NonQuery("SET IDENTITY_INSERT Manufacturer ON insert into Manufacturer (ManufacturerNo, Description, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.Manufacturer", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from OutSource", false);
            //    Common.NonQuery("insert into OutSource select * from [" + this.CurrentSQLServer + "].IR.dbo.OutSource", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from PartsOrders", false);
            //    Common.NonQuery("SET IDENTITY_INSERT PartsOrders ON insert into PartsOrders (RecordID, ApprovalDate, ApprovedBy, Approved, EnteredBy, EntryDate, Manufacturer, Notes, OrderDate, OrderedBy, Ordered, PartNumber, PONO, Qty, ReceivedDate, SnumberNo, TechnicianNo, NA, UnitCost, CostConfirmed, POLineID, ItemDescription, VendorPartNo, VendorNo, BenchStock) select * from [" + this.CurrentSQLServer + "].IR.dbo.PartsOrders", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from POLineDetail", false);
            //    Common.NonQuery("SET IDENTITY_INSERT POLineDetail ON insert into POLineDetail (POLineDetailID, POLineID, SNumberNo, Qty, Notes, LastUpdated, DateRequired, LineType, ReceivedQty) select * from [" + this.CurrentSQLServer + "].IR.dbo.POLineDetail", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from POLines", false);
            //    Common.NonQuery("SET IDENTITY_INSERT POLines ON insert into POLines (POLineID, PONO, POLineNo, PartNumber, ItemDescription, TotalQtyOrdered, QtyReceived, QtyStockOrdered, Manufacturer, UnitCost, LineTotal, Notes, DateOrdered, DateExpected, ReferenceNo, Received, CostConfirmed, BinNumber, StockNumber) select * from [" + this.CurrentSQLServer + "].IR.dbo.POLines", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from POMaster", false);
            //    Common.NonQuery("insert into POMaster select * from [" + this.CurrentSQLServer + "].IR.dbo.POMaster", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from POReceived", false);
            //    Common.NonQuery("SET IDENTITY_INSERT POReceived ON insert into POReceived (POReceivedID, PONO, Manufacturer, ItemDescription, EntryDate, DateReceived, QtyReceived, QtyStockReceived, ReceivedPrice, ReceivedBy, Freight, Posted, Status, POLineID, PaidLine, PartNumber, UnitCost, LineTotal, PackingSlip) select * from [" + this.CurrentSQLServer + "].IR.dbo.POReceived", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from QBInvoice", false);
            //    Common.NonQuery("insert into QBInvoice select * from [" + this.CurrentSQLServer + "].IR.dbo.QBInvoice", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from QBRegister", false);
            //    Common.NonQuery("SET IDENTITY_INSERT QBRegister ON insert into QBRegister (QBRegisterNo, RunDate, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.QBRegister", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from QBShipment", false);
            //    Common.NonQuery("insert into QBShipment select * from [" + this.CurrentSQLServer + "].IR.dbo.QBShipment", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ReportCustomerRankingList", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ReportJobTotals", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ReportSalesGoalsGraph", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ReportsTempGoals", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ReportsTempPerformance", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from RURReason", false);
            //    Common.NonQuery("SET IDENTITY_INSERT RURReason ON insert into RURReason (RURReasonNo, Description, LastChangedDate, UserDefined) select * from [" + this.CurrentSQLServer + "].IR.dbo.RURReason", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from RURShipment", false);
            //    Common.NonQuery("insert into RURShipment select * from [" + this.CurrentSQLServer + "].IR.dbo.RURShipment", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from RURShipmentRURReason", false);
            //    Common.NonQuery("insert into RURShipmentRURReason select * from [" + this.CurrentSQLServer + "].IR.dbo.RURShipmentRURReason", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from RushOption", false);
            //    Common.NonQuery("SET IDENTITY_INSERT RushOption ON insert into RushOption (RushOptionNo, ShortDescription, Description, Rate, MinimumOverride, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.RushOption", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from SalesOrderPrintQue", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from SalesOrders", false);
            //    Common.NonQuery("insert into SalesOrders select * from [" + this.CurrentSQLServer + "].IR.dbo.SalesOrders", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from SalesPeople", false);
            //    Common.NonQuery("SET IDENTITY_INSERT SalesPeople ON insert into SalesPeople (SalesPersonNo, Name, Status, StartDate, EndDate, Notes, SalesNo, LastChangedDate, OutsideSales) select * from [" + this.CurrentSQLServer + "].IR.dbo.SalesPeople", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from SalespersonGoals", false);
            //    Common.NonQuery("insert into SalespersonGoals select * from [" + this.CurrentSQLServer + "].IR.dbo.SalespersonGoals", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from SalesTotalsReport", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from SavedReports", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ScanLog", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Service", false);
            //    Common.NonQuery("SET IDENTITY_INSERT Service ON insert into Service (ServiceNo, Description, ServiceType, UserDefined, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.Service", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ServiceType", false);
            //    Common.NonQuery("insert into ServiceType select * from [" + this.CurrentSQLServer + "].IR.dbo.ServiceType", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ShipmentCodes", false);
            //    Common.NonQuery("SET IDENTITY_INSERT ShipmentCodes ON insert into ShipmentCodes (ShipmentCodeID, CodeDescription, RUR, PrintRURReport, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.ShipmentCodes", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from ShipMethod", false);
            //    Common.NonQuery("SET IDENTITY_INSERT ShipMethod ON insert into ShipMethod (ShipMethodid, Billable, Description, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.ShipMethod", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from SNumbers", false);
            //    Common.NonQuery("insert into SNumbers select * from [" + this.CurrentSQLServer + "].IR.dbo.SNumbers", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Stamps", false);
            //    Common.NonQuery("insert into Stamps select * from [" + this.CurrentSQLServer + "].IR.dbo.Stamps", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from StateAbbrev", false);
            //    Common.NonQuery("insert into StateAbbrev select * from [" + this.CurrentSQLServer + "].IR.dbo.StateAbbrev", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Technicians", false);
            //    Common.NonQuery("SET IDENTITY_INSERT Technicians ON insert into Technicians (TechnicianNo, Initials, Name, StartDate, EndDate, Status, TechNo, LastChangedDate, BenchNo, WPShelfNo) select * from [" + this.CurrentSQLServer + "].IR.dbo.Technicians", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from TechNotes", false);
            //    Common.NonQuery("insert into TechNotes select * from [" + this.CurrentSQLServer + "].IR.dbo.TechNotes", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from TechNotesService", false);
            //    Common.NonQuery("insert into TechNotesService select * from [" + this.CurrentSQLServer + "].IR.dbo.TechNotesService", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from TechPerformanceReport", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from TechWPShelf", false);
            //    Common.NonQuery("SET IDENTITY_INSERT TechWPShelf ON insert into TechWPShelf (RecordID, TechnicianNo, WPShelfNo) select * from [" + this.CurrentSQLServer + "].IR.dbo.TechWPShelf", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UPSBillingOption", false);
            //    Common.NonQuery("SET IDENTITY_INSERT UPSBillingOption ON insert into UPSBillingOption (upsBillingOption_id, billingOption, sequence, isConsigned, isThirdParty, isCollect) select * from [" + this.CurrentSQLServer + "].IR.dbo.UPSBillingOption", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UPSIn", false);
            //    Common.NonQuery("SET IDENTITY_INSERT UPSIn ON insert into UPSIn (ups_id, bookNumber, shipmentID, actualWeight, billableWeight, pickUpDate, documentsOnlyIndicator, numberOfPackages, declaredValueCharge, hazardousMaterialsCharge, pageNumber, hundredWeight, extendedAreaIndicator, calculatedRate, shipmentNotification1Charge, totalReceiverCharge, additionalHandlingCharge, deliveryConfirmationCharge, voidIndicator, codCharge, id, timestamp, other_invoice_id, totalShipperCharge, totalShipmentCharge) select * from [" + this.CurrentSQLServer + "].IR.dbo.UPSIn", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UPSOut", false);
            //    Common.NonQuery("insert into UPSOut select * from [" + this.CurrentSQLServer + "].IR.dbo.UPSOut", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UPSServiceType", false);
            //    Common.NonQuery("SET IDENTITY_INSERT UPSServiceType ON insert into UPSServiceType (upsServiceType_id, serviceType, sequence) select * from [" + this.CurrentSQLServer + "].IR.dbo.UPSServiceType", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UPSShipment", false);
            //    Common.NonQuery("SET IDENTITY_INSERT UPSShipment ON insert into UPSShipment (upsShipment_Id, invoice_id, shipmentID, bookNumber, pageNumber, actualWeight, billableWeight, numberOfPackages, calculatedRate, codCharge, dateProcessed, timestamp, handling, invoiceUpdated) select * from [" + this.CurrentSQLServer + "].IR.dbo.UPSShipment", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UPSShipment_Other", false);
            //    Common.NonQuery("insert into UPSShipment_Other select * from [" + this.CurrentSQLServer + "].IR.dbo.UPSShipment_Other", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UPSShipMethod", false);
            //    Common.NonQuery("insert into UPSShipMethod select * from [" + this.CurrentSQLServer + "].IR.dbo.UPSShipMethod", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UserForms", false);
            //    Common.NonQuery("insert into UserForms select * from [" + this.CurrentSQLServer + "].IR.dbo.UserForms", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UserGroups", false);
            //    Common.NonQuery("insert into UserGroups select * from [" + this.CurrentSQLServer + "].IR.dbo.UserGroups", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UserLog", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from UserPermissions", false);
            //    Common.NonQuery("insert into UserPermissions select * from [" + this.CurrentSQLServer + "].IR.dbo.UserPermissions", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Users", false);
            //    Common.NonQuery("insert into Users select * from [" + this.CurrentSQLServer + "].IR.dbo.Users", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //    Common.NonQuery("delete from Vendors", false);
            //    Common.NonQuery("SET IDENTITY_INSERT Vendors ON insert into Vendors (VendorNo, VendorName, Address1, Address2, Address3, City, State, Zip, VendorContact, VendorPhone, VendorFax, VendorEmail, VendorNotes, VendorStatus, Parts, LastChangedDate) select * from [" + this.CurrentSQLServer + "].IR.dbo.Vendors", false);
            //    (pb = this.pb1).Value = pb.Value + 1;
            //    this.pb1.Refresh();
            //}
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            //if (Interaction.MsgBox("This will delete all data in your local database and then load fresh data from the main server.\rDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical, "Load Data") == MsgBoxResult.No)
            //{
            //    base.Close();
            //    return;
            //}
            //if (Interaction.MsgBox("This will take some time and requires a fast connection to the office. Once you click OK you are comitted and the process cannot be stopped until complete.\rClick OK when you are ready.", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical, "ARE YOU SURE???") == MsgBoxResult.Cancel)
            //{
            //    base.Close();
            //    return;
            //}
            //this.CurrentSQLServer = this.CheckSQLStatus();
            //if (Operators.CompareString(this.CurrentSQLServer, "BAD", false) == 0)
            //{
            //    Interaction.MsgBox("Unable to see main server. Please check you network connection and VPN as needed.", MsgBoxStyle.OkOnly, null);
            //    this.Cursor = Cursors.Default;
            //    base.Close();
            //    return;
            //}
            //this.CloseOtherForms();
            //this.Cursor = Cursors.WaitCursor;
            //this.sendPing();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private string CheckSQLStatus()
        {
            //SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["IR2ConnectionString"]);

            //string dataSource;
            //string result;
            //try
            //{
            //    sqlConnection.Open();
            //    dataSource = sqlConnection.DataSource;
            //    sqlConnection.Close();
            //}
            //catch (Exception expr_20)
            //{
            //    ProjectData.SetProjectError(expr_20);
            //    result = "BAD";
            //    ProjectData.ClearProjectError();
            //    return result;
            //}
            //result = dataSource;
            return result;
        }

        private void sendPing()
        {
            //string hostNameOrAddress = "10.0.1.14";
            //this.pingClient.SendAsync(hostNameOrAddress, null);
        }
    }
}
