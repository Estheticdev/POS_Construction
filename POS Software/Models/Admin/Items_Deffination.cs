using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_Software.Models.Admin
{
    internal class Items_Deffination
    {
        public Int32 Item_ID { get; set; }
        public String Item_Name { get; set; }
        public String Item_Barcode { get; set; }
        public Nullable<Int32> Item_Type_ID { get; set; }
        public Nullable<Int32> Item_Category_ID { get; set; }
        public Nullable<Int32> Item_Size_ID { get; set; }
        public Nullable<Int32> Item_Unit_ID { get; set; }
        public String Stock_Critical_Level { get; set; }
        public String Item_Sale_Price { get; set; }
        public String Pack_Price { get; set; }
        public String Piece_Per_Pack { get; set; }
        public String Item_Purchase_Price { get; set; }
        public Boolean IsPacked { get; set; }
        public Nullable<DateTime> Item_Expiry_Date { get; set; }
        public Nullable<DateTime> Created_Date { get; set; }
        public String Created_By { get; set; }
        public String Modified_Date { get; set; }
        public String Modify_by { get; set; }
        public Boolean Active { get; set; }
    }
}
