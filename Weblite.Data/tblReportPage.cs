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
    
    public partial class tblReportPage
    {
        public int idReportPage { get; set; }
        public Nullable<int> idReportLayout { get; set; }
        public Nullable<System.Guid> idReportCategory { get; set; }
        public string strDescription { get; set; }
        public string strHtmlContent { get; set; }
        public System.DateTime dtCreate { get; set; }
        public string strCreateBy { get; set; }
        public System.DateTime dtModify { get; set; }
        public string strModifiedBy { get; set; }
    
        public virtual tblReportLayout tblReportLayout { get; set; }
        public virtual tblReportStandardCategory tblReportStandardCategory { get; set; }
    }
}