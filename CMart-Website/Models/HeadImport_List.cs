//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMart_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HeadImport_List
    {
        public string IDHeadImport { get; set; }
        public int IDProduct { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Nullable<System.DateTime> Expiration { get; set; }
        public string Status { get; set; }
    
        public virtual HeadImport HeadImport { get; set; }
        public virtual Product Product { get; set; }
    }
}
