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
    
    public partial class tblCampaignAttachment
    {
        public int idAttachment { get; set; }
        public int idDirectCampaign { get; set; }
        public string strPath { get; set; }
        public string strAttachmentName { get; set; }
        public Nullable<int> intStatus { get; set; }
        public string strCreateBy { get; set; }
        public Nullable<System.DateTime> dtCreateDate { get; set; }
        public string strLastModBy { get; set; }
        public Nullable<System.DateTime> dtLastModDate { get; set; }
    
        public virtual tblDirectCampaign tblDirectCampaign { get; set; }
    }
}
