namespace DynamicPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDtatBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 400),
                        BrowserTitle = c.String(maxLength: 300),
                        Url = c.String(nullable: false, maxLength: 500),
                        ShortDescription = c.String(nullable: false, maxLength: 500),
                        Text = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pages");
        }
    }
}
