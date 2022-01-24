using System;
using DevExpress.XtraReports.UI;
using System.Data;

namespace POS_Software.Reports.Report_Template
{
    public partial class RptTemplateWithOutHeader : DevExpress.XtraReports.UI.XtraReport
    {
        public RptTemplateWithOutHeader()
        {
            InitializeComponent();
        }

        public RptTemplateWithOutHeader(XtraReport xr, DataTable dt)
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
