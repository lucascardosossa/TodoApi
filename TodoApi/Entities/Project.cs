using System;
using System.Collections.Generic;

namespace TodoApi.Entities
{
    public class Project
    {
        public int ProjectId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public List<Todo> Todos
        {
            get;
            set;
        }
    }
}
