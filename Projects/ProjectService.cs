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

        public void AddProject(Project project)
        {
            var projectDb = ToProjectDb(project);
            repository.Add(projectDb);
        }

        public void DeleteProject(Project project)
        {
            var projectDb = ToProjectDb(project);
            repository.Delete(projectDb);
        }

        public void UpdateProject(Project project)
        {
            var projectDb = ToProjectDb(project);
            repository.Update(projectDb);
        }

        private List<Project> ConvertToProjects(List<ProjectDb> projectsDb)
        {
            var projects = new List<Project>();
            foreach (var projectDb in projectsDb)
            {
                var project = ToProjects(projectDb);
                projects.Add(project);
            }
            return projects;
        }

        private Project ToProjects(ProjectDb projectDb)
        {
            var project = new Project();
            project.ID = projectDb.ID;
            project.Name = projectDb.Name;
            project.Models = ToModels(projectDb.Models);
            return project;
        }

        private List<Model> ToModels(List<ModelDb> modelsDb)
        {
            var models = new List<Model>();
            foreach(var modelDb in modelsDb)
            {
                var model = new Model();
                model.ID = modelDb.ID;
                model.Name = modelDb.Name;
                model.Operations = ToOperations(modelDb.Operations);
                models.Add(model);
            }
            return models;
        }

        private List<Operation> ToOperations(List<OperationDb> operationsDb)
        {
            var operations = new List<Operation>();
            foreach (var operationDb in operationsDb)
            {
                var operation = new Operation();
                operation.ID = operationDb.ID;
                operation.Name = operationDb.Name;
                operation.Documents = ToDocuments(operationDb.Documents);
                operations.Add(operation);
            }
            return operations;
        }

        private List<Document> ToDocuments(List<DocumentDb> documentsDb)
        {
            var documents = new List<Document>();
            foreach (var documentDb in documentsDb)
            {
                var document = new Document();
                document.Name = documentDb.Name;
                document.Path = documentDb.Path;
                documents.Add(document);
            }
            return documents;
        }

        private ProjectDb ToProjectDb(Project project)
        {
            var projectDb = new ProjectDb();
            projectDb.ID = project.ID;
            projectDb.Name = project.Name;
            projectDb.Models = ToModelsDb(project.Models);
            return projectDb;
        }

        private List<ModelDb> ToModelsDb(List<Model> models)
        {
            var modelsDb = new List<ModelDb>();
            foreach (var model in models)
            {
                var modelDb = new ModelDb();
                modelDb.ID = model.ID;
                modelDb.Name = model.Name;
                modelDb.Operations = ToOperationsDb(model.Operations);
                modelsDb.Add(modelDb);
            }
            return modelsDb;
        }

        private List<OperationDb> ToOperationsDb(List<Operation> operations)
        {
            var operationsDb = new List<OperationDb>();
            foreach (var operation in operations)
            {
                var operationDb = new OperationDb();
                operationDb.ID = operation.ID;
                operationDb.Name = operation.Name;
                operationDb.Documents = ToDocumentsDb(operation.Documents);
                operationsDb.Add(operationDb);
            }
            return operationsDb;
        }

        private List<DocumentDb> ToDocumentsDb(List<Document> documents)
        {
            var documentsDb = new List<DocumentDb>();
            foreach (var document in documents)
            {
                var documentDb = new DocumentDb();
                documentDb.Name = document.Name;
                documentDb.Path = document.Path;
                documentsDb.Add(documentDb);
            }
            return documentsDb;
        }
    }
}
