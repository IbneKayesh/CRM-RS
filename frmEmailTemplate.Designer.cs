using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM
{
    partial class frmEmailTemplate
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
            this.IRDataSet = new System.Data.DataSet();
            this.CRMEmailTemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.CRMEmailTemplatesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.IdLabel4 = new System.Windows.Forms.Label();
            this.IdLabel3 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.IdTextBox1 = new System.Windows.Forms.TextBox();
            this.numTemplateID = new System.Windows.Forms.NumericUpDown();
            this.IdGroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cbMarker = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMarker = new System.Windows.Forms.Button();
            this.ckActive = new System.Windows.Forms.CheckBox();
            this.IdLabel5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMEmailTemplatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMEmailTemplatesBindingNavigator)).BeginInit();
            this.CRMEmailTemplatesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemplateID)).BeginInit();
            this.IdGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IRDataSet
            // 
            this.IRDataSet.DataSetName = "IRDataSet";
            // 
            // CRMEmailTemplatesBindingSource
            // 
            this.CRMEmailTemplatesBindingSource.DataSource = this.IRDataSet;
            this.CRMEmailTemplatesBindingSource.Position = 0;
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.BindingNavigatorCountItem.Text = "of {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // CRMEmailTemplatesBindingNavigator
            // 
            this.CRMEmailTemplatesBindingNavigator.AddNewItem = null;
            this.CRMEmailTemplatesBindingNavigator.BackColor = System.Drawing.Color.Tan;
            this.CRMEmailTemplatesBindingNavigator.BindingSource = this.CRMEmailTemplatesBindingSource;
            this.CRMEmailTemplatesBindingNavigator.CountItem = this.BindingNavigatorCountItem;
            this.CRMEmailTemplatesBindingNavigator.DeleteItem = null;
            this.CRMEmailTemplatesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2});
            this.CRMEmailTemplatesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.CRMEmailTemplatesBindingNavigator.MoveFirstItem = null;
            this.CRMEmailTemplatesBindingNavigator.MoveLastItem = null;
            this.CRMEmailTemplatesBindingNavigator.MoveNextItem = null;
            this.CRMEmailTemplatesBindingNavigator.MovePreviousItem = null;
            this.CRMEmailTemplatesBindingNavigator.Name = "CRMEmailTemplatesBindingNavigator";
            this.CRMEmailTemplatesBindingNavigator.PositionItem = null;
            this.CRMEmailTemplatesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.CRMEmailTemplatesBindingNavigator.TabIndex = 28;
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            this.BindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.BindingNavigatorMoveFirstItem_Click);
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            this.BindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.BindingNavigatorMovePreviousItem_Click);
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            this.BindingNavigatorMoveNextItem.Click += new System.EventHandler(this.BindingNavigatorMoveNextItem_Click);
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            this.BindingNavigatorMoveLastItem.Click += new System.EventHandler(this.BindingNavigatorMoveLastItem_Click);
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMEmailTemplatesBindingSource, "Body", true));
            this.txtBody.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBody.Location = new System.Drawing.Point(16, 259);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(831, 427);
            this.txtBody.TabIndex = 20;
            this.txtBody.Text = "";
            // 
            // IdLabel4
            // 
            this.IdLabel4.AutoSize = true;
            this.IdLabel4.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel4.Location = new System.Drawing.Point(13, 233);
            this.IdLabel4.Name = "IdLabel4";
            this.IdLabel4.Size = new System.Drawing.Size(43, 16);
            this.IdLabel4.TabIndex = 19;
            this.IdLabel4.Text = "Body:";
            // 
            // IdLabel3
            // 
            this.IdLabel3.AutoSize = true;
            this.IdLabel3.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel3.Location = new System.Drawing.Point(13, 64);
            this.IdLabel3.Name = "IdLabel3";
            this.IdLabel3.Size = new System.Drawing.Size(89, 16);
            this.IdLabel3.TabIndex = 18;
            this.IdLabel3.Text = "Subject Line:";
            // 
            // IdLabel2
            // 
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel2.Location = new System.Drawing.Point(223, 38);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(47, 16);
            this.IdLabel2.TabIndex = 17;
            this.IdLabel2.Text = "Name:";
            // 
            // IdLabel1
            // 
            this.IdLabel1.AutoSize = true;
            this.IdLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel1.Location = new System.Drawing.Point(13, 38);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(85, 16);
            this.IdLabel1.TabIndex = 16;
            this.IdLabel1.Text = "Template ID:";
            // 
            // txtSubject
            // 
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMEmailTemplatesBindingSource, "Subject", true));
            this.txtSubject.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSubject.ForeColor = System.Drawing.Color.Black;
            this.txtSubject.Location = new System.Drawing.Point(10, 86);
            this.txtSubject.MaxLength = 200;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(675, 23);
            this.txtSubject.TabIndex = 15;
            // 
            // IdTextBox1
            // 
            this.IdTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMEmailTemplatesBindingSource, "TemplateName", true));
            this.IdTextBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdTextBox1.ForeColor = System.Drawing.Color.Black;
            this.IdTextBox1.Location = new System.Drawing.Point(277, 35);
            this.IdTextBox1.MaxLength = 50;
            this.IdTextBox1.Name = "IdTextBox1";
            this.IdTextBox1.Size = new System.Drawing.Size(339, 23);
            this.IdTextBox1.TabIndex = 14;
            this.IdTextBox1.Leave += new System.EventHandler(this.IdTextBox1_Leave);
            // 
            // numTemplateID
            // 
            this.numTemplateID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMEmailTemplatesBindingSource, "TemplateID", true));
            this.numTemplateID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.numTemplateID.Location = new System.Drawing.Point(107, 35);
            this.numTemplateID.Name = "numTemplateID";
            this.numTemplateID.ReadOnly = true;
            this.numTemplateID.Size = new System.Drawing.Size(100, 23);
            this.numTemplateID.TabIndex = 13;
            this.numTemplateID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IdGroupBox1
            // 
            this.IdGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdGroupBox1.Controls.Add(this.btnIndividual);
            this.IdGroupBox1.Controls.Add(this.cmdSave);
            this.IdGroupBox1.Controls.Add(this.cmdCancel);
            this.IdGroupBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.IdGroupBox1.Location = new System.Drawing.Point(691, 53);
            this.IdGroupBox1.Name = "IdGroupBox1";
            this.IdGroupBox1.Size = new System.Drawing.Size(114, 173);
            this.IdGroupBox1.TabIndex = 10;
            this.IdGroupBox1.TabStop = false;
            // 
            // btnIndividual
            // 
            this.btnIndividual.BackColor = System.Drawing.Color.Brown;
            this.btnIndividual.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividual.ForeColor = System.Drawing.Color.White;
            this.btnIndividual.Location = new System.Drawing.Point(6, 70);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIndividual.Size = new System.Drawing.Size(98, 42);
            this.btnIndividual.TabIndex = 99;
            this.btnIndividual.Text = "&Create New Template";
            this.btnIndividual.UseVisualStyleBackColor = false;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
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
            this.cmdCancel.Location = new System.Drawing.Point(6, 118);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(98, 42);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Close";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cbMarker
            // 
            this.cbMarker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMarker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMarker.Font = new System.Drawing.Font("Arial", 10F);
            this.cbMarker.FormattingEnabled = true;
            this.cbMarker.Items.AddRange(new object[] {
            "Customer First Name",
            "My Email Address",
            "My Phone Number"});
            this.cbMarker.Location = new System.Drawing.Point(190, 194);
            this.cbMarker.Name = "cbMarker";
            this.cbMarker.Size = new System.Drawing.Size(210, 24);
            this.cbMarker.TabIndex = 21;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Brown;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(16, 184);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 42);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Allow Edits";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMarker
            // 
            this.btnMarker.BackColor = System.Drawing.Color.Brown;
            this.btnMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarker.Font = new System.Drawing.Font("Arial", 10F);
            this.btnMarker.ForeColor = System.Drawing.Color.White;
            this.btnMarker.Location = new System.Drawing.Point(423, 184);
            this.btnMarker.Name = "btnMarker";
            this.btnMarker.Size = new System.Drawing.Size(98, 42);
            this.btnMarker.TabIndex = 23;
            this.btnMarker.Text = "Insert Marker";
            this.btnMarker.UseVisualStyleBackColor = false;
            this.btnMarker.Click += new System.EventHandler(this.btnMarker_Click);
            // 
            // ckActive
            // 
            this.ckActive.AutoSize = true;
            this.ckActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CRMEmailTemplatesBindingSource, "Active", true));
            this.ckActive.Font = new System.Drawing.Font("Arial", 10F);
            this.ckActive.Location = new System.Drawing.Point(643, 37);
            this.ckActive.Name = "ckActive";
            this.ckActive.Size = new System.Drawing.Size(64, 20);
            this.ckActive.TabIndex = 24;
            this.ckActive.Text = "Active";
            this.ckActive.UseVisualStyleBackColor = true;
            // 
            // IdLabel5
            // 
            this.IdLabel5.AutoSize = true;
            this.IdLabel5.Font = new System.Drawing.Font("Arial", 10F);
            this.IdLabel5.Location = new System.Drawing.Point(16, 116);
            this.IdLabel5.Name = "IdLabel5";
            this.IdLabel5.Size = new System.Drawing.Size(166, 16);
            this.IdLabel5.TabIndex = 25;
            this.IdLabel5.Text = "Optional Word Document";
            // 
            // txtFileName
            // 
            this.txtFileName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CRMEmailTemplatesBindingSource, "DocumentPath", true));
            this.txtFileName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFileName.ForeColor = System.Drawing.Color.Black;
            this.txtFileName.Location = new System.Drawing.Point(10, 145);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(625, 23);
            this.txtFileName.TabIndex = 26;
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Brown;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(643, 139);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(32, 29);
            this.btnAttach.TabIndex = 27;
            this.btnAttach.Text = "...";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // frmEmailTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.IdLabel5);
            this.Controls.Add(this.ckActive);
            this.Controls.Add(this.btnMarker);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbMarker);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.IdLabel4);
            this.Controls.Add(this.IdLabel3);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.IdTextBox1);
            this.Controls.Add(this.numTemplateID);
            this.Controls.Add(this.CRMEmailTemplatesBindingNavigator);
            this.Controls.Add(this.IdGroupBox1);
            this.Name = "frmEmailTemplate";
            this.Tag = "EmailTemplate";
            this.Text = "frmEmailTemplate";
            this.Load += new System.EventHandler(this.frmEmailTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMEmailTemplatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMEmailTemplatesBindingNavigator)).EndInit();
            this.CRMEmailTemplatesBindingNavigator.ResumeLayout(false);
            this.CRMEmailTemplatesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemplateID)).EndInit();
            this.IdGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet IRDataSet;
        private System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        private System.Windows.Forms.BindingSource CRMEmailTemplatesBindingSource;
        private System.Windows.Forms.BindingNavigator CRMEmailTemplatesBindingNavigator;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;        
        private System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Label IdLabel4;
        private System.Windows.Forms.Label IdLabel3;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label IdLabel1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox IdTextBox1;
        private System.Windows.Forms.NumericUpDown numTemplateID;
        private System.Windows.Forms.GroupBox IdGroupBox1;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ComboBox cbMarker;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMarker;
        private System.Windows.Forms.CheckBox ckActive;
        private System.Windows.Forms.Label IdLabel5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnAttach;
    }
}