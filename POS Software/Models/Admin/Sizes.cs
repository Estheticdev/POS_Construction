using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Sizes
    {
        public Int32 Size_ID { get; set; }
        public String Size_Name { get; set; }
        public Boolean Active { get; set; }
        public Nullable<DateTime> Created_Date { get; set; }
        public String Created_By { get; set; }
        public String Modified_By { get; set; }
        public Nullable<DateTime> Modified_Date { get; set; }
    }
}
