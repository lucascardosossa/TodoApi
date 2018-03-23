using System;
using System.Collections.Generic;

namespace TodoApi.Entities
{
    public class Response
    {
        public bool Success
        {
            get;
            set;
        }

        public List<string> Data
        {
            get;
            set;
        }

        public List<string> Error
        {
            get;
            set;
        }
    }
}
