namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Salida_Muestras
    {
        [Key]
        public int No_Salida { get; set; }

        public DateTime? Fecha_Solicitud { get; set; }

        public DateTime? Hora_Solicitud { get; set; }

        [Column("No Orden/Remision")]
        public int? No_Orden_Remision { get; set; }

        public double? Solicitado_Por { get; set; }

        [Column("Tipo Cliente")]
        [StringLength(255)]
        public string Tipo_Cliente { get; set; }

        public double? Solicitado_Para { get; set; }

        [Column(TypeName = "ntext")]
        public string Observaciones { get; set; }

        public DateTime? Fecha_Requisicion { get; set; }

        public DateTime? Fecha_Salida { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }
    }
}
