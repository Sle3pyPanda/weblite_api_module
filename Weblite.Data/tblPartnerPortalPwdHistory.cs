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
    
    public partial class tblPartnerPortalPwdHistory
    {
        public System.Guid idPartnerPortalPwdHistory { get; set; }
        public string strLoginId { get; set; }
        public string strPassword { get; set; }
        public Nullable<System.DateTime> dtPwdGenerate { get; set; }
        public byte intChangeType { get; set; }
    }
}