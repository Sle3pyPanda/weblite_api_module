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
    
    public partial class tblPortalCredentialRight
    {
        public long idPortalCredentialRights { get; set; }
        public long idPortalCredentials { get; set; }
        public Nullable<long> idMasterAccount { get; set; }
        public Nullable<System.Guid> MemberId { get; set; }
        public bool bRewardBalance { get; set; }
        public bool bViewUsage { get; set; }
        public bool bRedemption { get; set; }
        public bool bViewRedeem { get; set; }
        public bool bEditProfile { get; set; }
        public bool bTransferPoints { get; set; }
        public bool bAdmin { get; set; }
    }
}