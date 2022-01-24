using System;

namespace POS_Software.Reports.Barcode
{
    public partial class RptBarcodeTags : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBarcodeTags()
        {
            InitializeComponent();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
