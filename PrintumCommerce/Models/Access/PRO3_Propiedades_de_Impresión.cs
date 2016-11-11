namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO3 Propiedades de Impresión")]
    public partial class PRO3_Propiedades_de_Impresión
    {
        [StringLength(255)]
        public string Cod_PRO { get; set; }

        [Column("En máquina Imprimibilidad")]
        [StringLength(255)]
        public string En_máquina_Imprimibilidad { get; set; }

        [Column("En máquina Secado")]
        [StringLength(255)]
        public string En_máquina_Secado { get; set; }

        [Column("En máquina Limpieza")]
        [StringLength(255)]
        public string En_máquina_Limpieza { get; set; }

        [Column("En Seco Brillo")]
        [StringLength(255)]
        public string En_Seco_Brillo { get; set; }

        [Column("En Seco Resistencia al Roce en Húmedo")]
        [StringLength(255)]
        public string En_Seco_Resistencia_al_Roce_en_Húmedo { get; set; }

        [Column("En Seco Resistencia al Roce en Seco")]
        [StringLength(255)]
        public string En_Seco_Resistencia_al_Roce_en_Seco { get; set; }

        [Column("En Seco Resistencia a Químicos")]
        [StringLength(255)]
        public string En_Seco_Resistencia_a_Químicos { get; set; }

        [Column("En Seco Resistencia a la Luz / Amarillamiento")]
        [StringLength(255)]
        public string En_Seco_Resistencia_a_la_Luz___Amarillamiento { get; set; }

        [Column("En Seco Resistencia al Calor")]
        [StringLength(255)]
        public string En_Seco_Resistencia_al_Calor { get; set; }

        [Column("En Seco Nivelación")]
        [StringLength(255)]
        public string En_Seco_Nivelación { get; set; }

        [Column("Procesamiento Estampado al Calor")]
        [StringLength(255)]
        public string Procesamiento_Estampado_al_Calor { get; set; }

        [Column("Procesamiento Pegabilidad")]
        [StringLength(255)]
        public string Procesamiento_Pegabilidad { get; set; }

        [Column("Procesamiento Transferencia Térmica")]
        [StringLength(255)]
        public string Procesamiento_Transferencia_Térmica { get; set; }

        [Column("Procesamiento Impresión Láser")]
        [StringLength(255)]
        public string Procesamiento_Impresión_Láser { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual PRO1_Productos PRO1_Productos { get; set; }
    }
}
