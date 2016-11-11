namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_CONTRA_Aumentos_SB
    {
        public double? id { get; set; }

        [StringLength(255)]
        public string TIPO { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? FECHAF { get; set; }

        [StringLength(255)]
        public string Termino { get; set; }

        [StringLength(255)]
        public string Tiempo_Contrato { get; set; }

        [Column("NUEVO CARGO")]
        [StringLength(255)]
        public string NUEVO_CARGO { get; set; }

        [Column("NUEVO SB")]
        [StringLength(255)]
        public string NUEVO_SB { get; set; }

        [StringLength(255)]
        public string Lugar_Trabajo { get; set; }

        public int? MF { get; set; }

        [StringLength(255)]
        public string DeLEY { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }

        public virtual RH_MF RH_MF { get; set; }
    }
}
