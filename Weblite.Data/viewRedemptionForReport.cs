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
    
    public partial class viewRedemptionForReport
    {
        public System.Guid RedemptionID { get; set; }
        public System.Guid MemberID { get; set; }
        public byte RedemptionStatus { get; set; }
        public System.DateTime RedeemDate { get; set; }
        public int TotalPoint { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalSubsidy { get; set; }
        public string strRedemptionNo { get; set; }
        public string intChannel { get; set; }
        public Nullable<int> intYear { get; set; }
        public Nullable<int> intMonth { get; set; }
        public Nullable<int> intDay { get; set; }
        public string strMonthName { get; set; }
        public string strWeekdayName { get; set; }
        public Nullable<int> intQuarter { get; set; }
    }
}
