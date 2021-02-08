namespace EvaluationApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UrlResponseStats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Date = c.DateTime(nullable: false),
                        ResponseTimeMs = c.Int(nullable: false),
                        WebsiteUrlId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WebsiteUrls", t => t.WebsiteUrlId, cascadeDelete: true)
                .Index(t => t.WebsiteUrlId);
            
            CreateTable(
                "dbo.WebsiteUrls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UrlResponseStats", "WebsiteUrlId", "dbo.WebsiteUrls");
            DropIndex("dbo.UrlResponseStats", new[] { "WebsiteUrlId" });
            DropTable("dbo.WebsiteUrls");
            DropTable("dbo.UrlResponseStats");
        }
    }
}
