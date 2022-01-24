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

namespace POS_Software.Forms.Sales
{
    public partial class frmCPayment : DevExpress.XtraEditors.XtraForm
    {
        public frmCPayment()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
        int v_customerID = 0;
        bool found = false;
        private void btnGetRegularCustomer_Click(object sender, EventArgs e)
        {
            var Dt = new DataTable();
            if (sender.GetType() == typeof(int))
            {
                Dt.Columns.Add("Customer_ID", typeof(string));
                Dt.Rows.Add(sender);
            }
            else
            {
                if (Modules.General.dtRegularCustomer != null)
                {
                    Dt = Soothmedia.General.Win.Searchingform("Customer Search", DalHandlar.cn, Modules.General.dtRegularCustomer, "'No','Name'", false, "1");
                    if (Dt != null)
                    {
                        var dtgetCustomer = DalHandlar.RunQuery("Select Customer_ID,Customer_Name,Contact_Number,TaxNumber,Location,Balance from Admin.Customer_Deffination where Active=1 and Customer_ID=" + Convert.ToInt32(Dt.Rows[0][0]));

                        if (dtgetCustomer != null)
                        {
                            lblCustomerName.Text = Convert.ToString(dtgetCustomer.Rows[0]["Customer_Name"] + "(" + dtgetCustomer.Rows[0]["Customer_ID"] + ")");
                            v_customerID = Convert.ToInt32(dtgetCustomer.Rows[0]["Customer_ID"].ToString());
                            label14.Text = dtgetCustomer.Rows[0]["Balance"].ToString();
                            found = true;

                        }
                    }
                }
            }
        }

        private void TxtGetRegularCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtGetRegularCustomer.Text != null)
            {
                int CalLengnth = Convert.ToInt32(TxtGetRegularCustomer.Text.Length);
                if (CalLengnth <= 7 && TxtGetRegularCustomer.Text != string.Empty)
                {
                    var dtgetCustomer = DalHandlar.RunQuery("Select Customer_ID,Customer_Name,Contact_Number,TaxNumber,Location,Balance  from Admin.Customer_Deffination where Active=1 and Customer_ID=" + Convert.ToInt32(TxtGetRegularCustomer.Text));
                    if (dtgetCustomer != null)
                    {
                        lblCustomerName.Text = Convert.ToString(dtgetCustomer.Rows[0]["Customer_Name"] + "(" + dtgetCustomer.Rows[0]["Customer_ID"] + ")");
                        v_customerID = Convert.ToInt32(dtgetCustomer.Rows[0]["Customer_ID"].ToString());
                        found = true;
                        label14.Text = dtgetCustomer.Rows[0]["Balance"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Invalid ID Customer Not Found");
                        found = false;
                    }

                }
                else
                {
                    MessageBox.Show("Kindly Enter Customer ID", "Stop");
                    found = false;
                    TxtGetRegularCustomer.Focus();

                }
            }
        }

        private Models.Sales.Sales_Invoice O_Invoiec = new Models.Sales.Sales_Invoice();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Soothmedia.General.Win.Validation(this, ErPro))
            {
                if (found == true)
                {
                    O_Invoiec.Sale_ID = (Int32)DalHandlar.AutoNumber<Models.Sales.Sales_Invoice>();
                   
                    double prevalue= Convert.ToDouble(label14.Text);
                    double newvalue= Convert.ToDouble(TxtComments.Text);
                    double newbalance = prevalue - newvalue;
                    DalHandlar.RunQuery("update admin.Customer_Deffination set Balance= " + newbalance + " where Customer_ID=" + v_customerID);
                    DalHandlar.RunQuery("insert into Sales.Sales_Invoice(Sale_ID,Customer_ID,Recievd_Amount,Invoice_Date,Created_Date,Active)Values(" + O_Invoiec.Sale_ID + "," + v_customerID  + ",'" + TxtComments.Text + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortDateString() + "','" + true + "')");
                    MessageBox.Show("Payment Received");
                    found = false;
                    TxtComments.Text = "";
                    TxtGetRegularCustomer.Text = "";
                    label14.Text = "0";
                    lblCustomerName.Text = "Name";
                }
            }
            }
        }
}