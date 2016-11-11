namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_PAGOS
    {
        public double? ID_E { get; set; }

        public int? aÑO { get; set; }

        public int? mES { get; set; }

        public DateTime? fECHA { get; set; }

        [StringLength(255)]
        public string pAGO { get; set; }

        public double? vALORpAGADO { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        public DateTime? fECHA_cAUSADA1 { get; set; }

        public DateTime? fECHA_cAUSADA2 { get; set; }

        [Column(TypeName = "ntext")]
        public string nOTAS { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [Key]
        public int idCode { get; set; }
    }
}
