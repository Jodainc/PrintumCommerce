namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_eVALUACIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH_eVALUACIONES()
        {
            RH_eVALUACIONES_D = new HashSet<RH_eVALUACIONES_D>();
        }

        [Key]
        [StringLength(255)]
        public string cOD { get; set; }

        public double? ID_E { get; set; }

        public int? aÑO { get; set; }

        public int? mES { get; set; }

        [Column(TypeName = "ntext")]
        public string cOMPRIMISOS { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_eVALUACIONES_D> RH_eVALUACIONES_D { get; set; }
    }
}
