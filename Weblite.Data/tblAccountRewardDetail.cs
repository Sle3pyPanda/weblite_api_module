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
    
    public partial class tblAccountRewardDetail
    {
        public long idRewardSummarydDetail { get; set; }
        public Nullable<long> idRewardSummary { get; set; }
        public Nullable<long> idMasterAccount { get; set; }
        public Nullable<System.Guid> MemberId { get; set; }
        public Nullable<System.Guid> RewardId { get; set; }
        public Nullable<System.Guid> RedemptionId { get; set; }
    }
}
