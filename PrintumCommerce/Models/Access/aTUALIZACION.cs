namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("aTUALIZACION")]
    public partial class aTUALIZACION
    {
        [Key]
        public int nO { get; set; }

        public DateTime? fECHA { get; set; }

        public DateTime? hORA { get; set; }

        [StringLength(255)]
        public string tIPO { get; set; }
    }
}
