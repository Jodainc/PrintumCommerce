namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Viaticos_D
    {
        public int? No_Viatico { get; set; }

        [StringLength(255)]
        public string Concepto { get; set; }

        [StringLength(255)]
        public string Nit { get; set; }

        [StringLength(255)]
        public string Razon_Social { get; set; }

        public double? Base { get; set; }

        public double? Iva { get; set; }

        public double? Total { get; set; }

        [Column(TypeName = "ntext")]
        public string Soporte { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_Viaticos RH_Viaticos { get; set; }
    }
}
