namespace FacultyDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faculties", "BatchId", c => c.Int());
            AddColumn("dbo.Faculties", "NominationStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faculties", "NominationStatus");
            DropColumn("dbo.Faculties", "BatchId");
        }
    }
}
