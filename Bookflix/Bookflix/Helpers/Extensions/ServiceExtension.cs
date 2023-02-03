using Bookflix.Helpers.JwtUtils;
using Bookflix.Helpers.Seeders;
using Bookflix.Repositories.BookRepository;
using Bookflix.Repositories.ReviewRepository;
using Bookflix.Repositories.UserBookRepository;
using Bookflix.Repositories.UserInformationRepository;
using Bookflix.Repositories.UserRepository;
using Bookflix.Services.BookServices;
using Bookflix.Services.UserServices;

namespace Bookflix.Helpers.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<IUserBookRepository, UserBookRepository>();
            services.AddTransient<IUserInformationRepository, UserInformationRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBookService, BookService>();
            //services.AddTransient<IReviewService, ReviewService>();
            //services.AddTransient<IUserBookService, UserBookService>();
            //services.AddTransient<IUserInformationService, UserInformationService>();

            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddScoped<BookSeeder>();
            return services;
        }

        public static IServiceCollection AddJwtUtils(this IServiceCollection services)
        {
            services.AddScoped<IJwtUtils, JwtUtils.JwtUtils>();

            return services;
        }

    }
}
