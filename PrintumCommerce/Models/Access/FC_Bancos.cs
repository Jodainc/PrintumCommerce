namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Bancos
    {
        [StringLength(255)]
        public string Categoria { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(255)]
        public string Banco { get; set; }

        public double? Saldo { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual FC_Sem FC_Sem { get; set; }
    }
}
