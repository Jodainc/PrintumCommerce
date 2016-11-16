namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO4 Propiedades de Aplicación")]
    public partial class PRO4_Propiedades_de_Aplicación
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [Column("Proceso de Impresión", TypeName = "ntext")]
        public string Proceso_de_Impresión { get; set; }

        [Column(TypeName = "ntext")]
        public string Naturaleza { get; set; }

        [StringLength(255)]
        public string Viscosidad { get; set; }

        [Column("Sustrato Recomendado", TypeName = "ntext")]
        public string Sustrato_Recomendado { get; set; }

        [StringLength(255)]
        public string LPI1 { get; set; }

        [StringLength(255)]
        public string LPI2 { get; set; }

        [StringLength(255)]
        public string LPI3 { get; set; }

        [Column("G/M2 - BCM1")]
        [StringLength(255)]
        public string G_M2___BCM1 { get; set; }

        [Column("G/M2 - BCM2")]
        [StringLength(255)]
        public string G_M2___BCM2 { get; set; }

        [Column("G/M2 - BCM3")]
        [StringLength(255)]
        public string G_M2___BCM3 { get; set; }

        [Column("Velocidad de Secado  -  m/min")]
        [StringLength(255)]
        public string Velocidad_de_Secado_____m_min { get; set; }

        [Column("Productos Impresos")]
        [StringLength(255)]
        public string Productos_Impresos { get; set; }

        [Key]
        public int idCode { get; set; }

        public  PRO1_Productos PRO1_Productos { get; set; }
    }
}
