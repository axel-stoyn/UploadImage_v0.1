namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImageInfoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Manufactures = c.String(),
                        Model = c.String(),
                        Date = c.DateTime(nullable: false),
                        Compression = c.String(),
                        ExposureTime = c.Int(nullable: false),
                        ExifVersion = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImageInfoes");
            DropTable("dbo.AddImages");
        }
    }
}
