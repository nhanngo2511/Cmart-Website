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
    
    public partial class requestImport
    {
        public requestImport()
        {
            this.HeadImports = new HashSet<HeadImport>();
            this.requestImport_List = new HashSet<requestImport_List>();
        }
    
        public string IDRequestImport { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string IDSupplier { get; set; }
        public string IDAcc { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ICollection<HeadImport> HeadImports { get; set; }
        public virtual ICollection<requestImport_List> requestImport_List { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
