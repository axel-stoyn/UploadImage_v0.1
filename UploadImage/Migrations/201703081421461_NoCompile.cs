namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoCompile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddImage", "Compression", c => c.String());
            AddColumn("dbo.AddImage", "Exposure", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddImage", "Exposure");
            DropColumn("dbo.AddImage", "Compression");
        }
    }
}
