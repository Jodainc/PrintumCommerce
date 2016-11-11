namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FC-Creditos")]
    public partial class FC_Creditos
    {
        [StringLength(255)]
        public string Categoria { get; set; }

        public DateTime? Fecha_Pago { get; set; }

        public double? Valor_Pago { get; set; }

        [StringLength(255)]
        public string Detalle_1 { get; set; }

        [StringLength(255)]
        public string Detalle_2 { get; set; }

        public double? iNTERES { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual FC_Sem FC_Sem { get; set; }
    }
}
