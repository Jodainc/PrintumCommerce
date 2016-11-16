namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRO_OC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRO_OC()
        {
            PRO_OC_D = new HashSet<PRO_OC_D>();
            PRO_OC_NC = new HashSet<PRO_OC_NC>();
        }

        [Key]
        public double NO_OC { get; set; }

        public DateTime? FECHA { get; set; }

        public double? ID_PROVEEDOR { get; set; }

        public int? RECIBIDO { get; set; }

        [StringLength(255)]
        public string ESTADO_OC { get; set; }

        public bool INGRESADA_WO { get; set; }

        [Column(TypeName = "ntext")]
        public string SOPORTE { get; set; }

        public double? sOLITICADApOR { get; set; }

        [Column(TypeName = "ntext")]
        public string oBS { get; set; }

        public DateTime? FECHA_ENTREGA { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSnO_CONFORME { get; set; }

        public double? cLI { get; set; }

        public int? tIPOnOcoNFORME { get; set; }

        public int? tIPOoc { get; set; }

        public int? sOLUCIONO_NC { get; set; }

        public DateTime? FECHA_S_NC { get; set; }

        public DateTime? FRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PRO_OC_D> PRO_OC_D { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PRO_OC_NC> PRO_OC_NC { get; set; }
    }
}
