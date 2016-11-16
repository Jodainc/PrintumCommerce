namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pRO_hsEG_ePP
    {
        [Column("8Codigo")]
        [StringLength(255)]
        public string C8Codigo { get; set; }

        [Column("8pROTECCION")]
        [StringLength(255)]
        public string C8pROTECCION { get; set; }

        [Column("8ePP")]
        public string C8ePP { get; set; }

        [Column("8mASiNFO", TypeName = "ntext")]
        public string C8mASiNFO { get; set; }

        [Key]
        public int idCode { get; set; }

        [StringLength(255)]
        public string pro_hsEG_Codigo { get; set; }

        public  pRO_hsEG pRO_hsEG { get; set; }
    }
}
