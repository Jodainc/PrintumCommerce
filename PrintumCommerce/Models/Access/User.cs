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
            CTZs = new HashSet<CTZ>();
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
        public virtual ICollection<CTZ> CTZs { get; set; }

        public virtual RH_EmpleadosPRTN RH_EmpleadosPRTN { get; set; }
    }
}
