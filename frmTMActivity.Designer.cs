using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmTMActivity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.lblRecordManager = new System.Windows.Forms.Label();
            this.cbTM = new System.Windows.Forms.ComboBox();
            this.IdGroupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            this.IdGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(246, 52);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 20);
            this.dtEnd.TabIndex = 143;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(140, 52);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 20);
            this.dtStart.TabIndex = 142;
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(89, 55);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(44, 16);
            this.IdLabel2.TabIndex = 141;
            this.IdLabel2.Text = "Dates";
            // 
            // txtCount
            // 
            this.txtCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtCount.Location = new System.Drawing.Point(469, 25);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(79, 23);
            this.txtCount.TabIndex = 140;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(363, 28);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(99, 16);
            this.IdLabel1.TabIndex = 139;
            this.IdLabel1.Text = "Record Count:";
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            this.gridDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetail.Location = new System.Drawing.Point(12, 91);
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.Size = new System.Drawing.Size(811, 391);
            this.gridDetail.TabIndex = 138;
            // 
            // lblRecordManager
            // 
            this.lblRecordManager.AutoSize = true;
            this.lblRecordManager.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRecordManager.Location = new System.Drawing.Point(42, 28);
            this.lblRecordManager.Name = "lblRecordManager";
            this.lblRecordManager.Size = new System.Drawing.Size(89, 16);
            this.lblRecordManager.TabIndex = 137;
            this.lblRecordManager.Text = "Telemarketer";
            // 
            // cbTM
            // 
            this.cbTM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTM.Font = new System.Drawing.Font("Arial", 10F);
            this.cbTM.FormattingEnabled = true;
            this.cbTM.Location = new System.Drawing.Point(140, 25);
            this.cbTM.Name = "cbTM";
            this.cbTM.Size = new System.Drawing.Size(206, 24);
            this.cbTM.TabIndex = 136;
            this.cbTM.SelectedIndexChanged += new System.EventHandler(this.cbRecordManager_SelectedIndexChanged);
            // 
            // IdGroupBox4
            // 
            this.IdGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox4.Controls.Add(this.cmdRefresh);
            this.IdGroupBox4.Controls.Add(this.btnCancel);
            this.IdGroupBox4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox4.Location = new System.Drawing.Point(595, 12);
            this.IdGroupBox4.Name = "IdGroupBox4";
            this.IdGroupBox4.Size = new System.Drawing.Size(228, 62);
            this.IdGroupBox4.TabIndex = 135;
            this.IdGroupBox4.TabStop = false;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.BackColor = System.Drawing.Color.Brown;
            this.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRefresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefresh.ForeColor = System.Drawing.Color.White;
            this.cmdRefresh.Location = new System.Drawing.Point(13, 13);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRefresh.Size = new System.Drawing.Size(98, 38);
            this.cmdRefresh.TabIndex = 90;
            this.cmdRefresh.Text = "&Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = false;
            this.cmdRefresh.Click += new System.EventHandler(this.gridDetail_DoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(117, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(98, 38);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTMActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(841, 494);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.gridDetail);
            this.Controls.Add(this.lblRecordManager);
            this.Controls.Add(this.cbTM);
            this.Controls.Add(this.IdGroupBox4);
            this.Name = "frmTMActivity";
            this.Tag = "TM ACTIVITY";
            this.Text = "Telemarketer Activity";
            this.Load += new System.EventHandler(this.frmTodaysActivities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            this.IdGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.TextBox txtCount;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label lblRecordManager;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.GroupBox IdGroupBox4;
        private System.Windows.Forms.ComboBox cbTM;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DataGridView gridDetail;
    }
}