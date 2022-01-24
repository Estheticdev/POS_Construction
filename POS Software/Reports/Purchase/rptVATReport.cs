using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace POS_Software.Reports.Purchase
{
    public partial class rptVATReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rptVATReport()
        {
            InitializeComponent();
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

        private void lblReportName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblReportName.Text = "تقرير ضريبة القيمة المضافة";
        }

        private void TblVendor_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblApplicationName.Text = Modules.Main.ApplicationName;
            LblVendorName.Text = Modules.Main.VendorName;
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           xrFromTo.Text = "من الى";
            xrTotalSale.Text = "للبيع";
            xrTotalSaleVAT.Text = "إجمالي ضريبة القيمة المضافة للبيع";
            xrTotalPurchase.Text = "للشراء";
            xrTotalPurchaseVAT.Text = "إجمالي ضريبة الشراء";
            xrTableCell8.Text = "إجمالي ضريبة الشراء";
        }
    }
}
