//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test
{
    using System;
    using System.Collections.Generic;
    
    public partial class CleaningRoomItem
    {
        public int ID { get; set; }
        public int CleaningRoomDetailID { get; set; }
        public int ItemID { get; set; }
        public int Qty { get; set; }
        public string Status { get; set; }
    
        public virtual CleaningRoomDetail CleaningRoomDetail { get; set; }
        public virtual Item Item { get; set; }
    }
}
