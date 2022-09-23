using System.Drawing;
using System.Windows.Forms;

namespace CRM
{
    partial class frmApplicationControl
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
            this.ckCRMLockout = new System.Windows.Forms.CheckBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.numLogs = new System.Windows.Forms.NumericUpDown();
            this.numArchive = new System.Windows.Forms.NumericUpDown();
            this.IdLabel4 = new System.Windows.Forms.Label();
            this.numPickup = new System.Windows.Forms.NumericUpDown();
            this.IdLabel5 = new System.Windows.Forms.Label();
            this.numQuote = new System.Windows.Forms.NumericUpDown();
            this.IdLabel6 = new System.Windows.Forms.Label();
            this.numRMA = new System.Windows.Forms.NumericUpDown();
            this.IdLabel7 = new System.Windows.Forms.Label();
            this.numRMAWarranty = new System.Windows.Forms.NumericUpDown();
            this.IdLabel8 = new System.Windows.Forms.Label();
            this.ckIR2Lockout = new System.Windows.Forms.CheckBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.txtCCEmail = new System.Windows.Forms.TextBox();
            this.intPortalRMA = new System.Windows.Forms.NumericUpDown();
            this.IdLabel9 = new System.Windows.Forms.Label();
            this.IdLabel10 = new System.Windows.Forms.Label();
            this.IdLabel11 = new System.Windows.Forms.Label();
            this.IdGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPickup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRMAWarranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPortalRMA)).BeginInit();
            this.SuspendLayout();
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.cmdSave);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(505, 12);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 121);
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
            // ckCRMLockout
            // 
            this.ckCRMLockout.AutoSize = true;
            this.ckCRMLockout.Font = new System.Drawing.Font("Arial", 10F);
            this.ckCRMLockout.Location = new System.Drawing.Point(50, 34);
            this.ckCRMLockout.Name = "ckCRMLockout";
            this.ckCRMLockout.Size = new System.Drawing.Size(172, 20);
            this.ckCRMLockout.TabIndex = 12;
            this.ckCRMLockout.Text = "CRM Lockout all users.";
            this.ckCRMLockout.UseVisualStyleBackColor = true;
            this.ckCRMLockout.CheckedChanged += new System.EventHandler(this.ckLockout_CheckedChanged);
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(52, 103);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(170, 16);
            this.IdLabel1.TabIndex = 13;
            this.IdLabel1.Text = "Months to keep user logs.";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(53, 135);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(169, 16);
            this.IdLabel2.TabIndex = 14;
            this.IdLabel2.Text = "Archive history data after ";
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel3.Location = new System.Drawing.Point(279, 135);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(57, 16);
            this.IdLabel3.TabIndex = 15;
            this.IdLabel3.Text = "months.";
            // 
            // numLogs
            // 
            this.numLogs.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numLogs.Location = new System.Drawing.Point(229, 100);
            this.numLogs.Name = "numLogs";
            this.numLogs.Size = new System.Drawing.Size(43, 23);
            this.numLogs.TabIndex = 16;
            this.numLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numArchive
            // 
            this.numArchive.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numArchive.Location = new System.Drawing.Point(230, 132);
            this.numArchive.Name = "numArchive";
            this.numArchive.Size = new System.Drawing.Size(43, 23);
            this.numArchive.TabIndex = 17;
            this.numArchive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel4
            // 
            this.IdLabel4.AutoSize = true;
            this.IdLabel4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel4.Location = new System.Drawing.Point(278, 103);
            this.IdLabel4.Name = "IdLabel4";
            this.IdLabel4.Size = new System.Drawing.Size(95, 16);
            this.IdLabel4.TabIndex = 18;
            this.IdLabel4.Text = "IR2 and CRM.";
            // 
            // numPickup
            // 
            this.numPickup.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numPickup.Location = new System.Drawing.Point(230, 164);
            this.numPickup.Name = "numPickup";
            this.numPickup.Size = new System.Drawing.Size(43, 23);
            this.numPickup.TabIndex = 20;
            this.numPickup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel5
            // 
            this.IdLabel5.AutoSize = true;
            this.IdLabel5.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel5.Location = new System.Drawing.Point(112, 167);
            this.IdLabel5.Name = "IdLabel5";
            this.IdLabel5.Size = new System.Drawing.Size(110, 16);
            this.IdLabel5.TabIndex = 19;
            this.IdLabel5.Text = "Pickup Template";
            // 
            // numQuote
            // 
            this.numQuote.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numQuote.Location = new System.Drawing.Point(231, 196);
            this.numQuote.Name = "numQuote";
            this.numQuote.Size = new System.Drawing.Size(43, 23);
            this.numQuote.TabIndex = 22;
            this.numQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel6
            // 
            this.IdLabel6.AutoSize = true;
            this.IdLabel6.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel6.Location = new System.Drawing.Point(115, 199);
            this.IdLabel6.Name = "IdLabel6";
            this.IdLabel6.Size = new System.Drawing.Size(107, 16);
            this.IdLabel6.TabIndex = 21;
            this.IdLabel6.Text = "Quote Template";
            // 
            // numRMA
            // 
            this.numRMA.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numRMA.Location = new System.Drawing.Point(231, 228);
            this.numRMA.Name = "numRMA";
            this.numRMA.Size = new System.Drawing.Size(43, 23);
            this.numRMA.TabIndex = 24;
            this.numRMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel7
            // 
            this.IdLabel7.AutoSize = true;
            this.IdLabel7.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel7.Location = new System.Drawing.Point(125, 231);
            this.IdLabel7.Name = "IdLabel7";
            this.IdLabel7.Size = new System.Drawing.Size(97, 16);
            this.IdLabel7.TabIndex = 23;
            this.IdLabel7.Text = "RMA Template";
            // 
            // numRMAWarranty
            // 
            this.numRMAWarranty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numRMAWarranty.Location = new System.Drawing.Point(231, 260);
            this.numRMAWarranty.Name = "numRMAWarranty";
            this.numRMAWarranty.Size = new System.Drawing.Size(43, 23);
            this.numRMAWarranty.TabIndex = 26;
            this.numRMAWarranty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel8
            // 
            this.IdLabel8.AutoSize = true;
            this.IdLabel8.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel8.Location = new System.Drawing.Point(64, 263);
            this.IdLabel8.Name = "IdLabel8";
            this.IdLabel8.Size = new System.Drawing.Size(158, 16);
            this.IdLabel8.TabIndex = 25;
            this.IdLabel8.Text = "RMA Warranty Template";
            // 
            // ckIR2Lockout
            // 
            this.ckIR2Lockout.AutoSize = true;
            this.ckIR2Lockout.Font = new System.Drawing.Font("Arial", 10F);
            this.ckIR2Lockout.Location = new System.Drawing.Point(50, 60);
            this.ckIR2Lockout.Name = "ckIR2Lockout";
            this.ckIR2Lockout.Size = new System.Drawing.Size(162, 20);
            this.ckIR2Lockout.TabIndex = 27;
            this.ckIR2Lockout.Text = "IR2 Lockout all users.";
            this.ckIR2Lockout.UseVisualStyleBackColor = true;
            // 
            // txtSMTP
            // 
            this.txtSMTP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSMTP.ForeColor = System.Drawing.Color.Black;
            this.txtSMTP.Location = new System.Drawing.Point(231, 324);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(288, 20);
            this.txtSMTP.TabIndex = 28;
            // 
            // txtCCEmail
            // 
            this.txtCCEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCCEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCCEmail.ForeColor = System.Drawing.Color.Black;
            this.txtCCEmail.Location = new System.Drawing.Point(231, 350);
            this.txtCCEmail.Name = "txtCCEmail";
            this.txtCCEmail.Size = new System.Drawing.Size(288, 20);
            this.txtCCEmail.TabIndex = 29;
            // 
            // intPortalRMA
            // 
            this.intPortalRMA.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.intPortalRMA.Location = new System.Drawing.Point(231, 289);
            this.intPortalRMA.Name = "intPortalRMA";
            this.intPortalRMA.Size = new System.Drawing.Size(43, 23);
            this.intPortalRMA.TabIndex = 30;
            this.intPortalRMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdLabel9
            // 
            this.IdLabel9.AutoSize = true;
            this.IdLabel9.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel9.Location = new System.Drawing.Point(84, 296);
            this.IdLabel9.Name = "IdLabel9";
            this.IdLabel9.Size = new System.Drawing.Size(138, 16);
            this.IdLabel9.TabIndex = 31;
            this.IdLabel9.Text = "RMA Portal Template";
            // 
            // IdLabel10
            // 
            this.IdLabel10.AutoSize = true;
            this.IdLabel10.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel10.Location = new System.Drawing.Point(93, 324);
            this.IdLabel10.Name = "IdLabel10";
            this.IdLabel10.Size = new System.Drawing.Size(129, 16);
            this.IdLabel10.TabIndex = 32;
            this.IdLabel10.Text = "SMTP Email Server";
            // 
            // IdLabel11
            // 
            this.IdLabel11.AutoSize = true;
            this.IdLabel11.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel11.Location = new System.Drawing.Point(61, 354);
            this.IdLabel11.Name = "IdLabel11";
            this.IdLabel11.Size = new System.Drawing.Size(161, 16);
            this.IdLabel11.TabIndex = 33;
            this.IdLabel11.Text = "Portal CC Email Address";
            // 
            // frmApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(631, 389);
            this.Controls.Add(this.IdLabel11);
            this.Controls.Add(this.IdLabel10);
            this.Controls.Add(this.IdLabel9);
            this.Controls.Add(this.intPortalRMA);
            this.Controls.Add(this.txtCCEmail);
            this.Controls.Add(this.txtSMTP);
            this.Controls.Add(this.ckIR2Lockout);
            this.Controls.Add(this.numRMAWarranty);
            this.Controls.Add(this.IdLabel8);
            this.Controls.Add(this.numRMA);
            this.Controls.Add(this.IdLabel7);
            this.Controls.Add(this.numQuote);
            this.Controls.Add(this.IdLabel6);
            this.Controls.Add(this.numPickup);
            this.Controls.Add(this.IdLabel5);
            this.Controls.Add(this.IdLabel4);
            this.Controls.Add(this.numArchive);
            this.Controls.Add(this.numLogs);
            this.Controls.Add(this.IdLabel3);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.ckCRMLockout);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmApplicationControl";
            this.Tag = "CRM_Control";
            this.Text = "Application Control";
            this.Load += new System.EventHandler(this.frmApplicationControl_Load);
            this.IdGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPickup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRMAWarranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPortalRMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.NumericUpDown numLogs;
        private System.Windows.Forms.NumericUpDown numArchive;
        private System.Windows.Forms.NumericUpDown numPickup;
        private System.Windows.Forms.NumericUpDown numRMA;
        private System.Windows.Forms.NumericUpDown numRMAWarranty;
        private System.Windows.Forms.NumericUpDown intPortalRMA;
        private System.Windows.Forms.NumericUpDown numQuote;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.Label IdLabel4;
        private System.Windows.Forms.Label IdLabel5;
        private System.Windows.Forms.Label IdLabel6;
        private System.Windows.Forms.Label IdLabel7;
        private System.Windows.Forms.Label IdLabel8;
        private System.Windows.Forms.Label IdLabel9;
        private System.Windows.Forms.Label IdLabel10;
        private System.Windows.Forms.Label IdLabel11;
        private System.Windows.Forms.GroupBox IdGroupBox1;

        private System.Windows.Forms.CheckBox ckCRMLockout;
        private System.Windows.Forms.CheckBox ckIR2Lockout;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.TextBox txtCCEmail;
    }
}