namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Contratos
    {
        [Key]
        public int No_Contrato { get; set; }

        [StringLength(243)]
        public string NOC { get; set; }

        public double? Id_Empleado { get; set; }

        [StringLength(255)]
        public string Termino { get; set; }

        [StringLength(255)]
        public string Tiempo_Contrato { get; set; }

        [StringLength(255)]
        public string Cargo { get; set; }

        [StringLength(255)]
        public string Salario { get; set; }

        [StringLength(255)]
        public string Forma_Pago { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        [StringLength(255)]
        public string Lugar_Trabajo { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        public DateTime? Fecha_Retiro { get; set; }

        public int? MF { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        public int? mANEJOcONFIANZA { get; set; }

        public virtual RH_Contra_Sueldos RH_Contra_Sueldos { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }

        public virtual RH_MF RH_MF { get; set; }
    }
}
