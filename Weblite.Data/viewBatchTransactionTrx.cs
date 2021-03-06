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
    
    public partial class viewBatchTransactionTrx
    {
        public System.DateTime TrxDate { get; set; }
        public string MCCCode { get; set; }
        public string POSMode { get; set; }
        public string MerchantID { get; set; }
        public string MerchantName { get; set; }
        public string TrxCurrCode { get; set; }
        public string BillCurrCode { get; set; }
        public Nullable<decimal> TrxAmt { get; set; }
        public Nullable<decimal> BillAmt { get; set; }
        public string RefNo { get; set; }
        public string CalcProcessStatus { get; set; }
        public string UpdLoyaltyStatus { get; set; }
        public Nullable<System.Guid> MemberID { get; set; }
        public string CountryCode { get; set; }
        public string CardNo { get; set; }
        public string Remarks { get; set; }
        public string TrxParamXML { get; set; }
        public Nullable<bool> UpdXMLStatus { get; set; }
        public string CardNoShow { get; set; }
        public string BatchID { get; set; }
        public Nullable<System.Guid> MemberTypeID { get; set; }
        public Nullable<System.DateTime> CardExpiryDate { get; set; }
        public Nullable<System.Guid> ProductVariantID { get; set; }
        public long TrxID { get; set; }
        public string TrxType { get; set; }
        public string TrxCode { get; set; }
        public string AuthCode { get; set; }
        public Nullable<long> idMasterAccount { get; set; }
    }
}
