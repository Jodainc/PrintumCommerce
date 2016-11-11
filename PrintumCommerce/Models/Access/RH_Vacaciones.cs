namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Vacaciones
    {
        public double? ID { get; set; }

        public int? rEF { get; set; }

        [StringLength(255)]
        public string pERIODOcAUSADO { get; set; }

        public DateTime? fECHA_dEL { get; set; }

        public DateTime? fECHA_aL { get; set; }

        public double? dIAS_cAUSADOS { get; set; }

        public double? dIAS_aCUMULADOS { get; set; }

        public double? dIAS_a_pAGAR { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        public DateTime? Fecha_Fin { get; set; }

        public double? dIAS_tOMA { get; set; }

        public double? aCUMULA_dIAS { get; set; }

        public double? Dias_Debe { get; set; }

        public double? Dias_Ley { get; set; }

        public double? Total_Dias { get; set; }

        public double? Dias_Real { get; set; }

        public double? Dias_Faltan { get; set; }

        [Column(TypeName = "ntext")]
        public string Soporte { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
