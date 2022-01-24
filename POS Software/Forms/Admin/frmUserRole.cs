using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class frmUserRole : DevExpress.XtraEditors.XtraForm
    {
        public frmUserRole()
        {
            InitializeComponent();
        }
        private bool a;

        private Models.Admin.User_Role O_UserRole = new Models.Admin.User_Role();
        private void frmUserRole_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            TxtUser_Role_ID.Enabled = false;

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

            O_UserRole.User_Role_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.User_Role>();
            TxtUser_Role_ID.Text = O_UserRole.User_Role_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtUser_Role_Name.Focus();
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
                O_UserRole.Active = true;
                Soothmedia.General.Win.UploadToModel<Models.Admin.User_Role>(this, O_UserRole);
                DalHandlar.Save<Models.Admin.User_Role>(O_UserRole, "User_Role_ID", TxtUser_Role_ID.Text, a, true);
                Modules.General.dtUserRole = DalHandlar.RunQuery("select * from Admin.User_Role Where Active='True'");
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
                var ID = DalHandlar.InputBox1("RoleFind", "Enter Role ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_UserRole = new Models.Admin.User_Role();
                    O_UserRole = DalHandlar.Select<string, int, Models.Admin.User_Role>("User_Role_ID", int.Parse(ID), O_UserRole);
                    if (Convert.ToInt32(O_UserRole.Active) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_UserRole);
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
                    DalHandlar.RunQuery("Update Admin.User_Role Set Active=0 where User_Role_ID=" + TxtUser_Role_ID.Text);
                    Modules.General.dtUserRole = DalHandlar.RunQuery("select * from Admin.User_Role where Active='True'");
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
                TxtUser_Role_Name.Focus();
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
            TxtUser_Role_Name.Focus();
            a = false;
        }
    }
}
