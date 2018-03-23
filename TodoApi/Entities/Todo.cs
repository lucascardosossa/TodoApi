using System;
namespace TodoApi.Entities
{
    public class Todo
    {

        public int TodoId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public int Status
        {
            get;
            set;
        }

        public int ProjectId
        {
            get;
            set;
        }

        public Project Project
        {
            get;
            set;
        }
    

    }
}
