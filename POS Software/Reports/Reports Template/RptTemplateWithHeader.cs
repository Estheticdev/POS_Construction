using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace POS_Software.Reports.Report_Template
{
    public partial class RptTemplateWithHeader : DevExpress.XtraReports.UI.XtraReport
    {
        public RptTemplateWithHeader()
        {
            InitializeComponent();
        }

        public RptTemplateWithHeader(XtraReport xr, DataTable dt)
        {
            InitializeComponent();
            Tag = xr.Tag;
            DisplayName = xr.DisplayName;
            Soothmedia.Reports.WinForm.ShowXtraSubReport(xr, dt, Modules.Main.DateFormat);
            xrSubreport1.ReportSource = xr;
            lblReportName.Text = DisplayName;
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

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
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
