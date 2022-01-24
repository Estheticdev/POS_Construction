using System;
using System.Data;

namespace POS_Software.Reports.Sales
{
    public partial class RptPurchaseDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public RptPurchaseDetail()
        {
            InitializeComponent();
        }

        private void TblHdrCelNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            TblHdrCelNo.Text = "رقم";
            TblHdrCelInvoiceNumber.Text = "رقم الفاتوره";
            TblHdrCelCustomerType.Text = "اسم مندوب";
            TblHdrCelGrandTotal.Text = "المبلغ الإجمالي";
            TblHdrCelRecievedAmount.Text = "المبلغ الذي تسلمه";
            TblHdrCelInvoiceDate.Text = "تاريخ الفاتوره";
            TblHdrCelCreationDate.Text = "تاريخ إنشاء الفاتورة";
            TblHdrCelUser.Text = "المستعمل";
            TblHdrCelIsReturn.Text = "إرجاع";
        }
        private int x = 0;

        private void xrTableCell39_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            x = x + 1;
            xrTableCell39.Text = x.ToString();
        }

        private void lblReportName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblReportName.Text = "تفاصيل فاتورة الشراء";
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
    }
}
