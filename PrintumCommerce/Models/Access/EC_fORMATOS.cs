namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EC_fORMATOS
    {
        [Key]
        public int No { get; set; }

        [StringLength(255)]
        public string dOCU { get; set; }

        [Column(TypeName = "ntext")]
        public string dOMUMENTACION { get; set; }
    }
}
