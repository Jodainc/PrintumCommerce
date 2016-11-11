namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FC_Sem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FC_Sem()
        {
            FC_Bancos = new HashSet<FC_Bancos>();
            FC_Proveedores = new HashSet<FC_Proveedores>();
            FC_Creditos = new HashSet<FC_Creditos>();
            FC_Gastos = new HashSet<FC_Gastos>();
        }

        [StringLength(255)]
        public string MES { get; set; }

        [Key]
        [Column("FECHA FC")]
        public DateTime FECHA_FC { get; set; }

        [StringLength(255)]
        public string DIA { get; set; }

        public double? SEMANA { get; set; }

        public short? AÑO { get; set; }

        [StringLength(243)]
        public string COD { get; set; }

        [StringLength(243)]
        public string COD1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FC_Bancos> FC_Bancos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FC_Proveedores> FC_Proveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FC_Creditos> FC_Creditos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FC_Gastos> FC_Gastos { get; set; }
    }
}
