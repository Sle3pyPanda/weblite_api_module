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
    
    public partial class tblTemplate
    {
        public int idTemplate { get; set; }
        public string strTemplateCode { get; set; }
        public Nullable<int> intType { get; set; }
        public string strSubject { get; set; }
        public string strBody { get; set; }
        public Nullable<int> intStatus { get; set; }
        public string strCreateBy { get; set; }
        public Nullable<System.DateTime> dtCreateDate { get; set; }
        public string strLastModBy { get; set; }
        public Nullable<System.DateTime> dtLastModDate { get; set; }
        public string strBodyHTML { get; set; }
    }
}