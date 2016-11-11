namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LG_rEMISION_D
    {
        public double? NO_rEMI { get; set; }

        [StringLength(255)]
        public string COD_PRODUCTO { get; set; }

        public double? CANTIDAD { get; set; }

        public double? VALORUNIT { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual LG_rEMISION LG_rEMISION { get; set; }
    }
}
