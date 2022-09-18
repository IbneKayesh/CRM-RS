using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmLoadData
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
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmdLoad
            // 
            this.cmdLoad.BackColor = System.Drawing.Color.Brown;
            this.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.ForeColor = System.Drawing.Color.White;
            this.cmdLoad.Location = new System.Drawing.Point(42, 80);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(98, 42);
            this.cmdLoad.TabIndex = 0;
            this.cmdLoad.Text = "Load Data";
            this.cmdLoad.UseVisualStyleBackColor = false;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Brown;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(190, 80);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // IdLabel1
            // 
            this.IdLabel1.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel1.Location = new System.Drawing.Point(39, 13);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(265, 64);
            this.IdLabel1.TabIndex = 2;
            this.IdLabel1.Text = "This may take several minutes to an hour depending on your connection speed.";
            this.IdLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb1
            // 
            this.pb1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb1.Location = new System.Drawing.Point(0, 132);
            this.pb1.Maximum = 95;
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(338, 23);
            this.pb1.TabIndex = 3;
            this.pb1.Visible = false;
            // 
            // frmLoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(338, 155);
            this.ControlBox = false;
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdLoad);
            this.Name = "frmLoadData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Data";
            this.Load += new System.EventHandler(this.frmLoadData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdLoad;        
        private System.Windows.Forms.Label IdLabel1;
    }
}