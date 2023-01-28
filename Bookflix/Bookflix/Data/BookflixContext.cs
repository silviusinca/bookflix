using Bookflix.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookflix.Data
{
    public class BookflixContext : DbContext
    {
        public BookflixContext(DbContextOptions<BookflixContext> options) : base(options) { }

        // tabele
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserInformation> UsersInformation { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }

        // relatii create
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one-to-one
            modelBuilder.Entity<User>()
                .HasOne(user => user.UserInformation)
                .WithOne(userInfo => userInfo.User)
                .HasForeignKey<UserInformation>(userInfo => userInfo.UserID);

            // one-to-many
            modelBuilder.Entity<Book>()
                .HasMany(book => book.Reviews);

            // many-to-many
            modelBuilder.Entity<UserBook>()
                .HasKey(userBook => new { userBook.UserID, userBook.BookID });

            modelBuilder.Entity<UserBook>()
                .HasOne(userBook => userBook.User)
                .WithMany(user => user.UserBooks)
                .HasForeignKey(userBook => userBook.UserID);

            modelBuilder.Entity<UserBook>()
                .HasOne(userBook => userBook.Book)
                .WithMany(books => books.UserBooks)
                .HasForeignKey(userBook => userBook.BookID);

            base.OnModelCreating(modelBuilder);
        }

    }
}
