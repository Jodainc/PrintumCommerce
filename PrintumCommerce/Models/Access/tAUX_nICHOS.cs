namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_nICHOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cODnICHO { get; set; }

        [StringLength(255)]
        public string nICHO { get; set; }

        public double? cALIFICACION { get; set; }
    }
}
