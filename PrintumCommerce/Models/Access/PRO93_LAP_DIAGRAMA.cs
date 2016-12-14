using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models.Access
{
    [Table("PRO93 LAP DIAGRAMA")]
    public class PRO93_LAP_DIAGRAMA
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [Column(TypeName = "ntext")]
        public string Diagramama { get; set; }

        [Key]
        public int idCode { get; set; }
        public virtual PRO1_Productos PRO1_Productos { get; set; }
    }
}