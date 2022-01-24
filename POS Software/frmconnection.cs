using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software
{
    public partial class frmconnection : Form
    {
        public frmconnection()
        {
            InitializeComponent();
        }

        private void frmconnection_Load(object sender, EventArgs e)
        {
            if (DalHandlar.MyConnection() == true)
            {
                /// Application.Run(new Frm_Mdi());
                var w = new frmMDI();
                w.ShowDialog();
            }
        }
    }
}
