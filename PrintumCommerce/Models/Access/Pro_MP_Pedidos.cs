namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_MP_Pedidos
    {
        [Key]
        public int No_Pedido { get; set; }

        public DateTime? Fecha_PD { get; set; }

        public DateTime? Hora_PD { get; set; }

        [StringLength(255)]
        public string Cod_MP { get; set; }

        public int? Cantidad { get; set; }

        [StringLength(255)]
        public string Entregado { get; set; }

        public DateTime? Fecha_ET { get; set; }

        public DateTime? Hora_ET { get; set; }
    }
}
