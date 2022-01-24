using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Purchase
{
    internal class Purchase_Invoice
    {
        public Int32  Purchase_ID { get;  set; }
        public Nullable<Int32>  Invoice_No { get;  set; }
        public String  Grand_Total { get;  set; }
        public String  Recievd_Amount { get;  set; }
        public Nullable<DateTime>  Invoice_Date { get;  set; }
        public String  Created_By { get;  set; }
        public Nullable<DateTime>  Created_Date { get;  set; }
        public Boolean  Active { get;  set; }
    }
}
