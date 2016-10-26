namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_pROVE_cRITERIOSeVA
    {
        [Key]
        public int cOD { get; set; }

        public double? rANGO { get; set; }

        [StringLength(255)]
        public string nOTAE { get; set; }

        [Column(TypeName = "ntext")]
        public string oBS { get; set; }
    }
}
