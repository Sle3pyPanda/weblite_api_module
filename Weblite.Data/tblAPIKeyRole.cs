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
    
    public partial class tblAPIKeyRole
    {
        public System.Guid idAPIKey { get; set; }
        public System.Guid idAPIRole { get; set; }
        public bool IsRequiredAuthSessionID { get; set; }
        public bool IsAccept { get; set; }
        public string IPAccept { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual tblAPIKey tblAPIKey { get; set; }
        public virtual tblAPIRole tblAPIRole { get; set; }
    }
}
