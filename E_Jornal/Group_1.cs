namespace E_Jornal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group_1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group_1()
        {
            Students = new HashSet<Students>();
        }

        public int id { get; set; }

        public int? Special_module_3 { get; set; }

        public int? Special_module_1 { get; set; }

        public int? Special_module_2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Group_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students { get; set; }
    }
}
