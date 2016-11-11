namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            C2016vENTAS = new HashSet<C2016vENTAS>();
            cLI_lINExvENDOR = new HashSet<cLI_lINExvENDOR>();
            CTZ = new HashSet<CTZ>();
            pRESUPUESTO__ = new HashSet<pRESUPUESTO__>();
            pRESUPUESTO_C = new HashSet<pRESUPUESTO_C>();
            Registro = new HashSet<Registro>();
            uSER_pERMIS = new HashSet<uSER_pERMIS>();
        }

        public double ID { get; set; }

        [StringLength(255)]
        public string sIGLAS { get; set; }

        [Column("User")]
        [StringLength(255)]
        public string User1 { get; set; }

        [Column("Nombre 1")]
        [StringLength(255)]
        public string Nombre_1 { get; set; }

        [Column("Nombre 2")]
        [StringLength(255)]
        public string Nombre_2 { get; set; }

        [Column("Apellido 1")]
        [StringLength(255)]
        public string Apellido_1 { get; set; }

        [Column("Apellido 2")]
        [StringLength(255)]
        public string Apellido_2 { get; set; }

        [StringLength(255)]
        public string Ciudad { get; set; }

        [StringLength(255)]
        public string eSTADO { get; set; }

        public double? IDHV { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [StringLength(255)]
        public string Departamento { get; set; }

        [StringLength(255)]
        public string Mail { get; set; }

        public int? Clase { get; set; }

        [Column(TypeName = "ntext")]
        public string pERMIS { get; set; }

        public int? cARGOus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C2016vENTAS> C2016vENTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cLI_lINExvENDOR> cLI_lINExvENDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTZ> CTZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pRESUPUESTO__> pRESUPUESTO__ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pRESUPUESTO_C> pRESUPUESTO_C { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registro { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uSER_pERMIS> uSER_pERMIS { get; set; }
    }
}
