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
    
    public partial class tblqueuemaster
    {
        public int idQMaster { get; set; }
        public Nullable<int> idDirectCampaign { get; set; }
        public Nullable<int> idDirectCampaignRun { get; set; }
        public Nullable<System.Guid> idMember { get; set; }
        public Nullable<int> idLead { get; set; }
        public Nullable<int> intStatus { get; set; }
        public Nullable<System.DateTime> dtFirstProcessDate { get; set; }
        public Nullable<System.DateTime> dtLastProcessDate { get; set; }
    }
}
