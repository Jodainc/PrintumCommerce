namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pRO_hsEG_oTRAiNFO
    {
        [Column("16Codigo")]
        [StringLength(255)]
        public string C16Codigo { get; set; }

        [Column("16iNFO", TypeName = "ntext")]
        public string C16iNFO { get; set; }

        [Key]
        public int idCode { get; set; }

        public  pRO_hsEG pRO_hsEG { get; set; }
    }
}
