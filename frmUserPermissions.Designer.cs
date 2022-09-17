using System.ComponentModel;
using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace CRM
{
    partial class frmUserPermissions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cbPermissions = new System.Windows.Forms.ComboBox();
            this.IRDataSet = new System.Data.DataSet();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.GridData = new System.Windows.Forms.DataGridView();
            this.UserFormsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserFormsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnIndividual);
            this.IdGroupBox1.Controls.Add(this.btnDelete);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(515, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 173);
            this.IdGroupBox1.TabIndex = 9;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnIndividual
            // 
            this.btnIndividual.BackColor = System.Drawing.Color.Brown;
            this.btnIndividual.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividual.ForeColor = System.Drawing.Color.White;
            this.btnIndividual.Location = new System.Drawing.Point(8, 22);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIndividual.Size = new System.Drawing.Size(98, 42);
            this.btnIndividual.TabIndex = 99;
            this.btnIndividual.Text = "&Add Selected Permission";
            this.btnIndividual.UseVisualStyleBackColor = false;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(8, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "&Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(8, 118);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Close";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cbPermissions
            // 
            this.cbPermissions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbPermissions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPermissions.DisplayMember = "FormName";
            this.cbPermissions.Font = new System.Drawing.Font("Arial", 10F);
            this.cbPermissions.FormattingEnabled = true;
            this.cbPermissions.Location = new System.Drawing.Point(184, 18);
            this.cbPermissions.Name = "cbPermissions";
            this.cbPermissions.Size = new System.Drawing.Size(221, 24);
            this.cbPermissions.TabIndex = 10;
            this.cbPermissions.ValueMember = "FormName";
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "IRDataSet";
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(33, 21);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(144, 16);
            this.IdLabel1.TabIndex = 11;
            this.IdLabel1.Text = "Available Permissions";
            // 
            // GridData
            // 
            this.GridData.AllowUserToAddRows = false;
            this.GridData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue;
            this.GridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridData.Location = new System.Drawing.Point(22, 82);
            this.GridData.MultiSelect = false;
            this.GridData.Name = "GridData";
            this.GridData.Size = new System.Drawing.Size(474, 289);
            this.GridData.TabIndex = 12;
            // 
            // UserFormsBindingSource
            // 
            this.UserFormsBindingSource.DataSource = this.IRDataSet;
            this.UserFormsBindingSource.Position = 0;
            // 
            // frmUserPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(641, 383);
            this.Controls.Add(this.GridData);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.cbPermissions);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmUserPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "UserPermissions";
            this.Text = "User Permissions";
            this.Load += new System.EventHandler(this.frmUserPermissions_Load);
            this.IdGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserFormsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.ComboBox cbPermissions;
        //private System.Windows.Forms.BindingSource UserFormsBindingSource;
        private System.Data.DataSet IRDataSet;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.DataGridView GridData;
        private BindingSource UserFormsBindingSource;
    }
}