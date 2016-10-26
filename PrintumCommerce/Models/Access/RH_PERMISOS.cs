namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_PERMISOS
    {
        [Key]
        public int COD_PER { get; set; }

        public double? ID { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        public DateTime? fECHA_sOLICITUD { get; set; }

        public DateTime? fECHA_pERMISO { get; set; }

        public DateTime? fECHA_pERMISO_fIN { get; set; }

        public int? mOTp { get; set; }

        public int? cAUSAP { get; set; }

        [StringLength(255)]
        public string mOT { get; set; }

        [Column(TypeName = "ntext")]
        public string mOTIVO { get; set; }

        public int? tODOeLdIA { get; set; }

        public int? rEMUNERADO { get; set; }

        public DateTime? h_iNICIO { get; set; }

        public DateTime? h_fIN { get; set; }

        public double? nO_hORAS { get; set; }

        public double? nO_dIAS { get; set; }

        [Column(TypeName = "ntext")]
        public string aDJUNTO { get; set; }

        [Column(TypeName = "ntext")]
        public string cONSTANCIA { get; set; }

        public int? rEPUESTO { get; set; }

        [StringLength(255)]
        public string mOT_rEPUESTO { get; set; }

        public DateTime? fECHA_rEPUESTO { get; set; }

        public int? pAGADA { get; set; }

        public DateTime? fpAGO { get; set; }

        public double? vALORpAGO { get; set; }

        public int? QAG { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
