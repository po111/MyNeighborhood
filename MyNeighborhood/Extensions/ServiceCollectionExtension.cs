using Microsoft.EntityFrameworkCore;
using MyNeighborhood.Infrastructure.Data;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {

        //public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        //{
        //    services.AddScoped<IApplicationDbRepository, ApplicationDbRepository>();

        //    return services;
        //}

        public static IServiceCollection AddAplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;

        }

    }
}
