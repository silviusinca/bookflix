using Bookflix.Helpers.Attributes;
using Bookflix.Models;
using Bookflix.Models.DTOs;
using Bookflix.Models.Enums;
using Bookflix.Repositories.BookRepository;
using Bookflix.Services.BookServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookflix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("get-books")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllBooks();
            return Ok(books);
        }
        [Authorization(Role.ADMIN)]
        [HttpPost("add-book")]
        public async Task<IActionResult> Create(BookRequestDTO book)
        {
            var bookToCreate = new Book
            {
                AuthorName = book.AuthorName,
                Title = book.Title,
                Description = book.Description,
                DatePublished = book.DatePublished
            };

            await _bookService.Create(bookToCreate);
            return Ok();
        }
    }
}
