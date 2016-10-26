namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tAUX_eSTADO_A-C")]
    public partial class tAUX_eSTADO_A_C
    {
        [Key]
        [StringLength(255)]
        public string eSTADO { get; set; }
    }
}
