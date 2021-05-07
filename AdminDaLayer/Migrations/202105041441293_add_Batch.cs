namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Batch : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "AssignStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Batches", "AssignStatus");
        }
    }
}
