using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace POS_Software.Reports.Report_Template
{
    public partial class RptWOHLandscapeTemplate : DevExpress.XtraReports.UI.XtraReport
    {
        public RptWOHLandscapeTemplate()
        {
            InitializeComponent();
        }
        public RptWOHLandscapeTemplate(XtraReport xr, DataTable dt)
        {
            InitializeComponent();
            Tag = xr.Tag;
            DisplayName = xr.DisplayName;
            Soothmedia.Reports.WinForm.ShowXtraSubReport(xr, dt, Modules.Main.DateFormat);
            xrSubreport1.ReportSource = xr;
            lblReportName.Text = DisplayName;
        }
    }
}
