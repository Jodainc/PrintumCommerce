namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_DIR_OP
    {
        [Key]
        [StringLength(255)]
        public string dIR_OP { get; set; }
    }
}
