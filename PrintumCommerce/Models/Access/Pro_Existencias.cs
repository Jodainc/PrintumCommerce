namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Existencias
    {
        [StringLength(255)]
        public string Cod_Pro { get; set; }

        public double? Existencias { get; set; }

        [StringLength(255)]
        public string Bodega { get; set; }

        [Column("cOSTO pROMEDIO")]
        public double? cOSTO_pROMEDIO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
