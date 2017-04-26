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
    
    public partial class tblMasterAccount
    {
        public long idMasterAccount { get; set; }
        public string strEmail { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string strAccountRef { get; set; }
        public byte intRefType { get; set; }
        public string strAccountName { get; set; }
        public System.DateTime dtAccountCreate { get; set; }
        public Nullable<byte> intBillingCycle { get; set; }
        public string strMobileNo { get; set; }
        public Nullable<System.DateTime> dtBirthDate { get; set; }
        public Nullable<byte> intGender { get; set; }
        public Nullable<System.Guid> idJobTitle { get; set; }
        public Nullable<System.Guid> idEducation { get; set; }
        public Nullable<System.Guid> idIncome { get; set; }
        public string strBusPhone { get; set; }
        public string strHousePhone { get; set; }
        public string strMobilePhone { get; set; }
        public string strFax { get; set; }
        public Nullable<byte> intEmailConsent { get; set; }
        public Nullable<byte> intSMSConsent { get; set; }
        public Nullable<byte> intContactMethod { get; set; }
        public string strHomeAddress1 { get; set; }
        public string strHomeAddress2 { get; set; }
        public string strHomeAddress3 { get; set; }
        public Nullable<System.Guid> idHomeCity { get; set; }
        public string strHomePostCd { get; set; }
        public Nullable<System.Guid> idHomeState { get; set; }
        public Nullable<System.Guid> idHomeCountry { get; set; }
        public string strDeliverAddress1 { get; set; }
        public string strDeliverAddress2 { get; set; }
        public string strDeliverAddress3 { get; set; }
        public Nullable<System.Guid> idDeliverCity { get; set; }
        public string strDeliverPostCd { get; set; }
        public Nullable<System.Guid> idDeliverState { get; set; }
        public Nullable<System.Guid> idDeliverCountry { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public string strHomeCity { get; set; }
        public string strDeliverCity { get; set; }
        public Nullable<System.Guid> idRace { get; set; }
        public Nullable<System.Guid> idNationality { get; set; }
        public Nullable<System.Guid> idReligion { get; set; }
        public Nullable<byte> intMaritalStatus { get; set; }
        public string strFirstName { get; set; }
        public string strLastName { get; set; }
        public Nullable<bool> intStatus { get; set; }
        public Nullable<bool> IMXInstall { get; set; }
        public string strRemarks { get; set; }
        public Nullable<byte> intCustomerType { get; set; }
        public bool bitEStatement { get; set; }
        public Nullable<System.DateTime> dtEStatementSubscribe { get; set; }
    }
}