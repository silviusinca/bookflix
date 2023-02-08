using Bookflix.Data;
using Bookflix.Models;
using Bookflix.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Bookflix.Repositories.BookRepository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookflixContext context) : base(context) { }

        public Book FindByBookTitle(string bookTitle)
        {
            return _table.FirstOrDefault(x => x.Title == bookTitle);
        }

        public ICollection<Book> FindByRealeaseYear(int realeaseYear)
        {
            var books = from b in _table
                        where b.DatePublished.Year == realeaseYear
                        select b;

            return (ICollection<Book>)books;
        }

        public ICollection<Book> GetAll()
        {
            return (ICollection<Book>)_table.Include(book => book.UserBooks);
        }

        public async Task<IEnumerable<IGrouping<User, Book>>> GroupUsersByBooksReviewd()
        {
            return (IEnumerable<IGrouping<User, Book>>) await _table.AsNoTracking().GroupBy(user => user.Reviews).ToListAsync();
        }
    }
}
