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
    
    public partial class view_getMembersSummaryInfo
    {
        public System.Guid MemberID { get; set; }
        public Nullable<byte> MemberStatus { get; set; }
        public Nullable<bool> intAllowGetPoints { get; set; }
        public bool intAllowRedem { get; set; }
        public string MemberType { get; set; }
        public string FirstName { get; set; }
        public string CardNumberShow { get; set; }
        public Nullable<System.Guid> ParendID { get; set; }
        public string Parent { get; set; }
        public Nullable<decimal> CASHBACK { get; set; }
        public Nullable<int> POINTS { get; set; }
    }
}
