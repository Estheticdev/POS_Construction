using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Units
    {
        public Int32 Unit_ID { get; set; }
        public String Unit_Name { get; set; }
        public Boolean Active { get; set; }
        public Nullable<DateTime> Created_By { get; set; }
        public String Created_Date { get; set; }
        public String Modified_By { get; set; }
        public Nullable<DateTime> Modified_Date { get; set; }
    }
}
