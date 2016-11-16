namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes_Estadistica
    {
        public double? ID { get; set; }

        public DateTime? fECHA { get; set; }

        [Column("lINEA nEGOCIO")]
        public int? lINEA_nEGOCIO { get; set; }

        [StringLength(255)]
        public string pRODUCTO { get; set; }

        [StringLength(255)]
        public string pROVEEDOR { get; set; }

        public double? pRECIO { get; set; }

        public int? cANTIDAD { get; set; }

        [Key]
        public int idCode { get; set; }
    }
}
