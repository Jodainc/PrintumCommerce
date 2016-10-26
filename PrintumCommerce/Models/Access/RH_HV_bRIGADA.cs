namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_HV_bRIGADA
    {
        [Key]
        public double ID_E { get; set; }

        public DateTime? fECHAV { get; set; }

        public int? EaCTIVO { get; set; }

        public int? gRUPOp { get; set; }

        public int? P1 { get; set; }

        public int? P2 { get; set; }

        public int? P3 { get; set; }

        public int? P4 { get; set; }

        public int? P5 { get; set; }

        public int? P6 { get; set; }

        public int? P7 { get; set; }

        public int? P8 { get; set; }

        public int? P9 { get; set; }

        public int? P10 { get; set; }

        public int? P11 { get; set; }

        public int? P12 { get; set; }

        public int? P13 { get; set; }

        public int? P14 { get; set; }

        public int? P15 { get; set; }

        [Column(TypeName = "ntext")]
        public string sP { get; set; }
    }
}
