namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_eVALUACIONES_D
    {
        [StringLength(255)]
        public string cOD { get; set; }

        [StringLength(255)]
        public string aCTIVIDAD { get; set; }

        public int? nOTA_EMPLEADO { get; set; }

        public int? nOTA_SUPERVISOR { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_eVALUACIONES RH_eVALUACIONES { get; set; }
    }
}
