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
    
    public partial class view_Estatement_Transaction_Individual
    {
        public Nullable<System.DateTime> SettlementDate { get; set; }
        public string CardNo { get; set; }
        public System.DateTime TranDate { get; set; }
        public Nullable<System.DateTime> TrxDate { get; set; }
        public string TrxTime { get; set; }
        public string TranNo { get; set; }
        public string EntryPlaza { get; set; }
        public string ExitPlaza { get; set; }
        public Nullable<decimal> TranAmt_RM { get; set; }
        public string POSMode { get; set; }
        public string MerchantID { get; set; }
        public Nullable<System.Guid> MemberID { get; set; }
    }
}
