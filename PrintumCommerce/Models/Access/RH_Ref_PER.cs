namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Ref_PER
    {
        public double? ID { get; set; }

        [Column("Nombre 1")]
        [StringLength(255)]
        public string Nombre_1 { get; set; }

        [Column("Nombre 2")]
        [StringLength(255)]
        public string Nombre_2 { get; set; }

        [Column("Apellido 1")]
        [StringLength(255)]
        public string Apellido_1 { get; set; }

        [Column("Apellido 2")]
        [StringLength(255)]
        public string Apellido_2 { get; set; }

        [Column("Telefono fijo")]
        [StringLength(255)]
        public string Telefono_fijo { get; set; }

        [Column("Telefono Celular")]
        [StringLength(255)]
        public string Telefono_Celular { get; set; }

        [StringLength(255)]
        public string Ocupacion { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
