namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clientes CONTAC")]
    public partial class Clientes_CONTAC
    {
        public double? idCLIENTE { get; set; }

        [StringLength(255)]
        public string Contacto { get; set; }

        [StringLength(255)]
        public string Cargo { get; set; }

        [Column("Telefono OF")]
        [StringLength(255)]
        public string Telefono_OF { get; set; }

        [StringLength(255)]
        public string Telefono1 { get; set; }

        [StringLength(255)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string Celular { get; set; }

        [StringLength(255)]
        public string Mail { get; set; }

        public DateTime? fECHA_cUMPLEAÑOS { get; set; }

        public int? AREA { get; set; }

        [Key]
        public int idCode { get; set; }
    }
}
