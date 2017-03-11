namespace myMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmailToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Email");
        }
    }
}
