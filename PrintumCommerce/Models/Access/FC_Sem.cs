namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Sem
    {
        [StringLength(255)]
        public string MES { get; set; }

        [Key]
        [Column("FECHA FC")]
        public DateTime FECHA_FC { get; set; }

        [StringLength(255)]
        public string DIA { get; set; }

        public double? SEMANA { get; set; }

        public short? AÑO { get; set; }

        [StringLength(243)]
        public string COD { get; set; }

        [StringLength(243)]
        public string COD1 { get; set; }
    }
}
