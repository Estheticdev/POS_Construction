namespace POS_Software.Forms.Admin
{
    partial class frmSizes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSizes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateSize = new System.Windows.Forms.Label();
            this.TCSize = new DevExpress.XtraTab.XtraTabControl();
            this.TPSize = new DevExpress.XtraTab.XtraTabPage();
            this.CkEActive = new DevExpress.XtraEditors.CheckEdit();
            this.TxtSize_ID = new DevExpress.XtraEditors.TextEdit();
            this.lblSizeID = new System.Windows.Forms.Label();
            this.TxtSize_Name = new DevExpress.XtraEditors.TextEdit();
            this.lblSizeName = new System.Windows.Forms.Label();
            this.TPHistory = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCSize)).BeginInit();
            this.TCSize.SuspendLayout();
            this.TPSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize_Name.Properties)).BeginInit();
            this.TPHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblCreateSize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 39);
            this.panel1.TabIndex = 15;
            // 
            // lblCreateSize
            // 
            this.lblCreateSize.AutoSize = true;
            this.lblCreateSize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateSize.ForeColor = System.Drawing.Color.White;
            this.lblCreateSize.Location = new System.Drawing.Point(180, 8);
            this.lblCreateSize.Name = "lblCreateSize";
            this.lblCreateSize.Size = new System.Drawing.Size(127, 23);
            this.lblCreateSize.TabIndex = 0;
            this.lblCreateSize.Text = "Create Sizes";
            // 
            // TCSize
            // 
            this.TCSize.Location = new System.Drawing.Point(3, 44);
            this.TCSize.Name = "TCSize";
            this.TCSize.SelectedTabPage = this.TPSize;
            this.TCSize.Size = new System.Drawing.Size(482, 188);
            this.TCSize.TabIndex = 47;
            this.TCSize.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TPSize,
            this.TPHistory});
            this.TCSize.Click += new System.EventHandler(this.TCSize_Click);
            // 
            // TPSize
            // 
            this.TPSize.Controls.Add(this.CkEActive);
            this.TPSize.Controls.Add(this.TxtSize_ID);
            this.TPSize.Controls.Add(this.lblSizeID);
            this.TPSize.Controls.Add(this.TxtSize_Name);
            this.TPSize.Controls.Add(this.lblSizeName);
            this.TPSize.Name = "TPSize";
            this.TPSize.Size = new System.Drawing.Size(480, 163);
            this.TPSize.Text = "Add Size";
            // 
            // CkEActive
            // 
            this.CkEActive.EnterMoveNextControl = true;
            this.CkEActive.Location = new System.Drawing.Point(178, 93);
            this.CkEActive.Name = "CkEActive";
            this.CkEActive.Properties.Caption = "Active";
            this.CkEActive.Size = new System.Drawing.Size(75, 20);
            this.CkEActive.TabIndex = 12;
            this.CkEActive.TabStop = false;
            this.CkEActive.CheckedChanged += new System.EventHandler(this.CkEActive_CheckedChanged);
            // 
            // TxtSize_ID
            // 
            this.TxtSize_ID.Location = new System.Drawing.Point(180, 42);
            this.TxtSize_ID.Name = "TxtSize_ID";
            this.TxtSize_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtSize_ID.TabIndex = 0;
            this.TxtSize_ID.TabStop = false;
            this.TxtSize_ID.Tag = "*";
            // 
            // lblSizeID
            // 
            this.lblSizeID.AutoSize = true;
            this.lblSizeID.Location = new System.Drawing.Point(126, 45);
            this.lblSizeID.Name = "lblSizeID";
            this.lblSizeID.Size = new System.Drawing.Size(44, 13);
            this.lblSizeID.TabIndex = 3;
            this.lblSizeID.Text = "Size ID:";
            // 
            // TxtSize_Name
            // 
            this.TxtSize_Name.EnterMoveNextControl = true;
            this.TxtSize_Name.Location = new System.Drawing.Point(180, 67);
            this.TxtSize_Name.Name = "TxtSize_Name";
            this.TxtSize_Name.Size = new System.Drawing.Size(145, 20);
            this.TxtSize_Name.TabIndex = 1;
            this.TxtSize_Name.Tag = "*";
            this.TxtSize_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTypes_Name_KeyPress);
            // 
            // lblSizeName
            // 
            this.lblSizeName.AutoSize = true;
            this.lblSizeName.Location = new System.Drawing.Point(110, 70);
            this.lblSizeName.Name = "lblSizeName";
            this.lblSizeName.Size = new System.Drawing.Size(60, 13);
            this.lblSizeName.TabIndex = 10;
            this.lblSizeName.Text = "Size Name:";
            // 
            // TPHistory
            // 
            this.TPHistory.Controls.Add(this.gridControl1);
            this.TPHistory.Name = "TPHistory";
            this.TPHistory.Size = new System.Drawing.Size(480, 163);
            this.TPHistory.Text = "History";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(475, 157);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "No";
            this.gridColumn1.FieldName = "Size_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "Size_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.FieldName = "Active";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Date Created";
            this.gridColumn5.FieldName = "Created_Date";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowMove = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(397, 235);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 22);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(320, 235);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 22);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(166, 235);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.Location = new System.Drawing.Point(12, 235);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(71, 22);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(89, 235);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(71, 22);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(243, 235);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 22);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmSizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TCSize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSizes.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSizes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Type";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCSize)).EndInit();
            this.TCSize.ResumeLayout(false);
            this.TPSize.ResumeLayout(false);
            this.TPSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize_Name.Properties)).EndInit();
            this.TPHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateSize;
        private DevExpress.XtraTab.XtraTabControl TCSize;
        private DevExpress.XtraTab.XtraTabPage TPSize;
        private DevExpress.XtraEditors.TextEdit TxtSize_ID;
        private System.Windows.Forms.Label lblSizeID;
        private DevExpress.XtraEditors.TextEdit TxtSize_Name;
        private System.Windows.Forms.Label lblSizeName;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraEditors.CheckEdit CkEActive;
        private DevExpress.XtraTab.XtraTabPage TPHistory;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}