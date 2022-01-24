using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace POS_Software.Forms.Stock
{
    public partial class FrmStock : DevExpress.XtraEditors.XtraForm
    {
        public FrmStock()
        {
            InitializeComponent();
            da = DalHandlar.cn.Adapter();
        }
        private IDbDataAdapter da;
        DataTable DtShowStockDetail = new DataTable();
        private Models.Stock.Stock O_Stock = new Models.Stock.Stock();
        private Models.Stock.Stock_Detail O_StockDetail = new Models.Stock.Stock_Detail();
        // private Models.Stock.VendorStockPayment_Detail o_Vendor_Stock_Detail = new Models.Stock.VendorStockPayment_Detail();

        void GridBind()
        {
            var dt = new DataTable();

            dt.Columns.Add("Stock_Detail_ID", typeof(int));
            dt.Columns.Add("Stock_ID", typeof(int));
            dt.Columns.Add("Item_Barcode", typeof(string));
            dt.Columns.Add("Item_ID", typeof(int));
            dt.Columns.Add("Item_Name", typeof(string));
            dt.Columns.Add("Stock_In", typeof(decimal));
            dt.Columns.Add("Total_Stock", typeof(decimal));
            dt.Columns.Add("Transaction_Date", typeof(DateTime));
            dt.Columns.Add("Transaction_By", typeof(string));
            dt.Columns.Add("Stock_Status", typeof(string));
            gridControl2.DataSource = dt;

            var dt2 = new DataTable();

            dt2.Columns.Add("Stock_Detail_ID", typeof(int));
            dt2.Columns.Add("Stock_ID", typeof(int));
            dt2.Columns.Add("Item_Barcode", typeof(string));
            dt2.Columns.Add("Item_ID", typeof(int));
            dt2.Columns.Add("Item_Name", typeof(string));
            dt2.Columns.Add("Stock_Out", typeof(decimal));
            dt2.Columns.Add("Remarks", typeof(decimal));
            dt2.Columns.Add("Transaction_Date", typeof(DateTime));
            dt2.Columns.Add("Transaction_By", typeof(string));
            gridControl3.DataSource = dt2;

            var dt3 = new DataTable();

            dt3.Columns.Add("Stock_Detail_ID", typeof(int));
            dt3.Columns.Add("Stock_ID", typeof(int));
            dt3.Columns.Add("Item_Barcode", typeof(string));
            dt3.Columns.Add("Item_ID", typeof(int));
            dt3.Columns.Add("Item_Name", typeof(string));
            dt3.Columns.Add("Stock_In", typeof(decimal));
            dt3.Columns.Add("Remarks", typeof(decimal));
            dt3.Columns.Add("Transaction_Date", typeof(DateTime));
            dt3.Columns.Add("Transaction_By", typeof(string));
            gridControl1.DataSource = dt3;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            GridBind();
            btnSave.Enabled = false;
        }

        public void ResetDatagrid(string KeyValue)
        {
            if (!string.IsNullOrEmpty(KeyValue))
            {

                gridControl2.DataSource = DalHandlar.InitializeDataGrid(@"Select VSP.VendorStockPayment_Detail_ID, S.Stock_ID,SD.Stock_Detail_ID,S.Item_ID,S.Item_Barcode,
                                                                        Case when Size_Name='None' then ID.Item_Name else ID.Item_Name+' ' + Sz.Size_Name End as Item_Name,
                                                                        SD.Stock_In,S.Total_Stock,SD.Remarks,SD.Transaction_Date,SD.Transaction_By
                                                                        from stock.VendorStockPayment_Detail as VSP
                                                                        Left Join Stock.Stock_Detail as SD on VSP.VendorStockPayment_Detail_ID=SD.Stock_Detail_ID
                                                                        Left Join Stock.Stock as S on SD.Stock_ID=S.Stock_ID
                                                                        Left Join Admin.Items_Deffination as ID on S.Item_ID=ID.Item_ID
                                                                        Left Join Admin.Sizes as Sz on ID.Item_Size_ID=Sz.Size_ID Where VSP.VendorStockPayment_Detail_ID= " + KeyValue, DtShowStockDetail, da);
            }
            else
            {
                MessageBox.Show("Invoice not Exist");
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
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
                    Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No','Name'", false, "1");
                    if (Dt != null)
                    {
                        var dtgetBarcode = DalHandlar.RunQuery("Select Item_ID,Item_Barcode from Admin.Items_Deffination where Active=1 and Item_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                        if (dtgetBarcode != null)
                        {
                            TxtBarcode.EditValue = Convert.ToString(dtgetBarcode.Rows[0][1]);
                            TxtQty.Focus();
                        }
                    }
                }
            }
        }

        private int BarcodeCheck = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dtItems = new DataTable();
            dtItems = DalHandlar.RunQuery(@"Select * from Stock.VwGetTotalStock where Item_Barcode = '" + TxtBarcode.Text + "'");
            if (dtItems != null)
            {

                for (var x = 0; x <= gridView2.RowCount; x++)
                {
                    var barcode2 = Convert.ToString(gridView2.GetRowCellValue(x, "Item_Barcode"));
                    if (TxtBarcode.Text == barcode2)
                    {
                        gridView2.SetRowCellValue(x, "Stock_In", Convert.ToDecimal(Convert.ToDecimal(TxtQty.Text) + Convert.ToDecimal(gridView2.GetRowCellValue(x, "Stock_In"))));
                        gridView2.SetRowCellValue(x, "Total_Stock", Convert.ToDecimal(Convert.ToDecimal(TxtQty.Text) + Convert.ToDecimal(gridView2.GetRowCellValue(x, "Total_Stock"))));
                        gridView2.SetRowCellValue(x, "Transaction_Date", DateTime.Now);
                        gridView2.SetRowCellValue(x, "Transaction_By", "User");
                        gridView2.UpdateCurrentRow();
                        BarcodeCheck = 1;
                        TxtBarcode.Text = string.Empty;
                        TxtQty.Text = string.Empty;
                        TxtBarcode.Focus();
                        break;

                    }
                    else
                    {
                        BarcodeCheck = 0;
                    }
                }

                if (BarcodeCheck == 0)
                {
                    gridView2.AddNewRow();
                    gridView2.SetFocusedRowCellValue("Stock_Detail_ID", O_StockDetail.Stock_Detail_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock_Detail>());
                    gridView2.SetFocusedRowCellValue("Item_ID", dtItems.Rows[0]["Item_ID"]);
                    gridView2.SetFocusedRowCellValue("Item_Barcode", dtItems.Rows[0]["Item_Barcode"]);
                    gridView2.SetFocusedRowCellValue("Item_Name", dtItems.Rows[0]["Item_Name"]);
                    gridView2.SetFocusedRowCellValue("Stock_In", TxtQty.Text);
                    gridView2.SetFocusedRowCellValue("Total_Stock", Convert.ToDecimal(TxtQty.Text) + Convert.ToDecimal(dtItems.Rows[0]["Total_Stock"]));
                    gridView2.SetFocusedRowCellValue("Transaction_Date", DateTime.Now);
                    gridView2.SetFocusedRowCellValue("Transaction_By", "Admin");
                    gridView2.SetFocusedRowCellValue("Stock_Status", Convert.ToDecimal(dtItems.Rows[0]["Total_Stock"]));
                    gridView2.SetFocusedRowCellValue("Stock_ID", Convert.ToDecimal(dtItems.Rows[0]["Stock_ID"]));
                    gridView2.UpdateCurrentRow();

                }
                TxtBarcode.Text = string.Empty;
                TxtQty.Text = string.Empty;
                btnFind.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                var view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);

                if (gridView2.RowCount <= 0)
                {
                    btnSave.Enabled = false;

                }
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                gridView2.SetFocusedRowCellValue("Total_Stock", Convert.ToDouble(gridView2.GetFocusedRowCellValue("Total_Stock")) - Convert.ToDouble(gridView2.GetFocusedRowCellValue("Stock_In")));
                TxtQty.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("Stock_In"));
                TxtBarcode.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("Item_Barcode"));
                gridView2.SetFocusedRowCellValue("Stock_In", 0);

                btnFind.Enabled = false;
                btnSave.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int v_StocKID = 0;
            for (int x = 0; x <= gridView2.RowCount - 1; x++)
            {
                if (Convert.ToString(gridView2.GetRowCellValue(x,"Stock_Status")) == "0")
                {
                    v_StocKID = O_Stock.Stock_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock>();
                    DalHandlar.RunQuery("Insert into Stock.Stock(Stock_ID,Item_Barcode,Item_ID,Total_Stock,Last_Updated,Modify_By) Values(" + v_StocKID + ",'" + gridView2.GetRowCellValue(x, "Item_Barcode") + "'," + gridView2.GetRowCellValue(x, "Item_ID") + "," + gridView2.GetRowCellValue(x, "Total_Stock") + ",'" + DateTime.Now.ToShortDateString() + "','" + gridView2.GetRowCellValue(x, "Transaction_By") + "')");
                }
                else
                {
                    v_StocKID = Convert.ToInt32(gridView2.GetRowCellValue(x, "Stock_ID"));
                    DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + gridView2.GetRowCellValue(x, "Total_Stock") + ",Last_Updated='" + DateTime.Now.ToShortDateString() + "',Modify_By='" + gridView2.GetRowCellValue(x, "Transaction_By") + "'Where Item_Barcode='" + gridView2.GetRowCellValue(x, "Item_Barcode") + "'");
                }
                O_StockDetail.Stock_Detail_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock_Detail>();

                DalHandlar.RunQuery("INSERT INTO Stock.Stock_Detail(Stock_Detail_ID,Stock_ID,Item_Barcode,Item_ID,Stock_In,Stock_Out,Remarks,Transaction_Date,Transaction_By)VALUES(" + O_StockDetail.Stock_Detail_ID + "," + v_StocKID + ",'" + gridView2.GetRowCellValue(x, "Item_Barcode") + "'," + gridView2.GetRowCellValue(x, "Item_ID") + "," + gridView2.GetRowCellValue(x, "Stock_In") + "," + 0 + ",'" +"In"+ "','" + DateTime.Now.ToShortDateString() + "','" + gridView2.GetRowCellValue(x, "Transaction_By") + "')");
            }
            MessageBox.Show("Stock Added Successfully");
            Modules.General.dtItemSearch = DalHandlar.RunQuery("select * from Admin.VwItemSearch where Active='True'");
            gridControl1.DataSource = null;
            GridBind();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // End of Stock Form

        private void TabPageAddStock_Click(object sender, EventArgs e)
        {
            GetStockOutByBarcode(string.Empty, DateTime.Now, DateTime.Now, 0);

            GetStockinByBarcode(string.Empty, DateTime.Now, DateTime.Now, 0);
        }
      
        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.AlphaNumericCheck(e);
        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.DecimalPointCheck(e);
        }

        private void FrmStock_KeyDown(object sender, KeyEventArgs e)
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
                        Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No','Name'", false, "1");
                        if (Dt != null)
                        {
                            var dtgetBarcode = DalHandlar.RunQuery(@"Select Item_ID,Item_Barcode from Admin.Items_Deffination
                                                                   where Active=1 and Item_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                            if (dtgetBarcode != null)
                            {
                                TxtBarcode.EditValue = Convert.ToString(dtgetBarcode.Rows[0][1]);
                                TxtQty.Focus();
                            }
                        }
                    }
                }
            }
        }

        //Tab page StockIN Start
        void GetStockinByBarcode(string value, DateTime FromDate,DateTime ToDate ,int flag)
        {
            DataTable GetStcokInData = new DataTable();
            string Query = string.Empty;
            switch (flag)
            {
                case 1:
                    Query = (@"Select * from Stock.VwStockDetail where Item_ID=" + value +"order by Stock_Detail_ID desc");
                    GetStcokInData = DalHandlar.RunQuery(Query);
                    if (GetStcokInData != null)
                    { TxtStockInBarCode.Text = GetStcokInData.Rows[0][2].ToString(); }
                    break;
                case 2:
                    if (value != string.Empty)
                    {

                        Query = (@"Select * from Stock.VwStockDetail where Item_Barcode='" + value + "' AND DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date)) between DATEADD(D, 0, DATEDIFF(D, 0, '" + FromDate + "')) and DATEADD(D, 0, DATEDIFF(D, 0, '" + ToDate + "')) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                        if (GetStcokInData != null)
                        { TxtStockInBarCode.Text = GetStcokInData.Rows[0][2].ToString(); }
                    }
                    else
                    {
                        Query = (@"Select * from Stock.VwStockDetail where DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date)) between DATEADD(D, 0, DATEDIFF(D, 0, '" + FromDate + "')) and DATEADD(D, 0, DATEDIFF(D, 0, '" + ToDate + "')) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                    }
                    break;
                case 3:
                    if (value != string.Empty)
                    {

                        Query = (@"Select * from Stock.VwStockDetail where Item_Barcode='" + value + "' AND  DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date))=DATEADD(D, 0, DATEDIFF(D, 0, GETDATE()-1)) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                        if (GetStcokInData != null)
                        { TxtStockInBarCode.Text = GetStcokInData.Rows[0][2].ToString(); }
                    }
                    else
                    {
                        Query = (@"Select * from Stock.VwStockDetail where     DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date))=DATEADD(D, 0, DATEDIFF(D, 0, GETDATE()-1)) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                    }
                    break;
                case 4:
                    Query = (@"Select * from Stock.VwStockDetail where Item_ID=" + value + "order by Stock_Detail_ID desc");
                    GetStcokInData = DalHandlar.RunQuery(Query);
                    if (GetStcokInData != null)
                    { TxtStockInBarCode.Text = GetStcokInData.Rows[0][2].ToString(); }
                    break;
                default:
                    {
                        GetStcokInData = DalHandlar.RunQuery("Select * from Stock.VwStockDetail order by Stock_Detail_ID desc");
                    }
                    break;
            }

            if (GetStcokInData != null)
            {
                gridControl1.DataSource = GetStcokInData;
                gridView1.BestFitColumns();
            }
            else
            {
            gridControl1.DataSource = null;
            }
        }

        private void btnStockInSearch_Click(object sender, EventArgs e)
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
                    Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No','Name'", false, "1");
                    if (Dt != null)
                    {
                        GetStockinByBarcode(Convert.ToString(Dt.Rows[0][0]),DateTime.Now,DateTime.Now,1);

                            //string expression = "Item_ID=" + Dt.Rows[0][0].ToString();
                            //var filteredData = new DataTable();
                            //filteredData = dtgetBarcode.Select(expression).CopyToDataTable();

                            ////filteredData = filteredData.Select("Transaction_Date= 11/22/2017 1:38:00 PM").CopyToDataTable();
                    }
                }
            }
        }
        private void TxtStockInBarCode_Leave(object sender, EventArgs e)
        {
            if (TxtStockInBarCode.Text != string.Empty)
            {
                GetStockinByBarcode(TxtStockInBarCode.Text, DateTime.Now, DateTime.Now, 4);
            }
        }


        private void btnStockInToday_Click(object sender, EventArgs e)
        {
            GetStockinByBarcode(TxtStockInBarCode.Text, DateTime.Now,DateTime.Now , 2);
        }

        private void btnStockInBetweenDates_Click(object sender, EventArgs e)
        {
            if (DtEStockInFromDate.Text != string.Empty && DtEStockInToDate.Text != string.Empty)
            {
                GetStockinByBarcode(TxtStockInBarCode.Text, Convert.ToDateTime(DtEStockInFromDate.Text), Convert.ToDateTime(DtEStockInToDate.Text), 2);
            }
        }

        private void btnStockInYesterday_Click(object sender, EventArgs e)
        {
            GetStockinByBarcode(TxtStockInBarCode.Text, DateTime.Now.AddDays(-1), DateTime.Now, 3);
        }

        private void btnStockInDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && Del == 1)
            {
                DialogResult result3 = MessageBox.Show("Are You Sure You want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result3 == DialogResult.Yes)
                {

                    if (gridView1.RowCount > 0 && gridView1.GetFocusedRowCellValue("Remarks").ToString()!="Return")
                    {
                        var dtGetStock = DalHandlar.RunQuery("select Item_Barcode,Item_ID,Total_Stock from Stock.Stock where Item_ID=" + Convert.ToInt32(gridView1.GetFocusedRowCellValue("Item_ID")));

                        decimal totalSTock = Convert.ToDecimal(dtGetStock.Rows[0]["Total_Stock"]) - Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Stock_In")); ;
                        DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + totalSTock + ",Last_Updated='" + DateTime.Now + "',Modify_By='" + "Admin" + "' Where Item_ID='" + gridView1.GetFocusedRowCellValue("Item_ID") + "'");
                        DalHandlar.RunQuery("Delete Stock.Stock_Detail where Item_ID=" + Convert.ToInt32(gridView1.GetFocusedRowCellValue("Item_ID")) + "AND Stock_Detail_ID=" + gridView1.GetFocusedRowCellValue("Stock_Detail_ID"));
                        MessageBox.Show("Delete Successfully");
                        GetStockinByBarcode(string.Empty, DateTime.Now, DateTime.Now, 0);
                        Modules.General.dtItemSearch = DalHandlar.RunQuery("select * from Admin.VwItemSearch where Active='True'");
                        Del = 0;
                    }
                    else
                    {

                        MessageBox.Show("Return Stock Can not be Deleted");
                    }

                }
            }
        }
        //Tab Page Stock In End

        //Tab Page Stock Out Start
        void GetStockOutByBarcode(string value, DateTime FromDate, DateTime ToDate, int flag)
        {
            DataTable GetStcokInData = new DataTable();
            string Query = string.Empty;
            switch (flag)
            {
                case 1:
                    Query = (@"Select * from Stock.VwStockOutDetail where Item_ID=" + value +" order by Stock_Detail_ID desc");
                    GetStcokInData = DalHandlar.RunQuery(Query);
                    if (GetStcokInData != null)
                    { TxtScanBarcodeStockOut.Text = GetStcokInData.Rows[0][2].ToString(); }
                    break;
                case 2:
                    if (value != string.Empty)
                    {
                        Query = (@"Select * from Stock.VwStockOutDetail where Item_Barcode='" + value + "' AND DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date)) between DATEADD(D, 0, DATEDIFF(D, 0, '" + FromDate + "')) and DATEADD(D, 0, DATEDIFF(D, 0, '" + ToDate + "')) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                        if (GetStcokInData != null)
                        { TxtStockInBarCode.Text = GetStcokInData.Rows[0][2].ToString(); }
                    }
                    else
                    {
                        Query = (@"Select * from Stock.VwStockOutDetail where DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date)) between DATEADD(D, 0, DATEDIFF(D, 0, '" + FromDate + "')) and DATEADD(D, 0, DATEDIFF(D, 0, '" + ToDate + "')) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                    }
                    break;
                case 3:
                    if (value != string.Empty)
                    {

                        Query = (@"Select * from Stock.VwStockOutDetail where Item_Barcode='" + value + "' AND     DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date))=DATEADD(D, 0, DATEDIFF(D, 0, GETDATE()-1)) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                        if (GetStcokInData != null)
                        { TxtStockInBarCode.Text = GetStcokInData.Rows[0][2].ToString(); }
                    }
                    else
                    {
                        Query = (@"Select * from Stock.VwStockOutDetail where     DATEADD(D, 0, DATEDIFF(D, 0, Transaction_Date))=DATEADD(D, 0, DATEDIFF(D, 0, GETDATE()-1)) order by Stock_Detail_ID desc");
                        GetStcokInData = DalHandlar.RunQuery(Query);
                    }
                    break;
                case 4:
                    Query = (@"Select * from Stock.VwStockOutDetail where Item_Barcode=" + value + " order by Stock_Detail_ID desc");
                    GetStcokInData = DalHandlar.RunQuery(Query);
                    if (GetStcokInData != null)
                    { TxtScanBarcodeStockOut.Text = GetStcokInData.Rows[0][2].ToString(); }
                    break;
                default:
                    {
                        GetStcokInData = DalHandlar.RunQuery("Select * from Stock.VwStockOutDetail order by Stock_Detail_ID desc");
                    }
                    break;
            }

            if (GetStcokInData != null)
            {
                gridControl3.DataSource = GetStcokInData;
                gridView3.BestFitColumns();
            }
            else
            {
                gridControl3.DataSource = null;
            }
        }
        private void BtnStockOutFind_Click(object sender, EventArgs e)
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
                    Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No','Name'", false, "1");
                    if (Dt != null)
                    {
                        GetStockOutByBarcode(Convert.ToString(Dt.Rows[0][0]), DateTime.Now,DateTime.Now , 1);
                    }
                }
            } 
        }
        private void btnBetweenDate_Click(object sender, EventArgs e)
        {
            if (DtEFrom.Text != string.Empty && DtETo.Text != string.Empty)
            {
                GetStockOutByBarcode(TxtStockInBarCode.Text, Convert.ToDateTime(DtEFrom.Text), Convert.ToDateTime(DtETo.Text), 2);
            }
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            GetStockOutByBarcode(TxtScanBarcodeStockOut.Text, DateTime.Now, DateTime.Now, 2);
        }
        private void btnYesterday_Click(object sender, EventArgs e)
        {
            GetStockOutByBarcode(TxtScanBarcodeStockOut.Text, DateTime.Now.AddDays(-1), DateTime.Now, 3);
        }
        int Del = 0;

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            Del = 1;
        }
        private void TxtScanBarcodeStockOut_Leave(object sender, EventArgs e)
        {
            if (TxtScanBarcodeStockOut.Text != string.Empty)
            {
                GetStockOutByBarcode(TxtScanBarcodeStockOut.Text, DateTime.Now, DateTime.Now, 4);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GetStockOutByBarcode(string.Empty, DateTime.Now, DateTime.Now, 5);
            TxtScanBarcodeStockOut.Text = string.Empty;
            DtEFrom.Text = string.Empty;
            DtETo.Text = string.Empty;
        }

        private void btnClearStockIn_Click(object sender, EventArgs e)
        {
            GetStockinByBarcode(string.Empty, DateTime.Now, DateTime.Now, 5);
            TxtStockInBarCode.Text = string.Empty;
            DtEStockInFromDate.Text = string.Empty;
            DtEStockInToDate.Text = string.Empty;
            Del = 0;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
        //Tab Page Stock Out End
    }
}
