using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Forms.Admin
{
    public partial class frmSizAssigns : DevExpress.XtraEditors.XtraForm
    {
        public frmSizAssigns()
        {
            InitializeComponent();
            SwitchLanguage();
        }
        private bool a;

        private Models.Admin.Sizes_Assign O_Size = new Models.Admin.Sizes_Assign();
        private void frmSizes_Load(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Disable(this);
            LuETypes_ID.Focus();
            TxtSizes_Assign_ID.Enabled = false;

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

            O_Size.Sizes_Assign_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Sizes_Assign>();
            TxtSizes_Assign_ID.Text = O_Size.Sizes_Assign_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            LuETypes_ID.Focus();
            CkEActive.Checked = true;
            SizeAssignCheck = 0;
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

        private int SizeAssignCheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                var dtSizeAssignCheck = DalHandlar.RunQuery(@"Select IT.Types_Name,C.Category_Name,S.Size_Name
                                                                   from [Admin].[Sizes_Assign] as SA
                                                                   Left Join admin.Items_Types as IT on SA.Types_ID= IT.Items_Types_ID
                                                                   Left Join admin.Category as C on SA.Category_ID= C.Category_ID
                                                                   Left join admin.Sizes as S on SA.Sizes_ID=S.Size_ID Where SA.Types_ID =" + LuETypes_ID.EditValue + " and SA.Category_ID=" + LuECategory_ID.EditValue + " and SA.Sizes_ID=" + LuESizes_ID.EditValue);
                if (dtSizeAssignCheck != null)
                {
                    for (var x = 0; x <= dtSizeAssignCheck.Rows.Count - 1; x++)
                    {
                        if (LuETypes_ID.Text == dtSizeAssignCheck.Rows[x]["Types_Name"].ToString() && LuECategory_ID.Text == dtSizeAssignCheck.Rows[x]["Category_Name"].ToString() && LuESizes_ID.Text == dtSizeAssignCheck.Rows[x]["Size_Name"].ToString() && a == false)
                        {
                            if (Activecheck == 0)
                            {
                                SizeAssignCheck = 1;
                                MessageBox.Show("Size Already Assigned");
                                break;
                            }

                            else
                            {
                                SizeAssignCheck = 0;
                                break;
                            }
                        }
                        else
                        {
                            SizeAssignCheck = 0;
                        }
                    }
                }

                if (SizeAssignCheck == 0)
                {
                    Soothmedia.General.Win.UploadToModel<Models.Admin.Sizes_Assign>(this, O_Size);
                    DalHandlar.Save<Models.Admin.Sizes_Assign>(O_Size, "Sizes_Assign_ID", TxtSizes_Assign_ID.Text, a, true);
                    Modules.General.dtSizes = DalHandlar.RunQuery("select * from Admin.Sizes_Assign where Active='True'");
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
                var ID = DalHandlar.InputBox1("Assign ID Find", "Enter Assign ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Size = new Models.Admin.Sizes_Assign();
                    O_Size = DalHandlar.Select<string, int, Models.Admin.Sizes_Assign>("Sizes_Assign_ID", int.Parse(ID), O_Size);
                    if (Convert.ToInt32(O_Size.Sizes_Assign_ID) != 0)
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
                    DalHandlar.RunQuery("Update Admin.Sizes_Assign Set Active =0 where Sizes_Assign_ID=" + TxtSizes_Assign_ID.Text);
                    Modules.General.dtSizes = DalHandlar.RunQuery("select * from Admin.Sizes_Assign where Active='True'");
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

        private void LuETypes_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuETypes_ID.EditValue != null)
            {
                DalHandlar.BindLookUp(LuECategory_ID, "Select Category_Name, Category_ID from Admin.Category where Type_ID =" + LuETypes_ID.EditValue + "and Active='True'", "Category_Name", "Category_ID");
            }
        }

        private void LuECategory_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuECategory_ID.EditValue != null && LuETypes_ID.EditValue != null)
            {
                DalHandlar.BindLookUp(LuESizes_ID, "select Size_Name as Size_Name, Size_ID as Sizes_ID from Admin.Sizes Where Active='True'", "Size_Name", "Sizes_ID");
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

        private void TCSize_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = DalHandlar.RunQuery(@"Select Top 20 SA.Sizes_Assign_ID, IT.Types_Name,C.Category_Name,S.Size_Name,SA.Active,SA.Created_Date from Admin.Sizes_Assign as SA
                                                          Left Join Admin.Items_Types as IT on SA.Types_ID=IT.Items_Types_ID 
                                                          Left Join admin.Category as C on SA.Category_ID=C.Category_ID
                                                          Left join Admin.Sizes as s on SA.Sizes_ID=S.Size_ID order by SA.Sizes_Assign_ID desc");
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var rowHandle = gridView1.GetFocusedRowCellValue("Sizes_Assign_ID").ToString();
            O_Size = new Models.Admin.Sizes_Assign();
            O_Size = DalHandlar.Select<string, string, Models.Admin.Sizes_Assign>("Sizes_Assign_ID", "'" + rowHandle + "'", O_Size);

            Soothmedia.General.Win.DownloadFromModel<Models.Admin.Sizes_Assign>(this, O_Size);
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
                this.Text = General.resourceManager.GetString("frmSizAssigns", General.culture);
                lblAssignSize.Text = General.resourceManager.GetString("lblAssignSize", General.culture);
                TPSize.Text = General.resourceManager.GetString("TPSize", General.culture);
                TPHistory.Text = General.resourceManager.GetString("TPHistory", General.culture);
                lblSizeID.Text = General.resourceManager.GetString("lblSizeID", General.culture);
                lblTypeName.Text = General.resourceManager.GetString("lblTypeName", General.culture);
                lblSubTypeName.Text = General.resourceManager.GetString("lblSubTypeName", General.culture);
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
