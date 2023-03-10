using Bookflix.Data;
using Bookflix.Helpers.JwtUtils;
using Bookflix.Models;
using Bookflix.Repositories.BookRepository;

namespace Bookflix.Services.BookServices
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;
        public IUnitOfWork _unitOfWork;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Create(Book newBook)
        {
            await _bookRepository.CreateAsync(newBook);
            await _bookRepository.SaveAsync();
        }

        public async Task Delete(Book bookToDelete)
        {
            _bookRepository.Delete(bookToDelete);
            await _unitOfWork.SaveAsync();
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

        public async Task Update(Book bookToUpdate)
        {
            _bookRepository.Update(bookToUpdate);
            await _unitOfWork.SaveAsync();
        }
    }
}
