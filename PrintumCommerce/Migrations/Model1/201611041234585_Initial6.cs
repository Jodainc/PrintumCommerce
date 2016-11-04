namespace PrintumCommerce.Migrations.Model1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.pRO_hsEG_cOMPO", "2nOcAS", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.pRO_hsEG_cOMPO", "2nOcAS", c => c.Double());
        }
    }
}
