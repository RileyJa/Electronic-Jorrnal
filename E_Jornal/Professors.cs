namespace E_Jornal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Professors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professors()
        {
            Subject = new HashSet<Subject>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Specialty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject> Subject { get; set; }
    }
}
