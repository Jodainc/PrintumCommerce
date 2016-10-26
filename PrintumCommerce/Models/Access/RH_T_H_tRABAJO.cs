namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_T_H_tRABAJO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cOD { get; set; }

        [StringLength(255)]
        public string cARGO { get; set; }
    }
}
