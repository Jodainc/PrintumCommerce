namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Credito")]
    public partial class Credito
    {
        [Key]
        public int Solicitud { get; set; }

        public double? IDCLIENTE { get; set; }

        [Column("Fecha Solicitud")]
        public DateTime? Fecha_Solicitud { get; set; }

        [Column("Activo Corriente")]
        public double? Activo_Corriente { get; set; }

        [Column("Pasivo Corriente")]
        public double? Pasivo_Corriente { get; set; }

        [Column("Activo Total")]
        public double? Activo_Total { get; set; }

        [Column("Pasivo Total")]
        public double? Pasivo_Total { get; set; }

        [Column("Utilidad Bruta")]
        public double? Utilidad_Bruta { get; set; }

        [Column("Ventas Netas")]
        public double? Ventas_Netas { get; set; }

        [Column("Utilidad Operacional")]
        public double? Utilidad_Operacional { get; set; }

        [Column("Utilidad Meta")]
        public double? Utilidad_Meta { get; set; }

        public int? CONCEPTO { get; set; }

        [Column("REPUTACION COMERCIAL")]
        public int? REPUTACION_COMERCIAL { get; set; }

        [Column("REFERENCIAS COMERCIALES")]
        public int? REFERENCIAS_COMERCIALES { get; set; }

        [Column("RENTABILIDAD (B > 5)")]
        public int? RENTABILIDAD__B___5_ { get; set; }

        [Column("LIQUIDEZ  (1,1)")]
        public int? LIQUIDEZ___1_1_ { get; set; }

        [Column("ENDEUDAMIENTO (B < 60%)")]
        public int? ENDEUDAMIENTO__B___60__ { get; set; }

        [Column("CUENTA CORRIENTE")]
        public int? CUENTA_CORRIENTE { get; set; }

        [Column("RESPALDO SOCIOS O PROPIEDADES")]
        public int? RESPALDO_SOCIOS_O_PROPIEDADES { get; set; }

        [Column("LIMPIEZA, ORDEN Y AMPLITUD")]
        public int? LIMPIEZA__ORDEN_Y_AMPLITUD { get; set; }

        [Column("ACTITUD ANTE EL CREDITO")]
        public int? ACTITUD_ANTE_EL_CREDITO { get; set; }

        [Column("ANTIGUEDAD (B > 10 AÑOS)")]
        public int? ANTIGUEDAD__B___10_AÑOS_ { get; set; }

        public int? NICHO { get; set; }

        [Column("CONOCIMIENTO TECNICO")]
        public int? CONOCIMIENTO_TECNICO { get; set; }

        [Column("CONOCIMIENTO COMERCIAL")]
        public int? CONOCIMIENTO_COMERCIAL { get; set; }

        public int? IMPORTANCIA { get; set; }

        [Column("PERSONA NATURAL")]
        public int? PERSONA_NATURAL { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [Column("Monto Aprobado")]
        public double? Monto_Aprobado { get; set; }

        [Column(TypeName = "ntext")]
        public string cONpAGO { get; set; }
    }
}
