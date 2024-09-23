using BookStore.BL.Interfaces;
using BookStore.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService; 
        }

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return _bookService.GetBooks();
        }
    }
}
