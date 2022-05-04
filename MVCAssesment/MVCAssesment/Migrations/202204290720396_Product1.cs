namespace MVCAssesment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product_Table", "Pprice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product_Table", "Pprice", c => c.Int(nullable: false));
        }
    }
}
