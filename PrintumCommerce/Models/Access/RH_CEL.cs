namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_CEL
    {
        public double? iD { get; set; }

        public DateTime? fECHA_eNTREGA { get; set; }

        [StringLength(255)]
        public string Marca { get; set; }

        [StringLength(255)]
        public string Referencia { get; set; }

        [StringLength(255)]
        public string IMEI { get; set; }

        [StringLength(255)]
        public string No_SIM { get; set; }

        [StringLength(255)]
        public string No_SIM1 { get; set; }

        [StringLength(255)]
        public string No_Celular { get; set; }

        public DateTime? f_eNTREGO { get; set; }

        [StringLength(255)]
        public string eSTADO { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
