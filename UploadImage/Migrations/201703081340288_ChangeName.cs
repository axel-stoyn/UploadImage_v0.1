namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddImages", "NamePicture", c => c.String());
            DropColumn("dbo.AddImages", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddImages", "Name", c => c.String());
            DropColumn("dbo.AddImages", "NamePicture");
        }
    }
}
