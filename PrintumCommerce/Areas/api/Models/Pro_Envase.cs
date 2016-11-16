namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Envase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod_Envase { get; set; }

        [StringLength(255)]
        public string Envase { get; set; }

        [Column("Peso Neto")]
        public double? Peso_Neto { get; set; }

        [Column("Peso Bruto")]
        public double? Peso_Bruto { get; set; }
    }
}
