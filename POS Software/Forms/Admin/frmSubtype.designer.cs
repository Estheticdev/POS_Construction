namespace POS_Software.Forms.Admin
{
    partial class frmSubtype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubtype));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateSubType = new System.Windows.Forms.Label();
            this.TCSubType = new DevExpress.XtraTab.XtraTabControl();
            this.TPSubType = new DevExpress.XtraTab.XtraTabPage();
            this.LuEType_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.CkEActive = new DevExpress.XtraEditors.CheckEdit();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.TxtCategory_ID = new DevExpress.XtraEditors.TextEdit();
            this.lblSubTypeID = new System.Windows.Forms.Label();
            this.TxtCategory_Name = new DevExpress.XtraEditors.TextEdit();
            this.lblSubTypeName = new System.Windows.Forms.Label();
            this.TPHistory = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.TCSubType)).BeginInit();
            this.TCSubType.SuspendLayout();
            this.TPSubType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuEType_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCategory_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCategory_Name.Properties)).BeginInit();
            this.TPHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblCreateSubType);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 39);
            this.panel1.TabIndex = 15;
            // 
            // lblCreateSubType
            // 
            this.lblCreateSubType.AutoSize = true;
            this.lblCreateSubType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateSubType.ForeColor = System.Drawing.Color.White;
            this.lblCreateSubType.Location = new System.Drawing.Point(159, 8);
            this.lblCreateSubType.Name = "lblCreateSubType";
            this.lblCreateSubType.Size = new System.Drawing.Size(166, 23);
            this.lblCreateSubType.TabIndex = 0;
            this.lblCreateSubType.Text = "Create Sub Type";
            // 
            // TCSubType
            // 
            this.TCSubType.Location = new System.Drawing.Point(3, 43);
            this.TCSubType.Name = "TCSubType";
            this.TCSubType.SelectedTabPage = this.TPSubType;
            this.TCSubType.Size = new System.Drawing.Size(482, 188);
            this.TCSubType.TabIndex = 47;
            this.TCSubType.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TPSubType,
            this.TPHistory});
            this.TCSubType.Click += new System.EventHandler(this.TCSubType_Click);
            // 
            // TPSubType
            // 
            this.TPSubType.Controls.Add(this.LuEType_ID);
            this.TPSubType.Controls.Add(this.CkEActive);
            this.TPSubType.Controls.Add(this.lblTypeName);
            this.TPSubType.Controls.Add(this.TxtCategory_ID);
            this.TPSubType.Controls.Add(this.lblSubTypeID);
            this.TPSubType.Controls.Add(this.TxtCategory_Name);
            this.TPSubType.Controls.Add(this.lblSubTypeName);
            this.TPSubType.Name = "TPSubType";
            this.TPSubType.Size = new System.Drawing.Size(480, 163);
            this.TPSubType.Text = "Add Sub Type";
            // 
            // LuEType_ID
            // 
            this.LuEType_ID.EnterMoveNextControl = true;
            this.LuEType_ID.Location = new System.Drawing.Point(188, 58);
            this.LuEType_ID.Name = "LuEType_ID";
            this.LuEType_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEType_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEType_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEType_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Types_Name", "Name")});
            this.LuEType_ID.Properties.NullText = "";
            this.LuEType_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuEType_ID.Properties.PopupSizeable = false;
            this.LuEType_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuEType_ID.Properties.ShowFooter = false;
            this.LuEType_ID.Properties.ShowHeader = false;
            this.LuEType_ID.Properties.ShowLines = false;
            this.LuEType_ID.Size = new System.Drawing.Size(145, 20);
            this.LuEType_ID.TabIndex = 1;
            this.LuEType_ID.Tag = "*";
            // 
            // CkEActive
            // 
            this.CkEActive.Location = new System.Drawing.Point(186, 112);
            this.CkEActive.Name = "CkEActive";
            this.CkEActive.Properties.Caption = "Active";
            this.CkEActive.Size = new System.Drawing.Size(75, 20);
            this.CkEActive.TabIndex = 13;
            this.CkEActive.TabStop = false;
            this.CkEActive.EditValueChanged += new System.EventHandler(this.CkEActive_EditValueChanged);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(121, 60);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(65, 13);
            this.lblTypeName.TabIndex = 12;
            this.lblTypeName.Text = "Type Name:";
            // 
            // TxtCategory_ID
            // 
            this.TxtCategory_ID.Location = new System.Drawing.Point(188, 31);
            this.TxtCategory_ID.Name = "TxtCategory_ID";
            this.TxtCategory_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtCategory_ID.TabIndex = 0;
            this.TxtCategory_ID.TabStop = false;
            // 
            // lblSubTypeID
            // 
            this.lblSubTypeID.AutoSize = true;
            this.lblSubTypeID.Location = new System.Drawing.Point(116, 34);
            this.lblSubTypeID.Name = "lblSubTypeID";
            this.lblSubTypeID.Size = new System.Drawing.Size(70, 13);
            this.lblSubTypeID.TabIndex = 3;
            this.lblSubTypeID.Text = "Sub Type ID:";
            // 
            // TxtCategory_Name
            // 
            this.TxtCategory_Name.EnterMoveNextControl = true;
            this.TxtCategory_Name.Location = new System.Drawing.Point(188, 86);
            this.TxtCategory_Name.Name = "TxtCategory_Name";
            this.TxtCategory_Name.Size = new System.Drawing.Size(145, 20);
            this.TxtCategory_Name.TabIndex = 2;
            this.TxtCategory_Name.Tag = "*";
            this.TxtCategory_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCategory_Name_KeyPress);
            // 
            // lblSubTypeName
            // 
            this.lblSubTypeName.AutoSize = true;
            this.lblSubTypeName.Location = new System.Drawing.Point(100, 89);
            this.lblSubTypeName.Name = "lblSubTypeName";
            this.lblSubTypeName.Size = new System.Drawing.Size(86, 13);
            this.lblSubTypeName.TabIndex = 10;
            this.lblSubTypeName.Text = "Sub Type Name:";
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
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(476, 158);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
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
            this.gridColumn1.FieldName = "Category_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Type Name";
            this.gridColumn2.FieldName = "Types_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Category Name";
            this.gridColumn3.FieldName = "Category_Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.FieldName = "Active";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Date Created";
            this.gridColumn5.FieldName = "Created_Date";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowMove = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // BtnCancel
            // 
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(402, 234);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 22);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(325, 234);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 22);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(171, 234);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.Location = new System.Drawing.Point(17, 234);
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
            this.BtnEdit.Location = new System.Drawing.Point(94, 234);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(71, 22);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(248, 234);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 22);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmSubtype
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
            this.Controls.Add(this.TCSubType);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSubtype.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSubtype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sub Type";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCSubType)).EndInit();
            this.TCSubType.ResumeLayout(false);
            this.TPSubType.ResumeLayout(false);
            this.TPSubType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuEType_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCategory_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCategory_Name.Properties)).EndInit();
            this.TPHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateSubType;
        private DevExpress.XtraTab.XtraTabControl TCSubType;
        private DevExpress.XtraTab.XtraTabPage TPSubType;
        private DevExpress.XtraEditors.TextEdit TxtCategory_ID;
        private System.Windows.Forms.Label lblSubTypeID;
        private DevExpress.XtraEditors.TextEdit TxtCategory_Name;
        private System.Windows.Forms.Label lblSubTypeName;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private System.Windows.Forms.Label lblTypeName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraEditors.CheckEdit CkEActive;
        private DevExpress.XtraEditors.LookUpEdit LuEType_ID;
        private DevExpress.XtraTab.XtraTabPage TPHistory;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}