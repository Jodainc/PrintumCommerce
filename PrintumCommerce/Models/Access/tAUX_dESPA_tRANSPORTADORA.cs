namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_dESPA_tRANSPORTADORA
    {
        [Key]
        public double cOD { get; set; }

        [StringLength(255)]
        public string tRANSPORTADORA { get; set; }
    }
}
