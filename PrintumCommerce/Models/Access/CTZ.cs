namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTZ")]
    public partial class CTZ
    {
        [Key]
        public int nO_CTZ { get; set; }

        public DateTime? fECHA { get; set; }

        public double? cLIENTE { get; set; }

        public double? vENDOR { get; set; }

        [Column(TypeName = "ntext")]
        public string tEXXTO { get; set; }

        public int? Tcd { get; set; }

        public int? fP { get; set; }

        public int? tEP { get; set; }

        public int? vOF { get; set; }

        public virtual User User { get; set; }
    }
}
