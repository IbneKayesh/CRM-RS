using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmToDoPopup
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.cbAlarm = new System.Windows.Forms.ComboBox();
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.IdContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MarkAsCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PostponeUntilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            this.IdContextMenuStrip1.SuspendLayout();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Interval = 60000;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(669, 132);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(79, 16);
            this.IdLabel1.TabIndex = 15;
            this.IdLabel1.Text = "Snooze for:";
            // 
            // cbAlarm
            // 
            this.cbAlarm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbAlarm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAlarm.Font = new System.Drawing.Font("Arial", 10F);
            this.cbAlarm.FormattingEnabled = true;
            this.cbAlarm.Items.AddRange(new object[] {
            "5 Minutes",
            "15 Minutes",
            "30 Minutes",
            "60 Minutes"});
            this.cbAlarm.Location = new System.Drawing.Point(669, 151);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(121, 24);
            this.cbAlarm.TabIndex = 14;
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            this.gridDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetail.ContextMenuStrip = this.IdContextMenuStrip1;
            this.gridDetail.Location = new System.Drawing.Point(13, 34);
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.Size = new System.Drawing.Size(645, 359);
            this.gridDetail.TabIndex = 13;
            // 
            // IdContextMenuStrip1
            // 
            this.IdContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarkAsCompletedToolStripMenuItem,
            this.PostponeUntilToolStripMenuItem,
            this.OpenContactToolStripMenuItem});
            this.IdContextMenuStrip1.Name = "IdContextMenuStrip1";
            this.IdContextMenuStrip1.Size = new System.Drawing.Size(176, 70);
            // 
            // MarkAsCompletedToolStripMenuItem
            // 
            this.MarkAsCompletedToolStripMenuItem.Name = "MarkAsCompletedToolStripMenuItem";
            this.MarkAsCompletedToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.MarkAsCompletedToolStripMenuItem.Text = "Mark as completed";
            this.MarkAsCompletedToolStripMenuItem.Click += new System.EventHandler(this.MarkAsCompletedToolStripMenuItem_Click);
            // 
            // PostponeUntilToolStripMenuItem
            // 
            this.PostponeUntilToolStripMenuItem.Name = "PostponeUntilToolStripMenuItem";
            this.PostponeUntilToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.PostponeUntilToolStripMenuItem.Text = "Postpone until...";
            this.PostponeUntilToolStripMenuItem.Click += new System.EventHandler(this.PostponeUntilToolStripMenuItem_Click);
            // 
            // OpenContactToolStripMenuItem
            // 
            this.OpenContactToolStripMenuItem.Name = "OpenContactToolStripMenuItem";
            this.OpenContactToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.OpenContactToolStripMenuItem.Text = "Open Contact";
            this.OpenContactToolStripMenuItem.Click += new System.EventHandler(this.OpenContactToolStripMenuItem_Click);
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(676, 34);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 73);
            this.IdGroupBox1.TabIndex = 12;
            this.IdGroupBox1.TabStop = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(6, 22);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Snooze All";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmToDoPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(802, 405);
            this.ControlBox = false;
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.cbAlarm);
            this.Controls.Add(this.gridDetail);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmToDoPopup";
            this.Text = "To Do Alarm";
            this.Load += new System.EventHandler(this.frmToDoPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            this.IdContextMenuStrip1.ResumeLayout(false);
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.ComboBox cbAlarm;
        private System.Windows.Forms.DataGridView gridDetail;
        private System.Windows.Forms.ContextMenuStrip IdContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MarkAsCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PostponeUntilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenContactToolStripMenuItem;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button cmdCancel;
    }
}