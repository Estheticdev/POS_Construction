using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace POS_Software.Reports
{
    public static class Report
    {
        public static void ReportTemplatePotrait(XtraReport Rpt, XtraReport Rpt2, DataTable dt, string Sort, DevExpress.XtraEditors.XtraForm MDIForm)
        {
            var rpt = new List<XtraReport>();

            var rwh = new Report_Template.RptTemplateWithHeader(Rpt, dt);
            rpt.Add(rwh);
            rpt.TrimExcess();
            Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, rwh, dt, Modules.Main.DateFormat, true);
        }

        public static void ItemDetail(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            var Query = @"SELECT        ID.Item_ID AS No,ID.Item_Barcode AS Code, Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END AS Name, ID.Item_Sale_Price,ID.Item_Purchase_Price, IT.Types_Name, cat.Category_Name, U.Unit_Name, Its.Size_Name, S.Total_Stock,ID.Created_Date,ID.Active
                           FROM            Admin.Items_Deffination AS ID WITH (NOLOCK) LEFT OUTER JOIN
                           Admin.Category AS cat ON ID.Item_Category_ID = cat.Category_ID LEFT OUTER JOIN
                           Admin.Items_Types AS IT ON ID.Item_Type_ID = IT.Items_Types_ID LEFT OUTER JOIN
                           Admin.Sizes AS Its ON ID.Item_Size_ID = Its.Size_ID LEFT OUTER JOIN
                           Admin.Units AS U ON ID.Item_Unit_ID = U.Unit_ID LEFT OUTER JOIN
                           Stock.Stock AS S ON ID.Item_ID = S.Item_ID";
                       var dtGetITems = new DataTable();
            dtGetITems = Soothmedia.Reports.WinForm.XtraReportQuery("Item Detail Report", DalHandlar.cn, "Admin.VwItemSearch", Query, "'No','Name','Code'", "ID.Item_ID", "DATEADD(D, 0, DATEDIFF(D, 0, ID.Created_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, ID.Created_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, ID.Created_Date))", new [] { "Name" }, new [] { "Name" });

             if (dtGetITems != null)
            {
                if (dtGetITems.Rows.Count > 0)
                {
                    var Rpt = new Reports.Sales.RptItemDetails();
                    Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, Rpt, dtGetITems, Modules.Main.DateFormat, true);
                }
            }
            else
            {
                MessageBox.Show(Modules.Main.MsgSearchError);
            }
        }

        public static void SalesDetail(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            var Query = @"select Sale_ID as No,Invoice_No as Code, case when Customer_Type=1 then 'Walk Through' else 'Regular' end as Name, Grand_Total,Recievd_Amount,Invoice_Date,Created_By,Created_Date,Case When IsReturn=1 then 'Yes' else 'No' end as IsReturn from Sales.Sales_Invoice where Active=1";
            var dtGetITems = new DataTable();
            dtGetITems = Soothmedia.Reports.WinForm.XtraReportQuery("Item Detail Report", DalHandlar.cn, "Sales.VwSalesINVsearch", Query, "'No','Name','Code'", "Invoice_No", "DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date))", new [] { "Name" }, new [] { "Name" });

            if (dtGetITems != null)
            {
                if (dtGetITems.Rows.Count > 0)
                {
                    var Rpt = new Reports.Sales.RptSaleDetail();
                    Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, Rpt, dtGetITems, Modules.Main.DateFormat, true);
                }
            }
            else
            {
                MessageBox.Show(Modules.Main.MsgSearchError);
            }
        }
        public static void purhasereport(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            var Query = @"select Purchase_ID as No,Invoice_No as Code,PI.Vendor_ID,VD.Vendor_Name, Grand_Total,Recievd_Amount,Invoice_Date,Created_By,Created_Date,Case When IsReturn=1 then 'Yes' else 'No' end as IsReturn from Purchase.Purchase_Invoice as PI left join Admin.Vendor_Definition as VD on PI.Vendor_ID=VD.Vendor_ID where PI.Active=1";
            var dtGetITems = new DataTable();
            dtGetITems = Soothmedia.Reports.WinForm.XtraReportQuery("Item Detail Report", DalHandlar.cn, "dbo.VwPurchaseINSearch", Query, "'No','Code'", "Invoice_No", "DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date))", new[] { "Name" }, new[] { "Name" });

            if (dtGetITems != null)
            {
                if (dtGetITems.Rows.Count > 0)
                {
                    var Rpt = new Reports.Sales.RptPurchaseDetail();
                    Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, Rpt, dtGetITems, Modules.Main.DateFormat, true);
                }
            }
            else
            {
                MessageBox.Show(Modules.Main.MsgSearchError);
            }
        }
        public static void InvoiceDetail(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            //var Query = @"select SI.Sale_ID as No,SI.Invoice_No as Code, 
            //               case when SI.Customer_Type=1 then 'Walk Through' else 'Regular' end as Name, 
            //               SI.Grand_Total,SI.Recievd_Amount,SI.Invoice_Date,SI.Created_By,SI.Created_Date,
            //               Case When IsReturn=1 then 'Yes' else 'No' end as IsReturn,
            //               SD.Sales_Detail_ID,SD.Sale_ID,SD.Item_ID,SD.Item_Barcode,
            //               Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as Item_Name,
            //               SD.Qty,SD.Unit_Price,SD.Amount 
            //               from Sales.Sales_Invoice AS SI
            //               left Join Sales.Sales_Invoice_Detail as SD on SI.Sale_ID =SD.Sale_ID
            //               Left Join Admin.Items_Deffination as ID on SD.Item_ID=ID.Item_ID
            //               Left Join Admin.Sizes as Its on ID.Item_Size_ID=its.Size_ID 
            //               where SI.Active=1";

            var Query = @"select SI.Sale_ID as No,SI.Invoice_No as Code,SI.Grand_Total as discountamount,SI.Discount as discount,(cast (SI.Grand_Total as float) + cast(SI.Discount as float)) as GrandTotal ,SI.Recievd_Amount as RecievedCash,SI.TaxPercentage,SI.TaxAmount as TaxAmount,SI.ShopAmount as ShopAmount,
(CAST (SI.ShopAmount as float) - cast( SI.Recievd_Amount as float)) as Balance,SI.Invoice_No as InvoiceNumber, SI.Invoice_Date as Date,SI.Created_By as Created_By,
case when SI.Customer_Type=1 then 'Walking Customer' else CD.Customer_Name end as Customer,CD.TaxNumber as TaxNumber,cd.Contact_Number as Contact_Number, 
SD.Item_Barcode,ID.Item_Name,SD.Unit_Price as Item_Sale_Price, ID.Item_Sale_Price as unit_Price,SD.Qty,SD.Amount,SI.Created_Date,
Case When IsReturn=1 then 'Yes' else 'No' end as IsReturn,SD.Custom_Size,SD.Percentage,SD.Percentage_Amount,
SD.Sales_Detail_ID,SD.Sale_ID,SD.Item_ID,SD.Item_Barcode,
Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as Item_Name,SI.gurrentee as guarantee,
SD.Qty,SD.Unit_Price,SD.Amount,SI.PaymentType_ID as paymenttype 
from Sales.Sales_Invoice AS SI
left Join Sales.Sales_Invoice_Detail as SD on SI.Sale_ID =SD.Sale_ID
Left Join Admin.Items_Deffination as ID on SD.Item_ID=ID.Item_ID
Left Join Admin.Sizes as Its on ID.Item_Size_ID=its.Size_ID 
left join admin.Customer_Deffination as CD on SI.Customer_ID=CD.Customer_ID
where SI.Active=1";
            var dtGetITems = new DataTable();
            dtGetITems = Soothmedia.Reports.WinForm.XtraReportQuery("Invoice Detail Report", DalHandlar.cn, "Sales.VwSalesINVsearch", Query, "'No','Name','Code'", "SI.Invoice_No", "DATEADD(D, 0, DATEDIFF(D,0,  SI.Invoice_Date))", "DATEADD(D, 0, DATEDIFF(D,0,  SI.Invoice_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, SI.Invoice_Date))", new[] { "Name" }, new[] { "Name" });
            if (dtGetITems != null )
            {
                if (dtGetITems.Rows.Count > 0)
                {
                    if ((bool)Modules.General.dtsetting.Rows[0]["Setting_Value"] == true)
                    {
                        if (System.Windows.Forms.Application.OpenForms[2] != null)
                        {
                            var report = new Reports.Sales.RptSalesInvoice_A4Direct(dtGetITems);

                            (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay(report, dtGetITems);

                        }
                    }
                    else
                    {
                        if (System.Windows.Forms.Application.OpenForms[2] != null)
                        {

                            var report = new Reports.Sales.RptSalesInvoice();

                            (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay(report, dtGetITems);

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Record not exist");
            }
            //if (dtGetITems != null)
            //{
            //    if (dtGetITems.Rows.Count > 0)
            //    {
            //        var Rpt = new Reports.Sales.RptInvoiceDetails();
            //        //var Rpt = new Reports.Sales.RptSalesInvoice_A4();
            //        Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, Rpt, dtGetITems, Modules.Main.DateFormat, true);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(Modules.Main.MsgSearchError);
            //}
        }
        public static void StockDetail(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            var Query = @"select S.Item_ID as No,S.Item_Barcode as Code,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as Name ,S.Stock_ID,U.Unit_Name,its.Size_Name,S.Total_Stock,S.Last_Updated,S.Modify_By,S.Created_Date
                           from [Stock].[Stock] as S 
                           Left Join Admin.Items_Deffination as ID on S.Item_ID=ID.Item_ID
                           Left Join Admin.Sizes as its on ID.Item_Size_ID=its.Size_ID
                           Left Join Admin.Units as U on ID.Item_Unit_ID=U.Unit_ID where ID.Active=1";
            
            var dtGetITems = new DataTable();
            dtGetITems = Soothmedia.Reports.WinForm.XtraReportQuery("Stock Details Report", DalHandlar.cn, "Admin.VwItemSearch", Query, "'No','Name'", "S.Item_ID", "DATEADD(D, 0, DATEDIFF(D, 0, S.Last_Updated))", "DATEADD(D, 0, DATEDIFF(D, 0, S.Last_Updated))", "DATEADD(D, 0, DATEDIFF(D, 0, S.Last_Updated))", new [] { "Name" }, new [] { "Name" });

            if (dtGetITems != null)
            {
                if (dtGetITems.Rows.Count > 0)
                {
                    var Rpt = new Reports.Stock.RptStockDetail();
                    Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, Rpt, dtGetITems, Modules.Main.DateFormat, true);
                }
            }
            else
            {
                MessageBox.Show(Modules.Main.MsgSearchError);
            }
        }

        public static void StockInDetail(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            var Query = @"select S.Item_ID as No,S.Item_Barcode as Code,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as Name ,S.Stock_ID,U.Unit_Name,its.Size_Name,S.Stock_In,S.Remarks,S.Transaction_Date,S.Transaction_By
                           from [Stock].Stock_Detail as S 
                           Left Join Admin.Items_Deffination as ID on S.Item_ID=ID.Item_ID
                           Left Join Admin.Sizes as its on ID.Item_Size_ID=its.Size_ID
                           Left Join Admin.Units as U on ID.Item_Unit_ID=U.Unit_ID where ID.Active=1 and S.Stock_In!=0";

            var dtGetITems = new DataTable();
            dtGetITems = Soothmedia.Reports.WinForm.XtraReportQuery("Stock Details Report", DalHandlar.cn, "Admin.VwItemSearch", Query, "'No','Name','Code'", "S.Item_ID", "DATEADD(D, 0, DATEDIFF(D, 0, S.Transaction_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, S.Transaction_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, S.Transaction_Date))", new [] { "Name" }, new [] { "Name" });

            if (dtGetITems != null)
            {
                if (dtGetITems.Rows.Count > 0)
                {
                    var Rpt = new Reports.Stock.RptStockInDetail();
                    Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, Rpt, dtGetITems, Modules.Main.DateFormat, true);
                }
            }
            else
            {
                MessageBox.Show(Modules.Main.MsgSearchError);
            }
        }

        public static void StockOutDetail(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            var Query = @"select S.Item_ID as No,S.Item_Barcode as Code,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as Name ,S.Stock_ID,U.Unit_Name,its.Size_Name,S.Stock_Out,S.Transaction_Date,S.Transaction_By
                           from [Stock].Stock_Detail as S 
                           Left Join Admin.Items_Deffination as ID on S.Item_ID=ID.Item_ID
                           Left Join Admin.Sizes as its on ID.Item_Size_ID=its.Size_ID
                           Left Join Admin.Units as U on ID.Item_Unit_ID=U.Unit_ID where ID.Active=1 and S.Stock_Out!=0";

            var dtGetITems = new DataTable();
            dtGetITems = Soothmedia.Reports.WinForm.XtraReportQuery("Stock Details Report", DalHandlar.cn, "Admin.VwItemSearch", Query, "'No','Name','Code'", "S.Item_ID", "DATEADD(D, 0, DATEDIFF(D, 0, S.Transaction_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, S.Transaction_Date))", "DATEADD(D, 0, DATEDIFF(D, 0, S.Transaction_Date))", new [] { "Name" }, new [] { "Name" });

            if (dtGetITems != null)
            {
                if (dtGetITems.Rows.Count > 0)
                {
                    var Rpt = new Reports.Stock.RptStockOutDetail();
                    Soothmedia.Reports.WinForm.ShowXtraReport(MDIForm, Rpt, dtGetITems, Modules.Main.DateFormat, true);
                }
            }
            else
            {
                MessageBox.Show(Modules.Main.MsgSearchError);
            }
        }
    }
}
