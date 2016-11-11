namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LG_rEMISION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LG_rEMISION()
        {
            LG_rEMISION_D = new HashSet<LG_rEMISION_D>();
        }

        [Key]
        public double NO_rEMI { get; set; }

        public DateTime? FECHA { get; set; }

        public DateTime? fECHA_vENCE { get; set; }

        public double? ID_cLIENTE { get; set; }

        [Column(TypeName = "ntext")]
        public string oBSERVACIONES { get; set; }

        [StringLength(255)]
        public string fACTURADA { get; set; }

        [StringLength(255)]
        public string nO_fAC { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LG_rEMISION_D> LG_rEMISION_D { get; set; }
    }
}
