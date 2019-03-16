namespace E_Jornal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subject")]
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            Lectures = new HashSet<Lectures>();
        }

        public int id { get; set; }

        public int Professor_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Modul_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lectures> Lectures { get; set; }

        public virtual Professors Professors { get; set; }
    }
}
