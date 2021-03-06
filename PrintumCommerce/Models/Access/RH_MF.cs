namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_MF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH_MF()
        {
            RH_CONTRA_Aumentos_SB = new HashSet<RH_CONTRA_Aumentos_SB>();
            RH_Contratos = new HashSet<RH_Contratos>();
            RH_MF_DF = new HashSet<RH_MF_DF>();
            RH_MF_EER = new HashSet<RH_MF_EER>();
            RH_MF_HE_FC = new HashSet<RH_MF_HE_FC>();
            RH_MF_HE_HE = new HashSet<RH_MF_HE_HE>();
            RH_MF_HE_IM = new HashSet<RH_MF_HE_IM>();
            RH_MF_IND = new HashSet<RH_MF_IND>();
            RH_MF_PP = new HashSet<RH_MF_PP>();
            RH_MF_RC_EX = new HashSet<RH_MF_RC_EX>();
            RH_MF_RC_FA = new HashSet<RH_MF_RC_FA>();
            RH_MF_RC = new HashSet<RH_MF_RC>();
            RH_MF_RC_RH = new HashSet<RH_MF_RC_RH>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nO_MF { get; set; }

        public int? cARGO { get; set; }

        [StringLength(255)]
        public string jEFEiNMEDIATO { get; set; }

        public int? nIVELcARGO { get; set; }

        [StringLength(255)]
        public string tIPO { get; set; }

        public int? dEPARTAMENTO { get; set; }

        [Column(TypeName = "ntext")]
        public string rELACION { get; set; }

        public int? pERSONASacARGO { get; set; }

        [StringLength(255)]
        public string eSTADOcIVIL { get; set; }

        [StringLength(255)]
        public string aREA { get; set; }

        [StringLength(255)]
        public string HE_L_V { get; set; }

        [StringLength(255)]
        public string HS_L_V { get; set; }

        [StringLength(255)]
        public string HE_S { get; set; }

        [StringLength(255)]
        public string HS_S { get; set; }

        [StringLength(255)]
        public string tIPOcONTRATO { get; set; }

        [StringLength(255)]
        public string sALARIO { get; set; }

        [StringLength(255)]
        public string bONIFICACION { get; set; }

        [StringLength(255)]
        public string aUXILIOS { get; set; }

        [StringLength(255)]
        public string pRESTACIONES { get; set; }

        [StringLength(255)]
        public string cONFIDENCIALIDAD { get; set; }

        [StringLength(255)]
        public string gENERO { get; set; }

        [Column(TypeName = "ntext")]
        public string hABILIDADESgENERALES { get; set; }

        [StringLength(255)]
        public string bIENESyhERRAMIENTAS { get; set; }

        [Column(TypeName = "ntext")]
        public string D1 { get; set; }

        [StringLength(255)]
        public string iNFOcONFIDENCIAL { get; set; }

        [Column(TypeName = "ntext")]
        public string D2 { get; set; }

        [StringLength(255)]
        public string rEGISTROiNFORMES { get; set; }

        [StringLength(255)]
        public string dINEROSovALORES { get; set; }

        [StringLength(255)]
        public string pRESUPUESTO { get; set; }

        [StringLength(255)]
        public string cLIENTEiNTERNO { get; set; }

        [StringLength(255)]
        public string cLIENTEeXTRERNO { get; set; }

        [Column(TypeName = "ntext")]
        public string hERRAMIENTAStRABAJO { get; set; }

        [Column(TypeName = "ntext")]
        public string cONDICIONaMBIELTAL { get; set; }

        public int? eDADmIN { get; set; }

        public int? eDADmAX { get; set; }

        [StringLength(255)]
        public string pROCEDENCIAgEO { get; set; }

        [StringLength(255)]
        public string pASE { get; set; }

        [StringLength(255)]
        public string cATEGORIA_pASE { get; set; }

        [StringLength(255)]
        public string vEHICULO { get; set; }

        [StringLength(255)]
        public string tIPO_vEHICULO { get; set; }

        [StringLength(255)]
        public string iDIOMAS { get; set; }

        [Column(TypeName = "ntext")]
        public string vALORES { get; set; }

        [Column(TypeName = "ntext")]
        public string hABILIDADESfISICAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_CONTRA_Aumentos_SB> RH_CONTRA_Aumentos_SB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Contratos> RH_Contratos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_DF> RH_MF_DF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_EER> RH_MF_EER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_HE_FC> RH_MF_HE_FC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_HE_HE> RH_MF_HE_HE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_HE_IM> RH_MF_HE_IM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_IND> RH_MF_IND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_PP> RH_MF_PP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_RC_EX> RH_MF_RC_EX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_RC_FA> RH_MF_RC_FA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_RC> RH_MF_RC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_MF_RC_RH> RH_MF_RC_RH { get; set; }
    }
}
