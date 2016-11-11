namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pRESUPUESTO_$")]
    public partial class pRESUPUESTO__
    {
        public double? ID_vENDEDOR { get; set; }

        public int? AÑO { get; set; }

        [StringLength(255)]
        public string MES { get; set; }

        public double? PRESUPUESTO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual User User { get; set; }
    }
}
