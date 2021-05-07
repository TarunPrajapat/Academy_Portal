namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecurityQuestionAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "SecurityQuestion", c => c.String());
            AddColumn("dbo.Admins", "SecurityQueAnswer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "SecurityQueAnswer");
            DropColumn("dbo.Admins", "SecurityQuestion");
        }
    }
}
