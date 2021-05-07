namespace EmployeeDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "BatchId", c => c.Int());
            AddColumn("dbo.Employees", "NominationStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "NominationStatus");
            DropColumn("dbo.Employees", "BatchId");
        }
    }
}
