namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_pRO_tPS
    {
        [Key]
        public int cDOtPS { get; set; }

        [StringLength(255)]
        public string tPS { get; set; }
    }
}
