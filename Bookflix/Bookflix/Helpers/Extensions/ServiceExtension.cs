using Bookflix.Helpers.JwtUtils;
using Bookflix.Helpers.Seeders;

namespace Bookflix.Helpers.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<_, _>
            return services;
        }
        
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<_, _>
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
