namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDiscription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddImages", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddImages", "Description");
        }
    }
}
