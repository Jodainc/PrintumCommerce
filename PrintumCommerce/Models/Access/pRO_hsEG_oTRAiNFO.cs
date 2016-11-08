using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models.Access
{
    public class pRO_hsEG_oTRAiNFO
    {
        [Key]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int idCode { get; set; }

        [Column("16Codigo ")]
        public string c16Codigo { get; set; }

        [Column("16iNFO", TypeName = "ntext")]
        public string c16iNFO { get; set; }

        public virtual pRO_hsEG pro_hsEG { set; get; }

    }
}