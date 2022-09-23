using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmUserLogsGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UserLogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.IdDataGridView1 = new System.Windows.Forms.DataGridView();
            this.CRMUserLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IRDataSet = new System.Data.DataSet();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.dtLogDate = new System.Windows.Forms.DateTimePicker();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMUserLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BindingNavigatorAddNewItem
            // 
            this.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorAddNewItem.Text = "Add new";
            this.BindingNavigatorAddNewItem.Visible = false;
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.BindingNavigatorCountItem.Text = "of {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorDeleteItem.Text = "Delete";
            this.BindingNavigatorDeleteItem.Visible = false;
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // UserLogBindingNavigatorSaveItem
            // 
            this.UserLogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UserLogBindingNavigatorSaveItem.Name = "UserLogBindingNavigatorSaveItem";
            this.UserLogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.UserLogBindingNavigatorSaveItem.Text = "Save Data";
            this.UserLogBindingNavigatorSaveItem.Visible = false;
            // 
            // IdDataGridView1
            // 
            this.IdDataGridView1.AllowUserToAddRows = false;
            this.IdDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            this.IdDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.IdDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdDataGridView1.AutoGenerateColumns = false;
            this.IdDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IdDataGridView1.DataSource = this.CRMUserLogBindingSource;
            this.IdDataGridView1.Location = new System.Drawing.Point(13, 78);
            this.IdDataGridView1.Name = "IdDataGridView1";
            this.IdDataGridView1.ReadOnly = true;
            this.IdDataGridView1.Size = new System.Drawing.Size(1156, 556);
            this.IdDataGridView1.TabIndex = 1;
            // 
            // CRMUserLogBindingSource
            // 
            this.CRMUserLogBindingSource.DataSource = this.IRDataSet;
            this.CRMUserLogBindingSource.Position = 0;
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "IRDataSet";
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(13, 14);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(36, 16);
            this.IdLabel1.TabIndex = 2;
            this.IdLabel1.Text = "User";
            // 
            // cbUser
            // 
            this.cbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUser.Font = new System.Drawing.Font("Arial", 10F);
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(57, 10);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(195, 24);
            this.cbUser.TabIndex = 3;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // dtLogDate
            // 
            this.dtLogDate.Location = new System.Drawing.Point(557, 11);
            this.dtLogDate.Name = "dtLogDate";
            this.dtLogDate.Size = new System.Drawing.Size(100, 20);
            this.dtLogDate.TabIndex = 4;
            this.dtLogDate.ValueChanged += new System.EventHandler(this.dtLogDate_EditValueChanged);
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(437, 14);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(99, 16);
            this.IdLabel2.TabIndex = 5;
            this.IdLabel2.Text = "Log entries for";
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnView);
            this.IdGroupBox1.Controls.Add(this.btnCLose);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(954, 10);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(215, 62);
            this.IdGroupBox1.TabIndex = 10;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Brown;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(6, 14);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnView.Size = new System.Drawing.Size(98, 42);
            this.btnView.TabIndex = 5;
            this.btnView.Tag = "";
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Brown;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Location = new System.Drawing.Point(110, 14);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCLose.Size = new System.Drawing.Size(98, 42);
            this.btnCLose.TabIndex = 4;
            this.btnCLose.Tag = "";
            this.btnCLose.Text = "&Close";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmUserLogsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1198, 660);
            this.Controls.Add(this.IdGroupBox1);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.dtLogDate);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.IdDataGridView1);
            this.Name = "frmUserLogsGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "UserLog";
            this.Text = "User Logs";
            this.Load += new System.EventHandler(this.frmUserLogsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMUserLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton BindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton UserLogBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView IdDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManageUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource CRMUserLogBindingSource;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.DateTimePicker dtLogDate;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Timer Timer1;
        private System.Data.DataSet IRDataSet;
    }
}