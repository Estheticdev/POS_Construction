using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class User_Role
    {
        public Int32  User_Role_ID { get;  set; }
        public String  User_Role_Name { get;  set; }
        public Nullable<DateTime>  Created_Date { get;  set; }
        public String  Created_By { get;  set; }
        public String  Modify_By { get;  set; }
        public Nullable<DateTime>  Modified_Date { get;  set; }
        public Boolean  Active { get;  set; }
    }
}
