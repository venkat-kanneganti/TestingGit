namespace MVCAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnitTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnitTable",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.UnitId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnitTable");
        }
    }
}
