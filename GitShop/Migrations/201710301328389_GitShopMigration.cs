namespace GitShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GitShopMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Category = c.String(nullable: false, maxLength: 256),
                        Price = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        LastName = c.String(nullable: false, maxLength: 256),
                        Role = c.String(nullable: false, maxLength: 256),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Product_Id", "dbo.Products");
            DropIndex("dbo.Users", new[] { "Product_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
        }
    }
}
