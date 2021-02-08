namespace EvaluationApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebsiteDateCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WebsiteUrls", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WebsiteUrls", "DateCreated");
        }
    }
}
