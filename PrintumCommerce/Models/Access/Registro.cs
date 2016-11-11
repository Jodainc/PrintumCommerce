namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Registro")]
    public partial class Registro
    {
        public double? ID { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? Hora { get; set; }

        [StringLength(255)]
        public string dESDEpC { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual User User { get; set; }
    }
}
