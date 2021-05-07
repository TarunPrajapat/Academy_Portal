namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class module_id : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Modules',RESEED,1001)");
        }
        
        public override void Down()
        {
        }
    }
}
