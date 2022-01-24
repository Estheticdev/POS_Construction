using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Globalization;
using System.Resources;
using System.Net;

namespace POS_Software.Modules
{
    public static class General
    {
        internal static DataTable dtUserRole = new DataTable();
        internal static DataTable dtBasicSecurty = new DataTable();
        internal static DataTable dtloginUser = new DataTable();
        internal static DataTable dtSecuarityRules = new DataTable();
        internal static DataTable dtItemsType = new DataTable();
        internal static DataTable dtCategory = new DataTable();
        internal static DataTable dtSizes = new DataTable();
        internal static DataTable dtSizesAssign = new DataTable();
        internal static DataTable dtUnitAssign = new DataTable();
        internal static DataTable dtUnits = new DataTable();
        internal static DataTable dtItems_Deffination = new DataTable();
        internal static DataTable dtItemSearch = new DataTable();
        internal static DataTable dtStoredeff = new DataTable();
        internal static DataTable dtRegularCustomer = new DataTable();
        internal static DataTable dtRegularVendor = new DataTable();
        internal static DataTable dtsetting = new DataTable();
        internal static ResourceManager resourceManager;
        internal static CultureInfo culture;
        internal static string  userrole="";


        public static void POSLoad()
        {
            dtsetting = DalHandlar.RunQuery("select * from admin.setting");
            dtUserRole = DalHandlar.RunQuery("select * from Admin.User_Role Where Active='True'");
            dtBasicSecurty = DalHandlar.RunQuery("select * from Admin.Create_User Where Active='True'");
            dtloginUser = DalHandlar.RunQuery("SELECT * FROM [dbo].[Vw_login] where Active = 'True'");
            dtItemsType = DalHandlar.RunQuery("select * from Admin.Items_Types Where Active='True'");
            dtCategory = DalHandlar.RunQuery("select * from Admin.Category Where Active='True'");
            dtSizes = DalHandlar.RunQuery("select * from Admin.Sizes Where Active='True'");
            dtSizesAssign = DalHandlar.RunQuery("select * from Admin.Sizes_Assign Where Active='True'");
            dtUnitAssign = DalHandlar.RunQuery("select * from Admin.Unit_Assign Where Active='True'");
            dtUnits = DalHandlar.RunQuery("select * from Admin.Units Where Active='True'");
            dtItems_Deffination = DalHandlar.RunQuery("select * from Admin.Items_Deffination Where Active='True'");
            dtItemSearch = DalHandlar.RunQuery("select * from Admin.VwItemSearch");
            dtStoredeff = DalHandlar.RunQuery("Select * from Admin.Store_Deffination where Active='True'");
            dtRegularCustomer = DalHandlar.RunQuery("select Customer_ID as No,Customer_Name as Name,Contact_Number,Location,Balance,Active from Admin.Customer_Deffination where Active='True'");
            dtRegularVendor = DalHandlar.RunQuery("select Vendor_ID as No,Vendor_Name as Name,Contact_Number,Location,Balance,Active from Admin.Vendor_Definition where Active='True'");
        }
    }

    public class MachineInfo
    {
        public string MyProperty { get; set; }
        public string DeviceName { get; set; }
        public string LicenseStatus { get; set; }
        public int LicenseDuration { get; set; }
    }

    public class ResponseModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public MachineInfo Data { get; set; }
    }
}
