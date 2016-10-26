namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_lIQUIDACIONES
    {
        [Key]
        public int cOD { get; set; }

        public int? nO_cONTRATO { get; set; }

        public double? iD_E { get; set; }

        public DateTime? fECHA_lQ { get; set; }

        [StringLength(255)]
        public string mOTIVO { get; set; }

        public double? sALARIObASE { get; set; }

        public double? aUX_tRANS { get; set; }

        [StringLength(255)]
        public string cOMI { get; set; }

        public double? pROcOMI { get; set; }

        public DateTime? f_iNICIO_pRIMA { get; set; }

        public DateTime? f_iNICIO_vACACIONES { get; set; }

        public DateTime? f_iNICIO_cESANTIAS { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTES { get; set; }
    }
}
