using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class frmTypes : DevExpress.XtraEditors.XtraForm
    {
        public frmTypes()
        {
            InitializeComponent();
        }
        private bool a;

        private Models.Admin.Items_Types O_Type = new Models.Admin.Items_Types();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            TxtItems_Types_ID.Enabled = false;

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnCancel.Enabled = false;
            SwitchLanguage();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_Type.Items_Types_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Items_Types>();
            TxtItems_Types_ID.Text = O_Type.Items_Types_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtTypes_Name.Focus();
            CkEActive.Checked = true;
            TypeCheck = 0;
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
            TypeCheck = 0;
        }

        private int TypeCheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                var dtTypeCheck = DalHandlar.RunQuery("Select Types_Name from admin.Items_Types");

                if (dtTypeCheck != null)
                {
                    for (var x = 0; x <= dtTypeCheck.Rows.Count - 1; x++)
                    {
                        if (TxtTypes_Name.Text == dtTypeCheck.Rows[x]["Types_Name"].ToString())
                        {
                            if (Activecheck == 0)
                            {
                                TypeCheck = 1;
                                MessageBox.Show("Type Already Exist");
                                break;
                            }
                            else
                            {
                                TypeCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            TypeCheck = 0;
                        }
                    }
                }

                if (TypeCheck == 0)
                {
                    Soothmedia.General.Win.UploadToModel<Models.Admin.Items_Types>(this, O_Type);
                    DalHandlar.Save<Models.Admin.Items_Types>(O_Type, "Items_Types_ID", TxtItems_Types_ID.Text, a, true);
                    Modules.General.dtItemsType = DalHandlar.RunQuery("select * from Admin.Items_Types Where Active='True'");
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
                var ID = DalHandlar.InputBox1("RoleFind", "Enter Role ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Type = new Models.Admin.Items_Types();
                    O_Type = DalHandlar.Select<string, int, Models.Admin.Items_Types>("Items_Types_ID", int.Parse(ID), O_Type);
                    if (Convert.ToInt32(O_Type.Items_Types_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_Type);
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
                    DalHandlar.RunQuery("Update Admin.Items_Types Set Active=0 where Items_Types_ID=" + TxtItems_Types_ID.Text);
                    Modules.General.dtItemsType = DalHandlar.RunQuery("select * from Admin.Items_Types Where Active='True'");
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
                TxtTypes_Name.Focus();
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
            TxtTypes_Name.Focus();
            a = false;
        }

        private void TxtTypes_Name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBCType_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DalHandlar.RunQuery("Select Top 20 * from Admin.Items_Types Order by Items_Types_ID desc");
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.GetFocusedRowCellValue("Items_Types_ID").ToString();
            O_Type = new Models.Admin.Items_Types();
            O_Type = DalHandlar.Select<string, string, Models.Admin.Items_Types>("Items_Types_ID", "'" + rowHandle + "'", O_Type);
            Soothmedia.General.Win.DownloadFromModel<Models.Admin.Items_Types>(this, O_Type);
            TBCType.SelectedTabPage = TPType;
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
                this.Text = General.resourceManager.GetString("frmTypes", General.culture);
                lblCreateType.Text = General.resourceManager.GetString("lblCreateType", General.culture);
                TPType.Text = General.resourceManager.GetString("TPType", General.culture);
                TPHistory.Text = General.resourceManager.GetString("TPHistory", General.culture);
                lblTypeID.Text = General.resourceManager.GetString("lblTypeID", General.culture);
                lblTypeName.Text = General.resourceManager.GetString("lblTypeName", General.culture);
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
