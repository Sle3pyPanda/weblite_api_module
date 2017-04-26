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
    
    public partial class RedemptionProductList
    {
        public System.Guid RedemptionProductID { get; set; }
        public System.Guid RedemptionCategoryID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<bool> Available { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<System.Guid> CurrencyID { get; set; }
        public Nullable<int> ProductQuantity { get; set; }
        public Nullable<int> PartnerID { get; set; }
        public Nullable<int> StockInHand { get; set; }
        public Nullable<byte> intProductType { get; set; }
        public Nullable<int> intSorting { get; set; }
        public Nullable<System.DateTime> dtStartDate { get; set; }
        public Nullable<System.DateTime> dtEndDate { get; set; }
        public string PartnerName { get; set; }
        public string CategoryName { get; set; }
    }
}