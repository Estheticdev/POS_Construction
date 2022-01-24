using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace POS_Software.Reports.Purchase
{
    public partial class frmPSVAT : DevExpress.XtraEditors.XtraForm
    {
        public frmPSVAT()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string reportQuery = @"SELECT SUM(PurchaseShopAmount) AS 'PurchaseShopAmount', SUM (PurchaseTotalTaxAmount) AS 'PurchaseTotalTaxAmount',
SUM(SaleShopAmount) AS 'SaleShopAmount', SUM(SaleTotalTaxAmount) AS 'SaleTotalTaxAmount' ,(SUM (SaleTotalTaxAmount) - SUM(PurchaseTotalTaxAmount)) as VATdfiference FROM (
Select ISNULL(SUM(CAST(ShopAmount AS decimal(18,2))),0.00) as 'PurchaseShopAmount', 
                                   ISNULL(SUM(CAST(TaxAmount AS decimal(18,2))), 0.00) AS 'PurchaseTotalTaxAmount',
                                   0 AS 'SaleShopAmount', 0 AS 'SaleTotalTaxAmount'
                                   FROM Purchase.Purchase_Invoice
                                   WHERE MONTH(CAST(Created_Date as datetime)) BETWEEN MONTH('" + dtpFrom.Value + "') AND MONTH('" + dtpTo.Value + "') UNION Select 0 AS 'PurchaseShopAmount', 0 AS 'PurchaseTotalTaxAmount', ISNULL(SUM(CAST(ShopAmount AS decimal(18,2))), 0.00) as 'SaleShopAmount', ISNULL(SUM(CAST(TaxAmount AS decimal(18,2))), 0.00) AS 'SaleTotalTaxAmount' FROM Sales.Sales_Invoice WHERE MONTH(CAST(Created_Date as datetime)) BETWEEN MONTH('" + dtpFrom.Value + "') AND MONTH('" + dtpTo.Value + "')) AS MainTable";
            DataTable dt = new DataTable();

            dt = DalHandlar.RunQuery(reportQuery);
            dt.Columns.Add("FROMTO", typeof(string));
            //dt.Columns["FROMTO"].Expression = dtpFrom.Value.ToString("MMM") + "-" + dtpTo.Value.ToString("MMM");

            dt.Rows[0]["FROMTO"] = dtpFrom.Value.ToString("MMM") + "-" + dtpTo.Value.ToString("MMM");
            //dt.Rows.Add(dtpFrom.Value.ToString("MMM") + "-" + dtpTo.Value.ToString("MMM"));

            //dt.Rows.Add("FROMTO", dtpFrom.Value.ToString("MMM") + "-" + dtpTo.Value.ToString("MMM"));
            var Rpt = new Reports.Purchase.rptVATReport();
            Rpt.DataSource = dt;
            (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay(Rpt, dt);
            //DevExpress.XtraEditors.XtraForm mdi = new DevExpress.XtraEditors.XtraForm();
            //Soothmedia.Reports.WinForm.ShowXtraReport(mdi, Rpt, dt, Modules.Main.DateFormat, true);
        }
    }
}