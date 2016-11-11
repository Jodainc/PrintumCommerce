namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pedidos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedidos()
        {
            Pedidos_Productos = new HashSet<Pedidos_Productos>();
        }

        [Key]
        public int No_Pedido { get; set; }

        public int? nOoC { get; set; }

        public int? tIPO { get; set; }

        public double? Solicitado_Por { get; set; }

        public double? Gestionado_Por { get; set; }

        public DateTime? F_registro { get; set; }

        public DateTime? H_registro { get; set; }

        public DateTime? F_rECIBIDO { get; set; }

        public DateTime? H_rECIBIDO { get; set; }

        public DateTime? F_pRUEBA { get; set; }

        public double? ID_Cliente { get; set; }

        [StringLength(255)]
        public string Prioridad { get; set; }

        public DateTime? Fecha_Despacho { get; set; }

        [Column(TypeName = "ntext")]
        public string Notas { get; set; }

        public int? lINEAn { get; set; }

        public double? aPROBO_D { get; set; }

        public double? aPROBO_L { get; set; }

        [StringLength(255)]
        public string eNVIARCO { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        public DateTime? fECHA_eNTREGA { get; set; }

        public int? jORNADA_eNTREGA { get; set; }

        [StringLength(255)]
        public string eSTADO_mUESTRA { get; set; }

        [Column(TypeName = "ntext")]
        public string cONCLUSION { get; set; }

        [StringLength(255)]
        public string fACTURA { get; set; }

        public double? kgCONSUMO { get; set; }

        public double? pCONSUMO { get; set; }

        [StringLength(255)]
        public string mERCADOO { get; set; }

        public int? fACTURAR { get; set; }

        public int? vLRfAC { get; set; }

        public int? nOrEMI { get; set; }

        [StringLength(255)]
        public string nOfAC { get; set; }

        public DateTime? fECHA_eNTREGAcLI { get; set; }

        public int? CODAC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidos_Productos> Pedidos_Productos { get; set; }
    }
}
