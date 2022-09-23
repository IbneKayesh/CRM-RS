using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmUserGroups
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
            this.UserGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IRDataSet = new System.Data.DataSet();
            this.UserGroupsidDataGridView = new System.Windows.Forms.DataGridView();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupsidDataGridView)).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserGroupsBindingSource
            // 
            this.UserGroupsBindingSource.DataSource = this.IRDataSet;
            this.UserGroupsBindingSource.Position = 0;
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "IRDataSet";
            // 
            // UserGroupsidDataGridView
            // 
            this.UserGroupsidDataGridView.AllowUserToAddRows = false;
            this.UserGroupsidDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            this.UserGroupsidDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.UserGroupsidDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGroupsidDataGridView.AutoGenerateColumns = false;
            this.UserGroupsidDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UserGroupsidDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGroupsidDataGridView.DataSource = this.UserGroupsBindingSource;
            this.UserGroupsidDataGridView.Location = new System.Drawing.Point(26, 67);
            this.UserGroupsidDataGridView.Name = "UserGroupsidDataGridView";
            this.UserGroupsidDataGridView.Size = new System.Drawing.Size(408, 259);
            this.UserGroupsidDataGridView.TabIndex = 13;
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnAddGroup);
            this.IdGroupBox1.Controls.Add(this.btnDelete);
            this.IdGroupBox1.Controls.Add(this.btnAdd);
            this.IdGroupBox1.Controls.Add(this.btnClose);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(462, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 220);
            this.IdGroupBox1.TabIndex = 12;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.Brown;
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Location = new System.Drawing.Point(6, 70);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddGroup.Size = new System.Drawing.Size(98, 42);
            this.btnAddGroup.TabIndex = 6;
            this.btnAddGroup.Text = "Add New &Group";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(6, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Brown;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(6, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(98, 42);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Brown;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(6, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(98, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGroup.BackColor = System.Drawing.SystemColors.Window;
            this.cbGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbGroup.Location = new System.Drawing.Point(72, 25);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbGroup.Size = new System.Drawing.Size(175, 24);
            this.cbGroup.Sorted = true;
            this.cbGroup.TabIndex = 10;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Tan;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(23, 28);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(42, 16);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Group";
            // 
            // frmUserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(596, 354);
            this.Controls.Add(this.UserGroupsidDataGridView);
            this.Controls.Add(this.IdGroupBox1);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.Label3);
            this.Name = "frmUserGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "UserGroups";
            this.Text = "User Groups";
            this.Click += new System.EventHandler(this.frmUserGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupsidDataGridView)).EndInit();
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet IRDataSet;
        private System.Windows.Forms.BindingSource UserGroupsBindingSource;
        private System.Windows.Forms.DataGridView UserGroupsidDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label Label3;
    }
}