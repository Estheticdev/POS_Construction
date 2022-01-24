using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software.Reports.Barcode
{
    public partial class frmBarcodeTag : DevExpress.XtraEditors.XtraForm
    {
        public frmBarcodeTag()
        {
            InitializeComponent();
            da_Barcode = DalHandlar.cn.Adapter();
        }

        private IDbDataAdapter da_Barcode;
        private DataTable dt_Barcode = new DataTable();

        private void ResetDataGrid(string TypeID, string CategoryID )
        {
            if (dt_Barcode != null)
            {
                dt_Barcode.Clear();
            }

            var dc1 = new DataColumn("CkEStatus", typeof(Boolean));
            var dc2 = new DataColumn("Barcode_Qty", typeof(Int32));

            dt_Barcode = DalHandlar.RunQuery(@"Select ID.Item_ID, ID.Item_Barcode, Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END  as Item_Name, IT.Types_Name, C.Category_Name ,u.Unit_Name
                                             from Admin.Items_Deffination as ID 
                                             Left Join Admin.Items_Types as IT on ID.Item_Type_ID=IT.Items_Types_ID
                                             Left Join Admin.Category as C on ID.Item_Category_ID =C.Category_ID 
                                             Left Join Admin.Sizes as ItS on ID.Item_Size_ID=ItS.Size_ID
                                             Left Join Admin.Units as U on ID.Item_Unit_ID = u.Unit_ID where ID.Item_Type_ID='" + TypeID + "' AND ID.Item_Category_ID='" + CategoryID + "' and  ID.Active='True'");

            if (dt_Barcode != null)
            {
                dt_Barcode.Columns.Add(dc1);
                dt_Barcode.Columns.Add(dc2);

                foreach (DataRow dr in dt_Barcode.Rows)
                {
                    dr["Barcode_Qty"] = 1;
                }
            }
            GridBarcode.DataSource = dt_Barcode;
        }
        private void ResetDataGridSearchButton(DataTable dt)
        {
            if (dt_Barcode != null)
            {
                dt_Barcode.Clear();
            }
            var dc1 = new DataColumn();
            var dc2 = new DataColumn();
            if (!dt.Columns.Contains("CkEStatus"))
            {
                 dc1 = new DataColumn("CkEStatus", typeof(Boolean));
                 dc2 = new DataColumn("Barcode_Qty", typeof(Int32));
            }
            string str = null;
            for (int x = 0; x <= dt.Rows.Count-1; x++)
            {
                    str +=Convert.ToString(dt.Rows[x][0]) +',';
            }
           
            
             dt_Barcode = DalHandlar.RunQuery(@"Select ID.Item_ID, ID.Item_Barcode, Case When Its.Size_Name='None' then ID.Item_Name Else ID.Item_Name + ' ' + Its.Size_Name END  as Item_Name, 
                                              IT.Types_Name, C.Category_Name ,u.Unit_Name
                                              from Admin.Items_Deffination as ID 
                                              Left Join Admin.Items_Types as IT on ID.Item_Type_ID=IT.Items_Types_ID
                                              Left Join Admin.Category as C on ID.Item_Category_ID =C.Category_ID 
                                              Left Join Admin.Sizes as ItS on ID.Item_Size_ID=ItS.Size_ID
                                              Left Join Admin.Units as U on ID.Item_Unit_ID = u.Unit_ID where ID.Item_ID in ("+ str.TrimEnd(',')+")");
             
            if (dt_Barcode != null)
            {
                dt_Barcode.Columns.Add(dc1);
                dt_Barcode.Columns.Add(dc2);

                foreach (DataRow dr in dt_Barcode.Rows)
                {
                    dr["Barcode_Qty"] = 1;
                }
            }
            GridBarcode.DataSource = dt_Barcode;
        }
        private void frmBarcodeTag_Load(object sender, EventArgs e)
        {
            DalHandlar.BindLookUp(LuEItem_Types_ID, Modules.General.dtItemsType, "Types_Name", "Items_Types_ID");
            LuEItem_Types_ID.Focus();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (GridBarcode.DataSource != null)
            {
                var dt = new DataTable();
                var Rpt = new Reports.Barcode.RptBarcodeTags();
                dt = (DataTable)GridBarcode.DataSource;

                var newdt = new DataTable();
                var dc1 = new DataColumn("Item_Barcode", typeof(string));
                var dc2 = new DataColumn("Item_Name", typeof(string));
                var dc3 = new DataColumn("Barcode_Qty", typeof(string));
                newdt.Columns.Add(dc1);
                newdt.Columns.Add(dc2);
                newdt.Columns.Add(dc3);
                for (var x = 0; x <= dt.Rows.Count - 1; x++)
                {
                    if (dt.Rows[x]["CkEStatus"].Equals(true))
                    {
                        for (var y = 0; y < Convert.ToInt32(dt.Rows[x]["Barcode_Qty"]); y++)
                        {
                            newdt.Rows.Add(dt.Rows[x]["Item_Barcode"], dt.Rows[x]["Item_Name"], dt.Rows[x]["Barcode_Qty"]);
                        }
                    }
                }
                if (newdt != null)
                {
                    if (System.Windows.Forms.Application.OpenForms[2] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms[2] as frmMDI).ReportDisplay(Rpt, newdt);
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }
                GridBarcode.DataSource = null;
                dt_Barcode.Clear();
            }
        }

        private void LuEItem_Category_Leave(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                ResetDataGrid(LuEItem_Types_ID.EditValue.ToString(), LuEItem_Category.EditValue.ToString());
            }
            else
            {
                dt_Barcode.Clear();
            }
        }

        private void LuEItem_Types_ID_EditValueChanged(object sender, EventArgs e)
        {
            if (LuEItem_Types_ID.EditValue != null)
            {
                var dt = DalHandlar.RunQuery("Select Category_Name, Category_ID from Admin.Category where Type_ID =" + LuEItem_Types_ID.EditValue + "and Active='True'");
                DalHandlar.BindLookUp(LuEItem_Category, dt, "Category_Name", "Category_ID");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = Soothmedia.General.Win.Searchingform("Item Search", DalHandlar.cn, Modules.General.dtItemSearch, "'No',Code,'Name'", true, "1");
            if (Dt != null)
            {
                ResetDataGridSearchButton(Dt);
            }
        }

        private void frmBarcodeTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.F)
            {
                btnSearch_Click(sender,e);
            }
        }
    }
}
