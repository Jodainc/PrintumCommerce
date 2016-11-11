namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTZ_D
    {
        public int? nO_CTZ { get; set; }

        [StringLength(255)]
        public string cOD_pRO { get; set; }

        public double? cANTIDAD { get; set; }

        [Column("vLR kG O uND")]
        public double? vLR_kG_O_uND { get; set; }

        [StringLength(255)]
        public string pRESENTACION { get; set; }

        public double? dCTO { get; set; }

        [StringLength(255)]
        public string cOD_D { get; set; }

        [StringLength(255)]
        public string dESCRIP { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual CTZ CTZ { get; set; }

        public virtual Pro_Presentacion Pro_Presentacion { get; set; }
    }
}
