namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_tOOLS
    {
        public double? ID { get; set; }

        public DateTime? fECHA_eNTREGA { get; set; }

        [StringLength(255)]
        public string eQUIPO { get; set; }

        [StringLength(255)]
        public string mARCA { get; set; }

        [StringLength(255)]
        public string dETALLE { get; set; }

        public DateTime? f_eNTREGO { get; set; }

        [StringLength(255)]
        public string eSTADO { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
