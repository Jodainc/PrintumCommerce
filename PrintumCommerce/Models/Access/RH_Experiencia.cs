namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Experiencia
    {
        public double? ID { get; set; }

        [StringLength(255)]
        public string Nombre_Empresa { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [Column("Telefono fijo")]
        [StringLength(255)]
        public string Telefono_fijo { get; set; }

        [Column("Actividad Comercial")]
        [StringLength(255)]
        public string Actividad_Comercial { get; set; }

        [Column("Cargo Desempeñado")]
        [StringLength(255)]
        public string Cargo_Desempeñado { get; set; }

        [Column(TypeName = "ntext")]
        public string Funciones { get; set; }

        public DateTime? TL_Desde { get; set; }

        public DateTime? TL_Hasta { get; set; }

        [Column("Razon Retiro", TypeName = "ntext")]
        public string Razon_Retiro { get; set; }

        [StringLength(255)]
        public string Referencia { get; set; }

        [Column("Telefono fijo1")]
        [StringLength(255)]
        public string Telefono_fijo1 { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
