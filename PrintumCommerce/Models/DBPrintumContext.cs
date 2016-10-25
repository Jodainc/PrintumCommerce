using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PrintumCommerce.Models
{
    public class DBPrintumContext: DbContext
    {
        public DBPrintumContext():base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<PrintumCommerce.Models.DepartmentModel> DepartmentModels { get; set; }

        public System.Data.Entity.DbSet<PrintumCommerce.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<PrintumCommerce.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<PrintumCommerce.Models.User> Users { get; set; }
    }
}