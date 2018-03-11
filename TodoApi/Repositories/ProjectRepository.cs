using System;
using System.Collections.Generic;
using System.Linq;
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

        public  IEnumerable<Project> GetByName(string name)
        {
            return _db.Project.Where(p => p.Name.Contains(name)).ToList();
        }
    }
}
