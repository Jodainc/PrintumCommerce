namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_POP_D
    {
        public int? nO_eNTEGA { get; set; }

        public int? POP { get; set; }

        public double? cANTIDAD { get; set; }

        [StringLength(255)]
        public string dOC_cOMPRA { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE_rECIBIDO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_POP RH_POP { get; set; }
    }
}
