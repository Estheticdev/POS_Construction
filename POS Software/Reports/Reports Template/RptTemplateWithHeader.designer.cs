namespace POS_Software.Reports.Report_Template
{
    partial class RptTemplateWithHeader
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PicLicenseLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.TblLicense = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblLicenseName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblLicenseAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblLicenseContacts = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.LblPrintDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.TblVendor = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.LblApplicationName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow44 = new DevExpress.XtraReports.UI.XRTableRow();
            this.LblVendorName = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblReportName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.TblLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1});
            this.Detail.HeightF = 72.9166F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PicLicenseLogo
            // 
            this.PicLicenseLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.PicLicenseLogo.Name = "PicLicenseLogo";
            this.PicLicenseLogo.SizeF = new System.Drawing.SizeF(150F, 100F);
            this.PicLicenseLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.PicLicenseLogo.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PicLicenseLogo_BeforePrint);
            // 
            // TblLicense
            // 
            this.TblLicense.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblLicense.LocationFloat = new DevExpress.Utils.PointFloat(199F, 0F);
            this.TblLicense.Name = "TblLicense";
            this.TblLicense.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TblLicense.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow2});
            this.TblLicense.SizeF = new System.Drawing.SizeF(563F, 70.27083F);
            this.TblLicense.StylePriority.UseFont = false;
            this.TblLicense.StylePriority.UsePadding = false;
            this.TblLicense.StylePriority.UseTextAlignment = false;
            this.TblLicense.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TblLicense.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TblLicense_BeforePrint);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblLicenseName});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // lblLicenseName
            // 
            this.lblLicenseName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseName.Name = "lblLicenseName";
            this.lblLicenseName.StylePriority.UseFont = false;
            this.lblLicenseName.Weight = 3D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblLicenseAddress});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // lblLicenseAddress
            // 
            this.lblLicenseAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseAddress.Name = "lblLicenseAddress";
            this.lblLicenseAddress.StylePriority.UseFont = false;
            this.lblLicenseAddress.StylePriority.UseTextAlignment = false;
            this.lblLicenseAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblLicenseAddress.Weight = 3D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblLicenseContacts});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // lblLicenseContacts
            // 
            this.lblLicenseContacts.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseContacts.Name = "lblLicenseContacts";
            this.lblLicenseContacts.StylePriority.UseFont = false;
            this.lblLicenseContacts.StylePriority.UseTextAlignment = false;
            this.lblLicenseContacts.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblLicenseContacts.Weight = 3D;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.LblPrintDate,
            this.xrPageInfo2,
            this.TblVendor});
            this.PageFooter.HeightF = 36.44446F;
            this.PageFooter.Name = "PageFooter";
            // 
            // LblPrintDate
            // 
            this.LblPrintDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrintDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 18.22223F);
            this.LblPrintDate.Name = "LblPrintDate";
            this.LblPrintDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LblPrintDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.LblPrintDate.SizeF = new System.Drawing.SizeF(201.1765F, 18.19444F);
            this.LblPrintDate.StylePriority.UseFont = false;
            this.LblPrintDate.StylePriority.UseTextAlignment = false;
            this.LblPrintDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.LblPrintDate.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.LblPrintDate_BeforePrint);
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPageInfo2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.Format = "Page {0} / {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.02778816F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(74.26823F, 18.19444F);
            this.xrPageInfo2.StylePriority.UseBorders = false;
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TblVendor
            // 
            this.TblVendor.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblVendor.LocationFloat = new DevExpress.Utils.PointFloat(271.981F, 0F);
            this.TblVendor.Name = "TblVendor";
            this.TblVendor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TblVendor.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow44});
            this.TblVendor.SizeF = new System.Drawing.SizeF(490.0189F, 36.38889F);
            this.TblVendor.StylePriority.UseFont = false;
            this.TblVendor.StylePriority.UsePadding = false;
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
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblReportName,
            this.PicLicenseLogo,
            this.TblLicense});
            this.PageHeader.HeightF = 162.4999F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
            // 
            // lblReportName
            // 
            this.lblReportName.BackColor = System.Drawing.Color.Transparent;
            this.lblReportName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 118.125F);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReportName.SizeF = new System.Drawing.SizeF(762F, 23F);
            this.lblReportName.StylePriority.UseBackColor = false;
            this.lblReportName.StylePriority.UseBorders = false;
            this.lblReportName.StylePriority.UseFont = false;
            this.lblReportName.StylePriority.UseTextAlignment = false;
            this.lblReportName.Text = "lblReportName";
            this.lblReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lblReportName.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lblReportName_BeforePrint);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.Id = 0;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0.0001430511F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(761.9999F, 72.9166F);
            // 
            // RptTemplateWithHeader
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.PageHeader});
            this.Margins = new System.Drawing.Printing.Margins(40, 25, 25, 25);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.TblLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable TblLicense;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell lblLicenseName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell lblLicenseAddress;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell lblLicenseContacts;
        private DevExpress.XtraReports.UI.XRPictureBox PicLicenseLogo;
        private DevExpress.XtraReports.UI.XRTable TblVendor;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell LblApplicationName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow44;
        private DevExpress.XtraReports.UI.XRTableCell LblVendorName;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPageInfo LblPrintDate;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRLabel lblReportName;
    }
}
