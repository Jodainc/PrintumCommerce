namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ciudades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_Ciudad { get; set; }

        [StringLength(255)]
        public string Ciudad { get; set; }

        [StringLength(255)]
        public string Ciudad12 { get; set; }
    }
}
