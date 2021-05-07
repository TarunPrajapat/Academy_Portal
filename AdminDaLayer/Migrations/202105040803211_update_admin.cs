namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mappings",
                c => new
                    {
                        MappingId = c.Int(nullable: false, identity: true),
                        SkillId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MappingId);
            

        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SkillMappings",
                c => new
                    {
                        SkillMappingId = c.Int(nullable: false, identity: true),
                        SkillId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillMappingId);
            
            DropTable("dbo.Mappings");
        }
    }
}
