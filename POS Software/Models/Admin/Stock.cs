using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Stock
{
    internal class Stock
    {
        public Int32  Stock_ID { get;  set; }
        public Nullable<Int32>  Item_ID { get;  set; }
        public String  Total_Stock { get;  set; }
        public Nullable<DateTime>  Last_Updated { get;  set; }
        public String  Stock_Critical_Level { get;  set; }
        public String  Created_By { get;  set; }
        public Nullable<DateTime>  Created_Date { get;  set; }
        public String  Modify_By { get;  set; }
        public Nullable<DateTime>  Modified_Date { get;  set; }
    }
}
