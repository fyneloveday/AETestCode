namespace WebApps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BannerTrackingForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.BannerTrackings", "BannerId");
            AddForeignKey("dbo.BannerTrackings", "BannerId", "dbo.Banners", "BannerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BannerTrackings", "BannerId", "dbo.Banners");
            DropIndex("dbo.BannerTrackings", new[] { "BannerId" });
        }
    }
}
