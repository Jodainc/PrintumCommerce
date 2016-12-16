namespace PrintumCommerce.Migrations.DBPrintumContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class End : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "troll", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "troll");
        }
    }
}
