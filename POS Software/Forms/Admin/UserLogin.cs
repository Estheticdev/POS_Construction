using DeviceId;
using Microsoft.Win32;
using Newtonsoft.Json;
using POS_Software.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace POS_Software.Forms.Admin
{
    public partial class UserLogin : DevExpress.XtraEditors.XtraForm
    {
        public UserLogin()
        {
            InitializeComponent();
            //POS_Software.Modules.General.POSLoad();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            
            //string QR = "Esthetic_POS/TotalBIll('" + ldGrandTotal.Text + "')/Tax('" + xrLabel4.Text + "')/NetAmount('" + xrLabel3.Text + "')/TaxNumber()";
            //string QR1 = "مستخدم المبيعاتTEXTBOX";
            
            //pictureEdit1.Image = qrcode.Draw(QR1, 50,2);
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            //pictureEdit1.Visible = true;
        }
        private void CheckAccount(string Status)
        {
            if (Status.Equals("Locked"))
            {
                MessageBox.Show("Login Failed! Account has been locked. Please contact to administrator", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (Status.Equals("Incorrect"))
            {
                MessageBox.Show("Login Failed! Incorrect user name or password", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (Status.Equals("NoUser"))
            {
                MessageBox.Show("Login Failed! There is no user created yet", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Modules.General.dtloginUser = DalHandlar.RunQuery("Select * from Vw_login where  Active = 'True'");
            }
            CheckUser = 0;
        }
        public static string HttpGet(String ComputerName)
        {
            try
            {
                string URI = "http://5.189.132.170:802/Mobile/GetClientLicenseInfo?serialNumber="+ComputerName;
                WebRequest req = WebRequest.Create(URI);
                req.ContentType = "application/json; charset=utf-8";
                req.Method = "GET";
                req.Timeout = 600000;
                System.Net.WebResponse resp = req.GetResponse();
                if (resp == null)
                    return null;
                StreamReader sr = new StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();

            }
            catch (WebException)
            {

                throw;
            }
        }

        private int CheckUser = 0;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (DalHandlar.MyConnection() == true)
            {
                POS_Software.Modules.General.POSLoad();
                

                if (Modules.General.dtloginUser != null)
                {
                   // loginprocess();
                    RegistryKey getkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EDevLicense");
                    if (getkey != null)
                    {
                        string str = getkey.GetValue("License").ToString();
                        string date = getkey.GetValue("LicenseValidity").ToString();

                        string date1 = SecurityManager.Decrypt(date);
                        if (Convert.ToDateTime(date1).Date > DateTime.Now.Date)
                        {
                            loginprocess();
                        }
                        else
                        {
                            MessageBox.Show("Software has been expired. kindly contact with support user");
                            RegistryKey delKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\EDevLicense");
                            delKey.DeleteValue("License");
                            delKey.DeleteValue("LicenseValidity");
                            Application.Exit();
                        }

                    }
                    else
                    {
                        var value = new DeviceIdBuilder();
                        string deviceid = value.AddMachineName().ToString();
                        var response = HttpGet(deviceid);

                        ResponseModel responseModel = JsonConvert.DeserializeObject<ResponseModel>(response);
                        if (responseModel.Data != null)
                        {
                            if (responseModel.Data.LicenseStatus.ToLower() == "licensed")
                            {
                                RegistryKey get = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\EDevLicense");
                                MachineInfo data = responseModel.Data;
                                string dte = SecurityManager.Encrypt(DateTime.Now.AddMonths(data.LicenseDuration).ToString());
                                string storedata = SecurityManager.Encrypt(data.DeviceName + "|" + data.LicenseDuration + "|" + data.LicenseStatus + "|" + dte.ToString());
                                get.SetValue("License", storedata);
                                get.SetValue("LicenseValidity", dte);
                                loginprocess();
                            }
                            else
                            {
                                MessageBox.Show("Licensed in invalid in server machine");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Software is not registered");
                            Application.Exit();
                        }



                    }

                }
            else
                {
                    CheckAccount("NoUser");
                    CheckUser = -1;
                }

                if (CheckUser == 0)
                {
                    MessageBox.Show("Login Failed! Incorrect user name or password", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        void loginprocess()
        {
            for (var x = 0; x < Modules.General.dtloginUser.Rows.Count; x++)
            {
                if (Modules.General.dtloginUser.Rows[x]["User_Name"].ToString().Equals(TxtUSER_NAME.Text.Trim()) && Modules.General.dtloginUser.Rows[x]["Password"].ToString().Equals(TxtPASSWORD.Text.Trim()))
                {
                    frmMDI mdi = new frmMDI();


                    mdi.BarEmpName.Caption = Modules.General.dtloginUser.Rows[x]["Full_Name"].ToString();
                    mdi.BarUserName.Caption = Modules.General.dtloginUser.Rows[x]["User_Name"].ToString();
                    Modules.General.userrole= Modules.General.dtloginUser.Rows[x]["User_Name"].ToString();
                    mdi.BarUserType.Caption = Modules.General.dtloginUser.Rows[x]["User_Role_Name"].ToString();
                    mdi.BarLoginAt.Caption = DateTime.Now.ToString();
                    var con = new frmconnection();
                    con.Show();
                   
                    CheckUser++;
                    TxtUSER_NAME.Text = string.Empty;
                    TxtPASSWORD.Text = string.Empty;
                    this.Hide();
                    break;
                }
            }
        }
        private void TxtPASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender , e);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
