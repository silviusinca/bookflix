using Bookflix.Helpers.JwtUtils;
using Bookflix.Helpers.Seeders;
using Bookflix.Repositories.UserRepository;
using Bookflix.Services.UserServices;

namespace Bookflix.Helpers.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
        
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
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
