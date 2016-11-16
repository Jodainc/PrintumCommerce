namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Medicion
    {
        public double? No_Certificado { get; set; }

        public int? Prueba { get; set; }

        [StringLength(255)]
        public string R_PRUEBA { get; set; }

        [Key]
        public int idCode { get; set; }

        public  Pro_Certificados Pro_Certificados { get; set; }
    }
}
