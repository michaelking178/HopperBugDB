namespace Hopper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepopulateProjects : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Projects (Name, Code) VALUES ('Hopper', 'HOPP')");
            Sql("INSERT INTO Projects (Name, Code) VALUES ('Vidly', 'VIDL')");
        }
        
        public override void Down()
        {
        }
    }
}
