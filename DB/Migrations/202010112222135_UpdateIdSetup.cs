namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelfCheckDbs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ResponsiblePersonId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TrainingDbId = c.Guid(nullable: false),
                        StaffDb_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffDbs", t => t.StaffDb_Id)
                .ForeignKey("dbo.TrainingDbs", t => t.TrainingDbId, cascadeDelete: true)
                .Index(t => t.TrainingDbId)
                .Index(t => t.StaffDb_Id);
            
            CreateTable(
                "dbo.TrainingDbs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ProjectId = c.Guid(nullable: false),
                        ModelId = c.Guid(nullable: false),
                        OperationId = c.Guid(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        StaffDbId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffDbs", t => t.StaffDbId, cascadeDelete: true)
                .Index(t => t.StaffDbId);
            
            CreateTable(
                "dbo.StaffDbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SelfCheckDbs", "TrainingDbId", "dbo.TrainingDbs");
            DropForeignKey("dbo.TrainingDbs", "StaffDbId", "dbo.StaffDbs");
            DropForeignKey("dbo.SelfCheckDbs", "StaffDb_Id", "dbo.StaffDbs");
            DropIndex("dbo.TrainingDbs", new[] { "StaffDbId" });
            DropIndex("dbo.SelfCheckDbs", new[] { "StaffDb_Id" });
            DropIndex("dbo.SelfCheckDbs", new[] { "TrainingDbId" });
            DropTable("dbo.StaffDbs");
            DropTable("dbo.TrainingDbs");
            DropTable("dbo.SelfCheckDbs");
        }
    }
}
