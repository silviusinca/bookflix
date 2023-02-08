using Bookflix.Repositories.BookRepository;
using Bookflix.Repositories.ReviewRepository;
using Bookflix.Repositories.UserBookRepository;
using Bookflix.Repositories.UserInformationRepository;
using Bookflix.Repositories.UserRepository;
using Microsoft.Data.SqlClient;

namespace Bookflix.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBookRepository BookRepository { get; set; }
        public IReviewRepository ReviewRepository { get; set; }
        public IUserBookRepository UserBookRepository { get; set; }
        public IUserInformationRepository UserInformationRepository { get; set; } 
        public IUserRepository UserRepository { get; set; }

        private BookflixContext _context { get; set; }

        public UnitOfWork(IBookRepository bookRepository, IReviewRepository reviewRepository, IUserBookRepository userBookRepository, IUserInformationRepository userInformationRepository, IUserRepository userRepository, BookflixContext context)
        {
            BookRepository = bookRepository;
            ReviewRepository = reviewRepository;
            UserBookRepository = userBookRepository;
            UserInformationRepository = userInformationRepository;
            UserRepository = userRepository;

            _context = context;
        }

        public async Task<bool> SaveAsync()
        {
             return await _context.SaveChangesAsync() != 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
