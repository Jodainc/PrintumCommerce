namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_EmpleadosPRTN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH_EmpleadosPRTN()
        {
            RH_CEL = new HashSet<RH_CEL>();
            RH_cESANTIAS = new HashSet<RH_cESANTIAS>();
            RH_Conformacion = new HashSet<RH_Conformacion>();
            RH_CONTRA_Aumentos_SB = new HashSet<RH_CONTRA_Aumentos_SB>();
            RH_Contratos = new HashSet<RH_Contratos>();
            RH_Dotacion = new HashSet<RH_Dotacion>();
            RH_EPP = new HashSet<RH_EPP>();
            RH_Experiencia = new HashSet<RH_Experiencia>();
            RH_MEMORANDOS = new HashSet<RH_MEMORANDOS>();
            RH_PC = new HashSet<RH_PC>();
            RH_PERMISOS = new HashSet<RH_PERMISOS>();
            RH_POP = new HashSet<RH_POP>();
            RH_Ref_FAM = new HashSet<RH_Ref_FAM>();
            RH_Ref_PER = new HashSet<RH_Ref_PER>();
            RH_tOMAiNDICADORES = new HashSet<RH_tOMAiNDICADORES>();
            RH_tOOLS = new HashSet<RH_tOOLS>();
            RH_Vacaciones = new HashSet<RH_Vacaciones>();
            RH_Viaticos = new HashSet<RH_Viaticos>();
            User = new HashSet<User>();
        }

        [Column("Fecha de Inicio")]
        public DateTime? Fecha_de_Inicio { get; set; }

        [Column("Fecha fin contrato")]
        public DateTime? Fecha_fin_contrato { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [Column("Tipo de Identificacion")]
        [StringLength(255)]
        public string Tipo_de_Identificacion { get; set; }

        public double Id { get; set; }

        public int? ID_CA { get; set; }

        [StringLength(255)]
        public string De { get; set; }

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

        [Column("Fecha de Nacimiento")]
        public DateTime? Fecha_de_Nacimiento { get; set; }

        [StringLength(255)]
        public string Genero { get; set; }

        [Column("Estado Civil")]
        [StringLength(255)]
        public string Estado_Civil { get; set; }

        [Column("No Hijos")]
        public int? No_Hijos { get; set; }

        [Column("Telefono fijo")]
        [StringLength(255)]
        public string Telefono_fijo { get; set; }

        [Column("Telefono Celular")]
        [StringLength(255)]
        public string Telefono_Celular { get; set; }

        [StringLength(255)]
        public string Mail { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [StringLength(255)]
        public string Barrio { get; set; }

        [StringLength(255)]
        public string Departamento { get; set; }

        [StringLength(255)]
        public string Cargo { get; set; }

        [StringLength(255)]
        public string Contrato { get; set; }

        [Column("Salario Basico")]
        public double? Salario_Basico { get; set; }

        public double? Variable { get; set; }

        [StringLength(255)]
        public string Entidad { get; set; }

        [Column("Tipo Cuenta")]
        [StringLength(255)]
        public string Tipo_Cuenta { get; set; }

        [Column("No Cuenta")]
        [StringLength(255)]
        public string No_Cuenta { get; set; }

        [StringLength(255)]
        public string EPS { get; set; }

        [StringLength(255)]
        public string APR { get; set; }

        [Column("Caja Compensacion")]
        [StringLength(255)]
        public string Caja_Compensacion { get; set; }

        [Column(TypeName = "ntext")]
        public string Foto { get; set; }

        [Column("Antecedentes Medicos", TypeName = "ntext")]
        public string Antecedentes_Medicos { get; set; }

        [Column(TypeName = "ntext")]
        public string Accidentes { get; set; }

        [Column(TypeName = "ntext")]
        public string Discapacidad { get; set; }

        [Column(TypeName = "ntext")]
        public string Perfil { get; set; }

        [Column(TypeName = "ntext")]
        public string Habilidades { get; set; }

        [Column(TypeName = "ntext")]
        public string Docs { get; set; }

        [StringLength(255)]
        public string Pantalon { get; set; }

        [StringLength(255)]
        public string Camisa { get; set; }

        [StringLength(255)]
        public string Camiseta { get; set; }

        [StringLength(255)]
        public string Zapatos { get; set; }

        [StringLength(255)]
        public string Bata { get; set; }

        [StringLength(255)]
        public string Overol { get; set; }

        public int? MF { get; set; }

        [StringLength(255)]
        public string CE_N { get; set; }

        [StringLength(255)]
        public string CE_T { get; set; }

        [StringLength(255)]
        public string CE_CEL { get; set; }

        [StringLength(255)]
        public string CE_P { get; set; }

        [StringLength(255)]
        public string RH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_CEL> RH_CEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_cESANTIAS> RH_cESANTIAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Conformacion> RH_Conformacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_CONTRA_Aumentos_SB> RH_CONTRA_Aumentos_SB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Contratos> RH_Contratos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Dotacion> RH_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_EPP> RH_EPP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Experiencia> RH_Experiencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MEMORANDOS> RH_MEMORANDOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_PC> RH_PC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_PERMISOS> RH_PERMISOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_POP> RH_POP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Ref_FAM> RH_Ref_FAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Ref_PER> RH_Ref_PER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_tOMAiNDICADORES> RH_tOMAiNDICADORES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_tOOLS> RH_tOOLS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Vacaciones> RH_Vacaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Viaticos> RH_Viaticos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}
