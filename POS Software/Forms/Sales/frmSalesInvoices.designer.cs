namespace POS_Software.Forms.Sales
{
    partial class frmSalesInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesInvoices));
            this.TxtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Item_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Custom_Size = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Sale_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RPtUnitPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.PackPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepTxtQty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Item_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total_Stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stock_Critical_Level = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Percentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rppercentage = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Percentage_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalesInvoice = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TPSalesInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.LblComment = new System.Windows.Forms.Label();
            this.TxtComments = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCustomerBalance = new System.Windows.Forms.Label();
            this.lblCellNo = new System.Windows.Forms.Label();
            this.TxtGetRegularCustomer = new DevExpress.XtraEditors.TextEdit();
            this.btnGetRegularCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.lblRegCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnSimple = new DevExpress.XtraEditors.SimpleButton();
            this.lblScanBarcode = new System.Windows.Forms.Label();
            this.gPaymentBox = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txtguarantee = new DevExpress.XtraEditors.TextEdit();
            this.lblgurrentee = new System.Windows.Forms.Label();
            this.TxtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtShopAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblShopAmount = new System.Windows.Forms.Label();
            this.TxtTaxAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.TxtTaxPercentage = new DevExpress.XtraEditors.TextEdit();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.TxtCheckOrCreditNo = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
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
            this.TPTodaySale = new DevExpress.XtraTab.XtraTabPage();
            this.DtETo = new System.Windows.Forms.DateTimePicker();
            this.DtEFrom = new System.Windows.Forms.DateTimePicker();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtClear = new DevExpress.XtraEditors.SimpleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtInvoiceNumberSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnYesterday = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnToday = new DevExpress.XtraEditors.SimpleButton();
            this.btnBetweenDate = new DevExpress.XtraEditors.SimpleButton();
            this.DtETo1 = new DevExpress.XtraEditors.DateEdit();
            this.DtEFrom2 = new DevExpress.XtraEditors.DateEdit();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPtUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepTxtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rppercentage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TPSalesInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGetRegularCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPaymentBox)).BeginInit();
            this.gPaymentBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtguarantee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiscount.Properties)).BeginInit();
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
            this.TPTodaySale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceNumberSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.EnterMoveNextControl = true;
            this.TxtBarcode.Location = new System.Drawing.Point(7, 65);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBarcode.Properties.Appearance.Options.UseFont = true;
            this.TxtBarcode.Size = new System.Drawing.Size(164, 22);
            this.TxtBarcode.TabIndex = 0;
            this.TxtBarcode.EditValueChanged += new System.EventHandler(this.TxtBarcode_EditValueChanged);
            this.TxtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBarcode_KeyPress);
            this.TxtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBarcode_KeyUp);
            this.TxtBarcode.Leave += new System.EventHandler(this.TxtBarcode_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(180, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(5, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepTxtQty,
            this.RPtUnitPrice,
            this.rppercentage});
            this.gridControl1.Size = new System.Drawing.Size(972, 362);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Item_ID,
            this.Item_Barcode,
            this.Item_Name,
            this.Custom_Size,
            this.Item_Sale_Price,
            this.PackPrice,
            this.Qty,
            this.Item_Amount,
            this.Unit,
            this.Total_Stock,
            this.Stock_ID,
            this.Stock_Critical_Level,
            this.gridColumn7,
            this.gridColumn8,
            this.Percentage,
            this.Percentage_Amount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // Item_ID
            // 
            this.Item_ID.Caption = "Item_ID";
            this.Item_ID.FieldName = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.OptionsColumn.AllowFocus = false;
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
            this.Item_Barcode.Visible = true;
            this.Item_Barcode.VisibleIndex = 0;
            this.Item_Barcode.Width = 83;
            // 
            // Item_Name
            // 
            this.Item_Name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceCell.Options.UseFont = true;
            this.Item_Name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceHeader.Options.UseFont = true;
            this.Item_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Name.Caption = "Item Name";
            this.Item_Name.FieldName = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 1;
            this.Item_Name.Width = 228;
            // 
            // Custom_Size
            // 
            this.Custom_Size.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Custom_Size.AppearanceCell.Options.UseFont = true;
            this.Custom_Size.AppearanceCell.Options.UseTextOptions = true;
            this.Custom_Size.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Custom_Size.AppearanceHeader.Options.UseFont = true;
            this.Custom_Size.Caption = "Custom_Size";
            this.Custom_Size.FieldName = "Custom_Size";
            this.Custom_Size.Name = "Custom_Size";
            this.Custom_Size.Visible = true;
            this.Custom_Size.VisibleIndex = 2;
            this.Custom_Size.Width = 115;
            // 
            // Item_Sale_Price
            // 
            this.Item_Sale_Price.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Sale_Price.AppearanceCell.Options.UseFont = true;
            this.Item_Sale_Price.AppearanceCell.Options.UseTextOptions = true;
            this.Item_Sale_Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Item_Sale_Price.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Sale_Price.AppearanceHeader.Options.UseFont = true;
            this.Item_Sale_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Sale_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Sale_Price.Caption = "Unit Price";
            this.Item_Sale_Price.ColumnEdit = this.RPtUnitPrice;
            this.Item_Sale_Price.FieldName = "Item_Sale_Price";
            this.Item_Sale_Price.Name = "Item_Sale_Price";
            this.Item_Sale_Price.Visible = true;
            this.Item_Sale_Price.VisibleIndex = 3;
            this.Item_Sale_Price.Width = 89;
            // 
            // RPtUnitPrice
            // 
            this.RPtUnitPrice.AutoHeight = false;
            this.RPtUnitPrice.Name = "RPtUnitPrice";
            this.RPtUnitPrice.Leave += new System.EventHandler(this.RPtUnitPrice_Leave);
            // 
            // PackPrice
            // 
            this.PackPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackPrice.AppearanceCell.Options.UseFont = true;
            this.PackPrice.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackPrice.AppearanceHeader.Options.UseFont = true;
            this.PackPrice.Caption = "Pack Price";
            this.PackPrice.FieldName = "Pack_Price";
            this.PackPrice.Name = "PackPrice";
            this.PackPrice.Visible = true;
            this.PackPrice.VisibleIndex = 4;
            this.PackPrice.Width = 77;
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
            this.Qty.FieldName = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.OptionsColumn.AllowEdit = false;
            this.Qty.Visible = true;
            this.Qty.VisibleIndex = 5;
            this.Qty.Width = 62;
            // 
            // RepTxtQty
            // 
            this.RepTxtQty.AutoHeight = false;
            this.RepTxtQty.Name = "RepTxtQty";
            this.RepTxtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepTxtQty_KeyPress);
            this.RepTxtQty.Leave += new System.EventHandler(this.RepTxtQty_Leave);
            this.RepTxtQty.MouseLeave += new System.EventHandler(this.RepTxtQty_MouseLeave);
            // 
            // Item_Amount
            // 
            this.Item_Amount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Amount.AppearanceCell.Options.UseFont = true;
            this.Item_Amount.AppearanceCell.Options.UseTextOptions = true;
            this.Item_Amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Item_Amount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Amount.AppearanceHeader.Options.UseFont = true;
            this.Item_Amount.AppearanceHeader.Options.UseTextOptions = true;
            this.Item_Amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item_Amount.Caption = "Amount";
            this.Item_Amount.FieldName = "Amount";
            this.Item_Amount.Name = "Item_Amount";
            this.Item_Amount.OptionsColumn.AllowEdit = false;
            this.Item_Amount.OptionsColumn.AllowFocus = false;
            this.Item_Amount.Visible = true;
            this.Item_Amount.VisibleIndex = 6;
            this.Item_Amount.Width = 83;
            // 
            // Unit
            // 
            this.Unit.Caption = "Unit";
            this.Unit.FieldName = "Unit_Name";
            this.Unit.Name = "Unit";
            this.Unit.OptionsColumn.AllowEdit = false;
            this.Unit.OptionsColumn.AllowFocus = false;
            // 
            // Total_Stock
            // 
            this.Total_Stock.Caption = "Total Stock";
            this.Total_Stock.FieldName = "Total_Stock";
            this.Total_Stock.Name = "Total_Stock";
            this.Total_Stock.OptionsColumn.AllowEdit = false;
            this.Total_Stock.OptionsColumn.AllowFocus = false;
            // 
            // Stock_ID
            // 
            this.Stock_ID.Caption = "Stock_ID";
            this.Stock_ID.FieldName = "Stock_ID";
            this.Stock_ID.Name = "Stock_ID";
            this.Stock_ID.OptionsColumn.AllowEdit = false;
            this.Stock_ID.OptionsColumn.AllowFocus = false;
            // 
            // Stock_Critical_Level
            // 
            this.Stock_Critical_Level.Caption = "Stock Level";
            this.Stock_Critical_Level.FieldName = "Stock_Critical_Level";
            this.Stock_Critical_Level.Name = "Stock_Critical_Level";
            this.Stock_Critical_Level.OptionsColumn.AllowEdit = false;
            this.Stock_Critical_Level.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "IsPacked";
            this.gridColumn7.FieldName = "IsPacked";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Piece_Per_Pack";
            this.gridColumn8.FieldName = "Piece_Per_Pack";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // Percentage
            // 
            this.Percentage.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Percentage.AppearanceCell.Options.UseFont = true;
            this.Percentage.AppearanceCell.Options.UseTextOptions = true;
            this.Percentage.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Percentage.AppearanceHeader.Options.UseFont = true;
            this.Percentage.Caption = "Percentage";
            this.Percentage.ColumnEdit = this.rppercentage;
            this.Percentage.FieldName = "Percentage";
            this.Percentage.Name = "Percentage";
            this.Percentage.Visible = true;
            this.Percentage.VisibleIndex = 7;
            this.Percentage.Width = 78;
            // 
            // rppercentage
            // 
            this.rppercentage.AutoHeight = false;
            this.rppercentage.Name = "rppercentage";
            this.rppercentage.EditValueChanged += new System.EventHandler(this.rppercentage_EditValueChanged);
            this.rppercentage.Leave += new System.EventHandler(this.rppercentage_Leave);
            // 
            // Percentage_Amount
            // 
            this.Percentage_Amount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Percentage_Amount.AppearanceCell.Options.UseFont = true;
            this.Percentage_Amount.AppearanceCell.Options.UseTextOptions = true;
            this.Percentage_Amount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Percentage_Amount.AppearanceHeader.Options.UseFont = true;
            this.Percentage_Amount.Caption = "Percentage_Amount";
            this.Percentage_Amount.FieldName = "Percentage_Amount";
            this.Percentage_Amount.Name = "Percentage_Amount";
            this.Percentage_Amount.Visible = true;
            this.Percentage_Amount.VisibleIndex = 8;
            this.Percentage_Amount.Width = 132;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblSalesInvoice);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 39);
            this.panel1.TabIndex = 47;
            // 
            // lblSalesInvoice
            // 
            this.lblSalesInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalesInvoice.AutoSize = true;
            this.lblSalesInvoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesInvoice.ForeColor = System.Drawing.Color.White;
            this.lblSalesInvoice.Location = new System.Drawing.Point(539, 8);
            this.lblSalesInvoice.Name = "lblSalesInvoice";
            this.lblSalesInvoice.Size = new System.Drawing.Size(117, 22);
            this.lblSalesInvoice.TabIndex = 0;
            this.lblSalesInvoice.Text = "Sales Invoice";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 42);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TPSalesInvoice;
            this.xtraTabControl1.Size = new System.Drawing.Size(1189, 496);
            this.xtraTabControl1.TabIndex = 51;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TPSalesInvoice,
            this.TPTodaySale});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // TPSalesInvoice
            // 
            this.TPSalesInvoice.Controls.Add(this.LblComment);
            this.TPSalesInvoice.Controls.Add(this.TxtComments);
            this.TPSalesInvoice.Controls.Add(this.label2);
            this.TPSalesInvoice.Controls.Add(this.label1);
            this.TPSalesInvoice.Controls.Add(this.checkBox1);
            this.TPSalesInvoice.Controls.Add(this.label14);
            this.TPSalesInvoice.Controls.Add(this.lblCustomerBalance);
            this.TPSalesInvoice.Controls.Add(this.lblCellNo);
            this.TPSalesInvoice.Controls.Add(this.TxtGetRegularCustomer);
            this.TPSalesInvoice.Controls.Add(this.btnGetRegularCustomer);
            this.TPSalesInvoice.Controls.Add(this.btnAddCustomer);
            this.TPSalesInvoice.Controls.Add(this.lblRegCustomerName);
            this.TPSalesInvoice.Controls.Add(this.lblCustomerName);
            this.TPSalesInvoice.Controls.Add(this.btnSimple);
            this.TPSalesInvoice.Controls.Add(this.lblScanBarcode);
            this.TPSalesInvoice.Controls.Add(this.gPaymentBox);
            this.TPSalesInvoice.Controls.Add(this.TxtAdmin);
            this.TPSalesInvoice.Controls.Add(this.lblUser);
            this.TPSalesInvoice.Controls.Add(this.lblCustomerType);
            this.TPSalesInvoice.Controls.Add(this.LuECustomerType_ID);
            this.TPSalesInvoice.Controls.Add(this.lblDate);
            this.TPSalesInvoice.Controls.Add(this.lblInvoiceNumber);
            this.TPSalesInvoice.Controls.Add(this.DtEInvoiceDate);
            this.TPSalesInvoice.Controls.Add(this.gridControl1);
            this.TPSalesInvoice.Controls.Add(this.TxtInvoiceNumber);
            this.TPSalesInvoice.Controls.Add(this.btnAdd);
            this.TPSalesInvoice.Controls.Add(this.TxtBarcode);
            this.TPSalesInvoice.Name = "TPSalesInvoice";
            this.TPSalesInvoice.Size = new System.Drawing.Size(1187, 471);
            this.TPSalesInvoice.Text = "Sales Invoice";
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComment.Location = new System.Drawing.Point(322, 50);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(148, 13);
            this.LblComment.TabIndex = 90;
            this.LblComment.Text = "Walking Customer Name:";
            // 
            // TxtComments
            // 
            this.TxtComments.Location = new System.Drawing.Point(322, 66);
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(205, 20);
            this.TxtComments.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(927, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1128, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 23);
            this.checkBox1.TabIndex = 87;
            this.checkBox1.Text = "A4";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(927, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 86;
            this.label14.Text = "00";
            // 
            // lblCustomerBalance
            // 
            this.lblCustomerBalance.AutoSize = true;
            this.lblCustomerBalance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerBalance.Location = new System.Drawing.Point(847, 48);
            this.lblCustomerBalance.Name = "lblCustomerBalance";
            this.lblCustomerBalance.Size = new System.Drawing.Size(115, 13);
            this.lblCustomerBalance.TabIndex = 85;
            this.lblCustomerBalance.Text = "Customer Balance :";
            // 
            // lblCellNo
            // 
            this.lblCellNo.AutoSize = true;
            this.lblCellNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNo.Location = new System.Drawing.Point(418, 3);
            this.lblCellNo.Name = "lblCellNo";
            this.lblCellNo.Size = new System.Drawing.Size(38, 13);
            this.lblCellNo.TabIndex = 84;
            this.lblCellNo.Text = "Code:";
            // 
            // TxtGetRegularCustomer
            // 
            this.TxtGetRegularCustomer.EnterMoveNextControl = true;
            this.TxtGetRegularCustomer.Location = new System.Drawing.Point(415, 21);
            this.TxtGetRegularCustomer.Name = "TxtGetRegularCustomer";
            this.TxtGetRegularCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGetRegularCustomer.Properties.Appearance.Options.UseFont = true;
            this.TxtGetRegularCustomer.Size = new System.Drawing.Size(132, 22);
            this.TxtGetRegularCustomer.TabIndex = 83;
            this.TxtGetRegularCustomer.EditValueChanged += new System.EventHandler(this.TxtGetRegularCustomer_EditValueChanged);
            this.TxtGetRegularCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGetRegularCustomer_KeyPress);
            this.TxtGetRegularCustomer.Leave += new System.EventHandler(this.TxtGetRegularCustomer_Leave);
            // 
            // btnGetRegularCustomer
            // 
            this.btnGetRegularCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRegularCustomer.Appearance.Options.UseFont = true;
            this.btnGetRegularCustomer.Enabled = false;
            this.btnGetRegularCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGetRegularCustomer.ImageOptions.Image")));
            this.btnGetRegularCustomer.Location = new System.Drawing.Point(553, 21);
            this.btnGetRegularCustomer.Name = "btnGetRegularCustomer";
            this.btnGetRegularCustomer.Size = new System.Drawing.Size(50, 22);
            this.btnGetRegularCustomer.TabIndex = 82;
            this.btnGetRegularCustomer.Text = "Find";
            this.btnGetRegularCustomer.Click += new System.EventHandler(this.btnGetRegularCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Appearance.Options.UseFont = true;
            this.btnAddCustomer.Enabled = false;
            this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.Image")));
            this.btnAddCustomer.Location = new System.Drawing.Point(356, 21);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(50, 22);
            this.btnAddCustomer.TabIndex = 81;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblRegCustomerName
            // 
            this.lblRegCustomerName.AutoSize = true;
            this.lblRegCustomerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegCustomerName.Location = new System.Drawing.Point(716, 49);
            this.lblRegCustomerName.Name = "lblRegCustomerName";
            this.lblRegCustomerName.Size = new System.Drawing.Size(131, 13);
            this.lblRegCustomerName.TabIndex = 80;
            this.lblRegCustomerName.Text = "Reg. Customer Name :";
            this.lblRegCustomerName.Visible = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(715, 62);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(162, 19);
            this.lblCustomerName.TabIndex = 79;
            this.lblCustomerName.Text = "Name Of Customer";
            // 
            // btnSimple
            // 
            this.btnSimple.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimple.Appearance.Options.UseFont = true;
            this.btnSimple.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSimple.ImageOptions.Image")));
            this.btnSimple.Location = new System.Drawing.Point(253, 65);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(67, 22);
            this.btnSimple.TabIndex = 72;
            this.btnSimple.TabStop = false;
            this.btnSimple.Text = "Search";
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // lblScanBarcode
            // 
            this.lblScanBarcode.AutoSize = true;
            this.lblScanBarcode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanBarcode.Location = new System.Drawing.Point(7, 47);
            this.lblScanBarcode.Name = "lblScanBarcode";
            this.lblScanBarcode.Size = new System.Drawing.Size(116, 13);
            this.lblScanBarcode.TabIndex = 71;
            this.lblScanBarcode.Text = "Scan Barcode Here:";
            // 
            // gPaymentBox
            // 
            this.gPaymentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPaymentBox.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gPaymentBox.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.gPaymentBox.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.gPaymentBox.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPaymentBox.Appearance.Options.UseBackColor = true;
            this.gPaymentBox.Appearance.Options.UseBorderColor = true;
            this.gPaymentBox.Appearance.Options.UseFont = true;
            this.gPaymentBox.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.gPaymentBox.AppearanceCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.gPaymentBox.AppearanceCaption.BorderColor = System.Drawing.Color.Transparent;
            this.gPaymentBox.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPaymentBox.AppearanceCaption.Options.UseBackColor = true;
            this.gPaymentBox.AppearanceCaption.Options.UseBorderColor = true;
            this.gPaymentBox.AppearanceCaption.Options.UseFont = true;
            this.gPaymentBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gPaymentBox.Controls.Add(this.panel2);
            this.gPaymentBox.Location = new System.Drawing.Point(981, 49);
            this.gPaymentBox.Name = "gPaymentBox";
            this.gPaymentBox.Size = new System.Drawing.Size(197, 414);
            this.gPaymentBox.TabIndex = 70;
            this.gPaymentBox.Text = "Payment Box";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Txtguarantee);
            this.panel2.Controls.Add(this.lblgurrentee);
            this.panel2.Controls.Add(this.TxtDiscount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtShopAmount);
            this.panel2.Controls.Add(this.lblShopAmount);
            this.panel2.Controls.Add(this.TxtTaxAmount);
            this.panel2.Controls.Add(this.lblTaxAmount);
            this.panel2.Controls.Add(this.TxtTaxPercentage);
            this.panel2.Controls.Add(this.lblTax);
            this.panel2.Controls.Add(this.lblCardNo);
            this.panel2.Controls.Add(this.TxtCheckOrCreditNo);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.TxtGrandAmount);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.lblPaymentType);
            this.panel2.Controls.Add(this.TxtBalance);
            this.panel2.Controls.Add(this.lblGrandAmount);
            this.panel2.Controls.Add(this.LuEPaymentType_ID);
            this.panel2.Controls.Add(this.TxtRecievePayment);
            this.panel2.Controls.Add(this.lblReceivedAmount);
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 383);
            this.panel2.TabIndex = 0;
            // 
            // Txtguarantee
            // 
            this.Txtguarantee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtguarantee.EnterMoveNextControl = true;
            this.Txtguarantee.Location = new System.Drawing.Point(73, 185);
            this.Txtguarantee.Name = "Txtguarantee";
            this.Txtguarantee.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtguarantee.Properties.Appearance.Options.UseFont = true;
            this.Txtguarantee.Properties.MaxLength = 15;
            this.Txtguarantee.Size = new System.Drawing.Size(104, 20);
            this.Txtguarantee.TabIndex = 83;
            this.Txtguarantee.Tag = "*";
            this.Txtguarantee.Leave += new System.EventHandler(this.Txtguarantee_Leave);
            // 
            // lblgurrentee
            // 
            this.lblgurrentee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgurrentee.AutoSize = true;
            this.lblgurrentee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgurrentee.Location = new System.Drawing.Point(70, 166);
            this.lblgurrentee.Name = "lblgurrentee";
            this.lblgurrentee.Size = new System.Drawing.Size(76, 16);
            this.lblgurrentee.TabIndex = 84;
            this.lblgurrentee.Text = "Guarantee";
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDiscount.EnterMoveNextControl = true;
            this.TxtDiscount.Location = new System.Drawing.Point(72, 184);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiscount.Properties.Appearance.Options.UseFont = true;
            this.TxtDiscount.Properties.MaxLength = 15;
            this.TxtDiscount.Size = new System.Drawing.Size(105, 20);
            this.TxtDiscount.TabIndex = 81;
            this.TxtDiscount.Tag = "";
            this.TxtDiscount.Visible = false;
            this.TxtDiscount.EditValueChanged += new System.EventHandler(this.TxtDiscount_EditValueChanged);
            this.TxtDiscount.Leave += new System.EventHandler(this.TxtDiscount_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Discount%";
            this.label3.Visible = false;
            // 
            // TxtShopAmount
            // 
            this.TxtShopAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtShopAmount.EnterMoveNextControl = true;
            this.TxtShopAmount.Location = new System.Drawing.Point(12, 273);
            this.TxtShopAmount.Name = "TxtShopAmount";
            this.TxtShopAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtShopAmount.Properties.Appearance.Options.UseFont = true;
            this.TxtShopAmount.Properties.MaxLength = 15;
            this.TxtShopAmount.Size = new System.Drawing.Size(169, 20);
            this.TxtShopAmount.TabIndex = 79;
            this.TxtShopAmount.Tag = "*";
            // 
            // lblShopAmount
            // 
            this.lblShopAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShopAmount.AutoSize = true;
            this.lblShopAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopAmount.Location = new System.Drawing.Point(10, 252);
            this.lblShopAmount.Name = "lblShopAmount";
            this.lblShopAmount.Size = new System.Drawing.Size(90, 16);
            this.lblShopAmount.TabIndex = 80;
            this.lblShopAmount.Text = "NET Amount:";
            // 
            // TxtTaxAmount
            // 
            this.TxtTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTaxAmount.EnterMoveNextControl = true;
            this.TxtTaxAmount.Location = new System.Drawing.Point(11, 226);
            this.TxtTaxAmount.Name = "TxtTaxAmount";
            this.TxtTaxAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTaxAmount.Properties.Appearance.Options.UseFont = true;
            this.TxtTaxAmount.Properties.MaxLength = 15;
            this.TxtTaxAmount.Size = new System.Drawing.Size(169, 20);
            this.TxtTaxAmount.TabIndex = 77;
            this.TxtTaxAmount.Tag = "*";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.Location = new System.Drawing.Point(9, 208);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(94, 16);
            this.lblTaxAmount.TabIndex = 78;
            this.lblTaxAmount.Text = "VAT Amount:";
            // 
            // TxtTaxPercentage
            // 
            this.TxtTaxPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTaxPercentage.Enabled = false;
            this.TxtTaxPercentage.EnterMoveNextControl = true;
            this.TxtTaxPercentage.Location = new System.Drawing.Point(10, 184);
            this.TxtTaxPercentage.Name = "TxtTaxPercentage";
            this.TxtTaxPercentage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTaxPercentage.Properties.Appearance.Options.UseFont = true;
            this.TxtTaxPercentage.Properties.MaxLength = 15;
            this.TxtTaxPercentage.Size = new System.Drawing.Size(54, 20);
            this.TxtTaxPercentage.TabIndex = 75;
            this.TxtTaxPercentage.Tag = "*";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(8, 166);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(48, 16);
            this.lblTax.TabIndex = 76;
            this.lblTax.Text = "VAT%";
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(7, 87);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(108, 16);
            this.lblCardNo.TabIndex = 74;
            this.lblCardNo.Text = "Check/Card No.";
            // 
            // TxtCheckOrCreditNo
            // 
            this.TxtCheckOrCreditNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCheckOrCreditNo.EditValue = "0";
            this.TxtCheckOrCreditNo.Enabled = false;
            this.TxtCheckOrCreditNo.Location = new System.Drawing.Point(9, 105);
            this.TxtCheckOrCreditNo.Name = "TxtCheckOrCreditNo";
            this.TxtCheckOrCreditNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCheckOrCreditNo.Properties.Appearance.Options.UseFont = true;
            this.TxtCheckOrCreditNo.Properties.MaxLength = 20;
            this.TxtCheckOrCreditNo.Size = new System.Drawing.Size(169, 20);
            this.TxtCheckOrCreditNo.TabIndex = 73;
            this.TxtCheckOrCreditNo.Tag = "*";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(7, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(100, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(7, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TxtGrandAmount
            // 
            this.TxtGrandAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGrandAmount.Location = new System.Drawing.Point(8, 22);
            this.TxtGrandAmount.Name = "TxtGrandAmount";
            this.TxtGrandAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGrandAmount.Properties.Appearance.Options.UseFont = true;
            this.TxtGrandAmount.Properties.ReadOnly = true;
            this.TxtGrandAmount.Size = new System.Drawing.Size(169, 26);
            this.TxtGrandAmount.TabIndex = 2;
            this.TxtGrandAmount.TabStop = false;
            this.TxtGrandAmount.Tag = "*";
            this.TxtGrandAmount.EditValueChanged += new System.EventHandler(this.TxtGrandAmount_EditValueChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(97, 296);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 16);
            this.lblBalance.TabIndex = 66;
            this.lblBalance.Text = "Balance:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(7, 49);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(105, 16);
            this.lblPaymentType.TabIndex = 68;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // TxtBalance
            // 
            this.TxtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBalance.Location = new System.Drawing.Point(100, 315);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBalance.Properties.Appearance.Options.UseFont = true;
            this.TxtBalance.Properties.ReadOnly = true;
            this.TxtBalance.Size = new System.Drawing.Size(78, 20);
            this.TxtBalance.TabIndex = 4;
            this.TxtBalance.TabStop = false;
            // 
            // lblGrandAmount
            // 
            this.lblGrandAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandAmount.AutoSize = true;
            this.lblGrandAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandAmount.Location = new System.Drawing.Point(6, 5);
            this.lblGrandAmount.Name = "lblGrandAmount";
            this.lblGrandAmount.Size = new System.Drawing.Size(106, 16);
            this.lblGrandAmount.TabIndex = 69;
            this.lblGrandAmount.Text = "Grand Amount:";
            // 
            // LuEPaymentType_ID
            // 
            this.LuEPaymentType_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LuEPaymentType_ID.Location = new System.Drawing.Point(9, 66);
            this.LuEPaymentType_ID.Name = "LuEPaymentType_ID";
            this.LuEPaymentType_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEPaymentType_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEPaymentType_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEPaymentType_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Payment_Type", "Name")});
            this.LuEPaymentType_ID.Properties.NullText = "Cash";
            this.LuEPaymentType_ID.Size = new System.Drawing.Size(169, 20);
            this.LuEPaymentType_ID.TabIndex = 67;
            this.LuEPaymentType_ID.EditValueChanged += new System.EventHandler(this.LuEPaymentType_ID_EditValueChanged);
            // 
            // TxtRecievePayment
            // 
            this.TxtRecievePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRecievePayment.EnterMoveNextControl = true;
            this.TxtRecievePayment.Location = new System.Drawing.Point(9, 144);
            this.TxtRecievePayment.Name = "TxtRecievePayment";
            this.TxtRecievePayment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecievePayment.Properties.Appearance.Options.UseFont = true;
            this.TxtRecievePayment.Properties.MaxLength = 15;
            this.TxtRecievePayment.Size = new System.Drawing.Size(169, 20);
            this.TxtRecievePayment.TabIndex = 2;
            this.TxtRecievePayment.Tag = "*";
            this.TxtRecievePayment.EditValueChanged += new System.EventHandler(this.TxtRecievePayment_EditValueChanged);
            this.TxtRecievePayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecievePayment_KeyPress);
            // 
            // lblReceivedAmount
            // 
            this.lblReceivedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceivedAmount.AutoSize = true;
            this.lblReceivedAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedAmount.Location = new System.Drawing.Point(7, 126);
            this.lblReceivedAmount.Name = "lblReceivedAmount";
            this.lblReceivedAmount.Size = new System.Drawing.Size(127, 16);
            this.lblReceivedAmount.TabIndex = 65;
            this.lblReceivedAmount.Text = "Recieved Amount:";
            // 
            // TxtAdmin
            // 
            this.TxtAdmin.EditValue = "Admin";
            this.TxtAdmin.Enabled = false;
            this.TxtAdmin.Location = new System.Drawing.Point(981, 21);
            this.TxtAdmin.Name = "TxtAdmin";
            this.TxtAdmin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdmin.Properties.Appearance.Options.UseFont = true;
            this.TxtAdmin.Properties.ReadOnly = true;
            this.TxtAdmin.Size = new System.Drawing.Size(118, 22);
            this.TxtAdmin.TabIndex = 58;
            this.TxtAdmin.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(978, 3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 13);
            this.lblUser.TabIndex = 57;
            this.lblUser.Text = "User:";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(177, 3);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(96, 13);
            this.lblCustomerType.TabIndex = 56;
            this.lblCustomerType.Text = "Customer Type:";
            // 
            // LuECustomerType_ID
            // 
            this.LuECustomerType_ID.Location = new System.Drawing.Point(180, 21);
            this.LuECustomerType_ID.Name = "LuECustomerType_ID";
            this.LuECustomerType_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuECustomerType_ID.Properties.Appearance.Options.UseFont = true;
            this.LuECustomerType_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuECustomerType_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer_Name", "Name")});
            this.LuECustomerType_ID.Properties.NullText = "";
            this.LuECustomerType_ID.Properties.PopupFormMinSize = new System.Drawing.Size(50, 50);
            this.LuECustomerType_ID.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.FrameResize;
            this.LuECustomerType_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuECustomerType_ID.Properties.ShowFooter = false;
            this.LuECustomerType_ID.Size = new System.Drawing.Size(164, 22);
            this.LuECustomerType_ID.TabIndex = 55;
            this.LuECustomerType_ID.TabStop = false;
            this.LuECustomerType_ID.EditValueChanged += new System.EventHandler(this.LuECustomerType_ID_EditValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(613, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 13);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "Date:";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(7, 3);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(99, 13);
            this.lblInvoiceNumber.TabIndex = 52;
            this.lblInvoiceNumber.Text = "Invoice Number:";
            // 
            // DtEInvoiceDate
            // 
            this.DtEInvoiceDate.EditValue = null;
            this.DtEInvoiceDate.EnterMoveNextControl = true;
            this.DtEInvoiceDate.Location = new System.Drawing.Point(616, 21);
            this.DtEInvoiceDate.Name = "DtEInvoiceDate";
            this.DtEInvoiceDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEInvoiceDate.Properties.Appearance.Options.UseFont = true;
            this.DtEInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEInvoiceDate.Size = new System.Drawing.Size(164, 22);
            this.DtEInvoiceDate.TabIndex = 51;
            this.DtEInvoiceDate.Tag = "*";
            // 
            // TxtInvoiceNumber
            // 
            this.TxtInvoiceNumber.Location = new System.Drawing.Point(7, 21);
            this.TxtInvoiceNumber.Name = "TxtInvoiceNumber";
            this.TxtInvoiceNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInvoiceNumber.Properties.Appearance.Options.UseFont = true;
            this.TxtInvoiceNumber.Properties.ReadOnly = true;
            this.TxtInvoiceNumber.Size = new System.Drawing.Size(164, 22);
            this.TxtInvoiceNumber.TabIndex = 53;
            this.TxtInvoiceNumber.TabStop = false;
            this.TxtInvoiceNumber.Tag = "*";
            // 
            // TPTodaySale
            // 
            this.TPTodaySale.Controls.Add(this.DtETo);
            this.TPTodaySale.Controls.Add(this.DtEFrom);
            this.TPTodaySale.Controls.Add(this.gridControl2);
            this.TPTodaySale.Controls.Add(this.txtClear);
            this.TPTodaySale.Controls.Add(this.label17);
            this.TPTodaySale.Controls.Add(this.TxtInvoiceNumberSearch);
            this.TPTodaySale.Controls.Add(this.btnYesterday);
            this.TPTodaySale.Controls.Add(this.label10);
            this.TPTodaySale.Controls.Add(this.label11);
            this.TPTodaySale.Controls.Add(this.btnToday);
            this.TPTodaySale.Controls.Add(this.btnBetweenDate);
            this.TPTodaySale.Controls.Add(this.DtETo1);
            this.TPTodaySale.Controls.Add(this.DtEFrom2);
            this.TPTodaySale.Name = "TPTodaySale";
            this.TPTodaySale.Size = new System.Drawing.Size(1187, 471);
            this.TPTodaySale.Text = "Today Sale";
            // 
            // DtETo
            // 
            this.DtETo.Location = new System.Drawing.Point(400, 25);
            this.DtETo.Name = "DtETo";
            this.DtETo.Size = new System.Drawing.Size(147, 21);
            this.DtETo.TabIndex = 136;
            // 
            // DtEFrom
            // 
            this.DtEFrom.Location = new System.Drawing.Point(241, 25);
            this.DtEFrom.Name = "DtEFrom";
            this.DtEFrom.Size = new System.Drawing.Size(147, 21);
            this.DtEFrom.TabIndex = 135;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(6, 46);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl2.Size = new System.Drawing.Size(1169, 417);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Invoice No";
            this.gridColumn2.FieldName = "Invoice_No";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Grand Total";
            this.gridColumn3.FieldName = "Grand_Total";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 200;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Recievd Amount";
            this.gridColumn4.FieldName = "Recievd_Amount";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 200;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Invoice Date";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.Width = 200;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "Created By";
            this.gridColumn10.FieldName = "Created_By";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 200;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Sale_ID";
            this.gridColumn1.FieldName = "Sale_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // txtClear
            // 
            this.txtClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtClear.ImageOptions.Image")));
            this.txtClear.Location = new System.Drawing.Point(817, 23);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(75, 23);
            this.txtClear.TabIndex = 134;
            this.txtClear.Text = "Clear";
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 133;
            this.label17.Text = "Invoice Number";
            // 
            // TxtInvoiceNumberSearch
            // 
            this.TxtInvoiceNumberSearch.EnterMoveNextControl = true;
            this.TxtInvoiceNumberSearch.Location = new System.Drawing.Point(9, 26);
            this.TxtInvoiceNumberSearch.Name = "TxtInvoiceNumberSearch";
            this.TxtInvoiceNumberSearch.Size = new System.Drawing.Size(211, 20);
            this.TxtInvoiceNumberSearch.TabIndex = 132;
            this.TxtInvoiceNumberSearch.Tag = "";
            this.TxtInvoiceNumberSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInvoiceNumberSearch_KeyPress);
            this.TxtInvoiceNumberSearch.Leave += new System.EventHandler(this.TxtInvoiceNumberSearch_Leave);
            // 
            // btnYesterday
            // 
            this.btnYesterday.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYesterday.ImageOptions.Image")));
            this.btnYesterday.Location = new System.Drawing.Point(736, 23);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(75, 23);
            this.btnYesterday.TabIndex = 17;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(397, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "To Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(238, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "From Date :";
            // 
            // btnToday
            // 
            this.btnToday.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnToday.ImageOptions.Image")));
            this.btnToday.Location = new System.Drawing.Point(655, 23);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 14;
            this.btnToday.Text = "Today";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnBetweenDate
            // 
            this.btnBetweenDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBetweenDate.ImageOptions.Image")));
            this.btnBetweenDate.Location = new System.Drawing.Point(574, 23);
            this.btnBetweenDate.Name = "btnBetweenDate";
            this.btnBetweenDate.Size = new System.Drawing.Size(75, 23);
            this.btnBetweenDate.TabIndex = 13;
            this.btnBetweenDate.Text = "Between";
            this.btnBetweenDate.Click += new System.EventHandler(this.btnBetweenDate_Click);
            // 
            // DtETo1
            // 
            this.DtETo1.EditValue = null;
            this.DtETo1.Location = new System.Drawing.Point(400, 26);
            this.DtETo1.Name = "DtETo1";
            this.DtETo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtETo1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtETo1.Size = new System.Drawing.Size(147, 20);
            this.DtETo1.TabIndex = 12;
            this.DtETo1.Tag = "";
            // 
            // DtEFrom2
            // 
            this.DtEFrom2.EditValue = null;
            this.DtEFrom2.Location = new System.Drawing.Point(241, 26);
            this.DtEFrom2.Name = "DtEFrom2";
            this.DtEFrom2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEFrom2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEFrom2.Size = new System.Drawing.Size(147, 20);
            this.DtEFrom2.TabIndex = 11;
            this.DtEFrom2.Tag = "";
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmSalesInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 538);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSalesInvoices.IconOptions.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSalesInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sale Invoice";
            this.Load += new System.EventHandler(this.frmSalesInvoices_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesInvoices_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPtUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepTxtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rppercentage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TPSalesInvoice.ResumeLayout(false);
            this.TPSalesInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGetRegularCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPaymentBox)).EndInit();
            this.gPaymentBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtguarantee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiscount.Properties)).EndInit();
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
            this.TPTodaySale.ResumeLayout(false);
            this.TPTodaySale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceNumberSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtETo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEFrom2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtBarcode;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Sale_Price;
        private DevExpress.XtraGrid.Columns.GridColumn Qty;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Amount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalesInvoice;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TPSalesInvoice;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private DevExpress.XtraEditors.DateEdit DtEInvoiceDate;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceNumber;
        private DevExpress.XtraTab.XtraTabPage TPTodaySale;
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
        private DevExpress.XtraEditors.GroupControl gPaymentBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrandAmount;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepTxtQty;
        private DevExpress.XtraGrid.Columns.GridColumn Unit;
        private DevExpress.XtraGrid.Columns.GridColumn Item_ID;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraGrid.Columns.GridColumn Total_Stock;
        private DevExpress.XtraGrid.Columns.GridColumn Stock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Stock_Critical_Level;
        private System.Windows.Forms.Label lblScanBarcode;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.SimpleButton btnYesterday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton btnToday;
        private DevExpress.XtraEditors.SimpleButton btnBetweenDate;
        private DevExpress.XtraEditors.DateEdit DtETo1;
        private DevExpress.XtraEditors.DateEdit DtEFrom2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSimple;
        private DevExpress.XtraGrid.Columns.GridColumn PackPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label lblRegCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private System.Windows.Forms.Label lblCellNo;
        private DevExpress.XtraEditors.TextEdit TxtGetRegularCustomer;
        private DevExpress.XtraEditors.SimpleButton btnGetRegularCustomer;
        private System.Windows.Forms.Label lblCardNo;
        private DevExpress.XtraEditors.TextEdit TxtCheckOrCreditNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCustomerBalance;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceNumberSearch;
        private DevExpress.XtraEditors.SimpleButton txtClear;
        private DevExpress.XtraEditors.TextEdit TxtShopAmount;
        private System.Windows.Forms.Label lblShopAmount;
        private DevExpress.XtraEditors.TextEdit TxtTaxAmount;
        private System.Windows.Forms.Label lblTaxAmount;
        private DevExpress.XtraEditors.TextEdit TxtTaxPercentage;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RPtUnitPrice;
        private System.Windows.Forms.DateTimePicker DtEFrom;
        private System.Windows.Forms.DateTimePicker DtETo;
        private System.Windows.Forms.Label LblComment;
        private DevExpress.XtraEditors.TextEdit TxtComments;
        private DevExpress.XtraEditors.TextEdit TxtDiscount;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn Custom_Size;
        private DevExpress.XtraGrid.Columns.GridColumn Percentage;
        private DevExpress.XtraGrid.Columns.GridColumn Percentage_Amount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rppercentage;
        private DevExpress.XtraEditors.TextEdit Txtguarantee;
        private System.Windows.Forms.Label lblgurrentee;
    }
}