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
    
    public partial class Reward_Adjustment
    {
        public System.Guid MemberID { get; set; }
        public long MemberCode { get; set; }
        public string FirstName { get; set; }
        public string NRIC { get; set; }
        public string PassportNo { get; set; }
        public string MobilePhone { get; set; }
        public byte RewardType { get; set; }
        public decimal RewardValue { get; set; }
        public string Remarks { get; set; }
        public string UserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid HistoryID { get; set; }
        public decimal AdjustedPoint { get; set; }
        public decimal AdjustedRebate { get; set; }
    }
}
