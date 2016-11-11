namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cHEQUES
    {
        public double? sOLICITADOx { get; set; }

        public DateTime? fECHAsOLI { get; set; }

        public DateTime? fECHArESPU { get; set; }

        public double? tERCERO { get; set; }

        public int? pERSONA { get; set; }

        [Key]
        [StringLength(255)]
        public string cHEQUEnO { get; set; }

        public DateTime? fECHAcONSIG { get; set; }

        public double? vALORcHEQUE { get; set; }

        public int? bANCO { get; set; }

        public int? cIUDAD { get; set; }

        [StringLength(255)]
        public string sUCURSAL { get; set; }

        [StringLength(255)]
        public string nOcUENTA { get; set; }

        [StringLength(255)]
        public string tITULARcTA { get; set; }

        public double? nOcC_tITUcTA { get; set; }

        public DateTime? fECHAeXP_cC { get; set; }

        [StringLength(255)]
        public string rEPRElEGAL { get; set; }

        public double? nOcC_rEPRElEGAL { get; set; }

        public DateTime? fECHAeXP_cCrEPRE { get; set; }

        [StringLength(255)]
        public string tEL_rEPRElEGAL { get; set; }

        [StringLength(255)]
        public string cEL_rEPRElEGAL { get; set; }

        public int? cIUDAD1 { get; set; }

        [StringLength(255)]
        public string dIRECCION1 { get; set; }

        public int? cIUDAD2 { get; set; }

        [StringLength(255)]
        public string dIRECCION2 { get; set; }

        [StringLength(255)]
        public string tEL1 { get; set; }

        [StringLength(255)]
        public string tEL2 { get; set; }

        [StringLength(255)]
        public string cEL1 { get; set; }

        [StringLength(255)]
        public string cEL2 { get; set; }

        [StringLength(255)]
        public string rEFpER1 { get; set; }

        public double? nOcC_rEFpER1 { get; set; }

        [StringLength(255)]
        public string rEFpER1_tEL1 { get; set; }

        [StringLength(255)]
        public string rEFpER1_cEL1 { get; set; }

        [StringLength(255)]
        public string rEFpER2 { get; set; }

        public double? nOcC_rEFpER2 { get; set; }

        [StringLength(255)]
        public string rEFpER1_tEL2 { get; set; }

        [StringLength(255)]
        public string rEFpER1_cEL2 { get; set; }

        public int? eSTADO { get; set; }

        [StringLength(255)]
        public string nOaPROBACION { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }
    }
}
