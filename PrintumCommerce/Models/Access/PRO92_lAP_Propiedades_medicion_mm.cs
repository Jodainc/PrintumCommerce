namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO92 lAP Propiedades medicion mm")]
    public partial class PRO92_lAP_Propiedades_medicion_mm
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [StringLength(50)]
        public string Info { get; set; }

        [StringLength(255)]
        public string Medicion { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual PRO1_Productos PRO1_Productos { get; set; }
    }
}
