using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MVC
{
    public class AuthorController
    {
        [ApiController]
        [Route("api/[controller]")]
        public class AuthorsController : ControllerBase
        {
            private readonly List<Authors> _authors;

            public AuthorsController()
            {
                var json = System.IO.File.ReadAllText("Resources/Authors.json");
                _authors = JsonSerializer.Deserialize<List<Authors>>(json) ?? new List<Authors>();
            }

            //[HttpGet]
            //public IActionResult GetAuthors()
            //{
                
            //}
        }
    }
    
}
