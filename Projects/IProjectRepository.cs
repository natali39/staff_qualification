using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public interface IProjectRepository
    {
        List<ProjectDb> GetAll();
        ProjectDb GetProject(Guid projectId);
        ProjectDb AddProject(ProjectDb projectDb);
        void UpdateProject(ProjectDb projectDb);
        void DeleteProject(ProjectDb projectDb);
        void AddModel(ModelDb modelDb, Guid projectId);
        void UpdateModel(ModelDb modelDb);
        void DeleteModel(ModelDb modelDb);
        OperationDb AddOperation(OperationDb operationDb, Guid modelId);
        void DeleteOperation(Guid operationId);
        void UpdateOperation(OperationDb operationDb);
        DocumentDb AddDocument(DocumentDb documentDb, Guid operationId);
        void DeleteDocument(DocumentDb documentDb);
    }
}
