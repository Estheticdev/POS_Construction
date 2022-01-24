namespace POS_Software.Reports.Barcode
{
    partial class RptBarcodeTags
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
            DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator code39ExtendedGenerator1 = new DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TxtCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TxtCompanyName,
            this.xrLabel4,
            this.xrBarCode2});
            this.Detail.HeightF = 105.4586F;
            this.Detail.MultiColumn.ColumnCount = 5;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UsePadding = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(14F, 95.13223F);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TxtCompanyName.SizeF = new System.Drawing.SizeF(136.8703F, 10.32639F);
            this.TxtCompanyName.StylePriority.UseFont = false;
            this.TxtCompanyName.StylePriority.UseTextAlignment = false;
            this.TxtCompanyName.Text = "Departmental Store";
            this.TxtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.CanShrink = true;
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(14F, 77.13221F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(136.8703F, 18F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Tag = "Item_Name";
            this.xrLabel4.Text = "Clear PVC / Heat Seal Trim/ Snap /Printed / sticker ";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode2
            // 
            this.xrBarCode2.AutoModule = true;
            this.xrBarCode2.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrBarCode2.LocationFloat = new DevExpress.Utils.PointFloat(14F, 0F);
            this.xrBarCode2.Name = "xrBarCode2";
            this.xrBarCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.xrBarCode2.SizeF = new System.Drawing.SizeF(136.8703F, 77.13221F);
            this.xrBarCode2.StylePriority.UseFont = false;
            this.xrBarCode2.StylePriority.UsePadding = false;
            this.xrBarCode2.StylePriority.UseTextAlignment = false;
            code39ExtendedGenerator1.WideNarrowRatio = 3F;
            this.xrBarCode2.Symbology = code39ExtendedGenerator1;
            this.xrBarCode2.Tag = "Item_Barcode";
            this.xrBarCode2.Text = "3323r";
            this.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 2.874724F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 23.95833F;
            this.PageHeader.Name = "PageHeader";
            // 
            // RptBarcodeTags
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 3);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel TxtCompanyName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode2;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    }
}
