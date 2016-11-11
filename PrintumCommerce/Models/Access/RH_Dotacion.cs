namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Dotacion
    {
        public double? ID { get; set; }

        public DateTime? fECHA_eNTREGA { get; set; }

        public int? Bata { get; set; }

        public int? Overol { get; set; }

        public int? Pantalon { get; set; }

        [Column("Camisa Polo")]
        public int? Camisa_Polo { get; set; }

        [Column("Camisa ML")]
        public int? Camisa_ML { get; set; }

        [Column("Camisa MC")]
        public int? Camisa_MC { get; set; }

        public int? Camiseta { get; set; }

        public int? Zapatos { get; set; }

        [Column("Vestido Dama 1P")]
        public int? Vestido_Dama_1P { get; set; }

        [Column("Vestido Dama 2P")]
        public int? Vestido_Dama_2P { get; set; }

        public int? Chaleco { get; set; }

        public int? Chaqueta { get; set; }

        public int? Gorra { get; set; }

        public DateTime? f_eNTREGO { get; set; }

        [StringLength(255)]
        public string eSTADO { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
