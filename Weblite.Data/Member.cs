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
    
    public partial class Member
    {
        public System.Guid MemberID { get; set; }
        public long MemberCode { get; set; }
        public Nullable<System.Guid> SalutationID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<byte> Gender { get; set; }
        public Nullable<byte> MaritalStatus { get; set; }
        public string NRIC { get; set; }
        public string PassportNo { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.Guid> JobTitleID { get; set; }
        public string CompanyAddress { get; set; }
        public Nullable<System.Guid> CompanyCountryID { get; set; }
        public Nullable<System.Guid> CompanyStateID { get; set; }
        public Nullable<System.Guid> CompanyCityID { get; set; }
        public string CompanyPostCode { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyFax { get; set; }
        public string HomeAddress1 { get; set; }
        public string HomeAddress2 { get; set; }
        public string HomeAddress3 { get; set; }
        public Nullable<System.Guid> HomeCountryID { get; set; }
        public Nullable<System.Guid> HomeStateID { get; set; }
        public Nullable<System.Guid> HomeCityID { get; set; }
        public string HomePostcode { get; set; }
        public string HomePhone { get; set; }
        public string HomeFax { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public Nullable<byte> PreferredContact { get; set; }
        public string MemberLogin { get; set; }
        public string MemberPassword { get; set; }
        public Nullable<System.Guid> MemberGroupID { get; set; }
        public Nullable<System.Guid> MemberTypeID { get; set; }
        public Nullable<System.DateTime> MemberSince { get; set; }
        public Nullable<byte> MemberStatus { get; set; }
        public Nullable<System.Guid> RefererID { get; set; }
        public Nullable<byte> Notification { get; set; }
        public Nullable<System.Guid> NationalityID { get; set; }
        public Nullable<System.Guid> EducationID { get; set; }
        public Nullable<System.Guid> SalaryRangeID { get; set; }
        public Nullable<System.Guid> ParentMemberID { get; set; }
        public Nullable<System.Guid> RaceTypeID { get; set; }
        public Nullable<System.Guid> ReligionID { get; set; }
        public string ReferenceNo { get; set; }
        public string Remarks { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string HomeAddress { get; set; }
        public string HomeCity { get; set; }
        public bool ConvertFromTnG { get; set; }
        public Nullable<System.DateTime> NextBirthday { get; set; }
        public Nullable<short> intBIllingCycle { get; set; }
        public Nullable<byte> intNoType { get; set; }
        public bool intAllowRedem { get; set; }
        public Nullable<bool> intAllowGetPoints { get; set; }
        public Nullable<byte> intCustomerType { get; set; }
        public Nullable<bool> bitEStatement { get; set; }
        public Nullable<System.DateTime> dtEStatementSubscribe { get; set; }
    }
}
