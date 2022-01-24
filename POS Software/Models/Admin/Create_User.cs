using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Create_User
    {
        public Int32  Security_ID { get;  set; }
        public Int32  User_Role_ID { get;  set; }
        public String  Full_Name { get;  set; }
        public String  User_Name { get;  set; }
        public String  Password { get;  set; }
        public String  Recovery_Hint { get;  set; }
        public Nullable<DateTime>  Created_Date { get;  set; }
        public Nullable<DateTime>  Modified_Date { get;  set; }
        public String  Created_By { get;  set; }
        public Boolean  Active { get;  set; }
    }
}
