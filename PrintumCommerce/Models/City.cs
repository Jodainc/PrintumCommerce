using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(60, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Ciudad")]
        public string CitiesName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int DepartmentId { get; set; }
        public virtual DepartmentModel Department { get; set; }
    }
}