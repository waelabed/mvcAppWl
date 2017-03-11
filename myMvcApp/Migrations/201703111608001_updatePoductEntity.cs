namespace myMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePoductEntity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Descrption", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Descrption", c => c.String());
        }
    }
}
