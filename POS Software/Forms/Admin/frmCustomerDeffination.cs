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
    public partial class frmCustomerDeffination : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager resourceManager;
        CultureInfo culture;

        public frmCustomerDeffination()
        {
            InitializeComponent();
            SwitchLanguage();
        }
        private bool a;

        private Models.Admin.Customer_Deffination O_Customer = new Models.Admin.Customer_Deffination();

        public frmCustomerDeffination(object p, object p1)
        {
            InitializeComponent();
            // TODO: Complete member initialization

            LuECustomerType_ID.EditValue = p1;
            LuECustomerType_ID.Text =Convert.ToString(p);

            DataTable dtAddCustomerType = new DataTable(); dtAddCustomerType.Columns.AddRange(new DataColumn[2] { new DataColumn("Cutomer_ID"), new DataColumn("Customer_Name") });
            dtAddCustomerType.Rows.Add(p1, p);

            DalHandlar.BindLookUp(LuECustomerType_ID, dtAddCustomerType, "Customer_Name", "Cutomer_ID");

            O_Customer.Customer_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Customer_Deffination>();
            TxtCustomer_ID.Text = O_Customer.Customer_ID.ToString();

            TxtCustomer_ID.Enabled = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            LuECustomerType_ID.Enabled = false;
            TxtCustomer_Name.Focus();
            CkEActive.Checked = true;
            constructorcheck = 1;
           
        }
        int constructorcheck = 0;
        private void frmCustomerDeffination_Load(object sender, EventArgs e)
        {
            if (constructorcheck == 0)
            {

                DataTable dtAddCustomerType = new DataTable();
                dtAddCustomerType.Columns.AddRange(new DataColumn[2] { new DataColumn("Cutomer_ID"), new DataColumn("Customer_Name") });
                dtAddCustomerType.Rows.Add(2, "Regular Customer");
                DalHandlar.BindLookUp(LuECustomerType_ID, dtAddCustomerType, "Customer_Name", "Cutomer_ID");
                LuECustomerType_ID.EditValue = "2";

                Soothmedia.General.Win.Disable(this);
                TxtCustomer_ID.Enabled = false;

                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
                BtnSearch.Enabled = true;
                BtnSave.Enabled = false;
                BtnNew.Enabled = true;
                BtnCancel.Enabled = false;
                TxtCustomer_Name.Focus();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Soothmedia.General.Win.Enable(this);
            Soothmedia.General.Win.Refresh(this);

            O_Customer.Customer_ID = (Int32)DalHandlar.AutoNumber<Models.Admin.Customer_Deffination>();
            TxtCustomer_ID.Text = O_Customer.Customer_ID.ToString();

            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSearch.Enabled = false;
            BtnSave.Enabled = true;
            BtnNew.Enabled = false;
            BtnCancel.Enabled = true;
            TxtCustomer_Name.Focus();
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
                Soothmedia.General.Win.UploadToModel<Models.Admin.Customer_Deffination>(this, O_Customer);
                DalHandlar.Save<Models.Admin.Customer_Deffination>(O_Customer, "Customer_ID", TxtCustomer_ID.Text, a, true);
                Modules.General.dtRegularCustomer = DalHandlar.RunQuery("select Customer_ID as No,Customer_Name as Name,Contact_Number,Location,TaxNumber,Balance,Active from Admin.Customer_Deffination where Active='True'");
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
                var ID = DalHandlar.InputBox1("Customer Find", "Enter Customer ID");
                if (string.IsNullOrEmpty(ID) != true)
                {
                    O_Customer = new Models.Admin.Customer_Deffination();
                    O_Customer = DalHandlar.Select<string, int, Models.Admin.Customer_Deffination>("Customer_ID", int.Parse(ID), O_Customer);
                    if (Convert.ToInt32(O_Customer.Customer_ID) != 0)
                    {
                        Soothmedia.General.Win.DownloadFromModel(this, O_Customer);
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
                    DalHandlar.RunQuery("Update Admin.Customer_Deffination Set Active=0 where Customer_ID=" + TxtCustomer_ID.Text);
                    Modules.General.dtRegularCustomer = DalHandlar.RunQuery("select Customer_ID as No,Customer_Name as Name,Contact_Number,Location,Balance,Active from Admin.Customer_Deffination where Active='True'");
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
                TxtCustomer_Name.Focus();
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
                lblRegularCustomer.Text = resourceManager.GetString("lblRegularCustomer", culture);
                tabCustomer.Text = resourceManager.GetString("tabCustomer", culture);
                lblCustomerId.Text = resourceManager.GetString("lblCustomerId", culture);
                lblCustomerType.Text = resourceManager.GetString("lblCustomerType", culture);
                lblCustomerName.Text = resourceManager.GetString("lblCustomerName", culture);
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