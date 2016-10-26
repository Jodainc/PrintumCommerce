namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_cLI_cALIFICACION
    {
        [Key]
        public int COD_CCC { get; set; }

        [StringLength(255)]
        public string cALIF { get; set; }

        [StringLength(255)]
        public string CONDICION { get; set; }

        public double? PDCTOC { get; set; }
    }
}
