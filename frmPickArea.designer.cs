using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmPickArea
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
            this.trAreas = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trAreas
            // 
            this.trAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trAreas.Location = new System.Drawing.Point(12, 12);
            this.trAreas.Name = "trAreas";
            this.trAreas.Size = new System.Drawing.Size(441, 666);
            this.trAreas.TabIndex = 13;
            this.trAreas.DoubleClick += new System.EventHandler(this.trAreas_DoubleClick);
            // 
            // frmPickArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(465, 690);
            this.ControlBox = false;
            this.Controls.Add(this.trAreas);
            this.Name = "frmPickArea";
            this.Tag = "EDIT_AREAS";
            this.Text = "Pick Area";
            this.Load += new System.EventHandler(this.frmPickArea_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView trAreas;
    }
}