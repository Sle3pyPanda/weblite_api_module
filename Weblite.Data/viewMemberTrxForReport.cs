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
    
    public partial class viewMemberTrxForReport
    {
        public long TrxID { get; set; }
        public Nullable<System.DateTime> TrxDate { get; set; }
        public Nullable<int> intYear { get; set; }
        public Nullable<int> intMonth { get; set; }
        public Nullable<int> intDay { get; set; }
        public string strMonthName { get; set; }
        public string strWeekdayName { get; set; }
        public Nullable<int> intQuarter { get; set; }
        public string strQuarterName { get; set; }
        public Nullable<int> intWeek { get; set; }
        public string strWeekName { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<int> intPostedYear { get; set; }
        public Nullable<int> intPostedMonth { get; set; }
        public Nullable<int> intPostedDay { get; set; }
        public string strPostedMonthName { get; set; }
        public string strPostedWeekdayName { get; set; }
        public Nullable<int> intPostedQuarter { get; set; }
        public string strPostedQuarterName { get; set; }
        public Nullable<int> intPostedWeek { get; set; }
        public string strPostedWeekName { get; set; }
        public string SystemCode { get; set; }
        public Nullable<System.Guid> MemberID { get; set; }
        public string MCCCode { get; set; }
        public string MerchantName { get; set; }
        public string TrxCurrCode { get; set; }
        public string idMasterAccount { get; set; }
        public Nullable<decimal> BillAmt { get; set; }
        public Nullable<long> TransRangeId { get; set; }
        public Nullable<long> TransFrequencyId { get; set; }
        public string MerchantID { get; set; }
    }
}
