namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRO_OC_D
    {
        public double? NO_OC { get; set; }

        [StringLength(255)]
        public string COD_PRODUCTO { get; set; }

        public double? CANTIDAD { get; set; }

        [StringLength(255)]
        public string RECIBIDO { get; set; }

        [StringLength(255)]
        public string ESTADO { get; set; }

        [Column(TypeName = "ntext")]
        public string nOTAS { get; set; }

        public double? pRECIOp { get; set; }

        [StringLength(255)]
        public string COD_ITM { get; set; }

        [StringLength(255)]
        public string ITEM { get; set; }

        public double? ID_PRO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual PRO_OC PRO_OC { get; set; }

        public virtual Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
