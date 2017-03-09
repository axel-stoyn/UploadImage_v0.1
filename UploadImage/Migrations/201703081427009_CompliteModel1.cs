namespace UploadImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompliteModel1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AddImage", "Intime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddImage", "Intime", c => c.DateTime(nullable: false));
        }
    }
}
