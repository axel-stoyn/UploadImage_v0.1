namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddImage", "ImagePath", c => c.String());
            DropColumn("dbo.AddImage", "NamePicture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddImage", "NamePicture", c => c.String());
            DropColumn("dbo.AddImage", "ImagePath");
        }
    }
}
