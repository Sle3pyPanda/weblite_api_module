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
    
    public partial class tblMemberVoucher
    {
        public long idVoucher { get; set; }
        public Nullable<System.Guid> idMember { get; set; }
        public Nullable<System.Guid> RedemptionProductId { get; set; }
        public string strVoucherNo { get; set; }
        public Nullable<byte> intChannel { get; set; }
        public Nullable<System.DateTime> dtRedeem { get; set; }
        public Nullable<System.DateTime> dtExpiry { get; set; }
        public Nullable<System.DateTime> dtUse { get; set; }
        public Nullable<System.DateTime> dtDismiss { get; set; }
        public string C2DBarcodeMessage { get; set; }
        public string strExternalRefNo { get; set; }
        public Nullable<byte> intStatus { get; set; }
        public Nullable<System.DateTime> dtCreateDate { get; set; }
        public Nullable<System.DateTime> dtLastUpdateDate { get; set; }
        public Nullable<System.Guid> RedemptionID { get; set; }
        public Nullable<System.Guid> idRedemptionProductDetail { get; set; }
        public Nullable<int> intPoint { get; set; }
    }
}