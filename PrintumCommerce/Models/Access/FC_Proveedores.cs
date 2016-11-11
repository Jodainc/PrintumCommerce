namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Proveedores
    {
        [StringLength(255)]
        public string Categoria { get; set; }

        [StringLength(255)]
        public string TipoDeIdentificacion { get; set; }

        [StringLength(255)]
        public string Identificacion { get; set; }

        [StringLength(255)]
        public string Nombres_terceros { get; set; }

        [StringLength(255)]
        public string Documento { get; set; }

        [StringLength(255)]
        public string prefijo { get; set; }

        [StringLength(255)]
        public string DocumentoNúmero { get; set; }

        public DateTime? Fecha { get; set; }

        public double? Saldo { get; set; }

        public DateTime? Vencimiento { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual FC_Sem FC_Sem { get; set; }
    }
}
