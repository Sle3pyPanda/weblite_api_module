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
    
    public partial class MemberType_List
    {
        public System.Guid MemberTypeID { get; set; }
        public string MemberType { get; set; }
        public string MemberTypeDesc { get; set; }
        public Nullable<int> Grade { get; set; }
        public Nullable<int> Points { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> AnnualFee { get; set; }
        public Nullable<System.Guid> PriceTypeID { get; set; }
        public byte ValidityPeriod { get; set; }
        public string ReferenceCode { get; set; }
        public Nullable<byte> intCustomerType { get; set; }
        public Nullable<bool> bitPreRegister { get; set; }
    }
}
