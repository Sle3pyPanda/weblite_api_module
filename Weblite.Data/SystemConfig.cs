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
    
    public partial class SystemConfig
    {
        public System.Guid SystemConfigID { get; set; }
        public System.Guid BaseCurrency { get; set; }
        public decimal PointsPerUnit { get; set; }
        public int PointExpiredDays { get; set; }
        public System.Guid CountryID { get; set; }
        public long MemberCode { get; set; }
        public string VoucherPrefix { get; set; }
        public Nullable<System.DateTime> NextCalculationDate { get; set; }
        public decimal ReloadTxnCharge { get; set; }
        public string ReloadTxnIDPrefix { get; set; }
        public Nullable<System.DateTime> NextRebateNotificationDate { get; set; }
        public long CorpNextStatementNo { get; set; }
        public byte CorpStatementMonth { get; set; }
    }
}