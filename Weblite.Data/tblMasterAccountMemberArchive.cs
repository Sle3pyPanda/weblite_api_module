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
    
    public partial class tblMasterAccountMemberArchive
    {
        public long idMasterAccountMemberArchive { get; set; }
        public long idMasterAccount { get; set; }
        public System.Guid MemberId { get; set; }
        public System.DateTime dtCreate { get; set; }
        public System.DateTime dtRemove { get; set; }
        public string strRemarks { get; set; }
        public System.Guid idCreateBy { get; set; }
        public System.Guid idRemoveBy { get; set; }
    }
}
