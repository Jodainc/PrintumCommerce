namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Certificados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pro_Certificados()
        {
            Pro_Medicion = new HashSet<Pro_Medicion>();
        }

        [Key]
        public double No { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(255)]
        public string Cod_producto { get; set; }

        [StringLength(255)]
        public string Presentacion { get; set; }

        [Column(TypeName = "ntext")]
        public string Espectro { get; set; }

        [StringLength(255)]
        public string cERTIdRIVE { get; set; }

        public  Productos Productos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<Pro_Medicion> Pro_Medicion { get; set; }
    }
}
