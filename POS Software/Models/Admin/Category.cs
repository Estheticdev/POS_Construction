using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Category
    {
        public Int32  Category_ID { get;  set; }
        public String  Category_Name { get;  set; }
        public Nullable<Int32>  Type_ID { get;  set; }
        public Nullable<DateTime>  Created_By { get;  set; }
        public String  Created_Date { get;  set; }
        public String  Modified_By { get;  set; }
        public Nullable<DateTime>  Modified_Date { get;  set; }
        public Boolean Active { get; set; }
    }
}
