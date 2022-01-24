using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class frmUnits : DevExpress.XtraEditors.XtraForm
    {
        public frmUnits()
        {
            InitializeComponent();
            SwitchLanguage();
        }
        private bool a;

        private Models.Admin.Units O_Units = new Models.Admin.Units();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            TxtUnit_ID.Enabled = false;

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

            O_Units.Unit_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Units>();
            TxtUnit_ID.Text = O_Units.Unit_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtUnit_Name.Focus();
            CkEActive.Checked = true;
            Unicheck = 0;
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

        private int Unicheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                var dtUnitCheck = DalHandlar.RunQuery("Select Unit_Name from admin.Units");
                if (dtUnitCheck != null)
                {
                    for (var x = 0; x <= dtUnitCheck.Rows.Count - 1; x++)
                    {
                        if (TxtUnit_Name.Text == dtUnitCheck.Rows[x]["Unit_Name"].ToString() && a == false)
                        {
                            if (Activecheck == 0)
                            {
                                Unicheck = 1;
                                MessageBox.Show("Unit Already Exist");
                                break;
                            }
                            else
                            {
                                Unicheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            Unicheck = 0;
                        }
                    }
                }

                if (Unicheck == 0)
                {
                    Soothmedia.General.Win.UploadToModel<Models.Admin.Units>(this, O_Units);
                    DalHandlar.Save<Models.Admin.Units>(O_Units, "Unit_ID", TxtUnit_ID.Text, a, true);
                    Modules.General.dtUnits = DalHandlar.RunQuery("select * from Admin.Units Where Active='True'");
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
                var ID = DalHandlar.InputBox1("Unit Find", "Enter Unit ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Units = new Models.Admin.Units();
                    O_Units = DalHandlar.Select<string, int, Models.Admin.Units>("Unit_ID", int.Parse(ID), O_Units);
                    if (Convert.ToInt32(O_Units.Unit_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_Units);
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
                    DalHandlar.RunQuery("Update Admin.Units Set Active=0 where Unit_ID=" + TxtUnit_ID.Text);
                    Modules.General.dtUnits = DalHandlar.RunQuery("select * from Admin.Units Where Active='True'");
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
                TxtUnit_Name.Focus();
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
        private void CkEActive_EditValueChanged(object sender, EventArgs e)
        {
            if (a == true)
            {
                Activecheck = 1;
            }
        }

        private void TCUnits_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DalHandlar.RunQuery("Select * from Admin.Units order by Unit_ID desc");
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.GetFocusedRowCellValue("Unit_ID").ToString();
            O_Units = new Models.Admin.Units();
            O_Units = DalHandlar.Select<string, string, Models.Admin.Units>("Unit_ID", "'" + rowHandle + "'", O_Units);

            Soothmedia.General.Win.DownloadFromModel<Models.Admin.Units>(this, O_Units);
            TCUnits.SelectedTabPage = TPUnit;

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
                this.Text = General.resourceManager.GetString("frmUnits", General.culture);
                lblCreateUnits.Text = General.resourceManager.GetString("lblCreateUnit", General.culture);
                TPUnit.Text = General.resourceManager.GetString("TPUnit", General.culture);
                TPHistory.Text = General.resourceManager.GetString("TPHistory", General.culture);
                lblUnitID.Text = General.resourceManager.GetString("lblUnitID", General.culture);
                lblUnitName.Text = General.resourceManager.GetString("lblUnitName", General.culture);
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
