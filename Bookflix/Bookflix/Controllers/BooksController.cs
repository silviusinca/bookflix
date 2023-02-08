using Bookflix.Helpers.Attributes;
using Bookflix.Models;
using Bookflix.Models.DTOs;
using Bookflix.Models.Enums;
using Bookflix.Services.BookServices;
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

        [Authorization(Role.ADMIN, Role.USER)]
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
        [Authorization(Role.ADMIN, Role.USER)]
        [HttpPut("update/{id}")]
        public IActionResult UpdateBook(Guid id, BookRequestDTO book)
        {
            var bookToUpdate = _bookService.GetById(id);
            if (book == null)
            {
                return BadRequest("The book ID was not found!");
            }

            bookToUpdate.AuthorName = book.AuthorName;
            bookToUpdate.Title = book.Title;
            bookToUpdate.Description = book.Description;
            bookToUpdate.DatePublished = book.DatePublished;
            _bookService.Save();

            return Ok();
        }
        [Authorization(Role.ADMIN)]
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            var bookToDelete = _bookService.GetById(id);
            if (bookToDelete == null)
            {
                return BadRequest("The book ID was not found!");
            }
            _bookService.Delete(bookToDelete);
            _bookService.Save();
            return Ok();
        }
    }
}
