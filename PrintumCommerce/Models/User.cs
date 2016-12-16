using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(256, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Email")]
        [Index ("User_UserName_Index", IsUnique = true)]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(60, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Nombres Usuario")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(60, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Apellidos Usuario")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(20, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = "Telefono Usuario")]
        [DataType(DataType.PhoneNumber)]
        public string UserPhone { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(60, ErrorMessage = "El campo {0} es muy largo, maximo caracter {1}")]
        [Display(Name = " Direccion Usuario")]
        public string UserAddress { get; set; }

        [Display(Name = "Foto Empleado")]
        [DataType(DataType.ImageUrl)]
        public string UserPhoto { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        [Display(Name = "Nit")]
        public int nit_Number { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        [Display(Name = "Activo?")]
        public int troll { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        [Display(Name = "Cedula")]
        public int cedula { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        [Display (Name ="Departamento")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        [Display(Name = "Ciudad")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Seleccione un {0}")]
        [Display(Name = "Compañia")]
        public int CompanyId { get; set; }

        [NotMapped]
        public HttpPostedFileBase UserPhotoFile { get; set; }

        [Display(Name = "Usuario")]
        public string Fullname { get {return string.Format("{0},{1}",FirstName,LastName); } }

        public virtual DepartmentModel DepartmentModel { set; get; }

        public virtual City City { set; get; }
        public virtual Company Company { set; get; }
    }
}