namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VT_cONDICION_pRESUPUESTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nO { get; set; }

        [StringLength(255)]
        public string cRITERIO { get; set; }

        [StringLength(255)]
        public string cONDICION { get; set; }

        public double? GANA_PIERDE { get; set; }
    }
}
