using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace POS_Software.Reports.Report_Template
{
    public partial class RptWHLandscapeTemplate : DevExpress.XtraReports.UI.XtraReport
    {
        public RptWHLandscapeTemplate()
        {
            InitializeComponent();
        }

        public RptWHLandscapeTemplate(XtraReport xr, DataTable dt)
        {
            InitializeComponent();
            Tag = xr.Tag;
            DisplayName = xr.DisplayName;
            Soothmedia.Reports.WinForm.ShowXtraSubReport(xr, dt, Modules.Main.DateFormat);
            xrSubreport1.ReportSource = xr;
        }

        private void PicLicenseLogo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var dt = new DataTable();
            dt = DalHandlar.RunQuery("Select CompanyLogo from General.Company");
            try
            {
                PicLicenseLogo.Image = Soothmedia.General.Images.ReadImage((Byte[])(dt.Rows[0]["CompanyLogo"]));
            }
            catch (Exception)
            {
            }
        }

        private void TblLicense_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void TblVendor_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblApplicationName.Text = Modules.Main.ApplicationName;
            LblVendorName.Text = Modules.Main.VendorName;
        }

        private void xrTable13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var dt = DalHandlar.RunQuery("select DocumentCode,Revision from Application.Document where DocumentID =1 ");
            if (dt != null)
            {
                tblcelfootercode.Text = dt.Rows[0]["DocumentCode"].ToString();
                TblCelFtrRevision.Text = dt.Rows[0]["Revision"].ToString();
            }
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblReportName.Text = DisplayName;
        }
    }
}
