namespace PrintumCommerce.Migrations.Model1
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.pRO_hsEG_cOMPO", "pRO_hsEG_Codigo_Index");
        }
        
        public override void Down()
        {
            CreateIndex("dbo.pRO_hsEG_cOMPO", "2Codigo ", unique: true, name: "pRO_hsEG_Codigo_Index");
        }
    }
}
