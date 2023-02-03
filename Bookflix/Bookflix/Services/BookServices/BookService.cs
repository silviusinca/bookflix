using Bookflix.Helpers.JwtUtils;
using Bookflix.Models;
using Bookflix.Repositories.BookRepository;

namespace Bookflix.Services.BookServices
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;
        public IJwtUtils _jwtUtils;

        public BookService(IBookRepository bookRepository, IJwtUtils jwtUtils)
        {
            _bookRepository = bookRepository;
            _jwtUtils = jwtUtils;
        }

        public async Task Create(Book newBook)
        {
            await _bookRepository.CreateAsync(newBook);
            await _bookRepository.SaveAsync();
        }

        public void Delete(Book bookToDelete)
        {
            _bookRepository.Delete(bookToDelete);
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAllAsync();
        }

        public Book GetById(Guid id)
        {
            return _bookRepository.FindById(id);
        }

        public bool Save()
        {
            return _bookRepository.Save();
        }

        public void Update(Book bookToUpdate)
        {
            _bookRepository.Update(bookToUpdate);
        }
    }
}
