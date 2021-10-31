namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "Contact_ContactID", "dbo.Contacts");
            DropIndex("dbo.Headings", new[] { "Contact_ContactID" });
            DropColumn("dbo.Headings", "Contact_ContactID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "Contact_ContactID", c => c.Int());
            CreateIndex("dbo.Headings", "Contact_ContactID");
            AddForeignKey("dbo.Headings", "Contact_ContactID", "dbo.Contacts", "ContactID");
        }
    }
}
