namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_tOMAiNDICADORES
    {
        [Key]
        [StringLength(255)]
        public string cOD { get; set; }

        public double? ID_E { get; set; }

        public int? aÑO { get; set; }

        public int? mES { get; set; }

        [Column(TypeName = "ntext")]
        public string cOMPRIMISOS { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [StringLength(255)]
        public string nOcONTRATO { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
