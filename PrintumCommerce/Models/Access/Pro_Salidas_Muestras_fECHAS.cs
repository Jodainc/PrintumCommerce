namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Salidas_Muestras_fECHAS
    {
        public int? cOD_mUESTRA { get; set; }

        public int? cONCEPTO { get; set; }

        [Column(TypeName = "ntext")]
        public string iNFO { get; set; }

        public DateTime? fECHA_C { get; set; }

        public DateTime? hORA_C { get; set; }

        [Key]
        public int idCode { get; set; }
    }
}
