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
    
    public partial class tblMemberTypeWhiteList
    {
        public int idMemberTypeWhiteList { get; set; }
        public System.Guid idFromMemberType { get; set; }
        public System.Guid idToMemberType { get; set; }
    
        public virtual MemberType MemberType { get; set; }
    }
}