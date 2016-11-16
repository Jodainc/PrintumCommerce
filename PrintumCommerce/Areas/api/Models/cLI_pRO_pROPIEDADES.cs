namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cLI_pRO_pROPIEDADES
    {
        public double? IDT { get; set; }

        public int? pROPIEDAD { get; set; }

        [Key]
        public int idCode { get; set; }

        public  Clientes Clientes { get; set; }
    }
}
