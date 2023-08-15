using CrudApp.Models;
using CrudApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CrudApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
       public IActionResult GetData(int? id)
        {
            var myTodos = _todoService.AllTask();

            if(id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }

       
    }
}
