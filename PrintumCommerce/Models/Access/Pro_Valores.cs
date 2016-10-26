namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Valores
    {
        [Key]
        public double Grupo { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public double? Linea { get; set; }

        [StringLength(255)]
        public string Tipo { get; set; }
    }
}
