using System;
using System.Collections.Generic;

namespace TodoApi.Entities
{
    public class Response
    {
        public Response()
        {
            Success = false;
            Data = null;
            Error = new List<string>();
        }

        public bool Success
        {
            get;
            set;
        }

        public object Data
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
