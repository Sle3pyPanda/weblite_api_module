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
    
    public partial class tblPeriodTable
    {
        public long PeriodId { get; set; }
        public Nullable<System.DateTime> dtDate { get; set; }
        public Nullable<int> intYear { get; set; }
        public Nullable<int> intQuarter { get; set; }
        public Nullable<int> intMonth { get; set; }
        public string strMonthName { get; set; }
        public Nullable<int> intDay { get; set; }
        public Nullable<int> intWeekday { get; set; }
        public string strWeekdayName { get; set; }
        public Nullable<int> intWeek { get; set; }
        public string strWeekName { get; set; }
        public string strQuarterName { get; set; }
    }
}