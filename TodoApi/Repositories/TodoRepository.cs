using TodoApi.Context;
using TodoApi.Entities;
using TodoApi.Repositories.Interfaces;

namespace TodoApi.Repositories
{
    public class TodoRepository : RepositoryBase<Todo>, ITodoRepository
    {
        public TodoRepository(TodoApiContext context) : base(context)
        {
        }
    }
}
