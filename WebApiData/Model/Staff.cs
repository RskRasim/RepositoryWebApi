namespace WebApiData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }

        [StringLength(35)]
        public string Username { get; set; }

        public string Password { get; set; }

        [StringLength(35)]
        public string Name { get; set; }

        [StringLength(35)]
        public string Surname { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Department { get; set; }

        [StringLength(35)]
        public string Task { get; set; }

        public int? CompanyId { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
