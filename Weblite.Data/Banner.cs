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
    
    public partial class Banner
    {
        public System.Guid BannerID { get; set; }
        public System.Guid CategoryID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> ValidPeriodFrom { get; set; }
        public Nullable<System.DateTime> ValidPeriodTo { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> DocumentID { get; set; }
        public Nullable<byte> Status { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int intBlock { get; set; }
        public bool intPublish { get; set; }
    }
}
