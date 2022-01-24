using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Resources;
using System.Globalization;
using POS_Software.Modules;

namespace POS_Software.Forms.Admin
{
    public partial class frmVendorDefinition : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager resourceManager;
        CultureInfo culture;

        public frmVendorDefinition()
        {
            InitializeComponent();
            SwitchLanguage();
        }
        private bool a;

        private Models.Admin.Vendor_Definition O_Vendor = new Models.Admin.Vendor_Definition();

        public frmVendorDefinition(object p, object p1)
        {
            InitializeComponent();
            // TODO: Complete member initialization

            //DataTable dtAddCustomerType = new DataTable(); dtAddCustomerType.Columns.AddRange(new DataColumn[2] { new DataColumn("Cutomer_ID"), new DataColumn("Customer_Name") });
            //dtAddCustomerType.Rows.Add(p1, p);

            //DalHandlar.BindLookUp(LuECustomerType_ID, dtAddCustomerType, "Customer_Name", "Cutomer_ID");

            O_Vendor.Vendor_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Vendor_Definition>();
            TxtVendor_ID.Text = O_Vendor.Vendor_ID.ToString();

            TxtVendor_ID.Enabled = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtVendor_Name.Focus();
            CkEActive.Checked = true;
            constructorcheck = 1;
           
        }
        int constructorcheck = 0;
        private void frmCustomerDeffination_Load(object sender, EventArgs e)
        {
            if (constructorcheck == 0)
            {

               
                Soothmedia.General.Win.Disable(this);
                TxtVendor_ID.Enabled = false;

                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                BtnSearch.Enabled = true;
                BtnSave.Enabled = false;
                BtnNew.Enabled = true;
                BtnCancel.Enabled = false;
                TxtVendor_Name.Focus();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_Vendor.Vendor_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Vendor_Definition>();
            TxtVendor_ID.Text = O_Vendor.Vendor_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtVendor_Name.Focus();
            CkEActive.Checked = true;
        
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
        int Activecheck = 0;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                Soothmedia.General.Win.UploadToModel<Models.Admin.Vendor_Definition>(this, O_Vendor);
                DalHandlar.Save<Models.Admin.Vendor_Definition>(O_Vendor, "Vendor_ID", TxtVendor_ID.Text, a, true);
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
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = DalHandlar.InputBox1("Vendor Find", "Enter Vendor ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Vendor = new Models.Admin.Vendor_Definition();
                    O_Vendor = DalHandlar.Select<string, int, Models.Admin.Vendor_Definition>("Vendor_ID", int.Parse(ID), O_Vendor);
                    if (Convert.ToInt32(O_Vendor.Vendor_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_Vendor);
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
                    DalHandlar.RunQuery("Update Admin.Vendor_Definition Set Active=0 where Vendor_ID=" + TxtVendor_ID.Text);
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
                TxtVendor_Name.Focus();
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

        private void SwitchLanguage()
        {
            resourceManager = General.resourceManager;
            culture = General.culture;

            if (culture != null)
            {
                this.Text = resourceManager.GetString("frmCustomerDeffination", culture);
                lblRegularVendor.Text = resourceManager.GetString("lblRegularVendor", culture);
                tabVendor.Text = resourceManager.GetString("tabVendor", culture);
                lblVendorID.Text = resourceManager.GetString("lblVendorID", culture);
                lblVendorName.Text = resourceManager.GetString("lblVendorName", culture);
                lblContactNumber.Text = resourceManager.GetString("lblContactNumber", culture);
                lblLocation.Text = resourceManager.GetString("lblLocation", culture);
                lblTaxNumber.Text = resourceManager.GetString("lblTaxNumber", culture);
                lblBalance.Text = resourceManager.GetString("lblBalance", culture);
                CkEActive.Text = resourceManager.GetString("CkEActive", culture);

                BtnNew.Text = resourceManager.GetString("BtnNew", culture);
                BtnSave.Text = resourceManager.GetString("BtnSave", culture);
                BtnEdit.Text = resourceManager.GetString("BtnEdit", culture);
                BtnSearch.Text = resourceManager.GetString("BtnSearch", culture);
                BtnDelete.Text = resourceManager.GetString("BtnDelete", culture);
                BtnCancel.Text = resourceManager.GetString("BtnCancel", culture);
            }
        }
    }
}