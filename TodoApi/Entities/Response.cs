using System;
using System.Collections.Generic;

namespace TodoApi.Entities
{
    public class Response
    {
        public Response()
        {
            Success = false;
            Data = new JsonObject("");
            Error = new List<string>();
        }

        public bool Success
        {
            get;
            set;
        }

        public JsonObject Data
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
