namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompliteModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddImage", "Manufactures", c => c.String());
            AddColumn("dbo.AddImage", "Model", c => c.String());
            AddColumn("dbo.AddImage", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.AddImage", "Compression", c => c.String());
            AddColumn("dbo.AddImage", "ExposureTime", c => c.Int(nullable: false));
            AddColumn("dbo.AddImage", "ExifVersion", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddImage", "ExifVersion");
            DropColumn("dbo.AddImage", "ExposureTime");
            DropColumn("dbo.AddImage", "Compression");
            DropColumn("dbo.AddImage", "Date");
            DropColumn("dbo.AddImage", "Model");
            DropColumn("dbo.AddImage", "Manufactures");
        }
    }
}
