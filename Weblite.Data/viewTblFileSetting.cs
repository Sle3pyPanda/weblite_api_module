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
    
    public partial class viewTblFileSetting
    {
        public int idx { get; set; }
        public string SystemCode { get; set; }
        public string BatchType { get; set; }
        public string LocalFolder { get; set; }
        public string RemoteFolder { get; set; }
        public string ftpAddress { get; set; }
        public string ftpUser { get; set; }
        public string ftpPassword { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> FileSeq { get; set; }
        public string FileExtension { get; set; }
        public string ftpDirection { get; set; }
        public string LocalProcessFolder { get; set; }
        public string LocalErrorFolder { get; set; }
        public string BulkInsertFormatFile { get; set; }
        public string BulkInsertFormatFileCRLF { get; set; }
        public Nullable<bool> IsEncrypted { get; set; }
        public Nullable<int> MaxRowPerFile { get; set; }
        public string BulkTableName { get; set; }
        public string SPName { get; set; }
        public string EncryptColumns { get; set; }
        public string OutQuery { get; set; }
        public string OutFileDelim { get; set; }
        public Nullable<bool> GenOnBillingDay { get; set; }
        public Nullable<bool> IsCustomHeader { get; set; }
        public string strCustomHeader { get; set; }
        public Nullable<bool> IsCustomTrailer { get; set; }
        public string strCustomTrailer { get; set; }
        public string UpdateQuery { get; set; }
        public Nullable<bool> IsCustomRowType { get; set; }
        public string strRowType { get; set; }
    }
}
