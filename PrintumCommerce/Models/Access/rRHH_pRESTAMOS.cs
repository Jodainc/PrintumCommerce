namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rRHH_pRESTAMOS
    {
        [Key]
        public int nO_pRESTAMO { get; set; }

        public double? IDV { get; set; }

        public DateTime? fECHApRESTAMO { get; set; }

        public DateTime? fECHADESEMBOLSO { get; set; }

        public double? pRESTAMO { get; set; }

        public double? nOcUOTAS { get; set; }

        public double? vALORcUOTA { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        [StringLength(255)]
        public string eSTADO { get; set; }

        [StringLength(255)]
        public string cANCELADO { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }
    }
}
