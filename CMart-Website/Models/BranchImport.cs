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
    
    public partial class BranchImport
    {
        public BranchImport()
        {
            this.BranchImport_List = new HashSet<BranchImport_List>();
        }
    
        public string IDBranchImport { get; set; }
        public string IDHeadImport { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Branch { get; set; }
        public string IDAcc { get; set; }
    
        public virtual HeadImport HeadImport { get; set; }
        public virtual ICollection<BranchImport_List> BranchImport_List { get; set; }
    }
}
