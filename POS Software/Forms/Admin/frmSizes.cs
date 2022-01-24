using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class frmSizes : DevExpress.XtraEditors.XtraForm
    {
        public frmSizes()
        {
            InitializeComponent();
            SwitchLanguage();
        }
        private bool a;

        private Models.Admin.Sizes O_Size = new Models.Admin.Sizes();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            TxtSize_ID.Enabled = false;

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnCancel.Enabled = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_Size.Size_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Sizes>();
            TxtSize_ID.Text = O_Size.Size_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtSize_Name.Focus();
            CkEActive.Checked = true;
            SizeCheck = 0;
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
        }

        private int SizeCheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                var dtSizeCheck = DalHandlar.RunQuery("Select Size_Name from admin.Sizes");

                if (dtSizeCheck != null)
                {
                    for (var x = 0; x <= dtSizeCheck.Rows.Count - 1; x++)
                    {
                        if (TxtSize_Name.Text == dtSizeCheck.Rows[x]["Size_Name"].ToString() && a == false)
                        {
                            if (Activecheck == 0)
                            {
                                SizeCheck = 1;
                                MessageBox.Show("Size Already Exist");
                                break;
                            }
                            else
                            {
                                SizeCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            SizeCheck = 0;
                        }
                    }
                }

                if (SizeCheck == 0)
                {
                    Soothmedia.General.Win.UploadToModel<Models.Admin.Sizes>(this, O_Size);
                    DalHandlar.Save<Models.Admin.Sizes>(O_Size, "Size_ID", TxtSize_ID.Text, a, true);
                    Modules.General.dtSizes = DalHandlar.RunQuery("select * from Admin.Sizes Where Active='True'");
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
                var ID = DalHandlar.InputBox1("Size Find", "Enter Size ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Size = new Models.Admin.Sizes();
                    O_Size = DalHandlar.Select<string, int, Models.Admin.Sizes>("Size_ID", int.Parse(ID), O_Size);
                    if (Convert.ToInt32(O_Size.Size_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_Size);
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
                    DalHandlar.RunQuery("Update Admin.Sizes Set Active=0 where Size_ID=" + TxtSize_ID.Text);
                    Modules.General.dtSizes = DalHandlar.RunQuery("select * from Admin.Sizes Where Active='True'");
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
                TxtSize_Name.Focus();
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
            a = false;
        }

        private void TxtTypes_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.AlphaNumericCheck(e);
        }
        private int Activecheck = 0;
        private void CkEActive_CheckedChanged(object sender, EventArgs e)
        {
            if (a == true)
            {
                Activecheck = 1;
            }
        }

        private void TCSize_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DalHandlar.RunQuery("Select * from Admin.Sizes order by Size_ID desc");
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.GetFocusedRowCellValue("Size_ID").ToString();
            O_Size = new Models.Admin.Sizes();
            O_Size = DalHandlar.Select<string, string, Models.Admin.Sizes>("Size_ID", "'" + rowHandle + "'", O_Size);

            Soothmedia.General.Win.DownloadFromModel<Models.Admin.Sizes>(this, O_Size);
            TCSize.SelectedTabPage = TPSize;

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
                lblCreateSize.Text = General.resourceManager.GetString("lblCreateSize", General.culture);
                TPSize.Text = General.resourceManager.GetString("TPSize", General.culture);
                TPHistory.Text = General.resourceManager.GetString("TPHistory", General.culture);
                lblSizeID.Text = General.resourceManager.GetString("lblSizeID", General.culture);
                lblSizeName.Text = General.resourceManager.GetString("lblSizeName", General.culture);
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
