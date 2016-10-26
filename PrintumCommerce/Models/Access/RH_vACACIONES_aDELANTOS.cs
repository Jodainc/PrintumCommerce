namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_vACACIONES_aDELANTOS
    {
        [Key]
        public int cOD_VACA { get; set; }

        public double? ID { get; set; }

        [StringLength(255)]
        public string pERIODOcAUSADO { get; set; }

        public int? rEF { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        public DateTime? Fecha_Fin { get; set; }

        public double? nOdIAS { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        public int? pAGAR { get; set; }

        public double? AJUSTE { get; set; }
    }
}
