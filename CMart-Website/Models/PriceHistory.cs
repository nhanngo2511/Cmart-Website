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
    
    public partial class PriceHistory
    {
        public int IDProduct { get; set; }
        public double Price { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Product Product { get; set; }
    }
}