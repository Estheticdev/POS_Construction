using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Store_Deffination
    {
        public Int32  Store_ID { get;  set; }
        public String  Store_Name { get;  set; }
        public String CR_Number { get; set; }
        public String English_Name { get; set; }
        public String  Owner_Name { get;  set; }
        public String  Phone_Number { get;  set; }
        public String  Cell_Number { get;  set; }
        public String TaxNumber { get; set; }        
        public Byte[]  Logo_Image { get;  set; }
        public String  Address { get;  set; }
        public String  Created_By { get;  set; }
        public Nullable<DateTime>  Created_Date { get;  set; }
        public String  Modified_By { get;  set; }
        public Nullable<DateTime>  Modified_Date { get;  set; }
        public Boolean  Active { get;  set; }
        public String Email { get; set; }
        public String licensenumber { get; set; }
        public String englishaddress { get; set; }
    }
}
