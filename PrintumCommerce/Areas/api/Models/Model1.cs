namespace PrintumCommerce.Areas.api.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }
        public static Model1 Create()
        {
            return new Model1();
        }
        public virtual DbSet<Pro_Certificados> Pro_Certificados { get; set; }
        /*
        public virtual DbSet<Users> Users { get; set; }
        */
        public virtual DbSet<VT_TRM> VT_TRM { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<PrintumCommerce.Areas.api.Models.User> Users { get; set; }
    }
}
