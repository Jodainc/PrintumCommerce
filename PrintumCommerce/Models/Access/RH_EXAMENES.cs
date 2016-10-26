namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_EXAMENES
    {
        [Key]
        public int CodEx { get; set; }

        public double? ID_E { get; set; }

        public DateTime? fECHA { get; set; }

        [StringLength(255)]
        public string mOTIVO { get; set; }

        [StringLength(255)]
        public string tIPO_eXAMEN { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        [Column(TypeName = "ntext")]
        public string rECOMEN { get; set; }

        [Column(TypeName = "ntext")]
        public string sPeNTREGA { get; set; }

        public int? rEMITIDO { get; set; }

        public int? rEMITIDOa { get; set; }

        [Column(TypeName = "ntext")]
        public string sPaSIS { get; set; }
    }
}
