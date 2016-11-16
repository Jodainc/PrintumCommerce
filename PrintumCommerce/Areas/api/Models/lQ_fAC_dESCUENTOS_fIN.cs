namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lQ_fAC_dESCUENTOS_fIN
    {
        [Key]
        [StringLength(255)]
        public string nO_fAC { get; set; }

        [StringLength(255)]
        public string pREFIJO { get; set; }

        public int? nO { get; set; }

        [StringLength(243)]
        public string nOfAC { get; set; }

        public double? vALORfAC { get; set; }

        public double? dESCUENTO { get; set; }

        public double? vLRdES { get; set; }

        public DateTime? fECHADF { get; set; }
    }
}
