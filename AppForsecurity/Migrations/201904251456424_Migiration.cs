namespace AppForsecurity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migiration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FullName = c.String(),
                        CertificateNumber = c.Long(nullable: false),
                        ConingTime = c.DateTime(nullable: false),
                        LeavingTime = c.DateTime(nullable: false),
                        VisitPurpose = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
        }
    }
}
