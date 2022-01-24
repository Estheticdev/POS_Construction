using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Sales
{
    internal class Sales_Return_Detail
    {
        public Int32  Sales_Return_ID { get;  set; }
        public Nullable<Int32>  Sales_Detail_ID { get;  set; }
        public Nullable<Int32>  Sale_ID { get;  set; }
        public String  Item_Barcode { get;  set; }
        public Nullable<Int32>  Item_ID { get;  set; }
        public String  Qty { get;  set; }
        public String  Unit_Price { get;  set; }
        public String  Amount { get;  set; }
        public String  Created_By { get;  set; }
        public Nullable<DateTime>  Created_Date { get;  set; }
    }
}
