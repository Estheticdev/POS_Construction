using System;
using System.Windows.Forms;
using POS_Software.Modules;

namespace POS_Software.Forms.Admin
{
    public partial class frmStore_Deffination : DevExpress.XtraEditors.XtraForm
    {
        public frmStore_Deffination()
        {
            InitializeComponent();
            SwitchLanguage();
        }
        private bool a;
        private Models.Admin.Store_Deffination O_StoreDeff = new Models.Admin.Store_Deffination();
        private void frmStore_Deffination_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            TxtStore_Name.Focus();
            TxtStore_ID.Enabled = false;

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

            O_StoreDeff.Store_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Store_Deffination>();
            TxtStore_ID.Text = O_StoreDeff.Store_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtStore_Name.Focus();
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                O_StoreDeff.Active = true;
                Soothmedia.General.Win.UploadToModel<Models.Admin.Store_Deffination>(this, O_StoreDeff);
                DalHandlar.Save<Models.Admin.Store_Deffination>(O_StoreDeff, "Store_ID", TxtStore_ID.Text, a, true);
                Modules.General.dtStoredeff = DalHandlar.RunQuery("Select * from Admin.Store_Deffination where Active='True'");
                Soothmedia.General.Win.Refresh(this);
                Soothmedia.General.Win.Disable(this);

                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                BtnSearch.Enabled = true;
                BtnSave.Enabled = false;
                BtnNew.Enabled = true;
                a = false;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = DalHandlar.InputBox1("Store Find", "Enter Store ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_StoreDeff = new Models.Admin.Store_Deffination();
                    O_StoreDeff = DalHandlar.Select<string, int, Models.Admin.Store_Deffination>("Store_ID", int.Parse(ID), O_StoreDeff);
                    if (Convert.ToInt32(O_StoreDeff.Active) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_StoreDeff);
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
                    DalHandlar.RunQuery("Update Admin.Store_Deffination Set Active =0 where Store_ID=" + TxtStore_ID.Text);
                    Modules.General.dtBasicSecurty = DalHandlar.RunQuery("Select * from Admin.Store_Deffination where Active='True'");
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
                TxtStore_Name.Focus();
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
            TxtStore_Name.Focus();
            a = false;
        }

        private void TxtPhone_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.NumericCheck(e);
        }

        private void TxtCell_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.NumericCheck(e);
        }

        private void TxtStore_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtOwner_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modules.Main.AlphabetsCheck(e);
        }

        private void SwitchLanguage()
        {
            if (General.culture != null)
            {
                this.Text = General.resourceManager.GetString("frmStore_Deffination", General.culture);
                lblCreateStore.Text = General.resourceManager.GetString("lblCreateStore", General.culture);
                tabStore.Text = General.resourceManager.GetString("tabStore", General.culture);
                lblStoreID.Text = General.resourceManager.GetString("lblStoreID", General.culture);
                lblStoreName.Text = General.resourceManager.GetString("lblStoreName", General.culture);
                lblOwnerName.Text = General.resourceManager.GetString("lblOwnerName", General.culture);
                lblPhoneNo.Text = General.resourceManager.GetString("lblPhoneNo", General.culture);
                lblCellNo.Text = General.resourceManager.GetString("lblCellNo", General.culture);
                lblTaxNumber.Text = General.resourceManager.GetString("lblTaxNumber", General.culture);
                lblAddress.Text = General.resourceManager.GetString("lblAddress", General.culture);
                lblStoreLogo.Text = General.resourceManager.GetString("lblStoreLogo", General.culture);
                LblCR_Number.Text = General.resourceManager.GetString("TxtCR_Number", General.culture);

                BtnNew.Text = General.resourceManager.GetString("BtnNew", General.culture);
                BtnSave.Text = General.resourceManager.GetString("BtnSave", General.culture);
                BtnEdit.Text = General.resourceManager.GetString("BtnEdit", General.culture);
                BtnSearch.Text = General.resourceManager.GetString("BtnSearch", General.culture);
                BtnDelete.Text = General.resourceManager.GetString("BtnDelete", General.culture);
                BtnCancel.Text = General.resourceManager.GetString("BtnCancel", General.culture);
            }
        }

        private void TxtStore_Name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtOwner_Name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmStore_Deffination_KeyDown(object sender, KeyEventArgs e)
        {
            if (BtnSave.Enabled==true && Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                BtnSave_Click(sender, e);
            }
            if (BtnSearch.Enabled == true && Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.F)
            {
                BtnSearch_Click(sender, e);
            }
            if (BtnNew.Enabled == true && Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                BtnNew_Click(sender, e);
            }
            if (BtnDelete.Enabled == true && Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.D)
            {
                BtnDelete_Click(sender, e);
            }
            if (BtnEdit.Enabled == true && Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.E)
            {
                BtnEdit_Click(sender, e);
            }
            if (BtnCancel.Enabled == true && Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
            {
                BtnCancel_Click(sender, e);
            }

        }
    }
}
