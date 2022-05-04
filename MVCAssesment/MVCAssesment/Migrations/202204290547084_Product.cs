namespace MVCAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product_Table",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(maxLength: 30),
                        CategoryId = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Pprice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.Category_Table", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.UnitTable", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.UnitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product_Table", "UnitId", "dbo.UnitTable");
            DropForeignKey("dbo.Product_Table", "CategoryId", "dbo.Category_Table");
            DropIndex("dbo.Product_Table", new[] { "UnitId" });
            DropIndex("dbo.Product_Table", new[] { "CategoryId" });
            DropTable("dbo.Product_Table");
        }
    }
}
