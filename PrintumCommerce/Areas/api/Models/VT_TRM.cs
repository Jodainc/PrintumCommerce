namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VT_TRM
    {
        [Key]
        public int COD_TRM { get; set; }

        public DateTime? FE_INICIO { get; set; }

        public DateTime? FE_FIN { get; set; }

        public double? TRMP { get; set; }
    }
}
