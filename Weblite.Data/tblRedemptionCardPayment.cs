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
    
    public partial class tblRedemptionCardPayment
    {
        public long idRedemptionCardPayment { get; set; }
        public Nullable<System.Guid> RedemptionId { get; set; }
        public string strRedemptionNo { get; set; }
        public string strCardNumber { get; set; }
        public string strAccountType { get; set; }
        public Nullable<decimal> decAmount { get; set; }
        public string strApprovalNo { get; set; }
        public string ICNo { get; set; }
        public Nullable<System.Guid> MemberId { get; set; }
        public Nullable<byte> intChannel { get; set; }
        public string strBatchId { get; set; }
        public Nullable<int> intStatus { get; set; }
        public Nullable<System.DateTime> dtSendDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.Guid> MerchantID { get; set; }
        public string strCardNumberEncrypted { get; set; }
        public string strMerchantID { get; set; }
        public Nullable<System.Guid> RedemptionDetailID { get; set; }
    }
}