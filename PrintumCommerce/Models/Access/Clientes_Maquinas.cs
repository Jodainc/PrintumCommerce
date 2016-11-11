namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes_Maquinas
    {
        public double? id { get; set; }

        [StringLength(255)]
        public string Proceso { get; set; }

        [StringLength(255)]
        public string Marca { get; set; }

        [StringLength(255)]
        public string Tamaño { get; set; }

        [StringLength(255)]
        public string Unid { get; set; }

        [StringLength(255)]
        public string Secado { get; set; }

        [Column(TypeName = "ntext")]
        public string Observaciones { get; set; }

        public double? pRECIO1 { get; set; }

        public double? pRECIO2 { get; set; }

        [Key]
        public int idCode { get; set; }
    }
}
