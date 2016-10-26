namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rECIBOSdEcAJA")]
    public partial class rECIBOSdEcAJA
    {
        public DateTime? fECHArC { get; set; }

        [Key]
        [StringLength(255)]
        public string fACTURA { get; set; }

        [StringLength(255)]
        public string pREFIJO { get; set; }

        public int? nOfAC { get; set; }

        [StringLength(243)]
        public string fAC_nO { get; set; }

        public double? rCnO { get; set; }

        public DateTime? FCREA { get; set; }

        public DateTime? HCREA { get; set; }
    }
}
