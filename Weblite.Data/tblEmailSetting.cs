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
    
    public partial class tblEmailSetting
    {
        public short idtblEmailSetting { get; set; }
        public string strHost { get; set; }
        public Nullable<int> intPort { get; set; }
        public string strUsername { get; set; }
        public string strPassword { get; set; }
        public string strSender { get; set; }
        public string strDisplayName { get; set; }
        public string strCCList { get; set; }
        public string strBCCList { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
