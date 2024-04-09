using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Model;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {

        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTasks")]
        public IEnumerable<ClassLibrary.Model.Task> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ClassLibrary.Model.Task
            {
                deadline = new DateTime(2024,4,3),
                name = "Task" + index.ToString(),
                description = "Description"
            })
            .ToArray();
        }
    }
}
