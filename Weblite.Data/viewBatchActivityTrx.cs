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
    
    public partial class viewBatchActivityTrx
    {
        public System.DateTime TrxDate { get; set; }
        public string ActivityCode { get; set; }
        public string CardNo { get; set; }
        public string RefNo { get; set; }
        public string BatchID { get; set; }
        public Nullable<System.Guid> MemberID { get; set; }
        public long TrxID { get; set; }
        public string CardNoShow { get; set; }
        public Nullable<System.DateTime> CardExpiryDate { get; set; }
        public Nullable<System.Guid> MemberTypeID { get; set; }
    }
}
