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
    
    public partial class HeadImport
    {
        public HeadImport()
        {
            this.BranchImports = new HashSet<BranchImport>();
            this.HeadImport_List = new HashSet<HeadImport_List>();
        }
    
        public string IDHeadImport { get; set; }
        public string IDrequestImport { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public string IDAcc { get; set; }
    
        public virtual ICollection<BranchImport> BranchImports { get; set; }
        public virtual ICollection<HeadImport_List> HeadImport_List { get; set; }
        public virtual requestImport requestImport { get; set; }
    }
}
