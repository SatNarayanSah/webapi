using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentName = {
                "John Doe",
                "Jane Smith",
                "Alice Johnson",
                "Bob Brown"
            };

            return Ok(studentName);
        }
    }
}
