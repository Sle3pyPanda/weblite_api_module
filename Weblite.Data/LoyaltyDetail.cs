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
    
    public partial class LoyaltyDetail
    {
        public System.Guid LoyaltyDetailID { get; set; }
        public System.Guid LoyaltyID { get; set; }
        public Nullable<System.Guid> MemberTypeID { get; set; }
        public Nullable<int> Point { get; set; }
        public Nullable<System.Guid> CouponID { get; set; }
        public Nullable<System.Guid> LuckyDrawID { get; set; }
        public Nullable<System.Guid> ToMemberTypeID { get; set; }
        public Nullable<int> ReferFriend { get; set; }
        public Nullable<byte> IntroducerPercent { get; set; }
        public Nullable<int> ForwardEmail { get; set; }
        public Nullable<bool> ParticipateSurvey { get; set; }
        public Nullable<bool> ParticipateQuiz { get; set; }
        public Nullable<decimal> FromAmount { get; set; }
        public Nullable<decimal> ToAmount { get; set; }
        public Nullable<System.Guid> CancelLoyaltyID { get; set; }
        public Nullable<byte> PointWithdraw { get; set; }
        public Nullable<bool> CouponWithdraw { get; set; }
        public Nullable<decimal> CancellationFee { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> MaximumPerMonth { get; set; }
        public Nullable<int> LifetimeMaximum { get; set; }
    
        public virtual Coupon Coupon { get; set; }
        public virtual Loyalty Loyalty { get; set; }
        public virtual LuckyDraw LuckyDraw { get; set; }
    }
}
