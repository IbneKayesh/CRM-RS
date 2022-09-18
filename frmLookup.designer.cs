using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmLookup
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
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.Picture1 = new System.Windows.Forms.Panel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.gridLookup = new System.Windows.Forms.DataGridView();
            this.IdGroupBox1.SuspendLayout();
            this.Picture1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnClose);
            this.IdGroupBox1.Controls.Add(this.btnNew);
            this.IdGroupBox1.Controls.Add(this.btnFind);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(603, 43);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(110, 164);
            this.IdGroupBox1.TabIndex = 96;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(6, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 44);
            this.btnClose.TabIndex = 98;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Brown;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial", 10F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(6, 61);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 44);
            this.btnNew.TabIndex = 97;
            this.btnNew.Text = "New btn";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Brown;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Arial", 10F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(6, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 42);
            this.btnFind.TabIndex = 95;
            this.btnFind.Text = "Advanced Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Picture1
            // 
            this.Picture1.BackColor = System.Drawing.Color.Tan;
            this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture1.Controls.Add(this.txtValue);
            this.Picture1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Picture1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Picture1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Picture1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Picture1.Location = new System.Drawing.Point(0, 405);
            this.Picture1.Name = "Picture1";
            this.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Picture1.Size = new System.Drawing.Size(727, 45);
            this.Picture1.TabIndex = 0;
            this.Picture1.TabStop = true;
            // 
            // txtValue
            // 
            this.txtValue.AcceptsReturn = true;
            this.txtValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValue.Location = new System.Drawing.Point(8, 8);
            this.txtValue.MaxLength = 50;
            this.txtValue.Name = "txtValue";
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValue.Size = new System.Drawing.Size(585, 22);
            this.txtValue.TabIndex = 1;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // gridLookup
            // 
            this.gridLookup.AllowUserToAddRows = false;
            this.gridLookup.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            this.gridLookup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridLookup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridLookup.Location = new System.Drawing.Point(0, 40);
            this.gridLookup.MultiSelect = false;
            this.gridLookup.Name = "gridLookup";
            this.gridLookup.ReadOnly = true;
            this.gridLookup.Size = new System.Drawing.Size(595, 365);
            this.gridLookup.TabIndex = 2;
            this.gridLookup.DoubleClick += new System.EventHandler(this.gridLookup_DoubleClick);
            // 
            // frmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.IdGroupBox1);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.gridLookup);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(4, 24);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLookup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Lookup";
            this.Text = "LOOKUP ITEMS";
            this.Load += new System.EventHandler(this.frmLookup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLookup_KeyDown);
            this.IdGroupBox1.ResumeLayout(false);
            this.Picture1.ResumeLayout(false);
            this.Picture1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridLookup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel Picture1;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.TextBox txtValue;
    }
}