namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vENTAS_rECIBOSdEcAJA
    {
        [StringLength(255)]
        public string RC { get; set; }

        [Column("ID TERCERO")]
        public double? ID_TERCERO { get; set; }

        public DateTime? FECHA { get; set; }

        [StringLength(255)]
        public string FACTURA { get; set; }

        [StringLength(255)]
        public string DETALLE { get; set; }

        [Column("VLR RC")]
        public double? VLR_RC { get; set; }

        [StringLength(255)]
        public string COD_RC { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual Clientes Clientes { get; set; }
    }
}
