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
    
    public partial class RewardsAdjustment_newCorporate
    {
        public System.Guid idRewardsAdjustmentCorporate { get; set; }
        public Nullable<System.Guid> MemberID { get; set; }
        public Nullable<byte> intRewardType { get; set; }
        public Nullable<decimal> decValue { get; set; }
        public string strRemarks { get; set; }
        public Nullable<byte> intStatus { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public Nullable<long> MemberCode { get; set; }
        public string Email { get; set; }
        public string NRIC { get; set; }
        public string PassportNo { get; set; }
        public Nullable<byte> MemberStatus { get; set; }
        public string MobilePhone { get; set; }
        public string FirstName { get; set; }
        public Nullable<decimal> AdjustedPoint { get; set; }
        public Nullable<decimal> AdjustedRebate { get; set; }
        public long RewardRefNo { get; set; }
    }
}
