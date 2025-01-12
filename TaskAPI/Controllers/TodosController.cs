using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private TodoService _todoService;
        public TasksController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos();

            if (id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }

        
    }
}
 