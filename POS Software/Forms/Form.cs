using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Forms
{
    public static class Form
    {
        public static void UserRole(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmUserRole)))
            {
                var UserRole = new Forms.Admin.frmUserRole();
                UserRole.MdiParent = MDIForm;
                UserRole.Show();
            }
        }
        public static void CreateUser(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.FrmCreateSecurity)))
            {
                var CreateUsers = new Forms.Admin.FrmCreateSecurity();
                CreateUsers.MdiParent = MDIForm;
                CreateUsers.Show();
            }
        }

        public static void ItemsType(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmTypes)))
            {
                var ItemsTypes = new Forms.Admin.frmTypes();
                ItemsTypes.MdiParent = MDIForm;
                ItemsTypes.Show();
            }
        }

        public static void ItemCategory(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmSubtype)))
            {
                var Categorys = new Forms.Admin.frmSubtype();
                Categorys.MdiParent = MDIForm;
                Categorys.Show();
            }
        }

        public static void ItemSize(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmSizes)))
            {
                var ItemSizes = new Forms.Admin.frmSizes();
                ItemSizes.MdiParent = MDIForm;
                ItemSizes.Show();
            }
        }
        public static void SizeAssign(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmSizAssigns)))
            {
                var ItemSizes = new Forms.Admin.frmSizAssigns();
                ItemSizes.MdiParent = MDIForm;
                ItemSizes.Show();
            }
        }
        public static void ItemUnit(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmUnits)))
            {
                var ItemUnits = new Forms.Admin.frmUnits();
                ItemUnits.MdiParent = MDIForm;
                ItemUnits.Show();
            }
        }

        public static void UnitsAssin(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmUnitAssign)))
            {
                var UnitsAssign = new Forms.Admin.frmUnitAssign();
                UnitsAssign.MdiParent = MDIForm;
                UnitsAssign.Show();
            }
        }
        public static void ItemsDeffinition(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmItems_Deffination)))
            {
                var ItemDeffinition = new Forms.Admin.frmItems_Deffination();
                ItemDeffinition.MdiParent = MDIForm;
                ItemDeffinition.Show();
            }
        }

        public static void ItemsBarcode(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Reports.Barcode.frmBarcodeTag)))
            {
                var ItemsBarcode = new Reports.Barcode.frmBarcodeTag();
                ItemsBarcode.MdiParent = MDIForm;
                ItemsBarcode.Show();
            }
        }

        public static void ItemSals(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Sales.frmSalesInvoices)))
            {
                var Invoice = new Forms.Sales.frmSalesInvoices();
                Invoice.MdiParent = MDIForm;
                Invoice.Show();
            }
        }
        public static void ItemStock(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Stock.FrmStock)))
            {
                var Stock = new Forms.Stock.FrmStock();
                Stock.MdiParent = MDIForm;
                Stock.Show();
            }
        }
        public static void StoreDeff(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmStore_Deffination)))
            {
                var Storedeff = new Forms.Admin.frmStore_Deffination();
                Storedeff.MdiParent = MDIForm;
                Storedeff.Show();
            }
        }
        public static void SalesRetruns(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Sales.frmSalesReturns)))
            {
                var Storedeff = new Forms.Sales.frmSalesReturns();
                Storedeff.MdiParent = MDIForm;
                Storedeff.Show();
            }
        }
        public static void SalesPayment(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Sales.frmCPayment)))
            {
                var Storedeff = new Forms.Sales.frmCPayment();
                Storedeff.MdiParent = MDIForm;
                Storedeff.Show();
            }
        }
        public static void AddCustomer(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmCustomerDeffination)))
            {
                var Storedeff = new Forms.Admin.frmCustomerDeffination();
                Storedeff.MdiParent = MDIForm;
                Storedeff.Show();
            }
        }
        public static void AddVendor(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Admin.frmVendorDefinition)))
            {
                var Storedeff = new Forms.Admin.frmVendorDefinition();
                Storedeff.MdiParent = MDIForm;
                Storedeff.Show();
            }
        }
        public static void PurchaseInvoice(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Forms.Purchase.frmPurchaseInvoices)))
            {
                var Storedeff = new Forms.Purchase.frmPurchaseInvoices();
                Storedeff.MdiParent = MDIForm;
                Storedeff.Show();
            }
        }

        public static void VATReport(DevExpress.XtraEditors.XtraForm MDIForm)
        {
            if (!DalHandlar.IsFormOpen(typeof(Reports.Purchase.frmPSVAT)))
            {
                var VATReport = new Reports.Purchase.frmPSVAT();
                VATReport.MdiParent = MDIForm;
                VATReport.Show();
            }
        }
    }
}
