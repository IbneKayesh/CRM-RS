using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmProductivity
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
            this.cbRecordManager = new System.Windows.Forms.ComboBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdGroupBox4.SuspendLayout();
            base.SuspendLayout();
            this.IdGroupBox4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.IdGroupBox4.Controls.Add(this.btnPrint);
            this.IdGroupBox4.Controls.Add(this.btnPreview);
            this.IdGroupBox4.Controls.Add(this.btnCancel);
            this.IdGroupBox4.Font = new Font("Arial", 10f);
            this.IdGroupBox4.Location = new Point(380, 12);
            this.IdGroupBox4.Name = "IdGroupBox4";
            this.IdGroupBox4.Size = new Size(109, 148);
            this.IdGroupBox4.TabIndex = 100;
            this.IdGroupBox4.TabStop = false;
            this.btnPrint.BackColor = Color.Brown;
            this.btnPrint.FlatStyle = FlatStyle.Flat;
            this.btnPrint.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.ForeColor = Color.White;
            this.btnPrint.Location = new Point(5, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new Size(98, 38);
            this.btnPrint.TabIndex = 116;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPreview.BackColor = Color.Brown;
            this.btnPreview.FlatStyle = FlatStyle.Flat;
            this.btnPreview.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPreview.ForeColor = Color.White;
            this.btnPreview.Location = new Point(5, 56);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPreview.Size = new Size(98, 38);
            this.btnPreview.TabIndex = 88;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnCancel.BackColor = Color.Brown;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(5, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new Size(98, 38);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.cbRecordManager.AutoCompleteMode = AutoCompleteMode.Append;
            this.cbRecordManager.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cbRecordManager.DisplayMember = "UserID";
            this.cbRecordManager.Font = new Font("Arial", 10f);
            this.cbRecordManager.FormattingEnabled = true;
            this.cbRecordManager.Location = new Point(148, 24);
            this.cbRecordManager.Name = "cbRecordManager";
            this.cbRecordManager.Size = new Size(206, 24);
            this.cbRecordManager.TabIndex = 134;
            this.cbRecordManager.ValueMember = "UserID";
            this.cbRecordManager.Visible = false;
            this.dtEnd.Location = new Point(254, 54);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new Size(100, 22);
            this.dtEnd.TabIndex = 136;
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new Font("Arial", 10f);
            this.IdLabel1.Location = new Point(28, 27);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new Size(114, 16);
            this.IdLabel1.TabIndex = 132;
            this.IdLabel1.Text = "Record Manager";
            this.IdLabel1.Visible = false;
            this.dtStart.Location = new Point(148, 54);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new Size(100, 22);
            this.dtStart.TabIndex = 135;
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new Font("Arial", 10f);
            this.IdLabel2.Location = new Point(97, 57);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new Size(45, 16);
            this.IdLabel2.TabIndex = 133;
            this.IdLabel2.Text = "Dates";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Tan;
            base.ClientSize = new Size(501, 178);
            base.Controls.Add(this.cbRecordManager);
            base.Controls.Add(this.dtEnd);
            base.Controls.Add(this.IdLabel1);
            base.Controls.Add(this.dtStart);
            base.Controls.Add(this.IdLabel2);
            base.Controls.Add(this.IdGroupBox4);
            base.Name = "frmProductivity";
            this.Text = "Productivity";
            this.IdGroupBox4.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox IdGroupBox4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label IdLabel2; 
        private System.Windows.Forms.ComboBox cbRecordManager;
    }
}