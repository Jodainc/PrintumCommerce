namespace PrintumCommerce.Areas.api.Models
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

        public  Pro_pRUEBAS Pro_pRUEBAS { get; set; }

        public  Productos Productos { get; set; }
    }
}
