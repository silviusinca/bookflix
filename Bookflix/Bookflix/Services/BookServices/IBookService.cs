using Bookflix.Models;

namespace Bookflix.Services.BookServices
{
    public interface IBookService
    {
        Book GetById(Guid id);
        Task Create(Book newBook);
        Task<List<Book>> GetAllBooks();
        void Delete(Book bookToDelete);
        void Update(Book bookToUpdate);
        bool Save();

    }
}
