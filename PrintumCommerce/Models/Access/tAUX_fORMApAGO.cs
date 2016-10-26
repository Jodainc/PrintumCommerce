namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_fORMApAGO
    {
        [Key]
        public double cODfP { get; set; }

        [StringLength(255)]
        public string fORMApAGO { get; set; }
    }
}
