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
    
    public partial class tblSRLog
    {
        public System.Guid idSRLog { get; set; }
        public System.Guid idSRID { get; set; }
        public string strDescription { get; set; }
        public string strRemark { get; set; }
        public byte intLogType { get; set; }
        public Nullable<System.Guid> idAssignedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
    }
}
