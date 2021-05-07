namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SkillMapping", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.SkillMapping", "ModuleId", "dbo.Modules");
            DropIndex("dbo.SkillMapping", new[] { "SkillId" });
            DropIndex("dbo.SkillMapping", new[] { "ModuleId" });
            DropTable("dbo.SkillMapping");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SkillMapping",
                c => new
                    {
                        SkillId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SkillId, t.ModuleId });
            
            CreateIndex("dbo.SkillMapping", "ModuleId");
            CreateIndex("dbo.SkillMapping", "SkillId");
            AddForeignKey("dbo.SkillMapping", "ModuleId", "dbo.Modules", "ModuleId", cascadeDelete: true);
            AddForeignKey("dbo.SkillMapping", "SkillId", "dbo.Skills", "Skill_ID", cascadeDelete: true);
        }
    }
}
