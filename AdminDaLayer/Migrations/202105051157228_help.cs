namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class help : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Helps",
                c => new
                    {
                        RequestId = c.Int(nullable: false),
                        Issue = c.String(nullable: false),
                        Discription = c.String(nullable: false),
                        DateOfTicket = c.DateTime(nullable: false),
                        Resolution = c.String(),
                        Status = c.String(),
                        userCategory = c.String(),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Helps");
        }
    }
}
