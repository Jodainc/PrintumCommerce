namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLI_dIR_OP
    {
        public double? IDCLI { get; set; }

        [StringLength(255)]
        public string DIR_OP { get; set; }

        [StringLength(255)]
        public string DETALLE_dIROP { get; set; }

        [Key]
        public int idCode { get; set; }
    }
}
