using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Index("City_CitiesName_Index   ",2, IsUnique =true )]
        public string CitiesName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1,double.MaxValue,ErrorMessage ="Seleccione un {0}")]
        [Index("City_CitiesName_Index   ", 1, IsUnique = true)]
        public int DepartmentId { get; set; }
        public virtual DepartmentModel Department { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}