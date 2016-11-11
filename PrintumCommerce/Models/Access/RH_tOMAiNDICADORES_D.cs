namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_tOMAiNDICADORES_D
    {
        [StringLength(255)]
        public string cOD { get; set; }

        [StringLength(255)]
        public string iNDICADOR { get; set; }

        public int? nOTA { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_tOMAiNDICADORES RH_tOMAiNDICADORES { get; set; }
    }
}
