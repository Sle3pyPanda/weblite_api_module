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
    
    public partial class VoucherException
    {
        public System.Guid VoucherExceptionID { get; set; }
        public Nullable<System.DateTime> ReconciliationDate { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<System.DateTime> ReloadDate { get; set; }
        public Nullable<decimal> ReloadAmount { get; set; }
        public Nullable<decimal> POS_Amount { get; set; }
        public string User_ID { get; set; }
        public string POS_ID { get; set; }
        public Nullable<System.DateTime> POS_Date { get; set; }
        public Nullable<byte> ErrorType { get; set; }
        public string ErrorMsg { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}