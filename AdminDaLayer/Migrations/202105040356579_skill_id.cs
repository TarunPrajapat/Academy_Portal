namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skill_id : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Skills',RESEED,101)");
        }
        
        public override void Down()
        {
        }
    }
}
