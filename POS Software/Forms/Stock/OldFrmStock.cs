using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace POS_Software.Forms.Stock
{
    public partial class OldFrmStock : DevExpress.XtraEditors.XtraForm
    {
        public OldFrmStock()
        {
            InitializeComponent();
        }

        private Models.Stock.Stock O_Stock = new Models.Stock.Stock();
        private Models.Stock.Stock_Detail O_StockDetail = new Models.Stock.Stock_Detail();

        private void OldFrmStock_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();

            dt.Columns.Add("Stock_ID", typeof(int));
            dt.Columns.Add("Item_ID", typeof(int));
            dt.Columns.Add("Item_Barcode", typeof(string));
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("Total_Stock", typeof(decimal));
            dt.Columns.Add("Last_Updated", typeof(DateTime));
            dt.Columns.Add("Modify_By", typeof(string));
            gridControl1.DataSource = dt;

            var dt2 = new DataTable();

            dt2.Columns.Add("Stock_Detail_ID", typeof(int));
            dt2.Columns.Add("Stock_ID", typeof(int));
            dt2.Columns.Add("Item_Barcode", typeof(string));
            dt2.Columns.Add("Item_ID", typeof(int));
            dt2.Columns.Add("ItemName", typeof(string));
            dt2.Columns.Add("Stock_In", typeof(decimal));
            dt2.Columns.Add("Transaction_Date", typeof(DateTime));
            dt2.Columns.Add("Transaction_By", typeof(string));

            gridControl1.DataSource = dt2;

            var dt3 = new DataTable();

            dt3.Columns.Add("Stock_Detail_ID", typeof(int));
            dt3.Columns.Add("Stock_ID", typeof(int));
            dt3.Columns.Add("Item_Barcode", typeof(string));
            dt3.Columns.Add("Item_ID", typeof(int));
            dt3.Columns.Add("ItemName", typeof(string));
            dt3.Columns.Add("Stock_Out", typeof(decimal));
            dt3.Columns.Add("Transaction_Date", typeof(DateTime));
            dt3.Columns.Add("Transaction_By", typeof(string));
        }

        public void ResetDatagrid2(string KeyValue)
        {
            gridControl2.DataSource = null;
            var dt2 = new DataTable();
            dt2 = DalHandlar.RunQuery(@"select top 10 SD.Stock_Detail_ID,SD.Stock_ID,SD.Item_Barcode,SD.Item_ID,
                                      Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as ItemName, SD.Stock_In,SD.Transaction_Date,SD.Transaction_By
                                      from Stock.Stock_Detail as SD 
                                      Left Join admin.Items_Deffination as ID on SD.Item_ID=ID.Item_ID
                                      Left Join admin.Sizes as its on ID.Item_Size_ID=its.Size_ID where SD.Item_Barcode='" + TxtBarcode.EditValue + "' and SD.Stock_In!=0 order by SD.Stock_Detail_ID desc");

            if (dt2 != null)
            {
                gridControl2.DataSource = dt2;
            }
        }

        private int check = 0;
        private void TxtBarcode_Leave(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
            var dt = new DataTable();
            var dt2 = new DataTable();
            dt = DalHandlar.RunQuery(@"Select * from Stock.VwGetTotalStock where Item_Barcode = '" + TxtBarcode.EditValue + "'");
            dt2 = DalHandlar.RunQuery(@"Select  top 10 * from Stock.VwStockDetail where Stock_In!=0 and Item_Barcode = '" + TxtBarcode.EditValue + "'order by Stock_Detail_ID desc");

            if (dt != null)
            {
                gridControl1.DataSource = dt;
                gridControl2.DataSource = dt2;

                ResetDatagrid2(Convert.ToString(TxtBarcode.EditValue));
                if (dt.Rows.Count > 0)
                {
                    check = 1;
                }
                else
                {
                    check = 0;
                }
            }
            else
            {
                check = 0;
            }
        }
        private double Qty = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                if (check == 0)
                {
                    gridControl1.DataSource = null;
                    O_Stock.Stock_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock>();
                    var dt = new DataTable();

                    dt = DalHandlar.RunQuery(@"select ID.Item_Barcode,ID.Item_ID,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as ItemName from Admin.Items_Deffination as ID 
                                             Left Join Admin.Sizes as Its on ID.Item_Size_ID=Its.Size_ID 
                                             where ID.Item_Barcode='" + TxtBarcode.EditValue + "'");

                    if (dt != null)
                    {
                        dt.Columns.Add("Stock_ID", typeof(int));
                        dt.Columns.Add("Total_Stock", typeof(decimal));
                        dt.Columns.Add("Last_Updated", typeof(DateTime));
                        dt.Columns.Add("Modify_By", typeof(string));

                        foreach (DataRow dr in dt.Rows)
                        {
                            dr["Stock_ID"] = O_Stock.Stock_ID;
                            dr["Total_Stock"] = TxtQty.EditValue;
                            dr["Last_Updated"] = DateTime.Now;
                            dr["Modify_By"] = Convert.ToString("Admin");
                        }

                        gridControl1.DataSource = dt;
                        check = 1;

                        O_Stock.Stock_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock>();
                        DalHandlar.RunQuery("Insert into Stock.Stock(Stock_ID,Item_Barcode,Item_ID,Total_Stock,Last_Updated,Modify_By) Values(" + O_Stock.Stock_ID + ",'" + gridView1.GetRowCellValue(0, "Item_Barcode") + "'," + gridView1.GetRowCellValue(0, "Item_ID") + "," + gridView1.GetRowCellValue(0, "Total_Stock") + ",'" + DateTime.Now + "','" + "Admin" + "')");
                    }
                    else
                    {
                        MessageBox.Show("Item Not Found");
                    }
                }
                else
                {
                    Qty = Convert.ToDouble(gridView1.GetRowCellValue(0, "Total_Stock"));
                    Qty = Qty + Convert.ToDouble(TxtQty.EditValue);
                    gridView1.SetRowCellValue(0, "Total_Stock", Qty);
                    gridView1.UpdateCurrentRow();

                    DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + gridView1.GetRowCellValue(0, "Total_Stock") + ",Last_Updated='" + DateTime.Now + "',Modify_By='" + "Admin" + "'Where Item_Barcode='" + gridView1.GetRowCellValue(0, "Item_Barcode") + "'");
                    check = 0;
                }

                if (gridView1.RowCount >= 1)
                {
                    O_StockDetail.Stock_Detail_ID = (Int32)DalHandlar.AutoNumber<Models.Stock.Stock_Detail>();
                    DalHandlar.RunQuery("insert into Stock.Stock_Detail(Stock_Detail_ID,Stock_ID,Item_Barcode,Item_ID,Stock_In,Stock_Out,Transaction_Date,Transaction_By) Values(" + O_StockDetail.Stock_Detail_ID + "," + gridView1.GetRowCellValue(0, "Stock_ID") + ",'" + gridView1.GetRowCellValue(0, "Item_Barcode") + "'," + gridView1.GetRowCellValue(0, "Item_ID") + "," + TxtQty.EditValue + "," + 0 + ",'" + DateTime.Now + "','" + "Admin" + "')");
                }
                Modules.General.dtItemSearch = DalHandlar.RunQuery("select * from Admin.VwItemSearch where Active='True'");
                TxtQty.Text = string.Empty;
                ResetDatagrid2(Convert.ToString(TxtBarcode.EditValue));
                TxtBarcode.Text = string.Empty;
                TxtBarcode.Focus();
            }
        }


        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                Qty = Convert.ToDouble(gridView1.GetRowCellValue(0, "Total_Stock"));
                Qty = Qty - Convert.ToDouble(gridView2.GetFocusedRowCellValue("Stock_In"));

                if (Qty >= 0)
                {
                    gridView1.SetRowCellValue(0, "Total_Stock", Qty);
                    gridView1.UpdateCurrentRow();

                    DalHandlar.RunQuery("Update Stock.Stock Set Total_Stock=" + gridView1.GetRowCellValue(0, "Total_Stock") + ",Last_Updated='" + DateTime.Now + "',Modify_By='" + "Admin" + "'Where Item_Barcode='" + gridView1.GetRowCellValue(0, "Item_Barcode") + "'");
                    DalHandlar.RunQuery("Delete Stock.Stock_Detail where Item_Barcode='" + gridView2.GetFocusedRowCellValue("Item_Barcode") + "' AND Stock_Detail_ID= " + gridView2.GetFocusedRowCellValue("Stock_Detail_ID") + string.Empty);
                    check = 0;
                    gridView2.UpdateCurrentRow();
                    TxtBarcode.EditValue = string.Empty;

                    var view = sender as GridView;
                    view.DeleteRow(view.FocusedRowHandle);
                }
                else
                {
                    MessageBox.Show("Stock Can never be less than Zero");
                }
            }
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt = DalHandlar.RunQuery(@"select top 50 SD.Stock_Detail_ID,SD.Stock_ID,ID.Item_Barcode,SD.Item_ID,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as ItemName, SD.Stock_Out,SD.Transaction_Date,SD.Transaction_By
                                     from Stock.Stock_Detail as SD 
                                     Left Join admin.Items_Deffination as ID on SD.Item_ID=ID.Item_ID
                                     Left Join admin.Sizes as its on ID.Item_Size_ID=its.Size_ID  where SD.Stock_Out!=0");

            gridControl3.DataSource = dt;
            gridView3.BestFitColumns();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            gridControl3.DataSource = null;
            var dt = new DataTable();
            dt = DalHandlar.RunQuery(@"select SD.Stock_Detail_ID,SD.Stock_ID,SD.Item_Barcode,SD.Item_ID,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as ItemName, SD.Stock_Out,SD.Transaction_Date,SD.Transaction_By
                                     from Stock.Stock_Detail as SD 
                                     Left Join admin.Items_Deffination as ID on SD.Item_ID=ID.Item_ID
                                     Left Join admin.Sizes as its on ID.Item_Size_ID=its.Size_ID where SD.Stock_Out!=0 and DATEADD(D, 0, DATEDIFF(D, 0, SD.Transaction_Date))=DATEADD(D, 0, DATEDIFF(D, 0, GETDATE()))");

            gridControl3.DataSource = dt;
            gridView3.BestFitColumns();
        }

        private void btnBetweenDate_Click(object sender, EventArgs e)
        {
            if (DtEFrom.EditValue != string.Empty && DtETo.EditValue != string.Empty)
            {
                gridControl3.DataSource = null;
                var dt = new DataTable();
                dt = DalHandlar.RunQuery(@"select SD.Stock_Detail_ID,SD.Stock_ID,SD.Item_Barcode,SD.Item_ID,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as ItemName, SD.Stock_Out,SD.Transaction_Date,SD.Transaction_By
                                         from Stock.Stock_Detail as SD 
                                         Left Join admin.Items_Deffination as ID on SD.Item_ID=ID.Item_ID
                                         Left Join admin.Sizes as its on ID.Item_Size_ID=its.Size_ID  where SD.Stock_Out!=0 and DATEADD(D, 0, DATEDIFF(D, 0, SD.Transaction_Date)) between DATEADD(D, 0, DATEDIFF(D, 0, '" + DtEFrom.EditValue + "')) and DATEADD(D, 0, DATEDIFF(D, 0, '" + DtETo.EditValue + "'))");

                gridControl3.DataSource = dt;
                gridView3.BestFitColumns();
            }
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            gridControl3.DataSource = null;
            var dt = new DataTable();
            dt = DalHandlar.RunQuery(@"select SD.Stock_Detail_ID,SD.Stock_ID,SD.Item_Barcode,SD.Item_ID,Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END as ItemName, SD.Stock_Out,SD.Transaction_Date,SD.Transaction_By
                                     from Stock.Stock_Detail as SD 
                                     Left Join admin.Items_Deffination as ID on SD.Item_ID=ID.Item_ID
                                     Left Join admin.Sizes as its on ID.Item_Size_ID=its.Size_ID  where SD.Stock_Out!=0 and DATEADD(D, 0, DATEDIFF(D, 0, SD.Transaction_Date))=DATEADD(D, 0, DATEDIFF(D, 0, GETDATE())) -1");

            gridControl3.DataSource = dt;
            gridView3.BestFitColumns();
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.NumericCheck(e);
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
                            var dtgetBarcode = DalHandlar.RunQuery("Select Item_ID,Item_Barcode from Admin.Items_Deffination where Active=1 and Item_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                            if (dtgetBarcode != null)
                            {
                                TxtBarcode.EditValue = Convert.ToString(dtgetBarcode.Rows[0][1]);
                                TxtBarcode_Leave(sender, e);
                                TxtQty.Focus();
                            }
                        }
                    }
                }
            }
        }

        private void TxtQty_Leave(object sender, EventArgs e)
        {
            if (TxtBarcode.Text != string.Empty)
            {
                TxtBarcode_Leave(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                            TxtBarcode_Leave(sender, e);
                            TxtQty.Focus();
                        }
                    }
                }
            }
        }
    }
}
