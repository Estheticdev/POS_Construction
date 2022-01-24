namespace POS_Software.Forms.Admin
{
    partial class frmItems_Deffination
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems_Deffination));
            this.TCItems = new DevExpress.XtraTab.XtraTabControl();
            this.TPItems = new DevExpress.XtraTab.XtraTabPage();
            this.lblSPWOT = new System.Windows.Forms.Label();
            this.CkEIsPacked = new DevExpress.XtraEditors.CheckEdit();
            this.LuEItem_Unit_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.LuEItem_Size_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.LuEItem_Category_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.LuEItem_Type_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.CkEActive = new DevExpress.XtraEditors.CheckEdit();
            this.lblBundlePrice = new System.Windows.Forms.Label();
            this.lblPieceInPack = new System.Windows.Forms.Label();
            this.TxtPiece_Per_Pack = new DevExpress.XtraEditors.TextEdit();
            this.lblStockCriticalLevel = new System.Windows.Forms.Label();
            this.TxtStock_Critical_Level = new DevExpress.XtraEditors.TextEdit();
            this.BCCItem_Barcode = new DevExpress.XtraEditors.BarCodeControl();
            this.TxtItem_Barcode = new DevExpress.XtraEditors.TextEdit();
            this.TxtItem_Name = new DevExpress.XtraEditors.TextEdit();
            this.DtEItem_Expiry_Date = new DevExpress.XtraEditors.DateEdit();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblSPWT = new System.Windows.Forms.Label();
            this.Txtsale = new DevExpress.XtraEditors.TextEdit();
            this.TxtItem_Sale_Price = new DevExpress.XtraEditors.TextEdit();
            this.TxtItem_Purchase_Price = new DevExpress.XtraEditors.TextEdit();
            this.lblItemUnit = new System.Windows.Forms.Label();
            this.TxtItem_ID = new DevExpress.XtraEditors.TextEdit();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemBarcode = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblItemSize = new System.Windows.Forms.Label();
            this.lblItemSubType = new System.Windows.Forms.Label();
            this.TxtPack_Price = new DevExpress.XtraEditors.TextEdit();
            this.TPHistory = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lblCreateItems = new System.Windows.Forms.Label();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErPro = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TCItems)).BeginInit();
            this.TCItems.SuspendLayout();
            this.TPItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkEIsPacked.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Unit_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Size_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Category_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Type_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPiece_Per_Pack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock_Critical_Level.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Barcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEItem_Expiry_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEItem_Expiry_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtsale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Sale_Price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Purchase_Price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPack_Price.Properties)).BeginInit();
            this.TPHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).BeginInit();
            this.SuspendLayout();
            // 
            // TCItems
            // 
            this.TCItems.Location = new System.Drawing.Point(3, 43);
            this.TCItems.Name = "TCItems";
            this.TCItems.SelectedTabPage = this.TPItems;
            this.TCItems.Size = new System.Drawing.Size(665, 330);
            this.TCItems.TabIndex = 53;
            this.TCItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TPItems,
            this.TPHistory});
            this.TCItems.Click += new System.EventHandler(this.TCItems_Click);
            // 
            // TPItems
            // 
            this.TPItems.Controls.Add(this.lblSPWOT);
            this.TPItems.Controls.Add(this.CkEIsPacked);
            this.TPItems.Controls.Add(this.LuEItem_Unit_ID);
            this.TPItems.Controls.Add(this.LuEItem_Size_ID);
            this.TPItems.Controls.Add(this.LuEItem_Category_ID);
            this.TPItems.Controls.Add(this.LuEItem_Type_ID);
            this.TPItems.Controls.Add(this.CkEActive);
            this.TPItems.Controls.Add(this.lblBundlePrice);
            this.TPItems.Controls.Add(this.lblPieceInPack);
            this.TPItems.Controls.Add(this.TxtPiece_Per_Pack);
            this.TPItems.Controls.Add(this.lblStockCriticalLevel);
            this.TPItems.Controls.Add(this.TxtStock_Critical_Level);
            this.TPItems.Controls.Add(this.BCCItem_Barcode);
            this.TPItems.Controls.Add(this.TxtItem_Barcode);
            this.TPItems.Controls.Add(this.TxtItem_Name);
            this.TPItems.Controls.Add(this.DtEItem_Expiry_Date);
            this.TPItems.Controls.Add(this.lblExpiryDate);
            this.TPItems.Controls.Add(this.lblPurchasePrice);
            this.TPItems.Controls.Add(this.lblSPWT);
            this.TPItems.Controls.Add(this.Txtsale);
            this.TPItems.Controls.Add(this.TxtItem_Sale_Price);
            this.TPItems.Controls.Add(this.TxtItem_Purchase_Price);
            this.TPItems.Controls.Add(this.lblItemUnit);
            this.TPItems.Controls.Add(this.TxtItem_ID);
            this.TPItems.Controls.Add(this.lblItemID);
            this.TPItems.Controls.Add(this.lblItemName);
            this.TPItems.Controls.Add(this.lblItemBarcode);
            this.TPItems.Controls.Add(this.lblItemType);
            this.TPItems.Controls.Add(this.lblItemSize);
            this.TPItems.Controls.Add(this.lblItemSubType);
            this.TPItems.Controls.Add(this.TxtPack_Price);
            this.TPItems.Name = "TPItems";
            this.TPItems.Size = new System.Drawing.Size(663, 305);
            this.TPItems.Text = "Add Items";
            // 
            // lblSPWOT
            // 
            this.lblSPWOT.AutoSize = true;
            this.lblSPWOT.Location = new System.Drawing.Point(321, 14);
            this.lblSPWOT.Name = "lblSPWOT";
            this.lblSPWOT.Size = new System.Drawing.Size(119, 13);
            this.lblSPWOT.TabIndex = 116;
            this.lblSPWOT.Text = "Sale Price Without Tax:";
            // 
            // CkEIsPacked
            // 
            this.CkEIsPacked.Location = new System.Drawing.Point(551, 110);
            this.CkEIsPacked.Name = "CkEIsPacked";
            this.CkEIsPacked.Properties.Caption = "Packed";
            this.CkEIsPacked.Size = new System.Drawing.Size(66, 20);
            this.CkEIsPacked.TabIndex = 47;
            this.CkEIsPacked.TabStop = false;
            // 
            // LuEItem_Unit_ID
            // 
            this.LuEItem_Unit_ID.EnterMoveNextControl = true;
            this.LuEItem_Unit_ID.Location = new System.Drawing.Point(47, 230);
            this.LuEItem_Unit_ID.Name = "LuEItem_Unit_ID";
            this.LuEItem_Unit_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEItem_Unit_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEItem_Unit_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEItem_Unit_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit_Name", "Name")});
            this.LuEItem_Unit_ID.Properties.NullText = "";
            this.LuEItem_Unit_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuEItem_Unit_ID.Properties.PopupSizeable = false;
            this.LuEItem_Unit_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuEItem_Unit_ID.Properties.ShowFooter = false;
            this.LuEItem_Unit_ID.Properties.ShowHeader = false;
            this.LuEItem_Unit_ID.Properties.ShowLines = false;
            this.LuEItem_Unit_ID.Size = new System.Drawing.Size(145, 20);
            this.LuEItem_Unit_ID.TabIndex = 5;
            this.LuEItem_Unit_ID.Tag = "";
            // 
            // LuEItem_Size_ID
            // 
            this.LuEItem_Size_ID.EnterMoveNextControl = true;
            this.LuEItem_Size_ID.Location = new System.Drawing.Point(47, 193);
            this.LuEItem_Size_ID.Name = "LuEItem_Size_ID";
            this.LuEItem_Size_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEItem_Size_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEItem_Size_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEItem_Size_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Size_Name", "Name")});
            this.LuEItem_Size_ID.Properties.NullText = "";
            this.LuEItem_Size_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuEItem_Size_ID.Properties.PopupSizeable = false;
            this.LuEItem_Size_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuEItem_Size_ID.Properties.ShowFooter = false;
            this.LuEItem_Size_ID.Properties.ShowHeader = false;
            this.LuEItem_Size_ID.Properties.ShowLines = false;
            this.LuEItem_Size_ID.Size = new System.Drawing.Size(145, 20);
            this.LuEItem_Size_ID.TabIndex = 4;
            this.LuEItem_Size_ID.Tag = "";
            // 
            // LuEItem_Category_ID
            // 
            this.LuEItem_Category_ID.EnterMoveNextControl = true;
            this.LuEItem_Category_ID.Location = new System.Drawing.Point(47, 153);
            this.LuEItem_Category_ID.Name = "LuEItem_Category_ID";
            this.LuEItem_Category_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEItem_Category_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEItem_Category_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEItem_Category_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category_Name", "Name")});
            this.LuEItem_Category_ID.Properties.NullText = "";
            this.LuEItem_Category_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuEItem_Category_ID.Properties.PopupSizeable = false;
            this.LuEItem_Category_ID.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.LuEItem_Category_ID.Properties.ShowFooter = false;
            this.LuEItem_Category_ID.Properties.ShowHeader = false;
            this.LuEItem_Category_ID.Properties.ShowLines = false;
            this.LuEItem_Category_ID.Size = new System.Drawing.Size(145, 20);
            this.LuEItem_Category_ID.TabIndex = 3;
            this.LuEItem_Category_ID.Tag = "";
            this.LuEItem_Category_ID.EditValueChanged += new System.EventHandler(this.LuEItem_Category_ID_EditValueChanged);
            // 
            // LuEItem_Type_ID
            // 
            this.LuEItem_Type_ID.EnterMoveNextControl = true;
            this.LuEItem_Type_ID.Location = new System.Drawing.Point(47, 110);
            this.LuEItem_Type_ID.Name = "LuEItem_Type_ID";
            this.LuEItem_Type_ID.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuEItem_Type_ID.Properties.Appearance.Options.UseFont = true;
            this.LuEItem_Type_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuEItem_Type_ID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Types_Name", "Name")});
            this.LuEItem_Type_ID.Properties.NullText = "";
            this.LuEItem_Type_ID.Properties.PopupFormMinSize = new System.Drawing.Size(150, 50);
            this.LuEItem_Type_ID.Properties.PopupSizeable = false;
            this.LuEItem_Type_ID.Properties.ShowFooter = false;
            this.LuEItem_Type_ID.Properties.ShowHeader = false;
            this.LuEItem_Type_ID.Properties.ShowLines = false;
            this.LuEItem_Type_ID.Size = new System.Drawing.Size(145, 20);
            this.LuEItem_Type_ID.TabIndex = 2;
            this.LuEItem_Type_ID.Tag = "";
            this.LuEItem_Type_ID.EditValueChanged += new System.EventHandler(this.LuEItem_Type_ID_EditValueChanged);
            // 
            // CkEActive
            // 
            this.CkEActive.Location = new System.Drawing.Point(551, 276);
            this.CkEActive.Name = "CkEActive";
            this.CkEActive.Properties.Caption = "Active";
            this.CkEActive.Size = new System.Drawing.Size(75, 20);
            this.CkEActive.TabIndex = 46;
            this.CkEActive.TabStop = false;
            this.CkEActive.EditValueChanged += new System.EventHandler(this.CkEActive_EditValueChanged);
            // 
            // lblBundlePrice
            // 
            this.lblBundlePrice.AutoSize = true;
            this.lblBundlePrice.Location = new System.Drawing.Point(321, 93);
            this.lblBundlePrice.Name = "lblBundlePrice";
            this.lblBundlePrice.Size = new System.Drawing.Size(95, 13);
            this.lblBundlePrice.TabIndex = 45;
            this.lblBundlePrice.Text = "Pack\\Bundle Price:";
            // 
            // lblPieceInPack
            // 
            this.lblPieceInPack.AutoSize = true;
            this.lblPieceInPack.Location = new System.Drawing.Point(321, 136);
            this.lblPieceInPack.Name = "lblPieceInPack";
            this.lblPieceInPack.Size = new System.Drawing.Size(74, 13);
            this.lblPieceInPack.TabIndex = 44;
            this.lblPieceInPack.Text = "Piece In Pack:";
            // 
            // TxtPiece_Per_Pack
            // 
            this.TxtPiece_Per_Pack.EnterMoveNextControl = true;
            this.TxtPiece_Per_Pack.Location = new System.Drawing.Point(324, 152);
            this.TxtPiece_Per_Pack.Name = "TxtPiece_Per_Pack";
            this.TxtPiece_Per_Pack.Size = new System.Drawing.Size(145, 20);
            this.TxtPiece_Per_Pack.TabIndex = 9;
            this.TxtPiece_Per_Pack.Tag = "";
            // 
            // lblStockCriticalLevel
            // 
            this.lblStockCriticalLevel.AutoSize = true;
            this.lblStockCriticalLevel.Location = new System.Drawing.Point(321, 177);
            this.lblStockCriticalLevel.Name = "lblStockCriticalLevel";
            this.lblStockCriticalLevel.Size = new System.Drawing.Size(100, 13);
            this.lblStockCriticalLevel.TabIndex = 39;
            this.lblStockCriticalLevel.Text = "Stock Critical Level:";
            // 
            // TxtStock_Critical_Level
            // 
            this.TxtStock_Critical_Level.EditValue = "0";
            this.TxtStock_Critical_Level.Enabled = false;
            this.TxtStock_Critical_Level.EnterMoveNextControl = true;
            this.TxtStock_Critical_Level.Location = new System.Drawing.Point(324, 193);
            this.TxtStock_Critical_Level.Name = "TxtStock_Critical_Level";
            this.TxtStock_Critical_Level.Size = new System.Drawing.Size(145, 20);
            this.TxtStock_Critical_Level.TabIndex = 10;
            // 
            // BCCItem_Barcode
            // 
            this.BCCItem_Barcode.AutoModule = true;
            this.BCCItem_Barcode.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BCCItem_Barcode.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BCCItem_Barcode.Location = new System.Drawing.Point(475, 177);
            this.BCCItem_Barcode.Name = "BCCItem_Barcode";
            this.BCCItem_Barcode.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.BCCItem_Barcode.Size = new System.Drawing.Size(180, 42);
            code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
            this.BCCItem_Barcode.Symbology = code128Generator1;
            this.BCCItem_Barcode.TabIndex = 37;
            this.BCCItem_Barcode.TabStop = false;
            this.BCCItem_Barcode.VerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BCCItem_Barcode.VerticalTextAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // TxtItem_Barcode
            // 
            this.TxtItem_Barcode.EnterMoveNextControl = true;
            this.TxtItem_Barcode.Location = new System.Drawing.Point(324, 277);
            this.TxtItem_Barcode.Name = "TxtItem_Barcode";
            this.TxtItem_Barcode.Size = new System.Drawing.Size(145, 20);
            this.TxtItem_Barcode.TabIndex = 12;
            this.TxtItem_Barcode.Tag = "*";
            this.TxtItem_Barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_Barcode_KeyPress);
            this.TxtItem_Barcode.Leave += new System.EventHandler(this.TxtItem_Barcode_Leave);
            // 
            // TxtItem_Name
            // 
            this.TxtItem_Name.EnterMoveNextControl = true;
            this.TxtItem_Name.Location = new System.Drawing.Point(47, 69);
            this.TxtItem_Name.Name = "TxtItem_Name";
            this.TxtItem_Name.Size = new System.Drawing.Size(145, 20);
            this.TxtItem_Name.TabIndex = 1;
            this.TxtItem_Name.Tag = "*";
            this.TxtItem_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_Name_KeyPress);
            // 
            // DtEItem_Expiry_Date
            // 
            this.DtEItem_Expiry_Date.EditValue = null;
            this.DtEItem_Expiry_Date.EnterMoveNextControl = true;
            this.DtEItem_Expiry_Date.Location = new System.Drawing.Point(324, 234);
            this.DtEItem_Expiry_Date.Name = "DtEItem_Expiry_Date";
            this.DtEItem_Expiry_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEItem_Expiry_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEItem_Expiry_Date.Size = new System.Drawing.Size(145, 20);
            this.DtEItem_Expiry_Date.TabIndex = 11;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(321, 216);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(67, 13);
            this.lblExpiryDate.TabIndex = 25;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(47, 260);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(81, 13);
            this.lblPurchasePrice.TabIndex = 23;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // lblSPWT
            // 
            this.lblSPWT.AutoSize = true;
            this.lblSPWT.Location = new System.Drawing.Point(321, 54);
            this.lblSPWT.Name = "lblSPWT";
            this.lblSPWT.Size = new System.Drawing.Size(103, 13);
            this.lblSPWT.TabIndex = 22;
            this.lblSPWT.Text = "Sale Price With Tax:";
            // 
            // Txtsale
            // 
            this.Txtsale.EnterMoveNextControl = true;
            this.Txtsale.Location = new System.Drawing.Point(324, 69);
            this.Txtsale.Name = "Txtsale";
            this.Txtsale.Size = new System.Drawing.Size(145, 20);
            this.Txtsale.TabIndex = 7;
            this.Txtsale.Tag = "*";
            this.Txtsale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_Sale_Price_KeyPress);
            this.Txtsale.Leave += new System.EventHandler(this.Txtsale_Leave);
            // 
            // TxtItem_Sale_Price
            // 
            this.TxtItem_Sale_Price.EnterMoveNextControl = true;
            this.TxtItem_Sale_Price.Location = new System.Drawing.Point(324, 30);
            this.TxtItem_Sale_Price.Name = "TxtItem_Sale_Price";
            this.TxtItem_Sale_Price.Size = new System.Drawing.Size(145, 20);
            this.TxtItem_Sale_Price.TabIndex = 115;
            this.TxtItem_Sale_Price.Tag = "";
            this.TxtItem_Sale_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_Sale_Price_KeyPress);
            this.TxtItem_Sale_Price.Leave += new System.EventHandler(this.TxtItem_Sale_Price_Leave);
            // 
            // TxtItem_Purchase_Price
            // 
            this.TxtItem_Purchase_Price.EditValue = "";
            this.TxtItem_Purchase_Price.EnterMoveNextControl = true;
            this.TxtItem_Purchase_Price.Location = new System.Drawing.Point(47, 276);
            this.TxtItem_Purchase_Price.Name = "TxtItem_Purchase_Price";
            this.TxtItem_Purchase_Price.Size = new System.Drawing.Size(145, 20);
            this.TxtItem_Purchase_Price.TabIndex = 6;
            this.TxtItem_Purchase_Price.Tag = "*";
            this.TxtItem_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_Purchase_Price_KeyPress);
            // 
            // lblItemUnit
            // 
            this.lblItemUnit.AutoSize = true;
            this.lblItemUnit.Location = new System.Drawing.Point(47, 216);
            this.lblItemUnit.Name = "lblItemUnit";
            this.lblItemUnit.Size = new System.Drawing.Size(55, 13);
            this.lblItemUnit.TabIndex = 19;
            this.lblItemUnit.Text = "Item Unit:";
            // 
            // TxtItem_ID
            // 
            this.TxtItem_ID.Location = new System.Drawing.Point(47, 30);
            this.TxtItem_ID.Name = "TxtItem_ID";
            this.TxtItem_ID.Size = new System.Drawing.Size(145, 20);
            this.TxtItem_ID.TabIndex = 0;
            this.TxtItem_ID.TabStop = false;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(47, 14);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(47, 13);
            this.lblItemID.TabIndex = 3;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(47, 54);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(63, 13);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblItemBarcode
            // 
            this.lblItemBarcode.AutoSize = true;
            this.lblItemBarcode.Location = new System.Drawing.Point(321, 261);
            this.lblItemBarcode.Name = "lblItemBarcode";
            this.lblItemBarcode.Size = new System.Drawing.Size(75, 13);
            this.lblItemBarcode.TabIndex = 5;
            this.lblItemBarcode.Text = "Item Barcode:";
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(47, 93);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(60, 13);
            this.lblItemType.TabIndex = 9;
            this.lblItemType.Text = "Item Type:";
            // 
            // lblItemSize
            // 
            this.lblItemSize.AutoSize = true;
            this.lblItemSize.Location = new System.Drawing.Point(47, 177);
            this.lblItemSize.Name = "lblItemSize";
            this.lblItemSize.Size = new System.Drawing.Size(55, 13);
            this.lblItemSize.TabIndex = 11;
            this.lblItemSize.Text = "Item Size:";
            // 
            // lblItemSubType
            // 
            this.lblItemSubType.AutoSize = true;
            this.lblItemSubType.Location = new System.Drawing.Point(47, 136);
            this.lblItemSubType.Name = "lblItemSubType";
            this.lblItemSubType.Size = new System.Drawing.Size(78, 13);
            this.lblItemSubType.TabIndex = 10;
            this.lblItemSubType.Text = "Item SubType:";
            // 
            // TxtPack_Price
            // 
            this.TxtPack_Price.EditValue = "0";
            this.TxtPack_Price.EnterMoveNextControl = true;
            this.TxtPack_Price.Location = new System.Drawing.Point(324, 110);
            this.TxtPack_Price.Name = "TxtPack_Price";
            this.TxtPack_Price.Size = new System.Drawing.Size(145, 20);
            this.TxtPack_Price.TabIndex = 8;
            this.TxtPack_Price.Tag = "";
            // 
            // TPHistory
            // 
            this.TPHistory.Controls.Add(this.gridControl1);
            this.TPHistory.Name = "TPHistory";
            this.TPHistory.Size = new System.Drawing.Size(663, 305);
            this.TPHistory.Text = "History";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(663, 301);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn3,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn5,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "No";
            this.gridColumn1.FieldName = "Item_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 35;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Barcode";
            this.gridColumn2.FieldName = "Item_Barcode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Type";
            this.gridColumn6.FieldName = "Types_Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Category";
            this.gridColumn7.FieldName = "Category_Name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowMove = false;
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name";
            this.gridColumn3.FieldName = "Item_Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 130;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Unit";
            this.gridColumn8.FieldName = "Unit_Name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowMove = false;
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 55;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Sale";
            this.gridColumn9.FieldName = "Item_Sale_Price";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.FixedWidth = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 45;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Date Created";
            this.gridColumn5.FieldName = "Created_Date";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowMove = false;
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.FieldName = "Active";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 45;
            // 
            // BtnCancel
            // 
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(526, 379);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(71, 22);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(449, 379);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(71, 22);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(295, 379);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 22);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.ImageOptions.Image")));
            this.BtnNew.Location = new System.Drawing.Point(141, 379);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(71, 22);
            this.BtnNew.TabIndex = 13;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.ImageOptions.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(218, 379);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(71, 22);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblCreateItems
            // 
            this.lblCreateItems.AutoSize = true;
            this.lblCreateItems.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateItems.ForeColor = System.Drawing.Color.White;
            this.lblCreateItems.Location = new System.Drawing.Point(281, 9);
            this.lblCreateItems.Name = "lblCreateItems";
            this.lblCreateItems.Size = new System.Drawing.Size(134, 23);
            this.lblCreateItems.TabIndex = 0;
            this.lblCreateItems.Text = "Create Items";
            this.lblCreateItems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(372, 379);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(71, 22);
            this.BtnSearch.TabIndex = 16;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(117)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.lblCreateItems);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 39);
            this.panel1.TabIndex = 46;
            // 
            // ErPro
            // 
            this.ErPro.ContainerControl = this;
            // 
            // frmItems_Deffination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 407);
            this.Controls.Add(this.TCItems);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmItems_Deffination.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmItems_Deffination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Items Defination";
            this.Load += new System.EventHandler(this.frmItems_Deffination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TCItems)).EndInit();
            this.TCItems.ResumeLayout(false);
            this.TPItems.ResumeLayout(false);
            this.TPItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkEIsPacked.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Unit_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Size_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Category_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuEItem_Type_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkEActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPiece_Per_Pack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock_Critical_Level.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Barcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEItem_Expiry_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEItem_Expiry_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtsale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Sale_Price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_Purchase_Price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtItem_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPack_Price.Properties)).EndInit();
            this.TPHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TCItems;
        private DevExpress.XtraTab.XtraTabPage TPItems;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSPWT;
        private DevExpress.XtraEditors.TextEdit TxtItem_Sale_Price;
        private DevExpress.XtraEditors.TextEdit TxtItem_Purchase_Price;
        private System.Windows.Forms.Label lblItemUnit;
        private DevExpress.XtraEditors.TextEdit TxtItem_ID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemBarcode;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblItemSize;
        private System.Windows.Forms.Label lblItemSubType;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.SimpleButton BtnEdit;
        private System.Windows.Forms.Label lblCreateItems;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit DtEItem_Expiry_Date;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ErPro;
        private DevExpress.XtraEditors.TextEdit TxtItem_Name;
        private DevExpress.XtraEditors.TextEdit TxtItem_Barcode;
        private DevExpress.XtraEditors.BarCodeControl BCCItem_Barcode;
        private System.Windows.Forms.Label lblStockCriticalLevel;
        private DevExpress.XtraEditors.TextEdit TxtStock_Critical_Level;
        private System.Windows.Forms.Label lblBundlePrice;
        private System.Windows.Forms.Label lblPieceInPack;
        private DevExpress.XtraEditors.TextEdit TxtPiece_Per_Pack;
        private DevExpress.XtraEditors.CheckEdit CkEActive;
        private DevExpress.XtraEditors.LookUpEdit LuEItem_Category_ID;
        private DevExpress.XtraEditors.LookUpEdit LuEItem_Type_ID;
        private DevExpress.XtraEditors.LookUpEdit LuEItem_Unit_ID;
        private DevExpress.XtraEditors.LookUpEdit LuEItem_Size_ID;
        private DevExpress.XtraTab.XtraTabPage TPHistory;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.CheckEdit CkEIsPacked;
        private DevExpress.XtraEditors.TextEdit TxtPack_Price;
        private DevExpress.XtraEditors.TextEdit Txtsale;
        private System.Windows.Forms.Label lblSPWOT;
    }
}