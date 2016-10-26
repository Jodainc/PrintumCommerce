namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_EPP
    {
        [Key]
        public int nO { get; set; }

        [StringLength(255)]
        public string pOP { get; set; }

        [StringLength(255)]
        public string nOMBREhS { get; set; }

        [StringLength(255)]
        public string tPROTECCCION { get; set; }

        [Column(TypeName = "ntext")]
        public string dETALLEePP { get; set; }

        [Column(TypeName = "ntext")]
        public string iNFOa { get; set; }

        [StringLength(255)]
        public string nORMAT { get; set; }

        [Column(TypeName = "ntext")]
        public string uSO { get; set; }

        [StringLength(255)]
        public string cUIDADOSE { get; set; }

        [Column(TypeName = "ntext")]
        public string cONxrEMPLA { get; set; }

        [StringLength(255)]
        public string aLMACENAMIENTO { get; set; }

        [StringLength(255)]
        public string lIMPIEZA { get; set; }

        [Column(TypeName = "ntext")]
        public string oBLIGApARA { get; set; }

        public int? rEVISION { get; set; }

        [Column(TypeName = "ntext")]
        public string IEPP { get; set; }
    }
}
