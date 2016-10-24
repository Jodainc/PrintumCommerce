using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required  (ErrorMessage ="El campo {0} es requerido")]
        [MaxLength(60,ErrorMessage ="El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name ="Departamento")]
        public string DepartmentName { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}