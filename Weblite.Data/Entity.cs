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
    
    public partial class Entity
    {
        public Entity()
        {
            this.Entity1 = new HashSet<Entity>();
            this.SecurityRoleEntities = new HashSet<SecurityRoleEntity>();
        }
    
        public System.Guid EntityID { get; set; }
        public System.Guid EntityTypeID { get; set; }
        public Nullable<System.Guid> EntityParentID { get; set; }
        public string EntityName { get; set; }
        public string EntityAddress { get; set; }
        public Nullable<System.Guid> EntityCountryID { get; set; }
        public Nullable<System.Guid> EntityStateID { get; set; }
        public Nullable<System.Guid> EntityCityID { get; set; }
        public string EntityPostcode { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string EntityCity { get; set; }
    
        public virtual ICollection<Entity> Entity1 { get; set; }
        public virtual Entity Entity2 { get; set; }
        public virtual EntityType EntityType { get; set; }
        public virtual Region Region { get; set; }
        public virtual Region Region1 { get; set; }
        public virtual Region Region2 { get; set; }
        public virtual ICollection<SecurityRoleEntity> SecurityRoleEntities { get; set; }
    }
}