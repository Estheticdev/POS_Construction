using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Stock
{
    internal class Stock_Detail
    {
        public Int32  Stock_Detail_ID { get;  set; }
        public Nullable<Int32>  Item_ID { get;  set; }
        public Nullable<Int32>  Stock_ID { get;  set; }
        public String  Stock_In { get;  set; }
        public String  Stock_Out { get;  set; }
        public Nullable<DateTime>  Transaction_Date { get;  set; }
        public String  Transaction_By { get;  set; }
    }
}
