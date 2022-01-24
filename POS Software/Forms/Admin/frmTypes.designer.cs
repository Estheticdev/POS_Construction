namespace POS_Software.Forms.Admin
{
    partial class frmTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateType = new System.Windows.Forms.Label();
            this.TBCType = new DevExpress.XtraTab.XtraTabControl();
            this.TPType = new DevExpress.XtraTab.XtraTabPage();
            this.CkEActive = new DevExpress.XtraEditors.CheckEdit();
            this.TxtItems_Types_ID = new DevExpress.XtraEditors.TextEdit();
            this.lblTypeID = new System.Windows.Forms.Label();
            this.TxtTypes_Name = new DevExpress.XtraEditors.TextEdit();
            this.lblTypeName = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.TBCType)).BeginInit();
            this.TBCType.SuspendLayout();
            this.TPType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItems_Types_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTypes_Name.Properties)).BeginInit();
            this.TPHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblCreateType);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 39);
            this.panel1.TabIndex = 15;
            // 
            // lblCreateType
            // 
            this.lblCreateType.AutoSize = true;
            this.lblCreateType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateType.ForeColor = System.Drawing.Color.White;
            this.lblCreateType.Location = new System.Drawing.Point(180, 8);
            this.lblCreateType.Name = "lblCreateType";
            this.lblCreateType.Size = new System.Drawing.Size(124, 23);
            this.lblCreateType.TabIndex = 0;
            this.lblCreateType.Text = "Create Type";
            // 
            // TBCType
            // 
            this.TBCType.Location = new System.Drawing.Point(3, 44);
            this.TBCType.Name = "TBCType";
            this.TBCType.SelectedTabPage = this.TPType;
            this.TBCType.Size = new System.Drawing.Size(482, 185);
            this.TBCType.TabIndex = 47;
            this.TBCType.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TPType,
            this.TPHistory});
            this.TBCType.Click += new System.EventHandler(this.TBCType_Click);
            // 
            // TPType
            // 
            this.TPType.Controls.Add(this.CkEActive);
            this.TPType.Controls.Add(this.TxtItems_Types_ID);
            this.TPType.Controls.Add(this.lblTypeID);
            this.TPType.Controls.Add(this.TxtTypes_Name);
            this.TPType.Controls.Add(this.lblTypeName);
            this.TPType.Name = "TPType";
            this.TPType.Size = new System.Drawing.Size(480, 160);
            this.TPType.Text = "Add Type";
            // 
            // CkEActive
            // 
            this.CkEActive.Location = new System.Drawing.Point(178, 92);
            this.CkEActive.Name = "CkEActive";
            this.CkEActive.Properties.Caption = "Active";
            this.CkEActive.Size = new System.Drawing.Size(75, 20);
            this.CkEActive.TabIndex = 11;
            this.CkEActive.TabStop = false;
            this.CkEActive.EditValueChanged += new System.EventHandler(this.CkEActive_EditValueChanged);
            // 
            // TxtItems_Types_ID
            // 
            this.TxtItems_Types_ID.Location = new System.Drawing.Point(180, 39);
            this.TxtItems_Types_ID.Name = "TxtItems_Types_ID";
            this.TxtItems_Types_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtItems_Types_ID.TabIndex = 0;
            this.TxtItems_Types_ID.TabStop = false;
            this.TxtItems_Types_ID.Tag = "*";
            // 
            // lblTypeID
            // 
            this.lblTypeID.AutoSize = true;
            this.lblTypeID.Location = new System.Drawing.Point(126, 42);
            this.lblTypeID.Name = "lblTypeID";
            this.lblTypeID.Size = new System.Drawing.Size(49, 13);
            this.lblTypeID.TabIndex = 3;
            this.lblTypeID.Text = "Type ID:";
            // 
            // TxtTypes_Name
            // 
            this.TxtTypes_Name.EnterMoveNextControl = true;
            this.TxtTypes_Name.Location = new System.Drawing.Point(180, 66);
            this.TxtTypes_Name.Name = "TxtTypes_Name";
            this.TxtTypes_Name.Size = new System.Drawing.Size(145, 20);
            this.TxtTypes_Name.TabIndex = 1;
            this.TxtTypes_Name.Tag = "*";
            this.TxtTypes_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTypes_Name_KeyPress);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(110, 69);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(65, 13);
            this.lblTypeName.TabIndex = 10;
            this.lblTypeName.Text = "Type Name:";
            // 
            // TPHistory
            // 
            this.TPHistory.Controls.Add(this.gridControl1);
            this.TPHistory.Name = "TPHistory";
            this.TPHistory.Size = new System.Drawing.Size(480, 160);
            this.TPHistory.Text = "History";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(475, 156);
            this.gridControl1.TabIndex = 0;
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
            this.gridColumn1.FieldName = "Items_Types_ID";
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
            this.gridColumn2.FieldName = "Types_Name";
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
            this.BtnCancel.Location = new System.Drawing.Point(397, 234);
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
            this.BtnDelete.Location = new System.Drawing.Point(320, 234);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 22);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(166, 234);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.Location = new System.Drawing.Point(12, 234);
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
            this.BtnEdit.Location = new System.Drawing.Point(89, 234);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(71, 22);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(243, 234);
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
            // frmTypes
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
            this.Controls.Add(this.TBCType);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmTypes.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Type";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBCType)).EndInit();
            this.TBCType.ResumeLayout(false);
            this.TPType.ResumeLayout(false);
            this.TPType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItems_Types_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTypes_Name.Properties)).EndInit();
            this.TPHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateType;
        private DevExpress.XtraTab.XtraTabControl TBCType;
        private DevExpress.XtraTab.XtraTabPage TPType;
        private DevExpress.XtraEditors.TextEdit TxtItems_Types_ID;
        private System.Windows.Forms.Label lblTypeID;
        private DevExpress.XtraEditors.TextEdit TxtTypes_Name;
        private System.Windows.Forms.Label lblTypeName;
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