namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            C2016vENTAS = new HashSet<C2016vENTAS>();
            cLI_pRO_pROPIEDADES = new HashSet<cLI_pRO_pROPIEDADES>();
            vENTAS_rECIBOSdEcAJA = new HashSet<vENTAS_rECIBOSdEcAJA>();
        }

        public double ID { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [Column("TIPO ID")]
        [StringLength(255)]
        public string TIPO_ID { get; set; }

        [StringLength(255)]
        public string RepresentanteLegal { get; set; }

        public double? IDRP { get; set; }

        public int? Ciudad { get; set; }

        [StringLength(255)]
        public string Sector { get; set; }

        [StringLength(255)]
        public string Barrio { get; set; }

        [StringLength(255)]
        public string Zona { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [StringLength(255)]
        public string Telefono { get; set; }

        [StringLength(255)]
        public string Telefono1 { get; set; }

        [StringLength(255)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string Celular { get; set; }

        public double? IDVENDEDOR { get; set; }

        public double? Plazo { get; set; }

        public double? Cupo { get; set; }

        [Column(TypeName = "ntext")]
        public string RUT { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [StringLength(255)]
        public string Mail { get; set; }

        [StringLength(255)]
        public string Contacto { get; set; }

        [StringLength(255)]
        public string WebSite { get; set; }

        public DateTime? Fecha_Creacion { get; set; }

        public int? Creado_Por { get; set; }

        [StringLength(255)]
        public string WO { get; set; }

        public int? cONSUMO { get; set; }

        public double? rEF_fIN { get; set; }

        public double? rEF_cOM { get; set; }

        public double? eSPECIAL { get; set; }

        [StringLength(255)]
        public string h_lUN_vIE { get; set; }

        [StringLength(255)]
        public string h_sAB { get; set; }

        [StringLength(255)]
        public string dIAS_cOBRO { get; set; }

        [StringLength(255)]
        public string nOTAS_cOBRO { get; set; }

        public DateTime? F_INI_aCT { get; set; }

        public double? PlazoP { get; set; }

        public double? CupoP { get; set; }

        public double? rEF_cOM1 { get; set; }

        public double? rEF_cOM2 { get; set; }

        public double? rEF_cOM3 { get; set; }

        public double? rEF_cOM4 { get; set; }

        public double? lEADtIME { get; set; }

        public double? sTOCKmAX { get; set; }

        public int? HC { get; set; }

        public int? CCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C2016vENTAS> C2016vENTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cLI_pRO_pROPIEDADES> cLI_pRO_pROPIEDADES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vENTAS_rECIBOSdEcAJA> vENTAS_rECIBOSdEcAJA { get; set; }
    }
}
