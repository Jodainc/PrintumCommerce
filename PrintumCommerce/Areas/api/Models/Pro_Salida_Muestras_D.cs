namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Salida_Muestras_D
    {
        public int? No_Salida_pro { get; set; }

        [Key]
        public int No_Muestra { get; set; }

        [StringLength(255)]
        public string Tipo { get; set; }

        [StringLength(255)]
        public string Cod_Prod { get; set; }

        [StringLength(255)]
        public string New_Producto { get; set; }

        public double? Cantidad { get; set; }

        [StringLength(255)]
        public string Und_Medida { get; set; }

        [Column(TypeName = "ntext")]
        public string Observaciones { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        public DateTime? Fecha_Entrega_Log { get; set; }
    }
}
