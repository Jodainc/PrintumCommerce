namespace PrintumCommerce.Models.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pro_Estandar
    {
        [StringLength(255)]
        public string CODIGO { get; set; }

        public int? COD_PRUEBA { get; set; }

        [StringLength(255)]
        public string R_PRUEBA { get; set; }

        [Key]
        public int idCode { get; set; }

        public virtual Pro_pRUEBAS Pro_pRUEBAS { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
