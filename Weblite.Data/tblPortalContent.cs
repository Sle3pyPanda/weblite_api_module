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
    
    public partial class tblPortalContent
    {
        public int idPortalContent { get; set; }
        public string strName { get; set; }
        public string strDescription { get; set; }
        public string strTitle { get; set; }
        public string strBody { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public bool intPublish { get; set; }
        public Nullable<System.Guid> CategoryID { get; set; }
        public string strCategory { get; set; }
    }
}
