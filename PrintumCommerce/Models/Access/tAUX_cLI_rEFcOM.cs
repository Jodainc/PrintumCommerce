namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_cLI_rEFcOM
    {
        [Key]
        public int cODn { get; set; }

        [StringLength(255)]
        public string cALF { get; set; }

        public double? vLRnT { get; set; }
    }
}
