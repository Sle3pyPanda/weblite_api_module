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
    
    public partial class tblSecuritySessionLogin
    {
        public System.Guid idSecuritySessionLogin { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime dtCreate { get; set; }
        public System.DateTime dtExpiry { get; set; }
        public string strCode { get; set; }
    
        public virtual SecurityUser SecurityUser { get; set; }
    }
}
