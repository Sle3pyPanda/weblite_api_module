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
    
    public partial class SecurityUser
    {
        public SecurityUser()
        {
            this.SecurityRoleEntities = new HashSet<SecurityRoleEntity>();
            this.SecurityUserRoles = new HashSet<SecurityUserRole>();
            this.tblSecuritySessionLogins = new HashSet<tblSecuritySessionLogin>();
            this.tblSRs = new HashSet<tblSR>();
            this.tblSRs1 = new HashSet<tblSR>();
            this.tblSRAssignments = new HashSet<tblSRAssignment>();
        }
    
        public System.Guid UserID { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public byte UserStatus { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool bMustChangePassword { get; set; }
        public bool bSuspend { get; set; }
        public byte intAttempts { get; set; }
        public System.DateTime dteChangepass { get; set; }
        public System.DateTime dteSuspend { get; set; }
    
        public virtual ICollection<SecurityRoleEntity> SecurityRoleEntities { get; set; }
        public virtual ICollection<SecurityUserRole> SecurityUserRoles { get; set; }
        public virtual ICollection<tblSecuritySessionLogin> tblSecuritySessionLogins { get; set; }
        public virtual ICollection<tblSR> tblSRs { get; set; }
        public virtual ICollection<tblSR> tblSRs1 { get; set; }
        public virtual ICollection<tblSRAssignment> tblSRAssignments { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
