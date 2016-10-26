namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_pD_eSTADO
    {
        [Key]
        public int cOD_s { get; set; }

        [StringLength(255)]
        public string eSTADOm { get; set; }

        [StringLength(255)]
        public string aCCIONM { get; set; }
    }
}
