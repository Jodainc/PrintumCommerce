namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRO1 Productos")]
    public partial class PRO1_Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRO1_Productos()
        {
            PRO2_Cuenta_con = new HashSet<PRO2_Cuenta_con>();
            PRO3_Propiedades_de_Impresión = new HashSet<PRO3_Propiedades_de_Impresión>();
            PRO4_Propiedades_de_Aplicación = new HashSet<PRO4_Propiedades_de_Aplicación>();
            PRO5_Referencias_Existentes = new HashSet<PRO5_Referencias_Existentes>();
            PRO6_Recomendaciones_de_Procesamiento = new HashSet<PRO6_Recomendaciones_de_Procesamiento>();
            PRO7_Limpieza = new HashSet<PRO7_Limpieza>();
            PRO8_Almacenamiento = new HashSet<PRO8_Almacenamiento>();
            PRO9_Instrucciones_de_Seguridad = new HashSet<PRO9_Instrucciones_de_Seguridad>();
            PRO91_Unidad_de_Empaque = new HashSet<PRO91_Unidad_de_Empaque>();
            PRO92_lAP_Propiedades_medicion_mm = new HashSet<PRO92_lAP_Propiedades_medicion_mm>();
            PRO93_lAP_Propiedades_Electricas = new HashSet<PRO93_lAP_Propiedades_Electricas>();
            PRO94_Recomendaciones_de_Uso = new HashSet<PRO94_Recomendaciones_de_Uso>();
            PRO95_Ventajas = new HashSet<PRO95_Ventajas>();
            PRO96_Garantia = new HashSet<PRO96_Garantia>();
            PRO97_ServiTec = new HashSet<PRO97_ServiTec>();
            PRO98_Propiedades = new HashSet<PRO98_Propiedades>();
            PRO99_Pedido = new HashSet<PRO99_Pedido>();
        }

        public double? Cod_Linea { get; set; }

        public double? Cod_Grupo { get; set; }

        [StringLength(255)]
        public string COD_PRODUCTO { get; set; }

        [Key]
        [StringLength(255)]
        public string Cod_pro { get; set; }

        [StringLength(255)]
        public string Producto { get; set; }

        [Column(TypeName = "ntext")]
        public string Descripcion { get; set; }

        [Column(TypeName = "ntext")]
        public string Imagen { get; set; }

        public virtual Productos Productos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO2_Cuenta_con> PRO2_Cuenta_con { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO3_Propiedades_de_Impresión> PRO3_Propiedades_de_Impresión { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO4_Propiedades_de_Aplicación> PRO4_Propiedades_de_Aplicación { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO5_Referencias_Existentes> PRO5_Referencias_Existentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO6_Recomendaciones_de_Procesamiento> PRO6_Recomendaciones_de_Procesamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO7_Limpieza> PRO7_Limpieza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO8_Almacenamiento> PRO8_Almacenamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO9_Instrucciones_de_Seguridad> PRO9_Instrucciones_de_Seguridad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO91_Unidad_de_Empaque> PRO91_Unidad_de_Empaque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO92_lAP_Propiedades_medicion_mm> PRO92_lAP_Propiedades_medicion_mm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO93_lAP_Propiedades_Electricas> PRO93_lAP_Propiedades_Electricas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO93_LAP_DIAGRAMA> PRO93_lAP_Propiedades_DIAGRAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO94_Recomendaciones_de_Uso> PRO94_Recomendaciones_de_Uso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO95_Ventajas> PRO95_Ventajas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO96_Garantia> PRO96_Garantia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO97_ServiTec> PRO97_ServiTec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO98_Propiedades> PRO98_Propiedades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO99_Pedido> PRO99_Pedido { get; set; }
    }
}
