namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VT_Vlr_Liq
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VT_Vlr_Liq()
        {
            Pro_Grupos = new HashSet<Pro_Grupos>();
        }

        [Key]
        [StringLength(255)]
        public string Tipo { get; set; }

        public double? Vendedor { get; set; }

        [Column("Free Lance")]
        public double? Free_Lance { get; set; }

        public double? Lider { get; set; }

        public double? Market { get; set; }

        public double? Cartera { get; set; }

        public double? Punto_Venta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Grupos> Pro_Grupos { get; set; }
    }
}
