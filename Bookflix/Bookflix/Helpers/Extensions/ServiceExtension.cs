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
    }
}
