namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cLI_lINExvENDOR
    {
        public double? iDcLI { get; set; }

        public double? lINEA { get; set; }

        public double? iDV { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual Pro_Lineas Pro_Lineas { get; set; }

        public virtual User User { get; set; }
    }
}
