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
    
    public partial class SecurityPasswordPolicy
    {
        public int idPolicy { get; set; }
        public Nullable<int> intSite { get; set; }
        public Nullable<int> intPwdMaxLen { get; set; }
        public Nullable<int> intPwdMinLen { get; set; }
        public Nullable<int> intPwdExpiry { get; set; }
        public Nullable<int> intPwdRecycleTimes { get; set; }
        public Nullable<bool> intUpperCaseFlag { get; set; }
        public Nullable<bool> intLowerCaseFlag { get; set; }
        public Nullable<bool> intNumbersFlag { get; set; }
        public Nullable<bool> intSpecialCharFlag { get; set; }
        public Nullable<bool> intChangePwdnextLogon { get; set; }
        public Nullable<int> intAccountLockoutThreshold { get; set; }
        public Nullable<int> intSuspendDays { get; set; }
        public Nullable<int> intMaxInActiveDay { get; set; }
    }
}