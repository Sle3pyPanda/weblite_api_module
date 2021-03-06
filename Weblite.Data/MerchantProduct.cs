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
    
    public partial class MerchantProduct
    {
        public MerchantProduct()
        {
            this.tblMerchantProducMemberTypes = new HashSet<tblMerchantProducMemberType>();
            this.tblMerchantProductLocations = new HashSet<tblMerchantProductLocation>();
            this.tblMerchantProductRatings = new HashSet<tblMerchantProductRating>();
            this.tblPendingMerchantProductMemberTypeRequests = new HashSet<tblPendingMerchantProductMemberTypeRequest>();
        }
    
        public System.Guid MerchantProductID { get; set; }
        public System.Guid MerchantID { get; set; }
        public System.Guid MerchantCategoryID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public Nullable<byte> Badge { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool FeaturedProduct { get; set; }
        public Nullable<System.Guid> MainImageID { get; set; }
        public Nullable<System.Guid> ThumbnailImageID { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<System.Guid> DocumentID { get; set; }
        public string TermsAndConditions { get; set; }
        public string FileToUpload { get; set; }
        public Nullable<short> Sorting { get; set; }
        public string strLongDesc { get; set; }
        public Nullable<decimal> decRating { get; set; }
    
        public virtual Merchant Merchant { get; set; }
        public virtual ICollection<tblMerchantProducMemberType> tblMerchantProducMemberTypes { get; set; }
        public virtual ICollection<tblMerchantProductLocation> tblMerchantProductLocations { get; set; }
        public virtual ICollection<tblMerchantProductRating> tblMerchantProductRatings { get; set; }
        public virtual ICollection<tblPendingMerchantProductMemberTypeRequest> tblPendingMerchantProductMemberTypeRequests { get; set; }
    }
}
