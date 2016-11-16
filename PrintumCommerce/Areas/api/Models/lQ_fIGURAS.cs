namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lQ_fIGURAS
    {
        [Key]
        public int cOD_fIG { get; set; }

        [StringLength(255)]
        public string fIGURA { get; set; }

        public double? mARGEN { get; set; }
    }
}
