namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pRO_lN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pRO_lN()
        {
            Pro_Lineas = new HashSet<Pro_Lineas>();
        }

        [Key]
        public double LN { get; set; }

        [Column("Linea Negocio")]
        [StringLength(255)]
        public string Linea_Negocio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Lineas> Pro_Lineas { get; set; }
    }
}
