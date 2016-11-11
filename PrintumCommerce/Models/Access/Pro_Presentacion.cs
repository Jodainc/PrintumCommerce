namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Presentacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pro_Presentacion()
        {
            C2016vENTAS = new HashSet<C2016vENTAS>();
            CTZ_D = new HashSet<CTZ_D>();
            iMPORTACIONES_D = new HashSet<iMPORTACIONES_D>();
            Pedidos_Productos = new HashSet<Pedidos_Productos>();
            Pro_Existencias = new HashSet<Pro_Existencias>();
            PRO_OC_D = new HashSet<PRO_OC_D>();
            pRODUCTOS_cLASS = new HashSet<pRODUCTOS_cLASS>();
            Proveedores_Productos = new HashSet<Proveedores_Productos>();
        }

        [StringLength(255)]
        public string CODIGO { get; set; }

        [Key]
        [StringLength(255)]
        public string Cod_Producto { get; set; }

        [StringLength(255)]
        public string COD_PROVEEDOR { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string D1 { get; set; }

        [StringLength(255)]
        public string D2 { get; set; }

        [Column("Presentacion/Kg")]
        public double? Presentacion_Kg { get; set; }

        [Column("Unidad/Medida")]
        [StringLength(255)]
        public string Unidad_Medida { get; set; }

        [Column("Precio KG")]
        public double? Precio_KG { get; set; }

        public double? cOSTOpRO { get; set; }

        public double? cOSiMP { get; set; }

        public int? Maxi { get; set; }

        public int? Mini { get; set; }

        public double? Presentacion_Pro { get; set; }

        [Column("Unidad/Medida_Pro")]
        [StringLength(255)]
        public string Unidad_Medida_Pro { get; set; }

        [Column("Presentacion/Kg_pri")]
        public double? Presentacion_Kg_pri { get; set; }

        public int? cLSiNV { get; set; }

        [StringLength(1)]
        public string R_NFPA1 { get; set; }

        [StringLength(1)]
        public string R_NFPA2 { get; set; }

        [StringLength(1)]
        public string R_NFPA3 { get; set; }

        [StringLength(1)]
        public string R_NFPA4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C2016vENTAS> C2016vENTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTZ_D> CTZ_D { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<iMPORTACIONES_D> iMPORTACIONES_D { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidos_Productos> Pedidos_Productos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pro_Existencias> Pro_Existencias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO_OC_D> PRO_OC_D { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual Pro_Tiempo Pro_Tiempo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pRODUCTOS_cLASS> pRODUCTOS_cLASS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedores_Productos> Proveedores_Productos { get; set; }
    }
}
