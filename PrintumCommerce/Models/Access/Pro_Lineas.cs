namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Lineas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pro_Lineas()
        {
            cLI_lINExvENDOR = new HashSet<cLI_lINExvENDOR>();
            Pro_Grupos = new HashSet<Pro_Grupos>();
        }

        public double? LN { get; set; }

        [Key]
        public double Linea { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cLI_lINExvENDOR> cLI_lINExvENDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Grupos> Pro_Grupos { get; set; }

        public virtual pRO_lN pRO_lN { get; set; }
    }
}
