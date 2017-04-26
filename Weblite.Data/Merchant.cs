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
    
    public partial class Merchant
    {
        public Merchant()
        {
            this.MerchantCategories = new HashSet<MerchantCategory>();
            this.MerchantProducts = new HashSet<MerchantProduct>();
        }
    
        public System.Guid MerchantID { get; set; }
        public Nullable<System.Guid> MerchantCategoryID { get; set; }
        public string MerchantName { get; set; }
        public string MerchantDesc { get; set; }
        public Nullable<System.Guid> LogoImageID { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<byte> Badge { get; set; }
        public bool intPublish { get; set; }
        public string strWebsite { get; set; }
        public string strPhone { get; set; }
        public bool isEVoucher { get; set; }
    
        public virtual ICollection<MerchantCategory> MerchantCategories { get; set; }
        public virtual ICollection<MerchantProduct> MerchantProducts { get; set; }
    }
}