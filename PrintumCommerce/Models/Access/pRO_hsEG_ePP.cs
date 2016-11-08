using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models.Access
{
    public class pRO_hsEG_ePP
    {
        [Key]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int idCode { get; set; }

        [Column("8Codigo ")]
        public string C8Codigo { get; set; }

        [Column("8pROTECCION", TypeName = "ntext")]
        public string C8pROTECCION { get; set; }

        [Column("8ePP")]
        public string c8ePP { get; set; }

        [Column("8mASiNFO")]
        public string c8mASiNFO { get; set; }

        public virtual pRO_hsEG pro_hsEG { set; get; }

    }
}