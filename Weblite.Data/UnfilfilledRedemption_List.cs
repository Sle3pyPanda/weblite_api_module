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
    
    public partial class UnfilfilledRedemption_List
    {
        public byte RedemptionStatus { get; set; }
        public System.Guid CreatedBy { get; set; }
        public string StaffName { get; set; }
        public System.DateTime RedeemDate { get; set; }
        public Nullable<long> CardNumber { get; set; }
        public System.Guid RedemptionID { get; set; }
        public Nullable<long> MemberCode { get; set; }
        public string DisplayName { get; set; }
        public Nullable<System.Guid> EntityID { get; set; }
        public string CardNumberShow { get; set; }
        public string CardNumberEncrypted { get; set; }
        public string DeliverAddress { get; set; }
        public string NRIC { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string strTrackingNo { get; set; }
        public string strBatchNo { get; set; }
        public string strRedemptionNo { get; set; }
        public Nullable<System.DateTime> dtResponseDate { get; set; }
        public Nullable<System.DateTime> dtShipDate { get; set; }
        public Nullable<System.DateTime> dtDeliveryDate { get; set; }
        public string strConsignmentNo { get; set; }
        public string remark { get; set; }
    }
}
