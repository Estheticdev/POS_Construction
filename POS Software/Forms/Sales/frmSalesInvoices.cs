using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using POS_Software.Modules;
namespace POS_Software.Forms.Sales
{
    public partial class frmSalesInvoices : DevExpress.XtraEditors.XtraForm
    {
        public frmSalesInvoices()
        {
            InitializeComponent();
            da = DalHandlar.cn.Adapter();
            checkstock = Convert.ToBoolean(Modules.General.dtsetting.Rows[1]["Setting_Value"]);
        }

        private IDbDataAdapter da;
        private DataTable dt = new DataTable();
        private DataTable dt2 = new DataTable();
        bool checkstock = true;

        private Models.Sales.Sales_Invoice O_Invoiec = new Models.Sales.Sales_Invoice();
        private Models.Sales.Sales_Invoice_Detail O_InvoiecDetail = new Models.Sales.Sales_Invoice_Detail();
        private Models.Stock.Stock_Detail O_StockDetail = new Models.Stock.Stock_Detail();
        double discount = 0;
       
        public void count()
        {
            double V_GrandTotal = 0;
            TxtGrandAmount.Text = "0";
            //TxtDiscount.Text = discount.ToString();
            var dt = new DataTable();

            dt = (DataTable)gridControl1.DataSource;
            if (dt != null)
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Item_Barcode"] != DBNull.Value)
                    {
                        if (dt.Rows[i]["Item_Sale_Price"] != DBNull.Value && dt.Rows[i]["Qty"] != null && dt.Rows[i]["Percentage_Amount"] != DBNull.Value)
                        {
                            V_GrandTotal += double.Parse(dt.Rows[i]["Percentage_Amount"].ToString());
                            TxtGrandAmount.Text = V_GrandTotal.ToString();
                           // TxtRecievePayment.Text = (Convert.ToDouble(TxtShopAmount.Text) - (Convert.ToDouble(TxtShopAmount.Text) * 0.10)).ToString();
                            discount = V_GrandTotal;
                        }
                    }
                }
            }
        }

        private void GridReset()
        {
            var dt = new DataTable();

            dt.Columns.Add("Item_ID", typeof(int));
            dt.Columns.Add("Item_Barcode", typeof(string));
            dt.Columns.Add("Item_Name", typeof(string));
            dt.Columns.Add("Item_Sale_Price", typeof(decimal));
            dt.Columns.Add("Pack_Price", typeof(decimal));
            dt.Columns.Add("Qty", typeof(decimal));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Unit_Name", typeof(string));
            dt.Columns.Add("Total_Stock", typeof(decimal));
            dt.Columns.Add("Stock_ID", typeof(int));
            dt.Columns.Add("Stock_Critical_Level", typeof(string));
            dt.Columns.Add("IsPacked", typeof(string));
            dt.Columns.Add("Piece_Per_Pack", typeof(decimal));
            dt.Columns.Add("Custom_Size", typeof(string));
            dt.Columns.Add("Percentage", typeof(decimal));
            dt.Columns.Add("Percentage_Amount", typeof(decimal));


            gridControl1.DataSource = dt;
        }

        private int V_Sales_Detail_ID = 0;
        private int V_Sale_ID = 0;
        private int V_Stock_Detail_ID = 0;
        private void frmSalesInvoices_Load(object sender, EventArgs e)
        {
            
            GridReset();
            var dt2 = new DataTable();
            if (Modules.General.dtsetting.Rows[0]["Setting_Value"].ToString() == "True")
                checkBox1.Checked = true;

            dt2.Columns.Add("Sale_ID", typeof(int));
            dt2.Columns.Add("Invoice_No", typeof(int));
            dt2.Columns.Add("Customer_Type", typeof(string));
            dt2.Columns.Add("Grand_Total", typeof(decimal));
            dt2.Columns.Add("Recievd_Amount", typeof(decimal));
            dt2.Columns.Add("TaxPercentage", typeof(decimal));
            dt2.Columns.Add("TaxAmount", typeof(decimal));
            dt2.Columns.Add("ShopAmount", typeof(decimal));
            dt2.Columns.Add("Invoice_Date", typeof(decimal));
            dt2.Columns.Add("Created_By", typeof(string));

            gridControl2.DataSource = dt2;
            //DataTable dtGetInvoiceNumber = null;
            var dtGetInvoiceNumber = DalHandlar.RunQuery("select top 1 Invoice_No from Sales.Sales_Invoice where Invoice_No != '' order by Sale_ID desc");
            if (dtGetInvoiceNumber != null)
            {
                TxtInvoiceNumber.EditValue = Convert.ToString(Convert.ToInt32(dtGetInvoiceNumber.Rows[0]["Invoice_No"]) + 1);
                dbcheck = Convert.ToInt32(TxtInvoiceNumber.Text);
            }
            else
            {
                TxtInvoiceNumber.EditValue = 1;
            }

            DataTable dtAddCustomerType = new DataTable();
            dtAddCustomerType.Columns.AddRange(new DataColumn[2] { new DataColumn("Cutomer_ID"), new DataColumn("Customer_Name") });
            dtAddCustomerType.Rows.Add(1, "Walking Customer");
            dtAddCustomerType.Rows.Add(2, "Regular Customer");
            DalHandlar.BindLookUp(LuECustomerType_ID, dtAddCustomerType, "Customer_Name", "Cutomer_ID");
            LuECustomerType_ID.EditValue = "1";

            DataTable dtPaymentType = new DataTable();
            dtPaymentType.Columns.AddRange(new DataColumn[2] { new DataColumn("Payment_Type_ID"), new DataColumn("Payment_Type") });
            dtPaymentType.Rows.Add(1, "Cash");
            dtPaymentType.Rows.Add(2, "Bank");
            dtPaymentType.Rows.Add(3, "Credit");
            DalHandlar.BindLookUp(LuEPaymentType_ID, dtPaymentType, "Payment_Type", "Payment_Type_ID");
            LuEPaymentType_ID.EditValue = "1";
            TxtCheckOrCreditNo.Enabled = false;
            TxtCheckOrCreditNo.Text = "0";
            DtEInvoiceDate.EditValue = DateTime.Now;
            TxtBarcode.Focus();
            SwitchLanguage();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetDatagrid(TxtBarcode.Text);
        }
        private int BarcodeCheck = 0;
        private int SaveCheck = 0;
        private double ItemPackCheck = 0;
        public void ResetDatagrid(string KeyValue)
        {
           

            if (TxtBarcode.Text != string.Empty)
            {
                dt2 = new DataTable();
                dt2 = DalHandlar.RunQuery(@"Select * from Sales.VwInvoice where Item_Barcode = '" + KeyValue + "' and Active='True'");
                if (dt2 != null)
                {
                    if (checkstock == true)
                    {
                        if (Convert.ToInt32(dt2.Rows[0]["Total_Stock"]) != 0)
                        {
                            stock(KeyValue);
                        }
                        else
                        {
                            MessageBox.Show(dt2.Rows[0]["Item_Name"] + " Has no Stock");
                        }
                    }
                    else
                    {
                        stock(KeyValue);
                    }
                }
                else
                {
                    MessageBox.Show(KeyValue + " Not Exist");
                }
            }
        }
        void stock(string KeyValue)
        {
            double VarQty = 0;
            double multi = 0;
            double sum = 0;
            if (SaveCheck == 1)
            {
                for (var x = 0; x <= gridView1.RowCount; x++)
                {
                    var barcode2 = Convert.ToString(gridView1.GetRowCellValue(x, "Item_Barcode"));
                    if (KeyValue == barcode2)
                    {
                        if (Convert.ToBoolean(gridView1.GetRowCellValue(x, "IsPacked")) == true)
                        {
                            VarQty = Convert.ToDouble(Convert.ToDouble(gridView1.GetRowCellValue(x, "Qty")) + Convert.ToDouble(gridView1.GetRowCellValue(x, "Piece_Per_Pack")));
                            double i = Math.Truncate(Convert.ToDouble(VarQty / Convert.ToDouble(gridView1.GetRowCellValue(x, "Piece_Per_Pack"))));
                            sum = VarQty - Convert.ToDouble(Math.Truncate(Convert.ToDouble(VarQty / Convert.ToDouble(gridView1.GetRowCellValue(x, "Piece_Per_Pack")))) * Convert.ToDouble(gridView1.GetRowCellValue(x, "Piece_Per_Pack")));
                            ItemPackCheck = Convert.ToDouble(gridView1.GetRowCellValue(x, "Pack_Price"));
                            multi = ItemPackCheck * Math.Truncate(i);

                            if (sum > 0)
                            {
                                multi = multi + (Math.Truncate(sum) * Convert.ToDouble(gridView1.GetRowCellValue(x, "Item_Sale_Price")));
                            }
                        }
                        else
                        {
                            ItemPackCheck = Convert.ToDouble(gridView1.GetRowCellValue(x, "Item_Sale_Price"));
                            VarQty = Convert.ToDouble(Convert.ToDouble(gridView1.GetRowCellValue(x, "Qty")) + 1);
                            multi = ItemPackCheck * VarQty;
                        }

                        gridView1.SetRowCellValue(x, "Qty", VarQty);
                        gridView1.SetRowCellValue(x, "Amount", multi);
                        gridView1.UpdateCurrentRow();
                        //count();
                        BarcodeCheck = 1;
                        TxtBarcode.Text = string.Empty;
                        TxtBarcode.Focus();
                        break;
                    }
                    else
                    {
                        BarcodeCheck = 0;
                    }
                }

            }

            if (BarcodeCheck == 0)
            {
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("Item_ID", dt2.Rows[0]["Item_ID"]);
                gridView1.SetFocusedRowCellValue("Item_Barcode", dt2.Rows[0]["Item_Barcode"]);
                gridView1.SetFocusedRowCellValue("Item_Name", dt2.Rows[0]["Item_Name"]);
                gridView1.SetFocusedRowCellValue("Item_Sale_Price", dt2.Rows[0]["Item_Sale_Price"]);
                gridView1.SetFocusedRowCellValue("Pack_Price", dt2.Rows[0]["Pack_Price"]);
                gridView1.SetFocusedRowCellValue("IsPacked", dt2.Rows[0]["IsPacked"]);
                gridView1.SetFocusedRowCellValue("Piece_Per_Pack", dt2.Rows[0]["Piece_Per_Pack"]);

                if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("IsPacked")) == true)
                {

                    VarQty = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack"));
                    ItemPackCheck = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Pack_Price"));
                    multi = ItemPackCheck;
                }
                else
                {
                    ItemPackCheck = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price"));
                    VarQty = 1;

                }
                gridView1.SetFocusedRowCellValue("Qty", VarQty);
                gridView1.SetFocusedRowCellValue("Amount", ItemPackCheck * 1);
                gridView1.SetFocusedRowCellValue("Unit_Name", dt2.Rows[0]["Unit_Name"]);
                gridView1.SetFocusedRowCellValue("Total_Stock", dt2.Rows[0]["Total_Stock"]);
                gridView1.SetFocusedRowCellValue("Stock_ID", dt2.Rows[0]["Stock_ID"]);
                gridView1.SetFocusedRowCellValue("Stock_Critical_Level", dt2.Rows[0]["Stock_Critical_Level"]);

                gridView1.UpdateCurrentRow();
                count();

                Qty.OptionsColumn.AllowEdit = true;
                TxtRecievePayment.Enabled = true;
                btnSave.Enabled = true;
                TxtBarcode.Text = string.Empty;
                TxtBarcode.Focus();
                SaveCheck = 1;
            }
        }
        private void RepTxtQty_Leave(object sender, EventArgs e)
        {
            double VarQty = 0;
            double multi = 0;
            double sum = 0;
            var strr = Convert.ToString(gridView1.GetFocusedRowCellValue("Item_Barcode"));
            if (strr.Length > 0)
            {
                if (!string.IsNullOrWhiteSpace(gridView1.GetFocusedRowCellValue("Qty").ToString()))
                {
                    var str = Convert.ToDouble(gridView1.EditingValue);

                    if (str == 0)
                    {
                        str = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Qty"));
                    }

                    if (str != 0)
                    {
                        if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("IsPacked")) == true && str >= Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))
                        {
                            VarQty = str/ Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack"));
                           
                            sum =str -Convert.ToDouble(Math.Truncate(Convert.ToDouble(str / Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))) * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")));

                            ItemPackCheck = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Pack_Price"));
                            multi = ItemPackCheck * Math.Truncate(VarQty);

                            if (sum > 0)
                            {
                                multi = multi + (Math.Truncate(sum)* Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price")));
                            }
                        }
                        else
                        {
                            ItemPackCheck = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price"));
                            multi = ItemPackCheck * str;
                        }

                        gridView1.SetFocusedRowCellValue("Amount", multi);
                        count();
                    }
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
                count();
            }
        }

        private void TxtRecievePayment_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtRecievePayment.Text != string.Empty && TxtShopAmount.Text != string.Empty)
            {
                TxtBalance.Text = Convert.ToString(Convert.ToDouble(TxtShopAmount.Text) - Convert.ToDouble(TxtRecievePayment.Text));
            }
            else
            {
                if (TxtShopAmount.Text != string.Empty)
                    TxtBalance.Text = TxtShopAmount.Text;
                else
                {
                    TxtBalance.Text = "0";

                }
            }
        }

        private int dbcheck = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (dbcheck <= 200)
            //{

                if (Soothmedia.General.Win.Validation(this, ErPro))
                {
                
                    var Rpt = new Reports.Sales.RptSalesInvoice();

                    O_Invoiec.Sale_ID = (Int32)DalHandlar.AutoNumber<Models.Sales.Sales_Invoice>();
                    V_Sale_ID = O_Invoiec.Sale_ID;

                    O_InvoiecDetail.Sales_Detail_ID = (Int32)DalHandlar.AutoNumber<Models.Sales.Sales_Invoice_Detail>();
                    V_Sales_Detail_ID = O_InvoiecDetail.Sales_Detail_ID;
                    if (checkstock == true)
                    {
                        O_StockDetail.Stock_Detail_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock_Detail>();
                        V_Stock_Detail_ID = O_StockDetail.Stock_Detail_ID;
                    }
                    var dt = new DataTable();
                    dt = (DataTable)gridControl1.DataSource;

                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            //if (Convert.ToDouble(TxtBalance.EditValue) >= 0)
                            //{
                                DalHandlar.RunQuery("insert into Sales.Sales_Invoice(Sale_ID,Invoice_No,Customer_Type,Customer_ID,Grand_Total,PaymentType_ID,CheckOrCreditNo,Recievd_Amount,TaxPercentage,TaxAmount,ShopAmount,Invoice_Date,Created_By,Created_Date,IsReturn,Active,Discount,Ten_Percentage,gurrentee)Values(" + V_Sale_ID + "," + TxtInvoiceNumber.EditValue + "," + Convert.ToInt32(LuECustomerType_ID.EditValue) + "," + v_customerID + "," + TxtGrandAmount.Text + ","+Convert.ToInt32(LuEPaymentType_ID.EditValue) +",'"+TxtCheckOrCreditNo.Text+"',"+ TxtRecievePayment.Text + ",'"+TxtTaxPercentage.Text+"','"+TxtTaxAmount.Text+"','"+TxtShopAmount.Text+"','" + DtEInvoiceDate.DateTime.ToShortDateString() + "','" + TxtAdmin.EditValue + "','" + DateTime.Now.ToShortDateString() + "','" + false + "','" + true + "','"+TxtDiscount.Text+"','"+TxtBalance.Text+"','"+Txtguarantee.Text+"')");
                                for (var x = 0; x <= dt.Rows.Count - 1; x++)
                                {
                                    DalHandlar.RunQuery("insert into Sales.Sales_Invoice_Detail(Sales_Detail_ID,Sale_ID,Item_ID,Item_Barcode,Qty,Unit_Price,Pack_Price,Amount,Created_By,Created_Date,Custom_Size,Percentage_Amount,Percentage) Values(" + V_Sales_Detail_ID + "," + V_Sale_ID + "," + dt.Rows[x]["Item_ID"] + ",'" + dt.Rows[x]["Item_Barcode"] + "'," + dt.Rows[x]["Qty"] + "," + dt.Rows[x]["Item_Sale_Price"] + "," + dt.Rows[x]["Pack_Price"] + "," + dt.Rows[x]["Amount"] + ",'" + TxtAdmin.EditValue + "','" + DateTime.Now.ToShortDateString() + "','" + dt.Rows[x]["Custom_Size"]+"','" + dt.Rows[x]["Percentage_Amount"]+"','" + dt.Rows[x]["Percentage"]+"')");
                                    if (checkstock == true)
                                    {
                                        DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + Convert.ToDouble(Convert.ToDouble(dt.Rows[x]["Total_Stock"]) - Convert.ToDouble(dt.Rows[x]["Qty"])) + ",Last_Updated='" + DateTime.Now.ToShortDateString() + "',Modify_By='" + TxtAdmin.EditValue + "'Where Item_Barcode='" + dt.Rows[x]["Item_Barcode"] + "'");

                                        DalHandlar.RunQuery("insert into Stock.Stock_Detail(Stock_Detail_ID,Stock_ID,Item_Barcode,Item_ID,Stock_In,Stock_Out,Remarks,Transaction_Date,Transaction_By) Values(" + V_Stock_Detail_ID + "," + dt.Rows[x]["Stock_ID"] + ",'" + dt.Rows[x]["Item_Barcode"] + "'," + dt.Rows[x]["Item_ID"] + "," + 0 + "," + dt.Rows[x]["Qty"] + ",'" + "Out" + "','" + DateTime.Now.ToShortDateString() + "','" + TxtAdmin.EditValue + "')");
                                        V_Stock_Detail_ID++;
                                    }
                                        V_Sales_Detail_ID++;
                                   
                                }
                        if (TxtBalance.Text != "0" && TxtGetRegularCustomer.Text!="")
                        {
                            double previous_balance = Convert.ToDouble(label14.Text);
                            double new_balance = Convert.ToDouble(TxtBalance.Text) + previous_balance;
                            DalHandlar.RunQuery("update admin.Customer_Deffination set Balance= " + new_balance + " where Customer_ID=" +v_customerID);
                        }
                                MessageBox.Show("Saved Successfully");


                            if (dt != null)
                            {
                                dt.Columns.Add("GrandTotal", typeof(double));
                                dt.Columns.Add("RecievedCash", typeof(double));
                                dt.Columns.Add("TaxPercentage", typeof(double));
                                dt.Columns.Add("TaxAmount", typeof(double));
                                dt.Columns.Add("ShopAmount", typeof(double));
                                dt.Columns.Add("Balance", typeof(double));
                                dt.Columns.Add("InvoiceNumber", typeof(int));
                                dt.Columns.Add("Date", typeof(string));
                                dt.Columns.Add("Created_By", typeof(string));
                                dt.Columns.Add("Customer", typeof(string));
                                dt.Columns.Add("TaxNumber", typeof(string));
                                dt.Columns.Add("Contact_Number", typeof(string));
                            dt.Columns.Add("Location", typeof(string));
                            dt.Columns.Add("CC1", typeof(string));
                            dt.Columns.Add("CC2", typeof(string));
                            dt.Columns.Add("discount", typeof(string));
                            dt.Columns.Add("discountamount", typeof(string));
                            dt.Columns.Add("paymenttype", typeof(string));
                            dt.Columns.Add("guarantee", typeof(string));
                            
                            //dt.Columns.Add("Comments", typeof(string));



                            foreach (DataRow dr in dt.Rows)
                                {
                                    dr["GrandTotal"] = discount.ToString(); ;
                                    dr["RecievedCash"] = TxtRecievePayment.EditValue;
                                    dr["TaxPercentage"] = TxtTaxPercentage.EditValue;
                                    dr["TaxAmount"] = TxtTaxAmount.EditValue;
                                dr["guarantee"] = Txtguarantee.Text;
                                dr["ShopAmount"] = TxtShopAmount.EditValue;
                                    dr["Balance"] = TxtBalance.EditValue;
                                dr["discount"] = TxtDiscount.EditValue;
                                dr["discountamount"] = TxtGrandAmount.EditValue;
                                //dr["Comments"] = 
                                dr["InvoiceNumber"] = TxtInvoiceNumber.EditValue;
                                    dr["Date"] = DtEInvoiceDate.EditValue.ToString();
                                    dr["Created_By"] = TxtAdmin.EditValue;
                                dr["paymenttype"] = LuEPaymentType_ID.EditValue;

                                if (LuECustomerType_ID.Text == "Walking Customer")
                                    {
                                    if(TxtComments.Text=="")
                                        dr["Customer"] = "N/A";
                                    else
                                            dr["Customer"] = TxtComments.Text ;
                                        dr["Contact_Number"] = "N/A";
                                        dr["TaxNumber"] = "N/A";
                                    }
                                    else
                                    {
                                        dr["Customer"] = lblCustomerName.Text;
                                        dr["Contact_Number"] = label1.Text;
                                        dr["TaxNumber"] = label2.Text;
                                    dr["Location"] = dtgetCustomer.Rows[0]["Location"].ToString();
                                    dr["CC1"] = dtgetCustomer.Rows[0]["CC1"].ToString();
                                    dr["CC2"] = dtgetCustomer.Rows[0]["CC2"].ToString();
                                    
                                }
                                }


                                if (checkBox1.Checked)
                                {
                                    if (System.Windows.Forms.Application.OpenForms[2] != null)
                                    if (System.Windows.Forms.Application.OpenForms[2] != null)
                                    {


                                        if ((bool)Modules.General.dtsetting.Rows[2]["Setting_Value"] == true)
                                        {
                                            (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay1(new Reports.Sales.RptSalesInvoice_A4Direct(dt), dt);
                                        }
                                        else
                                        {
                                            var report = new Reports.Sales.RptSalesInvoice_A4Direct(dt);
                                            report.DataSource = dt;

                                            report.Print();
                                        }
                                    }
                            }
                                else
                                {
                                    if (System.Windows.Forms.Application.OpenForms[2] != null)
                                    {
                                       
                                          
                                            if ((bool)Modules.General.dtsetting.Rows[2]["Setting_Value"] == true)
                                            {
                                                (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay1(new Reports.Sales.RptSalesInvoiceDirect(dt), dt);
                                            }
                                            else
                                            {
                                             var report = new Reports.Sales.RptSalesInvoiceDirect(dt);
                                             report.DataSource = dt;
                                             report.Print();
                                            }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Data Not Found");
                            }
                                TxtBarcode.EditValue = string.Empty;
                                TxtBarcode.Focus();
                                gridControl1.DataSource = null;

                                TxtGrandAmount.Text = "0";
                                TxtRecievePayment.Enabled = true;
                                TxtRecievePayment.Text = "0";
                                TxtBalance.Text = "0";
                        Txtguarantee.Text = "";
                                TxtBarcode.Text = string.Empty;
                                TxtCheckOrCreditNo.Enabled = false;
                                TxtCheckOrCreditNo.Text = "0";
                        TxtDiscount.Text = "0";
                                lblCustomerName.Text = "Name Of Customer";
                                BarcodeCheck = 0;
                        TxtGetRegularCustomer.Text = "";
                        LuECustomerType_ID.ItemIndex = 0;
                                SaveCheck = 0;
                                GridReset();
                                TxtInvoiceNumber.EditValue = Convert.ToString(Convert.ToInt32(TxtInvoiceNumber.EditValue) + 1);
                                dbcheck = Convert.ToInt32(TxtInvoiceNumber.Text);
                                Modules.General.dtItemSearch = DalHandlar.RunQuery("select * from Admin.VwItemSearch where Active='True'");
                                DtEInvoiceDate.EditValue = DateTime.Now;
                                TxtBarcode.Focus();
                            TxtComments.Text = "";
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Invoice Required " + Convert.ToString((Convert.ToDecimal(TxtBalance.EditValue) * (-1))) + "RS More");
                            //}
                        }
                        else
                        {
                            MessageBox.Show("You Must add at least one Row");
                        }
                    }
                }
            //}
            //else
            //{
            //    MessageBox.Show("You trial is expired");

            //}
        }

        private void frmSalesInvoices_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.F)
            {
                var Dt = new DataTable();
                if (sender.GetType() == typeof(int))
                {
                    Dt.Columns.Add("Item_Barcode", typeof(string));
                    Dt.Rows.Add(sender);
                }
                else
                {
                    if (Modules.General.dtItemSearch != null)
                    {
                        Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No',Code,'Name'", false, "1");
                        if (Dt != null)
                        {
                            var dtgetBarcode = DalHandlar.RunQuery("Select Item_ID,Item_Barcode from Admin.Items_Deffination where Active=1 and Item_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                            if (dtgetBarcode != null)
                            {
                                TxtBarcode.EditValue = Convert.ToString(dtgetBarcode.Rows[0]["Item_Barcode"]);
                                ResetDatagrid(Convert.ToString(dtgetBarcode.Rows[0]["Item_Barcode"]));
                                
                            }
                        }
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBetweenDate_Click(object sender, EventArgs e)
        {
            if (DtEFrom.Value.ToString() != string.Empty && DtETo.Value.ToString() != string.Empty)
            {
                gridControl2.DataSource = null;
                var dt = new DataTable();
                //dt = DalHandlar.RunQuery(@"Select * from Sales.Sales_Invoice where DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date)) between DATEADD(D, 0, DATEDIFF(D, 0, '" + DtEFrom.Value.ToString("yyyy-dd-MM") + "')) and DATEADD(D, 0, DATEDIFF(D, 0, '" + DtETo.Value.ToString("yyyy-dd-MM") + "'))");
                dt = DalHandlar.RunQuery(@"Select * from Sales.Sales_Invoice where Invoice_Date between '" + DtEFrom.Value.ToShortDateString() + "' and '" + DtETo.Value.ToShortDateString() + "'");
                gridControl2.DataSource = dt;
                gridView2.BestFitColumns();
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;
            var dt = new DataTable();
            // dt = DalHandlar.RunQuery(@"Select * from Sales.Sales_Invoice where DATEADD(D, 0, DATEDIFF(D, 0, Invoice_Date))=DATEADD(D, 0, DATEDIFF(D, 0, GETDATE()))");
            dt = DalHandlar.RunQuery(@"Select * from Sales.Sales_Invoice where Invoice_Date='"+DateTime.Now.Date.ToShortDateString()+"'");
            gridControl2.DataSource = dt;
            gridView2.BestFitColumns();
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;
            var dt = new DataTable();
            dt = DalHandlar.RunQuery(@"Select Top 50 * from Sales.Sales_Invoice where Invoice_Date='" + DateTime.Now.Date.AddDays(-1).ToShortDateString() + "'");

            gridControl2.DataSource = dt;
            gridView2.BestFitColumns();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;
            var dt = new DataTable();
            dt = DalHandlar.RunQuery(@"Select Top 50 * from Sales.Sales_Invoice");

            gridControl2.DataSource = dt;
            gridView2.BestFitColumns();
        }
        private void TxtInvoiceNumberSearch_Leave(object sender, EventArgs e)
        {
            if (TxtInvoiceNumberSearch.Text != string.Empty)
            {
                gridControl2.DataSource = null;
                var dt = new DataTable();
                dt = DalHandlar.RunQuery(@"Select  * from Sales.Sales_Invoice where Invoice_No=" + TxtInvoiceNumberSearch.Text);
                gridControl2.DataSource = dt;
                gridView2.BestFitColumns();
            }
            else
            {
                gridControl2.DataSource = null;
                var dt = new DataTable();
                dt = DalHandlar.RunQuery(@"Select Top 50 * from Sales.Sales_Invoice");

                gridControl2.DataSource = dt;
                gridView2.BestFitColumns();

            }
        }
        private void TxtBarcode_Leave(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void TxtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                e.Handled = true;

                btnAdd_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt2 = new DataTable();
            gridControl1.DataSource = null;
            TxtGrandAmount.Text = "0";
            TxtRecievePayment.Enabled = true;
            TxtRecievePayment.Text = "0";
            TxtBalance.Text = "0";
            TxtCheckOrCreditNo.Enabled = false;
            TxtCheckOrCreditNo.Text = "0";
            lblCustomerName.Text = "Name Of Customer";
            TxtBarcode.Text = string.Empty;
            GridReset();
            btnSave.Enabled = false;
            TxtBarcode.Focus();
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Modules.Main.AlphaNumericCheck(e);
            Modules.Main.AlphaNumericCheck(e);
        }

        private void TxtRecievePayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.DecimalPointCheck(e);
        }

        private void RepTxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.DecimalPointCheck(e);
        }

        private void RepTxtQty_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            var Dt = new DataTable();
            if (sender.GetType() == typeof(int))
            {
                Dt.Columns.Add("Item_Barcode", typeof(string));
                Dt.Rows.Add(sender);
            }
            else
            {
                if (Modules.General.dtItemSearch != null)
                {
                    Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No',Code,'Name'", false, "1");
                    if (Dt != null)
                    {
                        var dtgetBarcode = DalHandlar.RunQuery("Select Item_ID,Item_Barcode from Admin.Items_Deffination where Active=1 and Item_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                        if (dtgetBarcode != null)
                        {
                            TxtBarcode.EditValue = Convert.ToString(dtgetBarcode.Rows[0]["Item_Barcode"]);
                            ResetDatagrid(Convert.ToString(dtgetBarcode.Rows[0]["Item_Barcode"]));
                            
                        }
                    }
                }
            }
        }
        int v_customerID = 0;
        private void btnGetRegularCustomer_Click(object sender, EventArgs e)
        {
            var Dt = new DataTable();
            if (sender.GetType() == typeof(int))
            {
                Dt.Columns.Add("Customer_ID", typeof(string));
                Dt.Rows.Add(sender);
            }
            else
            {
                if (Modules.General.dtRegularCustomer != null)
                {
                    Dt = Soothmedia.General.Win.Searchingform("Customer Search", DalHandlar.cn, Modules.General.dtRegularCustomer, "'No','Name'", false, "1");
                    if (Dt != null)
                    {
                        var dtgetCustomer = DalHandlar.RunQuery("Select Customer_ID,Customer_Name,Contact_Number,TaxNumber,Location from Admin.Customer_Deffination where Active=1 and Customer_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                        if (dtgetCustomer != null)
                        {
                            lblCustomerName.Text = Convert.ToString(dtgetCustomer.Rows[0]["Customer_Name"] + "(" + dtgetCustomer.Rows[0]["Customer_ID"] + ")");
                            v_customerID = Convert.ToInt32(dtgetCustomer.Rows[0]["Customer_ID"].ToString());
                            label1.Text = dtgetCustomer.Rows[0]["Contact_Number"].ToString();
                            label2.Text = dtgetCustomer.Rows[0]["TaxNumber"].ToString();
                        }
                    }
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Forms.Admin.frmCustomerDeffination CD = new Admin.frmCustomerDeffination(LuECustomerType_ID.Text, LuECustomerType_ID.EditValue);
            CD.Show();
        }

        private void LuECustomerType_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuECustomerType_ID.Text == "Regular Customer")
            {
                btnAddCustomer.Enabled = true;
                btnGetRegularCustomer.Enabled = true;
                TxtGetRegularCustomer.Enabled = true;
                TxtGetRegularCustomer.Tag = "*";
                lblCustomerName.Text = "Name of Custmer";
                TxtComments.Enabled = false;
            }
            else
            {
                btnAddCustomer.Enabled = false;
                btnGetRegularCustomer.Enabled = false;
                TxtGetRegularCustomer.Enabled = false;
                lblCustomerName.Text = "Name of Custmer";
                TxtCheckOrCreditNo.Text = "0";
                TxtGetRegularCustomer.Tag = "";
                v_customerID = 0;
                TxtComments.Enabled = true;

            }
        }
        DataTable dtgetCustomer;
        private void TxtGetRegularCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtGetRegularCustomer.Text != null)
            {
                int CalLengnth = Convert.ToInt32(TxtGetRegularCustomer.Text.Length);
                if (CalLengnth <= 7 && TxtGetRegularCustomer.Text!=string.Empty)
                {
                     dtgetCustomer = DalHandlar.RunQuery("Select Customer_ID,Customer_Name,Contact_Number,TaxNumber,Location,Balance,*  from Admin.Customer_Deffination where Active=1 and Customer_ID=" + Convert.ToInt32(TxtGetRegularCustomer.Text));
                    if (dtgetCustomer != null)
                    {
                        lblCustomerName.Text = Convert.ToString(dtgetCustomer.Rows[0]["Customer_Name"]);
                        v_customerID = Convert.ToInt32(dtgetCustomer.Rows[0]["Customer_ID"].ToString());
                        label1.Text = dtgetCustomer.Rows[0]["Contact_Number"].ToString();
                        label2.Text = dtgetCustomer.Rows[0]["TaxNumber"].ToString();
                        label14.Text = dtgetCustomer.Rows[0]["Balance"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Customer Not Found");
                    }

                }
                else
                {
                    MessageBox.Show("Kindly Enter Customer ID", "Stop");
                    TxtGetRegularCustomer.Focus();
                    
                }
            }
        }

        private void LuEPaymentType_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuEPaymentType_ID.Text != "Cash")
            {
                TxtCheckOrCreditNo.Enabled = true;
                TxtRecievePayment.Visible = true;
                lblReceivedAmount.Visible = true;
               // TxtRecievePayment.Text = "0";
               
                
            }
            else
            {
                TxtCheckOrCreditNo.Enabled = false;
                TxtCheckOrCreditNo.Text = "0";
                TxtRecievePayment.Visible = true;
                lblReceivedAmount.Visible = true;
                //TxtRecievePayment.Text = TxtShopAmount.Text;
                

            }
        }

        private void TxtInvoiceNumberSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.NumericCheck(e);
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;
            var dt = new DataTable();
            dt = DalHandlar.RunQuery(@"Select Top 50 * from Sales.Sales_Invoice");

            gridControl2.DataSource = dt;
            gridView2.BestFitColumns();
            TxtInvoiceNumberSearch.Text = string.Empty;
            DtEFrom2.Text = string.Empty;
            DtETo1.Text = string.Empty;
        }

        private void TxtGetRegularCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.NumericCheck(e);
        }

        private void TxtGrandAmount_EditValueChanged(object sender, EventArgs e)
        {
            DataTable vat = DalHandlar.RunQuery("select Setting_Text from admin.Setting where SettingID =7");
            TxtTaxPercentage.Text = vat.Rows[0]["Setting_Text"].ToString();
            if (TxtGrandAmount.Text != "")
            {
                double grandamount = Convert.ToDouble( TxtGrandAmount.Text);
                TxtTaxAmount.Text = ((Convert.ToDouble(TxtTaxPercentage.Text)/100) * grandamount).ToString();
                TxtShopAmount.Text = Math.Round((grandamount + Convert.ToDouble(TxtTaxAmount.Text)),2).ToString();
                
                
            }
        }

        private void TxtBarcode_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SwitchLanguage()
        {
            if (General.culture != null)
            {
                this.Text = General.resourceManager.GetString("frmSalesInvoices", General.culture);
                lblSalesInvoice.Text = General.resourceManager.GetString("lblSalesInvoice", General.culture);
                TPSalesInvoice.Text = General.resourceManager.GetString("lblSalesInvoice", General.culture);
                TPTodaySale.Text = General.resourceManager.GetString("TPTodaySale", General.culture);
                lblInvoiceNumber.Text = General.resourceManager.GetString("lblInvoiceNumber", General.culture);
                lblCellNo.Text = General.resourceManager.GetString("lblCodeNo", General.culture);
                lblDate.Text = General.resourceManager.GetString("lblDate", General.culture);
                lblScanBarcode.Text = General.resourceManager.GetString("lblScanBarcode", General.culture);
                lblRegCustomerName.Text = General.resourceManager.GetString("lblRegCustomerName", General.culture);
                lblCustomerBalance.Text = General.resourceManager.GetString("lblCustomerBalance", General.culture);
                lblUser.Text = General.resourceManager.GetString("lblUser", General.culture);
                gPaymentBox.Text = General.resourceManager.GetString("gPaymentBox", General.culture);
                lblGrandAmount.Text = General.resourceManager.GetString("lblGrandAmount", General.culture);
                lblPaymentType.Text = General.resourceManager.GetString("lblPaymentType", General.culture);
                lblCardNo.Text = General.resourceManager.GetString("lblCardNo", General.culture);
                lblReceivedAmount.Text = General.resourceManager.GetString("lblReceivedAmount", General.culture);
                lblTax.Text = General.resourceManager.GetString("lblTax", General.culture);
                lblTaxAmount.Text = General.resourceManager.GetString("lblTaxAmount", General.culture);
                lblShopAmount.Text = General.resourceManager.GetString("lblShopAmount", General.culture);
                lblCustomerName.Text = General.resourceManager.GetString("lblCustomerName", General.culture);
                lblgurrentee.Text = General.resourceManager.GetString("lblgurrentee", General.culture);

                gridView1.Columns["Item_Barcode"].Caption = General.resourceManager.GetString("Item_Barcode", General.culture);
                gridView1.Columns["Item_Name"].Caption = General.resourceManager.GetString("Item_Name", General.culture);
                gridView1.Columns["Item_Sale_Price"].Caption = General.resourceManager.GetString("Item_Sale_Price", General.culture);
                gridView1.Columns["Pack_Price"].Caption = General.resourceManager.GetString("PackPrice", General.culture);
                gridView1.Columns["Qty"].Caption = General.resourceManager.GetString("Qty", General.culture);
                gridView1.Columns["Amount"].Caption = General.resourceManager.GetString("Item_Amount", General.culture);
                gridView1.Columns["Custom_Size"].Caption = General.resourceManager.GetString("Custom_Size", General.culture);
                gridView1.Columns["Percentage"].Caption = General.resourceManager.GetString("Percentage", General.culture);
                gridView1.Columns["Percentage_Amount"].Caption = General.resourceManager.GetString("Percentage_Amount", General.culture);

                gridView2.Columns["Invoice_No"].Caption = General.resourceManager.GetString("lblInvoiceNumber", General.culture);
                gridView2.Columns["Grand_Total"].Caption = General.resourceManager.GetString("Grand_Total", General.culture);
                gridView2.Columns["Recievd_Amount"].Caption = General.resourceManager.GetString("Recievd_Amount", General.culture);
                //gridView2.Columns["Invoice_Date"].Caption = General.resourceManager.GetString("Invoice_Date", General.culture);
                gridView2.Columns["Created_By"].Caption = General.resourceManager.GetString("Created_By", General.culture);

                btnAdd.Text = General.resourceManager.GetString("BtnAdd", General.culture);
                btnAddCustomer.Text = General.resourceManager.GetString("BtnAdd", General.culture);
                btnGetRegularCustomer.Text = General.resourceManager.GetString("btnFind", General.culture);
                btnSimple.Text = General.resourceManager.GetString("BtnSearch", General.culture);
                btnSave.Text = General.resourceManager.GetString("BtnSave", General.culture);
                btnCancel.Text = General.resourceManager.GetString("BtnCancel", General.culture);
                btnExit.Text = General.resourceManager.GetString("btnExit", General.culture);
                btnBetweenDate.Text = General.resourceManager.GetString("btnBetween", General.culture);
                btnToday.Text = General.resourceManager.GetString("btnToday", General.culture);
                btnYesterday.Text = General.resourceManager.GetString("btnYesterday", General.culture);
                txtClear.Text = General.resourceManager.GetString("btnClear", General.culture);
            }
        }

        private void RPtUnitPrice_Leave(object sender, EventArgs e)
        {
            double VarQty = 0;
            double multi = 0;
            double sum = 0;
            var strr = Convert.ToString(gridView1.GetFocusedRowCellValue("Item_Barcode"));
            if (strr.Length > 0)
            {
                if (!string.IsNullOrWhiteSpace(gridView1.GetFocusedRowCellValue("Qty").ToString()))
                {
                    var str = Convert.ToDouble(gridView1.EditingValue);

                    if (str == 0)
                    {
                        str = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Qty"));
                    }

                    if (str != 0)
                    {
                        if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("IsPacked")) == true && str >= Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))
                        {
                            VarQty = str / Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack"));

                            sum = str - Convert.ToDouble(Math.Truncate(Convert.ToDouble(str / Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))) * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")));

                            ItemPackCheck = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Pack_Price"));
                            multi = ItemPackCheck * Math.Truncate(VarQty);

                            if (sum > 0)
                            {
                                multi = multi + (Math.Truncate(sum) * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price")));
                            }
                        }
                        else
                        {
                            ItemPackCheck = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price"));
                            multi = ItemPackCheck * str;
                        }

                        gridView1.SetFocusedRowCellValue("Amount", multi);
                        count();
                    }
                }
            }
        }

        private void TxtGetRegularCustomer_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            double dd = 0;
            if (TxtDiscount.Text != "")
            {
                dd = Convert.ToDouble(TxtDiscount.Text);

                TxtGrandAmount.Text = (discount - dd).ToString();
            }
            else
            {
                TxtDiscount.Text = "0";
                dd = 0;
        TxtGrandAmount.Text = (discount - dd).ToString();
            }
        }

        private void TxtDiscount_Leave(object sender, EventArgs e)
        {
           
        }

        private void rppercentage_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rppercentage_Leave(object sender, EventArgs e)
        {
            double VarQty = 0;
            double multi = 0;
            double sum = 0;

            if (!string.IsNullOrWhiteSpace(gridView1.GetFocusedRowCellValue("Percentage").ToString()))
            {
                var str = Convert.ToDouble(gridView1.EditingValue);

                if (str == 0)
                {
                    str = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Percentage"));
                }

                if (str != 0)
                {
                    multi = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Amount"));
                    sum = (str / 100) * multi;

                    gridView1.SetFocusedRowCellValue("Percentage_Amount", sum);
                    count();
                }
            }
        }

        private void Txtguarantee_Leave(object sender, EventArgs e)
        {
            if (Txtguarantee.Text != null)
            {
                TxtRecievePayment.Text = (Convert.ToDouble(TxtShopAmount.Text) - (Convert.ToDouble(TxtShopAmount.Text) * (Convert.ToDouble(Txtguarantee.Text) / 100))).ToString();
                TxtBalance.Text = (Convert.ToDouble(TxtShopAmount.Text) - Convert.ToDouble(TxtRecievePayment.Text)).ToString();
            }
        }
    }
}
