namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            Pro_Certificados = new HashSet<Pro_Certificados>();
            Pro_Estandar = new HashSet<Pro_Estandar>();
            Pro_Formula = new HashSet<Pro_Formula>();
            Pro_Presentacion = new HashSet<Pro_Presentacion>();
            PRO1_Productos = new HashSet<PRO1_Productos>();
        }

        public double? Grupo { get; set; }

        [Key]
        [StringLength(255)]
        public string Código { get; set; }

        [StringLength(255)]
        public string Descripción { get; set; }

        [Column(TypeName = "ntext")]
        public string sOPORTE { get; set; }

        public int? cLSiNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Certificados> Pro_Certificados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Estandar> Pro_Estandar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Formula> Pro_Formula { get; set; }

        public virtual Pro_Grupos Pro_Grupos { get; set; }

        public virtual pRO_hsEG pRO_hsEG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Presentacion> Pro_Presentacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO1_Productos> PRO1_Productos { get; set; }
    }
}
