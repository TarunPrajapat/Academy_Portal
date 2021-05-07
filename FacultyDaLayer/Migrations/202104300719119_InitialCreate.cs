namespace FacultyDaLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Dob = c.DateTime(nullable: false),
                        gender = c.Int(nullable: false),
                        Contact = c.Long(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        SecurityQuestion = c.String(),
                        SecurityQueAnswer = c.String(),
                        UserCatagory = c.Int(nullable: false),
                        skillFamily = c.Int(nullable: false),
                        ModuleName = c.String(nullable: false),
                        Proficiency = c.Int(nullable: false),
                        TeachingHours = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        RegistrationStatus = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Faculties");
        }
    }
}
