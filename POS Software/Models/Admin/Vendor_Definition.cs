using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Software.Models.Admin
{
    class Vendor_Definition
    {
        #region Propertiers
        public Int32 Vendor_ID { get; set; }
        public String Vendor_Name { get; set; }
        public String Contact_Number { get; set; }
        public String Location { get; set; }
        public String Balance { get; set; }
        public String TaxNumber { get; set; }
        public Boolean Active { get; set; }
        #endregion
    }
}
