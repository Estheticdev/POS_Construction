using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class FrmCreateSecurity : DevExpress.XtraEditors.XtraForm
    {
        public FrmCreateSecurity()
        {
            InitializeComponent();
        }
        private bool a;

        private Models.Admin.Create_User O_BasicSecurity = new Models.Admin.Create_User();

        private void FrmGeneralSecurity_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            TxtFull_Name.Focus();
            TxtSecurity_ID.Enabled = false;

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnCancel.Enabled = false;

            DalHandlar.BindLookUp(LuEUser_Role_ID, Modules.General.dtUserRole, "User_Role_Name", "User_Role_ID");
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_BasicSecurity.Security_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Create_User>();
            TxtSecurity_ID.Text = O_BasicSecurity.Security_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtFull_Name.Focus();
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
                O_BasicSecurity.Active = true;
                Soothmedia.General.Win.UploadToModel<Models.Admin.Create_User>(this, O_BasicSecurity);
                DalHandlar.Save<Models.Admin.Create_User>(O_BasicSecurity, "Security_ID", TxtSecurity_ID.Text, a, true);
                Modules.General.dtBasicSecurty = DalHandlar.RunQuery("select * from Admin.Create_User where Active='True'");
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
                var ID = DalHandlar.InputBox1("Security Find", "Enter Security ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_BasicSecurity = new Models.Admin.Create_User();
                    O_BasicSecurity = DalHandlar.Select<string, int, Models.Admin.Create_User>("Security_ID", int.Parse(ID), O_BasicSecurity);
                    if (Convert.ToInt32(O_BasicSecurity.Active) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_BasicSecurity);
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
                    DalHandlar.RunQuery("Update Admin.Basic_Security Set Active =0 where Security_ID=" + TxtSecurity_ID.Text);
                    Modules.General.dtBasicSecurty = DalHandlar.RunQuery("select * from Admin.Create_User where Active='True'");
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
                TxtSecurity_ID.Focus();
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
            TxtFull_Name.Focus();
            a = false;
        }
    }
}
