using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace POS_Software.Reports.Sales
{
    public partial class RptInvoiceDetails : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoiceDetails()
        {
            InitializeComponent();
        }

        private void TblHdrCelInvoiceNumber_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            TblHdrCelInvoiceNumber.Text = "Invoice Number";
            TblHdrCelCustomerType.Text = "Customer Type";
            TblHdrCelIsReturn.Text = "Is Return";
            TblHdrCelInvoiceDate.Text = "Invoice Date";
            TblHdrCelCreationDate.Text = "INV. Created Date";
            TblHdrCelUser.Text = "User";
            TblHdrCelNo.Text = "No";
            TblHdrCelItemBarcode.Text = "Barcode";
            TblHdrCelItem_Name.Text = "Name";
            TblHdrCelUnitPrice.Text = "Unit Price";
            TblHdrCelQty.Text = "Quantity";
            TblHdrCelAmount.Text = "Amount";
        }
        private int x = 0;

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var groupField = new GroupField("Code");
            GroupHeader1.GroupFields.Add(groupField);
            x = 0;
        }

        private void xrTableCell39_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            x = x + 1;
            xrTableCell39.Text = x.ToString();
        }

        private void xrlblRecievedAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlblBalance.Text = Convert.ToString(Convert.ToDouble(xrlblRecievedAmount.Text) - Convert.ToDouble(xrlblGrandTotal.Text));
        }

        private void TblHdrCelGrandTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            TblHdrCelGrandTotal.Text = "Grand Total";
            TblHdrCelRecivedAmount.Text = "Received Amount";
            TblHdrCelBalance.Text = "Balance";
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

        private void TblVendor_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblApplicationName.Text = Modules.Main.ApplicationName;
            LblVendorName.Text = Modules.Main.VendorName;
        }

        private void LblPrintDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblPrintDate.Format = string.Format("Print Date:{0}", Modules.Main.DateFormat2);
        }

        private void lblReportName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblReportName.Text = DisplayName;
        }
    }
}
