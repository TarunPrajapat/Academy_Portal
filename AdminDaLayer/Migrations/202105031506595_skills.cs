namespace AdminDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ModuleId = c.Int(nullable: false, identity: true),
                        Technology = c.String(nullable: false),
                        proficiencyLevel = c.String(nullable: false),
                        executionType = c.Int(nullable: false),
                        certificationType = c.Int(nullable: false),
                        certificationName = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ModuleId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Skill_ID = c.Int(nullable: false, identity: true),
                        skillFamily = c.Int(nullable: false),
                        SkillName = c.String(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Skill_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
            DropTable("dbo.Modules");
        }
    }
}
