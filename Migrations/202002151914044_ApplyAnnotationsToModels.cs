namespace Hopper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bugs", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Bugs", new[] { "Project_Id" });
            AddColumn("dbo.Bugs", "BugStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Bugs", "BugPriority", c => c.Int(nullable: false));
            AlterColumn("dbo.Bugs", "Project_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Code", c => c.String(nullable: false, maxLength: 4));
            CreateIndex("dbo.Bugs", "Project_Id");
            AddForeignKey("dbo.Bugs", "Project_Id", "dbo.Projects", "Id", cascadeDelete: true);
            DropColumn("dbo.Bugs", "Status");
            DropColumn("dbo.Bugs", "Priority");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bugs", "Priority", c => c.String());
            AddColumn("dbo.Bugs", "Status", c => c.String());
            DropForeignKey("dbo.Bugs", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Bugs", new[] { "Project_Id" });
            AlterColumn("dbo.Projects", "Code", c => c.String());
            AlterColumn("dbo.Projects", "Name", c => c.String());
            AlterColumn("dbo.Bugs", "Project_Id", c => c.Int());
            DropColumn("dbo.Bugs", "BugPriority");
            DropColumn("dbo.Bugs", "BugStatus");
            CreateIndex("dbo.Bugs", "Project_Id");
            AddForeignKey("dbo.Bugs", "Project_Id", "dbo.Projects", "Id");
        }
    }
}
