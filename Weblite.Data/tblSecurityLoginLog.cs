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
    
    public partial class tblSecurityLoginLog
    {
        public System.Guid idSecurityLoginLog { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime dteCreate { get; set; }
        public string strIP { get; set; }
        public string strURLRefer { get; set; }
        public bool isSuccess { get; set; }
        public string strUserName { get; set; }
        public string strRemark { get; set; }
        public Nullable<byte> intType { get; set; }
    }
}
