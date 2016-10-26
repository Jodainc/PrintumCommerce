namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tAUX_cLSiNVENTARIO
    {
        [Key]
        public int CODCLS { get; set; }

        [StringLength(255)]
        public string sIGLAScSL { get; set; }

        [StringLength(255)]
        public string CLASEINV { get; set; }

        [StringLength(255)]
        public string CLASEINV2 { get; set; }
    }
}
