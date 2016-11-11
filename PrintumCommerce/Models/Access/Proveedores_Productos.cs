namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedores_Productos
    {
        public double? Id_Proveedor { get; set; }

        public int? tPS { get; set; }

        [StringLength(255)]
        public string Cod_MP { get; set; }

        [StringLength(255)]
        public string cOD_pROVEEDOR { get; set; }

        public double? cOSTOpROmP { get; set; }

        public double? IMPACTO { get; set; }

        [Column(TypeName = "ntext")]
        public string VERIFICACION { get; set; }

        [Column(TypeName = "ntext")]
        public string RESPONSABLES { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
