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
    
    public partial class RedemptionCart
    {
        public System.Guid CartID { get; set; }
        public string SessionID { get; set; }
        public System.Guid RedemptionProductID { get; set; }
        public int Quantity { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.Guid RedemptionProductDetailID { get; set; }
    }
}