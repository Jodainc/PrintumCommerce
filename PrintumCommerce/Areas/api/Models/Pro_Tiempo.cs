namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Tiempo
    {
        [StringLength(255)]
        public string cod { get; set; }

        [Key]
        [StringLength(255)]
        public string Cod_Producto { get; set; }

        public double? Tiempo { get; set; }

        [StringLength(255)]
        public string Unidad_Medida { get; set; }

        public  Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
