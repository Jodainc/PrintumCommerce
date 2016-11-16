namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Companies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Companies()
        {
            Users = new HashSet<Users>();
        }

        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(60)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(20)]
        public string CompanyPhone { get; set; }

        [Required]
        [StringLength(60)]
        public string CompanyAddress { get; set; }

        public string CompanyPhoto { get; set; }

        public int DepartmentId { get; set; }

        public int CityId { get; set; }

        public  Cities Cities { get; set; }

        public  DepartmentModels DepartmentModels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<Users> Users { get; set; }
    }
}
