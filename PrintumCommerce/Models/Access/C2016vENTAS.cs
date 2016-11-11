namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("2016vENTAS")]
    public partial class C2016vENTAS
    {
        public double? ID { get; set; }

        public double? VENDEDOR { get; set; }

        [StringLength(255)]
        public string FACTURA { get; set; }

        public double? FP { get; set; }

        public DateTime? FECHA { get; set; }

        [Column("FECHA VENCE")]
        public DateTime? FECHA_VENCE { get; set; }

        [StringLength(255)]
        public string CODIGO { get; set; }

        public double? CANTIDAD { get; set; }

        [Column("VLR UNITARIO")]
        public double? VLR_UNITARIO { get; set; }

        [Column("% DESCUENTO")]
        public double? C__DESCUENTO { get; set; }

        [Column("COSTO UNITARIO")]
        public double? COSTO_UNITARIO { get; set; }

        [Column("VALOR TOTAL")]
        public double? VALOR_TOTAL { get; set; }

        [Column("COSTO TOTAL")]
        public double? COSTO_TOTAL { get; set; }

        public double? MARGEN { get; set; }

        [Column("%")]
        public double? C_ { get; set; }

        [StringLength(255)]
        public string COD_RC { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual Clientes Clientes { get; set; }

        public virtual Pro_Presentacion Pro_Presentacion { get; set; }

        public virtual User User { get; set; }
    }
}
