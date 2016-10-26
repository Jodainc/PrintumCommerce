namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CSeguimiento")]
    public partial class CSeguimiento
    {
        public double? IDCLIENTE { get; set; }

        public DateTime? Fecha { get; set; }

        [Column(TypeName = "ntext")]
        public string Compromiso { get; set; }

        [Column("Fecha Compromiso")]
        public DateTime? Fecha_Compromiso { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [Key]
        [Column(Order = 0)]
        public int no { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Adjuntar { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }
    }
}
