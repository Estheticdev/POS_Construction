using QRCoder;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace POS_Software.Reports.Sales
{
    public partial class RptSalesInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        private DataTable dt;

        public RptSalesInvoice()
        {
            InitializeComponent();
        }

        public RptSalesInvoice(DataTable dt)
        {
            this.dt = dt;
        }

        private void lblDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //lblDate.Text = "Date : ";
            //lblInvoiceNumber.Text = "Invoice # : ";
            //lblProductName.Text = "Product";
            //lblPrice.Text = "Unit Price";
            //lblPackPrice.Text = "Pack Price";
            //lblQuantity.Text = "Qty";
            //lblAmount.Text = "Amount";
            //lbltaxamount.Text = "Tax Amount 15%";
            //lblnetamount.Text = "Net Price";
            lblDate.Text = "تاريخ : ";
            lblInvoiceNumber.Text = ": رقم الفاتوره";
            lblProductName.Text = "البيان";
            lblPrice.Text = "السعر الوحدة";
            //lblPackPrice.Text = "سعر العبوة";
            //lblQuantity.Text = "الكمية";
            //lblAmount.Text = "السعر الأجمالي";
            //lbltaxamount.Text = "قيمة الضريبة المضافة    %15";
            //lblnetamount.Text = "الصافي";
            lblQuantity.Text = "عدد";
            lblAmount.Text = "السعر الأجمالي";
            lbltaxamount.Text = "قيمة الضريبة المضافة    %15";
            lblnetamount.Text = "الصافي";
        }

        private void lblGreeting_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblGreeting.Text = "شكرا لك على التسوق معنا";

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
             barcodegenerator(lblStoreName.Text, Modules.Main.LicenceVAT, date, xrLabel3.Text, xrLabel4.Text);
            //////
            //lblUserName.Text = "Sales User :";
            //lbltaxamount.Text = "Tax Amount 15%:";
            //lblnetamount.Text = "Net Price:";
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
    }
}
