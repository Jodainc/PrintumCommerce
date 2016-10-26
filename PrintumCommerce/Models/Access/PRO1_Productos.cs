namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO1 Productos")]
    public partial class PRO1_Productos
    {
        public double? Cod_Linea { get; set; }

        public double? Cod_Grupo { get; set; }

        [StringLength(255)]
        public string COD_PRODUCTO { get; set; }

        [Key]
        [StringLength(255)]
        public string Cod_pro { get; set; }

        [StringLength(255)]
        public string Producto { get; set; }

        [Column(TypeName = "ntext")]
        public string Descripcion { get; set; }

        [Column(TypeName = "ntext")]
        public string Imagen { get; set; }

        public virtual Producto Producto1 { get; set; }
    }
}
