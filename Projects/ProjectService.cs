using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class ProjectService
    {
        private readonly IProjectRepository repository;

        public ProjectService(IProjectRepository repository)
        {
            this.repository = repository;
        }

        public List<Project> GetData()
        {
            var projectsDb = repository.GetAll();
            return ConvertToProjects(projectsDb);
        }

        public Project GetProject(Guid projectId)
        {
            var projectDb = repository.GetProject(projectId);
            return ToProject(projectDb);
        }

        public Project AddProject(Project project)
        {
            var projectDb = ToProjectDb(project);
            var projectDbWithId = repository.AddProject(projectDb);
            return ToProject(projectDbWithId);
        }

        public void DeleteProject(Project project)
        {
            var projectDb = ToProjectDb(project);
            repository.DeleteProject(projectDb);
        }

        public void UpdateProject(Project project)
        {
            var projectDb = ToProjectDb(project);
            repository.UpdateProject(projectDb);
        }

        public void AddModel(Model model, Guid projectId)
        {
            var modelDb = ToModelDb(model);
            repository.AddModel(modelDb, projectId);
        }

        public void DeleteModel(Model model)
        {
            var modelDb = ToModelDb(model);
            repository.DeleteModel(modelDb);
        }

        public Operation AddOperation(Operation operation, Guid modelId)
        {
            var operationDb = ToOperationDb(operation);
            return ToOperation(repository.AddOperation(operationDb, modelId));
        }

        public void DeleteOperation(Guid operationId)
        {
            repository.DeleteOperation(operationId);
        }

        public void UpdateOperation(Operation operation)
        {
            var operationDb = ToOperationDb(operation);
            repository.UpdateOperation(operationDb);
        }

        public Document AddDocument(Document document, Guid operationId)
        {
            var documentDb = ToDocumentDb(document);
            documentDb = repository.AddDocument(documentDb, operationId);
            return ToDocument(documentDb);
        }

        public void DeleteDocument(Document document)
        {
            var documentDb = ToDocumentDb(document);
            repository.DeleteDocument(documentDb);
        }

        private List<Project> ConvertToProjects(List<ProjectDb> projectsDb)
        {
            var projects = new List<Project>();
            if (projectsDb == null)
                return projects;
            foreach (var projectDb in projectsDb)
            {
                var project = ToProject(projectDb);
                projects.Add(project);
            }
            return projects;
        }

        private Project ToProject(ProjectDb projectDb)
        {
            var project = new Project();
            project.ID = projectDb.Id;
            project.Name = projectDb.Name;
            project.Models = new List<Model>();
            foreach (var modelDb in projectDb.Models)
            {
                var model = ToModel(modelDb);
                project.Models.Add(model);
            }
            return project;
        }

        private Model ToModel(ModelDb modelDb)
        {
            var model = new Model();
            model.ID = modelDb.Id;
            model.Name = modelDb.Name;
            model.Operations = new List<Operation>();
            foreach (var operationDb in modelDb.Operations)
            {
                var operation = ToOperation(operationDb);
                model.Operations.Add(operation);
            }
            return model;
        }

        private Operation ToOperation(OperationDb operationDb)
        {
            var operation = new Operation();
            operation.ID = operationDb.Id;
            operation.Name = operationDb.Name;
            operation.Documents = new List<Document>();
            foreach (var documentDb in operationDb.Documents)
            {
                var document = ToDocument(documentDb);
                operation.Documents.Add(document);
            }
            return operation;
        }

        private Document ToDocument(DocumentDb documentDb)
        {
            var document = new Document();
            document.Name = documentDb.Name;
            document.Path = documentDb.Path;
            return document;
        }

        private ProjectDb ToProjectDb(Project project)
        {
            var projectDb = new ProjectDb();
            projectDb.Id = project.ID;
            projectDb.Name = project.Name;
            projectDb.Models = new List<ModelDb>();
            foreach (var model in project.Models)
            {
                var modelDb = ToModelDb(model);
                projectDb.Models.Add(modelDb);
            }
            return projectDb;
        }

        private ModelDb ToModelDb(Model model)
        {
            var modelDb = new ModelDb();
            modelDb.Id = model.ID;
            modelDb.Name = model.Name;
            modelDb.Operations = new List<OperationDb>();
            foreach (var operation in model.Operations)
            {
                var operationDb = ToOperationDb(operation);
                modelDb.Operations.Add(operationDb);
            }
            return modelDb;
        }

        private OperationDb ToOperationDb(Operation operation)
        {
            var operationDb = new OperationDb();
            operationDb.Id = operation.ID;
            operationDb.Name = operation.Name;
            operationDb.Documents = new List<DocumentDb>();
            foreach (var document in operation.Documents)
            {
                var documentDb = ToDocumentDb(document);
                operationDb.Documents.Add(documentDb);
            }
            return operationDb;
        }

        private DocumentDb ToDocumentDb(Document document)
        {
            var documentDb = new DocumentDb();
            documentDb.Name = document.Name;
            documentDb.Path = document.Path;
            return documentDb;
        }
    }
}
