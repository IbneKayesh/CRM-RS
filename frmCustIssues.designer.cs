using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmCustIssues
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdGOTO = new System.Windows.Forms.Button();
            this.cmdComplete = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(13, 12);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(764, 437);
            this.gridData.TabIndex = 17;
            this.gridData.DoubleClick += new System.EventHandler(this.gridData_DoubleClick);
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.cmdGOTO);
            this.IdGroupBox1.Controls.Add(this.cmdComplete);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(796, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 167);
            this.IdGroupBox1.TabIndex = 16;
            this.IdGroupBox1.TabStop = false;
            // 
            // cmdGOTO
            // 
            this.cmdGOTO.BackColor = System.Drawing.Color.Brown;
            this.cmdGOTO.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGOTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGOTO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGOTO.ForeColor = System.Drawing.Color.White;
            this.cmdGOTO.Location = new System.Drawing.Point(8, 63);
            this.cmdGOTO.Name = "cmdGOTO";
            this.cmdGOTO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGOTO.Size = new System.Drawing.Size(98, 42);
            this.cmdGOTO.TabIndex = 3;
            this.cmdGOTO.Text = "&Open Selected";
            this.cmdGOTO.UseVisualStyleBackColor = false;
            this.cmdGOTO.Visible = false;
            // 
            // cmdComplete
            // 
            this.cmdComplete.BackColor = System.Drawing.Color.Brown;
            this.cmdComplete.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComplete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComplete.ForeColor = System.Drawing.Color.White;
            this.cmdComplete.Location = new System.Drawing.Point(8, 15);
            this.cmdComplete.Name = "cmdComplete";
            this.cmdComplete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdComplete.Size = new System.Drawing.Size(98, 42);
            this.cmdComplete.TabIndex = 0;
            this.cmdComplete.Text = "&Mark as Completed";
            this.cmdComplete.UseVisualStyleBackColor = false;
            this.cmdComplete.Click += new System.EventHandler(this.cmdComplete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(6, 111);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "&Close";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmCustIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmCustIssues";
            this.Text = "frmCustIssues";
            this.Load += new System.EventHandler(this.frmCustIssues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button cmdGOTO;
        private System.Windows.Forms.Button cmdComplete;
        private System.Windows.Forms.Button cmdCancel;
    }
}