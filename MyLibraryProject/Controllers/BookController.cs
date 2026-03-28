using Microsoft.AspNetCore.Mvc;
using MyLibraryProject.Model;

namespace MyLibraryProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly BookDbContext _context;
        private readonly IGetBooks _getBooks= new RepoBooks();

        public BookController(BookDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Model.Book>> GetBooks()
        {
            return _getBooks.GetBooks(_context).ToList();
        }
    }
}
