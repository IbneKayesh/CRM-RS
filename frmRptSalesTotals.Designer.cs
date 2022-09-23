using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmRptSalesTotals
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
            this.IdGroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckDetail = new System.Windows.Forms.CheckBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.cbSalesperson = new System.Windows.Forms.ComboBox();
            this.SalesPersonComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.cbCustomerClass = new System.Windows.Forms.ComboBox();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.IdGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IdGroupBox4
            // 
            this.IdGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox4.Controls.Add(this.btnPrint);
            this.IdGroupBox4.Controls.Add(this.btnPreview);
            this.IdGroupBox4.Controls.Add(this.btnCancel);
            this.IdGroupBox4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox4.Location = new System.Drawing.Point(380, 12);
            this.IdGroupBox4.Name = "IdGroupBox4";
            this.IdGroupBox4.Size = new System.Drawing.Size(109, 148);
            this.IdGroupBox4.TabIndex = 98;
            this.IdGroupBox4.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Brown;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(5, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(98, 38);
            this.btnPrint.TabIndex = 116;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Brown;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(5, 56);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPreview.Size = new System.Drawing.Size(98, 38);
            this.btnPreview.TabIndex = 88;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(5, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(98, 38);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckDetail
            // 
            this.ckDetail.AutoSize = true;
            this.ckDetail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckDetail.Font = new System.Drawing.Font("Arial", 10F);
            this.ckDetail.Location = new System.Drawing.Point(110, 112);
            this.ckDetail.Name = "ckDetail";
            this.ckDetail.Size = new System.Drawing.Size(62, 20);
            this.ckDetail.TabIndex = 124;
            this.ckDetail.Text = "Detail";
            this.ckDetail.UseVisualStyleBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(264, 84);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 20);
            this.dtEnd.TabIndex = 122;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(158, 84);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 20);
            this.dtStart.TabIndex = 121;
            // 
            // cbSalesperson
            // 
            this.cbSalesperson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSalesperson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSalesperson.DataSource = this.SalesPersonComboBindingSource;
            this.cbSalesperson.DisplayMember = "Name";
            this.cbSalesperson.Font = new System.Drawing.Font("Arial", 10F);
            this.cbSalesperson.FormattingEnabled = true;
            this.cbSalesperson.Location = new System.Drawing.Point(158, 24);
            this.cbSalesperson.Name = "cbSalesperson";
            this.cbSalesperson.Size = new System.Drawing.Size(206, 24);
            this.cbSalesperson.TabIndex = 120;
            this.cbSalesperson.ValueMember = "SalesPersonNo";
            // 
            // SalesPersonComboBindingSource
            // 
            this.SalesPersonComboBindingSource.DataMember = "SalesPersonCombo";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(107, 87);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(44, 16);
            this.IdLabel2.TabIndex = 118;
            this.IdLabel2.Text = "Dates";
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(65, 24);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(86, 16);
            this.IdLabel1.TabIndex = 117;
            this.IdLabel1.Text = "Salesperson";
            // 
            // cbCustomerClass
            // 
            this.cbCustomerClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCustomerClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomerClass.Font = new System.Drawing.Font("Arial", 10F);
            this.cbCustomerClass.FormattingEnabled = true;
            this.cbCustomerClass.Items.AddRange(new object[] {
            "ALL",
            "END USER",
            "DISTRIBUTOR"});
            this.cbCustomerClass.Location = new System.Drawing.Point(158, 54);
            this.cbCustomerClass.Name = "cbCustomerClass";
            this.cbCustomerClass.Size = new System.Drawing.Size(206, 24);
            this.cbCustomerClass.TabIndex = 126;
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel3.Location = new System.Drawing.Point(44, 54);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(107, 16);
            this.IdLabel3.TabIndex = 125;
            this.IdLabel3.Text = "Customer Class";
            // 
            // frmRptSalesTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(501, 178);
            this.Controls.Add(this.cbCustomerClass);
            this.Controls.Add(this.IdLabel3);
            this.Controls.Add(this.ckDetail);
            this.Controls.Add(this.IdGroupBox4);
            this.Controls.Add(this.cbSalesperson);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.IdLabel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptSalesTotals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SalesTotalsRpt";
            this.Text = "Sales Totals";
            this.Load += new System.EventHandler(this.frmRptSalesTotals_Load);
            this.IdGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonComboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.GroupBox IdGroupBox4;
        private System.Windows.Forms.ComboBox cbSalesperson;
        private System.Windows.Forms.ComboBox cbCustomerClass;
        private System.Windows.Forms.CheckBox ckDetail;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.BindingSource SalesPersonComboBindingSource;
    }
}