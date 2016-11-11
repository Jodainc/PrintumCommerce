namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rRHH_pRESTAMOS_pAGOS
    {
        public int? nO_pRESTAMO { get; set; }

        [StringLength(255)]
        public string pAGO { get; set; }

        public DateTime? fECHA { get; set; }

        public double? vALOR_pAGO { get; set; }

        [StringLength(255)]
        public string cANCELADO { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual rRHH_pRESTAMOS rRHH_pRESTAMOS { get; set; }
    }
}
