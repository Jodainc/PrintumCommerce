using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models
{
    public class DBPrintumContext: DbContext
    {
        public DBPrintumContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PrintumCommerce.Models.DepartmentModel> DepartmentModels { get; set; }

        public System.Data.Entity.DbSet<PrintumCommerce.Models.City> Cities { get; set; }
    }
}