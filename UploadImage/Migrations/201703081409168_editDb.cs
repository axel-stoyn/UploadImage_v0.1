namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editDb : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AddImage", "Image");
            DropColumn("dbo.AddImage", "Manufactures");
            DropColumn("dbo.AddImage", "Model");
            DropColumn("dbo.AddImage", "Date");
            DropColumn("dbo.AddImage", "Compression");
            DropColumn("dbo.AddImage", "ExposureTime");
            DropColumn("dbo.AddImage", "ExifVersion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddImage", "ExifVersion", c => c.Double(nullable: false));
            AddColumn("dbo.AddImage", "ExposureTime", c => c.Int(nullable: false));
            AddColumn("dbo.AddImage", "Compression", c => c.String());
            AddColumn("dbo.AddImage", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.AddImage", "Model", c => c.String());
            AddColumn("dbo.AddImage", "Manufactures", c => c.String());
            AddColumn("dbo.AddImage", "Image", c => c.Binary());
        }
    }
}
