//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace teammy
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.team_mates = new HashSet<team_mates>();
        }
    
        public long user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public string privilege_code { get; set; }
        public string email_address { get; set; }
        public string phone_number { get; set; }
        public string prefer_code { get; set; }
    
        public virtual preference preference { get; set; }
        public virtual privilege privilege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<team_mates> team_mates { get; set; }
    }
}
