using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Repositories.Interfaces;
using TodoApi.Entities;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        protected readonly ITodoRepository _repository;
        private Response _response;

        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
            _response = new Response();
        }

        [HttpGet]
        public Response Get()
        {
            try
            {
                _response.Success = true;
                _response.Data = _repository.GetAll();
            }
            catch (Exception ex)
            {
                _response.Error.Add(ex.Message.ToString());
            }
            return _response;
        }

        [HttpGet("{id}")]
        public Response Get(int id)
        {
            try
            {
                _response.Success = true;
                _response.Data = _repository.GetById(id);
            }
            catch (Exception ex)
            {
                _response.Error.Add(ex.Message.ToString());
            }
            return _response;

        }

        [HttpPost]
        public Response Post([FromBody]Todo todo)
        {
            
            try
            {
                _response.Success = _repository.Add(todo);
            }
            catch (Exception ex)
                {
                _response.Error.Add(ex.ToString());
            }
            return _response;
        }

        [HttpPut]
        public Response Put([FromBody]Todo todo)
        {
            try
            {
                _response.Success = _repository.Update(todo);
            }
            catch (Exception ex)
            {
                _response.Error.Add(ex.Message.ToString());
            }
            return _response;
        }

        [HttpDelete("{id}")]
        public Response Delete(int id)
        {
            try
            {
                var todo = _repository.GetById(id);
                _response.Success = _repository.Remove(todo);
            }
            catch (Exception ex)
            {
                _response.Error.Add(ex.Message.ToString());
            }
            return _response;
        }

    }
}
