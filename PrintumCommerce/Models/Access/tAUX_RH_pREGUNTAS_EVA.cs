namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_RH_pREGUNTAS_EVA
    {
        [Key]
        [StringLength(255)]
        public string DIR_AZ { get; set; }
    }
}
