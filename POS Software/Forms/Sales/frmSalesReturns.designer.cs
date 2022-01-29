namespace POS_Software.Forms.Sales
{
    partial class frmSalesReturns
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReturns));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sales_Detail_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sale_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unit_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RPTUnitPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Pack_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepTxtQty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CkEDelete = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.LuEItem_ID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalesReturn = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TPSalesReturn = new DevExpress.XtraTab.XtraTabPage();
            this.lblCellNo = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.TxtGetRegularCustomer = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetRegularCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblCustomerBalance = new System.Windows.Forms.Label();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnGetInvoiceData = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtShopAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblShopAmount = new System.Windows.Forms.Label();
            this.TxtTaxAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.TxtTaxPercentage = new DevExpress.XtraEditors.TextEdit();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.TxtCheckOrCreditNo = new DevExpress.XtraEditors.TextEdit();
            this.TxtGrandAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.TxtBalance = new DevExpress.XtraEditors.TextEdit();
            this.lblGrandAmount = new System.Windows.Forms.Label();
            this.LuEPaymentType_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtRecievePayment = new DevExpress.XtraEditors.TextEdit();
            this.lblReceivedAmount = new System.Windows.Forms.Label();
            this.TxtAdmin = new DevExpress.XtraEditors.TextEdit();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.LuECustomerType_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.DtEInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.TxtInvoiceNumber = new DevExpress.XtraEditors.TextEdit();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPTUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepTxtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_ID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TPSalesReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGetRegularCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtShopAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxPercentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCheckOrCreditNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrandAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEPaymentType_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRecievePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuECustomerType_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(7, 62);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepTxtQty,
            this.CkEDelete,
            this.LuEItem_ID,
            this.RPTUnitPrice});
            this.gridControl1.Size = new System.Drawing.Size(768, 373);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sales_Detail_ID,
            this.Sale_ID,
            this.Item_ID,
            this.Item_Barcode,
            this.Item_Name,
            this.Unit_Price,
            this.Pack_Price,
            this.Qty,
            this.Amount,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.Unit_Name,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // Sales_Detail_ID
            // 
            this.Sales_Detail_ID.Caption = "Sales_Detail_ID";
            this.Sales_Detail_ID.FieldName = "Sales_Detail_ID";
            this.Sales_Detail_ID.Name = "Sales_Detail_ID";
            this.Sales_Detail_ID.OptionsColumn.AllowEdit = false;
            this.Sales_Detail_ID.OptionsColumn.AllowFocus = false;
            this.Sales_Detail_ID.OptionsColumn.FixedWidth = true;
            // 
            // Sale_ID
            // 
            this.Sale_ID.Caption = "Sale_ID";
            this.Sale_ID.FieldName = "Sale_ID";
            this.Sale_ID.Name = "Sale_ID";
            this.Sale_ID.OptionsColumn.AllowEdit = false;
            this.Sale_ID.OptionsColumn.AllowFocus = false;
            this.Sale_ID.OptionsColumn.FixedWidth = true;
            // 
            // Item_ID
            // 
            this.Item_ID.Caption = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.OptionsColumn.AllowEdit = false;
            this.Item_ID.OptionsColumn.AllowFocus = false;
            this.Item_ID.OptionsColumn.FixedWidth = true;
            // 
            // Item_Barcode
            // 
            this.Item_Barcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Barcode.AppearanceCell.Options.UseFont = true;
            this.Item_Barcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Barcode.AppearanceHeader.Options.UseFont = true;
            this.Item_Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Barcode.Caption = "Barcode";
            this.Item_Barcode.FieldName = "Item_Barcode";
            this.Item_Barcode.Name = "Item_Barcode";
            this.Item_Barcode.OptionsColumn.AllowEdit = false;
            this.Item_Barcode.OptionsColumn.AllowFocus = false;
            this.Item_Barcode.OptionsColumn.FixedWidth = true;
            this.Item_Barcode.Visible = true;
            this.Item_Barcode.VisibleIndex = 0;
            this.Item_Barcode.Width = 100;
            // 
            // Item_Name
            // 
            this.Item_Name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceCell.Options.UseFont = true;
            this.Item_Name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceHeader.Options.UseFont = true;
            this.Item_Name.Caption = "Item Name";
            this.Item_Name.FieldName = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.OptionsColumn.AllowFocus = false;
            this.Item_Name.OptionsColumn.FixedWidth = true;
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 1;
            this.Item_Name.Width = 250;
            // 
            // Unit_Price
            // 
            this.Unit_Price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_Price.AppearanceCell.Options.UseFont = true;
            this.Unit_Price.AppearanceCell.Options.UseTextOptions = true;
            this.Unit_Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Unit_Price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit_Price.AppearanceHeader.Options.UseFont = true;
            this.Unit_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Unit_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Unit_Price.Caption = "Unit Price";
            this.Unit_Price.ColumnEdit = this.RPTUnitPrice;
            this.Unit_Price.FieldName = "Item_Sale_Price";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.OptionsColumn.AllowFocus = false;
            this.Unit_Price.OptionsColumn.FixedWidth = true;
            this.Unit_Price.Visible = true;
            this.Unit_Price.VisibleIndex = 2;
            // 
            // RPTUnitPrice
            // 
            this.RPTUnitPrice.AutoHeight = false;
            this.RPTUnitPrice.Name = "RPTUnitPrice";
            this.RPTUnitPrice.Leave += new System.EventHandler(this.RPTUnitPrice_Leave);
            // 
            // Pack_Price
            // 
            this.Pack_Price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pack_Price.AppearanceCell.Options.UseFont = true;
            this.Pack_Price.AppearanceCell.Options.UseTextOptions = true;
            this.Pack_Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Pack_Price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pack_Price.AppearanceHeader.Options.UseFont = true;
            this.Pack_Price.Caption = "Pack Price";
            this.Pack_Price.FieldName = "Pack_Price";
            this.Pack_Price.Name = "Pack_Price";
            this.Pack_Price.OptionsColumn.AllowEdit = false;
            this.Pack_Price.OptionsColumn.AllowFocus = false;
            this.Pack_Price.OptionsColumn.FixedWidth = true;
            this.Pack_Price.Visible = true;
            this.Pack_Price.VisibleIndex = 3;
            // 
            // Qty
            // 
            this.Qty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.AppearanceCell.Options.UseFont = true;
            this.Qty.AppearanceCell.Options.UseTextOptions = true;
            this.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Qty.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.AppearanceHeader.Options.UseFont = true;
            this.Qty.AppearanceHeader.Options.UseTextOptions = true;
            this.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Qty.Caption = "Quantity";
            this.Qty.ColumnEdit = this.RepTxtQty;
            this.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Qty.FieldName = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.OptionsColumn.FixedWidth = true;
            this.Qty.Visible = true;
            this.Qty.VisibleIndex = 4;
            // 
            // RepTxtQty
            // 
            this.RepTxtQty.AutoHeight = false;
            this.RepTxtQty.Name = "RepTxtQty";
            this.RepTxtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepTxtQty_KeyPress);
            this.RepTxtQty.Leave += new System.EventHandler(this.RepTxtQty_Leave);
            // 
            // Amount
            // 
            this.Amount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.AppearanceCell.Options.UseFont = true;
            this.Amount.AppearanceCell.Options.UseTextOptions = true;
            this.Amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Amount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.AppearanceHeader.Options.UseFont = true;
            this.Amount.AppearanceHeader.Options.UseTextOptions = true;
            this.Amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Amount.Caption = "Amount";
            this.Amount.FieldName = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.OptionsColumn.AllowEdit = false;
            this.Amount.OptionsColumn.AllowFocus = false;
            this.Amount.OptionsColumn.FixedWidth = true;
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 5;
            this.Amount.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "PreQty";
            this.gridColumn1.FieldName = "PreQty";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Width = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Total_Stock";
            this.gridColumn2.FieldName = "Total_Stock";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Width = 30;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Stock_ID";
            this.gridColumn3.FieldName = "Stock_ID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Width = 31;
            // 
            // Unit_Name
            // 
            this.Unit_Name.Caption = "Unit_Name";
            this.Unit_Name.FieldName = "Unit_Name";
            this.Unit_Name.Name = "Unit_Name";
            this.Unit_Name.OptionsColumn.AllowEdit = false;
            this.Unit_Name.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Piece_Per_Pack";
            this.gridColumn4.FieldName = "Piece_Per_Pack";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "IsPacked";
            this.gridColumn5.FieldName = "IsPacked";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // CkEDelete
            // 
            this.CkEDelete.AutoHeight = false;
            this.CkEDelete.Caption = "Check";
            this.CkEDelete.Name = "CkEDelete";
            // 
            // LuEItem_ID
            // 
            this.LuEItem_ID.AutoHeight = false;
            this.LuEItem_ID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEItem_ID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Item_Name", "Name")});
            this.LuEItem_ID.Name = "LuEItem_ID";
            this.LuEItem_ID.NullText = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblSalesReturn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 39);
            this.panel1.TabIndex = 47;
            // 
            // lblSalesReturn
            // 
            this.lblSalesReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalesReturn.AutoSize = true;
            this.lblSalesReturn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReturn.ForeColor = System.Drawing.Color.White;
            this.lblSalesReturn.Location = new System.Drawing.Point(433, 8);
            this.lblSalesReturn.Name = "lblSalesReturn";
            this.lblSalesReturn.Size = new System.Drawing.Size(141, 23);
            this.lblSalesReturn.TabIndex = 0;
            this.lblSalesReturn.Text = "Sales Returns";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 39);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TPSalesReturn;
            this.xtraTabControl1.Size = new System.Drawing.Size(1001, 517);
            this.xtraTabControl1.TabIndex = 51;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TPSalesReturn});
            // 
            // TPSalesReturn
            // 
            this.TPSalesReturn.Controls.Add(this.lblCellNo);
            this.TPSalesReturn.Controls.Add(this.btnCancel);
            this.TPSalesReturn.Controls.Add(this.btnExit);
            this.TPSalesReturn.Controls.Add(this.TxtGetRegularCustomer);
            this.TPSalesReturn.Controls.Add(this.btnDelete);
            this.TPSalesReturn.Controls.Add(this.btnGetRegularCustomer);
            this.TPSalesReturn.Controls.Add(this.label14);
            this.TPSalesReturn.Controls.Add(this.btnEdit);
            this.TPSalesReturn.Controls.Add(this.btnSave);
            this.TPSalesReturn.Controls.Add(this.lblCustomerBalance);
            this.TPSalesReturn.Controls.Add(this.btnNew);
            this.TPSalesReturn.Controls.Add(this.lblCustName);
            this.TPSalesReturn.Controls.Add(this.lblCustomerName);
            this.TPSalesReturn.Controls.Add(this.btnGetInvoiceData);
            this.TPSalesReturn.Controls.Add(this.groupControl1);
            this.TPSalesReturn.Controls.Add(this.TxtAdmin);
            this.TPSalesReturn.Controls.Add(this.lblUser);
            this.TPSalesReturn.Controls.Add(this.lblCustomerType);
            this.TPSalesReturn.Controls.Add(this.LuECustomerType_ID);
            this.TPSalesReturn.Controls.Add(this.lblDate);
            this.TPSalesReturn.Controls.Add(this.lblInvoiceNumber);
            this.TPSalesReturn.Controls.Add(this.DtEInvoiceDate);
            this.TPSalesReturn.Controls.Add(this.gridControl1);
            this.TPSalesReturn.Controls.Add(this.TxtInvoiceNumber);
            this.TPSalesReturn.Name = "TPSalesReturn";
            this.TPSalesReturn.Size = new System.Drawing.Size(999, 492);
            this.TPSalesReturn.Text = "Sales Returns";
            // 
            // lblCellNo
            // 
            this.lblCellNo.AutoSize = true;
            this.lblCellNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNo.Location = new System.Drawing.Point(572, 7);
            this.lblCellNo.Name = "lblCellNo";
            this.lblCellNo.Size = new System.Drawing.Size(111, 13);
            this.lblCellNo.TabIndex = 93;
            this.lblCellNo.Text = "Code/Cell Number:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(819, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 26);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(907, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TxtGetRegularCustomer
            // 
            this.TxtGetRegularCustomer.Enabled = false;
            this.TxtGetRegularCustomer.EnterMoveNextControl = true;
            this.TxtGetRegularCustomer.Location = new System.Drawing.Point(575, 25);
            this.TxtGetRegularCustomer.Name = "TxtGetRegularCustomer";
            this.TxtGetRegularCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGetRegularCustomer.Properties.Appearance.Options.UseFont = true;
            this.TxtGetRegularCustomer.Size = new System.Drawing.Size(132, 22);
            this.TxtGetRegularCustomer.TabIndex = 92;
            this.TxtGetRegularCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGetRegularCustomer_KeyPress);
            this.TxtGetRegularCustomer.Leave += new System.EventHandler(this.TxtGetRegularCustomer_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(731, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 26);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetRegularCustomer
            // 
            this.btnGetRegularCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRegularCustomer.Appearance.Options.UseFont = true;
            this.btnGetRegularCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGetRegularCustomer.ImageOptions.Image")));
            this.btnGetRegularCustomer.Location = new System.Drawing.Point(713, 25);
            this.btnGetRegularCustomer.Name = "btnGetRegularCustomer";
            this.btnGetRegularCustomer.Size = new System.Drawing.Size(50, 22);
            this.btnGetRegularCustomer.TabIndex = 91;
            this.btnGetRegularCustomer.Text = "Find";
            this.btnGetRegularCustomer.Click += new System.EventHandler(this.btnGetRegularCustomer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(915, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "00";
            this.label14.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(555, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 26);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(643, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 26);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCustomerBalance
            // 
            this.lblCustomerBalance.AutoSize = true;
            this.lblCustomerBalance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerBalance.Location = new System.Drawing.Point(776, 40);
            this.lblCustomerBalance.Name = "lblCustomerBalance";
            this.lblCustomerBalance.Size = new System.Drawing.Size(115, 13);
            this.lblCustomerBalance.TabIndex = 89;
            this.lblCustomerBalance.Text = "Customer Balance :";
            this.lblCustomerBalance.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(469, 446);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 26);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(776, 2);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(103, 13);
            this.lblCustName.TabIndex = 88;
            this.lblCustName.Text = "Customer Name :";
            this.lblCustName.Visible = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(775, 18);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(148, 18);
            this.lblCustomerName.TabIndex = 87;
            this.lblCustomerName.Text = "Name Of Customer";
            this.lblCustomerName.Visible = false;
            // 
            // btnGetInvoiceData
            // 
            this.btnGetInvoiceData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGetInvoiceData.ImageOptions.Image")));
            this.btnGetInvoiceData.Location = new System.Drawing.Point(118, 24);
            this.btnGetInvoiceData.Name = "btnGetInvoiceData";
            this.btnGetInvoiceData.Size = new System.Drawing.Size(48, 23);
            this.btnGetInvoiceData.TabIndex = 71;
            this.btnGetInvoiceData.Text = "Get";
            this.btnGetInvoiceData.Click += new System.EventHandler(this.btnGetInvoiceData_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.Transparent;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Location = new System.Drawing.Point(779, 64);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(210, 373);
            this.groupControl1.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TxtShopAmount);
            this.panel2.Controls.Add(this.lblShopAmount);
            this.panel2.Controls.Add(this.TxtTaxAmount);
            this.panel2.Controls.Add(this.lblTaxAmount);
            this.panel2.Controls.Add(this.TxtTaxPercentage);
            this.panel2.Controls.Add(this.lblTax);
            this.panel2.Controls.Add(this.lblCardNo);
            this.panel2.Controls.Add(this.TxtCheckOrCreditNo);
            this.panel2.Controls.Add(this.TxtGrandAmount);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.lblPaymentType);
            this.panel2.Controls.Add(this.TxtBalance);
            this.panel2.Controls.Add(this.lblGrandAmount);
            this.panel2.Controls.Add(this.LuEPaymentType_ID);
            this.panel2.Controls.Add(this.TxtRecievePayment);
            this.panel2.Controls.Add(this.lblReceivedAmount);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 369);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TxtShopAmount
            // 
            this.TxtShopAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtShopAmount.EnterMoveNextControl = true;
            this.TxtShopAmount.Location = new System.Drawing.Point(11, 294);
            this.TxtShopAmount.Name = "TxtShopAmount";
            this.TxtShopAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtShopAmount.Properties.Appearance.Options.UseFont = true;
            this.TxtShopAmount.Properties.MaxLength = 15;
            this.TxtShopAmount.Size = new System.Drawing.Size(169, 20);
            this.TxtShopAmount.TabIndex = 85;
            this.TxtShopAmount.Tag = "*";
            // 
            // lblShopAmount
            // 
            this.lblShopAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShopAmount.AutoSize = true;
            this.lblShopAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopAmount.Location = new System.Drawing.Point(11, 276);
            this.lblShopAmount.Name = "lblShopAmount";
            this.lblShopAmount.Size = new System.Drawing.Size(90, 16);
            this.lblShopAmount.TabIndex = 86;
            this.lblShopAmount.Text = "NET Amount:";
            // 
            // TxtTaxAmount
            // 
            this.TxtTaxAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTaxAmount.EnterMoveNextControl = true;
            this.TxtTaxAmount.Location = new System.Drawing.Point(11, 253);
            this.TxtTaxAmount.Name = "TxtTaxAmount";
            this.TxtTaxAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTaxAmount.Properties.Appearance.Options.UseFont = true;
            this.TxtTaxAmount.Properties.MaxLength = 15;
            this.TxtTaxAmount.Size = new System.Drawing.Size(169, 20);
            this.TxtTaxAmount.TabIndex = 83;
            this.TxtTaxAmount.Tag = "*";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.Location = new System.Drawing.Point(11, 235);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(94, 16);
            this.lblTaxAmount.TabIndex = 84;
            this.lblTaxAmount.Text = "VAT Amount:";
            // 
            // TxtTaxPercentage
            // 
            this.TxtTaxPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTaxPercentage.Enabled = false;
            this.TxtTaxPercentage.EnterMoveNextControl = true;
            this.TxtTaxPercentage.Location = new System.Drawing.Point(11, 211);
            this.TxtTaxPercentage.Name = "TxtTaxPercentage";
            this.TxtTaxPercentage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTaxPercentage.Properties.Appearance.Options.UseFont = true;
            this.TxtTaxPercentage.Properties.MaxLength = 15;
            this.TxtTaxPercentage.Size = new System.Drawing.Size(169, 20);
            this.TxtTaxPercentage.TabIndex = 81;
            this.TxtTaxPercentage.Tag = "*";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(11, 192);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(48, 16);
            this.lblTax.TabIndex = 82;
            this.lblTax.Text = "VAT%";
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(11, 109);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(108, 16);
            this.lblCardNo.TabIndex = 76;
            this.lblCardNo.Text = "Check/Card No.";
            // 
            // TxtCheckOrCreditNo
            // 
            this.TxtCheckOrCreditNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCheckOrCreditNo.EditValue = "0";
            this.TxtCheckOrCreditNo.Location = new System.Drawing.Point(11, 126);
            this.TxtCheckOrCreditNo.Name = "TxtCheckOrCreditNo";
            this.TxtCheckOrCreditNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCheckOrCreditNo.Properties.Appearance.Options.UseFont = true;
            this.TxtCheckOrCreditNo.Properties.MaxLength = 20;
            this.TxtCheckOrCreditNo.Size = new System.Drawing.Size(178, 20);
            this.TxtCheckOrCreditNo.TabIndex = 75;
            this.TxtCheckOrCreditNo.Tag = "*";
            // 
            // TxtGrandAmount
            // 
            this.TxtGrandAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtGrandAmount.Location = new System.Drawing.Point(11, 39);
            this.TxtGrandAmount.Name = "TxtGrandAmount";
            this.TxtGrandAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGrandAmount.Properties.Appearance.Options.UseFont = true;
            this.TxtGrandAmount.Properties.ReadOnly = true;
            this.TxtGrandAmount.Size = new System.Drawing.Size(178, 26);
            this.TxtGrandAmount.TabIndex = 61;
            this.TxtGrandAmount.TabStop = false;
            this.TxtGrandAmount.Tag = "*";
            this.TxtGrandAmount.EditValueChanged += new System.EventHandler(this.TxtGrandAmount_EditValueChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(11, 317);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 16);
            this.lblBalance.TabIndex = 66;
            this.lblBalance.Text = "Balance:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(11, 68);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(105, 16);
            this.lblPaymentType.TabIndex = 68;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // TxtBalance
            // 
            this.TxtBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBalance.Location = new System.Drawing.Point(11, 335);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBalance.Properties.Appearance.Options.UseFont = true;
            this.TxtBalance.Properties.ReadOnly = true;
            this.TxtBalance.Size = new System.Drawing.Size(178, 20);
            this.TxtBalance.TabIndex = 63;
            this.TxtBalance.TabStop = false;
            // 
            // lblGrandAmount
            // 
            this.lblGrandAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrandAmount.AutoSize = true;
            this.lblGrandAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandAmount.Location = new System.Drawing.Point(11, 22);
            this.lblGrandAmount.Name = "lblGrandAmount";
            this.lblGrandAmount.Size = new System.Drawing.Size(106, 16);
            this.lblGrandAmount.TabIndex = 69;
            this.lblGrandAmount.Text = "Grand Amount:";
            // 
            // LuEPaymentType_ID
            // 
            this.LuEPaymentType_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LuEPaymentType_ID.Enabled = false;
            this.LuEPaymentType_ID.Location = new System.Drawing.Point(11, 86);
            this.LuEPaymentType_ID.Name = "LuEPaymentType_ID";
            this.LuEPaymentType_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEPaymentType_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEPaymentType_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEPaymentType_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Payment_Type", "Name")});
            this.LuEPaymentType_ID.Properties.NullText = "";
            this.LuEPaymentType_ID.Size = new System.Drawing.Size(178, 20);
            this.LuEPaymentType_ID.TabIndex = 67;
            this.LuEPaymentType_ID.TabStop = false;
            this.LuEPaymentType_ID.EditValueChanged += new System.EventHandler(this.LuEPaymentType_ID_EditValueChanged);
            // 
            // TxtRecievePayment
            // 
            this.TxtRecievePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRecievePayment.Location = new System.Drawing.Point(11, 169);
            this.TxtRecievePayment.Name = "TxtRecievePayment";
            this.TxtRecievePayment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecievePayment.Properties.Appearance.Options.UseFont = true;
            this.TxtRecievePayment.Size = new System.Drawing.Size(178, 20);
            this.TxtRecievePayment.TabIndex = 3;
            this.TxtRecievePayment.Tag = "*";
            this.TxtRecievePayment.EditValueChanged += new System.EventHandler(this.TxtRecievePayment_EditValueChanged);
            this.TxtRecievePayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecievePayment_KeyPress);
            // 
            // lblReceivedAmount
            // 
            this.lblReceivedAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceivedAmount.AutoSize = true;
            this.lblReceivedAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedAmount.Location = new System.Drawing.Point(11, 150);
            this.lblReceivedAmount.Name = "lblReceivedAmount";
            this.lblReceivedAmount.Size = new System.Drawing.Size(122, 16);
            this.lblReceivedAmount.TabIndex = 65;
            this.lblReceivedAmount.Text = "Recieved Amount";
            // 
            // TxtAdmin
            // 
            this.TxtAdmin.EditValue = "Admin";
            this.TxtAdmin.Enabled = false;
            this.TxtAdmin.Location = new System.Drawing.Point(485, 26);
            this.TxtAdmin.Name = "TxtAdmin";
            this.TxtAdmin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdmin.Properties.Appearance.Options.UseFont = true;
            this.TxtAdmin.Properties.ReadOnly = true;
            this.TxtAdmin.Size = new System.Drawing.Size(84, 22);
            this.TxtAdmin.TabIndex = 58;
            this.TxtAdmin.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(482, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 13);
            this.lblUser.TabIndex = 57;
            this.lblUser.Text = "User:";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(315, 10);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(96, 13);
            this.lblCustomerType.TabIndex = 56;
            this.lblCustomerType.Text = "Customer Type:";
            // 
            // LuECustomerType_ID
            // 
            this.LuECustomerType_ID.Enabled = false;
            this.LuECustomerType_ID.Location = new System.Drawing.Point(318, 25);
            this.LuECustomerType_ID.Name = "LuECustomerType_ID";
            this.LuECustomerType_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuECustomerType_ID.Properties.Appearance.Options.UseFont = true;
            this.LuECustomerType_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuECustomerType_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer_Name", "Name")});
            this.LuECustomerType_ID.Properties.NullText = "";
            this.LuECustomerType_ID.Properties.PopupFormMinSize = new System.Drawing.Size(50, 50);
            this.LuECustomerType_ID.Properties.PopupSizeable = false;
            this.LuECustomerType_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuECustomerType_ID.Properties.ShowFooter = false;
            this.LuECustomerType_ID.Size = new System.Drawing.Size(161, 22);
            this.LuECustomerType_ID.TabIndex = 55;
            this.LuECustomerType_ID.TabStop = false;
            this.LuECustomerType_ID.EditValueChanged += new System.EventHandler(this.LuECustomerType_ID_EditValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(169, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 13);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "Date:";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(3, 10);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(99, 13);
            this.lblInvoiceNumber.TabIndex = 52;
            this.lblInvoiceNumber.Text = "Invoice Number:";
            // 
            // DtEInvoiceDate
            // 
            this.DtEInvoiceDate.EditValue = new System.DateTime(2017, 8, 16, 12, 49, 0, 818);
            this.DtEInvoiceDate.Location = new System.Drawing.Point(172, 25);
            this.DtEInvoiceDate.Name = "DtEInvoiceDate";
            this.DtEInvoiceDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEInvoiceDate.Properties.Appearance.Options.UseFont = true;
            this.DtEInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEInvoiceDate.Size = new System.Drawing.Size(140, 22);
            this.DtEInvoiceDate.TabIndex = 2;
            this.DtEInvoiceDate.Tag = "*";
            // 
            // TxtInvoiceNumber
            // 
            this.TxtInvoiceNumber.EditValue = "";
            this.TxtInvoiceNumber.Location = new System.Drawing.Point(7, 25);
            this.TxtInvoiceNumber.Name = "TxtInvoiceNumber";
            this.TxtInvoiceNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInvoiceNumber.Properties.Appearance.Options.UseFont = true;
            this.TxtInvoiceNumber.Size = new System.Drawing.Size(108, 22);
            this.TxtInvoiceNumber.TabIndex = 1;
            this.TxtInvoiceNumber.Tag = "";
            this.TxtInvoiceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInvoiceNumber_KeyPress);
            this.TxtInvoiceNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtInvoiceNumber_KeyUp);
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmSalesReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 560);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSalesReturns.IconOptions.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSalesReturns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sale Returns";
            this.Load += new System.EventHandler(this.frmSalesInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPTUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepTxtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_ID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TPSalesReturn.ResumeLayout(false);
            this.TPSalesReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGetRegularCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtShopAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxPercentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCheckOrCreditNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGrandAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEPaymentType_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRecievePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuECustomerType_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn Unit_Price;
        private DevExpress.XtraGrid.Columns.GridColumn Qty;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalesReturn;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TPSalesReturn;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private DevExpress.XtraEditors.DateEdit DtEInvoiceDate;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceNumber;
        private System.Windows.Forms.Label lblDate;
        private DevExpress.XtraEditors.TextEdit TxtAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCustomerType;
        private DevExpress.XtraEditors.LookUpEdit LuECustomerType_ID;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblReceivedAmount;
        private DevExpress.XtraEditors.TextEdit TxtBalance;
        private DevExpress.XtraEditors.TextEdit TxtRecievePayment;
        private DevExpress.XtraEditors.TextEdit TxtGrandAmount;
        private System.Windows.Forms.Label lblPaymentType;
        private DevExpress.XtraEditors.LookUpEdit LuEPaymentType_ID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrandAmount;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepTxtQty;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CkEDelete;
        private DevExpress.XtraGrid.Columns.GridColumn Sales_Detail_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Sale_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LuEItem_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn Item_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Unit_Name;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn Pack_Price;
        private DevExpress.XtraEditors.SimpleButton btnGetInvoiceData;
        private System.Windows.Forms.Label lblCardNo;
        private DevExpress.XtraEditors.TextEdit TxtCheckOrCreditNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCustomerBalance;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCellNo;
        private DevExpress.XtraEditors.TextEdit TxtGetRegularCustomer;
        private DevExpress.XtraEditors.SimpleButton btnGetRegularCustomer;
        private DevExpress.XtraEditors.TextEdit TxtShopAmount;
        private System.Windows.Forms.Label lblShopAmount;
        private DevExpress.XtraEditors.TextEdit TxtTaxAmount;
        private System.Windows.Forms.Label lblTaxAmount;
        private DevExpress.XtraEditors.TextEdit TxtTaxPercentage;
        private System.Windows.Forms.Label lblTax;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RPTUnitPrice;
    }
}