using System;
using System.Collections.Generic;

namespace TodoApi.Entities
{
    public class ResultProject
    {
        public IEnumerable<Project> Results
        {
            get;
            set;
        }
    }
}
