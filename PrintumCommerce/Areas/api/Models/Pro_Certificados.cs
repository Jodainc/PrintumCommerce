namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Certificados
    {
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
    }
}
