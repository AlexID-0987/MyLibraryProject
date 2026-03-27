using Microsoft.AspNetCore.Mvc;
using MyLibraryProject.Model;

namespace MyLibraryProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly BookDbContext _context;

        public BookController(BookDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Model.Book>> GetBooks()
        {
            return _context.Books.ToList();
        }
    }
}
