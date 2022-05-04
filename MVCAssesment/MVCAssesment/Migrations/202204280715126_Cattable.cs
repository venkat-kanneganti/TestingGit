namespace MVCAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cattable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category_Table",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Category_Table");
        }
    }
}
