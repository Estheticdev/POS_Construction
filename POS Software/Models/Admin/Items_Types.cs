using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Items_Types
    {
        public Int32  Items_Types_ID { get;  set; }
        public String  Types_Name { get;  set; }
        public Nullable<DateTime>  Created_By { get;  set; }
        public String  Created_Date { get;  set; }
        public String  Modified_By { get;  set; }
        public Nullable<DateTime>  Modified_Date { get;  set; }
        public Boolean Active { get; set; }
    }
}
