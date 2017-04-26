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
    
    public partial class SecurityRoleAccess
    {
        public System.Guid AccessID { get; set; }
        public System.Guid RoleID { get; set; }
        public System.Guid ModuleID { get; set; }
        public Nullable<System.Guid> PageID { get; set; }
        public Nullable<System.Guid> ElementID { get; set; }
        public byte Access { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual SecurityElement SecurityElement { get; set; }
        public virtual SecurityRole SecurityRole { get; set; }
    }
}