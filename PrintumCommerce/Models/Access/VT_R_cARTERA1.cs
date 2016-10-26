namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VT_R_cARTERA1
    {
        [Key]
        [StringLength(255)]
        public string COD { get; set; }

        public double? ID { get; set; }

        public DateTime? Fecha { get; set; }

        public short? Año { get; set; }

        [StringLength(255)]
        public string MES { get; set; }

        public double? TOTALC { get; set; }

        public double? Normal1 { get; set; }

        public double? Morosa1 { get; set; }

        public double? Preocupante1 { get; set; }

        public double? Descontable1 { get; set; }

        public double? iN { get; set; }

        public double? iM { get; set; }

        public double? iP { get; set; }

        public double? iDS { get; set; }

        public double? TPC { get; set; }
    }
}
