namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_pAGO
    {
        [Key]
        public int cODpG { get; set; }

        [StringLength(255)]
        public string pAGO { get; set; }

        public int? nOpLAZO { get; set; }
    }
}
