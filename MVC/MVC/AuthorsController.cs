using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MVC
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        readonly AuthorService _authorService;
        public AuthorsController(AuthorService authorService)
        {
            _authorService = authorService;
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorService.GetAllAuthors();
            if(authors == null) return NotFound();
            return Ok(authors);
        }
    }
}
