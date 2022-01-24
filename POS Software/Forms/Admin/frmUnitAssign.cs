using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class frmUnitAssign : DevExpress.XtraEditors.XtraForm
    {
        public frmUnitAssign()
        {
            InitializeComponent();
            SwitchLanguage();
        }
        private bool a;

        private Models.Admin.Unit_Assign O_Unit = new Models.Admin.Unit_Assign();
        private void frmUnit_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            LuETypes_ID.Focus();
            TxtUnit_Assign_ID.Enabled = false;

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            BtnCancel.Enabled = false;

            DalHandlar.BindLookUp(LuETypes_ID, Modules.General.dtItemsType, "Types_Name", "Items_Types_ID");
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_Unit.Unit_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Unit_Assign>();
            TxtUnit_Assign_ID.Text = O_Unit.Unit_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            LuETypes_ID.Focus();
            CkEActive.Checked = true;
            UnitAssignCheck = 0;
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

            LuETypes_ID.Enabled = false;
            LuECategory_ID.Enabled = false;
        }

        private int UnitAssignCheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                var dtUnitAssignCheck = DalHandlar.RunQuery(@"Select IT.Types_Name,C.Category_Name,S.Unit_Name
                                                                  from [Admin].Unit_Assign as UA
                                                                  Left Join admin.Items_Types as IT on UA.Types_ID= IT.Items_Types_ID
                                                                  Left Join admin.Category as C on UA.Category_ID= C.Category_ID
                                                                  Left join admin.Units as S on UA.Unit_ID=S.Unit_ID Where UA.Types_ID =" + LuETypes_ID.EditValue + " and UA.Category_ID=" + LuECategory_ID.EditValue + " and UA.Unit_ID=" + LuEUnit_ID.EditValue);
                if (dtUnitAssignCheck != null)
                {
                    for (var x = 0; x <= dtUnitAssignCheck.Rows.Count - 1; x++)
                    {
                        if (LuETypes_ID.Text == dtUnitAssignCheck.Rows[x]["Types_Name"].ToString() && LuECategory_ID.Text == dtUnitAssignCheck.Rows[x]["Category_Name"].ToString() && LuEUnit_ID.Text == dtUnitAssignCheck.Rows[x]["Unit_Name"].ToString() && a == false)
                        {
                            if (Activecheck == 0)
                            {
                                UnitAssignCheck = 1;
                                MessageBox.Show("Unit Already Assigned");
                                break;
                            }
                            else
                            {
                                UnitAssignCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            UnitAssignCheck = 0;
                        }
                    }
                }

                if (UnitAssignCheck == 0)
                {
                    Soothmedia.General.Win.UploadToModel<Models.Admin.Unit_Assign>(this, O_Unit);
                    DalHandlar.Save<Models.Admin.Unit_Assign>(O_Unit, "Unit_Assign_ID", TxtUnit_Assign_ID.Text, a, true);
                    Modules.General.dtUnitAssign = DalHandlar.RunQuery("select * from Admin.Unit_Assign where Active='True'");
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
                var ID = DalHandlar.InputBox1("Assign Find", "Enter Assign ID ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Unit = new Models.Admin.Unit_Assign();
                    O_Unit = DalHandlar.Select<string, int, Models.Admin.Unit_Assign>("Unit_Assign_ID", int.Parse(ID), O_Unit);
                    if (Convert.ToInt32(O_Unit.Unit_Assign_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_Unit);
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
                    DalHandlar.RunQuery("Update Admin.Unit_Assign Set Active =0 where Unit_Assign_ID=" + TxtUnit_Assign_ID.Text);
                    Modules.General.dtUnitAssign = DalHandlar.RunQuery("select * from Admin.Unit_Assign where Active='True'");
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
                LuETypes_ID.Focus();
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
            LuETypes_ID.Focus();
            a = false;
        }

        private void LuEType_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuETypes_ID.EditValue != null)
            {
                DalHandlar.BindLookUp(LuECategory_ID, "Select Category_Name, Category_ID from Admin.Category where Type_ID =" + LuETypes_ID.EditValue + "and Active='True'", "Category_Name", "Category_ID");
            }
        }

        private void LuECategory_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuETypes_ID.EditValue != null && LuECategory_ID.EditValue != null)
            {
                DalHandlar.BindLookUp(LuEUnit_ID, "select Unit_Name as Unit_Name, Unit_ID from Admin.Units Where Active='True'", "Unit_Name", "Unit_ID");
            }
        }
        private int Activecheck = 0;
        private void CkEActive_EditValueChanged(object sender, EventArgs e)
        {
            if (a == true)
            {
                Activecheck = 1;
            }
        }

        private void TCUnit_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DalHandlar.RunQuery(@"Select Top 20 UA.Unit_Assign_ID, IT.Types_Name,C.Category_Name,U.Unit_Name,UA.Active,UA.Created_Date from Admin.Unit_Assign as UA
                                                          Left Join Admin.Items_Types as IT on UA.Types_ID=IT.Items_Types_ID 
                                                          Left Join admin.Category as C on UA.Category_ID=C.Category_ID
                                                          Left join Admin.Units as U on UA.Unit_ID=U.Unit_ID order by UA.Unit_Assign_ID desc");
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.GetFocusedRowCellValue("Unit_Assign_ID").ToString();
            O_Unit = new Models.Admin.Unit_Assign();
            O_Unit = DalHandlar.Select<string, string, Models.Admin.Unit_Assign>("Unit_Assign_ID", "'" + rowHandle + "'", O_Unit);

            Soothmedia.General.Win.DownloadFromModel<Models.Admin.Unit_Assign>(this, O_Unit);
            TCUnit.SelectedTabPage = TPUnit;

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
                this.Text = General.resourceManager.GetString("frmSizAssigns", General.culture);
                lblAssignUnit.Text = General.resourceManager.GetString("lblAssignUnit", General.culture);
                TPUnit.Text = General.resourceManager.GetString("TPUnit", General.culture);
                TPHistory.Text = General.resourceManager.GetString("TPHistory", General.culture);
                lblUnitID.Text = General.resourceManager.GetString("lblUnitID", General.culture);
                lblTypeName.Text = General.resourceManager.GetString("lblTypeName", General.culture);
                lblCategoryName.Text = General.resourceManager.GetString("lblCategoryName", General.culture);
                CkEActive.Text = General.resourceManager.GetString("CkEActive", General.culture);
                lblUnitName.Text = General.resourceManager.GetString("lblUnitName", General.culture);

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
