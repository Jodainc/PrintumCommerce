namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRO_OC_NC
    {
        public double? NO_OC { get; set; }

        public int? tIPOnOcoNFORME { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual PRO_OC PRO_OC { get; set; }
    }
}
