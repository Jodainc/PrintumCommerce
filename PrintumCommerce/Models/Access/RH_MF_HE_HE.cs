namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_MF_HE_HE
    {
        public int? nO_MF { get; set; }

        [StringLength(255)]
        public string tXT { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_MF RH_MF { get; set; }
    }
}
