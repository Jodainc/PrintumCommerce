namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class uSER_pERMIS
    {
        public double? uSER { get; set; }

        public int? fORMUL { get; set; }

        public int? pADD { get; set; }

        public int? pEDIT { get; set; }

        public int? pDELETE { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual aDMIN_fORMULARIOS aDMIN_fORMULARIOS { get; set; }

        public virtual User User1 { get; set; }
    }
}
