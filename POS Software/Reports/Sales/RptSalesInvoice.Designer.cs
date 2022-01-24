namespace POS_Software.Reports.Sales
{
    partial class RptSalesInvoice
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptSalesInvoice));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.ldProduct = new DevExpress.XtraReports.UI.XRTableCell();
            this.ldPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.ldQty = new DevExpress.XtraReports.UI.XRTableCell();
            this.ldAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TblVendor = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.LblApplicationName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow44 = new DevExpress.XtraReports.UI.XRTableRow();
            this.LblVendorName = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblVATNUmber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.lblQuantity = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.lblProductName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblInvoiceNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.ldDate = new DevExpress.XtraReports.UI.XRLabel();
            this.ldInvoiceNo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.lblStoreName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGreeting = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lbltaxamount = new DevExpress.XtraReports.UI.XRLabel();
            this.lblnetamount = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRecievedCash = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBalance = new DevExpress.XtraReports.UI.XRLabel();
            this.ldUseName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblUserName = new DevExpress.XtraReports.UI.XRLabel();
            this.ldBalance = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGrandTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.ldGrandTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.ldRecievedCash = new DevExpress.XtraReports.UI.XRLabel();
            this.xrpaymenttype = new DevExpress.XtraReports.UI.XRLabel();
            this.ldpaymentname = new DevExpress.XtraReports.UI.XRLabel();
            this.ldpaymenttype = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(261.9999F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.ldProduct,
            this.ldPrice,
            this.ldQty,
            this.ldAmount});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // ldProduct
            // 
            this.ldProduct.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.ldProduct.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldProduct.Name = "ldProduct";
            this.ldProduct.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldProduct.StylePriority.UseBorders = false;
            this.ldProduct.StylePriority.UseFont = false;
            this.ldProduct.StylePriority.UsePadding = false;
            this.ldProduct.StylePriority.UseTextAlignment = false;
            this.ldProduct.Tag = "Item_Name";
            this.ldProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.ldProduct.Weight = 1.0495852647828139D;
            // 
            // ldPrice
            // 
            this.ldPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.ldPrice.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldPrice.Name = "ldPrice";
            this.ldPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldPrice.StylePriority.UseBorders = false;
            this.ldPrice.StylePriority.UseFont = false;
            this.ldPrice.StylePriority.UsePadding = false;
            this.ldPrice.StylePriority.UseTextAlignment = false;
            this.ldPrice.Tag = "Item_Sale_Price";
            this.ldPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.ldPrice.Weight = 0.54708343476047316D;
            // 
            // ldQty
            // 
            this.ldQty.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.ldQty.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldQty.Name = "ldQty";
            this.ldQty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldQty.StylePriority.UseBorders = false;
            this.ldQty.StylePriority.UseFont = false;
            this.ldQty.StylePriority.UsePadding = false;
            this.ldQty.StylePriority.UseTextAlignment = false;
            this.ldQty.Tag = "Qty";
            this.ldQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.ldQty.Weight = 0.45000015258788995D;
            // 
            // ldAmount
            // 
            this.ldAmount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.ldAmount.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldAmount.Name = "ldAmount";
            this.ldAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldAmount.StylePriority.UseBorders = false;
            this.ldAmount.StylePriority.UseFont = false;
            this.ldAmount.StylePriority.UsePadding = false;
            this.ldAmount.StylePriority.UseTextAlignment = false;
            this.ldAmount.Tag = "Amount";
            this.ldAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ldAmount.Weight = 0.57333054822919116D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 10F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TblVendor});
            this.BottomMargin.HeightF = 72F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TblVendor
            // 
            this.TblVendor.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblVendor.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.TblVendor.Name = "TblVendor";
            this.TblVendor.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow44});
            this.TblVendor.SizeF = new System.Drawing.SizeF(262F, 36.38889F);
            this.TblVendor.StylePriority.UseFont = false;
            this.TblVendor.StylePriority.UseTextAlignment = false;
            this.TblVendor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TblVendor.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TblVendor_BeforePrint);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.LblApplicationName});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // LblApplicationName
            // 
            this.LblApplicationName.Name = "LblApplicationName";
            this.LblApplicationName.Text = "fads";
            this.LblApplicationName.Weight = 3D;
            // 
            // xrTableRow44
            // 
            this.xrTableRow44.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.LblVendorName});
            this.xrTableRow44.Name = "xrTableRow44";
            this.xrTableRow44.Weight = 1D;
            // 
            // LblVendorName
            // 
            this.LblVendorName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendorName.Name = "LblVendorName";
            this.LblVendorName.StylePriority.UseFont = false;
            this.LblVendorName.Text = "dsfasd";
            this.LblVendorName.Weight = 3D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ldpaymenttype,
            this.xrpaymenttype,
            this.ldpaymentname,
            this.xrPictureBox2,
            this.lblVATNUmber,
            this.xrLabel1,
            this.xrLabel2,
            this.lblPrice,
            this.lblQuantity,
            this.lblAmount,
            this.lblProductName,
            this.lblInvoiceNumber,
            this.ldDate,
            this.ldInvoiceNo,
            this.lblDate,
            this.lblNumber,
            this.lblAddress,
            this.lblStoreName,
            this.lblGreeting});
            this.GroupHeader1.HeightF = 272.4585F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(44.62502F, 16.74999F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(172.9167F, 85.00001F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.xrPictureBox2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBox2_BeforePrint);
            // 
            // lblVATNUmber
            // 
            this.lblVATNUmber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVATNUmber.LocationFloat = new DevExpress.Utils.PointFloat(99.0833F, 140.75F);
            this.lblVATNUmber.Name = "lblVATNUmber";
            this.lblVATNUmber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblVATNUmber.SizeF = new System.Drawing.SizeF(172.9167F, 16F);
            this.lblVATNUmber.StylePriority.UseFont = false;
            this.lblVATNUmber.StylePriority.UseTextAlignment = false;
            this.lblVATNUmber.Text = "VAT#  0323-8046756";
            this.lblVATNUmber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 181.75F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(58.74997F, 15.00001F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Customer:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel1_BeforePrint);
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(68.74997F, 181.75F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(120.3336F, 15.00002F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Tag = "Customer";
            this.xrLabel2.Text = "001";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblPrice.LocationFloat = new DevExpress.Utils.PointFloat(114.9585F, 234.0417F);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPrice.SizeF = new System.Drawing.SizeF(54.70834F, 38.41666F);
            this.lblPrice.StylePriority.UseBackColor = false;
            this.lblPrice.StylePriority.UseBorders = false;
            this.lblPrice.StylePriority.UseTextAlignment = false;
            this.lblPrice.Text = "Unit Price";
            this.lblPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblQuantity.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblQuantity.LocationFloat = new DevExpress.Utils.PointFloat(169.6669F, 234.0418F);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblQuantity.SizeF = new System.Drawing.SizeF(45F, 38.41666F);
            this.lblQuantity.StylePriority.UseBackColor = false;
            this.lblQuantity.StylePriority.UseBorders = false;
            this.lblQuantity.StylePriority.UseTextAlignment = false;
            this.lblQuantity.Text = "Qty";
            this.lblQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAmount.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblAmount.LocationFloat = new DevExpress.Utils.PointFloat(214.6669F, 234.0418F);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAmount.SizeF = new System.Drawing.SizeF(57.91643F, 38.41666F);
            this.lblAmount.StylePriority.UseBackColor = false;
            this.lblAmount.StylePriority.UseBorders = false;
            this.lblAmount.StylePriority.UseTextAlignment = false;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblProductName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblProductName.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 234.0417F);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblProductName.SizeF = new System.Drawing.SizeF(104.9585F, 38.41666F);
            this.lblProductName.StylePriority.UseBackColor = false;
            this.lblProductName.StylePriority.UseBorders = false;
            this.lblProductName.StylePriority.UseTextAlignment = false;
            this.lblProductName.Text = "Product";
            this.lblProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.LocationFloat = new DevExpress.Utils.PointFloat(213.0836F, 181.75F);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblInvoiceNumber.SizeF = new System.Drawing.SizeF(58.91644F, 15.00001F);
            this.lblInvoiceNumber.StylePriority.UseFont = false;
            this.lblInvoiceNumber.StylePriority.UseTextAlignment = false;
            this.lblInvoiceNumber.Text = "Invoice Number:";
            this.lblInvoiceNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ldDate
            // 
            this.ldDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldDate.LocationFloat = new DevExpress.Utils.PointFloat(68.74997F, 196.75F);
            this.ldDate.Name = "ldDate";
            this.ldDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldDate.SizeF = new System.Drawing.SizeF(120.3336F, 15.00002F);
            this.ldDate.StylePriority.UseFont = false;
            this.ldDate.Tag = "Date";
            this.ldDate.Text = "08-08-2017";
            // 
            // ldInvoiceNo
            // 
            this.ldInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldInvoiceNo.LocationFloat = new DevExpress.Utils.PointFloat(224.5833F, 196.75F);
            this.ldInvoiceNo.Name = "ldInvoiceNo";
            this.ldInvoiceNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldInvoiceNo.SizeF = new System.Drawing.SizeF(47.41669F, 15.00002F);
            this.ldInvoiceNo.StylePriority.UseFont = false;
            this.ldInvoiceNo.StylePriority.UseTextAlignment = false;
            this.ldInvoiceNo.Tag = "InvoiceNumber";
            this.ldInvoiceNo.Text = "001";
            this.ldInvoiceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.LocationFloat = new DevExpress.Utils.PointFloat(10F, 196.75F);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDate.SizeF = new System.Drawing.SizeF(47.54167F, 15F);
            this.lblDate.StylePriority.UseFont = false;
            this.lblDate.Text = "Date:";
            this.lblDate.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lblDate_BeforePrint);
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.LocationFloat = new DevExpress.Utils.PointFloat(99.0833F, 156.75F);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNumber.SizeF = new System.Drawing.SizeF(172.9167F, 16F);
            this.lblNumber.StylePriority.UseFont = false;
            this.lblNumber.StylePriority.UseTextAlignment = false;
            this.lblNumber.Text = "Cell Number: 0323-8046756";
            this.lblNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.LocationFloat = new DevExpress.Utils.PointFloat(99.0833F, 124.75F);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAddress.SizeF = new System.Drawing.SizeF(172.9167F, 16F);
            this.lblAddress.StylePriority.UseFont = false;
            this.lblAddress.StylePriority.UseTextAlignment = false;
            this.lblAddress.Text = "H#123, St#08, TajhBagh Lahore";
            this.lblAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblStoreName
            // 
            this.lblStoreName.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.lblStoreName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblStoreName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 101.75F);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblStoreName.SizeF = new System.Drawing.SizeF(271F, 23F);
            this.lblStoreName.StylePriority.UseBackColor = false;
            this.lblStoreName.StylePriority.UseBorderDashStyle = false;
            this.lblStoreName.StylePriority.UseBorders = false;
            this.lblStoreName.StylePriority.UseFont = false;
            this.lblStoreName.StylePriority.UseTextAlignment = false;
            this.lblStoreName.Text = "Super Mart Reciept";
            this.lblStoreName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblGreeting
            // 
            this.lblGreeting.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.lblGreeting.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblGreeting.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.LocationFloat = new DevExpress.Utils.PointFloat(44.62502F, 0F);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblGreeting.SizeF = new System.Drawing.SizeF(172.9167F, 16.75F);
            this.lblGreeting.StylePriority.UseBorderDashStyle = false;
            this.lblGreeting.StylePriority.UseBorders = false;
            this.lblGreeting.StylePriority.UseFont = false;
            this.lblGreeting.StylePriority.UseTextAlignment = false;
            this.lblGreeting.Text = "Thank You for Shoping With Us";
            this.lblGreeting.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblGreeting.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lblGreeting_BeforePrint);
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.lbltaxamount,
            this.lblnetamount,
            this.xrLabel3,
            this.xrLabel4,
            this.lblRecievedCash,
            this.lblBalance,
            this.ldUseName,
            this.lblUserName,
            this.ldBalance,
            this.lblGrandTotal,
            this.ldGrandTotal,
            this.ldRecievedCash});
            this.GroupFooter1.HeightF = 274.2083F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.BandLevelChanged += new System.EventHandler(this.GroupFooter1_BandLevelChanged);
            this.GroupFooter1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupFooter1_BeforePrint);
            this.GroupFooter1.AfterPrint += new System.EventHandler(this.GroupFooter1_AfterPrint);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(44.62502F, 100F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(170.0419F, 151.2082F);
            // 
            // lbltaxamount
            // 
            this.lbltaxamount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.lbltaxamount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbltaxamount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxamount.LocationFloat = new DevExpress.Utils.PointFloat(30.58325F, 20.00001F);
            this.lbltaxamount.Name = "lbltaxamount";
            this.lbltaxamount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbltaxamount.SizeF = new System.Drawing.SizeF(149.5002F, 20F);
            this.lbltaxamount.StylePriority.UseBorderDashStyle = false;
            this.lbltaxamount.StylePriority.UseBorders = false;
            this.lbltaxamount.StylePriority.UseFont = false;
            this.lbltaxamount.StylePriority.UseTextAlignment = false;
            this.lbltaxamount.Text = "Tax Amount 15% : ";
            this.lbltaxamount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblnetamount
            // 
            this.lblnetamount.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.lblnetamount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lblnetamount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetamount.LocationFloat = new DevExpress.Utils.PointFloat(30.58325F, 39.99999F);
            this.lblnetamount.Name = "lblnetamount";
            this.lblnetamount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblnetamount.SizeF = new System.Drawing.SizeF(149.5003F, 20F);
            this.lblnetamount.StylePriority.UseBorderDashStyle = false;
            this.lblnetamount.StylePriority.UseBorders = false;
            this.lblnetamount.StylePriority.UseFont = false;
            this.lblnetamount.StylePriority.UseTextAlignment = false;
            this.lblnetamount.Text = "Net Amount : ";
            this.lblnetamount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(180.0836F, 40F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(86.45825F, 20F);
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Tag = "ShopAmount";
            this.xrLabel3.Text = "2000";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(180.0836F, 20F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(86.45825F, 20F);
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Tag = "TaxAmount";
            this.xrLabel4.Text = "1200";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblRecievedCash
            // 
            this.lblRecievedCash.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.lblRecievedCash.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lblRecievedCash.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecievedCash.LocationFloat = new DevExpress.Utils.PointFloat(31.58328F, 60.00001F);
            this.lblRecievedCash.Name = "lblRecievedCash";
            this.lblRecievedCash.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRecievedCash.SizeF = new System.Drawing.SizeF(148.5003F, 20F);
            this.lblRecievedCash.StylePriority.UseBorderDashStyle = false;
            this.lblRecievedCash.StylePriority.UseBorders = false;
            this.lblRecievedCash.StylePriority.UseFont = false;
            this.lblRecievedCash.StylePriority.UseTextAlignment = false;
            this.lblRecievedCash.Text = "Recieved Cash : ";
            this.lblRecievedCash.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            this.lblBalance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.lblBalance.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblBalance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.LocationFloat = new DevExpress.Utils.PointFloat(57.62505F, 80.00002F);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblBalance.SizeF = new System.Drawing.SizeF(122.4585F, 20F);
            this.lblBalance.StylePriority.UseBorderDashStyle = false;
            this.lblBalance.StylePriority.UseBorders = false;
            this.lblBalance.StylePriority.UseFont = false;
            this.lblBalance.StylePriority.UseTextAlignment = false;
            this.lblBalance.Text = "Balance : ";
            this.lblBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ldUseName
            // 
            this.ldUseName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.ldUseName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ldUseName.LocationFloat = new DevExpress.Utils.PointFloat(102.0833F, 251.2083F);
            this.ldUseName.Name = "ldUseName";
            this.ldUseName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldUseName.SizeF = new System.Drawing.SizeF(177.4998F, 23F);
            this.ldUseName.StylePriority.UseBorderDashStyle = false;
            this.ldUseName.StylePriority.UseBorders = false;
            this.ldUseName.StylePriority.UseTextAlignment = false;
            this.ldUseName.Tag = "Created_By";
            this.ldUseName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lblUserName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblUserName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 251.2083F);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblUserName.SizeF = new System.Drawing.SizeF(102.0833F, 23F);
            this.lblUserName.StylePriority.UseBorderDashStyle = false;
            this.lblUserName.StylePriority.UseBorders = false;
            this.lblUserName.StylePriority.UseTextAlignment = false;
            this.lblUserName.Text = "Sales User :";
            this.lblUserName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ldBalance
            // 
            this.ldBalance.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.ldBalance.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ldBalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldBalance.LocationFloat = new DevExpress.Utils.PointFloat(180.0835F, 80F);
            this.ldBalance.Name = "ldBalance";
            this.ldBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldBalance.SizeF = new System.Drawing.SizeF(86.45825F, 20F);
            this.ldBalance.StylePriority.UseBorderDashStyle = false;
            this.ldBalance.StylePriority.UseBorders = false;
            this.ldBalance.StylePriority.UseFont = false;
            this.ldBalance.StylePriority.UseTextAlignment = false;
            this.ldBalance.Tag = "Balance";
            this.ldBalance.Text = "800";
            this.ldBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.lblGrandTotal.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblGrandTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.LocationFloat = new DevExpress.Utils.PointFloat(31.58327F, 0F);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblGrandTotal.SizeF = new System.Drawing.SizeF(148.5F, 20F);
            this.lblGrandTotal.StylePriority.UseBorderDashStyle = false;
            this.lblGrandTotal.StylePriority.UseBorders = false;
            this.lblGrandTotal.StylePriority.UseFont = false;
            this.lblGrandTotal.StylePriority.UseTextAlignment = false;
            this.lblGrandTotal.Text = "Grand Total : ";
            this.lblGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblGrandTotal.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lblGrandTotal_BeforePrint);
            // 
            // ldGrandTotal
            // 
            this.ldGrandTotal.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.ldGrandTotal.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ldGrandTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldGrandTotal.LocationFloat = new DevExpress.Utils.PointFloat(180.0837F, 0F);
            this.ldGrandTotal.Name = "ldGrandTotal";
            this.ldGrandTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldGrandTotal.SizeF = new System.Drawing.SizeF(86.45825F, 20F);
            this.ldGrandTotal.StylePriority.UseBorderDashStyle = false;
            this.ldGrandTotal.StylePriority.UseBorders = false;
            this.ldGrandTotal.StylePriority.UseFont = false;
            this.ldGrandTotal.StylePriority.UseTextAlignment = false;
            this.ldGrandTotal.Tag = "GrandTotal";
            this.ldGrandTotal.Text = "1200";
            this.ldGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ldRecievedCash
            // 
            this.ldRecievedCash.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.ldRecievedCash.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.ldRecievedCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldRecievedCash.LocationFloat = new DevExpress.Utils.PointFloat(180.0837F, 60F);
            this.ldRecievedCash.Name = "ldRecievedCash";
            this.ldRecievedCash.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldRecievedCash.SizeF = new System.Drawing.SizeF(86.45825F, 20F);
            this.ldRecievedCash.StylePriority.UseBorderDashStyle = false;
            this.ldRecievedCash.StylePriority.UseBorders = false;
            this.ldRecievedCash.StylePriority.UseFont = false;
            this.ldRecievedCash.StylePriority.UseTextAlignment = false;
            this.ldRecievedCash.Tag = "RecievedCash";
            this.ldRecievedCash.Text = "2000";
            this.ldRecievedCash.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrpaymenttype
            // 
            this.xrpaymenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrpaymenttype.LocationFloat = new DevExpress.Utils.PointFloat(10F, 211.75F);
            this.xrpaymenttype.Name = "xrpaymenttype";
            this.xrpaymenttype.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrpaymenttype.SizeF = new System.Drawing.SizeF(47.54167F, 15F);
            this.xrpaymenttype.StylePriority.UseFont = false;
            this.xrpaymenttype.Text = "Date:";
            this.xrpaymenttype.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrpaymenttype_BeforePrint);
            // 
            // ldpaymentname
            // 
            this.ldpaymentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldpaymentname.LocationFloat = new DevExpress.Utils.PointFloat(68.74997F, 211.75F);
            this.ldpaymentname.Name = "ldpaymentname";
            this.ldpaymentname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldpaymentname.SizeF = new System.Drawing.SizeF(120.3336F, 15.00002F);
            this.ldpaymentname.StylePriority.UseFont = false;
            this.ldpaymentname.Tag = "Date";
            this.ldpaymentname.Text = "08-08-2017";
            this.ldpaymentname.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ldpaymentname_BeforePrint);
            // 
            // ldpaymenttype
            // 
            this.ldpaymenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldpaymenttype.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 156.75F);
            this.ldpaymenttype.Name = "ldpaymenttype";
            this.ldpaymenttype.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldpaymenttype.SizeF = new System.Drawing.SizeF(58.74997F, 15.00002F);
            this.ldpaymenttype.StylePriority.UseFont = false;
            this.ldpaymenttype.Tag = "paymenttype";
            this.ldpaymenttype.Text = "08-08-2017";
            this.ldpaymenttype.Visible = false;
            // 
            // RptSalesInvoice
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.Margins = new System.Drawing.Printing.Margins(9, 0, 10, 72);
            this.PageHeight = 500;
            this.PageWidth = 291;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.RollPaper = true;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel lblGreeting;
        private DevExpress.XtraReports.UI.XRLabel lblInvoiceNumber;
        private DevExpress.XtraReports.UI.XRLabel ldDate;
        private DevExpress.XtraReports.UI.XRLabel ldInvoiceNo;
        private DevExpress.XtraReports.UI.XRLabel lblDate;
        private DevExpress.XtraReports.UI.XRLabel lblNumber;
        private DevExpress.XtraReports.UI.XRLabel lblAddress;
        private DevExpress.XtraReports.UI.XRLabel lblStoreName;
        private DevExpress.XtraReports.UI.XRLabel lblProductName;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel ldBalance;
        private DevExpress.XtraReports.UI.XRLabel lblGrandTotal;
        private DevExpress.XtraReports.UI.XRLabel ldGrandTotal;
        private DevExpress.XtraReports.UI.XRLabel ldRecievedCash;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell ldProduct;
        private DevExpress.XtraReports.UI.XRTableCell ldPrice;
        private DevExpress.XtraReports.UI.XRTableCell ldQty;
        private DevExpress.XtraReports.UI.XRTableCell ldAmount;
        private DevExpress.XtraReports.UI.XRLabel ldUseName;
        private DevExpress.XtraReports.UI.XRLabel lblUserName;
        private DevExpress.XtraReports.UI.XRLabel lblRecievedCash;
        private DevExpress.XtraReports.UI.XRLabel lblBalance;
        private DevExpress.XtraReports.UI.XRLabel lblPrice;
        private DevExpress.XtraReports.UI.XRLabel lblQuantity;
        private DevExpress.XtraReports.UI.XRLabel lblAmount;
        private DevExpress.XtraReports.UI.XRLabel lbltaxamount;
        private DevExpress.XtraReports.UI.XRLabel lblnetamount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRTable TblVendor;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell LblApplicationName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow44;
        private DevExpress.XtraReports.UI.XRTableCell LblVendorName;
        private DevExpress.XtraReports.UI.XRLabel lblVATNUmber;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRLabel ldpaymenttype;
        private DevExpress.XtraReports.UI.XRLabel xrpaymenttype;
        private DevExpress.XtraReports.UI.XRLabel ldpaymentname;
    }
}
