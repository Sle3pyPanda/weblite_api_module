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
    
    public partial class tblAPIRole
    {
        public tblAPIRole()
        {
            this.tblAPIKeyRoles = new HashSet<tblAPIKeyRole>();
        }
    
        public System.Guid idAPIRole { get; set; }
        public string strName { get; set; }
        public string strRemark { get; set; }
        public string strDescription { get; set; }
    
        public virtual ICollection<tblAPIKeyRole> tblAPIKeyRoles { get; set; }
    }
}
