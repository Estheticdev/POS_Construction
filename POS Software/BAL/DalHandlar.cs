using System;
using System.Collections.Generic;
using System.Linq;
using Soothmedia.Data;
using System.Data;
using System.Windows.Forms;

namespace POS_Software
{
    public static class DalHandlar
    {
        public static SoothConnectionDialogUI cd = new SoothConnectionDialogUI();
        public static IOperations cn;

        public static bool MyConnection()
        {
            var str = cd.ShowConDialog(String.Format("{0}\\{1}.scs", @Application.LocalUserAppDataPath, Application.ProductName));

            if (cd.Provider.ToString() != string.Empty || string.IsNullOrEmpty(cd.Provider.ToString()) != true || cd.Provider.ToString() != null)
            {
                if (cd.Provider.ToLower().ToString() == "System.Data.SqlClient".ToLower().ToString())
                {
                    cn = new MSSQL();
                }
                else
                {
                    if (cd.Provider.ToLower().ToString() == "System.Data.OleDb".ToLower())
                    {
                        cn = new OLEDB();
                    }
                    else
                    {
                        if (cd.Provider.ToLower() == "System.Data.Oracle".ToLower())
                        {
                            cn = new Oracle();
                        }
                        else
                        {
                            if (cd.Provider.ToLower() == "System.Data.MySQL".ToLower())
                            {
                                cn = new MySQL();
                            }
                        }
                    }
                }
            }
            return cn.Connect(str);
        }

        public static bool ChangeConnection()
        {
            var con1 = cd.ShowConDialog(String.Format("{0}\\{1}.scs", @Application.LocalUserAppDataPath, Application.ProductName));
            //var con2 = //cd.ChangeConDilog(String.Format("{0}\\{1}.scs", @Application.LocalUserAppDataPath, Application.ProductName));
            //if (con2 == con1 || con2 == string.Empty)
            //{
               return false;
            //}
            //else
            //{
            //   return true;
            //}
        }

        public static bool Connect()
        {
            return cn.Connect(cd.ShowConDialog(String.Format("{0}\\{1}.scs", @Application.LocalUserAppDataPath, Application.ProductName)));
        }

        public static bool Save<T>(T ModelObject)
        {
            return cn.Insert<T>(ModelObject);
        }
        public static void Save<T>(T ModelObject, string Keyvalue, string keyfield, bool IsEditabel, bool msg)
        {
            cn.Save<T>(ModelObject, Keyvalue, keyfield, IsEditabel, msg);
        }
        public static bool Update<T>(T ModelObject)
        {
            return cn.Update<T>(ModelObject);
        }
        public static bool Delete<T>(T ModelObject)
        {
            return cn.Delete<T>(ModelObject);
        }
        public static O Select<C, V, O>(C ConditionName, V ConditionValue, O ModelObject)
        {
            return cn.Select<C, V, O>(ConditionName, ConditionValue, ModelObject);
        }
        public static List<T> SelectAll<T>()
        {
            return cn.SelectAll<T>();
        }
        public static List<T> SelectAll<T>(string SearchingCriteria)
        {
            return cn.SelectAll<T>(SearchingCriteria);
        }

        public static DataTable RunQuery(string str)
        {
            return cn.SelectAll(str);
        }

        public static DataTable RunQuery(string str, bool UpdateUser)
        {
            //return cn.SelectAll(str, UpdateUser);
            return null;
        }

        public static string GetValue(string TabelName, string Flds, string Condition)
        {
            return cn.GetValue(TabelName, Flds, Condition, ",", 0);
        }

        public static DataTable SelectAll(string Qry)
        {
            return cn.SelectAll(Qry);
        }
        public static dynamic AutoNumber<T>()
        {
            return cn.AutoNumber<T>();
        }
        public static DataTable InitializeDataGrid(string str, DataTable DT, IDbDataAdapter da)
        {
            return cn.GridInitialize(str, DT, da);
        }
        public static void SaveGridData(DataTable dt, IDbDataAdapter da)
        {
            cn.GridSave(dt, da);
        }

        public static void BindLookUp(DevExpress.XtraEditors.GridLookUpEdit cmb, string Qry, string DispMember, string ValueMember)
        {
            cmb.Properties.DataSource = cn.SelectAll(Qry);
            cmb.Properties.DisplayMember = DispMember;
            cmb.Properties.ValueMember = ValueMember;
            cmb.Refresh();
        }
        public static void BindLookUp(DevExpress.XtraEditors.GridLookUpEdit cmb, DataTable DT, string DispMember, string ValueMember)
        {
            cmb.Properties.DataSource = DT;
            cmb.Properties.DisplayMember = DispMember;
            cmb.Properties.ValueMember = ValueMember;
            cmb.Refresh();
        }
        public static void BindLookUp(DevExpress.XtraEditors.LookUpEdit cmb, string Qry, string DispMember, string ValueMember)
        {
            cmb.Properties.DataSource = cn.SelectAll(Qry);
            cmb.Properties.DisplayMember = DispMember;
            cmb.Properties.ValueMember = ValueMember;
            cmb.Refresh();
        }
        public static void BindLookUp(DevExpress.XtraEditors.LookUpEdit cmb, DataTable DT, string DispMember, string ValueMember)
        {
            cmb.Properties.DataSource = DT;
            cmb.Properties.DisplayMember = DispMember;
            cmb.Properties.ValueMember = ValueMember;
            cmb.Refresh();
        }
        public static void BindLookUp(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmb, string Qry, string DispMember, string ValueMember)
        {
            cmb.DataSource = cn.SelectAll(Qry);
            cmb.DisplayMember = DispMember;
            cmb.ValueMember = ValueMember;
        }
        public static void BindLookUp(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmb, DataTable DT, string DispMember, string ValueMember)
        {
            cmb.DataSource = DT;
            cmb.DisplayMember = DispMember;
            cmb.ValueMember = ValueMember;
        }
        public static void BindLookUp(DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb, string Qry, string DispMember, string ValueMember)
        {
            cmb.DataSource = cn.SelectAll(Qry);
            cmb.DisplayMember = DispMember;
            cmb.ValueMember = ValueMember;
        }
        public static void BindLookUp(DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmb, DataTable DT, string DispMember, string ValueMember)
        {
            cmb.DataSource = DT;
            cmb.DisplayMember = DispMember;
            cmb.ValueMember = ValueMember;
        }
        public static void BindCheckedCombo(DevExpress.XtraEditors.CheckedComboBoxEdit cmb, string Qry, string DispMember, string ValueMember)
        {
            cmb.Properties.DataSource = cn.SelectAll(Qry);
            cmb.Properties.DisplayMember = DispMember;
            cmb.Properties.ValueMember = ValueMember;
            cmb.Refresh();
        }
        public static void BindCheckedCombo(DevExpress.XtraEditors.CheckedComboBoxEdit cmb, DataTable DT, string DispMember, string ValueMember)
        {
            cmb.Properties.DataSource = DT;
            cmb.Properties.DisplayMember = DispMember;
            cmb.Properties.ValueMember = ValueMember;
            cmb.Refresh();
        }
        public static void BindCheckedCombo(DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit cmb, string Qry, string DispMember, string ValueMember)
        {
            cmb.DataSource = cn.SelectAll(Qry);
            cmb.DisplayMember = DispMember;
            cmb.ValueMember = ValueMember;
        }
        public static void BindCheckedCombo(DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit cmb, DataTable DT, string DispMember, string ValueMember)
        {
            cmb.DataSource = DT;
            cmb.DisplayMember = DispMember;
            cmb.ValueMember = ValueMember;
        }
        public static bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (formType.Name == form.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public static OpenFileDialog BrowesPicture()
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.jpg)|*.jpg|png files (*.png)|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    return dlg;
                }
                else
                {
                    return null;
                }
            }
        }

        public static string InputBox1(string Title, string promptText)
        {
            var Value = string.Empty;
            if (InputBox.Input.Show(Title, promptText, ref Value) == DialogResult.OK)
            {
                return Value;
            }
            else
            {
                return null;
            }
        }

        public static bool BtnNew(bool IsEnabel, string FormText)
        {
            try
            {
                if (IsEnabel)
                {
                    if (Convert.ToBoolean(Modules.General.dtSecuarityRules.Select("CommandName='" + FormText + "'").CopyToDataTable().Rows[0]["New"]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool BtnSave(bool IsEnabel, string FormText)
        {
            try
            {
                if (IsEnabel)
                {
                    if (Convert.ToBoolean(Modules.General.dtSecuarityRules.Select("CommandName='" + FormText + "'").CopyToDataTable().Rows[0]["Save"]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool BtnSearch(bool IsEnabel, string FormText)
        {
            try
            {
                if (IsEnabel)
                {
                    if (Convert.ToBoolean(Modules.General.dtSecuarityRules.Select("CommandName='" + FormText + "'").CopyToDataTable().Rows[0]["Search"]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool BtnEdit(bool IsEnabel, string FormText)
        {
            try
            {
                if (IsEnabel)
                {
                    if (Convert.ToBoolean(Modules.General.dtSecuarityRules.Select("CommandName='" + FormText + "'").CopyToDataTable().Rows[0]["Edit"]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool BtnDelete(bool IsEnabel, string FormText)
        {
            try
            {
                if (IsEnabel)
                {
                    if (Convert.ToBoolean(Modules.General.dtSecuarityRules.Select("CommandName='" + FormText + "'").CopyToDataTable().Rows[0]["Delete"]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static void BindcheckedListBoxControl(DevExpress.XtraEditors.CheckedListBoxControl cmb, DataTable Qry, string DispMember, string ValueMember)
        {
            cmb.DataSource = Qry;
            cmb.DisplayMember = DispMember;
            cmb.ValueMember = ValueMember;
        }
        public static void LatterPrientConform(string Name, string DepartmentName, string Date)
        {
        }
    }
}

