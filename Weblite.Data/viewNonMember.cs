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
    
    public partial class viewNonMember
    {
        public System.Guid MemberID { get; set; }
        public long idMasterAccount { get; set; }
        public System.Guid MembershipID { get; set; }
        public System.Guid MemberTypeID { get; set; }
        public Nullable<long> CardNumber { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string CardNumberEncrypted { get; set; }
        public string CardNumberShow { get; set; }
    }
}
