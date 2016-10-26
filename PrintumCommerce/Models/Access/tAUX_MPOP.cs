namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_MPOP
    {
        [Key]
        public int nO { get; set; }

        [StringLength(255)]
        public string pOP { get; set; }
    }
}
