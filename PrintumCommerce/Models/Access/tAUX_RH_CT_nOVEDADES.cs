namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_RH_CT_nOVEDADES
    {
        [Key]
        public int cOD { get; set; }

        [StringLength(255)]
        public string nOVEDAD { get; set; }
    }
}
