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
    
    public partial class BranchImport_List
    {
        public string IDBranchImport { get; set; }
        public int IDProduct { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    
        public virtual BranchImport BranchImport { get; set; }
        public virtual Product Product { get; set; }
    }
}
