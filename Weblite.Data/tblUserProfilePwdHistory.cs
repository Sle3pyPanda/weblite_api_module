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
    
    public partial class tblUserProfilePwdHistory
    {
        public System.Guid idPwdHistory { get; set; }
        public string strLoginId { get; set; }
        public string strPassword { get; set; }
        public System.DateTime dtPwdGenerate { get; set; }
        public System.Guid UserID { get; set; }
        public Nullable<byte> intChangeType { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
    }
}
