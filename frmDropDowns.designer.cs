using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmDropDowns
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.cbDropDowns = new System.Windows.Forms.ComboBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Brown;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(287, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(98, 42);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "&Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(109, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete Current";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbItems
            // 
            this.cbItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItems.Font = new System.Drawing.Font("Arial", 10F);
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(109, 65);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(276, 24);
            this.cbItems.TabIndex = 15;
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(58, 68);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(44, 16);
            this.IdLabel2.TabIndex = 14;
            this.IdLabel2.Text = "Items:";
            // 
            // cbDropDowns
            // 
            this.cbDropDowns.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbDropDowns.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDropDowns.Font = new System.Drawing.Font("Arial", 10F);
            this.cbDropDowns.FormattingEnabled = true;
            this.cbDropDowns.Location = new System.Drawing.Point(109, 26);
            this.cbDropDowns.Name = "cbDropDowns";
            this.cbDropDowns.Size = new System.Drawing.Size(276, 24);
            this.cbDropDowns.TabIndex = 13;
            this.cbDropDowns.SelectedIndexChanged += new System.EventHandler(this.cbDropDowns_SelectedIndexChanged);
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(21, 29);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(81, 16);
            this.IdLabel1.TabIndex = 12;
            this.IdLabel1.Text = "Drop Down:";
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.cmdSave);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(408, 7);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 77);
            this.IdGroupBox1.TabIndex = 11;
            this.IdGroupBox1.TabStop = false;
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Brown;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.White;
            this.cmdSave.Location = new System.Drawing.Point(6, 22);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSave.Size = new System.Drawing.Size(98, 42);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "&Close";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmDropDowns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.cbDropDowns);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmDropDowns";
            this.Tag = "DropDowns";
            this.Text = "frmDropDowns";
            this.Load += new System.EventHandler(this.frmDropDowns_Load);
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;        
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbItems;        
        private System.Windows.Forms.Label IdLabel2;        
        private System.Windows.Forms.ComboBox cbDropDowns;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button cmdSave;
    }
}