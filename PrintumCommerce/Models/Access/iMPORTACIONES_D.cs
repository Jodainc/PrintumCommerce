namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class iMPORTACIONES_D
    {
        public double? nO_pEDIDO { get; set; }

        [StringLength(255)]
        public string rEFERENCIA { get; set; }

        public double? cANTIDAD { get; set; }

        [Column("FOB/EXW")]
        public double? FOB_EXW { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual iMPORTACIONES iMPORTACIONES { get; set; }

        public virtual Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
