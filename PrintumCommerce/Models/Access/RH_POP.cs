namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_POP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH_POP()
        {
            RH_POP_D = new HashSet<RH_POP_D>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nO_eNTEGA { get; set; }

        public double? ID { get; set; }

        public DateTime? fECHA_eNTREGA { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE_rECIBIDO { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_POP_D> RH_POP_D { get; set; }
    }
}
