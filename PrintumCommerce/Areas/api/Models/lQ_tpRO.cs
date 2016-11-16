namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lQ_tpRO
    {
        [Key]
        [StringLength(255)]
        public string tIPO { get; set; }

        public double? uTILIDAD { get; set; }
    }
}
