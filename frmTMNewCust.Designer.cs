using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmTMNewCust
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
            this.IdGroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbTM = new System.Windows.Forms.ComboBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.IdGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdGroupBox4
            // 
            this.IdGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox4.Controls.Add(this.btnPrint);
            this.IdGroupBox4.Controls.Add(this.btnPreview);
            this.IdGroupBox4.Controls.Add(this.btnCancel);
            this.IdGroupBox4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox4.Location = new System.Drawing.Point(365, 12);
            this.IdGroupBox4.Name = "IdGroupBox4";
            this.IdGroupBox4.Size = new System.Drawing.Size(109, 148);
            this.IdGroupBox4.TabIndex = 101;
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
            // cbTM
            // 
            this.cbTM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTM.Font = new System.Drawing.Font("Arial", 10F);
            this.cbTM.FormattingEnabled = true;
            this.cbTM.Location = new System.Drawing.Point(126, 24);
            this.cbTM.Name = "cbTM";
            this.cbTM.Size = new System.Drawing.Size(206, 24);
            this.cbTM.TabIndex = 134;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(232, 54);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 20);
            this.dtEnd.TabIndex = 136;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(28, 27);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(89, 16);
            this.IdLabel1.TabIndex = 132;
            this.IdLabel1.Text = "Telemarketer";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(126, 54);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 20);
            this.dtStart.TabIndex = 135;
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(75, 57);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(44, 16);
            this.IdLabel2.TabIndex = 133;
            this.IdLabel2.Text = "Dates";
            // 
            // IdLabel3
            // 
            this.IdLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel3.Location = new System.Drawing.Point(13, 92);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(319, 80);
            this.IdLabel3.TabIndex = 137;
            this.IdLabel3.Text = "CAUTION: This report uses extreme database resources. DO NOT run during normal bu" +
    "siness hours.  It will drastically slow down the IR2 and CRM applications. ";
            this.IdLabel3.Visible = false;
            // 
            // frmTMNewCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(486, 181);
            this.Controls.Add(this.IdLabel3);
            this.Controls.Add(this.cbTM);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.IdGroupBox4);
            this.Name = "frmTMNewCust";
            this.Tag = "TM NEW CUSTOMERS";
            this.Text = "Telemarketer New Customers";
            this.Click += new System.EventHandler(this.frmTMNewCust_Load);
            this.IdGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label IdLabel3;

        private System.Windows.Forms.GroupBox IdGroupBox4;

        private System.Windows.Forms.ComboBox cbTM;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
    }
}