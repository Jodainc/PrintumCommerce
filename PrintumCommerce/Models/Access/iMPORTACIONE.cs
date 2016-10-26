namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("iMPORTACIONES")]
    public partial class iMPORTACIONE
    {
        [Key]
        public double nO_pEDIDO { get; set; }

        public double? pROVEEDOR { get; set; }

        [StringLength(255)]
        public string pRODUCTO { get; set; }

        [StringLength(255)]
        public string pUERTO { get; set; }

        public DateTime? f_lIQ { get; set; }

        [Column("f_B/L")]
        public DateTime? f_B_L { get; set; }

        public DateTime? f_lLEGADA_pUERTO { get; set; }

        public DateTime? f_eNTRADA_aLMACEN { get; set; }

        public double? aL_nACIONALIZAR { get; set; }

        public double? pLAZO_pROVEE { get; set; }

        public double? dIAS_nACIONALIZACION { get; set; }

        public double? pLAZO_fORWARD { get; set; }

        public double? tRANSITO { get; set; }

        public double? dIAS_iNVENTARIO { get; set; }

        public double? dIAS_cARTERA { get; set; }

        public double? fLETE_tOTAL { get; set; }

        public double? gRAVAMEN { get; set; }

        public double? gASTOS_nAVIERA { get; set; }

        public double? cOMISION_AA { get; set; }

        public double? tRANSPORTE_bODEGA { get; set; }

        public double? oTROS_gASTOS { get; set; }

        public double? bODEGAGES_mULTAS { get; set; }

        public double? vACIADO_cONTENEDOR { get; set; }

        public double? iVA { get; set; }

        [Column(TypeName = "ntext")]
        public string dOCUMENTACION { get; set; }
    }
}
