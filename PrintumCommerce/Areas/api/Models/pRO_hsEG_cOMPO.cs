namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pRO_hsEG_cOMPO
    {
        [Column("2Codigo")]
        [StringLength(255)]
        public string C2Codigo { get; set; }

        [Column("2cOMPONENTE")]
        [StringLength(255)]
        public string C2cOMPONENTE { get; set; }

        [Column("2pORCEN")]
        public double? C2pORCEN { get; set; }

        [Column("2nOcAS")]
        public string C2nOcAS { get; set; }

        [StringLength(255)]
        public string pro_hsEG_Codigo { get; set; }

        [Key]
        public int idCode { get; set; }
    }
}
