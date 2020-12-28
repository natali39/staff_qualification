namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRelationTrainingAndProject : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TrainingDbs", "ModelDb_Id", "dbo.ModelDbs");
            DropForeignKey("dbo.TrainingDbs", "ProjectDb_Id", "dbo.ProjectDbs");
            DropIndex("dbo.TrainingDbs", new[] { "ModelDb_Id" });
            DropIndex("dbo.TrainingDbs", new[] { "ProjectDb_Id" });
            DropColumn("dbo.TrainingDbs", "ModelDb_Id");
            DropColumn("dbo.TrainingDbs", "ProjectDb_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrainingDbs", "ProjectDb_Id", c => c.Guid());
            AddColumn("dbo.TrainingDbs", "ModelDb_Id", c => c.Guid());
            CreateIndex("dbo.TrainingDbs", "ProjectDb_Id");
            CreateIndex("dbo.TrainingDbs", "ModelDb_Id");
            AddForeignKey("dbo.TrainingDbs", "ProjectDb_Id", "dbo.ProjectDbs", "Id");
            AddForeignKey("dbo.TrainingDbs", "ModelDb_Id", "dbo.ModelDbs", "Id");
        }
    }
}
