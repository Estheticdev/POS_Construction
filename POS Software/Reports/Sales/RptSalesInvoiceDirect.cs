using DevExpress.XtraReports.UI;
using QRCoder;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace POS_Software.Reports.Sales
{
    public partial class RptSalesInvoiceDirect : DevExpress.XtraReports.UI.XtraReport
    {

        public RptSalesInvoiceDirect()
        {
            InitializeComponent();
        }
        DataTable value = new DataTable();
        public RptSalesInvoiceDirect(DataTable dt)
        {

            InitializeComponent();
            value = dt;
          
        }

        private void lblDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            lblDate.Text = "تاريخ : ";
            lblInvoiceNumber.Text = ": رقم الفاتوره";
            lblProductName.Text = "البيان";
            lblPrice.Text = "السعر الوحدة";
            lblQuantity.Text = "عدد";
            lblAmount.Text = "السعر الأجمالي";
            lbltaxamount.Text = "قيمة الضريبة المضافة    %15";
            lblnetamount.Text = "الصافي";
           
        }

            private void lblGreeting_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblGreeting.Text = "شكرا لك على التسوق معنا";
            
            xrLabel2.Text = value.Rows[0]["Customer"].ToString();
            ldDate.Text = value.Rows[0]["Date"].ToString();
            ldInvoiceNo.Text = value.Rows[0]["InvoiceNumber"].ToString();
       

            lblStoreName.Text =  Modules.General.dtStoredeff.Rows[0]["Store_Name"].ToString(); 
            lblAddress.Text = Modules.General.dtStoredeff.Rows[0]["Address"].ToString();
            lblNumber.Text = Modules.General.dtStoredeff.Rows[0]["Cell_Number"].ToString();
            lblVATNUmber.Text= "VAT#-"+ Modules.General.dtStoredeff.Rows[0]["TaxNumber"].ToString();


            //lblStoreName.Text = "Super Mart Reciept";
            //lblAddress.Text = "H#123, St#08, TajhBagh Lahore";
            //lblNumber.Text = "Cell Number: 0323-8046756";
        }

        private void lblGrandTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //lblGrandTotal.Text = "Grand Total : ";
            //lblRecievedCash.Text = "Recieved Cash : ";
            //lblBalance.Text = "Balance : ";
            lblGrandTotal.Text = ": السعر الأجمالي قبل الضريبة";
            lblRecievedCash.Text = "إعادة ينخل النقدية : ";
            lblBalance.Text = "توازن : ";
            string date = Convert.ToDateTime(ldDate.Text).ToString(("yyyy-MM-ddTHH:mm:ssZ"));
            //string date = Convert.ToDateTime(strdate[0]).ToString("yyyy-MM-dd") + "T" + strdate[1] + "Z";
             barcodegenerator(lblStoreName.Text, Modules.Main.LicenceVAT, date, value.Rows[0]["ShopAmount"].ToString(), value.Rows[0]["TaxAmount"].ToString());
            //////
            //lblUserName.Text = "Sales User :";
            //lbltaxamount.Text = "Tax Amount 15%:";
            //lblnetamount.Text = "Net Price:";
           
            taxamount.Text = value.Rows[0]["TaxAmount"].ToString();
            xrLabel3.Text = value.Rows[0]["ShopAmount"].ToString();
            

            xrLabel1.Text = ": اسم الشركة";
            lblUserName.Text = "مستخدم المبيعات :";
            lbltaxamount.Text = "مبلغ الضريبة %15:";
            lblnetamount.Text = "صافي السعر:";
            xrLabel1.Text = ": اسم الشركة";
            //lblImportantNote.Text = "GOODS ONCE SOLD CAN BE RETURNED OR EXCHANGE WITH ORIGIONAL INVOICE WITHIN THREE DAYS";
            //lblImportantInstruction.Text = "Open 7 days a week from 7:00 AM to 10:00 PM. Counter can be close due to prayer break.";
        }
        void barcodegenerator(string namelength, string vat, string Date, string total, string tax)
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
                int qqqq = b - withoutspac;
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
            string value = "" + d + namelength + "" + dd + vat + "" + ddd + Date + "" + dddd + total + "" + ddddd + tax;
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(value);
            var qq = Convert.ToBase64String(bytes);
            //textBox1.Text = encodeddata;
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qq, QRCodeGenerator.ECCLevel.Q);
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
            xrLabel1.Text = ": اسم الشركة";
        }

        private void TblVendor_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            LblApplicationName.Text = Modules.Main.ApplicationName;
            LblVendorName.Text = Modules.Main.VendorName;
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

        private void ldRecievedCash_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ldRecievedCash.Text = value.Rows[0]["RecievedCash"].ToString();
            ldBalance.Text = value.Rows[0]["Balance"].ToString();
        }

        private void ldGrandTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ldGrandTotal.Text = value.Rows[0]["GrandTotal"].ToString();
        }

        private void ldProduct_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ldProduct.Text = value.Rows[CurrentRowIndex]["Item_Name"].ToString();
              ldPrice.Text = value.Rows[CurrentRowIndex]["Item_Sale_Price"].ToString();
            ldQty.Text = value.Rows[CurrentRowIndex]["Qty"].ToString();
            ldAmount.Text = value.Rows[CurrentRowIndex]["Amount"].ToString();
        }

        private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string date = Convert.ToDateTime(ldDate.Text).ToString(("yyyy-MM-ddTHH:mm:ssZ"));
            barcodegenerator(lblStoreName.Text, Modules.Main.LicenceVAT, date, value.Rows[0]["ShopAmount"].ToString(), value.Rows[0]["TaxAmount"].ToString());
        }
        private void xrpaymenttype_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrpaymenttype.Text = "نوع الدفع";
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

        private void ldpaymenttype_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ldBalance.Text = value.Rows[0]["paymenttype"].ToString();
        }
    }
}
