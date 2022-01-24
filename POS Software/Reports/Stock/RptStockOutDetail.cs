using System;
using System.Data;

namespace POS_Software.Reports.Stock
{
    public partial class RptStockOutDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public RptStockOutDetail()
        {
            InitializeComponent();
        }

        private void PicLicenseLogo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var dt = new DataTable();
            dt = DalHandlar.RunQuery("Select Logo_Image from Admin.Store_Deffination");
            try
            {
                PicLicenseLogo.Image = Soothmedia.General.Images.ReadImage((Byte[])(dt.Rows[0]["Logo_Image"]));
            }
            catch
            {
            }
        }

        private void TblLicense_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblLicenseName.Text = Modules.Main.LicenseName;
            lblLicenseAddress.Text = Modules.Main.LicenceAddress;
            lblLicenseContacts.Text = Modules.Main.LicenceContact;
        }

        private void lblReportName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblReportName.Text = DisplayName;
        }

        private void LblPrintDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblReportName.Text = DisplayName;
        }

        private void TblVendor_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblApplicationName.Text = Modules.Main.ApplicationName;
            LblVendorName.Text = Modules.Main.VendorName;
        }

        private int x = 0;
        private void xrTableCell39_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            x = x + 1;
            xrTableCell39.Text = x.ToString();
        }

        private void TblHdrCelNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            TblHdrCelNo.Text = "No";
            TblHdrCelBarcode.Text = "Barcode";
            TblHdrCelName.Text = "Name";
            TblHdrCelSize.Text = "Size";
            TblHdrCelTotalStock.Text = "Stock Out";
            TblHdrCelLastUpdated.Text = "Date";
        }

        private double totalstock = 0;
        private void xrTableCell45_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            totalstock = totalstock + Convert.ToDouble(xrTableCell45.Text);
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel2.Text = totalstock.ToString();
        }

        private void lblTotalStock_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblTotalStock.Text = "Total Stock";
        }
    }
}
