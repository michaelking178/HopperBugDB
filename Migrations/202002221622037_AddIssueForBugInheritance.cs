namespace Hopper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIssueForBugInheritance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bugs", "IssueId", c => c.String());
            AddColumn("dbo.Bugs", "IssueStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Bugs", "IssuePriority", c => c.Int(nullable: false));
            DropColumn("dbo.Bugs", "BugId");
            DropColumn("dbo.Bugs", "BugStatus");
            DropColumn("dbo.Bugs", "BugPriority");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bugs", "BugPriority", c => c.Int(nullable: false));
            AddColumn("dbo.Bugs", "BugStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Bugs", "BugId", c => c.String());
            DropColumn("dbo.Bugs", "IssuePriority");
            DropColumn("dbo.Bugs", "IssueStatus");
            DropColumn("dbo.Bugs", "IssueId");
        }
    }
}
