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
    
    public partial class ProductPriceType
    {
        public System.Guid VariantID { get; set; }
        public System.Guid PriceTypeID { get; set; }
        public System.Guid CurrencyID { get; set; }
        public decimal SalePrice { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual PriceType PriceType { get; set; }
        public virtual ProductVariant ProductVariant { get; set; }
    }
}
