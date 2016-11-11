namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Viaticos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH_Viaticos()
        {
            RH_Viaticos_D = new HashSet<RH_Viaticos_D>();
        }

        [Key]
        public int No_Viatico { get; set; }

        public double? ID { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        public DateTime? Fecha_Fin { get; set; }

        [StringLength(255)]
        public string Motivo { get; set; }

        [Column(TypeName = "ntext")]
        public string Descripcion { get; set; }

        public double? Anticipo { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Viaticos_D> RH_Viaticos_D { get; set; }
    }
}
