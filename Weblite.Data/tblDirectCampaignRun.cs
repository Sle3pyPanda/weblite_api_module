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
    
    public partial class tblDirectCampaignRun
    {
        public tblDirectCampaignRun()
        {
            this.tblDirectCampaignRecipients = new HashSet<tblDirectCampaignRecipient>();
        }
    
        public int idDirectCampaignRun { get; set; }
        public int idDirectCampaign { get; set; }
        public int intDeliveryMode { get; set; }
        public string strRunCode { get; set; }
        public Nullable<int> intStatus { get; set; }
        public Nullable<System.DateTime> dtPost { get; set; }
        public Nullable<System.DateTime> dtSend { get; set; }
        public Nullable<System.DateTime> dtCompleteSend { get; set; }
        public Nullable<int> intSMSDelivery { get; set; }
        public string strSMSMessage { get; set; }
        public Nullable<int> intEmailDelivery { get; set; }
        public string strEmailFrom { get; set; }
        public string strEmailReplyTo { get; set; }
        public string strEmailSubject { get; set; }
        public string strEmailBodyHTML { get; set; }
        public string strEmailBodyText { get; set; }
        public Nullable<int> intPush { get; set; }
        public string strAndroidMsg { get; set; }
        public string striOSMsg { get; set; }
    
        public virtual tblDirectCampaign tblDirectCampaign { get; set; }
        public virtual ICollection<tblDirectCampaignRecipient> tblDirectCampaignRecipients { get; set; }
    }
}
