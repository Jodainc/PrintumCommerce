namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lQ_lIST_dCTOS
    {
        [Key]
        public int nOdCTO { get; set; }

        public double? IDCLI { get; set; }

        public int? aÑOD { get; set; }

        [StringLength(255)]
        public string mESD { get; set; }

        public double? gRUPO { get; set; }

        public double? dCTO { get; set; }

        public DateTime? fINICIO { get; set; }

        public DateTime? ffIN { get; set; }
    }
}
