using System;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
