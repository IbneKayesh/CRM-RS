using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmMapSalesRoute
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
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.lblRecordManager = new System.Windows.Forms.Label();
            this.cbRecordManager = new System.Windows.Forms.ComboBox();
            this.ManageUserComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserComboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnMap);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(360, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 116);
            this.IdGroupBox1.TabIndex = 12;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Brown;
            this.btnMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.Color.White;
            this.btnMap.Location = new System.Drawing.Point(6, 61);
            this.btnMap.Name = "btnMap";
            this.btnMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMap.Size = new System.Drawing.Size(98, 42);
            this.btnMap.TabIndex = 3;
            this.btnMap.Text = "&Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(6, 13);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(242, 52);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 20);
            this.dtEnd.TabIndex = 139;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(136, 52);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 20);
            this.dtStart.TabIndex = 138;
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(85, 55);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(45, 16);
            this.IdLabel2.TabIndex = 137;
            this.IdLabel2.Text = "Dates";
            // 
            // lblRecordManager
            // 
            this.lblRecordManager.AutoSize = true;
            this.lblRecordManager.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRecordManager.Location = new System.Drawing.Point(16, 28);
            this.lblRecordManager.Name = "lblRecordManager";
            this.lblRecordManager.Size = new System.Drawing.Size(114, 16);
            this.lblRecordManager.TabIndex = 136;
            this.lblRecordManager.Text = "Record Manager";
            // 
            // cbRecordManager
            // 
            this.cbRecordManager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbRecordManager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRecordManager.DataSource = this.ManageUserComboBindingSource;
            this.cbRecordManager.DisplayMember = "UserID";
            this.cbRecordManager.Font = new System.Drawing.Font("Arial", 10F);
            this.cbRecordManager.FormattingEnabled = true;
            this.cbRecordManager.Location = new System.Drawing.Point(136, 25);
            this.cbRecordManager.Name = "cbRecordManager";
            this.cbRecordManager.Size = new System.Drawing.Size(206, 24);
            this.cbRecordManager.TabIndex = 135;
            this.cbRecordManager.ValueMember = "UserID";
            // 
            // ManageUserComboBindingSource
            // 
            this.ManageUserComboBindingSource.DataMember = "ManageUserCombo";
            // 
            // frmMapSalesRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(486, 145);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.lblRecordManager);
            this.Controls.Add(this.cbRecordManager);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmMapSalesRoute";
            this.Tag = "MAPPING";
            this.Text = "Map Sales Route";
            this.Load += new System.EventHandler(this.frmMapSalesRoute_Load);
            this.IdGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserComboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.BindingSource ManageUserComboBindingSource;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label lblRecordManager;
        private System.Windows.Forms.ComboBox cbRecordManager;
    }
}