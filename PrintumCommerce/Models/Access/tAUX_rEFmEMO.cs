namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_rEFmEMO
    {
        [Key]
        public int cOD { get; set; }

        [StringLength(255)]
        public string rEF { get; set; }
    }
}
