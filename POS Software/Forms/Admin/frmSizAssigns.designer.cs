namespace POS_Software.Forms.Admin
{
    partial class frmSizAssigns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSizAssigns));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAssignSize = new System.Windows.Forms.Label();
            this.TCSize = new DevExpress.XtraTab.XtraTabControl();
            this.TPSize = new DevExpress.XtraTab.XtraTabPage();
            this.LuESizes_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.LuECategory_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.LuETypes_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.CkEActive = new DevExpress.XtraEditors.CheckEdit();
            this.lblSubTypeName = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.TxtSizes_Assign_ID = new DevExpress.XtraEditors.TextEdit();
            this.lblSizeID = new System.Windows.Forms.Label();
            this.lblSizeName = new System.Windows.Forms.Label();
            this.TPHistory = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.LuESizes_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuECategory_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuETypes_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSizes_Assign_ID.Properties)).BeginInit();
            this.TPHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblAssignSize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 39);
            this.panel1.TabIndex = 59;
            // 
            // lblAssignSize
            // 
            this.lblAssignSize.AutoSize = true;
            this.lblAssignSize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignSize.ForeColor = System.Drawing.Color.White;
            this.lblAssignSize.Location = new System.Drawing.Point(185, 8);
            this.lblAssignSize.Name = "lblAssignSize";
            this.lblAssignSize.Size = new System.Drawing.Size(118, 23);
            this.lblAssignSize.TabIndex = 0;
            this.lblAssignSize.Text = "Assign Size";
            // 
            // TCSize
            // 
            this.TCSize.Location = new System.Drawing.Point(3, 43);
            this.TCSize.Name = "TCSize";
            this.TCSize.SelectedTabPage = this.TPSize;
            this.TCSize.Size = new System.Drawing.Size(482, 189);
            this.TCSize.TabIndex = 60;
            this.TCSize.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TPSize,
            this.TPHistory});
            this.TCSize.Click += new System.EventHandler(this.TCSize_Click);
            // 
            // TPSize
            // 
            this.TPSize.Controls.Add(this.LuESizes_ID);
            this.TPSize.Controls.Add(this.LuECategory_ID);
            this.TPSize.Controls.Add(this.LuETypes_ID);
            this.TPSize.Controls.Add(this.CkEActive);
            this.TPSize.Controls.Add(this.lblSubTypeName);
            this.TPSize.Controls.Add(this.lblTypeName);
            this.TPSize.Controls.Add(this.TxtSizes_Assign_ID);
            this.TPSize.Controls.Add(this.lblSizeID);
            this.TPSize.Controls.Add(this.lblSizeName);
            this.TPSize.Name = "TPSize";
            this.TPSize.Size = new System.Drawing.Size(480, 164);
            this.TPSize.Text = "Add Size";
            // 
            // LuESizes_ID
            // 
            this.LuESizes_ID.EnterMoveNextControl = true;
            this.LuESizes_ID.Location = new System.Drawing.Point(196, 103);
            this.LuESizes_ID.Name = "LuESizes_ID";
            this.LuESizes_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuESizes_ID.Properties.Appearance.Options.UseFont = true;
            this.LuESizes_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuESizes_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Size_Name", "Name")});
            this.LuESizes_ID.Properties.NullText = "";
            this.LuESizes_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuESizes_ID.Properties.PopupSizeable = false;
            this.LuESizes_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuESizes_ID.Properties.ShowFooter = false;
            this.LuESizes_ID.Properties.ShowHeader = false;
            this.LuESizes_ID.Properties.ShowLines = false;
            this.LuESizes_ID.Size = new System.Drawing.Size(145, 20);
            this.LuESizes_ID.TabIndex = 3;
            this.LuESizes_ID.Tag = "*";
            // 
            // LuECategory_ID
            // 
            this.LuECategory_ID.EnterMoveNextControl = true;
            this.LuECategory_ID.Location = new System.Drawing.Point(196, 75);
            this.LuECategory_ID.Name = "LuECategory_ID";
            this.LuECategory_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuECategory_ID.Properties.Appearance.Options.UseFont = true;
            this.LuECategory_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuECategory_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category_Name", "Name")});
            this.LuECategory_ID.Properties.NullText = "";
            this.LuECategory_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuECategory_ID.Properties.PopupSizeable = false;
            this.LuECategory_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuECategory_ID.Properties.ShowFooter = false;
            this.LuECategory_ID.Properties.ShowHeader = false;
            this.LuECategory_ID.Properties.ShowLines = false;
            this.LuECategory_ID.Size = new System.Drawing.Size(145, 20);
            this.LuECategory_ID.TabIndex = 2;
            this.LuECategory_ID.Tag = "*";
            this.LuECategory_ID.EditValueChanged += new System.EventHandler(this.LuECategory_ID_EditValueChanged);
            // 
            // LuETypes_ID
            // 
            this.LuETypes_ID.EnterMoveNextControl = true;
            this.LuETypes_ID.Location = new System.Drawing.Point(196, 46);
            this.LuETypes_ID.Name = "LuETypes_ID";
            this.LuETypes_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuETypes_ID.Properties.Appearance.Options.UseFont = true;
            this.LuETypes_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuETypes_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Types_Name", "Name")});
            this.LuETypes_ID.Properties.NullText = "";
            this.LuETypes_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuETypes_ID.Properties.PopupSizeable = false;
            this.LuETypes_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuETypes_ID.Properties.ShowFooter = false;
            this.LuETypes_ID.Properties.ShowHeader = false;
            this.LuETypes_ID.Properties.ShowLines = false;
            this.LuETypes_ID.Size = new System.Drawing.Size(145, 20);
            this.LuETypes_ID.TabIndex = 1;
            this.LuETypes_ID.Tag = "*";
            this.LuETypes_ID.EditValueChanged += new System.EventHandler(this.LuETypes_ID_EditValueChanged);
            // 
            // CkEActive
            // 
            this.CkEActive.Location = new System.Drawing.Point(194, 129);
            this.CkEActive.Name = "CkEActive";
            this.CkEActive.Properties.Caption = "Active";
            this.CkEActive.Size = new System.Drawing.Size(75, 20);
            this.CkEActive.TabIndex = 18;
            this.CkEActive.TabStop = false;
            this.CkEActive.EditValueChanged += new System.EventHandler(this.CkEActive_EditValueChanged);
            // 
            // lblSubTypeName
            // 
            this.lblSubTypeName.AutoSize = true;
            this.lblSubTypeName.Location = new System.Drawing.Point(104, 78);
            this.lblSubTypeName.Name = "lblSubTypeName";
            this.lblSubTypeName.Size = new System.Drawing.Size(89, 13);
            this.lblSubTypeName.TabIndex = 16;
            this.lblSubTypeName.Text = "Sub Type  Name:";
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(128, 49);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(65, 13);
            this.lblTypeName.TabIndex = 14;
            this.lblTypeName.Text = "Type Name:";
            // 
            // TxtSizes_Assign_ID
            // 
            this.TxtSizes_Assign_ID.Location = new System.Drawing.Point(196, 19);
            this.TxtSizes_Assign_ID.Name = "TxtSizes_Assign_ID";
            this.TxtSizes_Assign_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtSizes_Assign_ID.TabIndex = 0;
            this.TxtSizes_Assign_ID.TabStop = false;
            // 
            // lblSizeID
            // 
            this.lblSizeID.AutoSize = true;
            this.lblSizeID.Location = new System.Drawing.Point(149, 22);
            this.lblSizeID.Name = "lblSizeID";
            this.lblSizeID.Size = new System.Drawing.Size(44, 13);
            this.lblSizeID.TabIndex = 3;
            this.lblSizeID.Text = "Size ID:";
            // 
            // lblSizeName
            // 
            this.lblSizeName.AutoSize = true;
            this.lblSizeName.Location = new System.Drawing.Point(133, 104);
            this.lblSizeName.Name = "lblSizeName";
            this.lblSizeName.Size = new System.Drawing.Size(60, 13);
            this.lblSizeName.TabIndex = 10;
            this.lblSizeName.Text = "Size Name:";
            // 
            // TPHistory
            // 
            this.TPHistory.Controls.Add(this.gridControl1);
            this.TPHistory.Name = "TPHistory";
            this.TPHistory.Size = new System.Drawing.Size(480, 164);
            this.TPHistory.Text = "History";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(476, 160);
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
            this.gridColumn6,
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
            this.gridColumn1.FieldName = "Sizes_Assign_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Type";
            this.gridColumn2.FieldName = "Types_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Category";
            this.gridColumn3.FieldName = "Category_Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Size";
            this.gridColumn6.FieldName = "Size_Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
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
            this.gridColumn4.VisibleIndex = 4;
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
            this.gridColumn5.VisibleIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(403, 234);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 22);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(326, 234);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 22);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(174, 235);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.Location = new System.Drawing.Point(20, 235);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(71, 22);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(97, 235);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(71, 22);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(251, 235);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 22);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmSizAssigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TCSize);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSizAssigns.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSizAssigns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Assign Size";
            this.Load += new System.EventHandler(this.frmSizes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCSize)).EndInit();
            this.TCSize.ResumeLayout(false);
            this.TPSize.ResumeLayout(false);
            this.TPSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuESizes_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuECategory_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuETypes_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSizes_Assign_ID.Properties)).EndInit();
            this.TPHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAssignSize;
        private DevExpress.XtraTab.XtraTabControl TCSize;
        private DevExpress.XtraTab.XtraTabPage TPSize;
        private DevExpress.XtraEditors.TextEdit TxtSizes_Assign_ID;
        private System.Windows.Forms.Label lblSizeID;
        private System.Windows.Forms.Label lblSizeName;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private System.Windows.Forms.Label lblSubTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraEditors.CheckEdit CkEActive;
        private DevExpress.XtraEditors.LookUpEdit LuETypes_ID;
        private DevExpress.XtraEditors.LookUpEdit LuECategory_ID;
        private DevExpress.XtraEditors.LookUpEdit LuESizes_ID;
        private DevExpress.XtraTab.XtraTabPage TPHistory;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}