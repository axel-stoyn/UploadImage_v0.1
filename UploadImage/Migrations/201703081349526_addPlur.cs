namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPlur : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AddImages", newName: "AddImage");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AddImage", newName: "AddImages");
        }
    }
}
