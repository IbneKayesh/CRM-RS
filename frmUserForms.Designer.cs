using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmUserForms
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.UserFormsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IRDataSet = new System.Data.DataSet();
            this.IdGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserFormsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnCancel);
            this.IdGroupBox1.Controls.Add(this.btnAdd);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(356, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 126);
            this.IdGroupBox1.TabIndex = 13;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(6, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(98, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // cbGroup
            // 
            this.cbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGroup.BackColor = System.Drawing.SystemColors.Window;
            this.cbGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbGroup.DataSource = this.UserFormsBindingSource;
            this.cbGroup.DisplayMember = "FormName";
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbGroup.Location = new System.Drawing.Point(24, 64);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbGroup.Size = new System.Drawing.Size(315, 24);
            this.cbGroup.TabIndex = 14;
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(43, 12);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(266, 16);
            this.IdLabel1.TabIndex = 16;
            this.IdLabel1.Text = "Select form to add from list and click Add.";
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "IRDataSet";
            // 
            // frmUserForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(482, 170);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmUserForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "UserForms";
            this.Text = "User Forms";
            this.Click += new System.EventHandler(this.frmUserForms_Load);
            this.IdGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserFormsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.BindingSource UserFormsBindingSource;
        private System.Windows.Forms.Button cbGroIdLabel1up;
        private System.Windows.Forms.Label IdLabel1;
        private System.Data.DataSet IRDataSet;
    }
}