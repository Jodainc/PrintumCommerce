namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_cESANTIAS
    {
        [Key]
        public int cOD_CS { get; set; }

        public double? iD_E { get; set; }

        [StringLength(255)]
        public string aÑO_cAUSADO { get; set; }

        public DateTime? fECHAiNICIO { get; set; }

        public DateTime? fECHAfIN { get; set; }

        [StringLength(255)]
        public string mOTIVO { get; set; }

        [StringLength(255)]
        public string mOVIMIENTO { get; set; }

        public int? vALOR_cS { get; set; }

        public DateTime? fECHA_eNTREGA_vALOR { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        public DateTime? Fecharad { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
