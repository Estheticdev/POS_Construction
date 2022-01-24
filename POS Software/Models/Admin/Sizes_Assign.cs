using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Sizes_Assign
    {
        public Int32 Sizes_Assign_ID { get; set; }
        public Nullable<Int32> Types_ID { get; set; }
        public Nullable<Int32> Category_ID { get; set; }
        public Nullable<Int32> Sizes_ID { get; set; }
        public String Created_By { get; set; }
        public Nullable<DateTime> Created_Date { get; set; }
        public String Modify_By { get; set; }
        public Nullable<DateTime> Modified_Date { get; set; }
        public Boolean Active { get; set; }
    }
}
