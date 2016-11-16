namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FC_Saldo Ayer")]
    public partial class FC_Saldo_Ayer
    {
        [Key]
        public DateTime FECHA { get; set; }

        [Column("SALDO AYER")]
        public double? SALDO_AYER { get; set; }
    }
}
