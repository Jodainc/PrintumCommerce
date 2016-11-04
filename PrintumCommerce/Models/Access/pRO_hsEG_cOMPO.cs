using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace PrintumCommerce.Models.Access
{
    public class pRO_hsEG_cOMPO
    {
        [Key]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int idCode { get; set; }

        [Column("2Codigo ")]
        public string C2Codigo { get; set; }

        [Column("2cOMPONENTE", TypeName = "ntext")]
        public string C2cOMPONENTE { get; set; }

        [Column("2pORCEN")]
        public double? C2pORCEN { get; set; }

        [Column("2nOcAS")]
        public string C2nOcAS { get; set; }

        public virtual pRO_hsEG pro_hsEG { set; get; }


    }
}