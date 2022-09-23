using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmTaskType
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
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.cmdSave);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(403, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 122);
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
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(6, 70);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmTaskType
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(529, 341);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmTaskType";
            this.Tag = "TaskType";
            this.Text = "Task Type";
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox IdGroupBox1;
    }
}