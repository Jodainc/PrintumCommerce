namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_fORMATOS
    {
        [Key]
        public int nO { get; set; }

        [Column(TypeName = "ntext")]
        public string fORMATOS { get; set; }
    }
}
