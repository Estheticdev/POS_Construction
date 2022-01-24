namespace POS_Software.Forms.Stock
{
    partial class OldFrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldFrmStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.AddStock = new DevExpress.XtraTab.XtraTabControl();
            this.TabAddStock = new DevExpress.XtraTab.XtraTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtQty = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Stock_Detail_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stock_In = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColItem_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StockID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.StockDetail = new DevExpress.XtraTab.XtraTabPage();
            this.btnYesterday = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToday = new DevExpress.XtraEditors.SimpleButton();
            this.btnBetweenDate = new DevExpress.XtraEditors.SimpleButton();
            this.DtETo = new DevExpress.XtraEditors.DateEdit();
            this.DtEFrom = new DevExpress.XtraEditors.DateEdit();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStock)).BeginInit();
            this.AddStock.SuspendLayout();
            this.TabAddStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarcode.Properties)).BeginInit();
            this.StockDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
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
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(358, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Stock";
            // 
            // AddStock
            // 
            this.AddStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStock.Location = new System.Drawing.Point(4, 42);
            this.AddStock.Name = "AddStock";
            this.AddStock.SelectedTabPage = this.TabAddStock;
            this.AddStock.Size = new System.Drawing.Size(853, 459);
            this.AddStock.TabIndex = 17;
            this.AddStock.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAddStock,
            this.StockDetail});
            this.AddStock.Click += new System.EventHandler(this.AddStock_Click);
            // 
            // TabAddStock
            // 
            this.TabAddStock.Controls.Add(this.btnSearch);
            this.TabAddStock.Controls.Add(this.label3);
            this.TabAddStock.Controls.Add(this.label2);
            this.TabAddStock.Controls.Add(this.TxtQty);
            this.TabAddStock.Controls.Add(this.label1);
            this.TabAddStock.Controls.Add(this.gridControl2);
            this.TabAddStock.Controls.Add(this.gridControl1);
            this.TabAddStock.Controls.Add(this.TxtBarcode);
            this.TabAddStock.Controls.Add(this.btnAdd);
            this.TabAddStock.Name = "TabAddStock";
            this.TabAddStock.Size = new System.Drawing.Size(847, 431);
            this.TabAddStock.Text = "Add Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scan Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Qty:";
            // 
            // TxtQty
            // 
            this.TxtQty.EnterMoveNextControl = true;
            this.TxtQty.Location = new System.Drawing.Point(213, 30);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(71, 20);
            this.TxtQty.TabIndex = 1;
            this.TxtQty.Tag = "*";
            this.TxtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress);
            this.TxtQty.Leave += new System.EventHandler(this.TxtQty_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last 10 Stock Transaction";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(7, 122);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(834, 301);
            this.gridControl2.TabIndex = 99;
            this.gridControl2.TabStop = false;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stock_Detail_ID,
            this.Stock_ID,
            this.Item_Barcode,
            this.Item_Name,
            this.Stock_In,
            this.AddedOn,
            this.AddedBy,
            this.ColItem_ID});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyDown);
            // 
            // Stock_Detail_ID
            // 
            this.Stock_Detail_ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_Detail_ID.AppearanceCell.Options.UseFont = true;
            this.Stock_Detail_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_Detail_ID.AppearanceHeader.Options.UseFont = true;
            this.Stock_Detail_ID.Caption = "Detail ID";
            this.Stock_Detail_ID.FieldName = "Stock_Detail_ID";
            this.Stock_Detail_ID.Name = "Stock_Detail_ID";
            this.Stock_Detail_ID.OptionsColumn.AllowEdit = false;
            this.Stock_Detail_ID.OptionsColumn.AllowFocus = false;
            // 
            // Stock_ID
            // 
            this.Stock_ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_ID.AppearanceCell.Options.UseFont = true;
            this.Stock_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_ID.AppearanceHeader.Options.UseFont = true;
            this.Stock_ID.Caption = "Stock ID";
            this.Stock_ID.FieldName = "Stock_ID";
            this.Stock_ID.Name = "Stock_ID";
            this.Stock_ID.OptionsColumn.AllowEdit = false;
            this.Stock_ID.OptionsColumn.AllowFocus = false;
            // 
            // Item_Barcode
            // 
            this.Item_Barcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Barcode.AppearanceCell.Options.UseFont = true;
            this.Item_Barcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Barcode.AppearanceHeader.Options.UseFont = true;
            this.Item_Barcode.Caption = "Barcode";
            this.Item_Barcode.FieldName = "Item_Barcode";
            this.Item_Barcode.Name = "Item_Barcode";
            this.Item_Barcode.OptionsColumn.AllowEdit = false;
            this.Item_Barcode.OptionsColumn.AllowFocus = false;
            this.Item_Barcode.Visible = true;
            this.Item_Barcode.VisibleIndex = 0;
            this.Item_Barcode.Width = 119;
            // 
            // Item_Name
            // 
            this.Item_Name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceCell.Options.UseFont = true;
            this.Item_Name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceHeader.Options.UseFont = true;
            this.Item_Name.Caption = "Name";
            this.Item_Name.FieldName = "ItemName";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.OptionsColumn.AllowEdit = false;
            this.Item_Name.OptionsColumn.AllowFocus = false;
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 1;
            this.Item_Name.Width = 343;
            // 
            // Stock_In
            // 
            this.Stock_In.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_In.AppearanceCell.Options.UseFont = true;
            this.Stock_In.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_In.AppearanceHeader.Options.UseFont = true;
            this.Stock_In.Caption = "Stock In";
            this.Stock_In.FieldName = "Stock_In";
            this.Stock_In.Name = "Stock_In";
            this.Stock_In.OptionsColumn.AllowEdit = false;
            this.Stock_In.OptionsColumn.AllowFocus = false;
            this.Stock_In.Visible = true;
            this.Stock_In.VisibleIndex = 2;
            this.Stock_In.Width = 114;
            // 
            // AddedOn
            // 
            this.AddedOn.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedOn.AppearanceCell.Options.UseFont = true;
            this.AddedOn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedOn.AppearanceHeader.Options.UseFont = true;
            this.AddedOn.Caption = "Added On";
            this.AddedOn.FieldName = "Transaction_Date";
            this.AddedOn.Name = "AddedOn";
            this.AddedOn.OptionsColumn.AllowEdit = false;
            this.AddedOn.OptionsColumn.AllowFocus = false;
            this.AddedOn.Visible = true;
            this.AddedOn.VisibleIndex = 3;
            this.AddedOn.Width = 116;
            // 
            // AddedBy
            // 
            this.AddedBy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedBy.AppearanceCell.Options.UseFont = true;
            this.AddedBy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedBy.AppearanceHeader.Options.UseFont = true;
            this.AddedBy.Caption = "Added By";
            this.AddedBy.FieldName = "Transaction_By";
            this.AddedBy.Name = "AddedBy";
            this.AddedBy.OptionsColumn.AllowEdit = false;
            this.AddedBy.OptionsColumn.AllowFocus = false;
            this.AddedBy.Visible = true;
            this.AddedBy.VisibleIndex = 4;
            this.AddedBy.Width = 144;
            // 
            // ColItem_ID
            // 
            this.ColItem_ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColItem_ID.AppearanceCell.Options.UseFont = true;
            this.ColItem_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColItem_ID.AppearanceHeader.Options.UseFont = true;
            this.ColItem_ID.Caption = "Item_ID";
            this.ColItem_ID.FieldName = "Item_ID";
            this.ColItem_ID.Name = "ColItem_ID";
            this.ColItem_ID.OptionsColumn.AllowEdit = false;
            this.ColItem_ID.OptionsColumn.AllowFocus = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(7, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(834, 44);
            this.gridControl1.TabIndex = 100;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StockID,
            this.Item_ID,
            this.ItemBarcode,
            this.ItemName,
            this.TotalStock,
            this.LastUpdated,
            this.ModifyBy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // StockID
            // 
            this.StockID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockID.AppearanceCell.Options.UseFont = true;
            this.StockID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockID.AppearanceHeader.Options.UseFont = true;
            this.StockID.AppearanceHeader.Options.UseTextOptions = true;
            this.StockID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockID.Caption = "ID";
            this.StockID.FieldName = "Stock_ID";
            this.StockID.Name = "StockID";
            this.StockID.OptionsColumn.AllowEdit = false;
            this.StockID.OptionsColumn.AllowFocus = false;
            this.StockID.Width = 35;
            // 
            // Item_ID
            // 
            this.Item_ID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_ID.AppearanceCell.Options.UseFont = true;
            this.Item_ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_ID.AppearanceHeader.Options.UseFont = true;
            this.Item_ID.Caption = "Item_ID";
            this.Item_ID.FieldName = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.OptionsColumn.AllowEdit = false;
            this.Item_ID.OptionsColumn.AllowFocus = false;
            // 
            // ItemBarcode
            // 
            this.ItemBarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBarcode.AppearanceCell.Options.UseFont = true;
            this.ItemBarcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBarcode.AppearanceHeader.Options.UseFont = true;
            this.ItemBarcode.AppearanceHeader.Options.UseTextOptions = true;
            this.ItemBarcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemBarcode.Caption = "Barcode";
            this.ItemBarcode.FieldName = "Item_Barcode";
            this.ItemBarcode.Name = "ItemBarcode";
            this.ItemBarcode.OptionsColumn.AllowEdit = false;
            this.ItemBarcode.OptionsColumn.AllowFocus = false;
            this.ItemBarcode.Visible = true;
            this.ItemBarcode.VisibleIndex = 0;
            this.ItemBarcode.Width = 123;
            // 
            // ItemName
            // 
            this.ItemName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.AppearanceCell.Options.UseFont = true;
            this.ItemName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.AppearanceHeader.Options.UseFont = true;
            this.ItemName.AppearanceHeader.Options.UseTextOptions = true;
            this.ItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemName.Caption = "Name";
            this.ItemName.FieldName = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.OptionsColumn.AllowEdit = false;
            this.ItemName.OptionsColumn.AllowFocus = false;
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 1;
            this.ItemName.Width = 351;
            // 
            // TotalStock
            // 
            this.TotalStock.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStock.AppearanceCell.Options.UseFont = true;
            this.TotalStock.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStock.AppearanceHeader.Options.UseFont = true;
            this.TotalStock.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalStock.Caption = "Total Stock";
            this.TotalStock.FieldName = "Total_Stock";
            this.TotalStock.Name = "TotalStock";
            this.TotalStock.OptionsColumn.AllowEdit = false;
            this.TotalStock.OptionsColumn.AllowFocus = false;
            this.TotalStock.Visible = true;
            this.TotalStock.VisibleIndex = 2;
            this.TotalStock.Width = 118;
            // 
            // LastUpdated
            // 
            this.LastUpdated.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUpdated.AppearanceCell.Options.UseFont = true;
            this.LastUpdated.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUpdated.AppearanceHeader.Options.UseFont = true;
            this.LastUpdated.AppearanceHeader.Options.UseTextOptions = true;
            this.LastUpdated.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LastUpdated.Caption = "Last Updated";
            this.LastUpdated.FieldName = "Last_Updated";
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.OptionsColumn.AllowEdit = false;
            this.LastUpdated.OptionsColumn.AllowFocus = false;
            this.LastUpdated.Visible = true;
            this.LastUpdated.VisibleIndex = 3;
            this.LastUpdated.Width = 118;
            // 
            // ModifyBy
            // 
            this.ModifyBy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBy.AppearanceCell.Options.UseFont = true;
            this.ModifyBy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBy.AppearanceHeader.Options.UseFont = true;
            this.ModifyBy.AppearanceHeader.Options.UseTextOptions = true;
            this.ModifyBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ModifyBy.Caption = "Added By";
            this.ModifyBy.FieldName = "Modify_By";
            this.ModifyBy.Name = "ModifyBy";
            this.ModifyBy.OptionsColumn.AllowEdit = false;
            this.ModifyBy.OptionsColumn.AllowFocus = false;
            this.ModifyBy.Visible = true;
            this.ModifyBy.VisibleIndex = 4;
            this.ModifyBy.Width = 126;
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.EnterMoveNextControl = true;
            this.TxtBarcode.Location = new System.Drawing.Point(7, 30);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Size = new System.Drawing.Size(200, 20);
            this.TxtBarcode.TabIndex = 0;
            this.TxtBarcode.Tag = "*";
            this.TxtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBarcode_KeyPress);
            this.TxtBarcode.Leave += new System.EventHandler(this.TxtBarcode_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(294, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 20);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // StockDetail
            // 
            this.StockDetail.Controls.Add(this.btnYesterday);
            this.StockDetail.Controls.Add(this.label5);
            this.StockDetail.Controls.Add(this.label4);
            this.StockDetail.Controls.Add(this.btnToday);
            this.StockDetail.Controls.Add(this.btnBetweenDate);
            this.StockDetail.Controls.Add(this.DtETo);
            this.StockDetail.Controls.Add(this.DtEFrom);
            this.StockDetail.Controls.Add(this.gridControl3);
            this.StockDetail.Name = "StockDetail";
            this.StockDetail.Size = new System.Drawing.Size(847, 431);
            this.StockDetail.Text = "Stock Detail";
            // 
            // btnYesterday
            // 
            this.btnYesterday.Image = ((System.Drawing.Image)(resources.GetObject("btnYesterday.Image")));
            this.btnYesterday.Location = new System.Drawing.Point(511, 21);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(75, 23);
            this.btnYesterday.TabIndex = 11;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "To Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "From Date:";
            // 
            // btnToday
            // 
            this.btnToday.Image = ((System.Drawing.Image)(resources.GetObject("btnToday.Image")));
            this.btnToday.Location = new System.Drawing.Point(430, 21);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 8;
            this.btnToday.Text = "Today";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnBetweenDate
            // 
            this.btnBetweenDate.Image = ((System.Drawing.Image)(resources.GetObject("btnBetweenDate.Image")));
            this.btnBetweenDate.Location = new System.Drawing.Point(349, 21);
            this.btnBetweenDate.Name = "btnBetweenDate";
            this.btnBetweenDate.Size = new System.Drawing.Size(75, 23);
            this.btnBetweenDate.TabIndex = 7;
            this.btnBetweenDate.Text = "Between";
            this.btnBetweenDate.Click += new System.EventHandler(this.btnBetweenDate_Click);
            // 
            // DtETo
            // 
            this.DtETo.EditValue = null;
            this.DtETo.Location = new System.Drawing.Point(193, 24);
            this.DtETo.Name = "DtETo";
            this.DtETo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtETo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtETo.Size = new System.Drawing.Size(147, 20);
            this.DtETo.TabIndex = 6;
            this.DtETo.Tag = "";
            // 
            // DtEFrom
            // 
            this.DtEFrom.EditValue = null;
            this.DtEFrom.Location = new System.Drawing.Point(7, 24);
            this.DtEFrom.Name = "DtEFrom";
            this.DtEFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEFrom.Size = new System.Drawing.Size(147, 20);
            this.DtEFrom.TabIndex = 5;
            this.DtEFrom.Tag = "";
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.Location = new System.Drawing.Point(7, 47);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(834, 338);
            this.gridControl3.TabIndex = 4;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Detail ID";
            this.gridColumn1.FieldName = "Stock_Detail_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Stock ID";
            this.gridColumn2.FieldName = "Stock_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Barcode";
            this.gridColumn3.FieldName = "Item_Barcode";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 119;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Name";
            this.gridColumn4.FieldName = "ItemName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 343;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Stock Out";
            this.gridColumn5.FieldName = "Stock_Out";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 114;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Added On";
            this.gridColumn6.FieldName = "Transaction_Date";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 116;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "AddedBy";
            this.gridColumn7.FieldName = "Transaction_By";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 144;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.Caption = "Item_ID";
            this.gridColumn8.FieldName = "Item_ID";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(375, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 101;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 501);
            this.Controls.Add(this.AddStock);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Stock";
            this.Load += new System.EventHandler(this.OldFrmStock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStock_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddStock)).EndInit();
            this.AddStock.ResumeLayout(false);
            this.TabAddStock.ResumeLayout(false);
            this.TabAddStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarcode.Properties)).EndInit();
            this.StockDetail.ResumeLayout(false);
            this.StockDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraTab.XtraTabControl AddStock;
        private DevExpress.XtraTab.XtraTabPage TabAddStock;
        private DevExpress.XtraTab.XtraTabPage StockDetail;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TxtBarcode;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtQty;
        private DevExpress.XtraGrid.Columns.GridColumn StockID;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn TotalStock;
        private DevExpress.XtraGrid.Columns.GridColumn LastUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn Stock_Detail_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Stock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Stock_In;
        private DevExpress.XtraGrid.Columns.GridColumn AddedOn;
        private DevExpress.XtraGrid.Columns.GridColumn AddedBy;
        private DevExpress.XtraGrid.Columns.GridColumn ItemBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn Item_ID;
        private DevExpress.XtraGrid.Columns.GridColumn ColItem_ID;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnToday;
        private DevExpress.XtraEditors.SimpleButton btnBetweenDate;
        private DevExpress.XtraEditors.DateEdit DtETo;
        private DevExpress.XtraEditors.DateEdit DtEFrom;
        private DevExpress.XtraEditors.SimpleButton btnYesterday;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}