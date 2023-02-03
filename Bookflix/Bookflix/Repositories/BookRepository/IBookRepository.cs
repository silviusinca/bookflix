using Bookflix.Models;
using Bookflix.Repositories.GenericRepository;

namespace Bookflix.Repositories.BookRepository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        ICollection<Book> FindByRealeaseYear(int realeaseYear);
        ICollection<Book> GetAll();
        Book FindByBookTitle(string bookTitle);
    }
}
