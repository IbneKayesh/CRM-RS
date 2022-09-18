using CRM.IRDataSetViewsTableAdapters;
using CRM.My;
using CRM.My.Resources;
using DevXPortableTools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CRM
{
    [DesignerGenerated]
    public class frmMain : Form
    {
        #region Generated Code
        private IContainer components;

        [AccessedThroughProperty("FileToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _FileToolStripMenuItem;

        [AccessedThroughProperty("PrintCurrentFormToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _PrintCurrentFormToolStripMenuItem;

        [AccessedThroughProperty("ExitToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ExitToolStripMenuItem;

        [AccessedThroughProperty("ToolsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ToolsToolStripMenuItem;

        [AccessedThroughProperty("UsersToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _UsersToolStripMenuItem;

        [AccessedThroughProperty("UsersToolStripMenuItem1"), CompilerGenerated]
        private ToolStripMenuItem _UsersToolStripMenuItem1;

        [AccessedThroughProperty("UserGroupsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _UserGroupsToolStripMenuItem;

        [AccessedThroughProperty("StatusStrip1"), CompilerGenerated]
        private StatusStrip _StatusStrip1;

        [AccessedThroughProperty("WindowToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _WindowToolStripMenuItem;

        [AccessedThroughProperty("CascadeToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _CascadeToolStripMenuItem;

        [AccessedThroughProperty("TileVerticleToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _TileVerticleToolStripMenuItem;

        [AccessedThroughProperty("TileHorizontalToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _TileHorizontalToolStripMenuItem;

        [AccessedThroughProperty("MenuStrip1"), CompilerGenerated]
        private MenuStrip _MenuStrip1;

        [AccessedThroughProperty("IdPanel1"), CompilerGenerated]
        private idPanel _IdPanel1;

        [AccessedThroughProperty("btnGroups"), CompilerGenerated]
        private idButton _btnGroups;

        [AccessedThroughProperty("btnSearch"), CompilerGenerated]
        private idButton _btnSearch;

        [AccessedThroughProperty("btnContacts"), CompilerGenerated]
        private idButton _btnContacts;

        [AccessedThroughProperty("btnTasks"), CompilerGenerated]
        private idButton _btnTasks;

        [AccessedThroughProperty("cbLookup"), CompilerGenerated]
        private idComboBox _cbLookup;

        [AccessedThroughProperty("lblLookup"), CompilerGenerated]
        private idLabel _lblLookup;

        [AccessedThroughProperty("IdLabel1"), CompilerGenerated]
        private idLabel _IdLabel1;

        [AccessedThroughProperty("btnFind"), CompilerGenerated]
        private idButton _btnFind;

        [AccessedThroughProperty("ckPartial"), CompilerGenerated]
        private idCheckBox _ckPartial;

        [AccessedThroughProperty("IdGroupBox1"), CompilerGenerated]
        private idGroupBox _IdGroupBox1;

        [AccessedThroughProperty("btnAdvFind"), CompilerGenerated]
        private idButton _btnAdvFind;

        [AccessedThroughProperty("btnCalendar"), CompilerGenerated]
        private idButton _btnCalendar;

        [AccessedThroughProperty("EmailContentToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _EmailContentToolStripMenuItem;

        [AccessedThroughProperty("ckShowAllContacts"), CompilerGenerated]
        private idCheckBox _ckShowAllContacts;

        [AccessedThroughProperty("Timer1"), CompilerGenerated]
        private Timer _Timer1;

        [AccessedThroughProperty("lblRecordCount"), CompilerGenerated]
        private ToolStripStatusLabel _lblRecordCount;

        [AccessedThroughProperty("UserLogToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _UserLogToolStripMenuItem;

        [AccessedThroughProperty("MaintenanceFormsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _MaintenanceFormsToolStripMenuItem;

        [AccessedThroughProperty("NoteTypeToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _NoteTypeToolStripMenuItem;

        [AccessedThroughProperty("TaskTypeToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _TaskTypeToolStripMenuItem;

        [AccessedThroughProperty("LookupFieldsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _LookupFieldsToolStripMenuItem;

        [AccessedThroughProperty("ImportsProspectsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ImportsProspectsToolStripMenuItem;

        [AccessedThroughProperty("Timer2"), CompilerGenerated]
        private Timer _Timer2;

        [AccessedThroughProperty("Timer3"), CompilerGenerated]
        private Timer _Timer3;

        [AccessedThroughProperty("ChangePasswordToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ChangePasswordToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem1"), CompilerGenerated]
        private ToolStripSeparator _ToolStripMenuItem1;

        [AccessedThroughProperty("ckSecondary"), CompilerGenerated]
        private idCheckBox _ckSecondary;

        [AccessedThroughProperty("ckLookupAll"), CompilerGenerated]
        private idCheckBox _ckLookupAll;

        [AccessedThroughProperty("DropDownsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _DropDownsToolStripMenuItem;

        [AccessedThroughProperty("cbLookupData"), CompilerGenerated]
        private idComboBox _cbLookupData;

        [AccessedThroughProperty("OpenFileDialog1"), CompilerGenerated]
        private OpenFileDialog _OpenFileDialog1;

        [AccessedThroughProperty("ApplicationControlToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ApplicationControlToolStripMenuItem;

        [AccessedThroughProperty("ToDoPopup"), CompilerGenerated]
        private Timer _ToDoPopup;

        [AccessedThroughProperty("MyPreferencesToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _MyPreferencesToolStripMenuItem;

        [AccessedThroughProperty("ckAllTasks"), CompilerGenerated]
        private idCheckBox _ckAllTasks;

        [AccessedThroughProperty("ReportsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ReportsToolStripMenuItem;

        [AccessedThroughProperty("SalesTotalsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _SalesTotalsToolStripMenuItem;

        [AccessedThroughProperty("lblTasks"), CompilerGenerated]
        private idLabel _lblTasks;

        [AccessedThroughProperty("cbTasks"), CompilerGenerated]
        private idComboBox _cbTasks;

        [AccessedThroughProperty("IRDataSetViews"), CompilerGenerated]
        private IRDataSetViews _IRDataSetViews;

        [AccessedThroughProperty("ManageUserComboBindingSource"), CompilerGenerated]
        private BindingSource _ManageUserComboBindingSource;

        [AccessedThroughProperty("ManageUserComboTableAdapter"), CompilerGenerated]
        private ManageUserComboTableAdapter _ManageUserComboTableAdapter;

        [AccessedThroughProperty("lblCalendar"), CompilerGenerated]
        private idLabel _lblCalendar;

        [AccessedThroughProperty("cbCalendar"), CompilerGenerated]
        private idComboBox _cbCalendar;

        [AccessedThroughProperty("ckHideInactive"), CompilerGenerated]
        private idCheckBox _ckHideInactive;

        [AccessedThroughProperty("BackToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _BackToolStripMenuItem;

        [AccessedThroughProperty("ForewardToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ForewardToolStripMenuItem;

        [AccessedThroughProperty("LastLookupToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _LastLookupToolStripMenuItem;

        [AccessedThroughProperty("DataLoadToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _DataLoadToolStripMenuItem;

        [AccessedThroughProperty("CallReportToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _CallReportToolStripMenuItem;

        [AccessedThroughProperty("RefreshCompanyToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _RefreshCompanyToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem2"), CompilerGenerated]
        private ToolStripSeparator _ToolStripMenuItem2;

        [AccessedThroughProperty("OpenRMAToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _OpenRMAToolStripMenuItem;

        [AccessedThroughProperty("OpenQuotesToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _OpenQuotesToolStripMenuItem;

        [AccessedThroughProperty("PickupsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _PickupsToolStripMenuItem;

        [AccessedThroughProperty("DeleteContactToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _DeleteContactToolStripMenuItem;

        [AccessedThroughProperty("gbLegend"), CompilerGenerated]
        private idGroupBox _gbLegend;

        [AccessedThroughProperty("IdLabel5"), CompilerGenerated]
        private idLabel _IdLabel5;

        [AccessedThroughProperty("IdLabel4"), CompilerGenerated]
        private idLabel _IdLabel4;

        [AccessedThroughProperty("IdLabel3"), CompilerGenerated]
        private idLabel _IdLabel3;

        [AccessedThroughProperty("IdLabel2"), CompilerGenerated]
        private idLabel _IdLabel2;

        [AccessedThroughProperty("IdLabel6"), CompilerGenerated]
        private idLabel _IdLabel6;

        [AccessedThroughProperty("IdLabel8"), CompilerGenerated]
        private idLabel _IdLabel8;

        [AccessedThroughProperty("IdLabel7"), CompilerGenerated]
        private idLabel _IdLabel7;

        [AccessedThroughProperty("TodaysActivitiesToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _TodaysActivitiesToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem3"), CompilerGenerated]
        private ToolStripSeparator _ToolStripMenuItem3;

        [AccessedThroughProperty("MapsToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _MapsToolStripMenuItem;

        [AccessedThroughProperty("SalesRouteToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _SalesRouteToolStripMenuItem;

        [AccessedThroughProperty("CurrentCompanyToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _CurrentCompanyToolStripMenuItem;

        [AccessedThroughProperty("UpdateLocalDataToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _UpdateLocalDataToolStripMenuItem;

        [AccessedThroughProperty("EnhancedManageUserComboBindingSource"), CompilerGenerated]
        private BindingSource _EnhancedManageUserComboBindingSource;

        [AccessedThroughProperty("EnhancedManageUserComboTableAdapter"), CompilerGenerated]
        private EnhancedManageUserComboTableAdapter _EnhancedManageUserComboTableAdapter;

        [AccessedThroughProperty("JustForJeffToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _JustForJeffToolStripMenuItem;

        [AccessedThroughProperty("btnMap"), CompilerGenerated]
        private idButton _btnMap;

        [AccessedThroughProperty("CustomerIssuesToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _CustomerIssuesToolStripMenuItem;

        [AccessedThroughProperty("NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem;

        [AccessedThroughProperty("NotifyMikeOfCustomerIssueToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _NotifyMikeOfCustomerIssueToolStripMenuItem;

        [AccessedThroughProperty("FranciesListToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _FranciesListToolStripMenuItem;

        [AccessedThroughProperty("MikesListToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _MikesListToolStripMenuItem;

        [AccessedThroughProperty("ProductivityReportToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _ProductivityReportToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem4"), CompilerGenerated]
        private ToolStripSeparator _ToolStripMenuItem4;

        [AccessedThroughProperty("HorseRaceToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _HorseRaceToolStripMenuItem;

        [AccessedThroughProperty("mnuNoOnAreas"), CompilerGenerated]
        private ToolStripMenuItem _mnuNoOnAreas;

        [AccessedThroughProperty("ToolStripMenuItem5"), CompilerGenerated]
        private ToolStripSeparator _ToolStripMenuItem5;

        [AccessedThroughProperty("TelemarketerNewCustomerToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _TelemarketerNewCustomerToolStripMenuItem;

        [AccessedThroughProperty("TelemarketerActivityToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _TelemarketerActivityToolStripMenuItem;

        [AccessedThroughProperty("SpecialStuffToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _SpecialStuffToolStripMenuItem;

        [AccessedThroughProperty("SetVersionNumberToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem _SetVersionNumberToolStripMenuItem;

        //private int HoldCount;

        //public int frmShowing;

        //private DataTable dtLookup;

        //private string tmpRecManager;
        #endregion

        #region Secondary Generated Code 

        internal virtual ToolStripMenuItem FileToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem PrintCurrentFormToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._PrintCurrentFormToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.PrintCurrentFormToolStripMenuItem_Click);
                ToolStripMenuItem printCurrentFormToolStripMenuItem = this._PrintCurrentFormToolStripMenuItem;
                if (printCurrentFormToolStripMenuItem != null)
                {
                    printCurrentFormToolStripMenuItem.Click -= value2;
                }
                this._PrintCurrentFormToolStripMenuItem = value;
                printCurrentFormToolStripMenuItem = this._PrintCurrentFormToolStripMenuItem;
                if (printCurrentFormToolStripMenuItem != null)
                {
                    printCurrentFormToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ExitToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._ExitToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ExitToolStripMenuItem_Click);
                ToolStripMenuItem exitToolStripMenuItem = this._ExitToolStripMenuItem;
                if (exitToolStripMenuItem != null)
                {
                    exitToolStripMenuItem.Click -= value2;
                }
                this._ExitToolStripMenuItem = value;
                exitToolStripMenuItem = this._ExitToolStripMenuItem;
                if (exitToolStripMenuItem != null)
                {
                    exitToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ToolsToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem UsersToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem UsersToolStripMenuItem1
        {
            [CompilerGenerated]
            get
            {
                return this._UsersToolStripMenuItem1;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.UsersToolStripMenuItem1_Click);
                ToolStripMenuItem usersToolStripMenuItem = this._UsersToolStripMenuItem1;
                if (usersToolStripMenuItem != null)
                {
                    usersToolStripMenuItem.Click -= value2;
                }
                this._UsersToolStripMenuItem1 = value;
                usersToolStripMenuItem = this._UsersToolStripMenuItem1;
                if (usersToolStripMenuItem != null)
                {
                    usersToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem UserGroupsToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._UserGroupsToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.UserGroupsToolStripMenuItem_Click);
                ToolStripMenuItem userGroupsToolStripMenuItem = this._UserGroupsToolStripMenuItem;
                if (userGroupsToolStripMenuItem != null)
                {
                    userGroupsToolStripMenuItem.Click -= value2;
                }
                this._UserGroupsToolStripMenuItem = value;
                userGroupsToolStripMenuItem = this._UserGroupsToolStripMenuItem;
                if (userGroupsToolStripMenuItem != null)
                {
                    userGroupsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual StatusStrip StatusStrip1
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem WindowToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem CascadeToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._CascadeToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.CascadeToolStripMenuItem_Click);
                ToolStripMenuItem cascadeToolStripMenuItem = this._CascadeToolStripMenuItem;
                if (cascadeToolStripMenuItem != null)
                {
                    cascadeToolStripMenuItem.Click -= value2;
                }
                this._CascadeToolStripMenuItem = value;
                cascadeToolStripMenuItem = this._CascadeToolStripMenuItem;
                if (cascadeToolStripMenuItem != null)
                {
                    cascadeToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem TileVerticleToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._TileVerticleToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TileVerticleToolStripMenuItem_Click);
                ToolStripMenuItem tileVerticleToolStripMenuItem = this._TileVerticleToolStripMenuItem;
                if (tileVerticleToolStripMenuItem != null)
                {
                    tileVerticleToolStripMenuItem.Click -= value2;
                }
                this._TileVerticleToolStripMenuItem = value;
                tileVerticleToolStripMenuItem = this._TileVerticleToolStripMenuItem;
                if (tileVerticleToolStripMenuItem != null)
                {
                    tileVerticleToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem TileHorizontalToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._TileHorizontalToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TileHorizontalToolStripMenuItem_Click);
                ToolStripMenuItem tileHorizontalToolStripMenuItem = this._TileHorizontalToolStripMenuItem;
                if (tileHorizontalToolStripMenuItem != null)
                {
                    tileHorizontalToolStripMenuItem.Click -= value2;
                }
                this._TileHorizontalToolStripMenuItem = value;
                tileHorizontalToolStripMenuItem = this._TileHorizontalToolStripMenuItem;
                if (tileHorizontalToolStripMenuItem != null)
                {
                    tileHorizontalToolStripMenuItem.Click += value2;
                }
            }
        }

        public virtual MenuStrip MenuStrip1
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idPanel IdPanel1
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idButton btnGroups
        {
            [CompilerGenerated]
            get
            {
                return this._btnGroups;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btnCalendar_Click);
                idButton btnGroups = this._btnGroups;
                if (btnGroups != null)
                {
                    btnGroups.Click -= value2;
                }
                this._btnGroups = value;
                btnGroups = this._btnGroups;
                if (btnGroups != null)
                {
                    btnGroups.Click += value2;
                }
            }
        }

        internal virtual idButton btnSearch
        {
            [CompilerGenerated]
            get
            {
                return this._btnSearch;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btnCompanies_Click);
                idButton btnSearch = this._btnSearch;
                if (btnSearch != null)
                {
                    btnSearch.Click -= value2;
                }
                this._btnSearch = value;
                btnSearch = this._btnSearch;
                if (btnSearch != null)
                {
                    btnSearch.Click += value2;
                }
            }
        }

        internal virtual idButton btnContacts
        {
            [CompilerGenerated]
            get
            {
                return this._btnContacts;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btnContacts_Click);
                idButton btnContacts = this._btnContacts;
                if (btnContacts != null)
                {
                    btnContacts.Click -= value2;
                }
                this._btnContacts = value;
                btnContacts = this._btnContacts;
                if (btnContacts != null)
                {
                    btnContacts.Click += value2;
                }
            }
        }

        internal virtual idButton btnTasks
        {
            [CompilerGenerated]
            get
            {
                return this._btnTasks;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btnTasks_Click);
                idButton btnTasks = this._btnTasks;
                if (btnTasks != null)
                {
                    btnTasks.Click -= value2;
                }
                this._btnTasks = value;
                btnTasks = this._btnTasks;
                if (btnTasks != null)
                {
                    btnTasks.Click += value2;
                }
            }
        }

        internal virtual idComboBox cbLookup
        {
            [CompilerGenerated]
            get
            {
                return this._cbLookup;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.cbLookup_TextChanged);
                EventHandler value3 = new EventHandler(this.cbLookup_SelectedIndexChanged);
                EventHandler value4 = new EventHandler(this.cbLookup_Leave);
                idComboBox cbLookup = this._cbLookup;
                if (cbLookup != null)
                {
                    cbLookup.TextChanged -= value2;
                    cbLookup.SelectedIndexChanged -= value3;
                    cbLookup.Leave -= value4;
                }
                this._cbLookup = value;
                cbLookup = this._cbLookup;
                if (cbLookup != null)
                {
                    cbLookup.TextChanged += value2;
                    cbLookup.SelectedIndexChanged += value3;
                    cbLookup.Leave += value4;
                }
            }
        }

        internal virtual idLabel lblLookup
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel1
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        public virtual idButton btnFind
        {
            [CompilerGenerated]
            get
            {
                return this._btnFind;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btnFind_Click);
                idButton btnFind = this._btnFind;
                if (btnFind != null)
                {
                    btnFind.Click -= value2;
                }
                this._btnFind = value;
                btnFind = this._btnFind;
                if (btnFind != null)
                {
                    btnFind.Click += value2;
                }
            }
        }

        internal virtual idCheckBox ckPartial
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idGroupBox IdGroupBox1
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        public virtual idButton btnAdvFind
        {
            [CompilerGenerated]
            get
            {
                return this._btnAdvFind;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btnAdvFind_Click);
                idButton btnAdvFind = this._btnAdvFind;
                if (btnAdvFind != null)
                {
                    btnAdvFind.Click -= value2;
                }
                this._btnAdvFind = value;
                btnAdvFind = this._btnAdvFind;
                if (btnAdvFind != null)
                {
                    btnAdvFind.Click += value2;
                }
            }
        }

        public virtual idButton btnCalendar
        {
            [CompilerGenerated]
            get
            {
                return this._btnCalendar;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btnEblast_Click);
                idButton btnCalendar = this._btnCalendar;
                if (btnCalendar != null)
                {
                    btnCalendar.Click -= value2;
                }
                this._btnCalendar = value;
                btnCalendar = this._btnCalendar;
                if (btnCalendar != null)
                {
                    btnCalendar.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem EmailContentToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._EmailContentToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.EmailContentToolStripMenuItem_Click);
                ToolStripMenuItem emailContentToolStripMenuItem = this._EmailContentToolStripMenuItem;
                if (emailContentToolStripMenuItem != null)
                {
                    emailContentToolStripMenuItem.Click -= value2;
                }
                this._EmailContentToolStripMenuItem = value;
                emailContentToolStripMenuItem = this._EmailContentToolStripMenuItem;
                if (emailContentToolStripMenuItem != null)
                {
                    emailContentToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual idCheckBox ckShowAllContacts
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual Timer Timer1
        {
            [CompilerGenerated]
            get
            {
                return this._Timer1;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Timer1_Tick);
                Timer timer = this._Timer1;
                if (timer != null)
                {
                    timer.Tick -= value2;
                }
                this._Timer1 = value;
                timer = this._Timer1;
                if (timer != null)
                {
                    timer.Tick += value2;
                }
            }
        }

        internal virtual ToolStripStatusLabel lblRecordCount
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem UserLogToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._UserLogToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.UserLogToolStripMenuItem_Click);
                ToolStripMenuItem userLogToolStripMenuItem = this._UserLogToolStripMenuItem;
                if (userLogToolStripMenuItem != null)
                {
                    userLogToolStripMenuItem.Click -= value2;
                }
                this._UserLogToolStripMenuItem = value;
                userLogToolStripMenuItem = this._UserLogToolStripMenuItem;
                if (userLogToolStripMenuItem != null)
                {
                    userLogToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem MaintenanceFormsToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem NoteTypeToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._NoteTypeToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.NoteTypeToolStripMenuItem_Click);
                ToolStripMenuItem noteTypeToolStripMenuItem = this._NoteTypeToolStripMenuItem;
                if (noteTypeToolStripMenuItem != null)
                {
                    noteTypeToolStripMenuItem.Click -= value2;
                }
                this._NoteTypeToolStripMenuItem = value;
                noteTypeToolStripMenuItem = this._NoteTypeToolStripMenuItem;
                if (noteTypeToolStripMenuItem != null)
                {
                    noteTypeToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem TaskTypeToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._TaskTypeToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TaskTypeToolStripMenuItem_Click);
                ToolStripMenuItem taskTypeToolStripMenuItem = this._TaskTypeToolStripMenuItem;
                if (taskTypeToolStripMenuItem != null)
                {
                    taskTypeToolStripMenuItem.Click -= value2;
                }
                this._TaskTypeToolStripMenuItem = value;
                taskTypeToolStripMenuItem = this._TaskTypeToolStripMenuItem;
                if (taskTypeToolStripMenuItem != null)
                {
                    taskTypeToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem LookupFieldsToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._LookupFieldsToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.LookupFieldsToolStripMenuItem_Click);
                ToolStripMenuItem lookupFieldsToolStripMenuItem = this._LookupFieldsToolStripMenuItem;
                if (lookupFieldsToolStripMenuItem != null)
                {
                    lookupFieldsToolStripMenuItem.Click -= value2;
                }
                this._LookupFieldsToolStripMenuItem = value;
                lookupFieldsToolStripMenuItem = this._LookupFieldsToolStripMenuItem;
                if (lookupFieldsToolStripMenuItem != null)
                {
                    lookupFieldsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ImportsProspectsToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._ImportsProspectsToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ImportsProspectsToolStripMenuItem_Click);
                ToolStripMenuItem importsProspectsToolStripMenuItem = this._ImportsProspectsToolStripMenuItem;
                if (importsProspectsToolStripMenuItem != null)
                {
                    importsProspectsToolStripMenuItem.Click -= value2;
                }
                this._ImportsProspectsToolStripMenuItem = value;
                importsProspectsToolStripMenuItem = this._ImportsProspectsToolStripMenuItem;
                if (importsProspectsToolStripMenuItem != null)
                {
                    importsProspectsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual Timer Timer2
        {
            [CompilerGenerated]
            get
            {
                return this._Timer2;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Timer2_Tick);
                Timer timer = this._Timer2;
                if (timer != null)
                {
                    timer.Tick -= value2;
                }
                this._Timer2 = value;
                timer = this._Timer2;
                if (timer != null)
                {
                    timer.Tick += value2;
                }
            }
        }

        internal virtual Timer Timer3
        {
            [CompilerGenerated]
            get
            {
                return this._Timer3;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Timer3_Tick);
                Timer timer = this._Timer3;
                if (timer != null)
                {
                    timer.Tick -= value2;
                }
                this._Timer3 = value;
                timer = this._Timer3;
                if (timer != null)
                {
                    timer.Tick += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ChangePasswordToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._ChangePasswordToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ChangePasswordToolStripMenuItem_Click);
                ToolStripMenuItem changePasswordToolStripMenuItem = this._ChangePasswordToolStripMenuItem;
                if (changePasswordToolStripMenuItem != null)
                {
                    changePasswordToolStripMenuItem.Click -= value2;
                }
                this._ChangePasswordToolStripMenuItem = value;
                changePasswordToolStripMenuItem = this._ChangePasswordToolStripMenuItem;
                if (changePasswordToolStripMenuItem != null)
                {
                    changePasswordToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem1
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idCheckBox ckSecondary
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idCheckBox ckLookupAll
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem DropDownsToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._DropDownsToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.DropDownsToolStripMenuItem_Click);
                ToolStripMenuItem dropDownsToolStripMenuItem = this._DropDownsToolStripMenuItem;
                if (dropDownsToolStripMenuItem != null)
                {
                    dropDownsToolStripMenuItem.Click -= value2;
                }
                this._DropDownsToolStripMenuItem = value;
                dropDownsToolStripMenuItem = this._DropDownsToolStripMenuItem;
                if (dropDownsToolStripMenuItem != null)
                {
                    dropDownsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual idComboBox cbLookupData
        {
            [CompilerGenerated]
            get
            {
                return this._cbLookupData;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.cbLookupData_TextChanged);
                idComboBox cbLookupData = this._cbLookupData;
                if (cbLookupData != null)
                {
                    cbLookupData.TextChanged -= value2;
                }
                this._cbLookupData = value;
                cbLookupData = this._cbLookupData;
                if (cbLookupData != null)
                {
                    cbLookupData.TextChanged += value2;
                }
            }
        }

        internal virtual OpenFileDialog OpenFileDialog1
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem ApplicationControlToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._ApplicationControlToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ApplicationControlToolStripMenuItem_Click);
                ToolStripMenuItem applicationControlToolStripMenuItem = this._ApplicationControlToolStripMenuItem;
                if (applicationControlToolStripMenuItem != null)
                {
                    applicationControlToolStripMenuItem.Click -= value2;
                }
                this._ApplicationControlToolStripMenuItem = value;
                applicationControlToolStripMenuItem = this._ApplicationControlToolStripMenuItem;
                if (applicationControlToolStripMenuItem != null)
                {
                    applicationControlToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual Timer ToDoPopup
        {
            [CompilerGenerated]
            get
            {
                return this._ToDoPopup;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ToDo_Tick);
                Timer toDoPopup = this._ToDoPopup;
                if (toDoPopup != null)
                {
                    toDoPopup.Tick -= value2;
                }
                this._ToDoPopup = value;
                toDoPopup = this._ToDoPopup;
                if (toDoPopup != null)
                {
                    toDoPopup.Tick += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem MyPreferencesToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._MyPreferencesToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.MyPreferencesToolStripMenuItem_Click);
                ToolStripMenuItem myPreferencesToolStripMenuItem = this._MyPreferencesToolStripMenuItem;
                if (myPreferencesToolStripMenuItem != null)
                {
                    myPreferencesToolStripMenuItem.Click -= value2;
                }
                this._MyPreferencesToolStripMenuItem = value;
                myPreferencesToolStripMenuItem = this._MyPreferencesToolStripMenuItem;
                if (myPreferencesToolStripMenuItem != null)
                {
                    myPreferencesToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual idCheckBox ckAllTasks
        {
            [CompilerGenerated]
            get
            {
                return this._ckAllTasks;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ckAllTasks_CheckedChanged);
                idCheckBox ckAllTasks = this._ckAllTasks;
                if (ckAllTasks != null)
                {
                    ckAllTasks.CheckedChanged -= value2;
                }
                this._ckAllTasks = value;
                ckAllTasks = this._ckAllTasks;
                if (ckAllTasks != null)
                {
                    ckAllTasks.CheckedChanged += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ReportsToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._ReportsToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ReportsToolStripMenuItem_Click);
                ToolStripMenuItem reportsToolStripMenuItem = this._ReportsToolStripMenuItem;
                if (reportsToolStripMenuItem != null)
                {
                    reportsToolStripMenuItem.Click -= value2;
                }
                this._ReportsToolStripMenuItem = value;
                reportsToolStripMenuItem = this._ReportsToolStripMenuItem;
                if (reportsToolStripMenuItem != null)
                {
                    reportsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem SalesTotalsToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._SalesTotalsToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.SalesTotalsToolStripMenuItem_Click);
                ToolStripMenuItem salesTotalsToolStripMenuItem = this._SalesTotalsToolStripMenuItem;
                if (salesTotalsToolStripMenuItem != null)
                {
                    salesTotalsToolStripMenuItem.Click -= value2;
                }
                this._SalesTotalsToolStripMenuItem = value;
                salesTotalsToolStripMenuItem = this._SalesTotalsToolStripMenuItem;
                if (salesTotalsToolStripMenuItem != null)
                {
                    salesTotalsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual idLabel lblTasks
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idComboBox cbTasks
        {
            [CompilerGenerated]
            get
            {
                return this._cbTasks;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.cbTasks_SelectedIndexChanged);
                idComboBox cbTasks = this._cbTasks;
                if (cbTasks != null)
                {
                    cbTasks.SelectedIndexChanged -= value2;
                }
                this._cbTasks = value;
                cbTasks = this._cbTasks;
                if (cbTasks != null)
                {
                    cbTasks.SelectedIndexChanged += value2;
                }
            }
        }

        internal virtual IRDataSetViews IRDataSetViews
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual BindingSource ManageUserComboBindingSource
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ManageUserComboTableAdapter ManageUserComboTableAdapter
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel lblCalendar
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idComboBox cbCalendar
        {
            [CompilerGenerated]
            get
            {
                return this._cbCalendar;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.cbCalendar_SelectedIndexChanged);
                idComboBox cbCalendar = this._cbCalendar;
                if (cbCalendar != null)
                {
                    cbCalendar.SelectedIndexChanged -= value2;
                }
                this._cbCalendar = value;
                cbCalendar = this._cbCalendar;
                if (cbCalendar != null)
                {
                    cbCalendar.SelectedIndexChanged += value2;
                }
            }
        }

        internal virtual idCheckBox ckHideInactive
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem BackToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._BackToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.BackToolStripMenuItem_Click);
                ToolStripMenuItem backToolStripMenuItem = this._BackToolStripMenuItem;
                if (backToolStripMenuItem != null)
                {
                    backToolStripMenuItem.Click -= value2;
                }
                this._BackToolStripMenuItem = value;
                backToolStripMenuItem = this._BackToolStripMenuItem;
                if (backToolStripMenuItem != null)
                {
                    backToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ForewardToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._ForewardToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ForewardToolStripMenuItem_Click);
                ToolStripMenuItem forewardToolStripMenuItem = this._ForewardToolStripMenuItem;
                if (forewardToolStripMenuItem != null)
                {
                    forewardToolStripMenuItem.Click -= value2;
                }
                this._ForewardToolStripMenuItem = value;
                forewardToolStripMenuItem = this._ForewardToolStripMenuItem;
                if (forewardToolStripMenuItem != null)
                {
                    forewardToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem LastLookupToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._LastLookupToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.LastLookupToolStripMenuItem_Click);
                ToolStripMenuItem lastLookupToolStripMenuItem = this._LastLookupToolStripMenuItem;
                if (lastLookupToolStripMenuItem != null)
                {
                    lastLookupToolStripMenuItem.Click -= value2;
                }
                this._LastLookupToolStripMenuItem = value;
                lastLookupToolStripMenuItem = this._LastLookupToolStripMenuItem;
                if (lastLookupToolStripMenuItem != null)
                {
                    lastLookupToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem DataLoadToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._DataLoadToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.DataLoadToolStripMenuItem_Click);
                ToolStripMenuItem dataLoadToolStripMenuItem = this._DataLoadToolStripMenuItem;
                if (dataLoadToolStripMenuItem != null)
                {
                    dataLoadToolStripMenuItem.Click -= value2;
                }
                this._DataLoadToolStripMenuItem = value;
                dataLoadToolStripMenuItem = this._DataLoadToolStripMenuItem;
                if (dataLoadToolStripMenuItem != null)
                {
                    dataLoadToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem CallReportToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._CallReportToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.CallReportToolStripMenuItem_Click);
                ToolStripMenuItem callReportToolStripMenuItem = this._CallReportToolStripMenuItem;
                if (callReportToolStripMenuItem != null)
                {
                    callReportToolStripMenuItem.Click -= value2;
                }
                this._CallReportToolStripMenuItem = value;
                callReportToolStripMenuItem = this._CallReportToolStripMenuItem;
                if (callReportToolStripMenuItem != null)
                {
                    callReportToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem RefreshCompanyToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._RefreshCompanyToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.RefreshCompanyToolStripMenuItem_Click);
                ToolStripMenuItem refreshCompanyToolStripMenuItem = this._RefreshCompanyToolStripMenuItem;
                if (refreshCompanyToolStripMenuItem != null)
                {
                    refreshCompanyToolStripMenuItem.Click -= value2;
                }
                this._RefreshCompanyToolStripMenuItem = value;
                refreshCompanyToolStripMenuItem = this._RefreshCompanyToolStripMenuItem;
                if (refreshCompanyToolStripMenuItem != null)
                {
                    refreshCompanyToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem2
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem OpenRMAToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._OpenRMAToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.OpenRMAToolStripMenuItem_Click);
                ToolStripMenuItem openRMAToolStripMenuItem = this._OpenRMAToolStripMenuItem;
                if (openRMAToolStripMenuItem != null)
                {
                    openRMAToolStripMenuItem.Click -= value2;
                }
                this._OpenRMAToolStripMenuItem = value;
                openRMAToolStripMenuItem = this._OpenRMAToolStripMenuItem;
                if (openRMAToolStripMenuItem != null)
                {
                    openRMAToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem OpenQuotesToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._OpenQuotesToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.OpenQuotesToolStripMenuItem_Click);
                ToolStripMenuItem openQuotesToolStripMenuItem = this._OpenQuotesToolStripMenuItem;
                if (openQuotesToolStripMenuItem != null)
                {
                    openQuotesToolStripMenuItem.Click -= value2;
                }
                this._OpenQuotesToolStripMenuItem = value;
                openQuotesToolStripMenuItem = this._OpenQuotesToolStripMenuItem;
                if (openQuotesToolStripMenuItem != null)
                {
                    openQuotesToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem PickupsToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._PickupsToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.PickupsToolStripMenuItem_Click);
                ToolStripMenuItem pickupsToolStripMenuItem = this._PickupsToolStripMenuItem;
                if (pickupsToolStripMenuItem != null)
                {
                    pickupsToolStripMenuItem.Click -= value2;
                }
                this._PickupsToolStripMenuItem = value;
                pickupsToolStripMenuItem = this._PickupsToolStripMenuItem;
                if (pickupsToolStripMenuItem != null)
                {
                    pickupsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem DeleteContactToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._DeleteContactToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.DeleteContactToolStripMenuItem_Click);
                ToolStripMenuItem deleteContactToolStripMenuItem = this._DeleteContactToolStripMenuItem;
                if (deleteContactToolStripMenuItem != null)
                {
                    deleteContactToolStripMenuItem.Click -= value2;
                }
                this._DeleteContactToolStripMenuItem = value;
                deleteContactToolStripMenuItem = this._DeleteContactToolStripMenuItem;
                if (deleteContactToolStripMenuItem != null)
                {
                    deleteContactToolStripMenuItem.Click += value2;
                }
            }
        }

        public virtual idGroupBox gbLegend
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel5
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel4
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel3
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel2
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel6
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel8
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual idLabel IdLabel7
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem TodaysActivitiesToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._TodaysActivitiesToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TodaysActivitiesToolStripMenuItem_Click);
                ToolStripMenuItem todaysActivitiesToolStripMenuItem = this._TodaysActivitiesToolStripMenuItem;
                if (todaysActivitiesToolStripMenuItem != null)
                {
                    todaysActivitiesToolStripMenuItem.Click -= value2;
                }
                this._TodaysActivitiesToolStripMenuItem = value;
                todaysActivitiesToolStripMenuItem = this._TodaysActivitiesToolStripMenuItem;
                if (todaysActivitiesToolStripMenuItem != null)
                {
                    todaysActivitiesToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem3
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem MapsToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem SalesRouteToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._SalesRouteToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.SalesRouteToolStripMenuItem_Click);
                ToolStripMenuItem salesRouteToolStripMenuItem = this._SalesRouteToolStripMenuItem;
                if (salesRouteToolStripMenuItem != null)
                {
                    salesRouteToolStripMenuItem.Click -= value2;
                }
                this._SalesRouteToolStripMenuItem = value;
                salesRouteToolStripMenuItem = this._SalesRouteToolStripMenuItem;
                if (salesRouteToolStripMenuItem != null)
                {
                    salesRouteToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem CurrentCompanyToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._CurrentCompanyToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.CurrentCompanyToolStripMenuItem_Click);
                ToolStripMenuItem currentCompanyToolStripMenuItem = this._CurrentCompanyToolStripMenuItem;
                if (currentCompanyToolStripMenuItem != null)
                {
                    currentCompanyToolStripMenuItem.Click -= value2;
                }
                this._CurrentCompanyToolStripMenuItem = value;
                currentCompanyToolStripMenuItem = this._CurrentCompanyToolStripMenuItem;
                if (currentCompanyToolStripMenuItem != null)
                {
                    currentCompanyToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem UpdateLocalDataToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._UpdateLocalDataToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.UpdateLocalDataToolStripMenuItem_Click);
                ToolStripMenuItem updateLocalDataToolStripMenuItem = this._UpdateLocalDataToolStripMenuItem;
                if (updateLocalDataToolStripMenuItem != null)
                {
                    updateLocalDataToolStripMenuItem.Click -= value2;
                }
                this._UpdateLocalDataToolStripMenuItem = value;
                updateLocalDataToolStripMenuItem = this._UpdateLocalDataToolStripMenuItem;
                if (updateLocalDataToolStripMenuItem != null)
                {
                    updateLocalDataToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual BindingSource EnhancedManageUserComboBindingSource
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual EnhancedManageUserComboTableAdapter EnhancedManageUserComboTableAdapter
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem JustForJeffToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        public virtual idButton btnMap
        {
            [CompilerGenerated]
            get
            {
                return this._btnMap;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.IdButton1_Click);
                idButton btnMap = this._btnMap;
                if (btnMap != null)
                {
                    btnMap.Click -= value2;
                }
                this._btnMap = value;
                btnMap = this._btnMap;
                if (btnMap != null)
                {
                    btnMap.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem CustomerIssuesToolStripMenuItem
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem_Click);
                ToolStripMenuItem notifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem = this._NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem;
                if (notifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem != null)
                {
                    notifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Click -= value2;
                }
                this._NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem = value;
                notifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem = this._NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem;
                if (notifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem != null)
                {
                    notifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem NotifyMikeOfCustomerIssueToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._NotifyMikeOfCustomerIssueToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.NotifyMikeOfCustomerIssueToolStripMenuItem_Click);
                ToolStripMenuItem notifyMikeOfCustomerIssueToolStripMenuItem = this._NotifyMikeOfCustomerIssueToolStripMenuItem;
                if (notifyMikeOfCustomerIssueToolStripMenuItem != null)
                {
                    notifyMikeOfCustomerIssueToolStripMenuItem.Click -= value2;
                }
                this._NotifyMikeOfCustomerIssueToolStripMenuItem = value;
                notifyMikeOfCustomerIssueToolStripMenuItem = this._NotifyMikeOfCustomerIssueToolStripMenuItem;
                if (notifyMikeOfCustomerIssueToolStripMenuItem != null)
                {
                    notifyMikeOfCustomerIssueToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem FranciesListToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._FranciesListToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.FranciesListToolStripMenuItem_Click);
                ToolStripMenuItem franciesListToolStripMenuItem = this._FranciesListToolStripMenuItem;
                if (franciesListToolStripMenuItem != null)
                {
                    franciesListToolStripMenuItem.Click -= value2;
                }
                this._FranciesListToolStripMenuItem = value;
                franciesListToolStripMenuItem = this._FranciesListToolStripMenuItem;
                if (franciesListToolStripMenuItem != null)
                {
                    franciesListToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem MikesListToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._MikesListToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.MikesListToolStripMenuItem_Click);
                ToolStripMenuItem mikesListToolStripMenuItem = this._MikesListToolStripMenuItem;
                if (mikesListToolStripMenuItem != null)
                {
                    mikesListToolStripMenuItem.Click -= value2;
                }
                this._MikesListToolStripMenuItem = value;
                mikesListToolStripMenuItem = this._MikesListToolStripMenuItem;
                if (mikesListToolStripMenuItem != null)
                {
                    mikesListToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ProductivityReportToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._ProductivityReportToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.ProductivityReportToolStripMenuItem_Click);
                ToolStripMenuItem productivityReportToolStripMenuItem = this._ProductivityReportToolStripMenuItem;
                if (productivityReportToolStripMenuItem != null)
                {
                    productivityReportToolStripMenuItem.Click -= value2;
                }
                this._ProductivityReportToolStripMenuItem = value;
                productivityReportToolStripMenuItem = this._ProductivityReportToolStripMenuItem;
                if (productivityReportToolStripMenuItem != null)
                {
                    productivityReportToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem4
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem HorseRaceToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._HorseRaceToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.HorseRaceToolStripMenuItem_Click);
                ToolStripMenuItem horseRaceToolStripMenuItem = this._HorseRaceToolStripMenuItem;
                if (horseRaceToolStripMenuItem != null)
                {
                    horseRaceToolStripMenuItem.Click -= value2;
                }
                this._HorseRaceToolStripMenuItem = value;
                horseRaceToolStripMenuItem = this._HorseRaceToolStripMenuItem;
                if (horseRaceToolStripMenuItem != null)
                {
                    horseRaceToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem mnuNoOnAreas
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripSeparator ToolStripMenuItem5
        {
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }

        internal virtual ToolStripMenuItem TelemarketerNewCustomerToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._TelemarketerNewCustomerToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TelemarketerNewCustomerToolStripMenuItem_Click);
                ToolStripMenuItem telemarketerNewCustomerToolStripMenuItem = this._TelemarketerNewCustomerToolStripMenuItem;
                if (telemarketerNewCustomerToolStripMenuItem != null)
                {
                    telemarketerNewCustomerToolStripMenuItem.Click -= value2;
                }
                this._TelemarketerNewCustomerToolStripMenuItem = value;
                telemarketerNewCustomerToolStripMenuItem = this._TelemarketerNewCustomerToolStripMenuItem;
                if (telemarketerNewCustomerToolStripMenuItem != null)
                {
                    telemarketerNewCustomerToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem TelemarketerActivityToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._TelemarketerActivityToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TelemarketerActivityToolStripMenuItem_Click);
                ToolStripMenuItem telemarketerActivityToolStripMenuItem = this._TelemarketerActivityToolStripMenuItem;
                if (telemarketerActivityToolStripMenuItem != null)
                {
                    telemarketerActivityToolStripMenuItem.Click -= value2;
                }
                this._TelemarketerActivityToolStripMenuItem = value;
                telemarketerActivityToolStripMenuItem = this._TelemarketerActivityToolStripMenuItem;
                if (telemarketerActivityToolStripMenuItem != null)
                {
                    telemarketerActivityToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem SpecialStuffToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._SpecialStuffToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.SpecialStuffToolStripMenuItem_Click);
                ToolStripMenuItem specialStuffToolStripMenuItem = this._SpecialStuffToolStripMenuItem;
                if (specialStuffToolStripMenuItem != null)
                {
                    specialStuffToolStripMenuItem.Click -= value2;
                }
                this._SpecialStuffToolStripMenuItem = value;
                specialStuffToolStripMenuItem = this._SpecialStuffToolStripMenuItem;
                if (specialStuffToolStripMenuItem != null)
                {
                    specialStuffToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem SetVersionNumberToolStripMenuItem
        {
            [CompilerGenerated]
            get
            {
                return this._SetVersionNumberToolStripMenuItem;
            }
            [CompilerGenerated]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.SetVersionNumberToolStripMenuItem_Click);
                ToolStripMenuItem setVersionNumberToolStripMenuItem = this._SetVersionNumberToolStripMenuItem;
                if (setVersionNumberToolStripMenuItem != null)
                {
                    setVersionNumberToolStripMenuItem.Click -= value2;
                }
                this._SetVersionNumberToolStripMenuItem = value;
                setVersionNumberToolStripMenuItem = this._SetVersionNumberToolStripMenuItem;
                if (setVersionNumberToolStripMenuItem != null)
                {
                    setVersionNumberToolStripMenuItem.Click += value2;
                }
            }
        }

        #endregion 

        //public frmMain()
        //{
        //    base.Load += new EventHandler(this.frmMain_Load);
        //    base.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);

        //    // Grant 12/1/2021:
        //    ///////////////////base.MdiChildActivate += FrmMain_MdiChildActivate;
        //    ///
        //    base.ResizeEnd += FrmMain_ResizeEnd;
        //    this.HoldCount = 0;
        //    this.tmpRecManager = "";
            
        //    this.InitializeComponent();


        //    try
        //    {
        //        string applicationPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        //        // Load SQL Server Types for SQL Server Spatial:
        //        LoadNativeAssemblies(applicationPath);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show($"LoadNativeAssembliesv13() Error:  {ex.Message}", "Load Native Assemblies Error!");
        //    }


        //}

        //private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        //{
        //    // throw new NotImplementedException();
        //    //if (this.ActiveMdiChild != null)
        //    //{
        //    //    if (this.ActiveMdiChild.FormBorderStyle == FormBorderStyle.None && this.ActiveMdiChild.WindowState != FormWindowState.Maximized)
        //    //        this.ActiveMdiChild.BringToFrontHelper();
        //    //}
        //}

        //private void FrmMain_ResizeEnd(object sender, EventArgs e)
        //{
        //    if (this.ActiveMdiChild != null)
        //    {

        //        // Grant - 6/19/2022:
        //        clsContacts.RefreshData(false);


        //        // Grant Changes - 12/1/2021:
        //        //if(this.ActiveMdiChild.FormBorderStyle == FormBorderStyle.None)

        //        this.ActiveMdiChild.BringToFrontHelper();
        //    }


        //    // throw new NotImplementedException();

        //    /*
        //    Form[] mdiChildren = base.MdiChildren;
        //    for (int i = 0; i < mdiChildren.Length; i++)
        //    {
        //        Form form = mdiChildren[i];
        //        if (form.Visible )
        //            form.BringToFrontHelper();
        //      //  if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //      //  {
        //            //new frmContactLaptop();
        //            //frmContactLaptop expr_77F = (frmContactLaptop)form;
        //            //expr_77F.ContactID = num3;
        //            //clsContacts.RefreshData(false);
        //            //expr_77F.BringToFrontHelper();
        //      //  }
        //    }
        //    */
        //}

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }



        private System.Windows.Forms.PictureBox pictureBoxLogo;

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
          //  this.components = new Container();
            
            
            
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));


            //////////System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm1));

            //this.pictureBoxLogo = new System.Windows.Forms.PictureBox();


            //((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();

            // 
            // pictureBoxLogo
            // 
            //this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));


            // GA 3/16/2022:  Switch logo image if Azure or LocalDB.

            string connectionString = ConfigurationManager.ConnectionStrings["IRConnectionString"].ConnectionString;

            if (connectionString.Contains("irsdbserver.database.windows.net"))
            {
                this.pictureBoxLogo.Image = Image.FromFile("Microsoft-Azure-Logo-Medium.png");
            }
            else
            {
                this.pictureBoxLogo.Image = Image.FromFile("LocalDBSQLServer2.png");
            }

                

            // Last control is this:  this.ckAllTasks.Location = new Point(18, 571);
            //this.pictureBoxLogo.Location = new System.Drawing.Point(5, 640);


            // Put it at the bottom:
            // For Reference:  this.ckAllTasks.Location = new Point(18, 571);
            /////////////////this.pictureBoxLogo.Location = new System.Drawing.Point(5, 640);


            // Put it at the top!
            // For Reference:  this.lblLookup.Location = new Point(12, 19);
            //this.IdPanel1.Dock = DockStyle.Left;
            //this.IdPanel1.Location = new Point(0, 24);
            //this.IdPanel1.Name = "IdPanel1";
            //this.IdPanel1.Size = new Size(200, 865);
            //this.IdPanel1.TabIndex = 0;


            //his.pictureBoxLogo.Dock = DockStyle.Left;
            // Bottom:
            //this.pictureBoxLogo.Location = new System.Drawing.Point(5, 640);
            // Top:
            //this.pictureBoxLogo.Location = new Point(0, 20);


            //this.pictureBoxLogo.Name = "Azure Logo";
            ////this.pictureBoxLogo.Size = new System.Drawing.Size(190, 40);
            //this.pictureBoxLogo.Size = new System.Drawing.Size(197, 40);

            //this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.pictureBoxLogo.TabIndex = 0;
            //this.pictureBoxLogo.TabStop = false;

            //((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();

   



            //this.MenuStrip1 = new MenuStrip();
            //this.FileToolStripMenuItem = new ToolStripMenuItem();
            //this.MyPreferencesToolStripMenuItem = new ToolStripMenuItem();
            //this.PrintCurrentFormToolStripMenuItem = new ToolStripMenuItem();
            //this.ChangePasswordToolStripMenuItem = new ToolStripMenuItem();
            //this.ToolStripMenuItem1 = new ToolStripSeparator();
            //this.ExitToolStripMenuItem = new ToolStripMenuItem();
            //this.JustForJeffToolStripMenuItem = new ToolStripMenuItem();
            //this.SpecialStuffToolStripMenuItem = new ToolStripMenuItem();
            //this.SetVersionNumberToolStripMenuItem = new ToolStripMenuItem();
            //this.ToolsToolStripMenuItem = new ToolStripMenuItem();
            //this.EmailContentToolStripMenuItem = new ToolStripMenuItem();
            //this.UsersToolStripMenuItem = new ToolStripMenuItem();
            //this.UsersToolStripMenuItem1 = new ToolStripMenuItem();
            //this.UserGroupsToolStripMenuItem = new ToolStripMenuItem();
            //this.UserLogToolStripMenuItem = new ToolStripMenuItem();
            //this.MaintenanceFormsToolStripMenuItem = new ToolStripMenuItem();
            //this.NoteTypeToolStripMenuItem = new ToolStripMenuItem();
            //this.TaskTypeToolStripMenuItem = new ToolStripMenuItem();
            //this.LookupFieldsToolStripMenuItem = new ToolStripMenuItem();
            //this.ImportsProspectsToolStripMenuItem = new ToolStripMenuItem();
            //this.DropDownsToolStripMenuItem = new ToolStripMenuItem();
            //this.ApplicationControlToolStripMenuItem = new ToolStripMenuItem();
            //this.DataLoadToolStripMenuItem = new ToolStripMenuItem();
            //this.UpdateLocalDataToolStripMenuItem = new ToolStripMenuItem();
            //this.mnuNoOnAreas = new ToolStripMenuItem();
            //this.ReportsToolStripMenuItem = new ToolStripMenuItem();
            //this.SalesTotalsToolStripMenuItem = new ToolStripMenuItem();
            //this.CallReportToolStripMenuItem = new ToolStripMenuItem();
            //this.TodaysActivitiesToolStripMenuItem = new ToolStripMenuItem();
            //this.ToolStripMenuItem2 = new ToolStripSeparator();
            //this.OpenRMAToolStripMenuItem = new ToolStripMenuItem();
            //this.OpenQuotesToolStripMenuItem = new ToolStripMenuItem();
            //this.PickupsToolStripMenuItem = new ToolStripMenuItem();
            //this.ProductivityReportToolStripMenuItem = new ToolStripMenuItem();
            //this.ToolStripMenuItem5 = new ToolStripSeparator();
            //this.TelemarketerNewCustomerToolStripMenuItem = new ToolStripMenuItem();
            //this.TelemarketerActivityToolStripMenuItem = new ToolStripMenuItem();
            //this.ToolStripMenuItem3 = new ToolStripSeparator();
            //this.MapsToolStripMenuItem = new ToolStripMenuItem();
            //this.SalesRouteToolStripMenuItem = new ToolStripMenuItem();
            //this.CurrentCompanyToolStripMenuItem = new ToolStripMenuItem();
            //this.ToolStripMenuItem4 = new ToolStripSeparator();
            //this.HorseRaceToolStripMenuItem = new ToolStripMenuItem();
            //this.WindowToolStripMenuItem = new ToolStripMenuItem();
            //this.CascadeToolStripMenuItem = new ToolStripMenuItem();
            //this.TileVerticleToolStripMenuItem = new ToolStripMenuItem();
            //this.TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            //this.BackToolStripMenuItem = new ToolStripMenuItem();
            //this.ForewardToolStripMenuItem = new ToolStripMenuItem();
            //this.LastLookupToolStripMenuItem = new ToolStripMenuItem();
            //this.RefreshCompanyToolStripMenuItem = new ToolStripMenuItem();
            //this.DeleteContactToolStripMenuItem = new ToolStripMenuItem();
            //this.CustomerIssuesToolStripMenuItem = new ToolStripMenuItem();
            //this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem = new ToolStripMenuItem();
            //this.NotifyMikeOfCustomerIssueToolStripMenuItem = new ToolStripMenuItem();
            //this.FranciesListToolStripMenuItem = new ToolStripMenuItem();
            //this.MikesListToolStripMenuItem = new ToolStripMenuItem();
            //this.StatusStrip1 = new StatusStrip();
            //this.lblRecordCount = new ToolStripStatusLabel();
            //this.Timer1 = new Timer(this.components);
            //this.Timer2 = new Timer(this.components);
            //this.Timer3 = new Timer(this.components);
            //this.OpenFileDialog1 = new OpenFileDialog();
            //this.ToDoPopup = new Timer(this.components);
            //this.IdPanel1 = new idPanel();
            //this.btnMap = new idButton();
            //this.gbLegend = new idGroupBox();
            //this.IdLabel8 = new idLabel();
            //this.IdLabel7 = new idLabel();
            //this.IdLabel5 = new idLabel();
            //this.IdLabel4 = new idLabel();
            //this.IdLabel3 = new idLabel();
            //this.IdLabel2 = new idLabel();
            //this.IdLabel6 = new idLabel();
            //this.lblCalendar = new idLabel();
            //this.cbCalendar = new idComboBox();
            //this.EnhancedManageUserComboBindingSource = new BindingSource(this.components);
            this.IRDataSetViews = new IRDataSetViews();
            //this.lblTasks = new idLabel();
            //this.cbTasks = new idComboBox();
            //this.ManageUserComboBindingSource = new BindingSource(this.components);
            //this.ckAllTasks = new idCheckBox();
            //this.btnCalendar = new idButton();
            //this.btnTasks = new idButton();
            //this.btnGroups = new idButton();
            //this.btnSearch = new idButton();
            //this.btnContacts = new idButton();
            //this.IdGroupBox1 = new idGroupBox();
            //this.ckHideInactive = new idCheckBox();
            //this.cbLookupData = new idComboBox();
            //this.ckLookupAll = new idCheckBox();
            //this.ckSecondary = new idCheckBox();
            //this.ckShowAllContacts = new idCheckBox();
            //this.btnAdvFind = new idButton();
            //this.btnFind = new idButton();
            //this.cbLookup = new idComboBox();
            //this.IdLabel1 = new idLabel();
            //this.lblLookup = new idLabel();
            //this.ckPartial = new idCheckBox();
            this.ManageUserComboTableAdapter = new ManageUserComboTableAdapter();
            this.EnhancedManageUserComboTableAdapter = new EnhancedManageUserComboTableAdapter();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.IdPanel1.SuspendLayout();
            this.gbLegend.SuspendLayout();
            ((ISupportInitialize)this.EnhancedManageUserComboBindingSource).BeginInit();
            ((ISupportInitialize)this.IRDataSetViews).BeginInit();
            ((ISupportInitialize)this.ManageUserComboBindingSource).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            base.SuspendLayout();
            //this.MenuStrip1.BackColor = Color.Tan;
            //this.MenuStrip1.Font = new Font("Arial", 9.75f);
            //this.MenuStrip1.Items.AddRange(new ToolStripItem[]
            //{
            //    this.FileToolStripMenuItem,
            //    this.ToolsToolStripMenuItem,
            //    this.ReportsToolStripMenuItem,
            //    this.WindowToolStripMenuItem,
            //    this.BackToolStripMenuItem,
            //    this.ForewardToolStripMenuItem,
            //    this.LastLookupToolStripMenuItem,
            //    this.RefreshCompanyToolStripMenuItem,
            //    this.DeleteContactToolStripMenuItem,
            //    this.CustomerIssuesToolStripMenuItem
            //});
            //this.MenuStrip1.Location = new Point(0, 0);
            //this.MenuStrip1.MdiWindowListItem = this.WindowToolStripMenuItem;
            //this.MenuStrip1.Name = "MenuStrip1";
            //this.MenuStrip1.Size = new Size(1112, 24);
            //this.MenuStrip1.TabIndex = 2;
            //this.MenuStrip1.Text = "MenuStrip1";
            //this.FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.MyPreferencesToolStripMenuItem,
            //    this.PrintCurrentFormToolStripMenuItem,
            //    this.ChangePasswordToolStripMenuItem,
            //    this.ToolStripMenuItem1,
            //    this.ExitToolStripMenuItem,
            //    this.JustForJeffToolStripMenuItem
            //});
            //this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            //this.FileToolStripMenuItem.Size = new Size(41, 20);
            //this.FileToolStripMenuItem.Text = "File";
            //this.MyPreferencesToolStripMenuItem.Name = "MyPreferencesToolStripMenuItem";
            //this.MyPreferencesToolStripMenuItem.Size = new Size(183, 22);
            //this.MyPreferencesToolStripMenuItem.Text = "My Preferences";
            //this.PrintCurrentFormToolStripMenuItem.Name = "PrintCurrentFormToolStripMenuItem";
            //this.PrintCurrentFormToolStripMenuItem.Size = new Size(183, 22);
            //this.PrintCurrentFormToolStripMenuItem.Text = "Print Current Form";
            //this.PrintCurrentFormToolStripMenuItem.Visible = false;
            //this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            //this.ChangePasswordToolStripMenuItem.Size = new Size(183, 22);
            //this.ChangePasswordToolStripMenuItem.Text = "Change Password";
            //this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            //this.ToolStripMenuItem1.Size = new Size(180, 6);
            //this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            //this.ExitToolStripMenuItem.Size = new Size(183, 22);
            //this.ExitToolStripMenuItem.Text = "Exit";
            //this.JustForJeffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.SpecialStuffToolStripMenuItem,
            //    this.SetVersionNumberToolStripMenuItem
            //});
            //this.JustForJeffToolStripMenuItem.Name = "JustForJeffToolStripMenuItem";
            //this.JustForJeffToolStripMenuItem.Size = new Size(183, 22);
            //this.JustForJeffToolStripMenuItem.Text = "Just for Jeff";
            //this.SpecialStuffToolStripMenuItem.Name = "SpecialStuffToolStripMenuItem";
            //this.SpecialStuffToolStripMenuItem.Size = new Size(192, 22);
            //this.SpecialStuffToolStripMenuItem.Text = "Special Stuff";
            //this.SetVersionNumberToolStripMenuItem.Name = "SetVersionNumberToolStripMenuItem";
            //this.SetVersionNumberToolStripMenuItem.Size = new Size(192, 22);
            //this.SetVersionNumberToolStripMenuItem.Text = "Set Version Number";
            //this.ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.EmailContentToolStripMenuItem,
            //    this.UsersToolStripMenuItem,
            //    this.MaintenanceFormsToolStripMenuItem,
            //    this.UpdateLocalDataToolStripMenuItem,
            //    this.mnuNoOnAreas
            //});
            //this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            //this.ToolsToolStripMenuItem.Size = new Size(50, 20);
            //this.ToolsToolStripMenuItem.Text = "Tools";
            //this.EmailContentToolStripMenuItem.Name = "EmailContentToolStripMenuItem";
            //this.EmailContentToolStripMenuItem.Size = new Size(191, 22);
            //this.EmailContentToolStripMenuItem.Text = "Email Templates";
            //this.UsersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.UsersToolStripMenuItem1,
            //    this.UserGroupsToolStripMenuItem,
            //    this.UserLogToolStripMenuItem
            //});
            //this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            //this.UsersToolStripMenuItem.Size = new Size(191, 22);
            //this.UsersToolStripMenuItem.Text = "Users";
            //this.UsersToolStripMenuItem1.Name = "UsersToolStripMenuItem1";
            //this.UsersToolStripMenuItem1.Size = new Size(149, 22);
            //this.UsersToolStripMenuItem1.Text = "Users";
            //this.UserGroupsToolStripMenuItem.Name = "UserGroupsToolStripMenuItem";
            //this.UserGroupsToolStripMenuItem.Size = new Size(149, 22);
            //this.UserGroupsToolStripMenuItem.Text = "User Groups";
            //this.UserLogToolStripMenuItem.Name = "UserLogToolStripMenuItem";
            //this.UserLogToolStripMenuItem.Size = new Size(149, 22);
            //this.UserLogToolStripMenuItem.Text = "User Log";
            //this.MaintenanceFormsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.NoteTypeToolStripMenuItem,
            //    this.TaskTypeToolStripMenuItem,
            //    this.LookupFieldsToolStripMenuItem,
            //    this.ImportsProspectsToolStripMenuItem,
            //    this.DropDownsToolStripMenuItem,
            //    this.ApplicationControlToolStripMenuItem,
            //    this.DataLoadToolStripMenuItem
            //});
            //this.MaintenanceFormsToolStripMenuItem.Name = "MaintenanceFormsToolStripMenuItem";
            //this.MaintenanceFormsToolStripMenuItem.Size = new Size(191, 22);
            //this.MaintenanceFormsToolStripMenuItem.Text = "Maintenance Forms";
            //this.NoteTypeToolStripMenuItem.Name = "NoteTypeToolStripMenuItem";
            //this.NoteTypeToolStripMenuItem.Size = new Size(185, 22);
            //this.NoteTypeToolStripMenuItem.Text = "Note Type";
            //this.NoteTypeToolStripMenuItem.Visible = false;
            //this.TaskTypeToolStripMenuItem.Name = "TaskTypeToolStripMenuItem";
            //this.TaskTypeToolStripMenuItem.Size = new Size(185, 22);
            //this.TaskTypeToolStripMenuItem.Text = "Task Type";
            //this.TaskTypeToolStripMenuItem.Visible = false;
            //this.LookupFieldsToolStripMenuItem.Name = "LookupFieldsToolStripMenuItem";
            //this.LookupFieldsToolStripMenuItem.Size = new Size(185, 22);
            //this.LookupFieldsToolStripMenuItem.Text = "Lookup Fields";
            //this.LookupFieldsToolStripMenuItem.Visible = false;
            //this.ImportsProspectsToolStripMenuItem.Name = "ImportsProspectsToolStripMenuItem";
            //this.ImportsProspectsToolStripMenuItem.Size = new Size(185, 22);
            //this.ImportsProspectsToolStripMenuItem.Text = "Import Prospects";
            //this.DropDownsToolStripMenuItem.Name = "DropDownsToolStripMenuItem";
            //this.DropDownsToolStripMenuItem.Size = new Size(185, 22);
            //this.DropDownsToolStripMenuItem.Text = "Drop Downs";
            //this.ApplicationControlToolStripMenuItem.Name = "ApplicationControlToolStripMenuItem";
            //this.ApplicationControlToolStripMenuItem.Size = new Size(185, 22);
            //this.ApplicationControlToolStripMenuItem.Text = "Application Control";
            //this.DataLoadToolStripMenuItem.Name = "DataLoadToolStripMenuItem";
            //this.DataLoadToolStripMenuItem.Size = new Size(185, 22);
            //this.DataLoadToolStripMenuItem.Text = "Data Load";
            //this.DataLoadToolStripMenuItem.Visible = false;
            //this.UpdateLocalDataToolStripMenuItem.Name = "UpdateLocalDataToolStripMenuItem";
            //this.UpdateLocalDataToolStripMenuItem.Size = new Size(191, 22);
            //this.UpdateLocalDataToolStripMenuItem.Text = "Update Local Data";
            //this.mnuNoOnAreas.CheckOnClick = true;
            //this.mnuNoOnAreas.Name = "mnuNoOnAreas";
            //this.mnuNoOnAreas.Size = new Size(191, 22);
            //this.mnuNoOnAreas.Text = "No % on Areas";
            //this.ReportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.SalesTotalsToolStripMenuItem,
            //    this.CallReportToolStripMenuItem,
            //    this.TodaysActivitiesToolStripMenuItem,
            //    this.ToolStripMenuItem2,
            //    this.OpenRMAToolStripMenuItem,
            //    this.OpenQuotesToolStripMenuItem,
            //    this.PickupsToolStripMenuItem,
            //    this.ProductivityReportToolStripMenuItem,
            //    this.ToolStripMenuItem5,
            //    this.TelemarketerNewCustomerToolStripMenuItem,
            //    this.TelemarketerActivityToolStripMenuItem,
            //    this.ToolStripMenuItem3,
            //    this.MapsToolStripMenuItem,
            //    this.ToolStripMenuItem4,
            //    this.HorseRaceToolStripMenuItem
            //});
            //this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            //this.ReportsToolStripMenuItem.Size = new Size(65, 20);
            //this.ReportsToolStripMenuItem.Text = "Reports";
            //this.SalesTotalsToolStripMenuItem.Name = "SalesTotalsToolStripMenuItem";
            //this.SalesTotalsToolStripMenuItem.Size = new Size(239, 22);
            //this.SalesTotalsToolStripMenuItem.Text = "Sales Totals";
            //this.CallReportToolStripMenuItem.Name = "CallReportToolStripMenuItem";
            //this.CallReportToolStripMenuItem.Size = new Size(239, 22);
            //this.CallReportToolStripMenuItem.Text = "Call Report";
            //this.TodaysActivitiesToolStripMenuItem.Name = "TodaysActivitiesToolStripMenuItem";
            //this.TodaysActivitiesToolStripMenuItem.Size = new Size(239, 22);
            //this.TodaysActivitiesToolStripMenuItem.Text = "Todays Activities";
            //this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            //this.ToolStripMenuItem2.Size = new Size(236, 6);
            //this.OpenRMAToolStripMenuItem.Name = "OpenRMAToolStripMenuItem";
            //this.OpenRMAToolStripMenuItem.Size = new Size(239, 22);
            //this.OpenRMAToolStripMenuItem.Text = "Open RMA";
            //this.OpenQuotesToolStripMenuItem.Name = "OpenQuotesToolStripMenuItem";
            //this.OpenQuotesToolStripMenuItem.Size = new Size(239, 22);
            //this.OpenQuotesToolStripMenuItem.Text = "Open Quotes";
            //this.PickupsToolStripMenuItem.Name = "PickupsToolStripMenuItem";
            //this.PickupsToolStripMenuItem.Size = new Size(239, 22);
            //this.PickupsToolStripMenuItem.Text = "Pickups";
            //this.ProductivityReportToolStripMenuItem.Name = "ProductivityReportToolStripMenuItem";
            //this.ProductivityReportToolStripMenuItem.Size = new Size(239, 22);
            //this.ProductivityReportToolStripMenuItem.Text = "Productivity Report";
            //this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            //this.ToolStripMenuItem5.Size = new Size(236, 6);
            //this.TelemarketerNewCustomerToolStripMenuItem.Name = "TelemarketerNewCustomerToolStripMenuItem";
            //this.TelemarketerNewCustomerToolStripMenuItem.Size = new Size(239, 22);
            //this.TelemarketerNewCustomerToolStripMenuItem.Text = "Telemarketer New Customer";
            //this.TelemarketerActivityToolStripMenuItem.Name = "TelemarketerActivityToolStripMenuItem";
            //this.TelemarketerActivityToolStripMenuItem.Size = new Size(239, 22);
            //this.TelemarketerActivityToolStripMenuItem.Text = "Telemarketer Activity";
            //this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            //this.ToolStripMenuItem3.Size = new Size(236, 6);
            //this.MapsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.SalesRouteToolStripMenuItem,
            //    this.CurrentCompanyToolStripMenuItem
            //});
            //this.MapsToolStripMenuItem.Name = "MapsToolStripMenuItem";
            //this.MapsToolStripMenuItem.Size = new Size(239, 22);
            //this.MapsToolStripMenuItem.Text = "Maps";
            //this.SalesRouteToolStripMenuItem.Name = "SalesRouteToolStripMenuItem";
            //this.SalesRouteToolStripMenuItem.Size = new Size(177, 22);
            //this.SalesRouteToolStripMenuItem.Text = "Sales Route";
            //this.CurrentCompanyToolStripMenuItem.Name = "CurrentCompanyToolStripMenuItem";
            //this.CurrentCompanyToolStripMenuItem.Size = new Size(177, 22);
            //this.CurrentCompanyToolStripMenuItem.Text = "Current Company";
            //this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            //this.ToolStripMenuItem4.Size = new Size(236, 6);
            //this.HorseRaceToolStripMenuItem.Name = "HorseRaceToolStripMenuItem";
            //this.HorseRaceToolStripMenuItem.Size = new Size(239, 22);
            //this.HorseRaceToolStripMenuItem.Text = "Horse Race";
            //this.WindowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.CascadeToolStripMenuItem,
            //    this.TileVerticleToolStripMenuItem,
            //    this.TileHorizontalToolStripMenuItem
            //});
            //this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            //this.WindowToolStripMenuItem.Size = new Size(66, 20);
            //this.WindowToolStripMenuItem.Text = "Window";
            //this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            //this.CascadeToolStripMenuItem.Size = new Size(158, 22);
            //this.CascadeToolStripMenuItem.Text = "Cascade";
            //this.TileVerticleToolStripMenuItem.Name = "TileVerticleToolStripMenuItem";
            //this.TileVerticleToolStripMenuItem.Size = new Size(158, 22);
            //this.TileVerticleToolStripMenuItem.Text = "Tile Verticle";
            //this.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem";
            //this.TileHorizontalToolStripMenuItem.Size = new Size(158, 22);
            //this.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            //this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            //this.BackToolStripMenuItem.Size = new Size(50, 20);
            //this.BackToolStripMenuItem.Text = "Back";
            //this.ForewardToolStripMenuItem.Name = "ForewardToolStripMenuItem";
            //this.ForewardToolStripMenuItem.Size = new Size(66, 20);
            //this.ForewardToolStripMenuItem.Text = "Forward";
            //this.LastLookupToolStripMenuItem.Name = "LastLookupToolStripMenuItem";
            //this.LastLookupToolStripMenuItem.Size = new Size(91, 20);
            //this.LastLookupToolStripMenuItem.Text = "Last Lookup";
            //this.RefreshCompanyToolStripMenuItem.Name = "RefreshCompanyToolStripMenuItem";
            //this.RefreshCompanyToolStripMenuItem.Size = new Size(123, 20);
            //this.RefreshCompanyToolStripMenuItem.Text = "Refresh Company";
            //this.DeleteContactToolStripMenuItem.Name = "DeleteContactToolStripMenuItem";
            //this.DeleteContactToolStripMenuItem.Size = new Size(106, 20);
            //this.DeleteContactToolStripMenuItem.Text = "Delete Contact";
            //this.CustomerIssuesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            //{
            //    this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem,
            //    this.NotifyMikeOfCustomerIssueToolStripMenuItem,
            //    this.FranciesListToolStripMenuItem,
            //    this.MikesListToolStripMenuItem
            //});
            //this.CustomerIssuesToolStripMenuItem.Name = "CustomerIssuesToolStripMenuItem";
            //this.CustomerIssuesToolStripMenuItem.Size = new Size(118, 20);
            //this.CustomerIssuesToolStripMenuItem.Text = "Customer Issues";
            //this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Name = "NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem";
            //this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Size = new Size(250, 22);
            //this.NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem.Text = "Send this prospect to Francie";
            //this.NotifyMikeOfCustomerIssueToolStripMenuItem.Name = "NotifyMikeOfCustomerIssueToolStripMenuItem";
            //this.NotifyMikeOfCustomerIssueToolStripMenuItem.Size = new Size(250, 22);
            //this.NotifyMikeOfCustomerIssueToolStripMenuItem.Text = "Notify Mike of Customer Issue";
            //this.FranciesListToolStripMenuItem.Name = "FranciesListToolStripMenuItem";
            //this.FranciesListToolStripMenuItem.Size = new Size(250, 22);
            //this.FranciesListToolStripMenuItem.Text = "Francie's List";
            //this.MikesListToolStripMenuItem.Name = "MikesListToolStripMenuItem";
            //this.MikesListToolStripMenuItem.Size = new Size(250, 22);
            //this.MikesListToolStripMenuItem.Text = "Mike's List";
            //this.StatusStrip1.BackColor = Color.Tan;
            //this.StatusStrip1.Items.AddRange(new ToolStripItem[]
            //{
            //    this.lblRecordCount
            //});
            //this.StatusStrip1.Location = new Point(0, 889);
            //this.StatusStrip1.Name = "StatusStrip1";
            //this.StatusStrip1.Size = new Size(1112, 22);
            //this.StatusStrip1.TabIndex = 1;
            //this.StatusStrip1.Text = "StatusStrip1";
            //this.lblRecordCount.Name = "lblRecordCount";
            //this.lblRecordCount.Size = new Size(0, 17);
            //this.Timer1.Interval = 300000;
            //this.Timer2.Interval = 1000;
            //this.Timer3.Interval = 30000;
            //this.ToDoPopup.Interval = 60000;



            //this.IdPanel1.Controls.Add(this.btnMap);
            //this.IdPanel1.Controls.Add(this.gbLegend);
            //this.IdPanel1.Controls.Add(this.lblCalendar);
            //this.IdPanel1.Controls.Add(this.cbCalendar);
            //this.IdPanel1.Controls.Add(this.lblTasks);
            //this.IdPanel1.Controls.Add(this.cbTasks);
            //this.IdPanel1.Controls.Add(this.ckAllTasks);
            //this.IdPanel1.Controls.Add(this.btnCalendar);
            //this.IdPanel1.Controls.Add(this.btnTasks);
            //this.IdPanel1.Controls.Add(this.btnGroups);
            //this.IdPanel1.Controls.Add(this.btnSearch);
            //this.IdPanel1.Controls.Add(this.btnContacts);
            //this.IdPanel1.Controls.Add(this.IdGroupBox1);

            //this.IdPanel1.Controls.Add(this.pictureBoxLogo);


            //this.IdPanel1.Dock = DockStyle.Left;
            //this.IdPanel1.Location = new Point(0, 24);
            //this.IdPanel1.Name = "IdPanel1";
            //this.IdPanel1.Size = new Size(200, 865);
            //this.IdPanel1.TabIndex = 0;



            //this.btnMap.BackColor = Color.Brown;
            //this.btnMap.Cursor = Cursors.Default;
            //this.btnMap.Enabled = false;
            //this.btnMap.FlatStyle = FlatStyle.Flat;
            //this.btnMap.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            //this.btnMap.ForeColor = Color.White;



            ////this.btnMap.Location = new Point(0, 530);
            //this.btnMap.Location = new Point(0, 600);


            //this.btnMap.Name = "btnMap";
            //this.btnMap.RightToLeft = RightToLeft.No;
            //this.btnMap.Size = new Size(200, 36);
            //this.btnMap.TabIndex = 51;
            //this.btnMap.Text = "&Map";
            //this.btnMap.UseVisualStyleBackColor = false;
            //this.gbLegend.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            //this.gbLegend.Controls.Add(this.IdLabel8);
            //this.gbLegend.Controls.Add(this.IdLabel7);
            //this.gbLegend.Controls.Add(this.IdLabel5);
            //this.gbLegend.Controls.Add(this.IdLabel4);
            //this.gbLegend.Controls.Add(this.IdLabel3);
            //this.gbLegend.Controls.Add(this.IdLabel2);
            //this.gbLegend.Controls.Add(this.IdLabel6);
            //this.gbLegend.Font = new Font("Arial", 10f);



            ////this.gbLegend.Location = new Point(16, 646);
            //this.gbLegend.Location = new Point(16, 714);



            //this.gbLegend.Name = "gbLegend";
            //this.gbLegend.Size = new Size(152, 151);
            //this.gbLegend.TabIndex = 50;
            //this.gbLegend.TabStop = false;
            //this.gbLegend.Tag = "";
            //this.gbLegend.Text = "Legend";
            //this.gbLegend.Visible = false;
            //this.IdLabel8.AutoSize = true;
            //this.IdLabel8.BackColor = Color.White;
            //this.IdLabel8.Font = new Font("Microsoft Sans Serif", 8f);
            //this.IdLabel8.Location = new Point(21, 133);
            //this.IdLabel8.Name = "IdLabel8";
            //this.IdLabel8.Size = new Size(108, 13);
            //this.IdLabel8.TabIndex = 6;
            //this.IdLabel8.Text = "WHITE Un-approved";
            //this.IdLabel7.AutoSize = true;
            //this.IdLabel7.BackColor = Color.Orange;
            //this.IdLabel7.Font = new Font("Microsoft Sans Serif", 8f);
            //this.IdLabel7.Location = new Point(21, 114);
            //this.IdLabel7.Name = "IdLabel7";
            //this.IdLabel7.Size = new Size(101, 13);
            //this.IdLabel7.TabIndex = 5;
            //this.IdLabel7.Text = "ORANGE Test Only";
            //this.IdLabel5.AutoSize = true;
            //this.IdLabel5.BackColor = Color.Yellow;
            //this.IdLabel5.Font = new Font("Microsoft Sans Serif", 8f);
            //this.IdLabel5.Location = new Point(21, 95);
            //this.IdLabel5.Name = "IdLabel5";
            //this.IdLabel5.Size = new Size(104, 13);
            //this.IdLabel5.TabIndex = 4;
            //this.IdLabel5.Text = "YELLOW Outsource";
            //this.IdLabel4.AutoSize = true;
            //this.IdLabel4.BackColor = Color.Green;
            //this.IdLabel4.Font = new Font("Microsoft Sans Serif", 8f);
            //this.IdLabel4.ForeColor = Color.White;
            //this.IdLabel4.Location = new Point(21, 76);
            //this.IdLabel4.Name = "IdLabel4";
            //this.IdLabel4.Size = new Size(94, 13);
            //this.IdLabel4.TabIndex = 3;
            //this.IdLabel4.Text = "GREEN Approved";
            //this.IdLabel3.AutoSize = true;
            //this.IdLabel3.BackColor = Color.Magenta;
            //this.IdLabel3.Font = new Font("Microsoft Sans Serif", 8f);
            //this.IdLabel3.ForeColor = Color.White;
            //this.IdLabel3.Location = new Point(21, 57);
            //this.IdLabel3.Name = "IdLabel3";
            //this.IdLabel3.Size = new Size(106, 13);
            //this.IdLabel3.TabIndex = 2;
            //this.IdLabel3.Text = "MAGENTA Warranty";
            //this.IdLabel2.AutoSize = true;
            //this.IdLabel2.BackColor = Color.Cyan;
            //this.IdLabel2.Font = new Font("Microsoft Sans Serif", 8f);
            //this.IdLabel2.ForeColor = Color.Black;
            //this.IdLabel2.Location = new Point(21, 38);
            //this.IdLabel2.Name = "IdLabel2";
            //this.IdLabel2.Size = new Size(78, 13);
            //this.IdLabel2.TabIndex = 1;
            //this.IdLabel2.Text = "CYAN Shipped";
            //this.IdLabel6.AutoSize = true;
            //this.IdLabel6.BackColor = Color.Red;
            //this.IdLabel6.Font = new Font("Microsoft Sans Serif", 8f);
            //this.IdLabel6.ForeColor = Color.White;
            //this.IdLabel6.Location = new Point(21, 19);
            //this.IdLabel6.Name = "IdLabel6";
            //this.IdLabel6.Size = new Size(55, 13);
            //this.IdLabel6.TabIndex = 0;
            //this.IdLabel6.Text = "RED Hold";
            //this.lblCalendar.AutoSize = true;
            //this.lblCalendar.Font = new Font("Arial", 10f);



            //this.lblCalendar.Location = new Point(15, 594);
            //this.lblCalendar.Location = new Point(15, 664);


            //this.lblCalendar.Name = "lblCalendar";
            //this.lblCalendar.Size = new Size(134, 16);
            //this.lblCalendar.TabIndex = 9;
            //this.lblCalendar.Text = "Show Calendar For:";
            this.cbCalendar.AllowNewType = idComboBox.Display.NONE;
            //this.cbCalendar.AutoCompleteMode = AutoCompleteMode.Append;
            //this.cbCalendar.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cbCalendar.DataSource = this.EnhancedManageUserComboBindingSource;
            //this.cbCalendar.DisplayMember = "UserID";
            //this.cbCalendar.Font = new Font("Arial", 10f);
            //this.cbCalendar.FormattingEnabled = true;



            /////this.cbCalendar.Location = new Point(16, 616);
            //this.cbCalendar.Location = new Point(16, 676);



            //this.cbCalendar.Name = "cbCalendar";
            //this.cbCalendar.Size = new Size(154, 24);
            //this.cbCalendar.TabIndex = 10;
            this.cbCalendar.useBackColorChange = true;
            //this.cbCalendar.ValueMember = "UserID";

            this.EnhancedManageUserComboBindingSource.DataMember = "EnhancedManageUserCombo";
            this.EnhancedManageUserComboBindingSource.DataSource = this.IRDataSetViews;
            this.IRDataSetViews.DataSetName = "IRDataSetViews";
            this.IRDataSetViews.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            //this.lblTasks.AutoSize = true;
            //this.lblTasks.Font = new Font("Arial", 10f);



            ////this.lblTasks.Location = new Point(15, 594);
            //this.lblTasks.Location = new Point(15, 664);



            //this.lblTasks.Name = "lblTasks";
            //this.lblTasks.Size = new Size(112, 16);
            //this.lblTasks.TabIndex = 7;
            //this.lblTasks.Text = "Show Tasks For:";
            this.cbTasks.AllowNewType = idComboBox.Display.NONE;
            //this.cbTasks.AutoCompleteMode = AutoCompleteMode.Append;
            //this.cbTasks.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cbTasks.DataSource = this.ManageUserComboBindingSource;
            //this.cbTasks.DisplayMember = "UserID";
            //this.cbTasks.Font = new Font("Arial", 10f);
            //this.cbTasks.FormattingEnabled = true;

            ////////////////////////////
            //this.cbTasks.Location = new Point(16, 616);
            //this.cbTasks.Location = new Point(16, 676);


            //this.cbTasks.Name = "cbTasks";
            //this.cbTasks.Size = new Size(154, 24);
            //this.cbTasks.TabIndex = 8;
            this.cbTasks.useBackColorChange = true;
            //this.cbTasks.ValueMember = "UserID";
            this.ManageUserComboBindingSource.DataMember = "ManageUserCombo";
            this.ManageUserComboBindingSource.DataSource = this.IRDataSetViews;
            //this.ckAllTasks.AutoSize = true;
            //this.ckAllTasks.Font = new Font("Arial", 10f);


            ////this.ckAllTasks.Location = new Point(18, 571);
            //this.ckAllTasks.Location = new Point(18, 641);


            //this.ckAllTasks.Name = "ckAllTasks";
            //this.ckAllTasks.Size = new Size(119, 20);
            //this.ckAllTasks.TabIndex = 6;
            //this.ckAllTasks.Text = "Show All Tasks";
            //this.ckAllTasks.UseVisualStyleBackColor = true;
            //this.btnCalendar.BackColor = Color.Brown;
            //this.btnCalendar.Cursor = Cursors.Default;
            //this.btnCalendar.Enabled = false;
            //this.btnCalendar.FlatStyle = FlatStyle.Flat;
            //this.btnCalendar.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            //this.btnCalendar.ForeColor = Color.White;


            ////this.btnCalendar.Location = new Point(0, 494);
            //this.btnCalendar.Location = new Point(0, 564);

            //this.btnCalendar.Name = "btnCalendar";
            //this.btnCalendar.RightToLeft = RightToLeft.No;
            //this.btnCalendar.Size = new Size(200, 36);
            //this.btnCalendar.TabIndex = 5;
            //this.btnCalendar.Text = "&Calendar";
            //this.btnCalendar.UseVisualStyleBackColor = false;
            //this.btnTasks.BackColor = Color.Brown;
            //this.btnTasks.FlatStyle = FlatStyle.Flat;
            //this.btnTasks.Font = new Font("Arial", 10f);
            //this.btnTasks.ForeColor = Color.White;


            ////this.btnTasks.Location = new Point(0, 458);
            //this.btnTasks.Location = new Point(0, 528);

            //this.btnTasks.Name = "btnTasks";
            //this.btnTasks.Size = new Size(200, 36);
            //this.btnTasks.TabIndex = 4;
            //this.btnTasks.Text = "Call List";
            //this.btnTasks.UseVisualStyleBackColor = false;
            //this.btnGroups.BackColor = Color.Brown;
            //this.btnGroups.FlatStyle = FlatStyle.Flat;
            //this.btnGroups.Font = new Font("Arial", 10f);
            //this.btnGroups.ForeColor = Color.White;


            ////this.btnGroups.Location = new Point(0, 422);
            //this.btnGroups.Location = new Point(0, 492);

            //this.btnGroups.Name = "btnGroups";
            //this.btnGroups.Size = new Size(200, 36);
            //this.btnGroups.TabIndex = 3;
            //this.btnGroups.Text = "Areas";
            //this.btnGroups.UseVisualStyleBackColor = false;
            //this.btnSearch.BackColor = Color.Brown;
            //this.btnSearch.FlatStyle = FlatStyle.Flat;
            //this.btnSearch.Font = new Font("Arial", 10f);
            //this.btnSearch.ForeColor = Color.White;


            ////this.btnSearch.Location = new Point(0, 386);
            //this.btnSearch.Location = new Point(0, 456);

            //this.btnSearch.Name = "btnSearch";
            //this.btnSearch.Size = new Size(200, 36);
            //this.btnSearch.TabIndex = 2;
            //this.btnSearch.Text = "Search Grid";
            //this.btnSearch.UseVisualStyleBackColor = false;
            //this.btnContacts.BackColor = Color.Brown;
            //this.btnContacts.FlatStyle = FlatStyle.Flat;
            //this.btnContacts.Font = new Font("Arial", 10f);
            //this.btnContacts.ForeColor = Color.White;

            ////this.btnContacts.Location = new Point(0, 350);
            //this.btnContacts.Location = new Point(0, 420);

            //this.btnContacts.Name = "btnContacts";
            //this.btnContacts.Size = new Size(200, 36);
            //this.btnContacts.TabIndex = 1;
            //this.btnContacts.Text = "Contacts";
            //this.btnContacts.UseVisualStyleBackColor = false;
            //this.IdGroupBox1.Controls.Add(this.ckHideInactive);
            //this.IdGroupBox1.Controls.Add(this.cbLookupData);
            //this.IdGroupBox1.Controls.Add(this.ckLookupAll);
            //this.IdGroupBox1.Controls.Add(this.ckSecondary);
            //this.IdGroupBox1.Controls.Add(this.ckShowAllContacts);
            //this.IdGroupBox1.Controls.Add(this.btnAdvFind);
            //this.IdGroupBox1.Controls.Add(this.btnFind);
            //this.IdGroupBox1.Controls.Add(this.cbLookup);
            //this.IdGroupBox1.Controls.Add(this.IdLabel1);
            //this.IdGroupBox1.Controls.Add(this.lblLookup);
            //this.IdGroupBox1.Controls.Add(this.ckPartial);
            //this.IdGroupBox1.FlatStyle = FlatStyle.Flat;
            //this.IdGroupBox1.Font = new Font("Arial", 10f);

            ////this.IdGroupBox1.Location = new Point(0, -12);
            //this.IdGroupBox1.Location = new Point(0, 58);

            //this.IdGroupBox1.Name = "IdGroupBox1";
            //this.IdGroupBox1.Size = new Size(200, 361);
            //this.IdGroupBox1.TabIndex = 0;
            //this.IdGroupBox1.TabStop = false;
            //this.ckHideInactive.AutoSize = true;
            //this.ckHideInactive.Checked = true;
            //this.ckHideInactive.CheckState = CheckState.Checked;
            //this.ckHideInactive.Font = new Font("Arial", 10f);
            //this.ckHideInactive.Location = new Point(5, 284);
            //this.ckHideInactive.Name = "ckHideInactive";
            //this.ckHideInactive.Size = new Size(167, 20);
            //this.ckHideInactive.TabIndex = 5;
            //this.ckHideInactive.Text = "Hide Inactive Contacts";
            //this.ckHideInactive.UseVisualStyleBackColor = true;
            this.cbLookupData.AllowNewType = idComboBox.Display.NONE;
            //this.cbLookupData.AutoCompleteMode = AutoCompleteMode.Append;
            //this.cbLookupData.AutoCompleteSource = AutoCompleteSource.ListItems;
            //this.cbLookupData.Font = new Font("Arial", 10f);
            //this.cbLookupData.FormattingEnabled = true;
            //this.cbLookupData.Location = new Point(10, 96);
            //this.cbLookupData.Name = "cbLookupData";
            //this.cbLookupData.Size = new Size(177, 24);
            //this.cbLookupData.TabIndex = 1;
            this.cbLookupData.useBackColorChange = true;
            //this.ckLookupAll.AutoSize = true;
            //this.ckLookupAll.Font = new Font("Arial", 10f);
            //this.ckLookupAll.Location = new Point(5, 336);
            //this.ckLookupAll.Name = "ckLookupAll";
            //this.ckLookupAll.Size = new Size(92, 20);
            //this.ckLookupAll.TabIndex = 7;
            //this.ckLookupAll.Text = "Lookup All";
            //this.ckLookupAll.UseVisualStyleBackColor = true;
            //this.ckSecondary.Checked = true;
            //this.ckSecondary.CheckState = CheckState.Checked;
            //this.ckSecondary.Font = new Font("Arial", 10f);
            //this.ckSecondary.Location = new Point(6, 246);
            //this.ckSecondary.Name = "ckSecondary";
            //this.ckSecondary.Size = new Size(154, 41);
            //this.ckSecondary.TabIndex = 4;
            //this.ckSecondary.Text = "Exclude Secondary Contacts On Grid";
            //this.ckSecondary.UseVisualStyleBackColor = true;
            //this.ckShowAllContacts.AutoSize = true;
            //this.ckShowAllContacts.Font = new Font("Arial", 10f);
            //this.ckShowAllContacts.Location = new Point(5, 310);
            //this.ckShowAllContacts.Name = "ckShowAllContacts";
            //this.ckShowAllContacts.Size = new Size(191, 20);
            //this.ckShowAllContacts.TabIndex = 6;
            //this.ckShowAllContacts.Text = "Show everyone’s contacts";
            //this.ckShowAllContacts.UseVisualStyleBackColor = true;
            //this.ckShowAllContacts.Visible = false;
            //this.btnAdvFind.BackColor = Color.Brown;
            //this.btnAdvFind.Cursor = Cursors.Default;
            //this.btnAdvFind.FlatStyle = FlatStyle.Flat;
            //this.btnAdvFind.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            //this.btnAdvFind.ForeColor = Color.White;
            //this.btnAdvFind.Location = new Point(42, 198);
            //this.btnAdvFind.Name = "btnAdvFind";
            //this.btnAdvFind.RightToLeft = RightToLeft.No;
            //this.btnAdvFind.Size = new Size(98, 42);
            //this.btnAdvFind.TabIndex = 3;
            //this.btnAdvFind.Text = "&Advanced Find";
            //this.btnAdvFind.UseVisualStyleBackColor = false;
            //this.btnFind.BackColor = Color.Brown;
            //this.btnFind.Cursor = Cursors.Default;
            //this.btnFind.FlatStyle = FlatStyle.Flat;
            //this.btnFind.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            //this.btnFind.ForeColor = Color.White;
            //this.btnFind.Location = new Point(42, 150);
            //this.btnFind.Name = "btnFind";
            //this.btnFind.RightToLeft = RightToLeft.No;
            //this.btnFind.Size = new Size(98, 42);
            //this.btnFind.TabIndex = 2;
            //this.btnFind.Text = "&Find";
            //this.btnFind.UseVisualStyleBackColor = false;
            this.cbLookup.AllowNew = true;
            this.cbLookup.AllowNewType = idComboBox.Display.NONE;
            //this.cbLookup.AutoCompleteMode = AutoCompleteMode.Append;
            //this.cbLookup.AutoCompleteSource = AutoCompleteSource.ListItems;
            //this.cbLookup.Font = new Font("Arial", 10f);
            //this.cbLookup.FormattingEnabled = true;
            //this.cbLookup.Location = new Point(12, 50);
            //this.cbLookup.Name = "cbLookup";
            //this.cbLookup.Size = new Size(175, 24);
            //this.cbLookup.TabIndex = 0;
            this.cbLookup.useBackColorChange = true;
            //this.IdLabel1.AutoSize = true;
            //this.IdLabel1.Font = new Font("Arial", 10f);
            //this.IdLabel1.Location = new Point(13, 75);
            //this.IdLabel1.Name = "IdLabel1";
            //this.IdLabel1.Size = new Size(68, 16);
            //this.IdLabel1.TabIndex = 8;
            //this.IdLabel1.Text = "Contains:";
            //this.lblLookup.AutoSize = true;
            //this.lblLookup.Font = new Font("Arial", 10f);
            //this.lblLookup.Location = new Point(12, 19);
            //this.lblLookup.Name = "lblLookup";
            //this.lblLookup.Size = new Size(96, 16);
            //this.lblLookup.TabIndex = 5;
            //this.lblLookup.Text = "Contact Field:";
            //this.ckPartial.AutoSize = true;
            //this.ckPartial.Checked = true;
            //this.ckPartial.CheckState = CheckState.Checked;
            //this.ckPartial.Font = new Font("Arial", 10f);
            //this.ckPartial.Location = new Point(16, 120);
            //this.ckPartial.Name = "ckPartial";
            //this.ckPartial.Size = new Size(154, 20);
            //this.ckPartial.TabIndex = 10;
            //this.ckPartial.Text = "Allow Partial Lookup";
            //this.ckPartial.UseVisualStyleBackColor = true;

            this.ManageUserComboTableAdapter.ClearBeforeFill = true;
            this.EnhancedManageUserComboTableAdapter.ClearBeforeFill = true;
            //base.AutoScaleMode = AutoScaleMode.Inherit;
            //this.BackColor = Color.Tan;
            //base.ClientSize = new Size(1112, 911);
            //base.Controls.Add(this.IdPanel1);
            //base.Controls.Add(this.StatusStrip1);
            //base.Controls.Add(this.MenuStrip1);

   //////////////////         base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");

            //base.IsMdiContainer = true;
            //base.Name = "frmMain";
            //base.StartPosition = FormStartPosition.CenterScreen;
            //this.Text = "CRM Azure";
            //base.WindowState = FormWindowState.Maximized;
            //this.MenuStrip1.ResumeLayout(false);
            //this.MenuStrip1.PerformLayout();
            //this.StatusStrip1.ResumeLayout(false);
            //this.StatusStrip1.PerformLayout();
            //this.IdPanel1.ResumeLayout(false);
            //this.IdPanel1.PerformLayout();
            //this.gbLegend.ResumeLayout(false);
            //this.gbLegend.PerformLayout();



            //((ISupportInitialize)this.EnhancedManageUserComboBindingSource).EndInit();
            ((ISupportInitialize)this.IRDataSetViews).EndInit();
            //((ISupportInitialize)this.ManageUserComboBindingSource).EndInit();
            //this.IdGroupBox1.ResumeLayout(false);
            //this.IdGroupBox1.PerformLayout();
            //base.ResumeLayout(false);
            //base.PerformLayout();
        }




        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        #region comments

        //private void frmMain_Load(object sender, EventArgs e)
        //{

        //    // V2 - 12/6/2021.
        //    this.Text = "CRM Azure - Contact";
        //    this.WindowState = FormWindowState.Normal;

        //    this.Width = 2000;
        //    this.Height = 1000;

        //    this.Icon = new Icon("crm_icon_resized.ico");

        //    Common.LastContacts = new int[5];
        //    Common.LastTask = new int[5];
        //    Common.LastContactPosition = 0;
        //    this.lblTasks.Visible = false;
        //    this.cbTasks.Visible = false;
        //    this.lblCalendar.Visible = false;
        //    this.cbCalendar.Visible = false;
        //    this.Text = "CRM Azure v" + Common.SetVersionDate(MyProject.Application.Info.Version.ToString(), true);
        //    Common.MyIP = clsSQLConn.SetConnectionString();
        //    //Common.NewVersion = false;
        //    if (!MyProject.Computer.FileSystem.DirectoryExists(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\CRMEmailTracker\\History"))
        //    {
        //        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\CRMEmailTracker\\History");
        //    }
        //    clsEmailTracker.ClearEmailHistory();
        //    if (Common.NoData)
        //    {
        //        if (Interaction.MsgBox("Your database is empty.\rIf you are loading your local database for the first time this is expected press OK.\rIf not then press Cancel to flip back to the main server.", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "Empty or missing local database") == MsgBoxResult.Cancel)
        //        {
        //            try
        //            {
        //                FileSystem.FileOpen(1, Common.CommonFolder + "\\Preferences.ini", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
        //                FileSystem.PrintLine(1, new object[]
        //                {
        //                    "1"
        //                });
        //                FileSystem.PrintLine(1, new object[]
        //                {
        //                    "0"
        //                });
        //                FileSystem.PrintLine(1, new object[]
        //                {
        //                    "1"
        //                });
        //                FileSystem.FileClose(new int[]
        //                {
        //                    1
        //                });
        //            }
        //            catch (Exception expr_168)
        //            {
        //                ProjectData.SetProjectError(expr_168);
        //                ProjectData.ClearProjectError();
        //            }
        //            Common.MyIP = clsSQLConn.SetConnectionString();
        //            Interaction.MsgBox("Your preferences have been reset back to the default settings.", MsgBoxStyle.OkOnly, null);
        //        }
        //        else
        //        {
        //            new frmLoadData().ShowDialog();
        //            base.Close();
        //        }
        //    }
        //    if (!clsSQLConn.isConnected(false))
        //    {
        //        Interaction.MsgBox("SQL Connect Error", MsgBoxStyle.OkOnly, null);
        //        ProjectData.EndApp();
        //    }
        //    int num = 0;
        //    frmLogin frmLogin = new frmLogin();
        //    checked
        //    {
        //        while (!((Operators.CompareString(Common.IRUser, "", false) != 0 & Operators.CompareString(Common.IRGroup, "", false) != 0) | num > 3))
        //        {
        //            if (num > 0)
        //            {
        //                Interaction.MsgBox("Incorrect username or password.", MsgBoxStyle.OkOnly, null);
        //                Common.LogEntryCRM(base.Name, "Failed Login", 0, 0, frmLogin.txtUserID.Text + " " + frmLogin.txtPassword.Text);
        //            }
        //            num++;
        //            frmLogin.ShowDialog();
        //            if (frmLogin.DialogResult != DialogResult.OK)
        //            {
        //                ProjectData.EndApp();
        //            }
        //            else
        //            {
        //                Common.IRGroup = Common.StrScalar(string.Concat(new string[]
        //                {
        //                    "select UserGroup from CRMUsers where UserID = '",
        //                    frmLogin.txtUserID.Text,
        //                    "' and LoginPassword = '",
        //                    frmLogin.txtPassword.Text,
        //                    "' and Active = 'True' and CanLogin = 'True'"
        //                }), false);
        //                Common.IRUser = frmLogin.txtUserID.Text;
        //            }
        //        }
        //        if (Operators.CompareString(Common.IRGroup, "", false) == 0 | Operators.CompareString(Common.IRGroup, "BAD", false) == 0)
        //        {
        //            Interaction.MsgBox("Incorrect username or password.", MsgBoxStyle.OkOnly, null);
        //            Common.LogEntryCRM(base.Name, "Failed Login", 0, 0, frmLogin.txtUserID.Text + " " + frmLogin.txtPassword.Text);
        //            ProjectData.EndApp();
        //        }
        //        this.Cursor = Cursors.WaitCursor;
        //        Common.IRSalesPersonNo = Common.IntScalar("select isnull(IRSalesPersonNo,0) from CRMUsers where UserID = '" + Common.IRUser + "'", false);
        //        int num2 = FileSystem.FreeFile();
        //        FileSystem.FileOpen(num2, MyProject.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\\CRMLocal.ini", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
        //        FileSystem.PrintLine(num2, new object[]
        //        {
        //            frmLogin.txtUserID.Text
        //        });
        //        FileSystem.FileClose(new int[]
        //        {
        //            num2
        //        });
        //        if (clsSQLConn.isConnected(false))
        //        {
        //            this.Text = "CRM Azure (" + Common.IRUser + ") v " + Common.SetVersionDate(MyProject.Application.Info.Version.ToString(), false);
        //            if (Common.LocalOnly)
        //            {
        //                this.Text += " LOCAL USE ONLY NO CHANGES WILL SAVE TO SERVER";
        //            }
        //            Common.LogEntryCRM(base.Name, "Login", 0, 0, "");
        //        }
        //        frmLogin.Close();
        //        this.CreateTable();
        //        this.GetStarted();
        //        this.SetupLookup();
        //        this.EmailTemplatePermissions();
        //        if (Common.CanUseForm("DELETE CONTACT", true))
        //        {
        //            this.DeleteContactToolStripMenuItem.Visible = true;
        //        }
        //        else
        //        {
        //            this.DeleteContactToolStripMenuItem.Visible = false;
        //        }
        //        if (Common.CanUseForm("MAPPING", true))
        //        {
        //            this.MapsToolStripMenuItem.Visible = true;
        //        }
        //        else
        //        {
        //            this.MapsToolStripMenuItem.Visible = false;
        //        }
        //        if (!Common.CanUseForm("ACTIVITYREPORT", true))
        //        {
        //            this.CallReportToolStripMenuItem.Visible = false;
        //        }
        //        if (!Common.CanUseForm("TODAYS_ACTIVITIES", true))
        //        {
        //            this.TodaysActivitiesToolStripMenuItem.Visible = false;
        //        }
        //        if (Common.CanUseForm("PRODUCTIVITY_REPORT", true))
        //        {
        //            this.ProductivityReportToolStripMenuItem.Visible = true;
        //        }
        //        else
        //        {
        //            this.ProductivityReportToolStripMenuItem.Visible = false;
        //        }
        //        if (Common.CanUseForm("ALLCONTACTS", true))
        //        {
        //            this.ckShowAllContacts.Visible = true;
        //            if (Common.LookupAllFiles)
        //            {
        //                this.ckShowAllContacts.CheckState = CheckState.Checked;
        //            }
        //            else
        //            {
        //                this.ckShowAllContacts.CheckState = CheckState.Unchecked;
        //            }
        //        }
        //        else
        //        {
        //            this.ckShowAllContacts.CheckState = CheckState.Unchecked;
        //            this.ckShowAllContacts.Visible = false;
        //        }
        //        if (Common.HideInactive)
        //        {
        //            this.ckHideInactive.CheckState = CheckState.Checked;
        //        }
        //        else
        //        {
        //            this.ckHideInactive.CheckState = CheckState.Unchecked;
        //        }
        //        this.Timer1.Enabled = true;
        //        this.ToDoPopup.Enabled = true;
        //        Common.NonQuery("update CRMTasks set OnHold = 'False' where (OnHold = 'True' or OnHold is null) and ManageUserID = '" + Common.IRUser + "'", false);
        //        this.ManageUserComboTableAdapter.Fill(this.IRDataSetViews.ManageUserCombo);
        //        try
        //        {
        //            this.EnhancedManageUserComboTableAdapter.Fill(this.IRDataSetViews.EnhancedManageUserCombo);
        //        }
        //        catch (Exception expr_5AC)
        //        {
        //            ProjectData.SetProjectError(expr_5AC);
        //            ProjectData.ClearProjectError();
        //        }
        //        this.cbTasks.Text = "";
        //        this.cbCalendar.Text = "";
        //        if (Common.CanUseForm("PRINT_CURRENT_FORM", true))
        //        {
        //            this.PrintCurrentFormToolStripMenuItem.Visible = true;
        //        }
        //        this.Cursor = Cursors.Default;
        //        if (!Common.CanUseForm("MIKES_LIST", true))
        //        {
        //            this.MikesListToolStripMenuItem.Visible = false;
        //        }
        //        if (!Common.CanUseForm("FRANCIES_LIST", true))
        //        {
        //            this.FranciesListToolStripMenuItem.Visible = false;
        //        }
        //        if (Operators.CompareString(Strings.UCase(Common.IRUser), "JEFF", false) == 0)
        //        {
        //            this.JustForJeffToolStripMenuItem.Visible = true;
        //        }
        //        else
        //        {
        //            this.JustForJeffToolStripMenuItem.Visible = false;
        //        }
        //        if (!Common.CanUseForm("", true))
        //        {
        //            this.TelemarketerActivityToolStripMenuItem.Visible = false;
        //        }
        //        if (!Common.CanUseForm("", true))
        //        {
        //            this.TelemarketerNewCustomerToolStripMenuItem.Visible = false;
        //        }
        //        if (!this.TelemarketerNewCustomerToolStripMenuItem.Visible & !this.TelemarketerActivityToolStripMenuItem.Visible)
        //        {
        //            this.ToolStripMenuItem5.Visible = false;
        //        }

        //        int num3 = 0;

        //        try
        //        {
        //            if (MyProject.Computer.FileSystem.FileExists(Common.CommonFolder + "\\LastCompany.ini"))
        //            {
        //                FileSystem.FileOpen(1, Common.CommonFolder + "\\LastCompany.ini", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);

        //                num3 = Conversions.ToInteger(FileSystem.LineInput(1));

        //                FileSystem.FileClose(new int[]
        //                {
        //                    1
        //                });
        //            }
        //        }
        //        catch (Exception expr_717)
        //        {
        //            ProjectData.SetProjectError(expr_717);
        //            ProjectData.ClearProjectError();
        //        }

        //        if (num3 != 0)
        //        {
        //            this.frmShowing = 1;
        //            this.SetupLookup();

        //            if (Common.LaptopMonitor)
        //            {
        //                Form[] mdiChildren = base.MdiChildren;

        //                for (int i = 0; i < mdiChildren.Length; i++)
        //                {
        //                    Form form = mdiChildren[i];

        //                    if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                    {
        //                        new frmContactLaptop();

        //                        frmContactLaptop expr_77F = (frmContactLaptop)form;
        //                        expr_77F.ContactID = num3;
        //                        clsContacts.RefreshData(false);

        //                        expr_77F.WindowState = FormWindowState.Maximized;

        //                        expr_77F.BringToFrontHelper();
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                Form[] mdiChildren2 = base.MdiChildren;

        //                for (int j = 0; j < mdiChildren2.Length; j++)
        //                {
        //                    Form form2 = mdiChildren2[j];

        //                    if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                    {
        //                        new frmContact();

        //                        frmContact expr_7E0 = (frmContact)form2;
        //                        expr_7E0.ContactID = num3;
        //                        clsContacts.RefreshData(false);

        //                        expr_7E0.WindowState = FormWindowState.Maximized;

        //                        expr_7E0.BringToFrontHelper();
        //                    }
        //                }
        //            }
        //        }

        //        if (Common.LocalOnly)
        //        {
        //            this.UpdateLocalDataToolStripMenuItem.Visible = true;
        //        }
        //        else
        //        {
        //            this.UpdateLocalDataToolStripMenuItem.Visible = false;
        //        }

        //        this.cbLookup.Focus();

        //        int num4 = Common.IntScalar(string.Concat(new string[]
        //        {
        //            "select Count(*) from CRMTasks T join CRMContactList L on T.ContactID = L.ContactID where  T.ManageUserID = '",
        //            Common.IRUser,
        //            "' and (TaskType = 6 or TaskType = 1)  and Deleted = 'False' and TaskColor <> '255,185,185,185' and StartTime < '",
        //            DateAndTime.DateAdd(DateInterval.Day, -2.0, DateTime.Today).ToShortDateString(),
        //            "'"
        //        }), false);

        //        if (num4 > 0)
        //        {
        //            Interaction.MsgBox("You have " + Conversions.ToString(num4) + " open calendar items over two days old.", MsgBoxStyle.OkOnly, null);
        //        }
        //    }

        //    // V2 - 12/6/2021.
        //    this.Text = "CRM Azure - Contact";
        //}

        //private void EmailTemplatePermissions()
        //{
        //    SqlConnection sqlConnection = new SqlConnection();
        //    sqlConnection = Common.ConnectToSQL(false);
        //    SqlCommand sqlCommand = new SqlCommand("select TemplateName from CRMEmailTemplates where TemplateName not in (select FormName from CRMUserForms)", sqlConnection);
        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //    while (sqlDataReader.Read())
        //    {
        //        Common.NonQuery("insert into CRMUserForms (FormName) values ('" + sqlDataReader.GetString(0) + "')", false);
        //    }
        //    sqlCommand.Connection.Close();
        //    sqlConnection.Close();
        //}

        //private void CreateTable()
        //{
        //    try
        //    {
        //        this.dtLookup = new DataTable("LookupData");
        //        DataColumn dataColumn = new DataColumn();
        //        dataColumn.DataType = Type.GetType("System.String");
        //        dataColumn.ColumnName = "DisplayName";
        //        dataColumn.AutoIncrement = false;
        //        dataColumn.Caption = "DisplayName";
        //        dataColumn.ReadOnly = false;
        //        dataColumn.Unique = false;
        //        this.dtLookup.Columns.Add(dataColumn);
        //        dataColumn = new DataColumn();
        //        dataColumn.DataType = Type.GetType("System.String");
        //        dataColumn.ColumnName = "FieldName";
        //        dataColumn.ReadOnly = true;
        //        dataColumn.Unique = true;
        //        this.dtLookup.Columns.Add(dataColumn);
        //    }
        //    catch (Exception expr_A4)
        //    {
        //        ProjectData.SetProjectError(expr_A4);
        //        Exception ex = expr_A4;
        //        string arg_B1_0 = ex.Message;
        //        ProjectData.ClearProjectError();
        //    }
        //}

        //private void GetStarted()
        //{
        //    this.frmShowing = 1;

        //    if (Common.LaptopMonitor)
        //    {
        //        frmContactLaptop frmContactLaptop = new frmContactLaptop();

        //        if (Common.CanUseForm(Conversions.ToString(frmContactLaptop.Tag), false))
        //        {
        //            frmContactLaptop.Icon = base.Icon;
        //            frmContactLaptop.MdiParent = this;

        //            // frmContactLaptop.ControlBox = false;
        //            frmContactLaptop.ControlBox = true;

        //            frmContactLaptop.Show();

        //            return;
        //        }
        //    }
        //    else
        //    {
        //        // V2 - 12/6/2021:

        //        LaunchContactForm();

        //        //frmContact frmContact = new frmContact();
        //        //if (Common.CanUseForm(Conversions.ToString(frmContact.Tag), false))
        //        //{
        //        //    frmContact.Icon = base.Icon;
        //        //    frmContact.MdiParent = this;
        //        //    frmContact.Show();
        //        //    frmContact.WindowState = FormWindowState.Minimized;
        //        //    frmContact.BringToFrontHelper();
        //        //}
        //    }
        //}



        //// V2 12/6/2021:
        //frmContact frmContact;
        //public void LaunchContactForm()
        //{
        //    frmContact = null;
        //    frmContact = new frmContact();

        //    if (Common.CanUseForm(Conversions.ToString(frmContact.Tag), false))
        //    {
        //        frmContact.Icon = base.Icon;
        //        frmContact.MdiParent = this;

        //        frmContact.ControlBox = true;

        //        frmContact.Show();


        //        //frmContact.WindowState = FormWindowState.Minimized;

        //        frmContact.WindowState = FormWindowState.Maximized;

        //        frmContact.BringToFrontHelper();
        //    }
        //}


        //// V2 12/9/2021:

        //public void LaunchForm(Form formToLaunch)
        //{
        //    frmContact = null;
        //    frmContact = new frmContact();

        //    if (Common.CanUseForm(Conversions.ToString(frmContact.Tag), false))
        //    {
        //        frmContact.Icon = base.Icon;
        //        frmContact.MdiParent = this;
        //        frmContact.Show();
        //        frmContact.WindowState = FormWindowState.Minimized;
        //        frmContact.BringToFrontHelper();
        //    }
        //}

        #endregion



        //private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    base.Close();
        //}

        //private void PrintCurrentFormToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Common.PrintForm(base.ActiveMdiChild);
        //}

        //private void UsersToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    frmLookup frmLookup = new frmLookup("User", "Select 'User Login' = UserID, 'Group' = UserGroup from CRMUsers order by UserID");
        //    if (Common.CanUseForm("User", false))
        //    {
        //        frmLookup.Icon = base.Icon;
        //        frmLookup.ShowDialog();
        //    }
        //}

        //private void UserGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmUserGroups frmUserGroups = new frmUserGroups();
        //    if (Common.CanUseForm(Conversions.ToString(frmUserGroups.Tag), false))
        //    {
        //        frmUserGroups.Icon = base.Icon;
        //        frmUserGroups.ShowDialog();
        //    }
        //}

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    FileSystem.FileOpen(1, Common.CommonFolder + "\\LastCompany.ini", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
        //    FileSystem.PrintLine(1, new object[]
        //    {
        //        Common.LastContactID
        //    });
        //    FileSystem.FileClose(new int[]
        //    {
        //        1
        //    });
        //    Common.LogEntryCRM(base.Name, "Logoff", 0, 0, "");
        //}

        //private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    base.LayoutMdi(MdiLayout.Cascade);
        //}

        //private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    base.LayoutMdi(MdiLayout.TileVertical);
        //}

        //private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    base.LayoutMdi(MdiLayout.TileHorizontal);
        //}

        //private void btnContacts_Click(object sender, EventArgs e)
        //{
        //    this.frmShowing = 1;

        //    this.SetupLookup();

        //    checked
        //    {
        //        if (Common.LaptopMonitor)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;

        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];

        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                {
        //                    form.BringToFrontHelper();
        //                    clsContacts.RefreshData(false);
        //                    return;
        //                }
        //            }

        //            return;
        //        }




        //        // V2 - 12/9/2021:

        //        ShowFormNow("frmContact", "");




        //        //Form[] mdiChildren2 = base.MdiChildren;
        //        //for (int j = 0; j < mdiChildren2.Length; j++)
        //        //{
        //        //    Form form2 = mdiChildren2[j];
        //        //    if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //        //    {
        //        //        form2.BringToFrontHelper();
        //        //        clsContacts.RefreshData(false);
        //        //        return;
        //        //    }
        //        //}


        //    }
        //}


        //// V2 - 12/9/2021.

        //private void ShowFormNow(string formName, string formText)
        //{
        //    // V2 - 12/6/2021:

        //    FormCollection fc = Application.OpenForms;

        //    bool foundFormFlag = false;

        //    Form FormThatWasFound = null;

        //    foreach (Form frm in fc)
        //    {
        //        if (frm.Text == formText)
        //        {
        //            // We've found it!

        //            foundFormFlag = true;

        //            FormThatWasFound = frm;

        //            break;
        //        }

        //        if (frm.Name == formName)
        //        {
        //            // We've found it!

        //            foundFormFlag = true;

        //            FormThatWasFound = frm;

        //            break;
        //        }
        //    }

        //    if (foundFormFlag == false)
        //    {
        //        // The form is not present!
        //        // So start it up again!!!

        //        // V2 - 12/6/2021:

        //        switch(formName)
        //        {
        //            case "frmContact":
        //                {
        //                    LaunchContactForm();

        //                    break;
        //                }
        //        }
                

        //    }
        //    else
        //    {
        //        // Set it active!

        //        if (FormThatWasFound != null)
        //        {
        //            FormThatWasFound.Activate();

        //            FormThatWasFound.BringToFrontHelper();

        //            // Grant - 6/19/2022:
        //            clsContacts.RefreshData(false);
        //        }

        //    }

        //    return;
        //}



        //private void btnCompanies_Click(object sender, EventArgs e)
        //{
        //    this.frmShowing = 2;
        //    this.SetupLookup();
        //    Form[] mdiChildren = base.MdiChildren;
        //    checked
        //    {
        //        for (int i = 0; i < mdiChildren.Length; i++)
        //        {
        //            Form form = mdiChildren[i];
        //            if (Operators.CompareString(form.Name, MyProject.Forms.frmSearchGrid.Name, false) == 0)
        //            {
        //                form.BringToFront();
        //                return;
        //            }
        //        }
        //        this.AdvancedFind(false);
        //    }
        //}

        //private void btnCalendar_Click(object sender, EventArgs e)
        //{
        //    this.Cursor = Cursors.WaitCursor;
        //    this.frmShowing = 3;
        //    this.SetupLookup();

        //    Form[] mdiChildren = base.MdiChildren;

        //    checked
        //    {
        //        for (int i = 0; i < mdiChildren.Length; i++)
        //        {
        //            Form form = mdiChildren[i];

        //            if (Operators.CompareString(form.Name, MyProject.Forms.frmAreas.Name, false) == 0)
        //            {
        //                frmAreas expr_4A = (frmAreas)form;
        //                expr_4A.NoPCT = this.mnuNoOnAreas.Checked;
        //                expr_4A.BringToFront();
        //                this.Cursor = Cursors.Default;

        //                return;
        //            }
        //        }
        //        frmAreas frmAreas = new frmAreas();

        //        if (Common.CanUseForm(Conversions.ToString(frmAreas.Tag), false))
        //        {
        //            frmAreas.Icon = base.Icon;
        //            frmAreas.MdiParent = this;
        //            frmAreas.NoPCT = this.mnuNoOnAreas.Checked;
        //            frmAreas.Show();


        //            // V2 - 12/6/2021:
        //            base.LayoutMdi(MdiLayout.Cascade);



        //            this.Cursor = Cursors.Default;
        //        }
        //    }
        //}

        //private void btnTasks_Click(object sender, EventArgs e)
        //{
        //    this.frmShowing = 4;
        //    this.SetupLookup();
        //    Form[] mdiChildren = base.MdiChildren;
        //    checked
        //    {
        //        for (int i = 0; i < mdiChildren.Length; i++)
        //        {
        //            Form form = mdiChildren[i];
        //            if (Operators.CompareString(form.Name, MyProject.Forms.frmTasks.Name, false) == 0)
        //            {
        //                frmTasks frmTasks = (frmTasks)form;
        //                if (Common.CanUseForm("SEE_ALL_TASKS", true))
        //                {
        //                    frmTasks.RecordManager = this.cbTasks.Text;
        //                }
        //                frmTasks.LoadGrid();
        //                frmTasks.BringToFront();
        //                return;
        //            }
        //        }
        //        frmTasks frmTasks2 = new frmTasks();
        //        if (Common.CanUseForm(Conversions.ToString(frmTasks2.Tag), false))
        //        {
        //            frmTasks2.Icon = base.Icon;
        //            if (Common.CanUseForm("SEE_ALL_TASKS", true))
        //            {
        //                frmTasks2.RecordManager = this.cbTasks.Text;
        //            }
        //            frmTasks2.MdiParent = this;
        //            frmTasks2.Show();
        //        }
        //    }
        //}

        //public void SetupLookup()
        //{
        //    this.gbLegend.Visible = false;
        //    this.ckAllTasks.Visible = false;
        //    this.cbTasks.Visible = false;
        //    this.lblTasks.Visible = false;
        //    this.lblCalendar.Visible = false;
        //    this.cbCalendar.Visible = false;
        //    this.ForewardToolStripMenuItem.Visible = false;
        //    this.BackToolStripMenuItem.Visible = false;
        //    this.CustomerIssuesToolStripMenuItem.Visible = false;

        //    this.pictureBoxLogo.Visible = true;

        //    switch (this.frmShowing)
        //    {
        //        case 1:
        //            {
        //                this.CustomerIssuesToolStripMenuItem.Visible = true;
        //                this.dtLookup.Clear();
        //                SqlConnection sqlConnection = new SqlConnection();
        //                sqlConnection = Common.ConnectToSQL(false);
        //                string cmdText = "select distinct DisplayName, FieldName from CRMLookupFields";
        //                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
        //                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //                while (sqlDataReader.Read())
        //                {
        //                    DataRow dataRow = this.dtLookup.NewRow();
        //                    dataRow["DisplayName"] = sqlDataReader.GetString(0);
        //                    dataRow["FieldName"] = sqlDataReader.GetString(1);
        //                    this.dtLookup.Rows.Add(dataRow);
        //                }
        //                sqlCommand.Connection.Close();
        //                sqlConnection.Close();
        //                this.cbLookup.DataSource = this.dtLookup;
        //                this.cbLookup.DisplayMember = "DisplayName";
        //                this.cbLookup.ValueMember = "FieldName";
        //                this.cbLookup.Text = "";
        //                this.ForewardToolStripMenuItem.Visible = true;
        //                this.BackToolStripMenuItem.Visible = true;
        //                return;
        //            }
        //        case 2:
        //            {
        //                this.dtLookup.Clear();
        //                SqlConnection sqlConnection2 = new SqlConnection();
        //                sqlConnection2 = Common.ConnectToSQL(false);
        //                string cmdText2 = "select distinct DisplayName, FieldName from CRMLookupFields";
        //                SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection2);
        //                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
        //                while (sqlDataReader2.Read())
        //                {
        //                    DataRow dataRow2 = this.dtLookup.NewRow();
        //                    dataRow2["DisplayName"] = sqlDataReader2.GetString(0);
        //                    dataRow2["FieldName"] = sqlDataReader2.GetString(1);
        //                    this.dtLookup.Rows.Add(dataRow2);
        //                }
        //                sqlCommand2.Connection.Close();
        //                sqlConnection2.Close();
        //                this.cbLookup.DataSource = this.dtLookup;
        //                this.cbLookup.DisplayMember = "DisplayName";
        //                this.cbLookup.ValueMember = "FieldName";
        //                this.cbLookup.Text = "";
        //                return;
        //            }
        //        case 3:
        //        case 6:
        //            break;
        //        case 4:
        //            this.ckAllTasks.Visible = true;
        //            if (!Common.CanUseForm("SEE_ALL_TASKS", true))
        //            {
        //                this.lblTasks.Visible = false;
        //                this.cbTasks.Visible = false;
        //                return;
        //            }
        //            this.lblTasks.Visible = true;
        //            this.cbTasks.Visible = true;
        //            if (Operators.CompareString(this.cbTasks.Text, "", false) == 0)
        //            {
        //                if (Operators.CompareString(this.tmpRecManager, "", false) != 0)
        //                {
        //                    this.cbTasks.Text = this.tmpRecManager;
        //                    return;
        //                }
        //                this.cbTasks.Text = Common.IRUser;
        //                return;
        //            }
        //            break;
        //        case 5:
        //            if (Common.CanUseForm("SEE_ALL_TASKS", true))
        //            {
        //                this.lblCalendar.Visible = true;
        //                this.cbCalendar.Visible = true;
        //                if (Operators.CompareString(this.cbCalendar.Text, "", false) == 0)
        //                {
        //                    if (Operators.CompareString(this.tmpRecManager, "", false) != 0)
        //                    {
        //                        this.cbCalendar.Text = this.tmpRecManager;
        //                        return;
        //                    }
        //                    this.cbCalendar.Text = Common.IRUser;
        //                    return;
        //                }
        //            }
        //            else
        //            {
        //                this.lblCalendar.Visible = false;
        //                this.cbCalendar.Visible = false;
        //            }
        //            break;
        //        default:
        //            return;
        //    }
        //}

        //private void btnFind_Click(object sender, EventArgs e)
        //{
        //    this.Cursor = Cursors.WaitCursor;
        //    if (this.ckLookupAll.CheckState == CheckState.Checked)
        //    {
        //        this.ckLookupAll.CheckState = CheckState.Unchecked;
        //        this.cbLookup.Text = "";
        //        this.cbLookupData.Text = "";
        //    }
        //    string text = "";
        //    string text2 = "select ContactID from CRMCompany CO join CRMContact CN on CO.CompanyID = CN.CompanyID ";
        //    string text3;
        //    string text4;
        //    if (this.ckPartial.CheckState == CheckState.Checked)
        //    {
        //        text3 = "%" + this.cbLookupData.Text + "%";
        //        text4 = "like";
        //    }
        //    else
        //    {
        //        text3 = this.cbLookupData.Text;
        //        text4 = "=";
        //    }
        //    checked
        //    {
        //        if (Operators.ConditionalCompareObjectEqual(this.cbLookup.SelectedValue, "FullName", false))
        //        {
        //            int num = Strings.InStr(Strings.Trim(this.cbLookupData.Text), " ", CompareMethod.Binary);
        //            if (num <= 0)
        //            {
        //                Common.LastSearchSQL = "";
        //                Common.LastSearchWhere = "";
        //                this.Cursor = Cursors.Default;
        //                Interaction.MsgBox("Sorry no records matched your search criteria.", MsgBoxStyle.OkOnly, "No Records");
        //                return;
        //            }
        //            string text5 = Strings.Trim(Strings.Mid(this.cbLookupData.Text, 1, num));
        //            string text6 = Strings.Trim(Strings.Mid(this.cbLookupData.Text, num, text3.Length - num));
        //            if (this.ckPartial.CheckState == CheckState.Checked)
        //            {
        //                text5 = "%" + text5 + "%";
        //                text6 = "%" + text6 + "%";
        //                text4 = "like";
        //            }
        //            else
        //            {
        //                text4 = "=";
        //            }
        //            text = clsSQLSearches.setWhere(text, string.Concat(new string[]
        //            {
        //                "FirstName ",
        //                text4,
        //                " '",
        //                text5,
        //                "'"
        //            }));
        //            text = clsSQLSearches.setWhere(text, string.Concat(new string[]
        //            {
        //                "LastName ",
        //                text4,
        //                " '",
        //                text6,
        //                "'"
        //            }));
        //        }
        //        else if (Operators.ConditionalCompareObjectEqual(this.cbLookup.SelectedValue, "AREA", false))
        //        {
        //            SqlConnection connection = new SqlConnection();
        //            connection = Common.ConnectToSQL(false);
        //            SqlDataReader sqlDataReader = new SqlCommand(string.Concat(new string[]
        //            {
        //                "select GroupID from CRMGroup where Name ",
        //                text4,
        //                " '",
        //                text3,
        //                "' "
        //            }), connection).ExecuteReader();
        //            if (sqlDataReader.HasRows)
        //            {
        //                string text7 = "(";
        //                while (sqlDataReader.Read())
        //                {
        //                    text7 = text7 + "CO.GroupID = " + Conversions.ToString(sqlDataReader.GetInt32(0)) + " or ";
        //                }
        //                text7 = Strings.Mid(text7, 1, text7.Length - 3);
        //                text7 += ")";
        //                text = clsSQLSearches.setWhere(text, text7);
        //            }
        //        }
        //        else if (Operators.CompareString(Strings.Trim(this.cbLookupData.Text), "", false) != 0)
        //        {
        //            text = clsSQLSearches.setWhere(text, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.cbLookup.SelectedValue, " "), text4), " '"), text3), "'")));
        //        }
        //        if (!Common.CanUseForm("ALLCONTACTS", true) | this.ckShowAllContacts.CheckState == CheckState.Unchecked)
        //        {
        //            SqlConnection sqlConnection = new SqlConnection();
        //            sqlConnection = Common.ConnectToSQL(false);
        //            SqlCommand sqlCommand = new SqlCommand("Select UserLinkID from CRMUserLinks where UserID = '" + Common.IRUser + "' and LinkType = 1", sqlConnection);
        //            SqlDataReader sqlDataReader2 = sqlCommand.ExecuteReader();
        //            if (sqlDataReader2.HasRows)
        //            {
        //                string text8 = "(";
        //                while (sqlDataReader2.Read())
        //                {
        //                    text8 = text8 + "ManageUserID = '" + sqlDataReader2.GetString(0) + "' or ";
        //                }
        //                text8 = text8 + " ManageUserID = '" + Common.IRUser + "')";
        //                text = clsSQLSearches.setWhere(text, text8);
        //            }
        //            else
        //            {
        //                text = clsSQLSearches.setWhere(text, "ManageUserID = '" + Common.IRUser + "'");
        //            }
        //            sqlCommand.Connection.Close();
        //            sqlConnection.Close();
        //        }
        //        if (this.ckSecondary.CheckState == CheckState.Checked)
        //        {
        //            text = clsSQLSearches.setWhere(text, "PrimaryContact = 'True'");
        //        }
        //        if (this.ckHideInactive.CheckState == CheckState.Checked)
        //        {
        //            text = clsSQLSearches.setWhere(text, "ConStatus <> 'INACTIVE'");
        //        }

        //        Common.LastSearchSQL = text2;
        //        Common.LastSearchWhere = text;
        //        text2 += text;
        //        text2 += " order by CN.CompanyID";
        //        Common.LogEntryCRM(base.Name, "SEARCH", 0, 0, "CONTACT " + this.cbLookup.Text + " " + this.cbLookupData.Text);
        //        int num2 = Common.RecordCount(text2);

        //        if (num2 != 0)
        //        {
        //            if (num2 != 1)
        //            {
        //                this.frmShowing = 2;
        //                this.SetupLookup();
        //                Form[] mdiChildren = base.MdiChildren;
        //                for (int i = 0; i < mdiChildren.Length; i++)
        //                {
        //                    Form form = mdiChildren[i];
        //                    if (Operators.CompareString(form.Name, MyProject.Forms.frmSearchGrid.Name, false) == 0)
        //                    {
        //                        frmSearchGrid expr_645 = (frmSearchGrid)form;
        //                        expr_645.where = text;
        //                        expr_645.LoadGrid();
        //                        expr_645.BringToFront();
        //                        this.Cursor = Cursors.Default;
        //                        return;
        //                    }
        //                }
        //                frmSearchGrid frmSearchGrid = new frmSearchGrid();
        //                if (!Common.CanUseForm(Conversions.ToString(frmSearchGrid.Tag), false))
        //                {
        //                    return;
        //                }
        //                frmSearchGrid.Icon = base.Icon;
        //                frmSearchGrid.where = text;
        //                frmSearchGrid.MdiParent = this;
        //                frmSearchGrid.Show();
        //                frmSearchGrid.WindowState = FormWindowState.Minimized;
        //                frmSearchGrid.WindowState = FormWindowState.Maximized;
        //                this.Cursor = Cursors.Default;
        //            }
        //            else
        //            {
        //                this.frmShowing = 1;
        //                this.SetupLookup();
        //                Common.LastSearchSQL = "";
        //                Common.LastSearchWhere = "";
        //                if (Common.LaptopMonitor)
        //                {
        //                    Form[] mdiChildren2 = base.MdiChildren;

        //                    for (int j = 0; j < mdiChildren2.Length; j++)
        //                    {
        //                        Form form2 = mdiChildren2[j];

        //                        if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                        {
        //                            frmContactLaptop expr_54A = (frmContactLaptop)form2;

        //                            expr_54A.ContactID = Common.IntScalar(text2, false);
        //                            expr_54A.CompanyCount = 1;
        //                            clsContacts.RefreshData(false);
        //                            expr_54A.BringToFrontHelper();
        //                            this.Cursor = Cursors.Default;

        //                            return;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Form[] mdiChildren3 = base.MdiChildren;
        //                    for (int k = 0; k < mdiChildren3.Length; k++)
        //                    {
        //                        Form form3 = mdiChildren3[k];

        //                        if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                        {
        //                            frmContact expr_5C1 = (frmContact)form3;

        //                            expr_5C1.ContactID = Common.IntScalar(text2, false);
        //                            expr_5C1.CompanyCount = 1;
        //                            clsContacts.RefreshData(false);
        //                            expr_5C1.BringToFrontHelper();
        //                            this.Cursor = Cursors.Default;

        //                            return;
        //                        }
        //                    }
        //                }
        //            }
        //            this.Cursor = Cursors.Default;
        //            return;
        //        }
        //        Common.LastSearchSQL = "";
        //        Common.LastSearchWhere = "";
        //        this.Cursor = Cursors.Default;
        //        Interaction.MsgBox("Sorry no records matched your search criteria.", MsgBoxStyle.OkOnly, "No Records");
        //    }
        //}

        //private void AdvancedFind(bool Redo)
        //{
        //    string text;
        //    string text2;
        //    if (Redo)
        //    {
        //        text = Common.LastSearchSQL;
        //        text2 = Common.LastSearchWhere;
        //    }
        //    else
        //    {
        //        frmAdvancedFind frmAdvancedFind = new frmAdvancedFind();
        //        if (!Common.CanUseForm(Conversions.ToString(frmAdvancedFind.Tag), false))
        //        {
        //            return;
        //        }
        //        frmAdvancedFind.Icon = base.Icon;
        //        frmAdvancedFind.frmShowing = this.frmShowing;
        //        frmAdvancedFind.ShowDialog();
        //        if (frmAdvancedFind.DialogResult == DialogResult.Cancel)
        //        {
        //            return;
        //        }
        //        this.Cursor = Cursors.WaitCursor;
        //        text = frmAdvancedFind.SQLStr;
        //        text2 = frmAdvancedFind.Where;
        //    }
        //    if (!Common.CanUseForm("ALLCONTACTS", true) | this.ckShowAllContacts.CheckState == CheckState.Unchecked)
        //    {
        //        SqlConnection sqlConnection = new SqlConnection();
        //        sqlConnection = Common.ConnectToSQL(false);
        //        SqlCommand sqlCommand = new SqlCommand("Select UserLinkID from CRMUserLinks where UserID = '" + Common.IRUser + "' and LinkType = 1", sqlConnection);
        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        if (sqlDataReader.HasRows)
        //        {
        //            string text3 = "(";
        //            while (sqlDataReader.Read())
        //            {
        //                text3 = text3 + "ManageUserID = '" + sqlDataReader.GetString(0) + "' or ";
        //            }
        //            text3 = text3 + " ManageUserID = '" + Common.IRUser + "')";
        //            text2 = clsSQLSearches.setWhere(text2, text3);
        //        }
        //        else
        //        {
        //            text2 = clsSQLSearches.setWhere(text2, "ManageUserID = '" + Common.IRUser + "'");
        //        }
        //        sqlCommand.Connection.Close();
        //        sqlConnection.Close();
        //    }
        //    if (this.ckSecondary.CheckState == CheckState.Checked)
        //    {
        //        text2 = clsSQLSearches.setWhere(text2, "PrimaryContact = 'True'");
        //    }
        //    if (this.ckHideInactive.CheckState == CheckState.Checked)
        //    {
        //        text2 = clsSQLSearches.setWhere(text2, "ConStatus <> 'INACTIVE'");
        //    }
        //    text += text2;
        //    text += " order by CN.CompanyID";
        //    Common.LogEntryCRM(base.Name, "SEARCH", 0, 0, "CONTACT " + this.cbLookup.Text + " " + this.cbLookupData.Text);
        //    int num = Common.RecordCount(text);
        //    if (num == 0)
        //    {
        //        this.Cursor = Cursors.Default;
        //        Interaction.MsgBox("Sorry no records matched your search criteria.", MsgBoxStyle.OkOnly, "No Records");
        //        return;
        //    }
        //    checked
        //    {
        //        if (num != 1)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;
        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];
        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmSearchGrid.Name, false) == 0)
        //                {
        //                    frmSearchGrid expr_312 = (frmSearchGrid)form;
        //                    expr_312.where = text2;
        //                    expr_312.LoadGrid();
        //                    expr_312.BringToFront();
        //                    this.Cursor = Cursors.Default;
        //                    return;
        //                }
        //            }
        //            frmSearchGrid frmSearchGrid = new frmSearchGrid();
        //            if (!Common.CanUseForm(Conversions.ToString(frmSearchGrid.Tag), false))
        //            {
        //                return;
        //            }
        //            frmSearchGrid.Icon = base.Icon;
        //            frmSearchGrid.where = text2;
        //            frmSearchGrid.MdiParent = this;
        //            frmSearchGrid.Show();
        //            frmSearchGrid.WindowState = FormWindowState.Minimized;
        //            frmSearchGrid.WindowState = FormWindowState.Maximized;
        //            this.Cursor = Cursors.Default;
        //        }
        //        else if (Common.LaptopMonitor)
        //        {
        //            Form[] mdiChildren2 = base.MdiChildren;
        //            for (int j = 0; j < mdiChildren2.Length; j++)
        //            {
        //                Form form2 = mdiChildren2[j];

        //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                {
        //                    ((frmContactLaptop)form2).ContactID = Common.IntScalar(text, false);

        //                    clsContacts.RefreshData(false);
        //                    this.Cursor = Cursors.Default;

        //                    return;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Form[] mdiChildren3 = base.MdiChildren;
        //            for (int k = 0; k < mdiChildren3.Length; k++)
        //            {
        //                Form form3 = mdiChildren3[k];

        //                if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                {
        //                    ((frmContact)form3).ContactID = Common.IntScalar(text, false);

        //                    clsContacts.RefreshData(false);
        //                    this.Cursor = Cursors.Default;

        //                    return;
        //                }
        //            }
        //        }
        //        this.Cursor = Cursors.Default;
        //    }
        //}

        //private void btnAdvFind_Click(object sender, EventArgs e)
        //{
        //    if (this.ckLookupAll.CheckState == CheckState.Checked)
        //    {
        //        this.ckLookupAll.CheckState = CheckState.Unchecked;
        //    }
        //    this.AdvancedFind(false);
        //}

        //private void btnEblast_Click(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (Common.CanUseForm("Calendar", false))
        //        {
        //            this.frmShowing = 5;
        //            Form[] mdiChildren = base.MdiChildren;
        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];
        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmCalendar.Name, false) == 0)
        //                {
        //                    frmCalendar frmCalendar = new frmCalendar();
        //                    frmCalendar = (frmCalendar)form;
        //                    string value = "";

        //                    if (Common.LaptopMonitor)
        //                    {
        //                        new frmContactLaptop();

        //                        Form[] mdiChildren2 = base.MdiChildren;

        //                        for (int j = 0; j < mdiChildren2.Length; j++)
        //                        {
        //                            Form form2 = mdiChildren2[j];

        //                            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                            {
        //                                value = ((frmContactLaptop)form2).txtContactID.Text;

        //                                break;
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        new frmContact();

        //                        Form[] mdiChildren3 = base.MdiChildren;

        //                        for (int k = 0; k < mdiChildren3.Length; k++)
        //                        {
        //                            Form form3 = mdiChildren3[k];

        //                            if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                            {
        //                                value = ((frmContact)form3).txtContactID.Text;
        //                                break;
        //                            }
        //                        }
        //                    }

        //                    frmCalendar.ContactID = Conversions.ToInteger(value);

        //                    frmCalendar.GetCalendarItems();

        //                    frmCalendar.BringToFront();

        //                    this.SetupLookup();

        //                    return;
        //                }
        //            }

        //            frmCalendar frmCalendar2 = new frmCalendar();
        //            string value2 = "";
        //            string left = "";
        //            string text = "";

        //            if (Common.LaptopMonitor)
        //            {
        //                new frmContactLaptop();

        //                Form[] mdiChildren4 = base.MdiChildren;

        //                for (int l = 0; l < mdiChildren4.Length; l++)
        //                {
        //                    Form form4 = mdiChildren4[l];

        //                    if (Operators.CompareString(form4.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                    {
        //                        frmContactLaptop expr_1AB = (frmContactLaptop)form4;

        //                        value2 = expr_1AB.txtContactID.Text;
        //                        left = expr_1AB.txtCompanyID.Text;
        //                        text = expr_1AB.cbRecordManager.Text;

        //                        break;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                new frmContact();

        //                Form[] mdiChildren5 = base.MdiChildren;

        //                for (int m = 0; m < mdiChildren5.Length; m++)
        //                {
        //                    Form form5 = mdiChildren5[m];

        //                    if (Operators.CompareString(form5.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                    {
        //                        frmContact expr_225 = (frmContact)form5;

        //                        value2 = expr_225.txtContactID.Text;
        //                        left = expr_225.txtCompanyID.Text;
        //                        text = expr_225.cbRecordManager.Text;

        //                        break;
        //                    }
        //                }
        //            }

        //            int contactID = 0;

        //            if (Operators.CompareString(left, "", false) == 0)
        //            {
        //                this.tmpRecManager = Common.IRUser;
        //            }
        //            else
        //            {
        //                contactID = Conversions.ToInteger(value2);

        //                int num = Common.IntScalar("select count(*) from CRMUserLinks where UserID = '" + text + "' and LinkType = 2", false);

        //                if (num != 0)
        //                {
        //                    if (num != 1)
        //                    {
        //                        this.tmpRecManager = Common.idComboInput("Select driver", "select UserLinkID from CRMUserLinks where UserID = '" + text + "' and LinkType = 2", "UserLinkID", "UserLInkID", "", "Select Driver", "", "");
        //                    }
        //                    else
        //                    {
        //                        this.tmpRecManager = Common.StrScalar("select UserLinkID from CRMUserLinks where UserID = '" + text + "' and LinkType = 2", false);
        //                    }
        //                }
        //                else
        //                {
        //                    if (!Common.CanUseForm("SEE_ALL_TASKS", true))
        //                    {
        //                        Interaction.MsgBox("This record manager does not currently have an assigned driver.", MsgBoxStyle.Critical, "No Assigned Driver");
        //                        return;
        //                    }

        //                    frmCalendar2.RecordManager = Common.IRUser;
        //                }
        //            }

        //            frmCalendar2.AreaManager = text;
        //            frmCalendar2.RecordManager = this.tmpRecManager;
        //            frmCalendar2.ContactID = contactID;
        //            frmCalendar2.Icon = base.Icon;
        //            frmCalendar2.MdiParent = this;

        //            frmCalendar2.Show();

        //            this.SetupLookup();
        //        }
        //    }
        //}

        //private void EmailContentToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmEmailTemplate frmEmailTemplate = new frmEmailTemplate();
        //    if (Common.CanUseForm(Conversions.ToString(frmEmailTemplate.Tag), false))
        //    {
        //        frmEmailTemplate.Icon = base.Icon;
        //        frmEmailTemplate.ShowDialog();
        //    }
        //}

        //private void Timer1_Tick(object sender, EventArgs e)
        //{
        //    this.Timer1.Enabled = false;
        //    this.Text = "CRM Azure (" + Common.IRUser + ") v " + Common.SetVersionDate(MyProject.Application.Info.Version.ToString(), false);
        //    this.Timer1.Enabled = true;
        //}

        //private void UserLogToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmUserLogsGrid frmUserLogsGrid = new frmUserLogsGrid();
        //    if (Common.CanUseForm(Conversions.ToString(frmUserLogsGrid.Tag), false))
        //    {
        //        frmUserLogsGrid.Icon = base.Icon;
        //        frmUserLogsGrid.MdiParent = this;
        //        frmUserLogsGrid.Show();
        //    }
        //}

        //private void cbLookup_TextChanged(object sender, EventArgs e)
        //{
        //    if (Operators.CompareString(this.cbLookup.Text, "", false) == 0)
        //    {
        //        this.cbLookupData.Text = "";
        //    }
        //}

        //private void NoteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmHistoryType frmHistoryType = new frmHistoryType();
        //    if (Common.CanUseForm(Conversions.ToString(frmHistoryType.Tag), false))
        //    {
        //        frmHistoryType.Icon = base.Icon;
        //        frmHistoryType.ShowDialog();
        //    }
        //}

        //private void TaskTypeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmTaskType frmTaskType = new frmTaskType();
        //    if (Common.CanUseForm(Conversions.ToString(frmTaskType.Tag), false))
        //    {
        //        frmTaskType.Icon = base.Icon;
        //        frmTaskType.ShowDialog();
        //    }
        //}

        //private void LookupFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmLookupFields frmLookupFields = new frmLookupFields();
        //    if (Common.CanUseForm(Conversions.ToString(frmLookupFields.Tag), false))
        //    {
        //        frmLookupFields.Icon = base.Icon;
        //        frmLookupFields.ShowDialog();
        //    }
        //}

        //private void ImportsProspectsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmImport frmImport = new frmImport();
        //    if (Common.CanUseForm(Conversions.ToString(frmImport.Tag), false))
        //    {
        //        frmImport.Icon = base.Icon;
        //        frmImport.ShowDialog();
        //    }
        //}

        //private void Timer2_Tick(object sender, EventArgs e)
        //{
        //    this.Timer2.Enabled = false;

        //    ////////////////////////////////////if (Common.BitScalar("select CRMDataLoad from CompanyControl", false))
        //    ////////////////////////////////////{
        //    ////////////////////////////////////    this.Timer3.Enabled = true;

        //    ////////////////////////////////////    Interaction.MsgBox("System maintenance underway you must exit the application.", MsgBoxStyle.OkOnly, "System Maintenance");

        //    ////////////////////////////////////    base.Close();
        //    ////////////////////////////////////}

        //    ////////////////////////////////////this.Timer2.Enabled = true;
        //}

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        //private void Timer3_Tick(object sender, EventArgs e)
        //{
        //    //////////////////////////////////////ProjectData.EndApp();
        //}

        //private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmPasswordChange frmPasswordChange = new frmPasswordChange();
        //    if (Common.CanUseForm(Conversions.ToString(frmPasswordChange.Tag), false))
        //    {
        //        frmPasswordChange.Icon = base.Icon;
        //        frmPasswordChange.ShowDialog();
        //    }
        //}

        //private void DropDownsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmDropDowns frmDropDowns = new frmDropDowns();
        //    if (Common.CanUseForm(Conversions.ToString(frmDropDowns.Tag), false))
        //    {
        //        frmDropDowns.Icon = base.Icon;
        //        frmDropDowns.ShowDialog();
        //    }
        //}

        //private void cbLookup_SelectedIndexChanged(object sender, EventArgs e)
        //{
            //if (this.cbLookup.Focused)
            //{
            //    this.FillLookupData(Conversions.ToString(this.cbLookup.SelectedValue));
            //}
        //}

        //internal static uint ComputeStringHash(string s)
        //{
        //    uint num = 0;
        //    if (s != null)
        //    {
        //        num = 2166136261U;
        //        for (int index = 0; index < s.Length; ++index)
        //            num = (uint)((s[index] ^ (int)num) * 16777619);
        //    }
        //    return num;
        //}
        //private void FillLookupData(string LookupValue)
        //{
        //    string left = Common.StrScalar("select FieldType from CRMLookupFields where FieldName = '" + LookupValue + "'", false);
        //    if (Operators.CompareString(left, "TEXT", false) != 0)
        //    {
        //        if (Operators.CompareString(left, "COMB", false) == 0)
        //        {
        //            uint num = ComputeStringHash(LookupValue);
        //            if (num <= 2827817063u)
        //            {
        //                if (num <= 1805450078u)
        //                {
        //                    if (num <= 415739499u)
        //                    {
        //                        if (num != 173083532u)
        //                        {
        //                            if (num == 415739499u)
        //                            {
        //                                if (Operators.CompareString(LookupValue, "SICCode", false) == 0)
        //                                {
        //                                    idComboBox cbLookupData = this.cbLookupData;
        //                                    Common.FillCombo(ref cbLookupData, "select distinct SICCode from CRMCompany order by SICCode", "SICCode", "NONE");
        //                                    this.cbLookupData = cbLookupData;
        //                                }
        //                            }
        //                        }
        //                        else if (Operators.CompareString(LookupValue, "ManageUserID", false) == 0)
        //                        {
        //                            idComboBox cbLookupData = this.cbLookupData;
        //                            Common.FillCombo(ref cbLookupData, "select UserID from ManageUserCombo order by UserID", "UserID", "NONE");
        //                            this.cbLookupData = cbLookupData;
        //                        }
        //                    }
        //                    else if (num != 502047894u)
        //                    {
        //                        if (num == 1805450078u)
        //                        {
        //                            if (Operators.CompareString(LookupValue, "Competition2", false) == 0)
        //                            {
        //                                idComboBox cbLookupData = this.cbLookupData;
        //                                Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Competition 2' order by Name", "Name", "NONE");
        //                                this.cbLookupData = cbLookupData;
        //                            }
        //                        }
        //                    }
        //                    else if (Operators.CompareString(LookupValue, "State", false) == 0)
        //                    {
        //                        idComboBox cbLookupData = this.cbLookupData;
        //                        Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'States' order by Name", "Name", "NONE");
        //                        this.cbLookupData = cbLookupData;
        //                    }
        //                }
        //                else if (num <= 2422945378u)
        //                {
        //                    if (num != 2115578328u)
        //                    {
        //                        if (num == 2422945378u)
        //                        {
        //                            if (Operators.CompareString(LookupValue, "City", false) == 0)
        //                            {
        //                                idComboBox cbLookupData = this.cbLookupData;
        //                                Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Cities' order by Name", "Name", "NONE");
        //                                this.cbLookupData = cbLookupData;
        //                            }
        //                        }
        //                    }
        //                    else if (Operators.CompareString(LookupValue, "Competition", false) == 0)
        //                    {
        //                        idComboBox cbLookupData = this.cbLookupData;
        //                        Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Competition' order by Name", "Name", "NONE");
        //                        this.cbLookupData = cbLookupData;
        //                    }
        //                }
        //                else if (num != 2423721063u)
        //                {
        //                    if (num == 2827817063u)
        //                    {
        //                        if (Operators.CompareString(LookupValue, "CreateUserID", false) == 0)
        //                        {
        //                            idComboBox cbLookupData = this.cbLookupData;
        //                            Common.FillCombo(ref cbLookupData, "select UserID from ManageUserCombo order by UserID", "UserID", "NONE");
        //                            this.cbLookupData = cbLookupData;
        //                        }
        //                    }
        //                }
        //                else if (Operators.CompareString(LookupValue, "Department", false) == 0)
        //                {
        //                    idComboBox cbLookupData = this.cbLookupData;
        //                    Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Departments' order by Name", "Name", "NONE");
        //                    this.cbLookupData = cbLookupData;
        //                }
        //            }
        //            else if (num <= 3462902463u)
        //            {
        //                if (num <= 2947802513u)
        //                {
        //                    if (num != 2884173501u)
        //                    {
        //                        if (num == 2947802513u)
        //                        {
        //                            if (Operators.CompareString(LookupValue, "Category", false) == 0)
        //                            {
        //                                idComboBox cbLookupData = this.cbLookupData;
        //                                Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Company ID/Status' order by Name", "Name", "NONE");
        //                                this.cbLookupData = cbLookupData;
        //                            }
        //                        }
        //                    }
        //                    else if (Operators.CompareString(LookupValue, "ConStatus", false) == 0)
        //                    {
        //                        idComboBox cbLookupData = this.cbLookupData;
        //                        Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Contact ID/Status' order by Name", "Name", "NONE");
        //                        this.cbLookupData = cbLookupData;
        //                    }
        //                }
        //                else if (num != 3376168378u)
        //                {
        //                    if (num == 3462902463u)
        //                    {
        //                        if (Operators.CompareString(LookupValue, "Equipment2", false) == 0)
        //                        {
        //                            idComboBox cbLookupData = this.cbLookupData;
        //                            Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Equipment 2' order by Name", "Name", "NONE");
        //                            this.cbLookupData = cbLookupData;
        //                        }
        //                    }
        //                }
        //                else if (Operators.CompareString(LookupValue, "JobTitle", false) == 0)
        //                {
        //                    idComboBox cbLookupData = this.cbLookupData;
        //                    Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'jobtitles' order by Name", "Name", "NONE");
        //                    this.cbLookupData = cbLookupData;
        //                }
        //            }
        //            else if (num <= 4017444449u)
        //            {
        //                if (num != 3512062061u)
        //                {
        //                    if (num == 4017444449u)
        //                    {
        //                        if (Operators.CompareString(LookupValue, "Classification", false) == 0)
        //                        {
        //                            idComboBox cbLookupData = this.cbLookupData;
        //                            Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Classification' order by Name", "Name", "NONE");
        //                            this.cbLookupData = cbLookupData;
        //                        }
        //                    }
        //                }
        //                else if (Operators.CompareString(LookupValue, "Type", false) == 0)
        //                {
        //                    idComboBox cbLookupData = this.cbLookupData;
        //                    Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Type' order by Name", "Name", "NONE");
        //                    this.cbLookupData = cbLookupData;
        //                }
        //            }
        //            else if (num != 4104324905u)
        //            {
        //                if (num == 4222088599u)
        //                {
        //                    if (Operators.CompareString(LookupValue, "Equipment", false) == 0)
        //                    {
        //                        idComboBox cbLookupData = this.cbLookupData;
        //                        Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Equipment' order by Name", "Name", "NONE");
        //                        this.cbLookupData = cbLookupData;
        //                    }
        //                }
        //            }
        //            else if (Operators.CompareString(LookupValue, "ReferredBy", false) == 0)
        //            {
        //                idComboBox cbLookupData = this.cbLookupData;
        //                Common.FillCombo(ref cbLookupData, "select Name from CRMComboData where ComboName = 'Refered By' order by Name", "Name", "NONE");
        //                this.cbLookupData = cbLookupData;
        //            }
        //            this.cbLookupData.Text = "";
        //        }
        //    }
        //    else
        //    {
        //        this.cbLookupData.DataSource = null;
        //    }
        //    if (Operators.CompareString(LookupValue, "AssignmentDate", false) == 0)
        //    {
        //        this.ckPartial.CheckState = CheckState.Unchecked;
        //        this.ckPartial.Enabled = false;
        //        return;
        //    }
        //    this.ckPartial.Enabled = true;
        //}

        //private void cbLookupData_TextChanged(object sender, EventArgs e)
        //{
        //    base.AcceptButton = this.btnFind;
        //}

        //private void ApplicationControlToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmApplicationControl frmApplicationControl = new frmApplicationControl();
        //    if (Common.CanUseForm(Conversions.ToString(frmApplicationControl.Tag), false))
        //    {
        //        frmApplicationControl.Icon = base.Icon;
        //        frmApplicationControl.ShowDialog();
        //    }
        //}

        //private void ToDo_Tick(object sender, EventArgs e)
        //{
        //    clsEmailTracker.TrackEmail();
        //    this.ToDoPopup.Enabled = false;
        //    if (this.HoldCount >= 10)
        //    {
        //        Common.NonQuery("update CRMTasks set OnHold = 'False' where ManageUserID = '" + Common.IRUser + "'", false);
        //        this.HoldCount = 0;
        //    }
        //    if (Common.IntScalar(string.Concat(new string[]
        //    {
        //        "select count(*) from CRMTasks where ReminderTime <= '",
        //        Conversions.ToString(DateTime.Now),
        //        "' and ManageUserID = '",
        //        Common.IRUser,
        //        "' and OnHold = 'False' and TaskType = 2 and Deleted = 'False'"
        //    }), false) > 0)
        //    {
        //        new frmToDoPopup
        //        {
        //            Icon = base.Icon
        //        }.ShowDialog();
        //    }
        //    checked
        //    {
        //        this.HoldCount++;
        //        this.ToDoPopup.Enabled = true;
        //    }
        //}

        //private void MyPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmPreferences frmPreferences = new frmPreferences();
        //    if (Common.CanUseForm(Conversions.ToString(frmPreferences.Tag), false))
        //    {
        //        frmPreferences.Icon = base.Icon;
        //        frmPreferences.ShowDialog();
        //    }
        //}

        //private void ckAllTasks_CheckedChanged(object sender, EventArgs e)
        //{
        //    Form[] mdiChildren = base.MdiChildren;
        //    checked
        //    {
        //        for (int i = 0; i < mdiChildren.Length; i++)
        //        {
        //            Form form = mdiChildren[i];
        //            if (Operators.CompareString(form.Name, MyProject.Forms.frmTasks.Name, false) == 0)
        //            {
        //                frmTasks expr_32 = (frmTasks)form;
        //                expr_32.LoadGrid();
        //                expr_32.BringToFront();
        //                return;
        //            }
        //        }
        //    }
        //}

        //private void SalesTotalsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmRptSalesTotals frmRptSalesTotals = new frmRptSalesTotals();
        //    if (Common.CanUseForm(Conversions.ToString(frmRptSalesTotals.Tag), false))
        //    {
        //        frmRptSalesTotals.Icon = base.Icon;
        //        frmRptSalesTotals.ShowDialog();
        //    }
        //}

        //private void cbTasks_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (this.frmShowing == 4)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;
        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];
        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmTasks.Name, false) == 0)
        //                {
        //                    frmTasks frmTasks = (frmTasks)form;
        //                    if (Common.CanUseForm("SEE_ALL_TASKS", true))
        //                    {
        //                        frmTasks.RecordManager = this.cbTasks.Text;
        //                    }
        //                    frmTasks.LoadGrid();
        //                    frmTasks.BringToFront();
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void cbCalendar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (this.cbCalendar.Focused && this.frmShowing == 5)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;
        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];
        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmCalendar.Name, false) == 0)
        //                {
        //                    frmCalendar frmCalendar = (frmCalendar)form;
        //                    if (Common.CanUseForm("SEE_ALL_TASKS", true))
        //                    {
        //                        frmCalendar.RecordManager = this.cbCalendar.Text;
        //                    }
        //                    frmCalendar.AreaManager = "";
        //                    frmCalendar.GetCalendarItems();
        //                    frmCalendar.BringToFront();
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void LastLookupToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.AdvancedFind(true);
        //}

        //private void DataLoadToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmDataLoad().ShowDialog();
        //}

        //private void ForewardToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (Common.LastContactPosition + 1 <= 4 && Common.LastContacts[Common.LastContactPosition + 1] != 0)
        //        {
        //            if (Common.LaptopMonitor)
        //            {
        //                Form[] mdiChildren = base.MdiChildren;

        //                for (int i = 0; i < mdiChildren.Length; i++)
        //                {
        //                    Form form = mdiChildren[i];

        //                    if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                    {
        //                        frmContactLaptop expr_58 = (frmContactLaptop)form;

        //                        expr_58.ContactID = Common.LastContacts[Common.LastContactPosition + 1];
        //                        expr_58.CompanyCount = 1;
        //                        expr_58.TaskID = Common.LastTask[Common.LastContactPosition + 1];
        //                        expr_58.MovingBack = 2;

        //                        clsContacts.RefreshData(false);
        //                        expr_58.BringToFrontHelper();

        //                        return;
        //                    }
        //                }

        //                return;
        //            }

        //            Form[] mdiChildren2 = base.MdiChildren;

        //            for (int j = 0; j < mdiChildren2.Length; j++)
        //            {
        //                Form form2 = mdiChildren2[j];

        //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                {
        //                    frmContact expr_DA = (frmContact)form2;

        //                    expr_DA.ContactID = Common.LastContacts[Common.LastContactPosition + 1];
        //                    expr_DA.CompanyCount = 1;
        //                    expr_DA.TaskID = Common.LastTask[Common.LastContactPosition + 1];
        //                    expr_DA.MovingBack = 2;

        //                    clsContacts.RefreshData(false);
        //                    expr_DA.BringToFrontHelper();

        //                    return;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (Common.LastContactPosition != 0 && Common.LastContacts[Common.LastContactPosition] != 0)
        //        {
        //            if (Common.LaptopMonitor)
        //            {
        //                Form[] mdiChildren = base.MdiChildren;
        //                for (int i = 0; i < mdiChildren.Length; i++)
        //                {
        //                    Form form = mdiChildren[i];

        //                    if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                    {
        //                        frmContactLaptop expr_53 = (frmContactLaptop)form;

        //                        expr_53.ContactID = Common.LastContacts[Common.LastContactPosition - 1];
        //                        expr_53.CompanyCount = 1;
        //                        expr_53.TaskID = Common.LastTask[Common.LastContactPosition - 1];
        //                        expr_53.MovingBack = 1;

        //                        clsContacts.RefreshData(false);
        //                        expr_53.BringToFrontHelper();

        //                        return;
        //                    }
        //                }
        //                return;
        //            }
        //            Form[] mdiChildren2 = base.MdiChildren;
        //            for (int j = 0; j < mdiChildren2.Length; j++)
        //            {
        //                Form form2 = mdiChildren2[j];

        //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                {
        //                    frmContact expr_D5 = (frmContact)form2;

        //                    expr_D5.ContactID = Common.LastContacts[Common.LastContactPosition - 1];
        //                    expr_D5.CompanyCount = 1;
        //                    expr_D5.TaskID = Common.LastTask[Common.LastContactPosition - 1];
        //                    expr_D5.MovingBack = 1;

        //                    clsContacts.RefreshData(false);
        //                    expr_D5.BringToFrontHelper();

        //                    return;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void CallReportToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmRptCall frmRptCall = new frmRptCall();
        //    if (Common.CanUseForm(Conversions.ToString(frmRptCall.Tag), false))
        //    {
        //        frmRptCall.Icon = base.Icon;
        //        frmRptCall.ShowDialog();
        //    }
        //}

        //private void RefreshCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (this.frmShowing == 1)
        //        {
        //            object instance = null;

        //            if (Common.LaptopMonitor)
        //            {
        //                Form[] mdiChildren = base.MdiChildren;

        //                for (int i = 0; i < mdiChildren.Length; i++)
        //                {
        //                    Form form = mdiChildren[i];

        //                    if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                    {
        //                        instance = new frmContactLaptop();
        //                        instance = form;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                Form[] mdiChildren2 = base.MdiChildren;

        //                for (int j = 0; j < mdiChildren2.Length; j++)
        //                {
        //                    Form form2 = mdiChildren2[j];

        //                    if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                    {
        //                        instance = new frmContact();
        //                        instance = form2;
        //                    }
        //                }
        //            }
        //            try
        //            {
        //                NewLateBinding.LateCall(instance, null, "Updatepage", new object[0], null, null, null, true);
        //                clsContacts.RefreshData(true);
        //            }
        //            catch (Exception expr_BE)
        //            {
        //                ProjectData.SetProjectError(expr_BE);
        //                ProjectData.ClearProjectError();
        //            }
        //        }
        //    }
        //}

        //private void OpenRMAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.frmShowing = 1;
        //    this.SetupLookup();
        //    Form[] mdiChildren = base.MdiChildren;
        //    checked
        //    {
        //        for (int i = 0; i < mdiChildren.Length; i++)
        //        {
        //            Form form = mdiChildren[i];
        //            //form.Text = string.Empty;
                    
        //            if (Operators.CompareString(form.Name, MyProject.Forms.frmOpenRMA.Name, false) == 0)
        //            {
        //                frmOpenRMA expr_3F = (frmOpenRMA)form;
        //                expr_3F.LoadGrid();
        //                expr_3F.BringToFront();
        //                return;
        //            }
        //        }
        //        frmOpenRMA frmOpenRMA = new frmOpenRMA();
        //        if (Common.CanUseForm(Conversions.ToString(frmOpenRMA.Tag), false))
        //        {
        //           // frmOpenRMA.Text = string.Empty;
                
        //            frmOpenRMA.MdiParent = this;
        //            frmOpenRMA.Icon = base.Icon;
        //            frmOpenRMA.Show();
        //           //frmOpenRMA.BringToFrontHelper();
        //        }
        //    }
        //}

        //private void OpenQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.frmShowing = 1;
        //    this.SetupLookup();
        //    Form[] mdiChildren = base.MdiChildren;
        //    checked
        //    {
        //        for (int i = 0; i < mdiChildren.Length; i++)
        //        {
        //            Form form = mdiChildren[i];
        //            if (Operators.CompareString(form.Name, MyProject.Forms.frmOpenQuote.Name, false) == 0)
        //            {
        //                frmOpenQuote expr_3F = (frmOpenQuote)form;
        //                expr_3F.LoadGrid();
        //                expr_3F.BringToFront();
        //                return;
        //            }
        //        }
        //        frmOpenQuote frmOpenQuote = new frmOpenQuote();
        //        if (Common.CanUseForm(Conversions.ToString(frmOpenQuote.Tag), false))
        //        {
        //            frmOpenQuote.MdiParent = this;
        //            frmOpenQuote.Icon = base.Icon;
        //            frmOpenQuote.Show();
        //        }
        //    }
        //}

        //private void PickupsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.frmShowing = 1;
        //    this.SetupLookup();
        //    Form[] mdiChildren = base.MdiChildren;
        //    checked
        //    {
        //        for (int i = 0; i < mdiChildren.Length; i++)
        //        {
        //            Form form = mdiChildren[i];
        //            if (Operators.CompareString(form.Name, MyProject.Forms.frmPickups.Name, false) == 0)
        //            {
        //                frmPickups expr_3F = (frmPickups)form;
        //                expr_3F.LoadGrid();
        //                expr_3F.BringToFront();
        //                return;
        //            }
        //        }
        //        frmPickups frmPickups = new frmPickups();
        //        if (Common.CanUseForm(Conversions.ToString(frmPickups.Tag), false))
        //        {
        //            frmPickups.MdiParent = this;
        //            frmPickups.Icon = base.Icon;
        //            frmPickups.Show();
        //        }
        //    }
        //}

        //private void DeleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    object instance = null;
        //    checked
        //    {
        //        if (Common.LaptopMonitor)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;

        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];

        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                {
        //                    instance = new frmContactLaptop();
        //                    instance = form;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Form[] mdiChildren2 = base.MdiChildren;

        //            for (int j = 0; j < mdiChildren2.Length; j++)
        //            {
        //                Form form2 = mdiChildren2[j];

        //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                {
        //                    instance = new frmContact();
        //                    instance = form2;
        //                }
        //            }
        //        }

        //        NewLateBinding.LateCall(instance, null, "Updatepage", new object[0], null, null, null, true);

        //        if (Common.CanUseForm("DELETE CONTACT", true) && Interaction.MsgBox("This will delete the currently displayed contact.\rTHIS CANNOT BE UNDONE!\rAre you sure?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical | MsgBoxStyle.Question, "Delete Contact") == MsgBoxResult.Yes)
        //        {
        //            int num = Common.IntScalar(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(*) from CRMContact where CompanyID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
        //            if (num == 1)
        //            {
        //                if (Interaction.MsgBox("This is the only contact for this company do you want to delete the company as well?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Delete Company") != MsgBoxResult.Yes)
        //                {
        //                    Interaction.MsgBox("Sorry you cannot have a company with no contacts. Delete contact not allowed.", MsgBoxStyle.OkOnly, null);
        //                    return;
        //                }
        //                Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from CRMContact where ContactID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
        //                Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from CRMCompany where CompanyID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
        //            }
        //            else
        //            {
        //                Common.NonQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Delete from CRMContact where ContactID = ", NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "Text", new object[0], null, null, null)), "")), false);
        //            }
        //        }
        //        clsContacts.RefreshData(false);
        //    }
        //}

        //private void TodaysActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmTodaysActivities frmTodaysActivities = new frmTodaysActivities();
        //    if (Common.CanUseForm(Conversions.ToString(frmTodaysActivities.Tag), false))
        //    {
        //        frmTodaysActivities.Icon = base.Icon;
        //        frmTodaysActivities.ShowDialog();
        //    }
        //}

        //private void SalesRouteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmMapSalesRoute frmMapSalesRoute = new frmMapSalesRoute();
        //    if (Common.CanUseForm(Conversions.ToString(frmMapSalesRoute.Tag), false))
        //    {
        //        frmMapSalesRoute.Icon = base.Icon;
        //        frmMapSalesRoute.ShowDialog();
        //    }
        //}

        //private void CurrentCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (Common.CanUseForm("MAPPING", false))
        //        {
        //            this.frmShowing = 6;
        //            Form[] mdiChildren = base.MdiChildren;
        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];
        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmMainMap.Name, false) == 0)
        //                {
        //                    frmMainMap frmMainMap = new frmMainMap();
        //                    frmMainMap = (frmMainMap)form;
        //                    if (Common.LaptopMonitor)
        //                    {
        //                        new frmContactLaptop();

        //                        Form[] mdiChildren2 = base.MdiChildren;

        //                        for (int j = 0; j < mdiChildren2.Length; j++)
        //                        {
        //                            Form form2 = mdiChildren2[j];

        //                            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                            {
        //                                string arg_AB_0 = ((frmContactLaptop)form2).txtCompanyID.Text;
        //                                break;
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        new frmContact();

        //                        Form[] mdiChildren3 = base.MdiChildren;

        //                        for (int k = 0; k < mdiChildren3.Length; k++)
        //                        {
        //                            Form form3 = mdiChildren3[k];

        //                            if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                            {
        //                                string arg_107_0 = ((frmContact)form3).txtCompanyID.Text;

        //                                break;
        //                            }
        //                        }
        //                    }
        //                    frmMainMap.Close();
        //                }
        //            }

        //            object instance = null;

        //            if (Common.LaptopMonitor)
        //            {
        //                Form[] mdiChildren4 = base.MdiChildren;

        //                for (int l = 0; l < mdiChildren4.Length; l++)
        //                {
        //                    Form form4 = mdiChildren4[l];

        //                    if (Operators.CompareString(form4.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                    {
        //                        instance = new frmContactLaptop();
        //                        instance = form4;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                Form[] mdiChildren5 = base.MdiChildren;

        //                for (int m = 0; m < mdiChildren5.Length; m++)
        //                {
        //                    Form form5 = mdiChildren5[m];

        //                    if (Operators.CompareString(form5.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                    {
        //                        instance = new frmContact();
        //                        instance = form5;
        //                    }
        //                }
        //            }

        //            this.Cursor = Cursors.WaitCursor;
        //            this.frmShowing = 6;
        //            this.SetupLookup();

        //            frmMainMap frmMainMap2 = new frmMainMap();

        //            if (Common.CanUseForm(Conversions.ToString(frmMainMap2.Tag), false))
        //            {
        //                frmMainMap2.MdiParent = this;
        //                frmMainMap2.CompanyID = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //                frmMainMap2.MapType = "Company Location";
        //                frmMainMap2.Icon = base.Icon;

        //                frmMainMap2.Show();

        //                this.Cursor = Cursors.Default;
        //            }
        //        }
        //    }
        //}

        //private void cbLookup_Leave(object sender, EventArgs e)
        //{
        //    if (Conversions.ToBoolean(Operators.OrObject(Operators.AndObject(Operators.CompareObjectEqual(this.cbLookup.SelectedValue, "", false), Operators.CompareString(this.cbLookup.Text, "", false) != 0), Operators.CompareString(Strings.LCase(this.cbLookup.Text), "record manager", false) == 0)))
        //    {
        //        string lookupValue = Common.StrScalar("select FieldName from CRMLookupFields where DisplayName = '" + this.cbLookup.Text + "'", false);
        //        try
        //        {
        //            this.FillLookupData(lookupValue);
        //        }
        //        catch (Exception expr_92)
        //        {
        //            ProjectData.SetProjectError(expr_92);
        //            ProjectData.ClearProjectError();
        //        }
        //    }
        //}

        //private void UpdateLocalDataToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmLoadData().ShowDialog();
        //}

        //private string SetStatus(bool PartNeeded, DateTime PartNeededDate, bool RT, DateTime RTDate, bool PartsDue, DateTime PartsDueDate, bool RUR, DateTime RURDate, bool PartsRcvd, DateTime PartsRcvdDate, bool Evaluation, DateTime EvaluationDate, DateTime ApprovalDate, bool Approved, bool ReQuote, DateTime ReQuoteDate)
        //{
        //    string result = "REC";
        //    DateTime[] array = new DateTime[]
        //    {
        //        PartNeededDate,
        //        PartsRcvdDate,
        //        PartsDueDate,
        //        RURDate,
        //        RTDate,
        //        EvaluationDate,
        //        ApprovalDate,
        //        ReQuoteDate
        //    };
        //    Array.Sort<DateTime>(array);
        //    int num = 0;
        //    checked
        //    {
        //        do
        //        {
        //            if (DateTime.Compare(array[num], Conversions.ToDate("1/1/1900")) != 0)
        //            {
        //                if (DateTime.Compare(array[num], ApprovalDate) == 0 & Approved)
        //                {
        //                    result = "APP";
        //                }
        //                else if (DateTime.Compare(array[num], EvaluationDate) == 0 & Evaluation)
        //                {
        //                    result = "EVAL";
        //                }
        //                else if (DateTime.Compare(array[num], PartNeededDate) == 0 & PartNeeded)
        //                {
        //                    result = "P/N";
        //                }
        //                else if (DateTime.Compare(array[num], PartsDueDate) == 0 & PartsDue)
        //                {
        //                    result = "P/D";
        //                }
        //                else if (DateTime.Compare(array[num], PartsRcvdDate) == 0 & PartsRcvd)
        //                {
        //                    result = "P/R";
        //                }
        //                else if (DateTime.Compare(array[num], RTDate) == 0 & RT)
        //                {
        //                    result = "R&T";
        //                }
        //                else if (DateTime.Compare(array[num], RURDate) == 0 & RUR)
        //                {
        //                    result = "RUR";
        //                }
        //                else if (DateTime.Compare(array[num], ReQuoteDate) == 0 & ReQuote)
        //                {
        //                    result = "RQ";
        //                }
        //            }
        //            num++;
        //        }
        //        while (num <= 7);
        //        return result;
        //    }
        //}

        //private void IdButton1_Click(object sender, EventArgs e)
        //{
        //    checked
        //    {
        //        if (Common.CanUseForm("MAPPING", false))
        //        {
        //            this.frmShowing = 6;
        //            Form[] mdiChildren = base.MdiChildren;
        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];
        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmMainMap.Name, false) == 0)
        //                {
        //                    frmMainMap frmMainMap = new frmMainMap();
        //                    frmMainMap = (frmMainMap)form;
        //                    if (Common.LaptopMonitor)
        //                    {
        //                        new frmContactLaptop();

        //                        Form[] mdiChildren2 = base.MdiChildren;

        //                        for (int j = 0; j < mdiChildren2.Length; j++)
        //                        {
        //                            Form form2 = mdiChildren2[j];

        //                            if (Operators.CompareString(form2.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                            {
        //                                string arg_A6_0 = ((frmContactLaptop)form2).txtCompanyID.Text;

        //                                break;
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        new frmContact();

        //                        Form[] mdiChildren3 = base.MdiChildren;

        //                        for (int k = 0; k < mdiChildren3.Length; k++)
        //                        {
        //                            Form form3 = mdiChildren3[k];

        //                            if (Operators.CompareString(form3.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                            {
        //                                string arg_102_0 = ((frmContact)form3).txtCompanyID.Text;

        //                                break;
        //                            }
        //                        }
        //                    }
        //                    frmMainMap.BringToFrontHelper();
        //                    this.SetupLookup();
        //                    return;
        //                }
        //            }

        //            object instance = null;

        //            if (Common.LaptopMonitor)
        //            {
        //                Form[] mdiChildren4 = base.MdiChildren;

        //                for (int l = 0; l < mdiChildren4.Length; l++)
        //                {
        //                    Form form4 = mdiChildren4[l];

        //                    if (Operators.CompareString(form4.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                    {
        //                        instance = new frmContactLaptop();
        //                        instance = form4;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                Form[] mdiChildren5 = base.MdiChildren;

        //                for (int m = 0; m < mdiChildren5.Length; m++)
        //                {
        //                    Form form5 = mdiChildren5[m];

        //                    if (Operators.CompareString(form5.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                    {
        //                        instance = new frmContact();
        //                        instance = form5;
        //                    }
        //                }
        //            }

        //            this.Cursor = Cursors.WaitCursor;
        //            this.frmShowing = 6;
        //            this.SetupLookup();
        //            frmMainMap frmMainMap2 = new frmMainMap();

        //            if (Common.CanUseForm(Conversions.ToString(frmMainMap2.Tag), false))
        //            {
        //                frmMainMap2.MdiParent = this;
        //                frmMainMap2.CompanyID = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //                frmMainMap2.MapType = "Company Location";
        //                frmMainMap2.Icon = base.Icon;
        //                frmMainMap2.Show();
        //                this.Cursor = Cursors.Default;
        //            }
        //        }
        //    }
        //}

        //private void NotifyFrancieThatThisProspectIsGoingNowhereToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    object instance = null;
        //    checked
        //    {
        //        if (Common.LaptopMonitor)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;
        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];

        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                {
        //                    instance = new frmContactLaptop();
        //                    instance = form;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Form[] mdiChildren2 = base.MdiChildren;

        //            for (int j = 0; j < mdiChildren2.Length; j++)
        //            {
        //                Form form2 = mdiChildren2[j];

        //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                {
        //                    instance = new frmContact();
        //                    instance = form2;
        //                }
        //            }
        //        }

        //        int value = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //        int value2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //        string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "cbRecordManager", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //        frmTODONotes frmTODONotes = new frmTODONotes();
        //        frmTODONotes.Icon = base.Icon;
        //        frmTODONotes.Text = "Notes for Francie";
        //        frmTODONotes.ShowDialog();
        //        string text2 = frmTODONotes.txtNotes.Text;

        //        Common.NonQuery(string.Concat(new string[]
        //        {
        //            "insert into CRMCustIssues (CompanyID, ContactID, ManageUserID, MF, Notes, CreateDate, IssueStatus, CreateUserID) values  (",
        //            Conversions.ToString(value),
        //            ", ",
        //            Conversions.ToString(value2),
        //            ", '",
        //            text,
        //            "', 'F', '",
        //            text2,
        //            "', '",
        //            Conversions.ToString(DateTime.Now),
        //            "', 'False', '",
        //            Common.IRUser,
        //            "')"
        //        }), false);

        //        frmTODONotes.Close();
        //    }
        //}

        //private void NotifyMikeOfCustomerIssueToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    object instance = null;

        //    checked
        //    {
        //        if (Common.LaptopMonitor)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;

        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];

        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                {
        //                    instance = new frmContactLaptop();
        //                    instance = form;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Form[] mdiChildren2 = base.MdiChildren;

        //            for (int j = 0; j < mdiChildren2.Length; j++)
        //            {
        //                Form form2 = mdiChildren2[j];

        //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                {
        //                    instance = new frmContact();
        //                    instance = form2;
        //                }
        //            }
        //        }

        //        int value = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtCompanyID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //        int value2 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "txtContactID", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //        string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "cbRecordManager", new object[0], null, null, null), null, "text", new object[0], null, null, null));
        //        frmTODONotes frmTODONotes = new frmTODONotes();
        //        frmTODONotes.Icon = base.Icon;
        //        frmTODONotes.Text = "Notes for Mike";
        //        frmTODONotes.ShowDialog();
        //        string text2 = frmTODONotes.txtNotes.Text;

        //        Common.NonQuery(string.Concat(new string[]
        //        {
        //            "insert into CRMCustIssues (CompanyID, ContactID, ManageUserID, MF, Notes, CreateDate, IssueStatus, CreateUserID) values  (",
        //            Conversions.ToString(value),
        //            ",  ",
        //            Conversions.ToString(value2),
        //            ", '",
        //            text,
        //            "', 'M', '",
        //            text2,
        //            "', '",
        //            Conversions.ToString(DateTime.Now),
        //            "', 'False', '",
        //            Common.IRUser,
        //            "')"
        //        }), false);

        //        frmTODONotes.Close();
        //    }
        //}

        //private void FranciesListToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmCustIssues
        //    {
        //        Icon = base.Icon,
        //        MdiParent = this,
        //        Text = "Prospects going no where",
        //        MF = "F"
        //    }.Show();
        //}

        //private void MikesListToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmCustIssues
        //    {
        //        Icon = base.Icon,
        //        MdiParent = this,
        //        Text = "Customers with issues",
        //        MF = "M"
        //    }.Show();
        //}

        //private void ProductivityReportToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmProductivity
        //    {
        //        Icon = base.Icon
        //    }.ShowDialog();
        //}

        //private void HorseRaceToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmHorseRace
        //    {
        //        Icon = base.Icon
        //    }.ShowDialog();
        //}

        //private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    object instance = null;

        //    checked
        //    {
        //        if (Common.LaptopMonitor)
        //        {
        //            Form[] mdiChildren = base.MdiChildren;

        //            for (int i = 0; i < mdiChildren.Length; i++)
        //            {
        //                Form form = mdiChildren[i];

        //                if (Operators.CompareString(form.Name, MyProject.Forms.frmContactLaptop.Name, false) == 0)
        //                {
        //                    instance = new frmContactLaptop();
        //                    instance = form;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Form[] mdiChildren2 = base.MdiChildren;

        //            for (int j = 0; j < mdiChildren2.Length; j++)
        //            {
        //                Form form2 = mdiChildren2[j];

        //                if (Operators.CompareString(form2.Name, MyProject.Forms.frmContact.Name, false) == 0)
        //                {
        //                    instance = new frmContact();
        //                    instance = form2;
        //                }
        //            }
        //        }


        //        // V2 - 12/6/2021:
        //        //////NewLateBinding.LateCall(NewLateBinding.LateGet(instance, null, "txtSport", new object[0], null, null, null), null, "Focus", new object[0], null, null, null, true);
        //    }
        //}

        //private void TelemarketerNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmTMNewCust
        //    {
        //        Icon = base.Icon
        //    }.ShowDialog();
        //}

        //private void TelemarketerActivityToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    new frmTMActivity
        //    {
        //        Icon = base.Icon
        //    }.ShowDialog();
        //}

        //private void SpecialStuffToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmPassword expr_05 = new frmPassword();
        //    expr_05.Icon = base.Icon;
        //    expr_05.Text = "Enter Password";
        //    expr_05.ShowDialog();

        //    if (Operators.CompareString(expr_05.txtPassword.Text, "Kmc-159", false) == 0)
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        SqlConnection sqlConnection = new SqlConnection();
        //        sqlConnection = Common.ConnectToSQL(false);
        //        SqlCommand sqlCommand = new SqlCommand("Select TaskID from CRMTasks where CreateUserID = 'REBECCA.FALLON' and CreateDate > = '1/1/2015' and (TaskType = 6 or TaskType = 1 )", sqlConnection);
        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        while (sqlDataReader.Read())
        //        {
        //            long value = Common.Int64Scalar(("select HistoryID From CRMTasks T join CRMHistory H on T.CompanyID = H.CompanyID and T.ContactID = H.ContactID and T.ManageUserID = H.CreateUserID where (t.TaskType = 6 or T.TaskType = 1 ) and (Typeid = 110 or TypeID = 111 or TypeID = 112 or TypeID = 209 or TypeID = 210 or TypeID = 211 or TypeID = 212 or TypeID = 213 or TypeID = 214) and cast( t.StartTime as date) = cast(H.CreateDate as date) and T.TaskID = " + Conversions.ToString(sqlDataReader.GetInt32(0))) ?? "", false);
        //            Common.NonQuery(("update CRMHistory set TaskID = " + Conversions.ToString(sqlDataReader.GetInt32(0)) + " where HistoryID = " + Conversions.ToString(value)) ?? "", false);
        //        }
        //        sqlCommand.Connection.Close();
        //        sqlConnection.Close();
        //        this.Cursor = Cursors.Default;
        //    }
        //}

        private void SetVersionNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword expr_05 = new frmPassword();
            expr_05.Icon = base.Icon;
            expr_05.Text = "Enter Password";
            expr_05.ShowDialog();
            if (Operators.CompareString(expr_05.txtPassword.Text, "kmC-159", false) == 0)
            {
                this.Cursor = Cursors.WaitCursor;
                Common.NonQuery("update CompanyControl set CRMVersion = '" + MyProject.Application.Info.Version.ToString() + "'", false);
                this.Cursor = Cursors.Default;
            }
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Grant - 5/17/2022:
        // Dealing with Mapping Issue - SQLServer Types and Spatial
        // See:  https://localcoder.org/unable-to-load-sqlserverspatial-dll
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern IntPtr LoadLibrary(string libname);

        //private static void LoadNativeAssembly(string nativeBinaryPath, string assemblyName)
        //{
        //    var path = Path.Combine(nativeBinaryPath, assemblyName);

        //    if (!File.Exists(path))
        //    {
        //        throw new FileNotFoundException($"{path} not found");
        //    }

        //    var ptr = LoadLibrary(path);
        //    if (ptr == IntPtr.Zero)
        //    {
        //        throw new Exception(string.Format(
        //            "Error loading {0} (ErrorCode: {1})",
        //            assemblyName,
        //            Marshal.GetLastWin32Error()));
        //    }
        //}

        //public static void LoadNativeAssemblies(string rootApplicationPath)
        //{
        //    var nativeBinaryPath = Environment.Is64BitProcess
        //    ? Path.Combine(rootApplicationPath, @"SqlServerTypes\x64\")
        //    : Path.Combine(rootApplicationPath, @"SqlServerTypes\x86\");

        //    LoadNativeAssembly(nativeBinaryPath, "msvcr120.dll");
        //    LoadNativeAssembly(nativeBinaryPath, "SqlServerSpatial140.dll");
        //}
    }
}
