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
    
    public partial class tblMemberAdjustment
    {
        public System.Guid idRewardsAdjustment { get; set; }
        public Nullable<System.Guid> MemberID { get; set; }
        public Nullable<byte> intRewardType { get; set; }
        public Nullable<decimal> decValue { get; set; }
        public string strRemarks { get; set; }
        public Nullable<byte> intStatus { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public long RewardRefNo { get; set; }
    }
}