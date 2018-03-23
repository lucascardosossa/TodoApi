using System;
using Microsoft.EntityFrameworkCore;
using TodoApi.Entities;

namespace TodoApi.Context
{
    public class TodoApiContext : DbContext
    {
        public TodoApiContext(DbContextOptions<TodoApiContext> options) : base(options)
        {
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<Todo> Todo
        {
            get;
            set;
        }
    }
}
