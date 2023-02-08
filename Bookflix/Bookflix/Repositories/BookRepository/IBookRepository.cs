using Bookflix.Models;
using Bookflix.Repositories.GenericRepository;
using System.IO;

namespace Bookflix.Repositories.BookRepository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        ICollection<Book> FindByRealeaseYear(int realeaseYear);
        ICollection<Book> GetAll();
        Book FindByBookTitle(string bookTitle);
        Task<IEnumerable<IGrouping<User, Book>>> GroupUsersByBooksReviewd();
    }
}
