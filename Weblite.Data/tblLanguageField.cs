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
    
    public partial class tblLanguageField
    {
        public tblLanguageField()
        {
            this.tblLanguageObjects = new HashSet<tblLanguageObject>();
        }
    
        public int idLanguageField { get; set; }
        public string strName { get; set; }
        public Nullable<byte> intType { get; set; }
        public Nullable<byte> intSort { get; set; }
        public Nullable<byte> intModule { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string strRemark { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<tblLanguageObject> tblLanguageObjects { get; set; }
    }
}
