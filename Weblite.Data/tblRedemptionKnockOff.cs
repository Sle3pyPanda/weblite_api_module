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
    
    public partial class tblRedemptionKnockOff
    {
        public long idRedemptionKnockOff { get; set; }
        public string strCardNumber { get; set; }
        public Nullable<decimal> decFee { get; set; }
        public Nullable<bool> bPay { get; set; }
        public Nullable<System.DateTime> dtPay { get; set; }
        public Nullable<System.DateTime> dtUpload { get; set; }
        public Nullable<bool> bSend { get; set; }
        public Nullable<System.Guid> ProductID { get; set; }
        public Nullable<System.Guid> ProductDetailID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public string NRIC { get; set; }
        public Nullable<System.Guid> MemberID { get; set; }
        public Nullable<System.Guid> RedemptionID { get; set; }
        public Nullable<int> intPoint { get; set; }
        public Nullable<System.DateTime> dtSendDate { get; set; }
        public Nullable<byte> intStatus { get; set; }
        public string strBatchID { get; set; }
        public string strProductName { get; set; }
        public string strMemberName { get; set; }
        public string strRedemptionNo { get; set; }
        public Nullable<byte> intChannel { get; set; }
        public string strProductType { get; set; }
        public string strAccountType { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string strReferenceNo { get; set; }
        public string strFeeItemName { get; set; }
        public string strCardNumberEncrypted { get; set; }
    }
}