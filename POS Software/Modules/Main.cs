using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace POS_Software.Modules
{
    internal static class Main
    {
        
        //Application Setting
        //public static string ApplicationName = "Ali Supper Store Management System";
        //public static string VendorName = "Esthetic Developers (Pvt.) Ltd.";
        //public static string VendorAddress = "Office 58-C Chaman street taj bagh phase 3. Lahore";
        //public static string VendorContact = "Phone: 0423-733-5658";
        //public static string VendorEmail = "info@estheticdeveloper.com";
        //public static string LicenseName = "Ali Super Mart";
        //public static string LicenceAddress = "Ali Super Mart Jhandiala Road Shaikhpura";
        //public static string LicenceType = "LPT";
        //public static string LicenceContact = "Phone Number: 03238046756";
        //Application Setting

        public static string ApplicationName = "Esthetic Point Of Sale";
        public static string VendorName = "Esthetic Developers (Pvt.) Ltd.";
        public static string VendorAddress = "Office 58-C Chaman street taj bagh phase 3. Lahore, Pakistan";
        public static string VendorContact = "Phone: 0092-323-4967141";
        public static string VendorEmail = "info@estheticdeveloper.com";

        public static string LicenseName = Modules.General.dtStoredeff != null ? Modules.General.dtStoredeff.Rows[0]["Store_Name"].ToString() : "";
        public static string LicenceAddress = Modules.General.dtStoredeff != null ? Modules.General.dtStoredeff.Rows[0]["Address"].ToString() : "";
        public static string LicenceType = "LPT";
        public static string LicenceContact =Modules.General.dtStoredeff != null ? Modules.General.dtStoredeff.Rows[0]["Cell_Number"].ToString() : "";
        public static string LicenceVAT = Modules.General.dtStoredeff != null ? Modules.General.dtStoredeff.Rows[0]["TaxNumber"].ToString() : "";
        public static void AlphabetsCheck(KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^a-zA-Z\s\b]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
        }

        public static void NumericCheck(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public static void DecimalPointCheck(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9.\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public static void AlphaNumericCheck(KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
        }

        public static void ParagraphCheck(KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^a-zA-Z0-9\s\b.,]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
        }

        public static void WebsiteCheck(KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^a-zA-Z0-9\b.\\]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
        }

        public static void EmailCheck(KeyPressEventArgs e)
        {
            //var regex = new Regex(@"[^a-zA-Z0-9\b._@]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //{
            //    e.Handled = true;
            //}
        }

        //Shortcut Messaging
        public static string MsgDeleting = "Are you sure you want to delete";
        public static string MsgSave = "Record Saved";
        public static string MsgClose = "Are you sure you want to close with out Save";
        public static string MsgSearchError = "Record not found";
        public static string MsgException = "Unable to Save Record.";
        public static string Msgdeleted = "Record has been Delete successfully.";

        public static string DateFormat = "{0:dd,MMM yyyy}";
        public static string DateFormat1 = "dd,MMM yyyy";
        public static string DateFormat2 = "{0:dd,MMM yyyy hh:mm:ss tt}";

        public static string Report1Sorting = "Name";
        public static string Report2Sorting = "GroupsName,EmployeeCode";
        public static string Report3Sorting = "DepartmentName,SectionName,EmployeeCode";
    }
}
