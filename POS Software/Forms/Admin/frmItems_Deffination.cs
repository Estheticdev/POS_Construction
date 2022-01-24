using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Data;

namespace POS_Software.Forms.Admin
{
    public partial class frmItems_Deffination : DevExpress.XtraEditors.XtraForm
    {
        public frmItems_Deffination()
        {
            InitializeComponent();
        }
        private bool a;

        private Models.Admin.Items_Deffination O_ItemsDeffinition = new Models.Admin.Items_Deffination();

        private void frmItems_Deffination_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            TxtItem_Name.Focus();
            TxtItem_ID.Enabled = false;

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnCancel.Enabled = false;
            SwitchLanguage();

            DalHandlar.BindLookUp(LuEItem_Type_ID, Modules.General.dtItemsType, "Types_Name", "Items_Types_ID");
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_ItemsDeffinition.Item_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Items_Deffination>();
            TxtItem_ID.Text = O_ItemsDeffinition.Item_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtItem_Name.Focus();
            CkEActive.Checked = true;
            ItemCheck = 0;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            a = true;
            TxtItem_Sale_Price_Leave(sender, e);
        }

        private int ItemCheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                if (LuEItem_Type_ID.Text == "")
                    LuEItem_Type_ID.EditValue = 1;
                if (LuEItem_Category_ID.Text == "")
                    LuEItem_Category_ID.EditValue = 1;
                if (LuEItem_Size_ID.Text == "")
                    LuEItem_Size_ID.EditValue = 1;
                if (LuEItem_Unit_ID.Text == "")
                    LuEItem_Unit_ID.EditValue = 1;
                if (TxtPack_Price.Text == "")
                    TxtPack_Price.Text = "1";
                var dtItemCheck = DalHandlar.RunQuery(@"Select ID.Item_Name
                                                            from [Admin].Items_Deffination as ID
                                                            Left Join admin.Items_Types as IT on ID.Item_Type_ID= IT.Items_Types_ID
                                                            Left Join admin.Category as C on ID.Item_Category_ID= C.Category_ID
                                                            Left join admin.Units as S on ID.Item_Unit_ID=S.Unit_ID 
                                                            Left Join admin.Sizes as Z on ID.Item_Size_ID=Z.Size_ID
                                                            Where ID.Item_Type_ID =" + LuEItem_Type_ID.EditValue + " and ID.Item_Category_ID=" + LuEItem_Category_ID.EditValue + " and ID.Item_Unit_ID=" + LuEItem_Unit_ID.EditValue + " and ID.Item_Size_ID=" + LuEItem_Size_ID.EditValue);
                if (dtItemCheck != null)
                {
                    for (var x = 0; x <= dtItemCheck.Rows.Count - 1; x++)
                    {
                        if (TxtItem_Name.Text == dtItemCheck.Rows[x]["Item_Name"].ToString() && a == false)
                        {
                            if (Activecheck == 0)
                            {
                                ItemCheck = 1;
                                MessageBox.Show("Item Already Defined");
                            }
                            else
                            {
                                ItemCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            ItemCheck = 0;
                        }
                    }
                }

                if (ItemCheck == 0)
                {
                    O_ItemsDeffinition.Active = true;
                    
                    Soothmedia.General.Win.UploadToModel<Models.Admin.Items_Deffination>(this, O_ItemsDeffinition);
                    DalHandlar.Save<Models.Admin.Items_Deffination>(O_ItemsDeffinition, "Item_ID", TxtItem_ID.Text, a, true);
                    Modules.General.dtItems_Deffination = DalHandlar.RunQuery("select * from Admin.Items_Deffination where Active='True'");
                    Modules.General.dtItemSearch = DalHandlar.RunQuery("select * from Admin.VwItemSearch where Active='True'");
                    Soothmedia.General.Win.Refresh(this);
                    Soothmedia.General.Win.Disable(this);

                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnSearch.Enabled = true;
                    BtnSave.Enabled = false;
                    BtnNew.Enabled = true;
                    a = false;
                    Activecheck = 0;
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = null;
                var Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No',Code,'Name'", false,"1");
                if (Dt != null)
                {
                    ID = Convert.ToString(Dt.Rows[0][0]);
                }

                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_ItemsDeffinition = new Models.Admin.Items_Deffination();
                    O_ItemsDeffinition = DalHandlar.Select<string, int, Models.Admin.Items_Deffination>("Item_ID", int.Parse(ID), O_ItemsDeffinition);
                    if (Convert.ToInt32(O_ItemsDeffinition.Item_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_ItemsDeffinition);
                        Soothmedia.General.Win.Disable(this);

                        BtnDelete.Enabled = true;
                        BtnEdit.Enabled = true;
                        BtnSearch.Enabled = true;
                        BtnSave.Enabled = false;
                        BtnNew.Enabled = false;
                        BtnCancel.Enabled = true;
                    }
                    else
                    {
                        Soothmedia.General.Win.Refresh(this);
                        MessageBox.Show(Modules.Main.MsgSearchError);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var res = new DialogResult();
                res = DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to Delete this Record ???", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    DalHandlar.RunQuery("Update Admin.Items_Deffination Set Active =0 where Item_ID=" + TxtItem_ID.Text);
                    Modules.General.dtItems_Deffination = DalHandlar.RunQuery("select * from Admin.Items_Deffination where Active='True'");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                Soothmedia.General.Win.Refresh(this);
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                BtnSearch.Enabled = true;
                BtnSave.Enabled = false;
                BtnNew.Enabled = true;
                BtnCancel.Enabled = false;
                TxtItem_ID.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Refresh(this);
            Soothmedia.General.Win.ValidationClear(this, ErPro);
            Soothmedia.General.Win.Disable(this);
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnCancel.Enabled = false;
            TxtItem_ID.Focus();
            a = false;
        }
        private void Barcode()
        {
            var length = "0";
            length = TxtItem_Barcode.Text;
            var x = Convert.ToInt32(length.Length);
            if (x <= 25)
            {
                BCCItem_Barcode.Text = TxtItem_Barcode.Text;
                BCCItem_Barcode.Visible = true;
            }
            else
            {
                MessageBox.Show("Barcode Should be 9 digits");
                TxtItem_Barcode.Text = string.Empty;
                TxtItem_Barcode.Focus();
            }
        }
        private void LuEItem_Type_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuEItem_Type_ID.EditValue != null)
            {
                DalHandlar.BindLookUp(LuEItem_Category_ID, "Select Category_Name, Category_ID from Admin.Category where Type_ID =" + LuEItem_Type_ID.EditValue + "and Active='True'", "Category_Name", "Category_ID");
            }
        }

        private void LuEItem_Category_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuEItem_Category_ID.EditValue != null && LuEItem_Type_ID.EditValue != null)
            {
                DalHandlar.BindLookUp(LuEItem_Size_ID, "Select S.Size_Name ,S.Size_ID  from Admin.Sizes_Assign as SA Left Join admin.Sizes as S on SA.Sizes_ID=S.Size_ID where SA.Types_ID=" + LuEItem_Type_ID.EditValue + " and SA.Category_ID=" + LuEItem_Category_ID.EditValue + " and SA.Active='True'", "Size_Name", "Size_ID");
                DalHandlar.BindLookUp(LuEItem_Unit_ID, "Select * from Admin.Unit_Assign as UA Left Join admin.Units as U on UA.Unit_ID=U.Unit_ID where UA.Types_ID=" + LuEItem_Type_ID.EditValue + " and UA.Category_ID=" + LuEItem_Category_ID.EditValue + "and UA.Active='True'", "Unit_Name", "Unit_ID");
            }
        }

        private void TxtItem_Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.DecimalPointCheck(e);
        }

        private void TxtItem_Sale_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.DecimalPointCheck(e);
        }

        private void TxtItem_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.AlphaNumericCheck(e);
        }

        private void TxtItem_Barcode_Leave(object sender, EventArgs e)
        {
            if (Modules.General.dtItems_Deffination != null)
            {
                for (var x = 0; x <= Modules.General.dtItems_Deffination.Rows.Count - 1; x++)
                {
                    if (TxtItem_Barcode.Text == Modules.General.dtItems_Deffination.Rows[x]["Item_Barcode"].ToString() && TxtItem_Barcode.Text != string.Empty)
                    {
                        MessageBox.Show("Barcode Already Exist");
                        TxtItem_Barcode.Text = string.Empty;
                        break;
                    }
                    else
                    {
                        Barcode();
                    }
                }
            }
            else
            {
                Barcode();
            }
        }

        private void TxtItem_Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.AlphaNumericCheck(e);
        }

        private int Activecheck = 0;
        private void CkEActive_EditValueChanged(object sender, EventArgs e)
        {
            if (a == true)
            {
                Activecheck = 1;
            }
        }

        private void TCItems_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DalHandlar.RunQuery(@"SELECT   Top 30     ID.Item_ID, ID.Item_Barcode, CASE WHEN Its.Size_Name = 'None' THEN ID.Item_Name ELSE ID.Item_Name + ' ' + Its.Size_Name END AS Item_Name,
                                                          IT.Types_Name, cat.Category_Name,U.Unit_Name, Its.Size_Name, ID.Item_Sale_Price,Item_Purchase_Price,Pack_Price,Piece_Per_Pack, ID.Active, ID.Created_Date
                                                          FROM            Admin.Items_Deffination AS ID WITH (NOLOCK) LEFT OUTER JOIN
                                                          Admin.Category AS cat ON ID.Item_Category_ID = cat.Category_ID LEFT OUTER JOIN
                                                          Admin.Items_Types AS IT ON ID.Item_Type_ID = IT.Items_Types_ID LEFT OUTER JOIN
                                                          Admin.Sizes AS Its ON ID.Item_Size_ID = Its.Size_ID LEFT OUTER JOIN
                                                          Admin.Units AS U ON ID.Item_Unit_ID = U.Unit_ID order by ID.Item_ID desc");
            gridView1.BestFitColumns();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.GetFocusedRowCellValue("Item_ID").ToString();
            O_ItemsDeffinition = new Models.Admin.Items_Deffination();
            O_ItemsDeffinition = DalHandlar.Select<string, string, Models.Admin.Items_Deffination>("Item_ID", "'" + rowHandle + "'", O_ItemsDeffinition);

            Soothmedia.General.Win.DownloadFromModel<Models.Admin.Items_Deffination>(this, O_ItemsDeffinition);
            TCItems.SelectedTabPage = TPItems;

            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
        }

        private void Txtsale_Leave(object sender, EventArgs e)
        {
            if (Txtsale.Text != "")
            {
                DataTable vat = DalHandlar.RunQuery("select Setting_Text from admin.Setting where SettingID =7");
                double saleprice = Math.Round(((Convert.ToDouble(Txtsale.Text) * 100) / (Convert.ToDouble(vat.Rows[0]["Setting_Text"]) + 100)), 4);
                TxtItem_Sale_Price.Text = saleprice.ToString();
                // TxtItem_Sale_Price.Text = Txtsale.Text;
            }
        }

        private void TxtItem_Sale_Price_Leave(object sender, EventArgs e)
        {
            if (TxtItem_Sale_Price.Text != "")
            {
                DataTable vat = DalHandlar.RunQuery("select Setting_Text from admin.Setting where SettingID =7");
                //TxtTaxPercentage.Text = vat.Rows[0]["Setting_Text"].ToString();
                double saleprice = Math.Round(((Convert.ToDouble(TxtItem_Sale_Price.Text)) *(Convert.ToDouble(vat.Rows[0]["Setting_Text"])/100)), 2);
                Txtsale.Text = (Convert.ToDouble(TxtItem_Sale_Price.Text) + saleprice).ToString();
                //Txtsale.Text = TxtItem_Sale_Price.Text;
            }
        }

        private void SwitchLanguage()
        {
            if (General.culture != null)
            {
                this.Text = General.resourceManager.GetString("frmItems_Deffination", General.culture);
                lblCreateItems.Text = General.resourceManager.GetString("lblCreateItems", General.culture);
                TPItems.Text = General.resourceManager.GetString("TPItems", General.culture);
                TPHistory.Text = General.resourceManager.GetString("TPHistory", General.culture);
                lblItemID.Text = General.resourceManager.GetString("lblItemID", General.culture);
                lblItemName.Text = General.resourceManager.GetString("lblItemName", General.culture);
                CkEActive.Text = General.resourceManager.GetString("CkEActive", General.culture);
                CkEIsPacked.Text = General.resourceManager.GetString("CkEIsPacked", General.culture);
                lblItemType.Text = General.resourceManager.GetString("lblItemType", General.culture);
                lblItemSubType.Text = General.resourceManager.GetString("lblItemSubType", General.culture);
                lblItemUnit.Text = General.resourceManager.GetString("lblItemUnit", General.culture);
                lblPurchasePrice.Text = General.resourceManager.GetString("lblPurchasePrice", General.culture);
                lblSPWOT.Text = General.resourceManager.GetString("lblSPWOT", General.culture);
                lblSPWT.Text = General.resourceManager.GetString("lblSPWT", General.culture);
                lblBundlePrice.Text = General.resourceManager.GetString("lblBundlePrice", General.culture);
                lblPieceInPack.Text = General.resourceManager.GetString("lblPieceInPack", General.culture);
                lblStockCriticalLevel.Text = General.resourceManager.GetString("lblStockCriticalLevel", General.culture);
                lblExpiryDate.Text = General.resourceManager.GetString("lblExpiryDate", General.culture);
                lblItemBarcode.Text = General.resourceManager.GetString("lblItemBarcode", General.culture);
                lblItemSize.Text = General.resourceManager.GetString("lblItemSize", General.culture);
                //CultureInfo culture;

                // this.lblBundlePrice.RightToLeft = lblCreateItems.RightToLeft = lblExpiryDate.RightToLeft = lblItemBarcode.RightToLeft = lblItemID.RightToLeft = lblItemName.RightToLeft = lblItemSize.RightToLeft = lblItemSize.RightToLeft = lblItemSubType.RightToLeft = lblItemType.RightToLeft = lblItemUnit.RightToLeft = lblPieceInPack.RightToLeft = lblPurchasePrice.RightToLeft = lblSPWOT.RightToLeft = lblSPWT.RightToLeft = lblStockCriticalLevel.RightToLeft = RightToLeft.Yes;

                BtnNew.Text = General.resourceManager.GetString("BtnNew", General.culture);
                BtnSave.Text = General.resourceManager.GetString("BtnSave", General.culture);
                BtnEdit.Text = General.resourceManager.GetString("BtnEdit", General.culture);
                BtnSearch.Text = General.resourceManager.GetString("BtnSearch", General.culture);
                BtnDelete.Text = General.resourceManager.GetString("BtnDelete", General.culture);
                BtnCancel.Text = General.resourceManager.GetString("BtnCancel", General.culture);
            }
        }
    }
}
