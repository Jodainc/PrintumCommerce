namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Contra_Sueldos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH_Contra_Sueldos()
        {
            RH_Contratos = new HashSet<RH_Contratos>();
        }

        [Key]
        [StringLength(255)]
        public string Rango { get; set; }

        public int? SB { get; set; }

        [StringLength(255)]
        public string Detalle { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public int? vLRdIAl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Contratos> RH_Contratos { get; set; }
    }
}
