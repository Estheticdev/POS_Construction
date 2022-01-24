namespace POS_Software.Reports.Report_Template
{
    partial class RptWHLandscapeTemplate
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
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PicLicenseLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.TblLicense = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblLicenseName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblLicenseAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lblLicenseContacts = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblReportName = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.LblPrintDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tblcelfootercode = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TblCelFtrRevision = new DevExpress.XtraReports.UI.XRTableCell();
            this.TblVendor = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.LblApplicationName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.LblVendorName = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.TblLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1});
            this.Detail.HeightF = 458.3334F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.Id = 0;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(1104F, 458.3334F);
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
            this.BottomMargin.HeightF = 27.04169F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PicLicenseLogo
            // 
            this.PicLicenseLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.PicLicenseLogo.Name = "PicLicenseLogo";
            this.PicLicenseLogo.SizeF = new System.Drawing.SizeF(149.3515F, 93.27084F);
            this.PicLicenseLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.PicLicenseLogo.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PicLicenseLogo_BeforePrint);
            // 
            // TblLicense
            // 
            this.TblLicense.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblLicense.LocationFloat = new DevExpress.Utils.PointFloat(534.8334F, 0F);
            this.TblLicense.Name = "TblLicense";
            this.TblLicense.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5});
            this.TblLicense.SizeF = new System.Drawing.SizeF(569.1666F, 70.27083F);
            this.TblLicense.StylePriority.UseFont = false;
            this.TblLicense.StylePriority.UseTextAlignment = false;
            this.TblLicense.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TblLicense.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TblLicense_BeforePrint);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblLicenseName});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // lblLicenseName
            // 
            this.lblLicenseName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblLicenseName.Name = "lblLicenseName";
            this.lblLicenseName.StylePriority.UseFont = false;
            this.lblLicenseName.Weight = 3D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblLicenseAddress});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // lblLicenseAddress
            // 
            this.lblLicenseAddress.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblLicenseAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLicenseAddress.Name = "lblLicenseAddress";
            this.lblLicenseAddress.StylePriority.UseBorders = false;
            this.lblLicenseAddress.StylePriority.UseFont = false;
            this.lblLicenseAddress.Weight = 3D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lblLicenseContacts});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // lblLicenseContacts
            // 
            this.lblLicenseContacts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLicenseContacts.Name = "lblLicenseContacts";
            this.lblLicenseContacts.StylePriority.UseFont = false;
            this.lblLicenseContacts.Weight = 3D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblReportName,
            this.PicLicenseLogo,
            this.TblLicense});
            this.PageHeader.HeightF = 93.27084F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
            // 
            // lblReportName
            // 
            this.lblReportName.BackColor = System.Drawing.Color.Transparent;
            this.lblReportName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblReportName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 70.27083F);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblReportName.SizeF = new System.Drawing.SizeF(1104F, 23.00001F);
            this.lblReportName.StylePriority.UseBackColor = false;
            this.lblReportName.StylePriority.UseBorders = false;
            this.lblReportName.StylePriority.UseFont = false;
            this.lblReportName.StylePriority.UseTextAlignment = false;
            this.lblReportName.Text = "lblReportName";
            this.lblReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.LblPrintDate,
            this.xrTable13,
            this.TblVendor});
            this.PageFooter.HeightF = 24F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPageInfo2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.Format = "Page {0} / {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(74.26823F, 12F);
            this.xrPageInfo2.StylePriority.UseBorders = false;
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // LblPrintDate
            // 
            this.LblPrintDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrintDate.Format = "Print Date: {0:dd-MMM-yyy}";
            this.LblPrintDate.LocationFloat = new DevExpress.Utils.PointFloat(74.99997F, 0F);
            this.LblPrintDate.Name = "LblPrintDate";
            this.LblPrintDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.LblPrintDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.LblPrintDate.SizeF = new System.Drawing.SizeF(125.1348F, 12F);
            this.LblPrintDate.StylePriority.UseFont = false;
            this.LblPrintDate.StylePriority.UseTextAlignment = false;
            this.LblPrintDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable13
            // 
            this.xrTable13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable13.Font = new System.Drawing.Font("Calibri", 7F);
            this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 12F);
            this.xrTable13.Name = "xrTable13";
            this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow19});
            this.xrTable13.SizeF = new System.Drawing.SizeF(200.1348F, 12F);
            this.xrTable13.StylePriority.UseBorders = false;
            this.xrTable13.StylePriority.UseFont = false;
            this.xrTable13.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTable13_BeforePrint);
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell85,
            this.tblcelfootercode,
            this.xrTableCell88,
            this.TblCelFtrRevision});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 1D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrTableCell85.CanGrow = false;
            this.xrTableCell85.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableCell85.StylePriority.UseBorders = false;
            this.xrTableCell85.StylePriority.UseFont = false;
            this.xrTableCell85.StylePriority.UsePadding = false;
            this.xrTableCell85.StylePriority.UseTextAlignment = false;
            this.xrTableCell85.Text = "Documents No:";
            this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell85.Weight = 1.1301241439767198D;
            // 
            // tblcelfootercode
            // 
            this.tblcelfootercode.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.tblcelfootercode.CanGrow = false;
            this.tblcelfootercode.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblcelfootercode.Name = "tblcelfootercode";
            this.tblcelfootercode.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.tblcelfootercode.StylePriority.UseBorders = false;
            this.tblcelfootercode.StylePriority.UseFont = false;
            this.tblcelfootercode.StylePriority.UsePadding = false;
            this.tblcelfootercode.StylePriority.UseTextAlignment = false;
            this.tblcelfootercode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tblcelfootercode.Weight = 0.8849107290278686D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrTableCell88.CanGrow = false;
            this.xrTableCell88.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableCell88.StylePriority.UseBorders = false;
            this.xrTableCell88.StylePriority.UseFont = false;
            this.xrTableCell88.StylePriority.UsePadding = false;
            this.xrTableCell88.StylePriority.UseTextAlignment = false;
            this.xrTableCell88.Text = "Rev:";
            this.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell88.Weight = 0.43764948509736668D;
            // 
            // TblCelFtrRevision
            // 
            this.TblCelFtrRevision.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.TblCelFtrRevision.CanGrow = false;
            this.TblCelFtrRevision.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblCelFtrRevision.Name = "TblCelFtrRevision";
            this.TblCelFtrRevision.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.TblCelFtrRevision.StylePriority.UseBorders = false;
            this.TblCelFtrRevision.StylePriority.UseFont = false;
            this.TblCelFtrRevision.StylePriority.UsePadding = false;
            this.TblCelFtrRevision.StylePriority.UseTextAlignment = false;
            this.TblCelFtrRevision.Text = "TblCelFtrRevision";
            this.TblCelFtrRevision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.TblCelFtrRevision.Weight = 0.56301169444262678D;
            // 
            // TblVendor
            // 
            this.TblVendor.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblVendor.LocationFloat = new DevExpress.Utils.PointFloat(568.8336F, 5.805559F);
            this.TblVendor.Name = "TblVendor";
            this.TblVendor.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow8});
            this.TblVendor.SizeF = new System.Drawing.SizeF(535.1664F, 18.19444F);
            this.TblVendor.StylePriority.UseFont = false;
            this.TblVendor.StylePriority.UseTextAlignment = false;
            this.TblVendor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.TblVendor.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TblVendor_BeforePrint);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.LblApplicationName});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // LblApplicationName
            // 
            this.LblApplicationName.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplicationName.Name = "LblApplicationName";
            this.LblApplicationName.StylePriority.UseFont = false;
            this.LblApplicationName.Text = "fads";
            this.LblApplicationName.Weight = 3.0571247532927042D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.LblVendorName});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // LblVendorName
            // 
            this.LblVendorName.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendorName.Name = "LblVendorName";
            this.LblVendorName.StylePriority.UseFont = false;
            this.LblVendorName.Text = "dsfasd";
            this.LblVendorName.Weight = 3.0571247532927042D;
            // 
            // RptWHLandscapeTemplate
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(40, 25, 25, 27);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.TblLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox PicLicenseLogo;
        private DevExpress.XtraReports.UI.XRTable TblLicense;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell lblLicenseName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell lblLicenseAddress;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell lblLicenseContacts;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRPageInfo LblPrintDate;
        private DevExpress.XtraReports.UI.XRTable xrTable13;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell85;
        private DevExpress.XtraReports.UI.XRTableCell tblcelfootercode;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell88;
        private DevExpress.XtraReports.UI.XRTableCell TblCelFtrRevision;
        private DevExpress.XtraReports.UI.XRTable TblVendor;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell LblApplicationName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell LblVendorName;
        private DevExpress.XtraReports.UI.XRLabel lblReportName;
    }
}
