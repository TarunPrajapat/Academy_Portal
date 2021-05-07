namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_admin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "AssignFacultyStatus", c => c.String());
            AddColumn("dbo.Batches", "AssignedEmployees", c => c.Int());
            DropColumn("dbo.Batches", "AssignStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Batches", "AssignStatus", c => c.String());
            DropColumn("dbo.Batches", "AssignedEmployees");
            DropColumn("dbo.Batches", "AssignFacultyStatus");
        }
    }
}
