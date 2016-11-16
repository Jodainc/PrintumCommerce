namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Formula
    {
        [StringLength(255)]
        public string Cod_Producto { get; set; }

        [StringLength(255)]
        public string PP { get; set; }

        [StringLength(255)]
        public string Material { get; set; }

        [Column("Cantidad gr")]
        public double? Cantidad_gr { get; set; }

        [Key]
        public int idCode { get; set; }

        public  Productos Productos { get; set; }
    }
}
