//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weblite.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSRType
    {
        public tblSRType()
        {
            this.tblSRs = new HashSet<tblSR>();
        }
    
        public System.Guid idSRTypeID { get; set; }
        public string strRequestType { get; set; }
        public Nullable<short> intEstimatedDuration { get; set; }
        public Nullable<System.Guid> idDefaultAssigneeID { get; set; }
        public Nullable<short> intStatus { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ICollection<tblSR> tblSRs { get; set; }
    }
}
