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
    
    public partial class MemberRewardHistory
    {
        public System.Guid HistoryID { get; set; }
        public System.Guid MemberID { get; set; }
        public Nullable<System.Guid> ToMemberID { get; set; }
        public byte HistoryType { get; set; }
        public byte RewardType { get; set; }
        public decimal RewardValue { get; set; }
        public string Remarks { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<System.Guid> RewardID { get; set; }
        public Nullable<byte> TransferReasonType { get; set; }
        public Nullable<System.Guid> RewardFundID { get; set; }
        public Nullable<System.Guid> idBatch { get; set; }
    }
}
