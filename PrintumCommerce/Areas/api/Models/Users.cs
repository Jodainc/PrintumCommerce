namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string UserPhone { get; set; }

        [Required]
        [StringLength(60)]
        public string UserAddress { get; set; }

        public string UserPhoto { get; set; }

        public int DepartmentId { get; set; }

        public int CityId { get; set; }

        public int CompanyId { get; set; }

        public  Cities Cities { get; set; }

        public  Companies Companies { get; set; }

        public  DepartmentModels DepartmentModels { get; set; }
    }
}
