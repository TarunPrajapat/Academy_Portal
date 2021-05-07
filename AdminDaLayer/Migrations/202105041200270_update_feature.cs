namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_feature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        BatchId = c.Int(nullable: false, identity: true),
                        SkillId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                        Technology = c.String(nullable: false),
                        FacultyId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        BatchCapacity = c.Int(nullable: false),
                        ClassroomName = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.BatchId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Batches");
        }
    }
}
