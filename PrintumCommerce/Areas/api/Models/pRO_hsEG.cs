namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pRO_hsEG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pRO_hsEG()
        {
            pRO_hsEG_ePP = new HashSet<pRO_hsEG_ePP>();
            pRO_hsEG_oTRAiNFO = new HashSet<pRO_hsEG_oTRAiNFO>();
        }

        [Key]
        [StringLength(255)]
        public string Codigo { get; set; }

        [Column("1nOMBRE")]
        [StringLength(255)]
        public string C1nOMBRE { get; set; }

        [Column("1sINONIMOS", TypeName = "ntext")]
        public string C1sINONIMOS { get; set; }

        [Column("1fXqUIMICA")]
        [StringLength(255)]
        public string C1fXqUIMICA { get; set; }

        [Column("1nOUN")]
        public int? C1nOUN { get; set; }

        [Column("1iDpROVEE")]
        public double? C1iDpROVEE { get; set; }

        [Column("3rIESTOsALUD", TypeName = "ntext")]
        public string C3rIESTOsALUD { get; set; }

        [Column("3iNHALACION", TypeName = "ntext")]
        public string C3iNHALACION { get; set; }

        [Column("3iNGESTION", TypeName = "ntext")]
        public string C3iNGESTION { get; set; }

        [Column("3cONTACpIEL", TypeName = "ntext")]
        public string C3cONTACpIEL { get; set; }

        [Column("3cONTACoJOS", TypeName = "ntext")]
        public string C3cONTACoJOS { get; set; }

        [Column("4iNHALACION", TypeName = "ntext")]
        public string C4iNHALACION { get; set; }

        [Column("4iNGESTION", TypeName = "ntext")]
        public string C4iNGESTION { get; set; }

        [Column("4cONTACpIEL", TypeName = "ntext")]
        public string C4cONTACpIEL { get; set; }

        [Column("4cONTACoJOS", TypeName = "ntext")]
        public string C4cONTACoJOS { get; set; }

        [Column("5piNFLAMACION")]
        [StringLength(255)]
        public string C5piNFLAMACION { get; set; }

        [Column("5tEMaUTOiGNICION")]
        [StringLength(255)]
        public string C5tEMaUTOiGNICION { get; set; }

        [Column("5lIMITiNFLAMA")]
        [StringLength(255)]
        public string C5lIMITiNFLAMA { get; set; }

        [Column("5pELIiNCENeXPLO")]
        [StringLength(255)]
        public string C5pELIiNCENeXPLO { get; set; }

        [Column("5mEDIeXTINCION", TypeName = "ntext")]
        public string C5mEDIeXTINCION { get; set; }

        [Column("5pROcOMBUSTION")]
        [StringLength(255)]
        public string C5pROcOMBUSTION { get; set; }

        [Column("5pRECAUCIONES", TypeName = "ntext")]
        public string C5pRECAUCIONES { get; set; }

        [Column("5iNTRUCcONTRAfIRE", TypeName = "ntext")]
        public string C5iNTRUCcONTRAfIRE { get; set; }

        [Column("6mEDIvERDITO", TypeName = "ntext")]
        public string C6mEDIvERDITO { get; set; }

        [Column("7mANEJO", TypeName = "ntext")]
        public string C7mANEJO { get; set; }

        [Column("7aLMACENAMIENTO", TypeName = "ntext")]
        public string C7aLMACENAMIENTO { get; set; }

        [Column("8cONTROLiNG", TypeName = "ntext")]
        public string C8cONTROLiNG { get; set; }

        [Column("9aPARIENCIA")]
        [StringLength(255)]
        public string C9aPARIENCIA { get; set; }

        [Column("9vALOR")]
        [StringLength(255)]
        public string C9vALOR { get; set; }

        [Column("9eSTADOfISICO")]
        [StringLength(255)]
        public string C9eSTADOfISICO { get; set; }

        [Column("9gRAVEDAD")]
        [StringLength(255)]
        public string C9gRAVEDAD { get; set; }

        [Column("9pUNTOeBULLI")]
        [StringLength(255)]
        public string C9pUNTOeBULLI { get; set; }

        [Column("9pUNTOfUSION")]
        [StringLength(255)]
        public string C9pUNTOfUSION { get; set; }

        [Column("9dENSIDAD")]
        [StringLength(255)]
        public string C9dENSIDAD { get; set; }

        [Column("9vISCOSIDAD")]
        [StringLength(255)]
        public string C9vISCOSIDAD { get; set; }

        [Column("9pH")]
        [StringLength(255)]
        public string C9pH { get; set; }

        [Column("9sOLUBILIDAD")]
        [StringLength(255)]
        public string C9sOLUBILIDAD { get; set; }

        [Column("10eSTABILIquIMICA", TypeName = "ntext")]
        public string C10eSTABILIquIMICA { get; set; }

        [Column("10aeVITAR", TypeName = "ntext")]
        public string C10aeVITAR { get; set; }

        [Column("10iNCOMPATIBILIDAD", TypeName = "ntext")]
        public string C10iNCOMPATIBILIDAD { get; set; }

        [Column("10pRPpELIxdESCOM", TypeName = "ntext")]
        public string C10pRPpELIxdESCOM { get; set; }

        [Column("10pOLIMERIZACION", TypeName = "ntext")]
        public string C10pOLIMERIZACION { get; set; }

        [Column("11iNFOtOXICOLOGICA", TypeName = "ntext")]
        public string C11iNFOtOXICOLOGICA { get; set; }

        [Column("12iNFOeCOLOGICA", TypeName = "ntext")]
        public string C12iNFOeCOLOGICA { get; set; }

        [Column("13dISPOSICION", TypeName = "ntext")]
        public string C13dISPOSICION { get; set; }

        [Column("14iNFOtRANSPORTE", TypeName = "ntext")]
        public string C14iNFOtRANSPORTE { get; set; }

        [Column("15iNFOrEGLAMENTA", TypeName = "ntext")]
        public string C15iNFOrEGLAMENTA { get; set; }

        [Column("16nFPA", TypeName = "ntext")]
        public string C16nFPA { get; set; }

        [Column("16pICT1", TypeName = "ntext")]
        public string C16pICT1 { get; set; }

        [Column("16pICT2", TypeName = "ntext")]
        public string C16pICT2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<pRO_hsEG_ePP> pRO_hsEG_ePP { get; set; }

        public  Productos Productos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<pRO_hsEG_oTRAiNFO> pRO_hsEG_oTRAiNFO { get; set; }
    }
}
