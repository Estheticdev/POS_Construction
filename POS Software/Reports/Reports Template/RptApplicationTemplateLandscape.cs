using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace POS_Software.Reports.Report_Template
{
    public partial class RptApplicationTemplateLandscape : DevExpress.XtraReports.UI.XtraReport
    {
        public RptApplicationTemplateLandscape()
        {
            InitializeComponent();
        }
        public RptApplicationTemplateLandscape(XtraReport xr, DataTable dt)
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

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var reportName = DisplayName;
            lblReportName.Text = DisplayName;
            var dt = DalHandlar.RunQuery("Select ReportName,OrignalDate,RevisionNo,RevisionDate,Division,DocumentNo,Department,Section from Application.Reports where ReportName = '" + reportName + "'");
            if (dt != null)
            {
                if (Convert.ToString(dt.Rows[0]["Section"]) != string.Empty)
                {
                    xrtblCellSection.Text = Convert.ToString(dt.Rows[0]["Section"]);
                }
                if (Convert.ToString(dt.Rows[0]["Department"]) != string.Empty)
                {
                    xrtblCellDepartment.Text = Convert.ToString(dt.Rows[0]["Department"]);
                }
                if (Convert.ToString(dt.Rows[0]["RevisionDate"]) != string.Empty)
                {
                    xrtblCellRevDate.Text = Convert.ToDateTime(dt.Rows[0]["RevisionDate"]).ToString(Modules.Main.DateFormat1);
                }
                if (Convert.ToString(dt.Rows[0]["RevisionNo"]) != string.Empty)
                {
                    xrtblCellRevNo.Text = Convert.ToString(dt.Rows[0]["RevisionNo"]);
                }
                if (Convert.ToString(dt.Rows[0]["DocumentNo"]) != string.Empty)
                {
                    xrtblCellDocumentNo.Text = Convert.ToString(dt.Rows[0]["DocumentNo"]);
                }
                if (Convert.ToString(dt.Rows[0]["Division"]) != string.Empty)
                {
                    xrtblCellDivision.Text = Convert.ToString(dt.Rows[0]["Division"]);
                }
                if (Convert.ToString(dt.Rows[0]["OrignalDate"]) != string.Empty)
                {
                    xrtblCellOriginalIssue.Text = Convert.ToDateTime(dt.Rows[0]["OrignalDate"]).ToString(Modules.Main.DateFormat1);
                }
            }
        }

        private void LblPrintDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblPrintDate.Format = string.Format("Print Date:{0}", Modules.Main.DateFormat2);
        }
    }
}
