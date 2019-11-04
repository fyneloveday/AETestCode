namespace WebApps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BannerTrackingModelAndIdentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BannerTrackings",
                c => new
                    {
                        TrackingId = c.Int(nullable: false, identity: true),
                        BannerId = c.Int(nullable: false),
                        ImpressionCount = c.Int(nullable: false),
                        ClickCount = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TrackingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BannerTrackings");
        }
    }
}
