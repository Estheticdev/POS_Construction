using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using POS_Software.Modules;

namespace POS_Software.Forms.Sales
{
    public partial class frmSalesReturns : DevExpress.XtraEditors.XtraForm
    {
        public frmSalesReturns()
        {
            InitializeComponent();
            da = DalHandlar.cn.Adapter();
            checkstock = Convert.ToBoolean(Modules.General.dtsetting.Rows[1]["Setting_Value"]);
        }
        bool checkstock = true;
        private IDbDataAdapter da;
        private DataTable dt = new DataTable();
        private DataTable dtGetSalesDetail = new DataTable();
        private DataTable dtGetSale = new DataTable();
        private DataTable dtSalesReturn = new DataTable();

        private int V_Sales_Return_ID = 0;
        private int V_Stock_Detail_ID = 0;

        private double V_preqty = 0;
        private Models.Sales.Sales_Return_Detail O_SalesReturn_Detail = new Models.Sales.Sales_Return_Detail();
        private Models.Stock.Stock_Detail O_StockDetail = new Models.Stock.Stock_Detail();

        public void ControlDisabled()
        {
            TxtInvoiceNumber.Enabled = false;
            btnGetInvoiceData.Enabled = false;
            DtEInvoiceDate.Enabled = false;
            TxtRecievePayment.Enabled = false;
            LuEPaymentType_ID.Enabled = false;
            LuECustomerType_ID.Enabled = false;
            TxtCheckOrCreditNo.Enabled = false;
            TxtGetRegularCustomer.Enabled = false;
            btnGetRegularCustomer.Enabled = false;
            TxtTaxAmount.Enabled = false;
            TxtTaxPercentage.Enabled = false;
            TxtShopAmount.Enabled = false;
        }

        public void ControlEnabled()
        {
            TxtInvoiceNumber.Enabled = true;
            btnGetInvoiceData.Enabled = true;
            DtEInvoiceDate.Enabled = true;
            LuEPaymentType_ID.Enabled = true;
            LuECustomerType_ID.Enabled = true;
            TxtCheckOrCreditNo.Enabled = true;
            TxtGetRegularCustomer.Enabled = true;
            btnGetRegularCustomer.Enabled = true;
            TxtTaxAmount.Enabled = true;
            TxtTaxPercentage.Enabled = true;
            TxtShopAmount.Enabled = true;
        }

        public void count()
        {
            double V_GrandTotal = 0;
            TxtGrandAmount.Text = "0";
            var dt = new DataTable();
            dt = (DataTable)gridControl1.DataSource;
            dt.AcceptChanges();
            if (dt != null)
            {
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Item_Barcode"] != DBNull.Value)
                    {
                        if (dt.Rows[i]["Item_Sale_Price"] != DBNull.Value && dt.Rows[i]["Qty"] != null)
                        {
                            V_GrandTotal += double.Parse(dt.Rows[i]["Amount"].ToString());
                        }
                    }
                }
            }
        }

        int v_customerID = 0;
        private void frmSalesInvoices_Load(object sender, EventArgs e)
        {
            if (!dtSalesReturn.Columns.Contains("Sales_Detail_ID"))
            {
                dtSalesReturn.Columns.Add("Sales_Detail_ID", typeof(int));
                dtSalesReturn.Columns.Add("Sale_ID", typeof(int));
                dtSalesReturn.Columns.Add("Item_ID", typeof(int));
                dtSalesReturn.Columns.Add("Item_Name", typeof(string));
                dtSalesReturn.Columns.Add("Item_Barcode", typeof(string));
                dtSalesReturn.Columns.Add("Item_Sale_Price", typeof(decimal));
                dtSalesReturn.Columns.Add("Pack_Price", typeof(decimal));
                dtSalesReturn.Columns.Add("Qty", typeof(decimal));
                dtSalesReturn.Columns.Add("Amount", typeof(decimal));
                dtSalesReturn.Columns.Add("Total_Stock", typeof(decimal));
                dtSalesReturn.Columns.Add("Stock_ID", typeof(Int32));
            }


            ControlDisabled();



            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnExit.Enabled = true;

            DataTable dtAddCustomerType = new DataTable();
            dtAddCustomerType.Columns.AddRange(new DataColumn[2] { new DataColumn("Cutomer_ID"), new DataColumn("Customer_Name") });
            dtAddCustomerType.Rows.Add(1, "Walking Customer");
            dtAddCustomerType.Rows.Add(2, "Regular Customer");
            DalHandlar.BindLookUp(LuECustomerType_ID, dtAddCustomerType, "Customer_Name", "Cutomer_ID");
            LuECustomerType_ID.EditValue = "1";

            DataTable dtPaymentType = new DataTable();
            dtPaymentType.Columns.AddRange(new DataColumn[2] { new DataColumn("Payment_Type_ID"), new DataColumn("Payment_Type") });
            dtPaymentType.Rows.Add(1, "Cash");
            dtPaymentType.Rows.Add(2, "Check");
            dtPaymentType.Rows.Add(3, "Credit");
            DalHandlar.BindLookUp(LuEPaymentType_ID, dtPaymentType, "Payment_Type", "Payment_Type_ID");
            LuEPaymentType_ID.EditValue = "1";

            SwitchLanguage();
        }
        DataTable dtGetCustomer = new DataTable();
        public void ResetDatagrid(string KeyValue)
        {
            
            if (!string.IsNullOrEmpty(KeyValue))
            {
                dtGetSale = DalHandlar.RunQuery("Select * from Sales.Sales_Invoice where Invoice_No=" + KeyValue + " and Active=1");
                if (dtGetSale != null)
                {
                    gridControl1.DataSource = DalHandlar.InitializeDataGrid(@"SELECT  SD.Sales_Detail_ID,SD.Sale_ID, SD.Item_Barcode, SD.Item_ID, ID.Item_Name + ' ' + its.Size_Name AS Item_Name, 
                                                                            SD.Qty, SD.Unit_Price AS Item_Sale_Price,SD.Pack_Price, SD.Amount,SD.Qty as PreQty, ST.Total_Stock,ST.Stock_ID,U.Unit_Name as Unit_Name,
                                                                            ID.Stock_Critical_Level,ID.IsPacked,ID.Piece_Per_Pack
                                                                            FROM       Sales.Sales_Invoice AS S LEFT JOIN
                                                                            Sales.Sales_Invoice_Detail AS SD ON S.Sale_ID = SD.Sale_ID LEFT JOIN
                                                                            Admin.Items_Deffination AS ID ON ID.Item_ID = SD.Item_ID LEFT JOIN
                                                                            Admin.Sizes AS its ON ID.Item_Size_ID = its.Size_ID LEFT JOIN
                                                                            Stock.Stock AS ST ON SD.Item_Barcode = ST.Item_Barcode Left join
                                                                            Admin.Units as U on ID.Item_Unit_ID= U.Unit_ID 
                                                                            where S.Invoice_No =" + KeyValue + " and S.Active=1", dtGetSalesDetail, da);






                    count();
                   
                    TxtRecievePayment.EditValue = Convert.ToString(dtGetSale.Rows[0]["Recievd_Amount"]);
                    TxtGrandAmount.EditValue = Convert.ToString(dtGetSale.Rows[0]["Grand_Total"]);
                    TxtTaxAmount.EditValue = Convert.ToString(dtGetSale.Rows[0]["TaxAmount"]);
                    TxtTaxPercentage.EditValue = Convert.ToString(dtGetSale.Rows[0]["TaxPercentage"]);
                    TxtShopAmount.EditValue = Convert.ToString(dtGetSale.Rows[0]["ShopAmount"]);
                    TxtBalance.Text = (Convert.ToDouble(TxtShopAmount.Text) - Convert.ToDouble(TxtRecievePayment.Text)).ToString();
                    DtEInvoiceDate.EditValue = Convert.ToString(dtGetSale.Rows[0]["Created_Date"]);
                    LuECustomerType_ID.EditValue = Convert.ToString(dtGetSale.Rows[0]["Customer_Type"]);
                    TxtGetRegularCustomer.Text= Convert.ToString(dtGetSale.Rows[0]["Customer_ID"]);
                    v_customerID = Convert.ToInt32(TxtGetRegularCustomer.Text);
                    LuEPaymentType_ID.EditValue = Convert.ToString(dtGetSale.Rows[0]["PaymentType_ID"]);
                    TxtCheckOrCreditNo.EditValue = dtGetSale.Rows[0]["CheckOrCreditNo"].ToString();

                    if (Convert.ToString(dtGetSale.Rows[0]["Customer_ID"]) != "0" && Convert.ToString(dtGetSale.Rows[0]["Customer_ID"])!=string.Empty)
                    {
                         dtGetCustomer = DalHandlar.RunQuery("Select * from Admin.Customer_Deffination where Customer_ID= " + dtGetSale.Rows[0]["Customer_ID"]);
                        lblCustomerName.Text = dtGetCustomer.Rows[0][2].ToString() + "(" + dtGetCustomer.Rows[0][0].ToString()+")";
                    }
                    TxtInvoiceNumber.Enabled = false;
                    btnGetInvoiceData.Enabled = false;
                    TxtRecievePayment.Enabled = false;
                    Qty.OptionsColumn.AllowEdit = false;

                    btnNew.Enabled = false;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;
                    btnExit.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invoice not Exist");

                    TxtInvoiceNumber.Enabled = true;
                    TxtRecievePayment.Enabled = false;
                    DtEInvoiceDate.Text = DateTime.Now.ToString();

                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnExit.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Field is Empty");
            }
        }
        private double ItemPackCheck = 0;
       
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

                    var NewQty = Convert.ToDouble(gridView1.EditingValue);

                    if (NewQty == 0)
                    {
                        NewQty = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Qty"));
                    }

                    //var NewQty = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Qty"));
                    V_preqty = Convert.ToDouble(gridView1.GetFocusedRowCellValue("PreQty"));

                    if (NewQty > 0)
                    {
                        if (NewQty <= V_preqty)
                        {


                            if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("IsPacked")) == true && NewQty >= Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))
                            {
                                VarQty = NewQty/ Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack"));

                                sum = NewQty - Convert.ToDouble(Math.Truncate(Convert.ToDouble(NewQty / Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))) * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")));

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
                                multi = ItemPackCheck * NewQty;
                            }

                            gridView1.SetFocusedRowCellValue("Amount", multi);
                            count();



                            // multi = NewQty * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price"));
                            //gridView1.SetFocusedRowCellValue("Amount", multi);
                            //gridView1.UpdateCurrentRow();
                            //count();
                        }
                        else
                        {
                            MessageBox.Show("Value Should be less than Previous Qty");

                            if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("IsPacked")) == true && Convert.ToDouble(gridView1.GetFocusedRowCellValue("PreQty")) >= Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))
                            {
                                VarQty = Convert.ToDouble(Convert.ToDouble(gridView1.GetFocusedRowCellValue("PreQty")) / Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")));

                                sum = V_preqty - Convert.ToDouble(Math.Truncate(Convert.ToDouble(V_preqty / Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")))) * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Piece_Per_Pack")));

                                ItemPackCheck = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Pack_Price"));
                                multi = ItemPackCheck * Math.Truncate(VarQty);

                                if (sum > 0)
                                {
                                    multi = multi + (Math.Truncate(sum) * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price")));
                                }
                            }
                            else
                            {
                           
                                multi = V_preqty * Convert.ToDouble(gridView1.GetFocusedRowCellValue("Item_Sale_Price"));
                            }

                            gridView1.SetFocusedRowCellValue("Qty", V_preqty);
                            gridView1.SetFocusedRowCellValue("Amount", multi);
                            gridView1.UpdateCurrentRow();
                            count();
                        }
                        TxtRecievePayment.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("New Qty Should be greater than zero");
                    }
                }
            }
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                var strr = Convert.ToString(gridView1.GetFocusedRowCellValue("Item_Barcode"));
                for (var x = 0; x <= gridView1.RowCount; x++)
                {
                    if (strr == gridView1.GetRowCellValue(x, "Item_Barcode"))
                    {
                        dtSalesReturn.Rows.Add(gridView1.GetRowCellValue(x, "Sales_Detail_ID"), gridView1.GetRowCellValue(x, "Sale_ID"), gridView1.GetRowCellValue(x, "Item_ID"), gridView1.GetRowCellValue(x, "Item_Name"), gridView1.GetRowCellValue(x, "Item_Barcode"), gridView1.GetRowCellValue(x, "Item_Sale_Price"), gridView1.GetRowCellValue(x, "PreQty"), gridView1.GetRowCellValue(x, "Amount"), gridView1.GetRowCellValue(x, "Total_Stock"), gridView1.GetRowCellValue(x, "Stock_ID"));
                    }
                }

                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
                count();
                TxtRecievePayment.Text = string.Empty;
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

        private void TxtInvoiceNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                e.Handled = true;
                btnGetInvoiceData_Click(sender,e);
            }
        }
        private void TxtInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.NumericCheck(e);
        }

        private void TxtRecievePayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.DecimalPointCheck(e);
        }

        private void RepTxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.DecimalPointCheck(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                var Rpt = new Reports.Sales.RptSalesInvoice();
                O_SalesReturn_Detail.Sales_Return_ID = (Int32)DalHandlar.AutoNumber<Models.Sales.Sales_Return_Detail>();
                V_Sales_Return_ID = O_SalesReturn_Detail.Sales_Return_ID;
                if (checkstock == true)
                {
                    O_StockDetail.Stock_Detail_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock_Detail>();
                    V_Stock_Detail_ID = O_StockDetail.Stock_Detail_ID;
                }
                var dtGridSave = new DataTable();

                dtGridSave = (DataTable)gridControl1.DataSource;

                if (dtGridSave != null)
                {
                    //if (Convert.ToDouble(TxtBalance.EditValue) >= 0)
                    //{
                        DalHandlar.RunQuery("Update Sales.Sales_Invoice Set  Customer_Type=" + Convert.ToInt32(LuECustomerType_ID.EditValue) + ",Customer_ID="+v_customerID+", Grand_Total=" + TxtGrandAmount.Text+ ",PaymentType_ID="+Convert.ToInt32(LuEPaymentType_ID.EditValue)+",CheckOrCreditNo="+TxtCheckOrCreditNo.Text+ ",Recievd_Amount=" + TxtRecievePayment.Text + ",TaxPercentage='"+TxtTaxPercentage.Text+ "',TaxAmount='"+TxtTaxAmount.Text+ "',ShopAmount='"+TxtShopAmount.Text+"',Invoice_Date='" + DtEInvoiceDate.DateTime.ToShortDateString() + "',Created_By ='" + TxtAdmin.Text + "',Created_Date='" + DateTime.Now.ToShortDateString() + "', IsReturn=1 where Invoice_No=" + TxtInvoiceNumber.Text);
                    if (TxtGetRegularCustomer.Text != "")
                    {
                        var dt = DalHandlar.RunQuery("select Balance from admin.Customer_Deffination where Customer_ID=" + TxtGetRegularCustomer.Text);
                        double previous_balanc = Convert.ToDouble(dt.Rows[0]["Balance"]);
                        double new_balance = Convert.ToDouble(TxtBalance.Text) + previous_balanc - Convert.ToDouble(TxtRecievePayment.Text);
                        DalHandlar.RunQuery("update admin.Customer_Deffination set Balance= " + new_balance + " where Customer_ID=" + v_customerID);
                    }
                    for (var x = 0; x <= dtGridSave.Rows.Count - 1; x++)
                        {
                            DalHandlar.RunQuery("Update Sales.Sales_Invoice_Detail Set Qty =" + dtGridSave.Rows[x]["Qty"] + ",Amount=" + dtGridSave.Rows[x]["Amount"] + ",Created_By='" + TxtAdmin.Text + "',Created_Date='" + DateTime.Now.ToShortDateString()+ "' where Sale_ID=" + dtGridSave.Rows[x]["Sale_ID"] + "AND Item_ID=" + dtGridSave.Rows[x]["Item_ID"]);

                            if (Convert.ToDecimal(dtGridSave.Rows[x]["PreQty"]) != Convert.ToDecimal(dtGridSave.Rows[x]["Qty"]))
                            {
                                decimal ReturnQty = 0;
                                decimal ReturnAmount = 0;
                                ReturnQty = Convert.ToDecimal(dtGridSave.Rows[x]["PreQty"]) - Convert.ToDecimal(dtGridSave.Rows[x]["Qty"]);
                                if (Convert.ToBoolean(dtGridSave.Rows[x]["IsPacked"]) == true)
                                {

                                   decimal   VarQty =ReturnQty / Convert.ToDecimal(dtGridSave.Rows[x]["Piece_Per_Pack"]);
                                   decimal   sum = ReturnQty - Convert.ToDecimal(Math.Truncate(Convert.ToDecimal(ReturnQty / Convert.ToDecimal(dtGridSave.Rows[x]["Piece_Per_Pack"]))) * Convert.ToDecimal(dtGridSave.Rows[x]["Piece_Per_Pack"]));

                                    ItemPackCheck = Convert.ToDouble(dtGridSave.Rows[x]["Pack_Price"]);
                                    ReturnAmount =Convert.ToDecimal(ItemPackCheck) * Math.Truncate(VarQty);

                                    if (sum > 0)
                                    {
                                        ReturnAmount = ReturnAmount + (Math.Truncate(sum) * Convert.ToDecimal(dtGridSave.Rows[x]["Item_Sale_Price"]));
                                    }
                                }
                                else
                                {
                                ReturnAmount = ReturnQty * Convert.ToDecimal(dtGridSave.Rows[x]["Item_Sale_Price"]);
                                }

                                DalHandlar.RunQuery("insert into Sales.Sales_Return_Detail(Sales_Return_ID,Sales_Detail_ID,Sale_ID,Item_ID,Item_Barcode,Qty,Unit_Price,Pack_Price,Amount,Created_By,Created_Date) Values(" + V_Sales_Return_ID + "," + dtGridSave.Rows[x]["Sales_Detail_ID"] + "," + dtGridSave.Rows[x]["Sale_ID"] + "," + dtGridSave.Rows[x]["Item_ID"] + ",'" + dtGridSave.Rows[x]["Item_Barcode"] + "'," + ReturnQty + "," + dtGridSave.Rows[x]["Item_Sale_Price"] + "," + dtGridSave.Rows[x]["Pack_Price"] + "," + ReturnAmount + ",'" + TxtAdmin.EditValue + "','" + DateTime.Now.ToShortDateString() + "')");

                                decimal TotalStock = 0;
                                TotalStock = ReturnQty + Convert.ToDecimal(dtGridSave.Rows[x]["Total_Stock"]);
                                if (checkstock == true)
                                {
                                    DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + TotalStock + ",Last_Updated='" + DateTime.Now.ToShortDateString() + "',Modify_By='" + TxtAdmin.EditValue + "'Where Item_Barcode='" + dtGridSave.Rows[x]["Item_Barcode"] + "'");


                                    DalHandlar.RunQuery("insert into Stock.Stock_Detail(Stock_Detail_ID,Stock_ID,Item_Barcode,Item_ID,Stock_In,Stock_Out,Remarks,Transaction_Date,Transaction_By) Values(" + V_Stock_Detail_ID + "," + dtGridSave.Rows[x]["Stock_ID"] + ",'" + dtGridSave.Rows[x]["Item_Barcode"] + "'," + dtGridSave.Rows[x]["Item_ID"] + "," + ReturnQty + "," + 0 + ",'" + "Return" + "','" + DateTime.Now.ToShortDateString() + "','" + TxtAdmin.EditValue + "')");
                                    V_Stock_Detail_ID++;
                                }
                                    
                                V_Sales_Return_ID++;
                            }
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invoice Required " + Convert.ToString((Convert.ToDecimal(TxtBalance.EditValue) * (-1))) + "RS More");
                    //}
                }
                else
                {
                    MessageBox.Show("There is no Data in Grid");
                }


                if (dtSalesReturn != null)
                {
                    for (var x = 0; x <= dtSalesReturn.Rows.Count - 1; x++)
                    {
                        //if (Convert.ToInt32(TxtBalance.EditValue) >= 0)
                        //{
                            DalHandlar.RunQuery("Delete Sales.Sales_Invoice_Detail  where Sale_ID=" + dtSalesReturn.Rows[x]["Sale_ID"] + "AND Item_ID=" + dtSalesReturn.Rows[x]["Item_ID"]);
                            DalHandlar.RunQuery("insert into Sales.Sales_Return_Detail(Sales_Return_ID,Sales_Detail_ID,Sale_ID,Item_ID,Item_Barcode,Qty,Unit_Price,Amount,Created_By,Created_Date) Values(" + V_Sales_Return_ID + "," + dtSalesReturn.Rows[x]["Sales_Detail_ID"] + "," + dtSalesReturn.Rows[x]["Sale_ID"] + "," + dtSalesReturn.Rows[x]["Item_ID"] + ",'" + dtSalesReturn.Rows[x]["Item_Barcode"] + "'," + dtSalesReturn.Rows[x]["Qty"] + "," + dtSalesReturn.Rows[x]["Unit_Price"] + "," + dtSalesReturn.Rows[x]["Amount"] + ",'" + TxtAdmin.EditValue + "','" + DateTime.Now.ToShortDateString() + "')");

                            decimal TotalStock = 0;
                            if (checkstock == true)
                            {
                                TotalStock = Convert.ToDecimal(dtSalesReturn.Rows[x]["Qty"]) + Convert.ToDecimal(dtGridSave.Rows[x]["Total_Stock"]);

                                DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + TotalStock + ",Last_Updated='" + DateTime.Now.ToShortDateString() + "',Modify_By='" + TxtAdmin.EditValue + "'Where Item_Barcode='" + dtGridSave.Rows[x]["Item_Barcode"] + "'");
                                DalHandlar.RunQuery("insert into Stock.Stock_Detail(Stock_Detail_ID,Stock_ID,Item_Barcode,Item_ID,Stock_In,Stock_Out,Transaction_Date,Transaction_By) Values(" + V_Stock_Detail_ID + "," + dtGridSave.Rows[x]["Stock_ID"] + ",'" + dtGridSave.Rows[x]["Item_Barcode"] + "'," + dtGridSave.Rows[x]["Item_ID"] + "," + Convert.ToDecimal(dtSalesReturn.Rows[x]["Qty"]) + "," + 0 + ",'" + DateTime.Now.ToShortDateString() + "','" + TxtAdmin.EditValue + "')");
                                V_Stock_Detail_ID++;
                            }
                            V_Sales_Return_ID++;
                      
                        MessageBox.Show("Saved Successfully");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Invoice Required " + Convert.ToString((Convert.ToDecimal(TxtBalance.EditValue) * (-1))) + "RS More");
                        //}
                    }
                }

                if (dtGridSave != null)
                {
                    if (Convert.ToDouble(TxtBalance.EditValue) >= 0)
                    {
                        dtGridSave.Columns.Add("GrandTotal", typeof(double));
                        dtGridSave.Columns.Add("RecievedCash", typeof(double));
                        dtGridSave.Columns.Add("TaxPercentage", typeof(double));
                        dtGridSave.Columns.Add("TaxAmount", typeof(double));
                        dtGridSave.Columns.Add("ShopAmount", typeof(double));
                        dtGridSave.Columns.Add("Balance", typeof(double));
                        dtGridSave.Columns.Add("InvoiceNumber", typeof(int));
                        dtGridSave.Columns.Add("Date", typeof(DateTime));
                        dtGridSave.Columns.Add("Created_By", typeof(string));
                        dtGridSave.Columns.Add("Customer", typeof(string));
                        dtGridSave.Columns.Add("TaxNumber", typeof(string));
                        dtGridSave.Columns.Add("Contact_Number", typeof(string));


                        foreach (DataRow dr in dtGridSave.Rows)
                        {
                            dr["GrandTotal"] = TxtGrandAmount.EditValue;
                            dr["RecievedCash"] = TxtRecievePayment.EditValue;
                            dr["TaxPercentage"] = TxtTaxPercentage.EditValue;
                            dr["TaxAmount"] = TxtTaxAmount.EditValue;
                            dr["ShopAmount"] = TxtShopAmount.EditValue;
                            dr["Balance"] = TxtBalance.EditValue;
                            dr["InvoiceNumber"] = TxtInvoiceNumber.EditValue;
                            dr["Date"] = DtEInvoiceDate.EditValue;
                            dr["Created_By"] = TxtAdmin.EditValue;
                            if (LuECustomerType_ID.Text == "Walking Customer")
                            {
                                dr["Customer"] = "Walking Customer" ;
                                dr["Contact_Number"] = "N/A";
                                dr["TaxNumber"] = "N/A";
                            }
                            else
                            {
                                dr["Customer"] = lblCustomerName.Text;
                                dr["Contact_Number"] = dtGetCustomer.Rows[0]["Contact_Number"].ToString();
                                dr["TaxNumber"] = dtGetCustomer.Rows[0]["TaxNumber"].ToString();
                            }
                           
                        }



                        if ((bool)Modules.General.dtsetting.Rows[0]["Setting_Value"]==true)
                        {
                            if (System.Windows.Forms.Application.OpenForms[2] != null)
                            {
                                var report = new Reports.Sales.RptSalesInvoice_A4();
                                report.DataSource = dtGridSave;

                                if ((bool)Modules.General.dtsetting.Rows[2]["Setting_Value"] == true)
                                {
                                    (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay(report, dtGridSave);
                                }
                                else
                                {
                                    report.Print();
                                }
                            }
                        }
                        else
                        {
                            if (System.Windows.Forms.Application.OpenForms[2] != null)
                            {

                                var report = new Reports.Sales.RptSalesInvoice();
                                report.DataSource = dtGridSave;
                                if ((bool)Modules.General.dtsetting.Rows[2]["Setting_Value"] == true)
                                {
                                    (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay(report, dtGridSave);
                                }
                                else
                                {
                                    report.Print();
                                }
                            }
                        }
                        dtGridSave.Clear();
                        gridControl1.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Found");

                    TxtInvoiceNumber.Enabled = true;
                    btnGetInvoiceData.Enabled = true;
                    lblCustomerName.Text="Name Of Customer";
                    btnNew.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = false;
                    btnExit.Enabled = true;
                }

                ControlDisabled();

                DtEInvoiceDate.EditValue = string.Empty;
                TxtInvoiceNumber.EditValue = string.Empty;
                TxtGrandAmount.EditValue = "0";
                TxtRecievePayment.EditValue = "0";
                TxtBalance.EditValue = "0";
                TxtCheckOrCreditNo.Text = "0";
                LuECustomerType_ID.Text = string.Empty;

                btnNew.Enabled = true;
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                btnExit.Enabled = true;

                gridControl1.DataSource = null;
                IsEdit = 0;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                O_SalesReturn_Detail.Sales_Return_ID = (Int32)DalHandlar.AutoNumber<Models.Sales.Sales_Return_Detail>();
                V_Sales_Return_ID = O_SalesReturn_Detail.Sales_Return_ID;

                O_StockDetail.Stock_Detail_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock_Detail>();
                V_Stock_Detail_ID = O_StockDetail.Stock_Detail_ID;

                var dtGridSave = new DataTable();

                dtGridSave = (DataTable)gridControl1.DataSource;

                if (dtGridSave != null)
                {
                    if (Convert.ToDouble(TxtBalance.EditValue) >= 0)
                    {
                        DalHandlar.RunQuery("Update Sales.Sales_Invoice Set Active=0 where Invoice_No=" + TxtInvoiceNumber.Text);

                        for (var x = 0; x <= dtGridSave.Rows.Count - 1; x++)
                        {
                            DalHandlar.RunQuery("Delete Sales.Sales_Invoice_Detail  where Sale_ID=" + dtGridSave.Rows[x]["Sale_ID"] + "AND Item_ID=" + dtGridSave.Rows[x]["Item_ID"]);
                            decimal ReturnQty = 0;
                            decimal ReturnAmount = 0;
                            ReturnQty = Convert.ToDecimal(dtGridSave.Rows[x]["Qty"]);

                            if (Convert.ToBoolean(dtGridSave.Rows[x]["IsPacked"]) == true)
                            {

                                decimal VarQty = ReturnQty / Convert.ToDecimal(dtGridSave.Rows[x]["Piece_Per_Pack"]);
                                decimal sum = ReturnQty - Convert.ToDecimal(Math.Truncate(Convert.ToDecimal(ReturnQty / Convert.ToDecimal(dtGridSave.Rows[x]["Piece_Per_Pack"]))) * Convert.ToDecimal(dtGridSave.Rows[x]["Piece_Per_Pack"]));

                                ItemPackCheck = Convert.ToDouble(dtGridSave.Rows[x]["Pack_Price"]);
                                ReturnAmount = Convert.ToDecimal(ItemPackCheck) * Math.Truncate(VarQty);

                                if (sum > 0)
                                {
                                    ReturnAmount = ReturnAmount + (Math.Truncate(sum) * Convert.ToDecimal(dtGridSave.Rows[x]["Item_Sale_Price"]));
                                }
                            }
                            else
                            {
                                ReturnAmount = ReturnQty * Convert.ToDecimal(dtGridSave.Rows[x]["Item_Sale_Price"]);
                            }

                            DalHandlar.RunQuery("insert into Sales.Sales_Return_Detail(Sales_Return_ID,Sales_Detail_ID,Sale_ID,Item_ID,Item_Barcode,Qty,Unit_Price,Amount,Created_By,Created_Date) Values(" + V_Sales_Return_ID + "," + dtGridSave.Rows[x]["Sales_Detail_ID"] + "," + dtGridSave.Rows[x]["Sale_ID"] + "," + dtGridSave.Rows[x]["Item_ID"] + ",'" + dtGridSave.Rows[x]["Item_Barcode"] + "'," + ReturnQty + "," + dtGridSave.Rows[x]["Item_Sale_Price"] + "," + ReturnAmount + ",'" + TxtAdmin.EditValue + "','" + DateTime.Now.ToShortDateString() + "')");
                            if (checkstock == true)
                            {
                                decimal TotalStock = 0;
                                TotalStock = ReturnQty + Convert.ToDecimal(dtGridSave.Rows[x]["Total_Stock"]);

                                DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + TotalStock + ",Last_Updated='" + DateTime.Now.ToShortDateString() + "',Modify_By='" + TxtAdmin.EditValue + "'Where Item_Barcode='" + dtGridSave.Rows[x]["Item_Barcode"] + "'");


                                DalHandlar.RunQuery("insert into Stock.Stock_Detail(Stock_Detail_ID,Stock_ID,Item_Barcode,Item_ID,Stock_In,Stock_Out,Transaction_Date,Transaction_By) Values(" + V_Stock_Detail_ID + "," + dtGridSave.Rows[x]["Stock_ID"] + ",'" + dtGridSave.Rows[x]["Item_Barcode"] + "'," + dtGridSave.Rows[x]["Item_ID"] + "," + ReturnQty + "," + 0 + ",'" + DateTime.Now.ToShortDateString() + "','" + TxtAdmin.EditValue + "')");
                                V_Stock_Detail_ID++;
                            }
                                V_Sales_Return_ID++;
                        }

                        ControlDisabled();
                        DtEInvoiceDate.EditValue = string.Empty;
                        TxtInvoiceNumber.EditValue = string.Empty;
                        TxtGrandAmount.EditValue = "0";
                        TxtRecievePayment.EditValue = "0";
                        TxtBalance.EditValue = "0";
                        LuECustomerType_ID.Text = string.Empty;
                        TxtCheckOrCreditNo.Text = "0";
                        lblCustomerName.Text="Name Of Customer";
                        

                        btnNew.Enabled = true;
                        btnEdit.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        btnCancel.Enabled = false;
                        btnExit.Enabled = true;

                        gridControl1.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Invoice Required " + Convert.ToString((Convert.ToDecimal(TxtBalance.EditValue) * (-1))) + "RS More");
                    }

                    MessageBox.Show("Return Successfully");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TxtInvoiceNumber.Enabled = true;
            btnGetInvoiceData.Enabled = true;
            TxtRecievePayment.Enabled = false;
            TxtInvoiceNumber.EditValue = string.Empty;
            LuECustomerType_ID.Text = string.Empty;

            lblCustomerName.Text="Name Of Customer";
            DtEInvoiceDate.EditValue = string.Empty;
            TxtGrandAmount.EditValue = "0";
            TxtRecievePayment.EditValue = "0";
            TxtBalance.EditValue = "0";
            TxtCheckOrCreditNo.Text = "0";
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnExit.Enabled = false;

            TxtInvoiceNumber.Focus();

            gridControl1.DataSource = null;
            dt = new DataTable();
            dtGetSalesDetail = new DataTable();
            dtGetSale = new DataTable();
            dtSalesReturn = new DataTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = 1;
           // ControlEnabled();
            TxtRecievePayment.Enabled = true;
            Qty.OptionsColumn.AllowEdit = true;

            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnExit.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            ControlDisabled();

            DtEInvoiceDate.EditValue = string.Empty;
            TxtInvoiceNumber.EditValue = string.Empty;
            LuECustomerType_ID.Text = string.Empty;
            TxtGrandAmount.EditValue = "0";
            TxtRecievePayment.EditValue = "0";
            TxtBalance.EditValue = "0";
            TxtCheckOrCreditNo.Text = "0";
            lblCustomerName.Text="Name Of Customer";
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnExit.Enabled = true;

            gridControl1.DataSource = null;
            IsEdit = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGetInvoiceData_Click(object sender, EventArgs e)
        {
            if (TxtInvoiceNumber.Text != string.Empty)
            {
                ResetDatagrid(Convert.ToString(TxtInvoiceNumber.EditValue));
            }
            else
            {
                MessageBox.Show("Enter Invoice Number");
            }
        }
        int IsEdit = 0;
        private void LuECustomerType_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (IsEdit == 1)
            {
                if (LuECustomerType_ID.Text == "Regular Customer")
                {

                    btnGetRegularCustomer.Enabled = true;
                    TxtGetRegularCustomer.Enabled = true;
                    lblCustomerName.Text = "Name of Custmer";
                }
                else
                {

                    btnGetRegularCustomer.Enabled = false;
                    TxtGetRegularCustomer.Enabled = false;
                    lblCustomerName.Text = "Name of Custmer";
                    TxtCheckOrCreditNo.Text = "0";
                    v_customerID = 0;

                }
            }
        }

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
                        var dtgetCustomer = DalHandlar.RunQuery("Select Customer_ID,Customer_Name from Admin.Customer_Deffination where Active=1 and Customer_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                        if (dtgetCustomer != null)
                        {
                            lblCustomerName.Text = Convert.ToString(dtgetCustomer.Rows[0]["Customer_Name"] + "(" + dtgetCustomer.Rows[0]["Customer_ID"] + ")");
                            v_customerID = Convert.ToInt32(dtgetCustomer.Rows[0]["Customer_ID"].ToString());
                        }
                    }
                }
            }
        }

        private void TxtGetRegularCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtGetRegularCustomer.Text != null)
            {
                int CalLengnth = Convert.ToInt32(TxtGetRegularCustomer.Text.Length);
                if (CalLengnth <= 7 && TxtGetRegularCustomer.Text != string.Empty)
                {
                    var dtgetCustomer = DalHandlar.RunQuery("Select Customer_ID,Customer_Name from Admin.Customer_Deffination where Active=1 and Customer_ID=" + Convert.ToInt32(TxtGetRegularCustomer.Text));
                    if (dtgetCustomer != null)
                    {
                        lblCustomerName.Text = Convert.ToString(dtgetCustomer.Rows[0]["Customer_Name"] + "(" + dtgetCustomer.Rows[0]["Customer_ID"] + ")");
                        v_customerID = Convert.ToInt32(dtgetCustomer.Rows[0]["Customer_ID"].ToString());

                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Customer Not Found");
                    }

                }
                else
                {
                    if (TxtGetRegularCustomer.Text != string.Empty)
                    {
                        var dtgetCustomer = DalHandlar.RunQuery("Select Customer_ID,Customer_Name from Admin.Customer_Deffination where Active=1 and Contact_Number=" + TxtGetRegularCustomer.Text);
                        if (dtgetCustomer != null)
                        {
                            lblCustomerName.Text = Convert.ToString(dtgetCustomer.Rows[0]["Customer_Name"] + "(" + dtgetCustomer.Rows[0]["Customer_ID"] + ")");
                            v_customerID = Convert.ToInt32(dtgetCustomer.Rows[0]["Customer_ID"].ToString());

                        }
                        else
                        {
                            MessageBox.Show("Invalid Cell Number Customer Not Found");
                        }
                    }
                }
            }
        }

        private void TxtGetRegularCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.NumericCheck(e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtGrandAmount_EditValueChanged(object sender, EventArgs e)
        {
            DataTable vat = DalHandlar.RunQuery("select Setting_Text from admin.Setting where SettingID =7");
            TxtTaxPercentage.Text = vat.Rows[0]["Setting_Text"].ToString();
            if (TxtGrandAmount.Text != "")
            {
                double grandamount = Convert.ToDouble(TxtGrandAmount.Text);
                TxtTaxAmount.Text = ((Convert.ToDouble(TxtTaxPercentage.Text)/100) * grandamount).ToString();
                TxtShopAmount.Text = Math.Round((grandamount + Convert.ToDouble(TxtTaxAmount.Text)), 2).ToString();

            }
        }

        private void LuEPaymentType_ID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SwitchLanguage()
        {
            if (General.culture != null)
            {
                this.Text = General.resourceManager.GetString("frmSalesInvoices", General.culture);
                lblSalesReturn.Text = General.resourceManager.GetString("lblSalesInvoice", General.culture);
                TPSalesReturn.Text = General.resourceManager.GetString("lblSalesInvoice", General.culture);
                lblInvoiceNumber.Text = General.resourceManager.GetString("lblInvoiceNumber", General.culture);
                lblCellNo.Text = General.resourceManager.GetString("lblCodeNo", General.culture);
                lblDate.Text = General.resourceManager.GetString("lblDate", General.culture);
                lblCustName.Text = General.resourceManager.GetString("lblRegCustomerName", General.culture);
                lblCustomerBalance.Text = General.resourceManager.GetString("lblCustomerBalance", General.culture);
                lblUser.Text = General.resourceManager.GetString("lblUser", General.culture);
                lblGrandAmount.Text = General.resourceManager.GetString("lblGrandAmount", General.culture);
                lblPaymentType.Text = General.resourceManager.GetString("lblPaymentType", General.culture);
                lblCardNo.Text = General.resourceManager.GetString("lblCardNo", General.culture);
                lblReceivedAmount.Text = General.resourceManager.GetString("lblReceivedAmount", General.culture);
                lblTax.Text = General.resourceManager.GetString("lblTax", General.culture);
                lblTaxAmount.Text = General.resourceManager.GetString("lblTaxAmount", General.culture);
                lblShopAmount.Text = General.resourceManager.GetString("lblShopAmount", General.culture);
                lblCustomerName.Text = General.resourceManager.GetString("lblCustomerName", General.culture);

                gridView1.Columns["Item_Barcode"].Caption = General.resourceManager.GetString("Item_Barcode", General.culture);
                gridView1.Columns["Item_Name"].Caption = General.resourceManager.GetString("Item_Name", General.culture);
                gridView1.Columns["Item_Sale_Price"].Caption = General.resourceManager.GetString("Item_Sale_Price", General.culture);
                gridView1.Columns["Pack_Price"].Caption = General.resourceManager.GetString("PackPrice", General.culture);
                gridView1.Columns["Qty"].Caption = General.resourceManager.GetString("Qty", General.culture);
                gridView1.Columns["Amount"].Caption = General.resourceManager.GetString("Item_Amount", General.culture);

                btnGetInvoiceData.Text = General.resourceManager.GetString("BtnFind", General.culture);
                btnGetRegularCustomer.Text = General.resourceManager.GetString("BtnFind", General.culture);
                btnSave.Text = General.resourceManager.GetString("BtnSave", General.culture);
                btnCancel.Text = General.resourceManager.GetString("BtnCancel", General.culture);
                btnExit.Text = General.resourceManager.GetString("btnExit", General.culture);

                btnNew.Text = General.resourceManager.GetString("BtnNew", General.culture);
                btnSave.Text = General.resourceManager.GetString("BtnSave", General.culture);
                btnEdit.Text = General.resourceManager.GetString("BtnEdit", General.culture);
                btnDelete.Text = General.resourceManager.GetString("BtnDelete", General.culture);
            }
        }

        private void RPTUnitPrice_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
