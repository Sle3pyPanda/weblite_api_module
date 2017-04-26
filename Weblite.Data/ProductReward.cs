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
    
    public partial class ProductReward
    {
        public ProductReward()
        {
            this.ProductRewardDetails = new HashSet<ProductRewardDetail>();
            this.ProductRewardExcludes = new HashSet<ProductRewardExclude>();
            this.ProductRewardPrices = new HashSet<ProductRewardPrice>();
        }
    
        public System.Guid ProductRewardID { get; set; }
        public string RewardName { get; set; }
        public Nullable<byte> RewardType { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<byte> ExpiryType { get; set; }
        public Nullable<int> ExpiryValue { get; set; }
        public Nullable<byte> TxnType { get; set; }
        public Nullable<System.Guid> MemberTypeID { get; set; }
        public Nullable<decimal> SubsidyAmount { get; set; }
        public Nullable<byte> GracePeriod { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<decimal> FormulaPrice { get; set; }
        public Nullable<int> FormulaPoint { get; set; }
        public string PromoCode { get; set; }
        public Nullable<System.Guid> RewardFundID { get; set; }
        public Nullable<int> CalculationFrequency { get; set; }
        public Nullable<int> ProcessDay { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<System.Guid> idRewardPromo { get; set; }
        public Nullable<byte> intSpecialRules { get; set; }
        public string ProgramCode { get; set; }
        public Nullable<byte> intRunStatus { get; set; }
        public Nullable<byte> intStatus { get; set; }
        public string strRuleName { get; set; }
        public Nullable<System.Guid> idActivityQuerySchedule { get; set; }
        public Nullable<bool> bitGroupType { get; set; }
        public Nullable<System.Guid> MemberGroupId { get; set; }
    
        public virtual MemberGroup MemberGroup { get; set; }
        public virtual MemberType MemberType { get; set; }
        public virtual tblRewardFundMaster tblRewardFundMaster { get; set; }
        public virtual tblRewardPromo tblRewardPromo { get; set; }
        public virtual ICollection<ProductRewardDetail> ProductRewardDetails { get; set; }
        public virtual ICollection<ProductRewardExclude> ProductRewardExcludes { get; set; }
        public virtual ICollection<ProductRewardPrice> ProductRewardPrices { get; set; }
    }
}