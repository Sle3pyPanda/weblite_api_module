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
    
    public partial class Document
    {
        public System.Guid DocumentID { get; set; }
        public string OwnerSource { get; set; }
        public Nullable<System.Guid> OwnerID { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDesc { get; set; }
        public int DocumentSize { get; set; }
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}