namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pRODUCTOS_cLASS
    {
        [StringLength(255)]
        public string cOD_pRO { get; set; }

        [StringLength(255)]
        public string cOD_pRE { get; set; }

        public int? cLASE { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
