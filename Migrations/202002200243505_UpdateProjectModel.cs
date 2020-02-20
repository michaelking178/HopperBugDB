namespace Hopper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProjectModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Created");
        }
    }
}
