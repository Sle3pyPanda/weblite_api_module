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
    
    public partial class tblRedemptionInstantRequest
    {
        public System.Guid idRedemptionInstantRequest { get; set; }
        public System.Guid idAPIKey { get; set; }
        public string strTransactionRefNo { get; set; }
        public string CardNumber { get; set; }
        public long idMasterAccount { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime dtTimeStampRequest { get; set; }
        public System.DateTime dtExpiry { get; set; }
        public decimal decPointValue { get; set; }
        public System.Guid RedemptionProductId { get; set; }
        public int intMaxFrequencyperMonth { get; set; }
        public int intMaximumCashbackperMonth { get; set; }
        public decimal decPercentPointBalanceCheck { get; set; }
        public int intPointstoRedeem { get; set; }
        public int intCntInstantRedeem { get; set; }
        public decimal decSumInstantRedeem { get; set; }
        public decimal decAllowedRedeemAmount { get; set; }
        public int intMaxPointRedeem { get; set; }
        public int intAllowedPointRedeem { get; set; }
        public byte strRespStatusCode { get; set; }
        public string strRespCardNo { get; set; }
        public string strRespMasterAccountNo { get; set; }
        public byte intRespMasterAcctRefType { get; set; }
        public int intRespAvailPointBalance { get; set; }
        public int intRespAllowedRedeemPoints { get; set; }
        public decimal decRespAllowedRedeemAmt { get; set; }
        public decimal decRespTransactionAmt { get; set; }
        public byte intStatus { get; set; }
    }
}