using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmPreferences
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
            this.ckContacts = new System.Windows.Forms.CheckBox();
            this.ckHistory = new System.Windows.Forms.CheckBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.ckHideInactive = new System.Windows.Forms.CheckBox();
            this.ckLaptop = new System.Windows.Forms.CheckBox();
            this.ckMirror = new System.Windows.Forms.CheckBox();
            this.ckLocal = new System.Windows.Forms.CheckBox();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.cmdSave);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(426, 12);
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
            // ckContacts
            // 
            this.ckContacts.AutoSize = true;
            this.ckContacts.Font = new System.Drawing.Font("Arial", 10F);
            this.ckContacts.Location = new System.Drawing.Point(29, 66);
            this.ckContacts.Name = "ckContacts";
            this.ckContacts.Size = new System.Drawing.Size(206, 20);
            this.ckContacts.TabIndex = 12;
            this.ckContacts.Text = "Show all contacts by default.";
            this.ckContacts.UseVisualStyleBackColor = true;
            // 
            // ckHistory
            // 
            this.ckHistory.AutoSize = true;
            this.ckHistory.Font = new System.Drawing.Font("Arial", 10F);
            this.ckHistory.Location = new System.Drawing.Point(29, 93);
            this.ckHistory.Name = "ckHistory";
            this.ckHistory.Size = new System.Drawing.Size(238, 20);
            this.ckHistory.TabIndex = 13;
            this.ckHistory.Text = "Always show all archived records.";
            this.ckHistory.UseVisualStyleBackColor = true;
            // 
            // IdLabel1
            // 
            this.IdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(26, 201);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(378, 16);
            this.IdLabel1.TabIndex = 14;
            this.IdLabel1.Text = "You must restart the CRM for these changes to take effect.";
            // 
            // ckHideInactive
            // 
            this.ckHideInactive.AutoSize = true;
            this.ckHideInactive.Font = new System.Drawing.Font("Arial", 10F);
            this.ckHideInactive.Location = new System.Drawing.Point(29, 39);
            this.ckHideInactive.Name = "ckHideInactive";
            this.ckHideInactive.Size = new System.Drawing.Size(234, 20);
            this.ckHideInactive.TabIndex = 15;
            this.ckHideInactive.Text = "Hide inactive contacts by default.";
            this.ckHideInactive.UseVisualStyleBackColor = true;
            // 
            // ckLaptop
            // 
            this.ckLaptop.AutoSize = true;
            this.ckLaptop.Font = new System.Drawing.Font("Arial", 10F);
            this.ckLaptop.Location = new System.Drawing.Point(29, 12);
            this.ckLaptop.Name = "ckLaptop";
            this.ckLaptop.Size = new System.Drawing.Size(205, 20);
            this.ckLaptop.TabIndex = 16;
            this.ckLaptop.Text = "Use Laptop Monitor Settings";
            this.ckLaptop.UseVisualStyleBackColor = true;
            // 
            // ckMirror
            // 
            this.ckMirror.AutoSize = true;
            this.ckMirror.Font = new System.Drawing.Font("Arial", 10F);
            this.ckMirror.Location = new System.Drawing.Point(29, 119);
            this.ckMirror.Name = "ckMirror";
            this.ckMirror.Size = new System.Drawing.Size(244, 20);
            this.ckMirror.TabIndex = 17;
            this.ckMirror.Text = "Never flip to mirror while logged in.";
            this.ckMirror.UseVisualStyleBackColor = true;
            this.ckMirror.Visible = false;
            // 
            // ckLocal
            // 
            this.ckLocal.AutoSize = true;
            this.ckLocal.Font = new System.Drawing.Font("Arial", 10F);
            this.ckLocal.Location = new System.Drawing.Point(29, 163);
            this.ckLocal.Name = "ckLocal";
            this.ckLocal.Size = new System.Drawing.Size(204, 20);
            this.ckLocal.TabIndex = 18;
            this.ckLocal.Text = "RUN CRM IN LOCAL MODE.";
            this.ckLocal.UseVisualStyleBackColor = true;
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(552, 229);
            this.Controls.Add(this.ckLocal);
            this.Controls.Add(this.ckMirror);
            this.Controls.Add(this.ckLaptop);
            this.Controls.Add(this.ckHideInactive);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.ckHistory);
            this.Controls.Add(this.ckContacts);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmPreferences";
            this.Tag = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox ckContacts;
        private System.Windows.Forms.CheckBox ckHistory;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.CheckBox ckHideInactive;
        private System.Windows.Forms.CheckBox ckLaptop;
        private System.Windows.Forms.CheckBox ckMirror;
        private System.Windows.Forms.CheckBox ckLocal;
        
    }
}