namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO5 Referencias Existentes")]
    public partial class PRO5_Referencias_Existentes
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Column("Off Tipogra UV")]
        [StringLength(255)]
        public string Off_Tipogra_UV { get; set; }

        [Column("Off Tipogra Aceite")]
        [StringLength(255)]
        public string Off_Tipogra_Aceite { get; set; }

        [Column("Flx UV")]
        [StringLength(255)]
        public string Flx_UV { get; set; }

        [Column("Flx AGUA")]
        [StringLength(255)]
        public string Flx_AGUA { get; set; }

        [Column("Flx SOVENTE")]
        [StringLength(255)]
        public string Flx_SOVENTE { get; set; }

        [Column("SRC UV")]
        [StringLength(255)]
        public string SRC_UV { get; set; }

        [Column("SRC AGUA")]
        [StringLength(255)]
        public string SRC_AGUA { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual PRO1_Productos PRO1_Productos { get; set; }
    }
}
