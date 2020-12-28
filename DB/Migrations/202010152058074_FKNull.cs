namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKNull : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DocumentDbs", "OperationDbId", "dbo.OperationDbs");
            DropForeignKey("dbo.OperationDbs", "ModelDbId", "dbo.ModelDbs");
            DropForeignKey("dbo.ModelDbs", "ProjectDbId", "dbo.ProjectDbs");
            DropIndex("dbo.DocumentDbs", new[] { "OperationDbId" });
            DropIndex("dbo.OperationDbs", new[] { "ModelDbId" });
            DropIndex("dbo.ModelDbs", new[] { "ProjectDbId" });
            AlterColumn("dbo.DocumentDbs", "OperationDbId", c => c.Guid());
            AlterColumn("dbo.OperationDbs", "ModelDbId", c => c.Guid());
            AlterColumn("dbo.ModelDbs", "ProjectDbId", c => c.Guid());
            CreateIndex("dbo.DocumentDbs", "OperationDbId");
            CreateIndex("dbo.OperationDbs", "ModelDbId");
            CreateIndex("dbo.ModelDbs", "ProjectDbId");
            AddForeignKey("dbo.DocumentDbs", "OperationDbId", "dbo.OperationDbs", "Id");
            AddForeignKey("dbo.OperationDbs", "ModelDbId", "dbo.ModelDbs", "Id");
            AddForeignKey("dbo.ModelDbs", "ProjectDbId", "dbo.ProjectDbs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ModelDbs", "ProjectDbId", "dbo.ProjectDbs");
            DropForeignKey("dbo.OperationDbs", "ModelDbId", "dbo.ModelDbs");
            DropForeignKey("dbo.DocumentDbs", "OperationDbId", "dbo.OperationDbs");
            DropIndex("dbo.ModelDbs", new[] { "ProjectDbId" });
            DropIndex("dbo.OperationDbs", new[] { "ModelDbId" });
            DropIndex("dbo.DocumentDbs", new[] { "OperationDbId" });
            AlterColumn("dbo.ModelDbs", "ProjectDbId", c => c.Guid(nullable: false));
            AlterColumn("dbo.OperationDbs", "ModelDbId", c => c.Guid(nullable: false));
            AlterColumn("dbo.DocumentDbs", "OperationDbId", c => c.Guid(nullable: false));
            CreateIndex("dbo.ModelDbs", "ProjectDbId");
            CreateIndex("dbo.OperationDbs", "ModelDbId");
            CreateIndex("dbo.DocumentDbs", "OperationDbId");
            AddForeignKey("dbo.ModelDbs", "ProjectDbId", "dbo.ProjectDbs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OperationDbs", "ModelDbId", "dbo.ModelDbs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DocumentDbs", "OperationDbId", "dbo.OperationDbs", "Id", cascadeDelete: true);
        }
    }
}
