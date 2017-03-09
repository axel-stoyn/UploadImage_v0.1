namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Complite : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddImage", "Intime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddImage", "Intime");
        }
    }
}
