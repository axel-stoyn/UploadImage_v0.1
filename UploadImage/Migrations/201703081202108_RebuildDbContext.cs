namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RebuildDbContext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImageInfoes", "Name", c => c.String());
            AddColumn("dbo.ImageInfoes", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImageInfoes", "Description");
            DropColumn("dbo.ImageInfoes", "Name");
        }
    }
}
