namespace POS_Software.Reports.Barcode
{
    partial class frmBarcodeTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcodeTag));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.TabBarcode = new DevExpress.XtraTab.XtraTabPage();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.LuEItem_Category = new DevExpress.XtraEditors.LookUpEdit();
            this.LuEItem_Types_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridBarcode = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Item_Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barcode_Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CkEStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepoSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.RepoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.TabBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Category.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Types_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 39);
            this.panel1.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(360, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Barcode Print";
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // TabBarcode
            // 
            this.TabBarcode.Controls.Add(this.btnSearch);
            this.TabBarcode.Controls.Add(this.LuEItem_Category);
            this.TabBarcode.Controls.Add(this.LuEItem_Types_ID);
            this.TabBarcode.Controls.Add(this.BtnPrint);
            this.TabBarcode.Controls.Add(this.label3);
            this.TabBarcode.Controls.Add(this.label1);
            this.TabBarcode.Controls.Add(this.GridBarcode);
            this.TabBarcode.Name = "TabBarcode";
            this.TabBarcode.Size = new System.Drawing.Size(846, 427);
            this.TabBarcode.Text = "Detail";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(668, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LuEItem_Category
            // 
            this.LuEItem_Category.EnterMoveNextControl = true;
            this.LuEItem_Category.Location = new System.Drawing.Point(377, 17);
            this.LuEItem_Category.Name = "LuEItem_Category";
            this.LuEItem_Category.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEItem_Category.Properties.Appearance.Options.UseFont = true;
            this.LuEItem_Category.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEItem_Category.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category_Name", "Name")});
            this.LuEItem_Category.Properties.NullText = "";
            this.LuEItem_Category.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuEItem_Category.Properties.PopupSizeable = false;
            this.LuEItem_Category.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuEItem_Category.Properties.ShowFooter = false;
            this.LuEItem_Category.Properties.ShowHeader = false;
            this.LuEItem_Category.Properties.ShowLines = false;
            this.LuEItem_Category.Size = new System.Drawing.Size(175, 22);
            this.LuEItem_Category.TabIndex = 80;
            this.LuEItem_Category.Tag = "*";
            this.LuEItem_Category.Leave += new System.EventHandler(this.LuEItem_Category_Leave);
            // 
            // LuEItem_Types_ID
            // 
            this.LuEItem_Types_ID.EnterMoveNextControl = true;
            this.LuEItem_Types_ID.Location = new System.Drawing.Point(153, 17);
            this.LuEItem_Types_ID.Name = "LuEItem_Types_ID";
            this.LuEItem_Types_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEItem_Types_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEItem_Types_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEItem_Types_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Types_Name", "Name")});
            this.LuEItem_Types_ID.Properties.NullText = "";
            this.LuEItem_Types_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuEItem_Types_ID.Properties.PopupSizeable = false;
            this.LuEItem_Types_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuEItem_Types_ID.Properties.ShowFooter = false;
            this.LuEItem_Types_ID.Properties.ShowHeader = false;
            this.LuEItem_Types_ID.Properties.ShowLines = false;
            this.LuEItem_Types_ID.Size = new System.Drawing.Size(190, 22);
            this.LuEItem_Types_ID.TabIndex = 79;
            this.LuEItem_Types_ID.Tag = "*";
            this.LuEItem_Types_ID.EditValueChanged += new System.EventHandler(this.LuEItem_Types_ID_EditValueChanged);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.Appearance.Options.UseFont = true;
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.Location = new System.Drawing.Point(576, 19);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(86, 20);
            this.BtnPrint.TabIndex = 76;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Item Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Items Type:";
            // 
            // GridBarcode
            // 
            this.GridBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBarcode.Location = new System.Drawing.Point(7, 45);
            this.GridBarcode.MainView = this.gridView1;
            this.GridBarcode.Name = "GridBarcode";
            this.GridBarcode.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepoSpinEdit,
            this.RepoCheck,
            this.repositoryItemSpinEdit1});
            this.GridBarcode.Size = new System.Drawing.Size(832, 375);
            this.GridBarcode.TabIndex = 75;
            this.GridBarcode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Item_Barcode,
            this.Item_Name,
            this.Barcode_Qty,
            this.CkEStatus});
            this.gridView1.GridControl = this.GridBarcode;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // Item_Barcode
            // 
            this.Item_Barcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Barcode.AppearanceCell.Options.UseFont = true;
            this.Item_Barcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Barcode.AppearanceHeader.Options.UseFont = true;
            this.Item_Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Barcode.Caption = "Barcode";
            this.Item_Barcode.FieldName = "Item_Barcode";
            this.Item_Barcode.Name = "Item_Barcode";
            this.Item_Barcode.OptionsColumn.AllowEdit = false;
            this.Item_Barcode.OptionsColumn.AllowFocus = false;
            this.Item_Barcode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.Item_Barcode.OptionsColumn.AllowMove = false;
            this.Item_Barcode.OptionsColumn.FixedWidth = true;
            this.Item_Barcode.OptionsColumn.ReadOnly = true;
            this.Item_Barcode.OptionsColumn.TabStop = false;
            this.Item_Barcode.Visible = true;
            this.Item_Barcode.VisibleIndex = 0;
            this.Item_Barcode.Width = 95;
            // 
            // Item_Name
            // 
            this.Item_Name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceCell.Options.UseFont = true;
            this.Item_Name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceHeader.Options.UseFont = true;
            this.Item_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Name.Caption = "Name";
            this.Item_Name.FieldName = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.OptionsColumn.AllowEdit = false;
            this.Item_Name.OptionsColumn.AllowFocus = false;
            this.Item_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.Item_Name.OptionsColumn.AllowMove = false;
            this.Item_Name.OptionsColumn.FixedWidth = true;
            this.Item_Name.OptionsColumn.ReadOnly = true;
            this.Item_Name.OptionsColumn.TabStop = false;
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 1;
            this.Item_Name.Width = 300;
            // 
            // Barcode_Qty
            // 
            this.Barcode_Qty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode_Qty.AppearanceCell.Options.UseFont = true;
            this.Barcode_Qty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode_Qty.AppearanceHeader.Options.UseFont = true;
            this.Barcode_Qty.AppearanceHeader.Options.UseTextOptions = true;
            this.Barcode_Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode_Qty.Caption = "Qty";
            this.Barcode_Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Barcode_Qty.FieldName = "Barcode_Qty";
            this.Barcode_Qty.Name = "Barcode_Qty";
            this.Barcode_Qty.OptionsColumn.FixedWidth = true;
            this.Barcode_Qty.Visible = true;
            this.Barcode_Qty.VisibleIndex = 2;
            // 
            // CkEStatus
            // 
            this.CkEStatus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkEStatus.AppearanceCell.Options.UseFont = true;
            this.CkEStatus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkEStatus.AppearanceHeader.Options.UseFont = true;
            this.CkEStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.CkEStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CkEStatus.Caption = "Status";
            this.CkEStatus.FieldName = "CkEStatus";
            this.CkEStatus.Name = "CkEStatus";
            this.CkEStatus.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.CkEStatus.OptionsColumn.AllowMove = false;
            this.CkEStatus.OptionsColumn.FixedWidth = true;
            this.CkEStatus.OptionsColumn.TabStop = false;
            this.CkEStatus.Visible = true;
            this.CkEStatus.VisibleIndex = 3;
            // 
            // RepoSpinEdit
            // 
            this.RepoSpinEdit.AutoHeight = false;
            this.RepoSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepoSpinEdit.Name = "RepoSpinEdit";
            this.RepoSpinEdit.NullText = "1";
            // 
            // RepoCheck
            // 
            this.RepoCheck.AutoHeight = false;
            this.RepoCheck.Caption = "Check";
            this.RepoCheck.Name = "RepoCheck";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 43);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabBarcode;
            this.xtraTabControl1.Size = new System.Drawing.Size(852, 455);
            this.xtraTabControl1.TabIndex = 69;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabBarcode});
            // 
            // frmBarcodeTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 501);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmBarcodeTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Print Barcode Tags";
            this.Load += new System.EventHandler(this.frmBarcodeTag_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBarcodeTag_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.TabBarcode.ResumeLayout(false);
            this.TabBarcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Category.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Types_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabBarcode;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl GridBarcode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode_Qty;
        private DevExpress.XtraGrid.Columns.GridColumn CkEStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit RepoSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepoCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.LookUpEdit LuEItem_Category;
        private DevExpress.XtraEditors.LookUpEdit LuEItem_Types_ID;
        private DevExpress.XtraEditors.SimpleButton btnSearch;

    }
}