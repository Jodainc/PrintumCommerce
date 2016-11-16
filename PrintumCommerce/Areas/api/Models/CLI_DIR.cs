namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLI_DIR
    {
        public double ID { get; set; }

        [StringLength(255)]
        public string Ciudad { get; set; }

        [StringLength(255)]
        public string Sector { get; set; }

        [StringLength(255)]
        public string Barrio { get; set; }

        [StringLength(255)]
        public string Zona { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [Column("1")]
        [StringLength(255)]
        public string C1 { get; set; }

        [Column("2")]
        [StringLength(255)]
        public string C2 { get; set; }

        [Column("3")]
        [StringLength(255)]
        public string C3 { get; set; }

        [Column("4")]
        [StringLength(255)]
        public string C4 { get; set; }

        [Column("5")]
        [StringLength(255)]
        public string C5 { get; set; }

        [Column("6")]
        [StringLength(255)]
        public string C6 { get; set; }

        [Column("7")]
        [StringLength(255)]
        public string C7 { get; set; }

        [Column("8")]
        [StringLength(255)]
        public string C8 { get; set; }

        [Column("9")]
        [StringLength(255)]
        public string C9 { get; set; }

        [Column("10")]
        [StringLength(255)]
        public string C10 { get; set; }
    }
}
