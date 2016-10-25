using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(60, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Compañia")]
        [Index("Company_CompanyName_Index", IsUnique = true)]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(20, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Compañia Telefono")]
        [DataType(DataType.PhoneNumber)]
        public string CompanyPhone { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(60, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Compañia Direccion")]
        public string CompanyAddress { get; set; }

        [Display(Name = "Compañia Imagen")]
        [DataType(DataType.ImageUrl)]
        public string CompanyPhoto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        public int CityId { get; set; }

        [NotMapped]
        public HttpPostedFileBase CompanyPhotoFile { get; set; }

        public virtual DepartmentModel DepartmentModel { set; get; }

        public virtual City City { set; get; }

        public virtual ICollection<User> Users { get; set; }


    }
}