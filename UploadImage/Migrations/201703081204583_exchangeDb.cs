namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exchangeDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddImages", "Manufactures", c => c.String());
            AddColumn("dbo.AddImages", "Model", c => c.String());
            AddColumn("dbo.AddImages", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.AddImages", "Compression", c => c.String());
            AddColumn("dbo.AddImages", "ExposureTime", c => c.Int(nullable: false));
            AddColumn("dbo.AddImages", "ExifVersion", c => c.Double(nullable: false));
            DropTable("dbo.ImageInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ImageInfoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        Manufactures = c.String(),
                        Model = c.String(),
                        Date = c.DateTime(nullable: false),
                        Compression = c.String(),
                        ExposureTime = c.Int(nullable: false),
                        ExifVersion = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.AddImages", "ExifVersion");
            DropColumn("dbo.AddImages", "ExposureTime");
            DropColumn("dbo.AddImages", "Compression");
            DropColumn("dbo.AddImages", "Date");
            DropColumn("dbo.AddImages", "Model");
            DropColumn("dbo.AddImages", "Manufactures");
        }
    }
}
