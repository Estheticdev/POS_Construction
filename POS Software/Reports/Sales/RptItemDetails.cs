using System;
using System.Data;

namespace POS_Software.Reports.Sales
{
    public partial class RptItemDetails : DevExpress.XtraReports.UI.XtraReport
    {
        public RptItemDetails()
        {
            InitializeComponent();
        }

        private void TblHdrCelNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            TblHdrCelNo.Text = "No";
            TblHdrCelBarcode.Text = "Barcode";
            TblHdrCelName.Text = "Name";
            TblHdrCelType.Text = "Type";
            TblHdrCelSubType.Text = "Sub Type";
            TblHdrCelSize.Text = "Size";
            TblHdrCelUnit.Text = "Unit";
            TblHdrCelSalePrice.Text = "Sale Price";
            TblHdrCelPurPrice.Text = "Pur. Price";
            TblHdrCelStock.Text = "Stock";
        }
        private int x = 0;
        private void xrTableCell39_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            x = x + 1;
            xrTableCell39.Text = x.ToString();
        }

        private void lblReportName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblReportName.Text = DisplayName;
        }

        private void TblLicense_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblLicenseName.Text = Modules.Main.LicenseName;
            lblLicenseAddress.Text = Modules.Main.LicenceAddress;
            lblLicenseContacts.Text = Modules.Main.LicenceContact;
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

        private void LblPrintDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblPrintDate.Format = string.Format("Print Date:{0}", Modules.Main.DateFormat2);
        }

        private void TblVendor_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblApplicationName.Text = Modules.Main.ApplicationName;
            LblVendorName.Text = Modules.Main.VendorName;
        }
    }
}
