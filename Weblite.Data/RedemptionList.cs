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
    
    public partial class RedemptionList
    {
        public System.Guid RedemptionID { get; set; }
        public System.Guid RedemptionDetailID { get; set; }
        public string ProductCode { get; set; }
        public byte RedemptionDetailStatus { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> RedeemPoint { get; set; }
        public Nullable<decimal> RedeemAmount { get; set; }
        public Nullable<decimal> RedeemSubsidy { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> TotalPoint { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> TotalSubsidy { get; set; }
        public string strTrackingNo { get; set; }
    }
}
