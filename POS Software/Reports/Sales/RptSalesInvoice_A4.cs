
using POS_Software.Modules;
using QRCoder;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace POS_Software.Reports.Sales
{
    public partial class RptSalesInvoice_A4 : DevExpress.XtraReports.UI.XtraReport
    {
        public RptSalesInvoice_A4()
        {
            InitializeComponent();
           // currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));

            dtdata = DalHandlar.RunQuery("Select * from Admin.Store_Deffination");
        }
        DataTable dtdata = new DataTable();
        private void lblDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
            
        }
      //  List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        private void lblGreeting_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
          
        }

        private void lblGrandTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblGrandTotal.Text = "السعر الأجمالي قبل الضريبة";
            lblRecievedCash.Text = "إعادة ينخل النقدية";
            lblBalance.Text = "توازن";
            string date = Convert.ToDateTime(ldDate.Text).ToString(("yyyy-MM-ddTHH:mm:ssZ"));
           //string date = Convert.ToDateTime(strdate[0]).ToString("yyyy-MM-dd") + "T" + strdate[1] + "Z";
            barcodegenerator(lblenglishname.Text, Modules.Main.LicenceVAT, date, xrLabel3.Text, xrLabel4.Text);
            
            xrPictureBox2.Visible = true;
            lblUserName.Text = "مستخدم المبيعات";
            lbltaxamount.Text = "الضريبة المضافة 15%";
            lblnetamount.Text = "الأجمالي بعد الضريبة";
            // xrLabel1.Text = ": اسم الشركة";
            xrLabel1.Text = " فاتوره إلى";
            xrLabel5.Text = " رقم الضريبة عميل";
            xrLabel7.Text = " هاتف";
            xrPictureBox1_BeforePrint(sender, e); 
            //lblImportantNote.Text = "GOODS ONCE SOLD CAN BE RETURNED OR EXCHANGE WITH ORIGIONAL INVOICE WITHIN THREE DAYS";
            //lblImportantInstruction.Text = "Open 7 days a week from 7:00 AM to 10:00 PM. Counter can be close due to prayer break.";
        }
        void barcodegenerator(string namelength,string vat,string Date,string total,string tax)
        {
            int b = namelength.Length;
            int bb = vat.Length;
            int bbb = Date.Length;
            int bbbb = total.Length;
            int bbbbb = tax.Length;
            Regex regex1 = new Regex(@"^[a-zA-Z0-9_ ]+$");
            char c;
            if (regex1.IsMatch(namelength))
            {
                 c = Convert.ToChar(b);
            }
            else
            {
                string withoutspace = namelength.Replace(" ", "");
                int withoutspac = withoutspace.Length;
                int qqqq = b-withoutspac;
                int qqq = (withoutspac * 2) + qqqq;
                 c = Convert.ToChar(qqq);
            }
            char cc = Convert.ToChar(bb);
            char ccc = Convert.ToChar(bbb);
            char cccc = Convert.ToChar(bbbb);
            char ccccc = Convert.ToChar(bbbbb);
            string d = c.ToString();
            string dd = cc.ToString();
            string ddd = ccc.ToString();
            string dddd = cccc.ToString();
            string ddddd = ccccc.ToString();
            string value = "" + d + namelength + "" + dd + vat + "" + ddd + Date+ "" + dddd + total+ "" + ddddd + tax;
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(value);
            var qq = Convert.ToBase64String(bytes);
            //textBox1.Text = encodeddata;
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qq, QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(data);
            xrPictureBox1.Image = code.GetGraphic(2);
            xrPictureBox1.Visible = true;
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void GroupFooter1_BandLevelChanged(object sender, EventArgs e)
        {

        }

        private void GroupFooter1_AfterPrint(object sender, EventArgs e)
        {

        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrLabel1.Text = ": اسم الشركة";
            xrLabel1.Text = ": فاتوره إلى";
            xrLabel5.Text = ": رقم الضريبة عميل";
            xrLabel7.Text = ": هاتف";
        }

        private void TblVendor_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblApplicationName.Text = Modules.Main.ApplicationName;
            LblVendorName.Text = Modules.Main.VendorName;
        }

        private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((bool)Modules.General.dtsetting.Rows[8]["Setting_Value"] == true)
            {
                xrPictureBox1.Visible = true;
                string date = Convert.ToDateTime(ldDate.Text).ToString(("yyyy-MM-ddTHH:mm:ssZ"));
                barcodegenerator(lblenglishname.Text, Modules.Main.LicenceVAT, date, xrLabel3.Text, xrLabel4.Text);

            }
            else
            {
                xrPictureBox1.Visible = false;
            }
        }

        private void ldBalance_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrPictureBox1_BeforePrint( sender, e);
        }

        private void lblGrandTotal_AfterPrint(object sender, EventArgs e)
        {
            
        }

        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrLabel1.Text = ": اسم الشركة";
            xrLabel1.Text = ": فاتوره إلى";
            xrLabel5.Text = ": رقم الضريبة عميل";
            xrLabel7.Text = ": هاتف";
        }

        private void xrPictureBox2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var dt = new DataTable();
            dt = DalHandlar.RunQuery("Select Logo_Image from Admin.Store_Deffination");
            try
            {
                xrPictureBox2.Image = Soothmedia.General.Images.ReadImage((Byte[])(dt.Rows[0]["Logo_Image"]));
            }
            catch
            {
            }
           
        }

        private void xrPanel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblDate.Text = " التاريخ:";
            lblInvoiceNumber.Text = "رقم الفاتوره:";
            lblProductName.Text = "البيان";
            lblPrice.Text = "السعر الوحدة";
            xrbarcode.Text = ": رقم منتاج";
            // lblPackPrice.Text = "سعر العبوة";
            lblQuantity.Text = "عدد";
            lblAmount.Text = "السعر الأجمالي";
            lbltaxamount.Text = "قيمة الضريبة المضافة    %15";
            lblnetamount.Text = "الصافي";
            lblNumber.Text = Modules.General.dtStoredeff.Rows[0]["CR_Number"].ToString()+ "س ر: ";
            lblEnglishcontact.Text = "CR# "+ Modules.General.dtStoredeff.Rows[0]["CR_Number"].ToString();
            lblGreeting.Text = "شكرا لك على التسوق معنا";

            lblStoreName.Text = Modules.General.dtStoredeff.Rows[0]["Store_Name"].ToString();
            lblenglishname.Text = Modules.General.dtStoredeff.Rows[0]["English_Name"].ToString() ;
            lblAddress.Text = Modules.General.dtStoredeff.Rows[0]["Address"].ToString();
            lblNumber.Text = Modules.General.dtStoredeff.Rows[0]["Cell_Number"].ToString() + ": الجوال";
            lblVATNUmber.Text = Modules.General.dtStoredeff.Rows[0]["TaxNumber"].ToString() + ": رقم الضريبة";
            lblenglishVAT.Text = "VAT# " + Modules.General.dtStoredeff.Rows[0]["TaxNumber"].ToString();



        }

        private void xrShopComments_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrLabel9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var dt1 = new DataTable();
            dt1 = DalHandlar.RunQuery(@"DECLARE @STRING NVARCHAR(MAX) 
                DECLARE @SPECIALCHARACTER CHAR(1) 
                SET @STRING = (select Setting_Text from admin.Setting where SettingID = 5)
                SELECT * 
                FROM   STRING_SPLIT (@STRING, '|')");
            try
            {
                xrLabel9.Text = "";
                if (dt1 != null)
                {
                    for (int x = 0; x < dt1.Rows.Count; x++)
                    {

                        xrLabel9.Text = xrLabel9.Text + " \n" + dt1.Rows[x]["value"].ToString();
                    }
                }
            }
            catch
            {
            }
        }

        private void xremglishemail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
            try
            {
                xremglishemail.Text= dtdata.Rows[0]["Email"].ToString();
            }
            catch
            {
            }

        }

        private void xrenglishlicenseNumber_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrenglishlicenseNumber.Text = dtdata.Rows[0]["licensenumber"].ToString();
            }
            catch
            {
            }
        }

        private void xrenglishaddress_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrenglishaddress.Text = dtdata.Rows[0]["englishaddress"].ToString();
            }
            catch
            {
            }
        }

        private void xrLabel13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel13.Text = "خصم";
        }

        private void xrLabel12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel12.Text  = ": السعر الأجمالي قبل الضريبة"; 
        }

        private void xrLabel14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                Arabicemail.Text = dtdata.Rows[0]["Email"].ToString();
            }
            catch
            {
            }
        }

        private void xrLabel15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                arabiclicensenumber.Text = dtdata.Rows[0]["licensenumber"].ToString();
            }
            catch
            {
            }
        }

        private void xrarabicwords_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((bool)Modules.General.dtsetting.Rows[7]["Setting_Value"] == true)
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(xrLabel3.Text), new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
                //txtEnglishWord.Text = toWord.ConvertToEnglish();
                xrarabicwords.Text = toWord.ConvertToArabic();
            }
        }

        private void xrcc1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
            xrcc1.Visible = (bool)Modules.General.dtsetting.Rows[9]["Setting_Value"];
            xrcc2.Visible = (bool)Modules.General.dtsetting.Rows[10]["Setting_Value"];
            xrlocation.Visible = (bool)Modules.General.dtsetting.Rows[11]["Setting_Value"];

        }

        private void xrpaymenttype_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrpaymenttype.Text = "نوع الدفع";
        }

        private void ldpaymenttype_AfterPrint(object sender, EventArgs e)
        {
            //string x = ldpaymenttype.Text;
            //if (x == "1")
            //    ldpaymenttype.Text = "Cash";
        }

        private void ldpaymentname_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string x = ldpaymenttype.Text;
            if (x == "1")
                ldpaymentname.Text = "Cash";
            else if (x == "2")
                ldpaymentname.Text = "Bank";
            else if (x == "3")
                ldpaymentname.Text = "Credit";
            else
                ldpaymentname.Text = "";
        }

        private void xrLabel14_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel14.Text = "Total Amount";
        }

        private void xrLabel15_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel15.Text = "Taxable Invoice";
        }
    }
}

