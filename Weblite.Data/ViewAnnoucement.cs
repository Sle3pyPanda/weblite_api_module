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
    
    public partial class ViewAnnoucement
    {
        public System.Guid AnnouncementID { get; set; }
        public System.Guid CategoryID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> CommencementDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public Nullable<System.Guid> DocumentID { get; set; }
        public Nullable<byte> Status { get; set; }
        public System.Guid CreatedBy { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string UserName { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
    }
}
