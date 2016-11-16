namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO93 lAP Propiedades Electricas")]
    public partial class PRO93_lAP_Propiedades_Electricas
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [StringLength(50)]
        public string Info { get; set; }

        [StringLength(255)]
        public string Medicion { get; set; }

        [Key]
        public int idCode { get; set; }

        public  PRO1_Productos PRO1_Productos { get; set; }
    }
}
