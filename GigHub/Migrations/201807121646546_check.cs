namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Notifications", "DateTime");
            DropColumn("dbo.Notifications", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Notifications", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
