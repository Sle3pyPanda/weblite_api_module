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
    
    public partial class tblAuditLog
    {
        public System.Guid idAuditLog { get; set; }
        public System.Guid UserID { get; set; }
        public string strController { get; set; }
        public string strAction { get; set; }
        public string strTableName { get; set; }
        public System.DateTime dtCreate { get; set; }
        public string strOldData { get; set; }
        public string strNewData { get; set; }
    }
}