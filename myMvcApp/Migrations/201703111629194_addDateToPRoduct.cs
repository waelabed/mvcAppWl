namespace myMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDateToPRoduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DateAdded");
        }
    }
}
