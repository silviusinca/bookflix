using Bookflix.Models;

namespace Bookflix.Services.BookServices
{
    public interface IBookService
    {
        Book GetById(Guid id);
        Task Create(Book newBook);
        Task<List<Book>> GetAllBooks();
        Task Delete(Book bookToDelete);
        Task Update(Book bookToUpdate);
        bool Save();

    }
}
