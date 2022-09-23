using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmPickups
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
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.IdGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnRefresh);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(721, 15);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 78);
            this.IdGroupBox1.TabIndex = 16;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Brown;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(6, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.Size = new System.Drawing.Size(98, 42);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(101, 12);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtStartDate.TabIndex = 17;
            this.dtStartDate.Tag = "HideOnDemand";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(376, 12);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtEndDate.TabIndex = 18;
            this.dtEndDate.Tag = "HideOnDemand";
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(19, 15);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(75, 16);
            this.IdLabel1.TabIndex = 43;
            this.IdLabel1.Text = "Start Date:";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(299, 15);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(70, 16);
            this.IdLabel2.TabIndex = 44;
            this.IdLabel2.Text = "End Date:";
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
            this.gridDetail.Location = new System.Drawing.Point(8, 59);
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.Size = new System.Drawing.Size(687, 385);
            this.gridDetail.TabIndex = 45;
            this.gridDetail.DoubleClick += new System.EventHandler(this.gridDetail_DoubleClick);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCount.Location = new System.Drawing.Point(554, 15);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(95, 16);
            this.lblCount.TabIndex = 53;
            this.lblCount.Text = "Pickup Count:";
            // 
            // frmPickups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.gridDetail);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmPickups";
            this.Tag = "PICKUP_REPORT";
            this.Text = "frmPickups";
            this.Load += new System.EventHandler(this.frmPickups_Load);
            this.IdGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.DataGridView gridDetail;
        private System.Windows.Forms.Label lblCount;
    }
}