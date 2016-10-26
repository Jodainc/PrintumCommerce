namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_OC_nOcONFORMIDAD
    {
        [Key]
        public int cOD_NC { get; set; }

        [StringLength(255)]
        public string nOcONFORMIDAD { get; set; }

        [StringLength(255)]
        public string cRITERIO { get; set; }
    }
}
