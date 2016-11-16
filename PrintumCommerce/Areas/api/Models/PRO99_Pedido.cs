namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO99 Pedido")]
    public partial class PRO99_Pedido
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [Column(TypeName = "ntext")]
        public string Informacion { get; set; }

        [Key]
        public int idCode { get; set; }

        public  PRO1_Productos PRO1_Productos { get; set; }
    }
}
