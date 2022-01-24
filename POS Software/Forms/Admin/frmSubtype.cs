using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class frmSubtype : DevExpress.XtraEditors.XtraForm
    {
        public frmSubtype()
        {
            InitializeComponent();
        }

        private bool a;

        private Models.Admin.Category O_Category = new Models.Admin.Category();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            LuEType_ID.Focus();
            TxtCategory_ID.Enabled = false;

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnCancel.Enabled = false;

            DalHandlar.BindLookUp(LuEType_ID, Modules.General.dtItemsType, "Types_Name", "Items_Types_ID");
            SwitchLanguage();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_Category.Category_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Category>();
            TxtCategory_ID.Text = O_Category.Category_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtCategory_ID.Enabled = false;
            LuEType_ID.Focus();
            CkEActive.Checked = true;
            SubTypeCheck = 0;
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
            SubTypeCheck = 0;
        }

        private int SubTypeCheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                var dtcategorychec = DalHandlar.RunQuery("Select Type_ID,Category_Name,Active from Admin.Category where TYPE_ID=" + LuEType_ID.EditValue);
                if (dtcategorychec != null)
                {
                    for (var x = 0; x <= dtcategorychec.Rows.Count - 1; x++)
                    {
                        if (TxtCategory_Name.Text == dtcategorychec.Rows[x]["Category_Name"].ToString())
                        {
                            if (Activecheck == 0)
                            {
                                SubTypeCheck = 1;
                                MessageBox.Show("Sub Type Already Exist");
                                break;
                            }
                            else
                            {
                                SubTypeCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            SubTypeCheck = 0;
                        }
                    }
                }

                if (SubTypeCheck == 0)
                {
                    Soothmedia.General.Win.UploadToModel<Models.Admin.Category>(this, O_Category);
                    DalHandlar.Save<Models.Admin.Category>(O_Category, "Category_ID", TxtCategory_ID.Text, a, true);
                    Modules.General.dtCategory = DalHandlar.RunQuery("select * from Admin.Category where Active='True'");
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
                var ID = DalHandlar.InputBox1("Security Find", "Enter Security ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Category = new Models.Admin.Category();
                    O_Category = DalHandlar.Select<string, int, Models.Admin.Category>("Category_ID", int.Parse(ID), O_Category);
                    if (Convert.ToInt32(O_Category.Category_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_Category);
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

            catch (Exception)
            {
                MessageBox.Show(Modules.Main.MsgSearchError);
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
                    DalHandlar.RunQuery("Update Admin.Category Set Active =0 where Category_ID=" + TxtCategory_ID.Text);
                    Modules.General.dtBasicSecurty = DalHandlar.RunQuery("select * from Admin.Category where Active='True'");
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
                TxtCategory_ID.Focus();
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
            TxtCategory_ID.Focus();
            a = false;
        }

        private void TxtCategory_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TCSubType_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DalHandlar.RunQuery("Select Top 20 C.Category_ID,IT.Types_Name,Category_Name,C.Active,C.Created_Date from Admin.Category as C left join Admin.Items_Types as IT on C.[Type_ID]=IT.Items_Types_ID order by c.Category_ID desc");
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.GetFocusedRowCellValue("Category_ID").ToString();
            O_Category = new Models.Admin.Category();
            O_Category = DalHandlar.Select<string, string, Models.Admin.Category>("Category_ID", "'" + rowHandle + "'", O_Category);

            Soothmedia.General.Win.DownloadFromModel<Models.Admin.Category>(this, O_Category);
            TCSubType.SelectedTabPage = TPSubType;

            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
        }

        private void SwitchLanguage()
        {
            if (General.culture != null)
            {
                this.Text = General.resourceManager.GetString("frmSubType", General.culture);
                lblCreateSubType.Text = General.resourceManager.GetString("lblCreateSubType", General.culture);
                TPSubType.Text = General.resourceManager.GetString("TPSubType", General.culture);
                TPHistory.Text = General.resourceManager.GetString("TPHistory", General.culture);
                lblSubTypeID.Text = General.resourceManager.GetString("lblSubTypeID", General.culture);
                lblTypeName.Text = General.resourceManager.GetString("lblTypeName", General.culture);
                lblSubTypeName.Text = General.resourceManager.GetString("lblSubTypeName", General.culture);
                CkEActive.Text = General.resourceManager.GetString("CkEActive", General.culture);

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
