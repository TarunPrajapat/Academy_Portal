﻿namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Admins',RESEED,100001)");
        }
        
        public override void Down()
        {
        }
    }
}
