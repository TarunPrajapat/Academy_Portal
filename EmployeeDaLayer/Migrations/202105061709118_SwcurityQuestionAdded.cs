namespace EmployeeDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SwcurityQuestionAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "SecurityQuestion", c => c.String());
            AddColumn("dbo.Employees", "SecurityQueAnswer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "SecurityQueAnswer");
            DropColumn("dbo.Employees", "SecurityQuestion");
        }
    }
}
