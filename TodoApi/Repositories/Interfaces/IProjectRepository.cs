using System;
using System.Collections.Generic;
using TodoApi.Entities;

namespace TodoApi.Repositories.Interfaces
{
    public interface IProjectRepository : IRepositoryBase<Project>
    {
        IEnumerable<Project> GetByName(string name);
    }
}
