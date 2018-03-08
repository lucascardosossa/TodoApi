using System;
using TodoApi.Context;
using TodoApi.Entities;
using TodoApi.Repositories.Interfaces;

namespace TodoApi.Repositories
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(TodoApiContext db) : base(db)
        {
        }
    }
}
