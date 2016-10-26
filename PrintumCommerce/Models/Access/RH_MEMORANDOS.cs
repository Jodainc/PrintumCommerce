namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_MEMORANDOS
    {
        [Key]
        public int nO_mEMO { get; set; }

        public int? tIPO { get; set; }

        public double? ID { get; set; }

        [StringLength(255)]
        public string rEF { get; set; }

        public DateTime? fECHA_mEMO { get; set; }

        [Column(TypeName = "ntext")]
        public string mOTIVO { get; set; }

        [Column(TypeName = "ntext")]
        public string aDJUNTO { get; set; }

        public double? FR_RESPONSABLE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
