namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotComp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AddImage", "Date");
            DropColumn("dbo.AddImage", "Compression");
            DropColumn("dbo.AddImage", "ExposureTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddImage", "ExposureTime", c => c.Int(nullable: false));
            AddColumn("dbo.AddImage", "Compression", c => c.String());
            AddColumn("dbo.AddImage", "Date", c => c.DateTime(nullable: false));
        }
    }
}
