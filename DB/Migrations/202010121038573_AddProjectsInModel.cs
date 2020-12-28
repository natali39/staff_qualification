namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectsInModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SelfCheckDbs", "StaffDb_Id", "dbo.StaffDbs");
            DropIndex("dbo.SelfCheckDbs", new[] { "StaffDb_Id" });
            CreateTable(
                "dbo.DocumentDbs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                        OperationDbId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OperationDbs", t => t.OperationDbId, cascadeDelete: true)
                .Index(t => t.OperationDbId);
            
            CreateTable(
                "dbo.OperationDbs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        ModelDbId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ModelDbs", t => t.ModelDbId, cascadeDelete: true)
                .Index(t => t.ModelDbId);
            
            CreateTable(
                "dbo.ModelDbs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectDbId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectDbs", t => t.ProjectDbId, cascadeDelete: true)
                .Index(t => t.ProjectDbId);
            
            CreateTable(
                "dbo.ProjectDbs",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TrainingDbs", "ModelDb_Id", c => c.Guid());
            AddColumn("dbo.TrainingDbs", "OperationDb_Id", c => c.Guid());
            AddColumn("dbo.TrainingDbs", "ProjectDb_Id", c => c.Guid());
            CreateIndex("dbo.TrainingDbs", "ModelDb_Id");
            CreateIndex("dbo.TrainingDbs", "OperationDb_Id");
            CreateIndex("dbo.TrainingDbs", "ProjectDb_Id");
            AddForeignKey("dbo.TrainingDbs", "ModelDb_Id", "dbo.ModelDbs", "Id");
            AddForeignKey("dbo.TrainingDbs", "OperationDb_Id", "dbo.OperationDbs", "Id");
            AddForeignKey("dbo.TrainingDbs", "ProjectDb_Id", "dbo.ProjectDbs", "Id");
            DropColumn("dbo.SelfCheckDbs", "StaffDb_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SelfCheckDbs", "StaffDb_Id", c => c.Int());
            DropForeignKey("dbo.TrainingDbs", "ProjectDb_Id", "dbo.ProjectDbs");
            DropForeignKey("dbo.TrainingDbs", "OperationDb_Id", "dbo.OperationDbs");
            DropForeignKey("dbo.TrainingDbs", "ModelDb_Id", "dbo.ModelDbs");
            DropForeignKey("dbo.ModelDbs", "ProjectDbId", "dbo.ProjectDbs");
            DropForeignKey("dbo.OperationDbs", "ModelDbId", "dbo.ModelDbs");
            DropForeignKey("dbo.DocumentDbs", "OperationDbId", "dbo.OperationDbs");
            DropIndex("dbo.TrainingDbs", new[] { "ProjectDb_Id" });
            DropIndex("dbo.TrainingDbs", new[] { "OperationDb_Id" });
            DropIndex("dbo.TrainingDbs", new[] { "ModelDb_Id" });
            DropIndex("dbo.ModelDbs", new[] { "ProjectDbId" });
            DropIndex("dbo.OperationDbs", new[] { "ModelDbId" });
            DropIndex("dbo.DocumentDbs", new[] { "OperationDbId" });
            DropColumn("dbo.TrainingDbs", "ProjectDb_Id");
            DropColumn("dbo.TrainingDbs", "OperationDb_Id");
            DropColumn("dbo.TrainingDbs", "ModelDb_Id");
            DropTable("dbo.ProjectDbs");
            DropTable("dbo.ModelDbs");
            DropTable("dbo.OperationDbs");
            DropTable("dbo.DocumentDbs");
            CreateIndex("dbo.SelfCheckDbs", "StaffDb_Id");
            AddForeignKey("dbo.SelfCheckDbs", "StaffDb_Id", "dbo.StaffDbs", "Id");
        }
    }
}
